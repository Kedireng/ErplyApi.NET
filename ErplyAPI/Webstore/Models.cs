using ErplyAPI.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ErplyAPI.Webstore
{
    #region GetMatrixDimensions Settings

    public class GetMatrixDimensionsSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "getMatrixDimensions";
        public int? DimensionID { get; set; }
        /// <summary>
        /// Number of records API should return. By default 20, at most 100. 
        /// </summary>
        public int? RecordsOnPage { get; set; }
        /// <summary>
        /// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
        /// </summary>
        public int? PageNo { get; set; }
    }

    #endregion
    #region MatrixDimension

    public class MatrixDimension : ErplyItem
    {
        public int? DimensionID { get; set; }
        public string Name { get; set; }
        [ErplyConverter(typeof(ListConverter))]
        public List<MatrixDimensionVariation> Variations { get; set; }
    }
    public class MatrixDimensionVariation
    {
        public int VariationID { get; set; }
        [JsonProperty("name")]
        [ErplyProperty("valueName")]
        public string Name { get; set; }
        [JsonProperty("code")]
        [ErplyProperty("valueCode")]
        public string Code { get; set; }
        public int Order { get; set; }
    }

    #endregion
    #region SaveMatrixDimension Settings

    public class SaveMatrixDimensionSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveMatrixDimension";

        [ErplyConverter(typeof(ErplyConverter))]
        public MatrixDimension MatrixDimension { get; set; }
    }

    #endregion
    #region AddItemToMatrixDimension Settings

    public class AddItemToMatrixDimensionSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "addItemToMatrixDimension";
        /// <summary>
        /// Dimension ID. 
        /// </summary>
        public int? DimensionID { get; set; }

        [ErplyConverter(typeof(ErplyConverter))]
        public MatrixDimensionVariation MatrixDimensionVariation { get; set; }
    }

    #endregion

    #region Brand

    public class Brand : ErplyItem
    {
        public int? BrandID { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Creation time.  
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        /// <summary>
        /// Last modification time.  
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? LastModified { get; set; }
    }

    #endregion
    #region SaveBrand Settings

    public class SaveBrandSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveBrand";

        [ErplyConverter(typeof(ErplyConverter))]
        public Brand Brand { get; set; }
    }

    #endregion
}
