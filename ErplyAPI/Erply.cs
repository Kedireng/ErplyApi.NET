using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using System.Net.Http;
using System.Text;
using ErplyAPI.Products;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using ErplyAPI.Company;
using System.Security;

namespace ErplyAPI
{
    /// <summary>
    /// Erply class for Erply 1.0 API. This will automatically verify user if needed.
    /// </summary>
    public class Erply : IDisposable
    {
        #region Private properties
        private HttpClient client { get; set; }
        private string sessionKey = "";
        private DateTime lastVerification = new DateTime();
        #endregion

        #region Public properties
        public int ClientCode { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ErplyUser User { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Creates a new instance of Erply class and verifies if user has access to API.
        /// </summary>
        /// <param name="clientCode">Erply client code</param>
        /// <param name="username">Erply username</param>
        /// <param name="password">Erply password</param>
        public Erply(int clientCode, string username, string password)
        {
            this.ClientCode = clientCode;
            this.Username = username;
            this.Password = password;
            client = new HttpClient() { BaseAddress = new Uri("https://" + ClientCode.ToString() + ".erply.com/api/") };
            client.Timeout = TimeSpan.FromMinutes(10);
            VerifyUser();
        }
        #endregion

        #region MakeRequests
        /// <summary>
        /// Make a Erply API request and cast it's response records into given type T.
        /// When T is not IEnumerable, then first element will be cast into type T.
        /// When that is not possible, first element's first field will be cast into type T.
        /// Request will also be validated for success.
        /// </summary>
        /// <exception cref="InvalidCastException">Call was successful, but couldn't cast response to given type.</exception>
        /// <exception cref="ErplyException">Indicates that something went wrong with call on erply side.</exception>
        /// <exception cref="HttpRequestException">Something went wrong with web request.</exception>
        /// <exception cref="ArgumentNullException">Call or call's CallName is null or empty</exception>
        /// <typeparam name="T">Type to cast response records into.</typeparam>
        /// <param name="call">Erply call to make</param>
        /// <returns>Returns erply response records as type T</returns>
        public T MakeRequest<T>(ErplyCall call)
        {
            if (call == null)
                throw new ArgumentNullException(nameof(call), "Call cannot equal null!");
            if (String.IsNullOrWhiteSpace(call.CallName))
                throw new ArgumentNullException(nameof(call.CallName), "CallName cannot be null or empty!");

            TimeSpan timeFromLastVerification = DateTime.Now.Subtract(lastVerification);
            if (timeFromLastVerification.TotalSeconds > 3600 && call.CallName != "verifyUser")
                VerifyUser();
            if (String.IsNullOrWhiteSpace(sessionKey) && call.CallName != "verifyUser")
                VerifyUser();

            var content = GetRequestContent(call);
            var response = SendContent(content);

            if ((response.Status.ErrorCode == 1054 || response.Status.ErrorCode == 1055) && call.CallName != "verifyUser")
            {
                VerifyUser();
                return MakeRequest<T>(call);
            }

            response.ValidateSuccess();

            return CastErplyResponse<T>(response);
        }
        /// <summary>
        /// Make a Erply API request and cast it's response records into given type T.
        /// When T is not IEnumerable, then first element will be cast into type T.
        /// When that is not possible, first element's first field will be cast into type T.
        /// Request will also be validated for success.
        /// </summary>
        /// <exception cref="InvalidCastException">Call was successful, but couldn't cast response to given type.</exception>
        /// <exception cref="ErplyException">Indicates that something went wrong with call on erply side.</exception>
        /// <exception cref="HttpRequestException">Something went wrong with web request.</exception>
        /// <exception cref="ArgumentNullException">Call or call's CallName is null or empty</exception>
        /// <typeparam name="T">Type to cast response records into.</typeparam>
        /// <param name="call">Erply call to make</param>
        /// <returns>Returns erply response records as type T</returns>
        public async Task<T> MakeRequestAsync<T>(ErplyCall call)
        {
            if (call == null)
                throw new ArgumentNullException(nameof(call), "Call cannot equal null!");
            if (String.IsNullOrWhiteSpace(call.CallName))
                throw new ArgumentNullException(nameof(call.CallName), "CallName cannot be null or empty!");

            TimeSpan timeFromLastVerification = DateTime.Now.Subtract(lastVerification);
            if (timeFromLastVerification.TotalSeconds > 3600 && call.CallName != "verifyUser")
                VerifyUser();
            if (String.IsNullOrWhiteSpace(sessionKey) && call.CallName != "verifyUser")
                VerifyUser();

            StringContent content = GetRequestContent(call);
            ErplyResponse response = await SendContentAsync(content);

            if ((response.Status.ErrorCode == 1054 || response.Status.ErrorCode == 1055) && call.CallName != "verifyUser")
            {
                VerifyUser();
                return await MakeRequestAsync<T>(call);
            }

            response.ValidateSuccess();

            return CastErplyResponse<T>(response);
        }
        /// <summary>
        /// Make a Erply API request and validate it's success.
        /// </summary>
        /// <exception cref="ErplyException">Indicates that something went wrong with call on erply side.</exception>
        /// <exception cref="HttpRequestException">Something went wrong with web request.</exception>        
        /// <exception cref="ArgumentNullException">Call or call's CallName is null or empty</exception>
        /// <param name="call">Erply call to make</param>
        public void MakeRequest(ErplyCall call)
        {
            if (call == null)
                throw new ArgumentNullException(nameof(call), "Call cannot equal null!");
            if (String.IsNullOrWhiteSpace(call.CallName))
                throw new ArgumentNullException(nameof(call.CallName), "CallName cannot be null or empty!");

            TimeSpan timeFromLastVerification = DateTime.Now.Subtract(lastVerification);
            if (timeFromLastVerification.TotalSeconds > 3600 && call.CallName != "verifyUser")
                VerifyUser();
            if (String.IsNullOrWhiteSpace(sessionKey) && call.CallName != "verifyUser")
                VerifyUser();

            StringContent content = GetRequestContent(call);
            ErplyResponse response = SendContent(content);

            if ((response.Status.ErrorCode == 1054 || response.Status.ErrorCode == 1055) && call.CallName != "verifyUser")
            {
                VerifyUser();
                MakeRequest(call);
                return;
            }

            response.ValidateSuccess();            
        }
        /// <summary>
        /// Make Erply API requests as a Bulk API call. When there are more than 100 calls, as many Bulk API calls will be done as needed.
        /// </summary>
        /// <param name="calls">Erply calls to make</param>
        /// <exception cref="ErplyException">Indicates that something went wrong with call on erply side.</exception>
        /// <exception cref="HttpRequestException">Something went wrong with web request.</exception>
        /// <exception cref="ArgumentNullException">Call or call's CallName is null or empty</exception>
        /// <returns>Returns a list of all gotten responses</returns>
        public List<ErplyResponse> MakeBulkRequest(List<ErplyCall> calls)
        {
            TimeSpan timeFromLastVerification = DateTime.Now.Subtract(lastVerification);
            if (timeFromLastVerification.TotalSeconds > 3600)
                VerifyUser();
            if (String.IsNullOrWhiteSpace(sessionKey))
                VerifyUser();

            if (calls.Count > 100)
            {
                List<ErplyCall> tempCalls = new List<ErplyCall>();
                int i = 0;
                List<ErplyResponse> responses = new List<ErplyResponse>();

                foreach (var call in calls)
                {
                    if (call == null)
                        throw new ArgumentNullException(nameof(call), "Call cannot equal null!");
                    if (String.IsNullOrWhiteSpace(call.CallName))
                        throw new ArgumentNullException(nameof(call.CallName), "CallName cannot be null or empty!");

                    tempCalls.Add(call);                  

                    if (tempCalls.Count == 100 || i == calls.Count)
                    {
                        try
                        {
                            responses.AddRange(MakeBulkRequest(tempCalls));
                            tempCalls.Clear();
                        }
                        catch (Exception exc)
                        {
                            int startI = (i % (100 * 10)) - (i % 100);
                            throw new Exception("Something went wrong with erply calls between " + startI + "-" + (startI + 100).ToString(), exc);
                        }
                    }
                    i++;
                }

                return responses;
            }
            else
            {
                var content = GetBulkRequestContent(calls);
                ErplyResponse response = SendContent(content);

                if (response.Status.ErrorCode == 1054 || response.Status.ErrorCode == 1055)
                {
                    VerifyUser();
                    return MakeBulkRequest(calls);
                }

                response.ValidateSuccess();

                if (response.Requests != null)
                    return response.Requests;
                else
                    throw new Exception("Erply response requests records doesn't contain any fields!");
            }
        }
        /// <summary>
        /// Make Erply API requests as a Bulk API call. When there are more than 100 calls, as many Bulk API calls will be done as needed.
        /// </summary>
        /// <param name="calls">Erply calls to make</param>
        /// <exception cref="ErplyException">Indicates that something went wrong with call on erply side.</exception>
        /// <exception cref="HttpRequestException">Something went wrong with web request.</exception>
        /// <exception cref="ArgumentNullException">Call or call's CallName is null or empty</exception>
        /// <returns>Returns a list of all gotten responses</returns>
        public async Task<List<ErplyResponse>> MakeBulkRequestAsync(List<ErplyCall> calls)
        {
            TimeSpan timeFromLastVerification = DateTime.Now.Subtract(lastVerification);
            if (timeFromLastVerification.TotalSeconds > 3600)
                VerifyUser();
            if (String.IsNullOrWhiteSpace(sessionKey))
                VerifyUser();

            if (calls.Count > 100)
            {
                List<ErplyCall> tempCalls = new List<ErplyCall>();
                int i = 0;
                List<ErplyResponse> responses = new List<ErplyResponse>();

                foreach (var call in calls)
                {
                    if (call == null)
                        throw new ArgumentNullException(nameof(call), "Call cannot equal null!");
                    if (String.IsNullOrWhiteSpace(call.CallName))
                        throw new ArgumentNullException(nameof(call.CallName), "CallName cannot be null or empty!");

                    tempCalls.Add(call);
                    i++;

                    if (tempCalls.Count == 100 || i == calls.Count)
                    {
                        try
                        {
                            responses.AddRange(MakeBulkRequest(tempCalls));
                            tempCalls.Clear();
                        }
                        catch (Exception exc)
                        {
                            int startI = (i % (100 * 10)) - (i % 100);
                            throw new Exception("Something went wrong with erply calls between " + startI + "-" + startI + 100, exc);
                        }
                    }
                }

                return responses;
            }
            else
            {
                var content = GetBulkRequestContent(calls);
                var response = SendContent(content);

                if (response.Status.ErrorCode == 1054 || response.Status.ErrorCode == 1055)
                {
                    VerifyUser();
                    return await MakeBulkRequestAsync(calls);
                }

                response.ValidateSuccess();

                if (response.Requests != null)
                    return response.Requests;
                else
                    throw new Exception("Erply response requests records doesn't contain any fields!");
            }
        }
        #endregion

        #region MakeRequests logic
        /// <summary>
        /// Turns calls into a StringContent, which can be sent to Erply API.
        /// </summary>
        /// <param name="calls">Erply requests to wrap into bulk request</param>
        /// <returns>Returns StringContent ready to send to Erply API.</returns>
        private StringContent GetBulkRequestContent(List<ErplyCall> calls)
        {
            JArray jsonObjects = new JArray();

            foreach (var call in calls)
            {
                if (call == null)
                    throw new ArgumentNullException(nameof(call), "Call cannot equal null!");
                if (String.IsNullOrWhiteSpace(call.CallName))
                    throw new ArgumentNullException(nameof(call.CallName), "CallName cannot be null or empty!");

                Dictionary<string, string> dict = new Dictionary<string, string>();

                dict["requestName"] = call.CallName;
                if (call.CallID.HasValue) dict["requestID"] = call.CallID.Value.ToString();

                var callDict = call.ToKeyValue().ToDictionary(k => k.Key, v => v.Value);
                if (callDict != null && callDict.Count != 0)
                    foreach (var kv in callDict)
                        dict.Add(kv.Key, kv.Value);
                if (call.InputParameters != null)
                    foreach (var kv in call.InputParameters)
                        dict.Add(kv.Key, kv.Value);

                jsonObjects.Add(CreateJsonObject(dict));
            }

            Dictionary<string, string> inputParams = new Dictionary<string, string>();
            inputParams.Add("sessionKey", sessionKey);
            inputParams.Add("clientCode", ClientCode.ToString());
            inputParams.Add("version", "1.0");
            inputParams.Add("requests", JsonConvert.SerializeObject(jsonObjects));

            var encodedItems = inputParams.Select(i => HttpUtility.UrlEncode(i.Key) + "=" + HttpUtility.UrlEncode(i.Value));
            string httpString = String.Join("&", encodedItems);
            return new StringContent(httpString, null, "application/x-www-form-urlencoded");
        }
        /// <summary>
        /// Turns call into a StringContent, which can be sent to Erply API.
        /// </summary>
        /// <param name="call">Erply request which will be made</param>
        /// <returns>Returns StringContent ready to send to Erply API.</returns>
        private StringContent GetRequestContent(ErplyCall call)
        {
            var inputParams = call.ToKeyValue().ToDictionary(k => k.Key, v => v.Value);
            if (call.InputParameters != null)
                foreach (var kv in call.InputParameters)
                    inputParams.Add(kv.Key, kv.Value);

            inputParams["request"] = call.CallName;
            if (!String.IsNullOrWhiteSpace(sessionKey) && call.CallName != "verifyUser")
                inputParams["sessionKey"] = sessionKey;
            inputParams["clientCode"] = ClientCode.ToString();
            inputParams["version"] = "1.0";

            var encodedItems = inputParams.Select(i => HttpUtility.UrlEncode(i.Key) + "=" + HttpUtility.UrlEncode(i.Value));
            string httpString = String.Join("&", encodedItems);
            return new StringContent(httpString, null, "application/x-www-form-urlencoded");
        }
        /// <summary>
        /// Sends requests content to Erply API and converts response into ErplyResponse.
        /// </summary>
        /// <exception cref="HttpRequestException">Something went wrong with web request.</exception>
        /// <exception cref="ErplyException">Something was wrong with Erply's response.</exception>
        /// <param name="content">Content to send to Erply API</param>
        /// <returns>Returns Erply's response as ErplyResponse.</returns>
        private ErplyResponse SendContent(StringContent content)
        {
            string response;

            try
            {
                HttpResponseMessage result = client.PostAsync("", content).Result;
                result.EnsureSuccessStatusCode();
                response = result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception exc)
            {
                throw new HttpRequestException("Something went wrong with web request. Maybe Erply API is down or you're not connected to internet?", exc);
            }

            if (String.IsNullOrWhiteSpace(response) || response == "null")
                throw new ErplyException("Erply response was empty.");

            ErplyResponse erplyResponse;
            try
            {
                erplyResponse = JsonConvert.DeserializeObject<ErplyResponse>(response, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore, Converters = new List<JsonConverter> { new FloatConverter() } });
            }
            catch (Exception exc)
            {
                throw new ErplyException("Erply response was in wrong format.", exc);
            }

            return erplyResponse;
        }
        /// <summary>
        /// Sends requests content to Erply API and converts response into ErplyResponse as an asynchronous operation.
        /// </summary>
        /// <exception cref="HttpRequestException">Something went wrong with web request.</exception>
        /// <exception cref="ErplyException">Something was wrong with Erply's response.</exception>
        /// <param name="content">Content to send to Erply API</param>
        /// <returns>Returns Erply's response as ErplyResponse.</returns>
        private async Task<ErplyResponse> SendContentAsync(StringContent content)
        {
            string response;

            try
            {
                HttpResponseMessage result = await client.PostAsync("", content);
                result.EnsureSuccessStatusCode();
                response = await result.Content.ReadAsStringAsync();
            }
            catch (Exception exc)
            {
                throw new HttpRequestException("Something went wrong with web request. Maybe Erply API is down or you're not connected to internet?", exc);
            }

            if (String.IsNullOrWhiteSpace(response) || response == "null")
                throw new ErplyException("Erply response was empty.");

            ErplyResponse erplyResponse;
            try
            {
                erplyResponse = JsonConvert.DeserializeObject<ErplyResponse>(response, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore, Converters = new List<JsonConverter> { new FloatConverter() } });
            }
            catch (Exception exc)
            {
                throw new ErplyException("Erply response was in wrong format.", exc);
            }

            return erplyResponse;
        }
        private T CastErplyResponse <T>(ErplyResponse response)
        {
            if (typeof(T) == typeof(ErplyResponse))
                return (T)Convert.ChangeType(response, typeof(T));

            if (response.Records != null)
            {
                try
                {
                    return response.Records.ToObject<T>();
                }
                catch(Exception exc)
                {
                    try
                    {
                        return response.Records[0].ToObject<T>();
                    }
                    catch
                    {
                        try
                        {
                            return response.Records[0].First().ToObject<T>();
                        }
                        catch
                        {
                            throw new InvalidCastException("Couldn't cast request response into " + typeof(T).FullName);
                        }
                    }
                }
            }
            else
                throw new Exception("Erply response records doesn't contain any fields!");
        }
        #endregion

