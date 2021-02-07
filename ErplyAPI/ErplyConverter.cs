using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace ErplyAPI
{
    public sealed class ErplyConverterAttribute : System.Attribute
    {

        public ErplyConverterAttribute(Type converterType)
        {
            if (converterType.IsSubclassOf(typeof(ErplyConverter)) || converterType == typeof(ErplyConverter))
                ConverterType = converterType;
            else
                throw new ArgumentException("Given type is not ErplyConverter or any of it's subclasses.");
        }

        public Type ConverterType { get; set; }
    }

    /// <summary>
    /// Erply converter base. This will be used to send calls to Erply.
    /// Defaultly converts property to string. When property is custom class, it's properties will be converted to Dictionary.
    /// Lastly when property is a IEnumerable, it's items will be converted to Dictionary, where key is item name + index, and value item value.
    /// </summary>
    public class ErplyConverter
    {
        /// <summary>
        /// If object is a enumerable and will return a string instead of dictionary.
        /// </summary>
        public virtual bool EnumerableReturnsValue => false;
        /// <summary>
        /// Get object value as a string
        /// </summary>
        /// <returns>Returns object value as a string</returns>
        public virtual string GetValue(object obj) => obj.ToString();
        /// <summary>
        /// Get IEnumerable collection items or class properties as a dictionary.
        /// </summary>
        /// <returns>Returns Dictionary where key is property name + it's index(For IEnumerables) and value is property's value as a string</returns>
        public virtual IDictionary<string, string> GetValues(object obj)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            var enumerable = obj as System.Collections.IEnumerable;

            if (enumerable != null)
            {
                int i = 1;
                foreach (var item in enumerable)
                {
                    var dic = ToKeyValue(item);

                    foreach (var kv in dic)
                    {
                        dict.Add(kv.Key + i, kv.Value);
                        i++;
                    }
                }
            }
            else
                return ToKeyValue(obj);

            return dict;
        }

        /// <summary>
        /// Check if converter is usable on given type.
        /// </summary>
        public virtual bool CanConvert(Type objectType) => true;

        /// <summary>
        /// Main logic for creating parameters for erply call. Returns object's properties as Dictionary where property's first char is lowered.
        /// </summary>
        /// <returns>Returns dictionary where key is property name or gotten name according to json attributes and erply attributes and value is property value or gotten value according to json attributes and erply attributes</returns>
        public virtual IDictionary<string, string> ToKeyValue(object source, BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance) => Erply.ToKeyValue(source, bindingAttr);
    }
}
