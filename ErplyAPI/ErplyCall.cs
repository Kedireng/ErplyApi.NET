using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ErplyAPI
{
    public class ErplyCall
    {
        public static ErplyCall Empty => new ErplyCall();

        public ErplyCall()
        { }
        public ErplyCall(string callName) => CallName = callName;
        /// <summary>
        /// By default, API returns the whole dataset as always; but if a list of fields is specified, the records will be returned with these fields only.
        /// Unknown field names will be ignored.
        /// This feature helps to reduce the amount of data sent over the network.
        /// Please note that the filter is applied at output stage. API will still fetch each field from database, and/or calculate it, as it would usually do. Only then will API discard the fields that API client does not want to receive.
        /// Therefore, omitting a field does not make an API call execute faster, or make it possible to retrieve a million records at once. But the response sent over the network will be more compact. If an unexpectedly large response is slowing down the frontend, this optimization will help.
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<string> GetFields { get; set; }
        /// <summary>
        /// Erply request(e.g "getProducts"). These can be found at https://learn-api.erply.com/requests/
        /// </summary>
        [JsonIgnore]
        public virtual string CallName { get; set; }
        /// <summary>
        /// Custom ID assigned to call, used with bulk API calls.
        /// </summary>
        [JsonIgnore]
        public virtual string RequestId { get; set; }
        [JsonIgnore]
        public Dictionary<string, string> InputParameters { get; set; }
        /// <summary>
        /// Main logic for creating parameters for erply call. Returns object's properties as Dictionary where property's first char is lowered.
        /// </summary>
        /// <returns>Returns dictionary where key is property name or gotten name according to json attributes and erply attributes and value is property value or gotten value according to json attributes and erply attributes</returns>
        public IDictionary<string, string> ToKeyValue(BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance) => Erply.ToKeyValue(this, bindingAttr);

        /// <summary>
        /// Clones item through Json Serialization
        /// </summary>
        /// <returns>Returns newly created clone of this object</returns>
        public object Clone()
        {
            string serialized = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject(serialized, this.GetType());
        }
    }

}
