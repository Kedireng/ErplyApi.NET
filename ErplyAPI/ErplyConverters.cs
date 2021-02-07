using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ErplyAPI.Converters
{
    /// <summary>
    /// Add index behind every item property name and any of it's sublist items names
    /// </summary>
    public class ListWithListConverter : ErplyConverter
    {
        public override IDictionary<string, string> GetValues(object obj)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            var enumerable = obj as System.Collections.IEnumerable;

            int i = 1;
            foreach (var item in enumerable)
            {
                string itemName = item.GetType().Name;
                Type elementType = null;
                Type[] interfaces = enumerable.GetType().GetInterfaces();

                foreach (Type inter in interfaces)
                    if (inter.IsGenericType && inter.GetGenericTypeDefinition().Equals(typeof(IEnumerable<>)))
                        elementType = inter.GetGenericArguments()[0];

                if (elementType != null)
                {
                    var elementPropertyAttribute = elementType.GetCustomAttribute(typeof(ErplyPropertyAttribute), false);
                    if (elementType.GetCustomAttribute(typeof(ErplyPropertyAttribute), false) != null)
                    {
                        itemName = ((ErplyPropertyAttribute)elementPropertyAttribute).PropertyName;
                    }
                    else
                        itemName = elementType.Name;
                }

                var itemProperties = item.GetType().GetProperties();
                foreach (var property in itemProperties)
                {
                    var propertyValue = property.GetValue(item, null);

                    if (propertyValue == null)
                        continue;

                    var propertyAttribute = property.GetCustomAttribute(typeof(ErplyPropertyAttribute), false);
                    var propertyName = property.Name;
                    bool firstCharToLower = true;
                    if (propertyAttribute != null)
                    {
                        propertyName = ((ErplyPropertyAttribute)propertyAttribute).PropertyName;
                        firstCharToLower = false;
                    }

                    bool ignoreListType = itemProperties.Count() == 1;

                    if (propertyValue as System.Collections.IEnumerable != null && !(propertyValue is string))
                    {
                        var dic = GetValues(propertyValue);

                        if (dic.Count != 0)
                        {
                            elementType = null;
                            interfaces = propertyValue.GetType().GetInterfaces();

                            foreach (Type inter in interfaces)
                                if (inter.IsGenericType && inter.GetGenericTypeDefinition().Equals(typeof(IEnumerable<>)))
                                    elementType = inter.GetGenericArguments()[0];

                            firstCharToLower = true;
                            var elementPropertyAttribute = elementType.GetCustomAttribute(typeof(ErplyPropertyAttribute), false);
                            if (elementType.GetCustomAttribute(typeof(ErplyPropertyAttribute), false) != null)
                            {
                                firstCharToLower = false;
                                propertyName = ((ErplyPropertyAttribute)elementPropertyAttribute).PropertyName;
                            }
                            else
                                propertyName = elementType.Name;

                            int ii = 1;
                            foreach (var kv in dic)
                            {
                                if (!ignoreListType)
                                {
                                    if (kv.Key.Contains("+"))
                                        dict.Add(itemName + i + (firstCharToLower ? propertyName.First().ToString().ToUpper() + propertyName.Substring(1) : propertyName) + ii + kv.Key.Substring(0, kv.Key.IndexOf("+")), kv.Value);
                                    else
                                        dict.Add(itemName + i + (firstCharToLower ? propertyName.First().ToString().ToUpper() + propertyName.Substring(1) : propertyName) + ii + kv.Key, kv.Value);
                                }
                                else
                                    dict.Add(itemName + i + kv.Key.Replace("+", ""), kv.Value);
                                ii++;
                            }
                        }
                    }
                    else
                        dict.Add((firstCharToLower ? propertyName.First().ToString().ToUpper() + propertyName.Substring(1) : propertyName) + "+" + i, GetValue(propertyValue));
                }
                i++;
            }

            StackTrace stackTrace = new StackTrace();

            if (stackTrace.GetFrame(1).GetMethod().Name != "GetValues")
            {
                Dictionary<string, string> finalDict = new Dictionary<string, string>();
                foreach (var kv in dict)
                    finalDict.Add(kv.Key.Replace("+", ""), kv.Value);
                return finalDict;
            }

            return dict;
        }
        public override bool CanConvert(Type objectType) => objectType.GetInterfaces().Contains(typeof(System.Collections.IEnumerable));
    }
    /// <summary>
    /// Add index behind every item property name
    /// </summary>
    public class ListConverter : ErplyConverter
    {
        public override IDictionary<string, string> GetValues(object obj)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            var enumerable = obj as System.Collections.IEnumerable;

            int i = 1;
            foreach (var item in enumerable)
            {
                var dic = ToKeyValue(item);

                foreach (var kv in dic)
                    dict.Add(kv.Key + i, kv.Value);                   
                i++;
            }

            return dict;
        }
        public override bool CanConvert(Type objectType) => objectType.GetInterfaces().Contains(typeof(System.Collections.IEnumerable));
    }
    /// <summary>
    /// Convert list to a comma separated string
    /// </summary>
    public class CommaSeparatedListConverter : ErplyConverter
    {
        public override bool EnumerableReturnsValue => true;

        public override string GetValue(object obj)
        {
            var enumerable = obj as System.Collections.IEnumerable;

            string s = string.Empty;
            foreach(var item in enumerable)
            {
                s = s + item.ToString() + ",";
            }
            s = s.Substring(0, s.Length - 1);

            return s;
        }
        public override bool CanConvert(Type objectType) => objectType.GetInterfaces().Contains(typeof(System.Collections.IEnumerable));
    }
}
