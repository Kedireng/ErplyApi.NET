using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErplyAPI
{
    public class ErplyItem
    {
        /// <summary>
        /// Turn object properties to dictionary<string, string>, where key is property name and value is property value.
        /// </summary>
        /// <returns>Returns Dictionary<string, string>, where key is property name and value is property value.</returns>
        public virtual IDictionary<string, string> ToKeyValue() => Erply.ToKeyValue(this);

        /// <summary>
        /// Clones item through Json Serialization
        /// </summary>
        /// <returns>Returns newly created clone of this object</returns>
        public object Clone()
        {
            string serialized = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject(serialized, this.GetType());
        }

        /// <summary>
        /// Checks if given object is equal to this one through Json Serialization
        /// </summary>
        /// <param name="obj">Object to compare this one against</param>
        /// <returns>Returns if given object is equal to this one</returns>
        public bool IsEqualTo(object obj)
        {
            if (this.GetType() != obj.GetType())
                return false;

            string thisSerialized = JsonConvert.SerializeObject(this);
            string objSerialized = JsonConvert.SerializeObject(obj);

            if (thisSerialized == objSerialized)
                return true;
            else
                return false;
        }
    }
}
