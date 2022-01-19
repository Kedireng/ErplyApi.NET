using System;
using System.Collections.Generic;
using System.Text;

namespace ErplyAPI
{
    public class ErplyPropertyAttribute : System.Attribute
    {
        public ErplyPropertyAttribute(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
                PropertyName = name;
            else
                throw new ArgumentNullException("Property name can't be null or white space!");
        }

        public string PropertyName { get; set; }
    }

    public class ErplyNullPropertyAttribute : System.Attribute
    {
        /// <summary>
        /// Value to use if property value is null. (Can also be null)
        /// </summary>
        /// <param name="value">Value to use</param>
        public ErplyNullPropertyAttribute(string value)
        {
            PropertyValue = value;
        }

        public string PropertyValue { get; set; }
    }
}