        #region Helper public methods
        /// <summary>
        /// Fetch all items from erply with given settings. Settings has to have 'RecordsOnPage' and 'PageNo' properties.
        /// </summary>
        /// <typeparam name="T">Type which gotten items will be converted into</typeparam>
        /// <param name="settings">Call settings which will be used</param>
        /// <returns>Returns a list of all found items</returns>
        public List<T> FetchAll<T>(ErplyCall settings)
        {
            List<ErplyResponse> responses = new List<ErplyResponse>();
            int n = 1;

            if (!settings.HasProperty("RecordsOnPage") || !settings.HasProperty("PageNo"))
                throw new ArgumentException("Settings has to have 'RecordsOnPage' and 'PageNo' properties to fetch all items!");

            Type settingsType = settings.GetType();
            var call = (ErplyCall)settings.Clone();
            settingsType.GetProperty("RecordsOnPage").SetValue(call, 100, null);
            settingsType.GetProperty("PageNo").SetValue(call, 1, null);

            responses.Add(MakeRequest<ErplyResponse>(call));

            if(responses[0].Status.RecordsTotal.Value > 100)
            {
                int count = responses[0].Status.RecordsTotal.Value - 100;
                while (count > 0)
                {
                    List<ErplyCall> calls = new List<ErplyCall>();

                    double y = count / 100d;
                    var pow = Math.Pow(10, 0);
                    int c = (int)(Math.Truncate(y * pow) / pow) + 2;

                    for (int i = 2; i <= c; i++)
                    {
                        Type settingsType1 = settings.GetType();
                        var call1 = (ErplyCall)settings.Clone();
                        settingsType1.GetProperty("RecordsOnPage").SetValue(call1, 100, null);
                        settingsType1.GetProperty("PageNo").SetValue(call1, i + ((n - 1) * 100), null);

                        calls.Add(call1);
                    }

                    List<ErplyResponse> gottenResponses = MakeBulkRequest(calls);

                    gottenResponses.ForEach(x => x.ValidateSuccess());

                    responses.AddRange(gottenResponses);
                    count -= gottenResponses.Count * 100;
                }
            }

            List<T> items = new List<T>();

            foreach (var response in responses)
                items.AddRange(response.Records.ToObject<List<T>>());

            return items;
        }
        public void VerifyUser()
        {
            try
            {
                User = this.VerifyUser(new VerifyUserSettings()
                {
                    Username = this.Username,
                    Password = this.Password
                });
                sessionKey = User.SessionKey;
            }
            catch (Exception exc)
            {

                throw new ErplyException("Couldn't verify Erply user.", exc);
            }

            lastVerification = DateTime.Now;
        }
        public void Dispose()
        {
            client?.Dispose();
        }
        #endregion

