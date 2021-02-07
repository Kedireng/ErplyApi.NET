using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErplyAPI
{
    public enum Language
    {
        /// <summary>
        /// English
        /// </summary>
        ENG,
        /// <summary>
        /// Spanish
        /// </summary>
        SPA,
        /// <summary>
        /// German
        /// </summary>
        GER,
        /// <summary>
        /// Swedish
        /// </summary>
        SWE,
        /// <summary>
        /// Finnish
        /// </summary>
        FIN,
        /// <summary>
        /// Russian
        /// </summary>
        RUS,
        /// <summary>
        /// Estonian
        /// </summary>
        EST,
        /// <summary>
        /// Latvian
        /// </summary>
        LAT,
        /// <summary>
        /// Lithuanian
        /// </summary>
        LIT,
        /// <summary>
        /// Greek
        /// </summary>
        GRE
    }
    public enum OrderBy
    {
        NAME,
        CODE,
        PRODUCTID,
        PRICE,
        PARENTPRODUCTID,
        /// <summary>
        /// Sorts by last modification timestamp. Items that have been created but never changed yet, have a modification timestamp of 0 and are sorted at the end of the list.
        /// </summary>
        CHANGED,
        /// <summary>
        /// Sorts by creation timestamp.
        /// </summary>
        ADDED,
        CUSTOMERID,
        GROUP,
        COLORSTATUS,
        LASTCHANGED,
        NONE,
        ADDRESSID,
        DOCUMENTID,
        DATEANDNUMBER,
        CLIENTNAME,
        EMPLOYEEID
    }
    public enum OrderByDirection
    {
        /// <summary>
        /// Ascending order
        /// </summary>
        ASC,
        /// <summary>
        /// Descending order
        /// </summary>
        DESC
    }
    public class Attribute
    {
        /// <summary>
        /// Attribute name
        /// </summary>
        [JsonProperty("attributeName")]
        public string Name { get; set; }
        /// <summary>
        /// Attribute type
        /// </summary>
        [JsonProperty("attributeType")]
        public string Type { get; set; }
        /// <summary>
        /// Attribute value
        /// </summary>
        [JsonProperty("attributeValue")]
        public string Value { get; set; }
    }
    public class LongAttribute
    {
        [ErplyProperty("longAttributeName")]
        public string Name { get; set; }
        [ErplyProperty("longAttributeValue")]
        public string Value { get; set; }
    }
    public class IDItem
    {
        [JsonProperty("id")]
        public int? ID { get; set; }
    }
    public class ProductIDItem
    {
        public int? ProductID { get; set; }
    }
}
