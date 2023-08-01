using System;
using System.Collections.Generic;
using System.Drawing;

using ErplyAPI.Converters;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ErplyAPI.Products
{
    #region GetProducts Settings

    public class GetProductsSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "getProducts";

        /// <summary>
        /// Retrieve one specific product. 
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// Retrieve specific products.
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> ProductIDs { get; set; }
        /// <summary>
        /// Filter by product type.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductType? Type { get; set; }
        /// <summary>
        /// Filter by product types.
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<ProductType> Types { get; set; }
        /// <summary>
        /// This filter is for retrieving or excluding matrix variations (specific colors or sizes of a matrix product). By default, variations are included.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? IncludeMatrixVariations { get; set; }
        /// <summary>
        /// Retrieve products in this specific product group. 
        /// </summary>
        public int? GroupID { get; set; }
        /// <summary>
        /// Retrieve products in this product group, or in any of its sub-groups, sub-subgroups etc. 
        /// </summary>
        public int? GroupIDWithSubgroups { get; set; }
        /// <summary>
        /// Retrieve products in specific product groups, or in any of their sub-groups, sub-subgroups etc.
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> GroupIDsWithSubgroups { get; set; }
        /// <summary>
        /// Retrieve products in this specific category.
        /// </summary>
        public int? CategoryID { get; set; }
        /// <summary>
        /// Retrieve products in this category, or in any of its sub-categories, sub-sub-categories etc. 
        /// </summary>
        public int? CategoryIDWithSubcategories { get; set; }
        /// <summary>
        /// Retrieve products in this priority group. 
        /// </summary>
        public int? PriorityGroupID { get; set; }
        /// <summary>
        /// Retrieve products of this supplier.
        /// </summary>
        public int? SupplierID { get; set; }
        /// <summary>
        /// Retrieve products of this brand. 
        /// </summary>
        public int? BrandID { get; set; }
        /// <summary>
        /// Retrieve products that have this specific unit.
        /// </summary>
        public int? UnitID { get; set; }
        /// <summary>
        /// Retrieve products that have this VAT / tax rate set on product card.
        /// </summary>
        public int? VatrateID { get; set; }
        /// <summary>
        /// Retrieve only the variations of one specific matrix product. 
        /// </summary>
        public int? ParentProductID { get; set; }
        /// <summary>
        /// Search for a product by code, exact matches only.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Search for a product by EAN / UPC, exact matches only. 
        /// </summary>
        public string Code2 { get; set; }
        /// <summary>
        /// Search for a product by code 3, exact matches only. 
        /// </summary>
        public string Code3 { get; set; }
        /// <summary>
        /// Search for a product by supplier / manufacturer code, exact matches only. 
        /// </summary>
        public string SupplierCode { get; set; }
        /// <summary>
        /// Search for a product by code 5, exact matches only. "Extra product codes" module must be enabled. 
        /// </summary>
        public string Code5 { get; set; }
        /// <summary>
        /// Search for a product by code 6, exact matches only. "Extra product codes" module must be enabled. 
        /// </summary>
        public string Code6 { get; set; }
        /// <summary>
        /// Search for a product by code 7, exact matches only. "Extra product codes" module must be enabled. 
        /// </summary>
        public string Code7 { get; set; }
        /// <summary>
        /// Search for a product by code 8, exact matches only. "Extra product codes" module must be enabled. 
        /// </summary>
        public string Code8 { get; set; }
        /// <summary>
        /// Search for a product by name, exact matches only.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Search for a product by code. Returns all items where beginning of the code matches. 
        /// </summary>
        public string CodePrefix { get; set; }
        /// <summary>
        /// Search for a product by EAN/UPC. Returns all items where beginning of the EAN / UPC matches. 
        /// </summary>
        public string Code2Prefix { get; set; }
        /// <summary>
        /// Search for a product by code 3. Returns all items where beginning of the code matches. 
        /// </summary>
        public string Code3Prefix { get; set; }
        /// <summary>
        /// Search for a product by supplier code. Returns all items where beginning of the code matches. 
        /// </summary>
        public string SupplierCodePrefix { get; set; }
        /// <summary>
        /// Search for a product by code 5. Returns all items where beginning of the code matches. "Extra product codes" module must be enabled. 
        /// </summary>
        public string Code5Prefix { get; set; }
        /// <summary>
        /// Search for a product by code 6. Returns all items where beginning of the code matches. "Extra product codes" module must be enabled. 
        /// </summary>
        public string Code6Prefix { get; set; }
        /// <summary>
        /// Search for a product by code 7. Returns all items where beginning of the code matches. "Extra product codes" module must be enabled. 
        /// </summary>
        public string Code7Prefix { get; set; }
        /// <summary>
        /// Search for a product by code 8. Returns all items where beginning of the code matches. "Extra product codes" module must be enabled. 
        /// </summary>
        public string Code8Prefix { get; set; }
        /// <summary>
        /// Search for a product by name. Returns all items where beginning of the name matches. 
        /// </summary>
        public string NamePrefix { get; set; }
        /// <summary>
        /// If set to true, and you have supplied input parameters "seachName" or "searchNameIncrementally", API will search from anywhere within the code field, not just the beginning. 
        /// </summary>
        public bool? SearchCodeFromMiddle { get; set; }
        /// <summary>
        /// Search from product name (anywhere within the name field), product code (from the beginning), or EAN / UPC (from the beginning).
        /// </summary>
        public string SearchName { get; set; }
        /// <summary>
        /// A more optimized product search. Specify your search phrase, and API will check whether it matches product code, EAN/UPC OR product name. It is meant for cases where API should return quickly the most relevant results, but the search does not have to be exhaustive.
        /// API will also look for partial matches.
        /// When using SearchNameIncrementally, the results are not ordered and you cannot use paging(pageNo), nor specify how many results you want to retrieve.Pay no attention to the "recordsTotal" field - it returns a random large number!
        /// API tries the following search combinations:
        ///     1. Exact product code match?
        ///     2. Exact EAN/UPC match?
        ///     3. Product code or EAN beginning matches, or name contents match?
        /// </summary>
        public string SearchNameIncrementally { get; set; }
        /// <summary>
        /// Set findBestMatch = 1 and send input parameters code, code2, and/or name, each of which may contain a different search phrase. API will try to find a best exact match, trying different search combinations:
        ///     1. code, code2, name;
        ///     2. code, code2;
        ///     3. code2, name;
        ///     4. code2;
        ///     5. code, name;
        ///     6. code;
        ///     7. name.
        /// This search option is useful for importing products.You may have a product code, EAN/UPC and product name (or any combination of these) — and you want a certain answer whether this exact item already exists in ERPLY or not.
        /// Therefore, API will only return exact, not partial matches.
        /// You may also use input parameter parentProductID to find a match ONLY from among the variations of a specific matrix product.This is the only additional filter which can be combined with findBestMatch = true!
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? FindBestMatch { get; set; }
        /// <summary>
        /// Specify active = false to get archived products. (Filter status = ARCHIVED gives the same results.)
        /// Specify active = true to get all non-archived products. (Filter status = ALL_EXCEPT_ARCHIVED gives the same results.)
        /// A non-archived product can be either active, no longer ordered, or not for sale.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? Active { get; set; }
        /// <summary>
        /// Filter products by status.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductStatus? Status { get; set; }
        /// <summary>
        /// If set specified, API returns only non-stock products. Salon / SPA module must be enabled. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? NonStockProduct { get; set; }
        /// <summary>
        /// Set to true to retrieve only the frequently-used products that are displayed in POS as quick-select buttons.
        /// Each location may have different quick-select buttons.If you want the buttons for a specific store, use warehouseID input parameter. If you omit it, you will get the "default" selection.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? QuickPosProducts { get; set; }
        /// <summary>
        /// Set to true to retrieve only the products that are serial numbered gift cards. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GiftCards { get; set; }
        /// <summary>
        /// Set this flag to true to retrieve only the products that are regular (non-numbered, non-serialized) gift cards.
        /// Setting this field to false to omit regular gift cards and fetch everything else does not work.Field value 0 is equivalent to not applying the filter at all.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? RegularGiftCards { get; set; }
        /// <summary>
        /// Set to true to retrieve only the products that are displayed in webshop. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? DisplayedInWebshop { get; set; }
        /// <summary>
        /// Set to true to retrieve inventory quantities for selected products.
        /// Note that product's timestamp does not change when its inventory quantity changes. Therefore you cannot use getProducts to synchronize inventory quantitites.
        /// Omit if not needed. Retrieving quantities takes extra resources and results are returned slower.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetStockInfo { get; set; }
        /// <summary>
        /// Set to true to retrieve FIFO costs and purchase prices for selected products.
        /// Omit if not needed. Retrieving costs takes extra resources and results are returned slower.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetFIFOCost { get; set; }
        /// <summary>
        /// Set to true to retrieve more information about the beverage container that goes with this product.
        /// You will be needing this feature if shops are required to show beverage container as a separate item on invoice, and charge an additional fee for that.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetContainerInfo { get; set; }
        /// <summary>
        /// Set to true to retrieve information about the various-sized packages for this product.
        /// For each product that has packages, API will return an additional sub-structure named "productPackages". 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetPackageInfo { get; set; }
        /// <summary>
        /// Set to true to retrieve replacement products for selected products.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetReplacementProducts { get; set; }
        /// <summary>
        /// Set to true to retrieve related products for selected products.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetRelatedProducts { get; set; }
        /// <summary>
        /// Set to true to retrieve a detailed list of variations for a matrix product: product name, code, EAN / UPC, color and size for each variation. By default (without setting getMatrixVariations = true) you will only get the IDs of variation products. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetMatrixVariations { get; set; }
        /// <summary>
        /// Set to true to retrieve related files for selected products.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetRelatedFiles { get; set; }
        /// <summary>
        /// Set to true to retrieve components for selected products (if selected product is a bundle or an assembly product).  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetRecipes { get; set; }
        /// <summary>
        /// Set to true to retrieve parameters for selected products. Parameters module must be enabled. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetParameters { get; set; }
        /// <summary>
        /// Set to true to retrieve quantities of packaging materials for selected products. Packaging module must be enabled. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetPackagingMaterials { get; set; }
        /// <summary>
        /// Set to true to retrieve price list prices. You can use warehouseID parameter to retrieve product's sales price for a specific warehouse. You can use clientID parameter to retrieve product's sales price for a specific customer.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetPriceListPrices { get; set; }
        /// <summary>
        /// Set to true to retrieve a set of records detailing how price list price was received. If you specify "GetPriceCalculationSteps", input parameter "GetPriceListPrices" is required, too. This feature requires Classic back office, version 4.5.0 or newer. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetPriceCalculationSteps { get; set; }
        /// <summary>
        /// Set to true to retrieve only the products that are in first price list of a specific location. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetItemsFromFirstPriceListOnly { get; set; }
        /// <summary>
        /// Set to true retrieve sales price (VAT included) that applies to specified sales location. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetWarehouseSpecificVAT { get; set; }
        /// <summary>
        /// Set to true to retrieve only the products that are in stock at specific location. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetOnlyItemsInStock { get; set; }
        /// <summary>
        /// A filter to retrieve only sellable products, or only products that can be reordered from supplier. This filter will use product's own status, and also product's status in assortment, if an assortment has been set for the selected location.
        /// If you specify "GetProductsFor", input parameter "WarehouseID" is required, too.
        /// Cannot be used together with input parameters "Active", "Status", "AddedSince"" and "ChangedSince" . (The "Active" and "Status" filters would conflict with the logic of "GetProductsFor", and this filtered dataset is complex enough that incrementally synchronizing it is not supported.)
        /// Behavior of this filter if no assortment has been set for the selected location:
        ///     1. "SALES" will return "Active" and "No longer ordered" products.
        ///     2. "ORDERING" will return "Active" and "Not for sale" products.
        /// Behavior of the filter if the selected location has an assortment:
        ///     1. "SALES" will return only products that are present in the assortment, and whose status BOTH on product card, and in assortment, is "Active" or "No longer ordered".
        ///     2. "ORDERING" will return only products that are present in the assortment, and whose status BOTH on product card, and in assortment, is "Active" or "Not for sale".
        /// To enable the assortments module on your account, please contact customer support.This feature requires Classic back office, version 4.5.0 or newer. (This filter, however, can still be used even without the assortments module.)
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductsFor? GetProductsFor { get; set; }
        /// <summary>
        /// Specify warehouse ID to:
        ///     1. Retrieve inventory quantities of selected products only in one specific warehouse.If not set, API will return inventory quantities for every warehouse.For performance reasons, it is recommended to always set this parameter if you do not need information about all warehouses simultaneously.
        ///     2. Retrieve price list prices in one specific location.
        ///     3. Retrieve POS quick select buttons for one specific location(quickPosProducts = 1)
        /// </summary>
        public int? WarehouseID { get; set; }
        /// <summary>
        /// Customer ID (to retrieve price list prices for specified customer) 
        /// </summary>
        public int? ClientID { get; set; }
        /// <summary>
        /// IDs of selected values in product card extra field 1.
        /// </summary>
        public string ExtraField1IDs { get; set; }
        /// <summary>
        /// IDs of selected values in product card extra field 2.
        /// </summary>
        public string ExtraField2IDs { get; set; }
        /// <summary>
        /// IDs of selected values in product card extra field 3.
        /// </summary>
        public string ExtraField3IDs { get; set; }
        /// <summary>
        /// IDs of selected values in product card extra field 4.
        /// </summary>
        public string ExtraField4IDs { get; set; }
        /// <summary>
        /// Filter products by their "location in warehouse" ID.
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> LocationInWarehouseIDs { get; set; }
        /// <summary>
        /// Filter products by the value of their "location in warehouse" text field. Exact matches only. 
        /// </summary>
        public string LocationInWarehouseText { get; set; }
        /// <summary>
        /// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
        /// </summary>
        public string SearchAttributeName { get; set; }
        /// <summary>
        /// Attribute value to search for. Error 1030 will be returned if value is an array. 
        /// </summary>
        public string SearchAttributeValue { get; set; }
        /// <summary>
        /// Get products that have a specific parameter value.
        /// Example: let us assume that you have defined a parameter "Available colors", with possible options of "white", "red", yellow" and "blue". Use SearchParameterOptionID to get all items that are available in blue.
        /// Of course, to make the query, you need to know the ID of the "blue" option.
        /// </summary>
        public int? SearchParameterOptionID { get; set; }
        /// <summary>
        /// Get products that have a specific parameter ID.
        /// Example: Some product parameters are simple yes/no properties, eg. "does this product have batteries included". Assuming this parameter's ID is "456", you need to make the query SearchParameterID = 456 if you want to get all products that have batteries included.
        /// </summary>
        public int? SearchParameterID { get; set; }
        /// <summary>
        /// Get products that have a specific parameter value.
        /// Example: Some parameters have scalar values, eg.the inner diameter of a ball bearing. Assuming the parameter ID is 789, you need to make the query SearchParameterID = 789, SearchParameterValue = "1/2" if you want to get all bearings with inner diameter of 1/2". 
        /// </summary>
        public string SearchParameterValue { get; set; }
        /// <summary>
        /// Get all new items that have been added since a specific point in time.
        /// NOT RECOMMENDED.Instead, use "ChangedSince", which returns both new items and changed items.
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? AddedSince { get; set; }
        /// <summary>
        /// Get all items that have been ADDED AND/OR CHANGED since a specific point in time. Use this field for synchronizing product database. Set ChangedSince equal to the time of last successful synchronization.
        /// Some tips:
        ///     1. Use server's timestamp, eg. the one that is returned in every response header. Your clock may be different from server clock, so if you stamp the synchronization with a locally generated timestamp, you'll risk missing some updates.
        ///     2. Product's timestamp changes when product card is updated in Erply. Timestamp DOES NOT CHANGE when product's inventory quantity changes, eg. as a result of a sale, a confirmed Purchase Invoice, or a confirmed Inventory Registration.
        ///     3. For each item that GetProducts returns, check if you already have an item with that ID in your local database.If yes, update it. If not, add it as a new item.
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? ChangedSince { get; set; }
        /// <summary>
        /// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
        /// </summary>
        [JsonProperty("lang")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Language? Language { get; set; }
        /// <summary>
        /// Retrive product names in all languages. If you turn on this flag, API will return additional fields nameENG, nameGER, etc. — depending on which languages have been enabled on your account. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetAllLanguages { get; set; }
        /// <summary>
        /// 'ParentProductID', combined with orderByDir = 'asc', is useful if you need to retrieve matrix products first, followed by matrix product variations. (Matrix products have ParentProductID = 0; variations have a non-zero value.)
        /// The default value is 'changed'. 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderBy? OrderBy { get; set; }
        /// <summary>
        /// By default items are sorted in descending order. 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("orderByDir")]
        public OrderByDirection? OrderByDirection { get; set; }
        /// <summary>
        /// Number of records API should return. By default API returns 20 records.
        /// At most you can request 1000 products at a time(or only 100, if you have set GetStockInfo = 1). 
        /// </summary>
        public int? RecordsOnPage { get; set; }
        /// <summary>
        /// API returns at most RecordsOnPage items at a time. To retrive the next RecordsOnPage items, send a new request with PageNo incremented by one. By default, API returns "page 1". 
        /// </summary>
        public int? PageNo { get; set; }
        /// <summary>
        /// As an alternative to PageNo, you can specify an exact list offset like in SQL. RecordOffset is 0-based, so if you are retrieving items 20 at a time,
        /// pageNo = 1 is equivalent to recordOffset = 0,
        /// pageNo = 2 is equivalent to recordOffset = 20
        /// and so on.
        /// </summary>
        public int? RecordOffset { get; set; }
    }
    public enum ProductType
    {
        /// <summary>
        /// A regular item.
        /// </summary>
        PRODUCT,
        /// <summary>
        /// A bundle product. Bundle products do not have an inventory quantity. When a bundle is sold, it is the components that are actually drawn from inventory. A bundle cannot be purchased, counted or taken into stock. The composition of a bundle product is described by its recipe.
        /// </summary>
        BUNDLE,
        /// <summary>
        /// A matrix product. Matrix product has a number of variations - specific colors or sizes of the same design or model. The matrix product itself does not have inventory and cannot be purchased or sold.
        /// </summary>
        MATRIX,
        /// <summary>
        /// An assembly product. An assembly is similar to a bundle (it has a list of components), but it is an inventory item in its own right. An assembly can be purchased as a whole, and it can also be "assembled". Assembling is a procedure that subtracts the components from inventory and takes the finished product into stock.
        /// </summary>
        ASSEMBLY
    }
    public enum ProductStatus
    {
        ACTIVE,
        NO_LONGER_ORDERED,
        NOT_FOR_SALE,
        ARCHIVED,
        /// <summary>
        /// All non-archived items (ie. items that are active, not for sale or no longer ordered). 
        /// </summary>
        ALLEXCEPT_ARCHIVED
    }
    public enum ProductsFor
    {
        SALES,
        ORDERING
    }

    #endregion
    #region Product

    public class Product : ErplyItem
    {
        /// <summary>
        /// Product ID  
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// Product type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductType? Type { get; set; }
        /// <summary>
        /// Value true indicates an archived product, and is equivalent to status = ARCHIVED. Archived products should not be displayed to users.
        /// Value false indicates an active item.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? Active { get; set; }
        /// <summary>
        /// Product status. 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductStatus? Status { get; set; }
        /// <summary>
        /// Product name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name in english
        /// </summary>
        public string NameENG { get; set; }
        /// <summary>
        /// Name in spanish
        /// </summary>
        public string NameSPA { get; set; }
        /// <summary>
        /// Name in german
        /// </summary>
        public string NameGER { get; set; }
        /// <summary>
        /// Name in swedish
        /// </summary>
        public string NameSWE { get; set; }
        /// <summary>
        /// Name in finnish
        /// </summary>
        public string NameFIN { get; set; }
        /// <summary>
        /// Name in russian
        /// </summary>
        public string NameRUS { get; set; }
        /// <summary>
        /// Name in estonian
        /// </summary>
        public string NameEST { get; set; }
        /// <summary>
        /// Name in latvian
        /// </summary>
        public string NameLAT { get; set; }
        /// <summary>
        /// Name in lithuanian
        /// </summary>
        public string NameLIT { get; set; }
        /// <summary>
        /// Name in greek
        /// </summary>
        public string NameGRE { get; set; }
        /// <summary>
        /// First code of the item (by convention, this is used for company's internal code)  
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Second code of the item (by convention, this is used for EAN/UPC barcode)  
        /// </summary>
        public string Code2 { get; set; }
        /// <summary>
        /// Third code of the item (note that this field may not be visible on product card by default)  
        /// </summary>
        public string Code3 { get; set; }
        /// <summary>
        /// Supplier's product code  
        /// </summary>
        public string SupplierCode { get; set; }
        /// <summary>
        /// Code 5 of the item. API only returns this field if "Extra product codes" module is enabled on your account.  
        /// </summary>
        public string Code5 { get; set; }
        /// <summary>
        /// Code 6 of the item. API only returns this field if "Extra product codes" module is enabled on your account.  
        /// </summary>
        public string Code6 { get; set; }
        /// <summary>
        /// Code 7 of the item. API only returns this field if "Extra product codes" module is enabled on your account.  
        /// </summary>
        public string Code7 { get; set; }
        /// <summary>
        /// Code 8 of the item. API only returns this field if "Extra product codes" module is enabled on your account.  
        /// </summary>
        public string Code8 { get; set; }
        /// <summary>
        /// Product group ID  
        /// </summary>
        public int? GroupID { get; set; }
        /// <summary>
        /// Name of the product group  
        /// </summary>
        public string GroupName { get; set; }
        public float? Price { get; set; }
        public float? PriceWithVat { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool? DisplayedInWebshop { get; set; }
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int? SeriesID { get; set; }
        public string SeriesName { get; set; }
        public int? SupplierID { get; set; }
        public string SupplierName { get; set; }
        public int? UnitID { get; set; }
        public string UnitName { get; set; }
        /// <summary>
        /// If set to true, this product is tax free in ALL stores and sales locations, regardless of POS tax rate and regardless of this product's 'vatrateID'. (Eg. a gift card.)  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? TaxFree { get; set; }
        public string DeliveryTime { get; set; }
        /// <summary>
        /// VAT rate (tax rate) of this item. NB! POS tax rate will override this value when selling from POS.  
        /// </summary>
        public int? VatrateID { get; set; }
        public float? Vatrate { get; set; }
        /// <summary>
        /// Value true indicates that this item has a quick-select button in POS.
        /// This field is DEPRECATED, because in Erply backend you can actually define different POS quick select buttons for each shop(location, warehouse). Therefore you should use API call getPointsOfSale to retrieve POS quick buttons.For each register, API will return a quickButtons structure.
        /// (Quick buttons are specified per-store, but 'getPointsOfSale' returns them separately for each register.)
        /// Please note that quick buttons may contain both services and products.We are phasing out services(new accounts do not have this module and should use non-stock products instead), but older accounts still have and use them.
        /// If you are only interested in product buttons, you can still use API call 'getProducts'. Set the filters 'quickPosProducts' to true and 'warehouseID'.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? HasQuickSelectButton { get; set; }
        /// <summary>
        /// True if this item is a serial numbered gift card.
        /// If such a product is sold from POS, its serial number should be recorded and saved into the registry of sold gift cards, using API function saveGiftCard.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? IsGiftCard { get; set; }
        /// <summary>
        /// True if this item is a regular gift card.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? IsRegularGiftCard { get; set; }
        /// <summary>
        /// True if this item is marked as non-discountable. Non-discountable products are related to calculateShoppingCart call. This field show only product's own flag, product can be non-discountable for card calculation if it's group, or any of group's parent group is marked as non-discountable, or if product is any type of gift card. Flag presently only applies to promotion discounts, product still can be discounted manually or using price list.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? NonDiscountable { get; set; }
        public string ManufacturerName { get; set; }
        /// <summary>
        /// Priority group ID.
        /// </summary>
        public int? PriorityGroupID { get; set; }
        /// <summary>
        /// Country ID. 
        /// </summary>
        public int? CountryOfOriginID { get; set; }
        public int? BrandID { get; set; }
        public string BrandName { get; set; }
        /// <summary>
        /// Physical dimension. Unit depends on region, check your Erply account (typically inches or mm).  
        /// </summary>
        public int? Width { get; set; }
        /// <summary>
        /// Physical dimension. Unit depends on region, check your Erply account (typically inches or mm).  
        /// </summary>
        public int? Height { get; set; }
        /// <summary>
        /// Physical dimension. Unit depends on region, check your Erply account (typically inches or mm).  
        /// </summary>
        public int? Length { get; set; }
        /// <summary>
        /// Length in minutes, for a salon service. API returns this attribute if Salon / SPA module is enabled.  
        /// </summary>
        public int? LengthInMinutes { get; set; }
        /// <summary>
        /// Service set-up time in minutes. API returns this attribute if Salon / SPA module is enabled.  
        /// </summary>
        public int? SetupTimeInMinutes { get; set; }
        /// <summary>
        /// Service cleanup time in minutes. API returns this attribute if Salon / SPA module is enabled.  
        /// </summary>
        public int? CleanupTimeInMinutes { get; set; }
        /// <summary>
        /// API returns this attribute if Salon / SPA module is enabled.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? WalkInService { get; set; }
        /// <summary>
        /// API returns this attribute if Reward Points module is enabled.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? RewardPointsNotAllowed { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool? NonStockProduct { get; set; }
        /// <summary>
        /// If this field is set to true, a prompt to enter price will appear in Berlin POS (3.26 and newer) every time the item is sold. (Even if the item has a price on product card or price lists, cashier will override the price every time, so the price lists will not apply.)
        /// This feature is used for random-weighted or random-priced items which are sold in units. (Inventory will be in units, but each unit might have a unique price given to it.)
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? CashierMustEnterPrice { get; set; }
        /// <summary>
        /// Item's net weight. Unit depends on region, check your Erply account (typically lbs or kg)  
        /// </summary>
        public float? NetWeight { get; set; }
        /// <summary>
        /// Default sales price of the product, excluding VAT. 
        /// </summary>
        public float? NetPrice { get; set; }
        /// <summary>
        /// Item's gross weight (with packaging). Unit depends on region, check your Erply account (typically lbs or kg)  
        /// </summary>
        public float? GrossWeight { get; set; }
        /// <summary>
        /// Item's fluid volume, eg. for beverages or perfumery. Unit depends on locale, check your Erply account (typically mL or fl oz)  
        /// </summary>
        public int? Volume { get; set; }
        /// <summary>
        /// Product description in default language, plain text.  
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Longer product description in default language, HTML.  
        /// </summary>
        public string Longdesc { get; set; }
        /// <summary>
        /// Product description in Estonian (if needed besides default language), plain text. 
        /// </summary>
        public string DescriptionEST { get; set; }
        /// <summary>
        /// Longer product description in Estonian (if needed besides default language), HTML. 
        /// </summary>
        public string LongdescEST { get; set; }
        /// <summary>
        /// Product description in English (if needed besides default language), plain text.  
        /// </summary>
        public string DescriptionENG { get; set; }
        /// <summary>
        /// Longer product description in English (if needed besides default language), HTML.  
        /// </summary>
        public string LongdescENG { get; set; }
        /// <summary>
        /// Product description in Russian (if needed besides default language), plain text.  
        /// </summary>
        public string DescriptionRUS { get; set; }
        /// <summary>
        /// Longer product description in Russian (if needed besides default language), HTML.  
        /// </summary>
        public string LongdescRUS { get; set; }
        /// <summary>
        /// Product description in Finnish (if needed besides default language), plain text.  
        /// </summary>
        public string DescriptionFIN { get; set; }
        /// <summary>
        /// Longer product description in Finnish (if needed besides default language), HTML.  
        /// </summary>
        public string LongdescFIN { get; set; }
        /// <summary>
        /// Product description in Finnish (if needed besides default language), plain text.  
        /// </summary>
        public string DescriptionSWE { get; set; }
        /// <summary>
        /// Longer product description in Finnish (if needed besides default language), HTML.  
        /// </summary>
        public string LongdescSWE { get; set; }
        /// <summary>
        /// Product unit cost.
        /// This is an informative, unchanging cost you can edit yourself on Erply's product card. To get real current costs for the batches in stock, use FIFOCost instead.  
        /// </summary>
        public float? Cost { get; set; }
        /// <summary>
        /// Average product unit cost, for the batches currently in stock.
        /// To retrieve this field, set 'getFIFOCost' to true. If you have specified warehouse ID, API returns FIFO cost of selected products in one specific warehouse.Otherwise, the cost given is an average over all warehouses.See the structure "warehouses" below to get costs for each warehouse separately.
        /// Cost = purchase price + freight and other additional costs.
        /// </summary>
        public float? FIFOCost { get; set; }
        /// <summary>
        /// Average purchase price, for the batches currently in stock.
        /// Purchase price is basically the same as FIFO cost, but excluding freight and other additional costs.
        /// To retrieve this field, set 'getFIFOCost' to true.If you have specified warehouse ID, API returns purchase price of selected products in one specific warehouse.Otherwise, the purchase price given is an average over all warehouses.See the structure "warehouses" below to get purchase prices for each warehouse separately.
        /// </summary>
        public float? PurchasePrice { get; set; }
        /// <summary>
        /// Amount of backbar charges for this service.  
        /// </summary>
        public float? BackbarCharges { get; set; }
        /// <summary>
        /// Creation time.  
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        /// <summary>
        /// An identifier referring to the user who created this product. This is NOT actually the user's name; it's just a string, at most 16 characters long. However, typically it matches the first 16 characters of the user's name.  
        /// </summary>
        public string AddedByUsername { get; set; }
        /// <summary>
        /// Last modification time.  
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? LastModified { get; set; }
        /// <summary>
        /// An identifier that refers to the user who last modified this product. This is NOT actually the user's name; it's just a string, at most 16 characters long. However, typically it matches the first 16 characters of the user's name. 
        /// </summary>
        public string LastModifiedByUsername { get; set; }
        /// <summary>
        /// Product pictures. For each picture, ERPLY provides 4 URLs for 4 different image sizes. These URLs must not be hotlinked — you need to download the images to your application and serve them from there.
        /// Access to images is currently limited and the images are not accessible by default. If you need to access the files, please contact ERPLY customer support.
        /// </summary>
        public List<ProductImage> Images { get; set; }
        /// <summary>
        /// Warehouse-specific inventory quantities and/or unit costs.
        /// To retrieve inventory quantities per warehouse, specify getStockInfo to true. To retrieve costs, specify getFIFOCost to true.
        /// Keys of the array correspond to warehouse IDs.If only one warehouse was specified, the array will contain only one item.
        /// </summary>
        [JsonConverter(typeof(DictionaryToListConverter))]
        public List<ProductInfoInWarehouse> Warehouses { get; set; }
        /// <summary>
        /// This field describes the color and size of a matrix variation. Only matrix variations (products that are a specific color and size of a matrix product) have this field.
        /// For Berlin POS and Touch POS, this field is not returned by default, but POS can request it with a special input parameter posGetVariationDescription set to true.  
        /// </summary>
        [JsonProperty("variationDescription")]
        public List<ProductVariationDescription> VariationDescriptions { get; set; }
        /// <summary>
        /// A list of the variation product IDs for this matrix product. Only matrix products (type = MATRIX) have this output field.
        /// </summary>
        public List<int> ProductVariations { get; set; }
        /// <summary>
        /// Detailed information about the variations of this matrix product. Only matrix products (type = MATRIX) have this output field.
        /// To retrieve this information, you need to set input parameter getMatrixVariations to true.
        /// </summary>
        public List<ProductVariation> VariationList { get; set; }
        /// <summary>
        /// For matrix variations only: the ID of matrix parent product.  
        /// </summary>
        public int? ParentProductID { get; set; }
        /// <summary>
        /// ID of another product, a beverage container that is always sold together with this item.  
        /// </summary>
        public int? ContainerID { get; set; }
        /// <summary>
        /// Name of the associated product, the beverage container. Set parameter getContainerInfo to true to retrieve this field.  
        /// </summary>
        public string ContainerName { get; set; }
        /// <summary>
        /// Code of the associated product, the beverage container. Set parameter getContainerInfo to true to retrieve this field.  
        /// </summary>
        public string ContainerCode { get; set; }
        /// <summary>
        /// Number of beverage containers that this product contains. (Eg. if your product is "A Case of Coca-Cola", it might contain 24 cans.) Set parameter getContainerInfo to true to retrieve this field.  
        /// </summary>
        public string ContainerAmount { get; set; }
        /// <summary>
        /// Type of packaging, Packaging module must be enabled.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PackagingType? PackagingType { get; set; }
        /// <summary>
        /// List of product packages.
        /// Information about the various-sized packages for this item (eg. a pack of 4, a crate of 20, a pallet of 500).
        /// To have getProducts return product parameters, set input field "getPackageInfo" to true.
        /// Set the "lang" parameter to retrieve package names in an appropriate language.
        /// To add, modify or remove packages, see API calls saveProductPackage and deleteProductPackage.  
        /// </summary>
        public List<ProductPackage> ProductPackages { get; set; }
        /// <summary>
        /// Replacement products for this item. This element is an list of product IDs. To retrieve this list, specify getReplacementProducts to true.  
        /// </summary>
        [ErplyProperty("replacementProductIDs")]
        [ErplyConverter(typeof(CommaSeparatedListConverter))]
        public List<int> ReplacementProducts { get; set; }
        /// <summary>
        /// Related items.
        /// Please note that on ERPLY product card, related products subsection is not visible by default. It needs to be specially enabled.
        /// This is an list of product IDs. To retrieve this list, specify getRelatedProducts to true.  
        /// </summary>
        [ErplyProperty("relatedProductIDs")]
        [ErplyConverter(typeof(CommaSeparatedListConverter))]
        public List<int> RelatedProducts { get; set; }
        /// <summary>
        /// Product files (brochures, manuals, specifications). For each file, API provides a URL.
        /// Please note that the files(as well as product images) are not accessible by default. To get access to the files, please contact ERPLY customer support.
        /// To retrieve this information, specify getRelatedFiles to true.
        /// The same information is also available through a standalone API call getProductFiles.Use it if you need to fetch all files, or retrieve a file by ID.  
        /// </summary>
        public List<ProductRelatedFile> RelatedFiles { get; set; }
        /// <summary>
        /// Composition, or recipe, of a BUNDLE or ASSEMBLY product.
        /// A bundle product does not have a stock quantity.When a bundle is sold, it is the components that are actually drawn from inventory.
        /// An assembly product, on the other hand, is an inventory item in its own right.It can be purchased as a whole, but it can also be "assembled"; this is a procedure that subtracts the components from inventory and takes the finished product into stock.
        /// To retrieve this information, set getRecipes to true.  
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<ProductComponent> ProductComponents { get; set; }
        /// <summary>
        /// Sales price (VAT excluded) that applies to specified sales location or customer. API returns this attribute if parameter "getPriceListPrices" is specified.
        /// </summary>
        public float? PriceListPrice { get; set; }
        /// <summary>
        /// Sales price (VAT included) that applies to specified sales location or customer. API returns this attribute if parameter "getPriceListPrices" is specified.
        /// </summary>
        public float? PriceListPriceWithVat { get; set; }
        /// <summary>
        /// List of records.
        /// </summary>
        public List<ProductPriceCalculationStep> PriceCalculationSteps { get; set; }
        /// <summary>
        /// Location in warehouse. DEPRECATED — this is a merged field that contains both the "location in warehouse" classifier selected from a drop-down, and the contents of the "location in warehouse" text field. To get these values separately, see the following fields.  
        /// </summary>
        public string LocationInWarehouse { get; set; }
        /// <summary>
        /// ID of product's location in warehouse (selected from a drop-down list). To get a list of the classifiers, see API call getLocationsInWarehouse.  
        /// </summary>
        public string LocationInWarehouseID { get; set; }
        /// <summary>
        /// Name of the "location in warehouse" that the previous ID refers to.  
        /// </summary>
        public string LocationInWarehouseName { get; set; }
        /// <summary>
        /// Contents of the "location in warehouse" text field on product card.
        /// There are two options for classifying products - locations in warehouse can be predefined as a list and selected from a drop-down, or entered as free text on every product card.
        /// </summary>
        public string LocationInWarehouseText { get; set; }
        /// <summary>
        /// Title for product card extra field 1. (Users can customize field label if they want it to be named something else than "Extra Field 1"). The title is returned in specified language, or account's default language otherwise.
        /// API outputs this field, and all the following "extraField..." fields only if "Extra product card fields" module is enabled on your account.
        /// </summary>
        public string ExtraField1Title { get; set; }
        /// <summary>
        /// ID of selected value in product card extra field 1. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField1Values.  
        /// </summary>
        public int? ExtraField1ID { get; set; }
        /// <summary>
        /// Code of selected value in product card extra field 1.  
        /// </summary>
        public string ExtraField1Code { get; set; }
        /// <summary>
        /// Name of selected value in product card extra field 1.  
        /// </summary>
        public string ExtraField1Name { get; set; }
        /// <summary>
        /// Title for product card extra field 2. (Users can customize field label if they want it to be named something else than "Extra Field 2"). The title is returned in specified language, or account's default language otherwise.  
        /// </summary>
        public string ExtraField2Title { get; set; }
        /// <summary>
        /// ID of selected value in product card extra field 2. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField2Values.  
        /// </summary>
        public int? ExtraField2ID { get; set; }
        /// <summary>
        /// Code of selected value in product card extra field 2.  
        /// </summary>
        public string ExtraField2Code { get; set; }
        /// <summary>
        /// Name of selected value in product card extra field 2.  
        /// </summary>
        public string ExtraField2Name { get; set; }
        /// <summary>
        /// Title for product card extra field 3. (Users can customize field label if they want it to be named something else than "Extra Field 3"). The title is returned in specified language, or account's default language otherwise.  
        /// </summary>
        public string ExtraField3Title { get; set; }
        /// <summary>
        /// ID of selected value in product card extra field 3. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField3Values.  
        /// </summary>
        public int? ExtraField3ID { get; set; }
        /// <summary>
        /// Code of selected value in product card extra field 3.  
        /// </summary>
        public string ExtraField3Code { get; set; }
        /// <summary>
        /// Name of selected value in product card extra field 3.  
        /// </summary>
        public string ExtraField3Name { get; set; }
        /// <summary>
        /// Title for product card extra field 4. (Users can customize field label if they want it to be named something else than "Extra Field 4"). The title is returned in specified language, or account's default language otherwise.  
        /// </summary>
        public string ExtraField4Title { get; set; }
        /// <summary>
        /// ID of selected value in product card extra field 4. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField4Values.  
        /// </summary>
        public int? ExtraField4ID { get; set; }
        /// <summary>
        /// Code of selected value in product card extra field 4.  
        /// </summary>
        public string ExtraField4Code { get; set; }
        /// <summary>
        /// Name of selected value in product card extra field 4.  
        /// </summary>
        public string ExtraField4Name { get; set; }
        /// <summary>
        /// Sales package - amount of clear/brown glass.  
        /// </summary>
        public string SalesPackageClearBrownGlass { get; set; }
        /// <summary>
        /// Sales package - amount of green/other glass.  
        /// </summary>
        public string SalesPackageGreenOtherGlass { get; set; }
        /// <summary>
        /// Sales package - amount of plastic (PP, PE).  
        /// </summary>
        public string SalesPackagePlasticPpPe { get; set; }
        /// <summary>
        /// Sales package - amount of plastic (PET).  
        /// </summary>
        public string SalesPackagePlasticPet { get; set; }
        /// <summary>
        /// Sales package - amount of metal (Fe).  
        /// </summary>
        public string SalesPackageMetalFe { get; set; }
        /// <summary>
        /// Sales package - amount of metal (Al).  
        /// </summary>
        public string SalesPackageMetalAl { get; set; }
        /// <summary>
        /// Sales package - amount of other metal.  
        /// </summary>
        public string SalesPackageOtherMetal { get; set; }
        /// <summary>
        /// Sales package - amount of cardboard.  
        /// </summary>
        public string SalesPackageCardboard { get; set; }
        /// <summary>
        /// Sales package - amount of wood.  
        /// </summary>
        public string SalesPackageWood { get; set; }
        /// <summary>
        /// Group package - amount of paper.  
        /// </summary>
        public string GroupPackagePaper { get; set; }
        /// <summary>
        /// Group package - amount of plastic.  
        /// </summary>
        public string GroupPackagePlastic { get; set; }
        /// <summary>
        /// Group package - amount of metal.  
        /// </summary>
        public string GroupPackageMetal { get; set; }
        /// <summary>
        /// Group package - amount of wood.  
        /// </summary>
        public string GroupPackageWood { get; set; }
        /// <summary>
        /// Transport package - amount of wood.  
        /// </summary>
        public string TransportPackageWood { get; set; }
        /// <summary>
        /// Transport package - amount of plastic.  
        /// </summary>
        public string TransportPackagePlastic { get; set; }
        /// <summary>
        /// Transport package - amount of cardboard.  
        /// </summary>
        public string TransportPackageCardboard { get; set; }
        /// <summary>
        /// The product's identification number in a state registry (eg. for alcoholic beverages).  
        /// </summary>
        public string RegistyNumber { get; set; }
        /// <summary>
        /// Percentage of alcohol by volume in the beverage.  
        /// </summary>
        public float? AlcoholPrecentage { get; set; }
        /// <summary>
        /// List of current batches in stock (batch identification numbers), separated by semicolons. This field is only meant to be used for specific reporting purposes (eg. for alcoholic beverages), where batches are identified by an official identification number. Erply does not manage these "batches" automatically; it only allows to associate a sales document row with a batch number.  
        /// </summary>
        public string Batches { get; set; }
        /// <summary>
        /// Number and date of the excise declaration for this product (eg. an alcoholic beverage), and other relevant information about the declaration  
        /// </summary>
        public string ExciseDeclaration { get; set; }
        public float? ExciseFermentedProductUnder6 { get; set; }
        public float? ExciseWineOver6 { get; set; }
        public float? ExciseFermentedProductOver6 { get; set; }
        public float? ExcicseIntermediateProduct { get; set; }
        public float? ExciseOtherAlchohol { get; set; }
        public float? ExcisePackaging { get; set; }
        /// <summary>
        /// Additional attributes.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
        /// <summary>
        /// Additional attributes — longer strings.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<LongAttribute> LongAttributes { get; set; }
        /// <summary>
        /// List of parameters.
        /// "Product parameters" is a ERPLY add-on module, primarily for web shops.It needs to be set up in a specific way, and is not enabled by default. If you are looking for a simple way to attach extra key-value data to products, see "Attributes" above.
        /// To work with parameters, you first need to define "parameter groups" in Erply backend, and associate these with product groups. Each group defines parameters for a specific type of product.Eg.: inner and outer diameter for bearings; volume, energy rating and physical dimensions for refrigerators etc.
        /// To have getProducts return product parameters, set input field "getParameters" to true.  
        /// </summary>
        [ErplyConverter(typeof(ListWithListConverter))]
        public List<ProductParameter> Parameters { get; set; }
        /// <summary>
        /// If set to true, this product does not need printed labels. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? LabelsNotNeeded { get; set; }
        /// <summary>
        /// Matrix items have 1...3 dimensions - color, size etc. Matrix dimensions can be defined in Erply backend (in Settings » Matrix Dimensions) or with API call saveMatrixDimension.
        /// A dimension has a name(eg. "Letter Sizes" or Spring 2013 Colors") and a list of possible values (eg. S, M, L or Lime, Yellow, Fuchsia). API call getMatrixDimensions returns a list of all dimensions you have defined.
        /// To create a matrix product, first pick the dimension(s) that apply to this particular product, eg "Waist Size" and "Length" for jeans.A matrix can have up to 3 dimensions.
        /// Create the parent product (matrix product). You will not be selling this item directly, but Erply needs this item to group all sizes/colors together. Set:
        /// type = MATRIX
        /// dimensionID1 = first dimension ID
        /// dimensionID2 = second dimension ID (if needed)
        /// dimensionID3 = third dimension ID(if needed)
        /// Create the specific variations(color/size combinations), each one as a separate product.Set:
        /// type = PRODUCT
        /// parentProductID = ID of the matrix item
        /// dimValueID1, dimValueID2, dimValueID3 as needed(corresponding to how many dimensions the matrix has.)
        /// </summary>
        public int? DimensionID1 { get; set; }
        /// <summary>
        /// Matrix items have 1...3 dimensions - color, size etc. Matrix dimensions can be defined in Erply backend (in Settings » Matrix Dimensions) or with API call saveMatrixDimension.
        /// A dimension has a name(eg. "Letter Sizes" or Spring 2013 Colors") and a list of possible values (eg. S, M, L or Lime, Yellow, Fuchsia). API call getMatrixDimensions returns a list of all dimensions you have defined.
        /// To create a matrix product, first pick the dimension(s) that apply to this particular product, eg "Waist Size" and "Length" for jeans.A matrix can have up to 3 dimensions.
        /// Create the parent product (matrix product). You will not be selling this item directly, but Erply needs this item to group all sizes/colors together. Set:
        /// type = MATRIX
        /// dimensionID1 = first dimension ID
        /// dimensionID2 = second dimension ID (if needed)
        /// dimensionID3 = third dimension ID(if needed)
        /// Create the specific variations(color/size combinations), each one as a separate product.Set:
        /// type = PRODUCT
        /// parentProductID = ID of the matrix item
        /// dimValueID1, dimValueID2, dimValueID3 as needed(corresponding to how many dimensions the matrix has.)
        /// </summary>
        public int? DimensionID2 { get; set; }
        /// <summary>
        /// Matrix items have 1...3 dimensions - color, size etc. Matrix dimensions can be defined in Erply backend (in Settings » Matrix Dimensions) or with API call saveMatrixDimension.
        /// A dimension has a name(eg. "Letter Sizes" or Spring 2013 Colors") and a list of possible values (eg. S, M, L or Lime, Yellow, Fuchsia). API call getMatrixDimensions returns a list of all dimensions you have defined.
        /// To create a matrix product, first pick the dimension(s) that apply to this particular product, eg "Waist Size" and "Length" for jeans.A matrix can have up to 3 dimensions.
        /// Create the parent product (matrix product). You will not be selling this item directly, but Erply needs this item to group all sizes/colors together. Set:
        /// type = MATRIX
        /// dimensionID1 = first dimension ID
        /// dimensionID2 = second dimension ID (if needed)
        /// dimensionID3 = third dimension ID(if needed)
        /// Create the specific variations(color/size combinations), each one as a separate product.Set:
        /// type = PRODUCT
        /// parentProductID = ID of the matrix item
        /// dimValueID1, dimValueID2, dimValueID3 as needed(corresponding to how many dimensions the matrix has.)
        /// </summary>
        public int? DimensionID3 { get; set; }
        /// <summary>
        /// Matrix items have 1...3 dimensions - color, size etc. Matrix dimensions can be defined in Erply backend (in Settings » Matrix Dimensions) or with API call saveMatrixDimension.
        /// A dimension has a name(eg. "Letter Sizes" or Spring 2013 Colors") and a list of possible values (eg. S, M, L or Lime, Yellow, Fuchsia). API call getMatrixDimensions returns a list of all dimensions you have defined.
        /// To create a matrix product, first pick the dimension(s) that apply to this particular product, eg "Waist Size" and "Length" for jeans.A matrix can have up to 3 dimensions.
        /// Create the parent product (matrix product). You will not be selling this item directly, but Erply needs this item to group all sizes/colors together. Set:
        /// type = MATRIX
        /// dimensionID1 = first dimension ID
        /// dimensionID2 = second dimension ID (if needed)
        /// dimensionID3 = third dimension ID(if needed)
        /// Create the specific variations(color/size combinations), each one as a separate product.Set:
        /// type = PRODUCT
        /// parentProductID = ID of the matrix item
        /// dimValueID1, dimValueID2, dimValueID3 as needed(corresponding to how many dimensions the matrix has.)
        /// </summary>
        public int? DimValueID1 { get; set; }
        /// <summary>
        /// Matrix items have 1...3 dimensions - color, size etc. Matrix dimensions can be defined in Erply backend (in Settings » Matrix Dimensions) or with API call saveMatrixDimension.
        /// A dimension has a name(eg. "Letter Sizes" or Spring 2013 Colors") and a list of possible values (eg. S, M, L or Lime, Yellow, Fuchsia). API call getMatrixDimensions returns a list of all dimensions you have defined.
        /// To create a matrix product, first pick the dimension(s) that apply to this particular product, eg "Waist Size" and "Length" for jeans.A matrix can have up to 3 dimensions.
        /// Create the parent product (matrix product). You will not be selling this item directly, but Erply needs this item to group all sizes/colors together. Set:
        /// type = MATRIX
        /// dimensionID1 = first dimension ID
        /// dimensionID2 = second dimension ID (if needed)
        /// dimensionID3 = third dimension ID(if needed)
        /// Create the specific variations(color/size combinations), each one as a separate product.Set:
        /// type = PRODUCT
        /// parentProductID = ID of the matrix item
        /// dimValueID1, dimValueID2, dimValueID3 as needed(corresponding to how many dimensions the matrix has.)
        /// </summary>
        public int? DimValueID2 { get; set; }
        /// <summary>
        /// Matrix items have 1...3 dimensions - color, size etc. Matrix dimensions can be defined in Erply backend (in Settings » Matrix Dimensions) or with API call saveMatrixDimension.
        /// A dimension has a name(eg. "Letter Sizes" or Spring 2013 Colors") and a list of possible values (eg. S, M, L or Lime, Yellow, Fuchsia). API call getMatrixDimensions returns a list of all dimensions you have defined.
        /// To create a matrix product, first pick the dimension(s) that apply to this particular product, eg "Waist Size" and "Length" for jeans.A matrix can have up to 3 dimensions.
        /// Create the parent product (matrix product). You will not be selling this item directly, but Erply needs this item to group all sizes/colors together. Set:
        /// type = MATRIX
        /// dimensionID1 = first dimension ID
        /// dimensionID2 = second dimension ID (if needed)
        /// dimensionID3 = third dimension ID(if needed)
        /// Create the specific variations(color/size combinations), each one as a separate product.Set:
        /// type = PRODUCT
        /// parentProductID = ID of the matrix item
        /// dimValueID1, dimValueID2, dimValueID3 as needed(corresponding to how many dimensions the matrix has.)
        /// </summary>
        public int? DimValueID3 { get; set; }
    }

    public class ProductInfoInWarehouse
    {
        /// <summary>
        /// ID of the warehouse
        /// </summary>
        public int? WarehouseID { get; set; }
        /// <summary>
        /// Amount currently in stock
        /// </summary>
        public float? TotalInStock { get; set; }
        /// <summary>
        /// Amount reserved to customers
        /// </summary>
        public float? Reserved { get; set; }
        /// <summary>
        /// TotalInStock - reserved
        /// </summary>
        public float? Free { get; set; }
        /// <summary>
        /// Amount that has already been ordered from suppliers (purchase orders that have been confirmed)
        /// </summary>
        public float? OrderPending { get; set; }
        /// <summary>
        /// Reorder point (if stock amount falls below that, it needs to be restocked) for this particular product, in this particular warehouse
        /// </summary>
        public float? ReorderPoint { get; set; }
        /// <summary>
        /// Restocking level (when placing purchase orders, the item is by default restocked to specified amount) for this particular product, in this particular warehouse.
        /// </summary>
        public float? RestockLevel { get; set; }
        /// <summary>
        /// FIFO cost.
        /// </summary>
        public float? FIFOCost { get; set; }
        /// <summary>
        /// Purchase price.  
        /// </summary>
        public float? PurchasePrice { get; set; }
    }
    public class ProductVariationDescription
    {
        /// <summary>
        /// Name of the dimension (eg. "Size")
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name of dimension's value (eg. "Medium")
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Position number of the dimension
        /// </summary>
        public int? Order { get; set; }
        /// <summary>
        /// ID of the dimension (ID of "Size")
        /// </summary>
        public int? DimensionID { get; set; }
        /// <summary>
        /// ID of dimension's value (ID of "Medium")
        /// </summary>
        public int? VariationID { get; set; }
    }
    public class ProductVariation
    {
        /// <summary>
        /// ID of the variation product (ID of the product "Shirt Red L")
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// Name of the variation (eg. "Shirt Red L")
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Code of the variation (eg. "10056-Red-L")
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// EAN / UPC of the variation
        /// </summary>
        public string Code2 { get; set; }
        /// <summary>
        /// A description of the item's color and size (ie. the "dimensions"). This array contains at most 3 elements (first, second and third dimension).
        /// </summary>
        public List<ProductVariationDimensions> Dimensions { get; set; }
    }
    public class ProductVariationDimensions
    {
        /// <summary>
        /// Name of the dimension (eg. "Size")
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name of dimension's value (eg. "Medium")
        /// </summary>
        public string Value { get; set; }
        /// <summary>
        /// Code of dimension's value (eg. "M")
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Position number of the dimension value (ie. what is the position of this color in the list of all colors).
        /// </summary>
        public int? Order { get; set; }
        /// <summary>
        /// ID of the dimension (ID of "Size")
        /// </summary>
        public int? DimensionID { get; set; }
        /// <summary>
        /// ID of dimension's value (ID of "Medium")
        /// </summary>
        public int? DimensionValueID { get; set; }
    }
    public class ProductImage
    {
        /// <summary>
        /// Image ID
        /// </summary>
        public int? PictureID { get; set; }
        /// <summary>
        /// A descriptive name for the file. May be empty.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// URL of image thumbnail (by default 100 x 100 px)
        /// </summary>
        public string ThumbURL { get; set; }
        /// <summary>
        /// URL of a small version of the image (by default 200 x 200 px)
        /// </summary>
        public string SmallURL { get; set; }
        /// <summary>
        /// URL of a large version of the image (by default 800 x 600 px)
        /// </summary>
        public string LargeURL { get; set; }
        /// <summary>
        /// URL of the full-size original image
        /// </summary>
        public string FullURL { get; set; }
        /// <summary>
        /// A flag that indicates whether the image is stored as a local file in Erply, or as a URL to an external location, eg. a content delivery network.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? External { get; set; }
        /// <summary>
        /// A codename for the hosting provider, if the file is stored in an external location. May be empty.
        /// This is used only for ERPLY's internal purposes, eg. to know how to remove image files from a specific CDN when the picture is removed from ERPLY.
        /// </summary>
        public string HostingProvider { get; set; }
    }
    [ErplyProperty("parameter")]
    public class ProductParameter
    {
        /// <summary>
        /// Parameter ID
        /// </summary>
        public int? ParameterID { get; set; }
        /// <summary>
        /// Parameter name
        /// </summary>
        public string ParameterName { get; set; }
        /// <summary>
        /// Parameter type. Possible values: TEXT, NUMERIC, BOOLEAN, MULTIVALUE
        /// </summary>
        public string ParameterType { get; set; }
        /// <summary>
        /// Parameter group ID
        /// </summary>
        public int? ParameterGroupID { get; set; }
        /// <summary>
        /// Parameter value. Not set for MULTIVALUE parameters.
        /// </summary>
        public string ParameterValue { get; set; }
        /// <summary>
        /// Only for MULTIVALUE parameters — shows which optins from the multi-select list are enabled for this particular item.
        /// </summary>
        public List<ProductParameterOption> ParameterOptions { get; set; }
    }
    [ErplyProperty("optionID")]
    public class ProductParameterOption
    {
        public int? OptionID { get; set; }
        public string OptionName { get; set; }
        [ErplyProperty("additionalPrice")]
        public float? OptionAdditionalPrice { get; set; }
    }
    public class ProductPackage
    {
        /// <summary>
        /// Package ID
        /// </summary>
        public int? PackageID { get; set; }
        /// <summary>
        /// Package type name in current language
        /// </summary>
        public string PackageType { get; set; }
        /// <summary>
        /// Package type ID, full list with API call getProductPackageTypes
        /// </summary>
        public int? PackageTypeID { get; set; }
        /// <summary>
        /// Amount that this package contains
        /// </summary>
        public float? PackageAmount { get; set; }
        /// <summary>
        /// Package barcode
        /// </summary>
        public string PackageCode { get; set; }
        /// <summary>
        /// Package weight without packing materials
        /// </summary>
        public float? PackageNetWeight { get; set; }
        /// <summary>
        /// Package total weight
        /// </summary>
        public float? PackageGrossWeight { get; set; }
        public float? PackageLength { get; set; }
        public float? PackageWidth { get; set; }
        public float? PackageHeight { get; set; }
    }
    public class ProductRelatedFile
    {
        /// <summary>
        /// ID of the file
        /// </summary>
        public int? FileID { get; set; }
        /// <summary>
        /// A descriptive name for the file. May be empty.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// File type ID. Types are defined in Settings » Inventory settings » Product file types. See API call getProductFileTypes.
        /// </summary>
        public int? TypeID { get; set; }
        /// <summary>
        /// Name of the file type
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// A flag for categorizing the files
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? IsInformationFile { get; set; }
        /// <summary>
        /// URL of file.
        /// </summary>
        public string FileURL { get; set; }
        /// <summary>
        /// A flag that indicates whether the file is stored as a local file in Erply, or as a URL to an external location, eg. a content delivery network.
        /// </summary>
        [JsonProperty("external")]
        [JsonConverter(typeof(BoolConverter))]
        public bool? IsExternal { get; set; }
        /// <summary>
        /// A codename for the hosting provider, if the file is stored in an external location. May be empty.
        /// This is used only for ERPLY's internal purposes, eg. to know how to remove files from a specific CDN when the file is removed from ERPLY.
        /// </summary>
        public string HostingProvider { get; set; }
    }
    public class ProductComponent
    {
        [ErplyProperty("componentProductID")]
        /// <summary>
        /// ID of the component product
        /// </summary>
        public int? ComponentID { get; set; }
        /// <summary>
        /// Component amount
        /// </summary>
        [ErplyProperty("componentAmount")]
        public float? Amount { get; set; }
    }
    public class ProductPriceCalculationStep
    {
        /// <summary>
        /// Price list ID
        /// </summary>
        public int? PriceListID { get; set; }
        /// <summary>
        /// Price list name
        /// </summary>
        public string PriceListName { get; set; }
        /// <summary>
        /// Unit price specified in this price list
        /// </summary>
        public float? Price { get; set; }
        /// <summary>
        /// Unit $ discount given by this price list
        /// </summary>
        public float? Discount { get; set; }
        /// <summary>
        /// "PRICE" or "DISCOUNT"
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Discount percentage from the price list (only present if the price list specified a percentage discount).
        /// </summary>
        public float? Percentage { get; set; }
    }
    public enum PackagingType
    {
        ORDINARY_PACKAGE,
        METAL_BEVERAGE_PACKAGE,
        RETURNABLE_PACKAGE
    }

    #endregion
    #region SaveProduct Settings
    public class SaveProductSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveProduct";

        [ErplyConverter(typeof(ErplyConverter))]
        public Product Product { get; set; }
    }
    #endregion
    #region ProductPicture
    public class ProductPicture : ErplyItem
    {
        /// <summary>
        /// Image ID.  
        /// </summary>
        public int? ProductPictureID { get; set; }
        /// <summary>
        /// Product ID.  
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// A descriptive name for the file. May be empty.  
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// URL of image thumbnail (by default 100 x 100 px).  
        /// </summary>
        public string ThumbURL { get; set; }
        /// <summary>
        /// URL of a small version of the image (by default 200 x 200 px).  
        /// </summary>
        public string SmallURL { get; set; }
        /// <summary>
        /// URL of a large version of the image (by default 800 x 600 px).  
        /// </summary>
        public string LargeURL { get; set; }
        /// <summary>
        /// URL of the full-size original image.  
        /// </summary>
        public string FullURL { get; set; }
        /// <summary>
        /// A flag that indicates whether the image is stored as a local file in Erply, or as a URL to an external location, eg. a content delivery network.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? External { get; set; }
        /// <summary>
        /// A codename for the hosting provider, if the file is stored in an external location. May be empty.
        /// This is used only for ERPLY's internal purposes, eg. to know how to remove image files from a specific CDN when the picture is removed from ERPLY.  
        /// </summary>
        public int? HostingProvider { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        public string LastModified { get; set; }
    }

    #endregion
    #region GetProductPictures Settings

    public class GetProductPicturesSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "getProductPictures";
        /// <summary>
        /// Retrieve one specific image by ID. 
        /// </summary>
        public int? ProductPictureID { get; set; }
        /// <summary>
        /// Retrieve all images associated with a product. 
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? ChangedSince { get; set; }
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
    #region SaveProductPicture Settings
    public class SaveProductPictureSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveProductPicture";

        /// <summary>
        /// Use productPictureID to edit or replace an existing image. You may edit general information of the file (productID, pictureName) or replace/update the file as well, as needed. 
        /// </summary>
        public int? ProductPictureID { get; set; }
        /// <summary>
        /// Product ID. For new pictures, this field is required. 
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// A descriptive name for the image 
        /// </summary>
        public string PictureName { get; set; }
        [JsonConverter(typeof(Base64Converter))]
        [JsonProperty("picture")]
        public Bitmap Image { get; set; }
        /// <summary>
        /// File name. If omitted, API will generate a random name for the image. 
        /// </summary>
        [JsonProperty("filename")]
        public string FileName { get; set; }
        /// <summary>
        /// Instead of uploading a file, it is possible to just provide a URL that points to the image file in an external location (a content delivery network). This feature is for internal purposes only and NOT recommended for use!
        /// Must start with http:// or https://, otherwise API returns error 1015. 
        /// </summary>
        public string URL { get; set; }
        /// <summary>
        /// To be used with parameter "url". This should be a mutually-agreed classifier, identifying the CDN where the image is located. ERPLY needs it to know how to manipulate the remote images.
        /// Must consist of letters and numbers only([A-Za-z0-9]*), otherwise API returns error 1015. It cannot be used in conjunction with local image files(API will return error 1013). 
        /// </summary>
        public string HostingProvider { get; set; }
    }
    #endregion
    #region DeleteProductSettings Settings
    public class DeleteProductSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "deleteProduct";

        /// <summary>
        /// The product to be deleted. 
        /// </summary>
        public int? ProductID { get; set; }
    }
    #endregion
    #region DeleteProductPictureSettings Settings
    public class DeleteProductPictureSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "deleteProductPicture";

        /// <summary>
        /// The product picture to be deleted. 
        /// </summary>
        public int? ProductPictureID { get; set; }
        /// <summary>
        /// To delete all pictures of the product, set productID. 
        /// </summary>
        public int? ProductID { get; set; }
    }
    #endregion

    #region GetProductGroups Settings
    public class GetProductGroupsSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "getProductGroups";

        /// <summary>
        /// Fetch one specific product group. 
        /// </summary>
        public int? ProductGroupID { get; set; }
        /// <summary>
        /// For synchronization; retrieve all product groups that have been updated after a certain time.
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? ChangedSince { get; set; }
        /// <summary>
        /// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified.
        /// </summary>
        public string SearchAttributeName { get; set; }
        /// <summary>
        /// Attribute value to search for.
        /// </summary>
        public string SearchAttributeValue { get; set; }
        /// <summary>
        /// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
        /// </summary>
        [JsonProperty("lang")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Language? Language { get; set; }
        /// <summary>
        /// Retrive product group names in all languages. If you turn on this flag, API will return additional fields nameENG, nameGER, etc. — depending on which languages have been enabled on your account. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetAllLanguages { get; set; }
    }
    #endregion
    #region ProductGroup
    public class ProductGroup : ErplyItem
    {
        /// <summary>
        /// Product group ID
        /// </summary>
        [JsonProperty("productGroupID")]
        [ErplyProperty("productGroupID")]
        public int? ID { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name in english
        /// </summary>
        public string NameENG { get; set; }
        /// <summary>
        /// Name in spanish
        /// </summary>
        public string NameSPA { get; set; }
        /// <summary>
        /// Name in german
        /// </summary>
        public string NameGER { get; set; }
        /// <summary>
        /// Name in swedish
        /// </summary>
        public string NameSWE { get; set; }
        /// <summary>
        /// Name in finnish
        /// </summary>
        public string NameFIN { get; set; }
        /// <summary>
        /// Name in russian
        /// </summary>
        public string NameRUS { get; set; }
        /// <summary>
        /// Name in estonian
        /// </summary>
        public string NameEST { get; set; }
        /// <summary>
        /// Name in latvian
        /// </summary>
        public string NameLAT { get; set; }
        /// <summary>
        /// Name in lithuanian
        /// </summary>
        public string NameLIT { get; set; }
        /// <summary>
        /// Name in greek
        /// </summary>
        public string NameGRE { get; set; }
        /// <summary>
        /// True if product group should be displayed in webshop.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? ShowInWebshop { get; set; }
        /// <summary>
        /// True if this group is marked as non-discountable. Non-discountable products and groups are related to calculateShoppingCart call. This field show only groups's own flag, product can be non-discountable for card calculation if it's group, or any of group's parent group is marked as non-discountable, or if product is any type of gift card. Flag presently only applies to promotion discounts, product still can be discounted manually or using price list.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? NonDiscountable { get; set; }
        /// <summary>
        /// Position number. When laying out the list of product groups, you can use this parameter to display them in intended order.  
        /// </summary>
        public int? PositionNo { get; set; }
        /// <summary>
        /// Parent product group ID.  
        /// </summary>
        public int? ParentGroupID { get; set; }
        /// <summary>
        /// Product group images
        /// </summary>
        public List<ProductGroupImage> Images { get; set; }
        /// <summary>
        /// Product group subgroups
        /// </summary>
        public List<ProductGroup> SubGroups { get; set; }
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
        /// <summary>
        /// Array of product group-specific tax rates (used in US, for example).
        /// </summary>
        public List<ProductGroupVatrate> Vatrates { get; set; }
    }

    public class ProductGroupImage
    {
        /// <summary>
        /// ID of the image
        /// </summary>
        public int? PictureID { get; set; }
        /// <summary>
        /// URL of image thumbnail (100 x 100 px as configured by default)
        /// </summary>
        public string ThumbURL { get; set; }
        /// <summary>
        /// URL of a small version of the image (by default 200 x 200 px)
        /// </summary>
        public string SmallURL { get; set; }
        /// <summary>
        /// URL of a large version of the image (by default 800 x 600 px)  
        /// </summary>
        public string LargeURL { get; set; }
    }
    public class ProductGroupVatrate
    {
        /// <summary>
        /// Warehouse ID
        /// </summary>
        public int? WarehouseID { get; set; }
        /// <summary>
        /// Tax rate that applies to this product group in this location (warehouse).
        /// </summary>
        public int? VatrateID { get; set; }
    }
    #endregion
    #region SaveProductGroup Settings
    public class SaveProductGroupSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveProductGroup";

        [ErplyConverter(typeof(ErplyConverter))]
        public ProductGroup ProductGroup { get; set; }
    }
    #endregion
    #region DeleteProductGroupSettings Settings
    public class DeleteProductGroupSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "deleteProductGroup";

        /// <summary>
        /// The product to be deleted. 
        /// </summary>
        public int? ProductGroupID { get; set; }
    }
    #endregion

    #region GetProductCategories Settings
    public class GetProductCategoriesSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "getProductCategories";

        public int? ParentCategoryID { get; set; }
        /// <summary>
        /// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified.
        /// </summary>
        public string SearchAttributeName { get; set; }
        /// <summary>
        /// Attribute value to search for.
        /// </summary>
        public string SearchAttributeValue { get; set; }
        /// <summary>
        /// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? ChangedSince { get; set; }
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
    #region ProductCategory
    public class ProductCategory : ErplyItem
    {
        /// <summary>
        /// Product category ID
        /// </summary>
        [JsonProperty("productCategoryID")]
        public int? ID { get; set; }
        public int? ParentCategoryID { get; set; }
        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Name in english
        /// </summary>
        public string NameENG { get; set; }
        /// <summary>
        /// Name in spanish
        /// </summary>
        public string NameSPA { get; set; }
        /// <summary>
        /// Name in german
        /// </summary>
        public string NameGER { get; set; }
        /// <summary>
        /// Name in swedish
        /// </summary>
        public string NameSWE { get; set; }
        /// <summary>
        /// Name in finnish
        /// </summary>
        public string NameFIN { get; set; }
        /// <summary>
        /// Name in russian
        /// </summary>
        public string NameRUS { get; set; }
        /// <summary>
        /// Name in estonian
        /// </summary>
        public string NameEST { get; set; }
        /// <summary>
        /// Name in latvian
        /// </summary>
        public string NameLAT { get; set; }
        /// <summary>
        /// Name in lithuanian
        /// </summary>
        public string NameLIT { get; set; }
        /// <summary>
        /// Name in greek
        /// </summary>
        public string NameGRE { get; set; }
        [JsonProperty("productCategoryName")]
        private string productCategoryName
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
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
    #region SaveProductCategory Settings
    public class SaveProductCategorySettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveProductCategories";

        [ErplyConverter(typeof(ErplyConverter))]
        public ProductCategory ProductCategory { get; set; }
    }
    #endregion

    #region GetProductPriorityGroups Settings
    public class GetProductPriorityGroupsSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "getProductPriorityGroups";

        /// <summary>
        /// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? ChangedSince { get; set; }
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
    #region ProductPriorityGroup
    public class ProductPriorityGroup : ErplyCall
    {
        [JsonProperty("priorityGroupID")]
        public int? ID { get; set; }
        [JsonProperty("priorityGroupName")]
        [ErplyProperty("name")]
        public string Name { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? LastModified { get; set; }
    }
    #endregion
    #region SaveProductPriorityGroup Settings
    public class SaveProductPriorityGroupSettings : ErplyCall
    {

        [JsonIgnore]
        public override string CallName { get; set; } = "saveProductPriorityGroup";

        [ErplyConverter(typeof(ErplyConverter))]
        public ProductPriorityGroup ProductPriorityGroup { get; set; }
    }
    #endregion

    #region ProductUnit
    public class ProductUnit : ErplyItem
    {
        public int? UnitID { get; set; }
        [JsonProperty("productUnitID")]
        private int? productUnitID => UnitID;
        public string Name { get; set; }
    }
    #endregion
    #region SaveProductUnit Settings
    public class SaveProductUnitSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveProductUnit";

        [ErplyConverter(typeof(ListConverter))]
        public ProductUnit ProductUnit { get; set; }
    }
    #endregion

    #region GetProductPrices Settings
    public class GetProductPricesSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "getProductPrices";

        public int? ProductID { get; set; }
        /// <summary>
        /// Multiple product IDs. Returns error 1162 if the list is longer than 10 000 elements. 
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> ProductIDs { get; set; }
        /// <summary>
        /// Customer ID 
        /// </summary>
        public int? ClientID { get; set; }
        /// <summary>
        /// Sales location ID 
        /// </summary>
        public int? WarehouseID { get; set; }
    }
    #endregion
    #region ProductPrices
    public class ProductPrices : ErplyItem
    {
        public int? ProductID { get; set; }
        public float? DefaultPrice { get; set; }
        public float? DefaultPriceWithVAT { get; set; }
        public float? SpecialPrice { get; set; }
        public float? SpecialPriceWithVAT { get; set; }
    }
    #endregion

    #region GetProductCostForSpecificAmount Settings
    public class GetProductCostForSpecificAmountSettings : ErplyCall
    {
        public int? WarehouseID { get; set; }
        public List<ProductAmount> ProductAmounts { get; set; }
    }
    public class ProductAmount
    {
        public int ProductID { get; set; }
        public int Amount { get; set; }
    }
    #endregion
    #region ProductCostForSpecificAmount
    public class ProductCostForSpecificAmount : ErplyCall
    {
        /// <summary>
        /// Product ID  
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// Requested amount  
        /// </summary>
        public float? Amount { get; set; }
        /// <summary>
        /// Unit cost.  
        /// </summary>
        public float? Cost { get; set; }
        /// <summary>
        /// IF THERE IS NOT ENOUGH INVENTORY, API can only return a preliminary cost value! This is because the real cost will be determined by the next Purchase Invoice or Inventory Registration. If that is the case, costIsPreliminary will be set to true and amountActuallyInStock will tell the actual current stock quantity.  
        /// </summary>
        public float? AmountActuallyInStock { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool? CostIsPreliminary { get; set; }
    }
    #endregion

    #region GetProductStock Settings
    public class GetProductStockSettings : ErplyCall
    {
        /// <summary>
        /// When using old inventory system, then warehouseID is a required parameter.
        /// If this parameter is omitted, then the total stock will be returned. Don't omit the warehouseID when syncing stock amounts, use API call syncTotalProductStock instead. 
        /// </summary>
        public int? WarehouseID { get; set; }
        /// <summary>
        /// Retrieve one specific product. 
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// Retrieve specific products. Multiple product IDs.
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> ProductIDs { get; set; }
        /// <summary>
        /// Retrieve products in this specific product group. 
        /// </summary>
        public int? GroupID { get; set; }
        /// <summary>
        /// Retrieve products in this product group, or in any of its sub-groups, sub-subgroups etc. 
        /// </summary>
        public int? GroupIDWithSubgroups { get; set; }
        /// <summary>
        /// Retrieve products of this supplier.
        /// </summary>
        public int? SupplierID { get; set; }
        /// <summary>
        /// Retrieve products of this brand.
        /// </summary>
        public int? BrandID { get; set; }
        /// <summary>
        /// Retrieve products in this priority group.
        /// </summary>
        public int? PriorityGroupID { get; set; }
        /// <summary>
        /// Retrieve products in this specific category. 
        /// </summary>
        public int? CategoryID { get; set; }
        /// <summary>
        /// Retrieve products in this category, or in any of its sub-categories, sub-sub-categories etc. 
        /// </summary>
        public int? CategoryIDWithSubcategories { get; set; }
        /// <summary>
        /// Retrieve variations of this matrix product.
        /// </summary>
        public int? ParentProductID { get; set; }
        /// <summary>
        /// Filter products by status.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ProductStockProductStatus? Status { get; set; }
        /// <summary>
        /// If set to true, then offline warehouses are not included in the result.
        /// This parameter should be used, when warehouseID is not set.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? ExcludeOfflineWarehouses { get; set; }
        /// <summary>
        /// If set to true, API also returns Reorder Points and Restock Levels for each item.
        /// When set to true, then warehouseID is required
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetReorderPoints { get; set; }
        /// <summary>
        /// If set to true, API also returns reserved amounts. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetAmountReserved { get; set; }
        /// <summary>
        /// If set to true, API also returns suggested cost for each item.
        /// For a definition of "suggested cost", see the description of the "suggestedPurchasePrice" field below.
        /// When set to true, then warehouseID is required
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetSuggestedPurchasePrice { get; set; }
        /// <summary>
        /// If set to true, API also returns average purchase price and average cost.
        /// When set to true, then warehouseID is required
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetAveragePrices { get; set; }
        /// <summary>
        /// If set to true, API also returns first purchase date. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetFirstPurchaseDate { get; set; }
        /// <summary>
        /// If set to true, API also returns most recent purchase date. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetLastPurchaseDate { get; set; }
        /// <summary>
        /// If set to true, API also returns most recent sale date. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetLastSoldDate { get; set; }
        /// <summary>
        /// If set to true, API returns only products with Reorder Point defined.
        /// When set to true, then warehouseID is required
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetProductsWithReorderPointDefined { get; set; }
        /// <summary>
        /// If set to true, API returns only products with Restock Level defined.
        /// When set to true, then warehouseID is required
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetProductsWithRestockLevelDefined { get; set; }
        /// <summary>
        /// Retrieve inventory quantities on given date. Either date or changedSince can be set, but not both at the same time. 
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Get only items for which the amount on hand has recently changed 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? ChangedSince { get; set; }
        /// <summary>
        /// This API call may return a lot of data (tens of thousands of records) and the output is non-pageable. If you have a large database, API may be unable to serve the request — you will get an error code or empty output. 
        /// However, there is an alternative way: you may use CSVMethod, which will download gotten CSV file and parse it to List<ProductStock>.
        /// NB! Using this method may take time, because all product stocks will be downloaded. USE WITH CAUTION!
        /// </summary>
        [JsonIgnore]
        public bool UseCSVMethod { get; set; }
        [JsonProperty("responseType")]
        private string ResponseType
        {
            get
            {
                return UseCSVMethod ? "CSV" : null;
            }
        }
    }
    public enum ProductStockProductStatus
    {
        ACTIVE,
        NO_LONGER_ORDERED,
        NOT_FOR_SALE,
        ARCHIVED,
        /// <summary>
        /// All non-archived items (ie. items that are active, not for sale or no longer ordered). 
        /// </summary>
        ALLEXCEPT_ARCHIVED,
        /// <summary>
        /// All orderable items, skipping archived products and those marked as "not ordered any more". 
        /// </summary>
        ACTIVE_AND_NOT_FOR_SALE
    }
    #endregion
    #region ProductStock
    public class ProductStock : ErplyItem
    {
        /// <summary>
        /// Product ID.  
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// Total amount on hand.
        /// This includes the amounts that are reserved to specific customers: via Sales Orders, for example.If you want to get only available inventory, subtract amountReserved from amountInStock.
        /// </summary>
        public float? AmountInStock { get; set; }
        /// <summary>
        /// Reserved amount (eg. pending Sales Orders).
        /// To retrieve this field, set getAmountReserved = 1.  
        /// </summary>
        public float? AmountReserved { get; set; }
        /// <summary>
        /// "Suggested cost" for the item. If you add this product to a Purchase Order, Erply will populate the "Price" field with this value.
        /// The value is derived as follows:
        /// If the product has a supplier, and there is a "supplier price list" for that supplier, the product's price in supplier's price list is returned.
        /// Otherwise, the price on most recent purchase invoice(regardless of supplier or location) is returned.
        /// If there have not been any purchase invoices containing that product, cost from product card is returned.
        /// If no cost defined on product card, the product's cost from the most recent Inventory Registration (regardless of location) is returned.
        /// To retrieve this field, set getSuggestedPurchasePrice = 1.
        /// </summary>
        public float? SuggestedPurchasePrice { get; set; }
        /// <summary>
        /// Weighted average purchase price, for the batches that are currently in stock. To retrieve this field, set getAveragePrices = 1.  
        /// </summary>
        public float? AveragePurchasePrice { get; set; }
        /// <summary>
        /// Weighted average cost, for the batches that are currently in stock.
        /// Cost = purchase price + freight costs.If you multiply this field by amountInStock, you will get the total current value of your inventory.
        /// Whenever you sell from inventory, ERPLY will naturally calculate cost for the specific sold items, not use this average value. Each sold item has its own cost, since it is drawn from a specific batch (according to FIFO). If you are interested in the cost of the sold item, you can use API calls:
        /// getProductCostForSpecificAmount — if you need to know the cost before you create the sales document.
        /// getCostOfGoodsSold — if the sale has already taken place. Returns all sold items and their costs in a specified time period.
        /// getSalesDocuments — returns the total cost of all items on the invoice (field "cost"), if you specify input parameter getCOGS = 1.
        /// To retrieve this field, set getAveragePrices = 1.
        /// </summary>
        public float? AverageCost { get; set; }
        /// <summary>
        /// First purchase date. To retrieve this field, set getFirstPurchaseDate = 1. 
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? FirstPurchaseDate { get; set; }
        /// <summary>
        /// Most recent purchase date. To retrieve this field, set getLastPurchaseDate = 1. 
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? LastPurchaseDate { get; set; }
        /// <summary>
        /// Most recent sale date. To retrieve this field, set getLastSoldDate = 1. 
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? LastSoldDate { get; set; }
        /// <summary>
        /// Reorder point. (If amount on hand drops below that point, the item should be re-stocked.)  
        /// </summary>
        public int? ReorderPoint { get; set; }
        /// <summary>
        /// Restock level. (Suggested amount to have on hand. The item is usually re-stocked up to this quantity.)  
        /// </summary>
        public int? RestockLevel { get; set; }
    }
    #endregion
}