        #region Main call conversion logic
        /// <summary>
        /// Main logic for creating parameters for erply call. Returns object's properties as Dictionary where property's first char is lowered.
        /// </summary>
        /// <returns>Returns dictionary where key is property name or gotten name according to json attributes and erply attributes and value is property value or gotten value according to json attributes and erply attributes</returns>
        public static IDictionary<string, string> ToKeyValue(object source, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance)
        {
            // Get all basic properties and convert them to string
            var allProperties = source.GetType().GetProperties(bindingAttr);
            var dict = allProperties.Where(x => x.CustomAttributes.Count() == 0).ToDictionary
            (
                propInfo => propInfo.Name,
                propInfo => propInfo.GetValue(source, null) != null ? propInfo.GetValue(source, null).ToString() : null
            ).Where(x => x.Value != null).ToDictionary(k => k.Key, v => v.Value);

            // Get all properties with json attributes and convert them to dictionary using Newtonsoft.Json
            try
            {
                var settings = new JsonSerializerSettings()
                {
                    ContractResolver = new IgnoreNonJsonPropertiesResolver(),
                    Converters = new List<JsonConverter>() { new FloatConverter() },
                    NullValueHandling = NullValueHandling.Ignore
                };
                var json = JsonConvert.SerializeObject(source, settings);
                var obj = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                foreach (var kv in obj)
                    if(!String.IsNullOrWhiteSpace(kv.Value))
                        dict.Add(kv.Key, kv.Value);
            }
            catch(Exception exc) {  }

            var tempDict = new Dictionary<string, string>();
            foreach (var kv in dict)
                tempDict.Add(kv.Key.First().ToString().ToLower() + kv.Key.Substring(1), kv.Value);
            dict = tempDict;

            // Get all properties with erply attributes and convert them to dictionary using their attributes
            foreach (var property in allProperties.Where(x => x.IsDefined(typeof(ErplyConverterAttribute)) || x.IsDefined(typeof(ErplyPropertyAttribute))))
            {
                var converterData = property.GetCustomAttribute(typeof(ErplyConverterAttribute), false);
                var propertyAttribute = property.GetCustomAttribute(typeof(ErplyPropertyAttribute), false);
                var propertyValue = property.GetValue(source, null);
                string propertyName = property.Name;
                bool firstCharToLower = true;
                if (propertyAttribute != null)
                {
                    propertyName = ((ErplyPropertyAttribute)propertyAttribute).PropertyName;
                    firstCharToLower = false;
                }

                if (converterData != null)
                {
                    var converter = (ErplyConverter)Activator.CreateInstance(((ErplyConverterAttribute)converterData).ConverterType);

                    var propertyValueType = propertyValue != null ? propertyValue.GetType() : null;
                    if (propertyValue != null && converter.CanConvert(propertyValueType))
                    {
                        if (propertyValue.GetType().GetInterfaces().Contains(typeof(System.Collections.IEnumerable)) && propertyValue.GetType() != typeof(string) && !converter.EnumerableReturnsValue)
                        {
                            foreach (var kv in converter.GetValues(propertyValue))
                                dict.Add(kv.Key, kv.Value);
                        }
                        else if (!propertyValue.GetType().Namespace.StartsWith("System") && !converter.EnumerableReturnsValue)
                        {
                            foreach (var kv in ToKeyValue(propertyValue))
                                dict.Add(kv.Key, kv.Value);
                        }
                        else
                            dict.Add(firstCharToLower ?propertyName.First().ToString().ToUpper() + propertyName.Substring(1) : propertyName, converter.GetValue(propertyValue));
                    }
                }
                else if (propertyAttribute != null && propertyValue != null)
                {
                    ErplyConverter converter = new ErplyConverter();
                    if (propertyValue.GetType().GetInterfaces().Contains(typeof(System.Collections.IEnumerable)) && propertyValue.GetType() != typeof(string) && !converter.EnumerableReturnsValue)
                    {
                        foreach (var kv in converter.GetValues(propertyValue))
                            dict.Add(kv.Key, kv.Value);
                    }
                    else if (!propertyValue.GetType().Namespace.StartsWith("System") && !converter.EnumerableReturnsValue)
                    {
                        foreach (var kv in ToKeyValue(propertyValue))
                            dict.Add(kv.Key, kv.Value);
                    }
                    else
                        dict.Add(firstCharToLower ? propertyName.First().ToString().ToUpper() + propertyName.Substring(1) : propertyName, converter.GetValue(propertyValue));
                }
            }

            return dict;
        }
        private class IgnoreNonJsonPropertiesResolver : DefaultContractResolver
        {
            public IgnoreNonJsonPropertiesResolver()
            {
            }
            protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
            {
                var allProps = base.CreateProperties(type, memberSerialization);

                //Choose the properties you want to serialize/deserialize
                var props = type.GetProperties(~BindingFlags.FlattenHierarchy).Where(x =>
                (x.IsDefined(typeof(JsonArrayAttribute))
                || x.IsDefined(typeof(JsonConstructorAttribute))
                || x.IsDefined(typeof(JsonContainerAttribute))
                || x.IsDefined(typeof(JsonConverterAttribute))
                || x.IsDefined(typeof(JsonDictionaryAttribute))
                || x.IsDefined(typeof(JsonExtensionDataAttribute))
                || x.IsDefined(typeof(JsonObjectAttribute))
                || x.IsDefined(typeof(JsonPropertyAttribute)))
                && !x.IsDefined(typeof(JsonIgnoreAttribute))
                && !x.IsDefined(typeof(ErplyPropertyAttribute))
                && !x.IsDefined(typeof(ErplyConverterAttribute)));

                return allProps.Where(p => props.Any(a => a.Name == p.UnderlyingName)).ToList();
            }
        }
        private static JObject CreateJsonObject(Dictionary<string, string> properties)
        {
            var jsonString = "{";
            int i = 0;
            foreach (KeyValuePair<string, string> keyValuePair in properties)
            {
                if(keyValuePair.Value.StartsWith("["))
                    jsonString = jsonString + @"""" + keyValuePair.Key + @""":" + keyValuePair.Value + @"";
                else
                    jsonString = jsonString + @"""" + keyValuePair.Key + @""":""" + keyValuePair.Value + @"""";
                i++;
                if (properties.Count != 1 && properties.Count > i)
                    jsonString = jsonString + ",";
            }
            jsonString = jsonString + "}";

            return JsonConvert.DeserializeObject<JObject>(jsonString);
        }
        #endregion
    }
}
