using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace ErplyAPI
{
    /// <summary>
    /// Convert bool to 1 or 0 and back
    /// </summary>
    public class BoolConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((bool)value) ? 1 : 0);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool isNullable = IsNullableType(objectType);

            if (reader.TokenType == JsonToken.Null)
            {
                if (!isNullable)
                    return false;
                return null;
            }

            return reader.Value.ToString() == "1";
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(bool);
        }

        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
    /// <summary>
    /// Convert DateTime to Unix timestamp and back
    /// </summary>
    public class UnixTimestampConverter : JsonConverter
    {
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue(UnixTimestampFromDateTime((DateTime)value).ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool isNullable = IsNullableType(objectType);

            if (reader.TokenType == JsonToken.Null)
            {
                if (!isNullable)
                    return _epoch;
                return null;
            }

            return reader.Value == null ? _epoch : TimeFromUnixTimestamp(long.Parse(reader.Value.ToString()));
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(DateTime);
        }

        private static DateTime TimeFromUnixTimestamp(long unixTimestamp)
        {
            long unixTimeStampInTicks = unixTimestamp * TimeSpan.TicksPerSecond;
            return new DateTime(_epoch.Ticks + unixTimeStampInTicks);
        }

        public static long UnixTimestampFromDateTime(DateTime date)
        {
            long unixTimestamp = date.Ticks - _epoch.Ticks;
            unixTimestamp /= TimeSpan.TicksPerSecond;
            return unixTimestamp;
        }

        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
    /// <summary>
    /// Convert int list to comma separated string(e.g "1,2,3") and back.
    /// Possible list types: enum, int, string
    /// </summary>
    public class CommaSeparatedStringConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null || ((IList)value).Count == 0)
                writer.WriteNull();
            if (value != null && typeof(IEnumerable<int>).IsAssignableFrom(value.GetType()) && ((IEnumerable<int>)value).Count() > 0)
                writer.WriteValue(string.Join(",", ((IEnumerable<int>)value)));
            else if (typeof(IEnumerable).IsAssignableFrom(value.GetType()) && ((IList)value)[0].GetType().IsEnum)
            {
                var array = new JArray();

                StringEnumConverter converter = new StringEnumConverter();

                using (var tempWriter = array.CreateWriter())
                {
                    foreach (var e in (IList)value)
                        converter.WriteJson(tempWriter, e, serializer);
                }

                var token = array.First;

                if (array.HasValues && value != null)
                {
                    var enumType = value.GetType();
                    token = (JValue)string.Join(", ", array.Values());
                }

                token.WriteTo(writer);
            }
            else if(typeof(IEnumerable<string>).IsAssignableFrom(value.GetType()))
                writer.WriteValue(string.Join(",", ((IEnumerable<string>)value)));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null || (reader.TokenType == JsonToken.String && String.IsNullOrWhiteSpace(reader.Value.ToString())))
            {
                return null;
            }

            if (typeof(IEnumerable<int>).IsAssignableFrom(objectType))
            {
                string[] strings = reader.Value.ToString().Split(',');
                List<int> integers = new List<int>();

                foreach (string s in strings)
                    if (int.TryParse(s, out int i))
                        integers.Add(i);

                return integers;
            }
            else if (typeof(IEnumerable<Enum>).IsAssignableFrom(objectType))
            {
                Type enumType = (Nullable.GetUnderlyingType(objectType) ?? objectType);
                var prefix = enumType.Name + "_";

                // Strip the prefix from the enum components (if any).
                var token = JToken.Load(reader);
                var array = new JArray();
                if (token.Type == JTokenType.String)
                    foreach (var s in token.ToString().Split(',').Select(s => s.Trim()).Select(s => s.StartsWith(prefix) ? s.Substring(prefix.Length) : s).ToArray())
                        array.Add((JValue)s);

                var list = (IList)Activator.CreateInstance(objectType);
                var itemType = objectType.GetGenericArguments().Single();
                StringEnumConverter converter = new StringEnumConverter();

                foreach (var s in array)
                    using (var subReader = s.CreateReader())
                    {
                        while (subReader.TokenType == JsonToken.None)
                            subReader.Read();
                        list.Add(converter.ReadJson(subReader, itemType, existingValue, serializer)); // Use base class to convert
                    }

                if (list.Count != 0)
                    return list;
            }
            else if (typeof(IEnumerable<string>).IsAssignableFrom(objectType))
            {
                return reader.Value.ToString().Split(',');
            }

            return (IList)Activator.CreateInstance(objectType);
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IEnumerable<int>).IsAssignableFrom(objectType) || typeof(IEnumerable<Enum>).IsAssignableFrom(objectType) || typeof(IEnumerable<string>).IsAssignableFrom(objectType); ;
        }

        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
    /// <summary>
    /// Convert datetime to "yyyy-MM-dd" string and back
    /// </summary>
    public class ISODateConverter : JsonConverter
    {
        private static readonly DateTime _epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((DateTime)value).ToString("yyyy-MM-dd"));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool isNullable = IsNullableType(objectType);

            if (reader.TokenType == JsonToken.Null)
            {
                if (!isNullable)
                    return _epoch;
                return null;
            }
            if (String.IsNullOrWhiteSpace(reader.Value.ToString()) || reader.Value.ToString() == "0000-00-00")
                return _epoch;
            else
                return DateTime.ParseExact(reader.Value.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(DateTime))
                return true;
            else
                return false;
        }

        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
    /// <summary>
    /// Convert datetime to "yyyy-MM-dd HH:mm:ss" string and back
    /// </summary>
    public class ISODateTimeConverter : IsoDateTimeConverter
    {
        public ISODateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }
    /// <summary>
    /// Convert TimeSpan to "HH:mm:ss" string and back
    /// </summary>
    public class ISOTimeHHmmssConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var ts = (TimeSpan)value;
            var tsString = ts.Hours + ":" + ts.Minutes + ":" + ts.Seconds;
            serializer.Serialize(writer, tsString);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<String>(reader);
            var args = value.Split(':');
            int hour = int.Parse(args[0]);
            int minute = int.Parse(args[1]);
            int second = int.Parse(args[2]);
            var time = new TimeSpan(hour, minute, second);
            return time;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?);
        }
    }
    /// <summary>
    /// Convert TimeSpan to "HH:mm" string and back
    /// </summary>
    public class ISOTimeHHmmConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var ts = (TimeSpan)value;
            var dt = new DateTime(2000, 1, 1);
            dt.Add(ts);
            var tsString = XmlConvert.ToString(dt, "HH:mm");
            serializer.Serialize(writer, tsString);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var value = serializer.Deserialize<String>(reader);
            return XmlConvert.ToTimeSpan(value);
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?);
        }
    }
    /// <summary>
    /// Convert datetime to "MM-dd" string and back
    /// </summary>
    public class ISODateMMddConverter : IsoDateTimeConverter
    {
        public ISODateMMddConverter()
        {
            base.DateTimeFormat = "MM-dd";
        }
    }
    /// <summary>
    /// Convert Bitmap to base64 string and back
    /// </summary>
    public class Base64Converter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string base64String = string.Empty;

            MemoryStream memoryStream = new MemoryStream();
            ((System.Drawing.Bitmap)value).Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

            memoryStream.Position = 0;
            byte[] byteBuffer = memoryStream.ToArray();

            memoryStream.Close();

            base64String = Convert.ToBase64String(byteBuffer);
            byteBuffer = null;
            if (!base64String.EndsWith("="))
                base64String = base64String + "=";

            writer.WriteValue("data:image/png;base64," + base64String);

            /*
            using (MemoryStream m = new MemoryStream())
            {
                ((System.Drawing.Bitmap)value).Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] imageBytes = m.ToArray();
                var base64String = Convert.ToBase64String(imageBytes, 0, imageBytes.Length);
                writer.WriteValue("data:image/jpeg;base64," + base64String);
            }
            */
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool isNullable = IsNullableType(objectType);

            if (reader.TokenType == JsonToken.Null)
            {
                if (!isNullable)
                    return new System.Drawing.Bitmap(1,1);
                return null;
            }

            byte[] imageBytes = Convert.FromBase64String(reader.Value.ToString());
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            if (objectType == typeof(System.Drawing.Image))
            {
                System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
                return image;
            }
            else
            {
                System.Drawing.Bitmap image = new System.Drawing.Bitmap(System.Drawing.Bitmap.FromStream(ms, true));
                return image;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            if (objectType == typeof(System.Drawing.Bitmap) || objectType == typeof(System.Drawing.Image))
                return true;
            else
                return false;
        }

        private bool IsNullableType(Type t)
        {
            if ((t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>)) || t.IsClass)
                return true;
            else
                return false;
        }
    }
    public class ImageMimeTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((ErplyAPI.Customers.ImageMimeType)value == ErplyAPI.Customers.ImageMimeType.GIF) ? "image/gif" : "image/jpeg");
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool isNullable = IsNullableType(objectType);

            if (reader.TokenType == JsonToken.Null)
            {
                if (!isNullable)
                    throw new JsonSerializationException();
                return null;
            }

            return reader.Value.ToString() == "image/gif" ? ErplyAPI.Customers.ImageMimeType.GIF : ErplyAPI.Customers.ImageMimeType.JPEG;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(ErplyAPI.Customers.ImageMimeType);
        }

        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }
    /// <summary>
    /// Convert a List to dictionary, where key is index of Item. 
    /// </summary>
    public class DictionaryToListConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            JObject obj = new JObject();
            var list = (IList)value;

            if (value != null && list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                    obj.Add((i + 1).ToString(), JToken.FromObject(list[i]));
                obj.WriteTo(writer);
            }
            else
                writer.WriteNull();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            bool isNullable = IsNullableType(objectType);

            var list = Activator.CreateInstance(objectType) as IList;

            if (reader.TokenType == JsonToken.StartArray)
            {
                reader.Read();
                if (reader.TokenType == JsonToken.EndArray)
                    return new Dictionary<string, string>();
                else
                    throw new JsonSerializationException("Non-empty JSON array does not make a valid Dictionary!");
            }
            else if (reader.TokenType == JsonToken.Null)
            {
                if (!isNullable)
                    return (IEnumerable)Activator.CreateInstance(objectType);
                return null;
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                reader.Read();
                while (reader.TokenType != JsonToken.EndObject)
                {
                    if (reader.TokenType != JsonToken.PropertyName)
                        throw new JsonSerializationException("Unexpected token!");
                    string key = (string)reader.Value;
                    reader.Read();
                    string item = "{";
                    if(reader.TokenType == JsonToken.StartObject)
                    {
                        reader.Read();
                        while(reader.TokenType != JsonToken.EndObject)
                        {
                            if (reader.TokenType != JsonToken.PropertyName)
                                throw new JsonSerializationException("Unexpected token!");
                            item += @"""" + (string)reader.Value + @""":""";
                            reader.Read();
                            item += reader.Value + @"""";
                            reader.Read();
                            if (reader.TokenType != JsonToken.EndObject)
                                item += ",";
                        }
                        item += "}";
                    }
                    else if (reader.TokenType != JsonToken.String)
                        throw new JsonSerializationException("Unexpected token!");
                    list.Add((JsonConvert.DeserializeObject<JToken>(item)).ToObject(list.GetType().GetGenericArguments().Single()));
                    reader.Read();
                }
                return list as IEnumerable;
            }
            else
            {
                throw new JsonSerializationException("Unexpected token!");
            }
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(IEnumerable).IsAssignableFrom(objectType);
        }

        private bool IsNullableType(Type t)
        {
            return (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>));
        }
    }

    public class FloatConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(float) || objectType == typeof(float?));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JToken token = JToken.Load(reader);
            if (token.Type == JTokenType.Float || token.Type == JTokenType.Integer)
            {
                return token.ToObject<float>();
            }
            if (token.Type == JTokenType.String)
            {
                return float.Parse(token.ToString(), System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            }
            if (token.Type == JTokenType.Null && objectType == typeof(decimal?))
            {
                return null;
            }
            throw new JsonSerializationException("Unexpected token type: " +
                                                  token.Type.ToString());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(((float)value).ToString("0.00"));
        }
    }
}
