#region Products

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
/// Retrieve specific products. Multiple product IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Filter by product type. You can specify multiple product types, separated by commas (eg. "BUNDLE,ASSEMBLY").
/// Possible types are:
/// PRODUCT
/// BUNDLE
/// MATRIX
/// ASSEMBLY.
/// For a more detailed description of each type, please see below.
/// Please note that matrix variations (specific colors and sizes of a matrix product) are regular products; there is no separate type for those. To include or exclude matrix variations, please see the next filter: includeMatrixVariations. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// This filter is for retrieving or excluding matrix variations (specific colors or sizes of a matrix product). By default, variations are included.
/// This filter helps you with the following two use cases:
/// 1. If you only need to retrieve regular items and matrix parent products (NO variations), set the following filters:
/// type = "PRODUCT,BUNDLE,MATRIX,ASSEMBLY"
/// includeMatrixVariations = 0
/// 2. If you only need to retrieve regular items and matrix variations (ie. only items you can sell; NO matrix parent products), set the following filter:
/// type = "PRODUCT,BUNDLE,ASSEMBLY"
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IncludeMatrixVariations { get; set; }
/// <summary>
/// Retrieve products in this specific product group. (See getProductGroups.) 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Retrieve products in this product group, or in any of its sub-groups, sub-subgroups etc. 
/// </summary>
public int? GroupIDWithSubgroups { get; set; }
/// <summary>
/// Retrieve products in specific product groups, or in any of their sub-groups, sub-subgroups etc. Multiple group IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> GroupIDsWithSubgroups { get; set; }
/// <summary>
/// Retrieve products in this specific category. (See getProductCategories.) 
/// </summary>
public int? CategoryID { get; set; }
/// <summary>
/// Retrieve products in this category, or in any of its sub-categories, sub-sub-categories etc. 
/// </summary>
public int? CategoryIDWithSubcategories { get; set; }
/// <summary>
/// Retrieve products in this priority group. (See getProductPriorityGroups.) 
/// </summary>
public int? PriorityGroupID { get; set; }
/// <summary>
/// Retrieve products of this supplier. (See getSuppliers.) 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Retrieve products of this brand. (See getBrands.) 
/// </summary>
public int? BrandID { get; set; }
/// <summary>
/// Retrieve products that have this specific unit. (See getProductUnits.) 
/// </summary>
public int? UnitID { get; set; }
/// <summary>
/// Retrieve products that have this VAT / tax rate set on product card. (See getVatRates.) 
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Retrieve only the variations of one specific matrix product. 
/// </summary>
public int? ParentProductID { get; set; }
/// <summary>
/// Search for a product by code, exact matches only.
/// For more sophisticated product search options, see input parameters findBestMatch or searchNameIncrementally. 
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
/// For more sophisticated product search options, see input parameters findBestMatch or searchNameIncrementally.. 
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
/// If set to 1, and you have supplied input parameters "seachName" or "searchNameIncrementally", API will search from anywhere within the code field, not just the beginning. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SearchCodeFromMiddle { get; set; }
/// <summary>
/// Search from product name (anywhere within the name field), product code (from the beginning), or EAN / UPC (from the beginning).
/// For more sophisticated product search options, see input parameters findBestMatch or searchNameIncrementally. 
/// </summary>
public string SearchName { get; set; }
/// <summary>
/// A more optimized product search. Specify your search phrase, and API will check whether it matches product code, EAN/UPC OR product name. It is meant for cases where API should return quickly the most relevant results, but the search does not have to be exhaustive.
/// API will also look for partial matches.
/// When using searchNameIncrementally, the results are not ordered and you cannot use paging (pageNo), nor specify how many results you want to retrieve. Pay no attention to the "recordsTotal" field - it returns a random large number!
/// API tries the following search combinations:
/// Exact product code match?
/// Exact EAN/UPC match?
/// Product code or EAN beginning matches, or name contents match?
/// </summary>
public string SearchNameIncrementally { get; set; }
/// <summary>
/// Set findBestMatch = 1 and send input parameters code, code2, and/or name, each of which may contain a different search phrase. API will try to find a best exact match, trying different search combinations:
/// code, code2, name;
/// code, code2;
/// code2, name;
/// code2;
/// code, name;
/// code;
/// name.
/// This search option is useful for importing products. You may have a product code, EAN/UPC and product name (or any combination of these) — and you want a certain answer whether this exact item already exists in ERPLY or not.
/// Therefore, API will only return exact, not partial matches.
/// You may also use input parameter parentProductID to find a match ONLY from among the variations of a specific matrix product. This is the only additional filter which can be combined with findBestMatch = 1! 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? FindBestMatch { get; set; }
/// <summary>
/// Specify active = 0 to get archived products. (Filter status = ARCHIVED gives the same results.)
/// Specify active = 1 to get all non-archived products. (Filter status = ALL_EXCEPT_ARCHIVED gives the same results.)
/// A non-archived product can be either active, no longer ordered, or not for sale. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Filter products by status: ACTIVE, NO_LONGER_ORDERED, NOT_FOR_SALE, ARCHIVED, or ALL_EXCEPT_ARCHIVED.
/// The last one returns all non-archived items (ie. items that are active, not for sale or no longer ordered). 
/// </summary>
public string Status { get; set; }
/// <summary>
/// If specified, API returns only non-stock products. Salon / SPA module must be enabled. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NonStockProduct { get; set; }
/// <summary>
/// Set to 1 to retrieve only the frequently-used products that are displayed in POS as quick-select buttons.
/// Each location may have different quick-select buttons. If you want the buttons for a specific store, use warehouseID input parameter. If you omit it, you will get the "default" selection. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? QuickPosProducts { get; set; }
/// <summary>
/// Set to 1 to retrieve only the products that are serial numbered gift cards. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GiftCards { get; set; }
/// <summary>
/// Set this flag to 1 to retrieve only the products that are regular (non-numbered, non-serialized) gift cards.
/// Setting this field to 0, to omit regular gift cards and fetch everything else, does not work. Field value 0 is equivalent to not applying the filter at all.
/// </summary>
public string RegularGiftCards { get; set; }
/// <summary>
/// Set to 1 to retrieve only the products that are displayed in webshop. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? DisplayedInWebshop { get; set; }
/// <summary>
/// Set to 1 to retrieve inventory quantities for selected products.
/// Note that product's timestamp does not change when its inventory quantity changes. Therefore you cannot use getProducts to synchronize inventory quantitites. For that purpose, see API call getProductStock instead.
/// Omit if not needed. Retrieving quantities takes extra resources and results are returned slower.  
/// </summary>
public string GetStockInfo { get; set; }
/// <summary>
/// Set to 1 to retrieve FIFO costs and purchase prices for selected products.
/// Omit if not needed. Retrieving costs takes extra resources and results are returned slower.  
/// </summary>
public string GetFIFOCost { get; set; }
/// <summary>
/// Set to 1 to retrieve more information about the beverage container that goes with this product.
/// You will be needing this feature if shops are required to show beverage container as a separate item on invoice, and charge an additional fee for that. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetContainerInfo { get; set; }
/// <summary>
/// Set to 1 to retrieve information about the various-sized packages for this product.
/// For each product that has packages, API will return an additional sub-structure named "productPackages". 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetPackageInfo { get; set; }
/// <summary>
/// Set to 1 to retrieve replacement products for selected products.  
/// </summary>
public string GetReplacementProducts { get; set; }
/// <summary>
/// Set to 1 to retrieve related products for selected products.  
/// </summary>
public string GetRelatedProducts { get; set; }
/// <summary>
/// Set to 1 to retrieve a detailed list of variations for a matrix product: product name, code, EAN / UPC, color and size for each variation. See output element variationList. By default (without setting getMatrixVariations = 1) you will only get the IDs of variation products. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetMatrixVariations { get; set; }
/// <summary>
/// Set to 1 to retrieve related files for selected products.  
/// </summary>
public string GetRelatedFiles { get; set; }
/// <summary>
/// Set to 1 to retrieve components for selected products (if selected product is a bundle or an assembly product).  
/// </summary>
public string GetRecipes { get; set; }
/// <summary>
/// Set to 1 to retrieve parameters for selected products. Parameters module must be enabled. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetParameters { get; set; }
/// <summary>
/// Set to 1 to retrieve quantities of packaging materials for selected products. Packaging module must be enabled. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetPackagingMaterials { get; set; }
/// <summary>
/// Set to 1 to retrieve price list prices. You can use warehouseID parameter to retrieve product's sales price for a specific warehouse. You can use clientID parameter to retrieve product's sales price for a specific customer.  
/// </summary>
public string GetPriceListPrices { get; set; }
/// <summary>
/// Set to 1 to retrieve a set of records detailing how price list price was received. If you specify "getPriceCalculationSteps", input parameter getPriceListPrices" is required, too. This feature requires Classic back office, version 4.5.0 or newer. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetPriceCalculationSteps { get; set; }
/// <summary>
/// Set to 1 to retrieve only the products that are in first price list of a specific location. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetItemsFromFirstPriceListOnly { get; set; }
/// <summary>
/// Set to 1 retrieve sales price (VAT included) that applies to specified sales location. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetWarehouseSpecificVAT { get; set; }
/// <summary>
/// Set to 1 to retrieve only the products that are in stock at specific location. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetOnlyItemsInStock { get; set; }
/// <summary>
/// "SALES" or "ORDERING".
/// A filter to retrieve only sellable products, or only products that can be reordered from supplier. This filter will use product's own status, and also product's status in assortment, if an assortment has been set for the selected location.
/// If you specify "getProductsFor", input parameter "warehouseID" is required, too.
/// Cannot be used together with input parameters "active", "status", "addedSince"" and "changedSince" . (The "active" and "status" filters would conflict with the logic of "getProductsFor", and this filtered dataset is complex enough that incrementally synchronizing it is not supported.)
/// Behavior of this filter if no assortment has been set for the selected location:
/// "SALES" will return "Active" and "No longer ordered" products.
/// "ORDERING" will return "Active" and "Not for sale" products.
/// Behavior of the filter if the selected location has an assortment:
/// "SALES" will return only products that are present in the assortment, and whose status BOTH on product card, and in assortment, is "Active" or "No longer ordered".
/// "ORDERING" will return only products that are present in the assortment, and whose status BOTH on product card, and in assortment, is "Active" or "Not for sale".
/// To enable the assortments module on your account, please contact customer support. This feature requires Classic back office, version 4.5.0 or newer. (This filter, however, can still be used even without the assortments module.)
/// </summary>
public string GetProductsFor { get; set; }
/// <summary>
/// Specify warehouse ID to:
/// 1) retrieve inventory quantities of selected products only in one specific warehouse. If not set, API will return inventory quantities for every warehouse. For performance reasons, it is recommended to always set this parameter if you do not need information about all warehouses simultaneously.
/// 2) retrieve price list prices in one specific location.
/// 3) retrieve POS quick select buttons for one specific location (quickPosProducts = 1) 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Customer ID (to retrieve price list prices for specified customer) 
/// </summary>
public int? ClientID { get; set; }
/// <summary>
/// IDs of selected values in product card extra field 1. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField1Values 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ExtraField1IDs { get; set; }
/// <summary>
/// IDs of selected values in product card extra field 2. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField2Values 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ExtraField2IDs { get; set; }
/// <summary>
/// IDs of selected values in product card extra field 3. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField3Values 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ExtraField3IDs { get; set; }
/// <summary>
/// IDs of selected values in product card extra field 4. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField4Values 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ExtraField4IDs { get; set; }
/// <summary>
/// Filter products by their "location in warehouse" ID. Multiple IDs, separated by commas. 
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
/// Example: let us assume that you have defined a parameter "Available colors", with possible options of "white", "red", yellow" and "blue". Use searchParameterOptionID to get all items that are available in blue.
/// Of course, to make the query, you need to know the ID of the "blue" option. API call getParameters provides all parameters and their options. 
/// </summary>
public int? SearchParameterOptionID { get; set; }
/// <summary>
/// Get products that have a specific parameter value.
/// Example 1: some product parameters are simple yes/no properties, eg. "does this product have batteries included". Assuming this parameter's ID is "456", you need to make the query searchParameterID = 456 if you want to get all products that have batteries included.
/// Example 2: Other parameters have scalar values, eg. the inner diameter of a ball bearing. Assuming the parameter ID is 789, you need to make the query searchParameterID = 789, searchParameterValue = "1/2" if you want to get all bearings with inner diameter of 1/2". 
/// </summary>
public int? SearchParameterID
searchParameterValue { get; set; }
/// <summary>
/// Get all new items that have been added since a specific point in time.
/// NOT RECOMMENDED. Instead, use "changedSince", which returns both new items and changed items. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? AddedSince { get; set; }
/// <summary>
/// Get all items that have been ADDED AND/OR CHANGED since a specific point in time. Use this field for synchronizing product database. Set changedSince equal to the time of last successful synchronization.
/// Some tips:
/// Use server's timestamp, eg. the one that is returned in every response header. Your clock may be different from server clock, so if you stamp the synchronization with a locally generated timestamp, you'll risk missing some updates.
/// Product's timestamp changes when product card is updated in Erply. Timestamp DOES NOT CHANGE when product's inventory quantity changes, eg. as a result of a sale, a confirmed Purchase Invoice, or a confirmed Inventory Registration.
/// If you want to synchronize inventory quantities, use API call getProductStock instead.
/// For each item that getProducts returns, check if you already have an item with that ID in your local database. If yes, update it. If not, add it as a new item.
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
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
/// 'name', 'code', 'productID', 'price', 'parentProductID', 'changed' or 'added'.
/// 'changed' sorts by last modification timestamp. Items that have been created but never changed yet, have a modification timestamp of 0 and are sorted at the end of the list.
/// 'added' sorts by creation timestamp.
/// 'parentProductID', combined with orderByDir = 'asc', is useful if you need to retrieve matrix products first, followed by matrix product variations. (Matrix products have parentProductID = 0; variations have a non-zero value.)
/// The default value is 'changed'. 
/// </summary>
public string OrderBy { get; set; }
/// <summary>
/// 'asc' (ascending order) or 'desc' (descending order). By default items are sorted in descending order. 
/// </summary>
public string OrderByDir { get; set; }
/// <summary>
/// Number of records API should return. By default API returns 20 records.
/// At most you can request 1000 products at a time (or only 100, if you have set getStockInfo = 1). 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// As an alternative to pageNo, you can specify an exact list offset like in SQL. recordOffset is 0-based, so if you are retrieving items 20 at a time,
/// pageNo = 1 is equivalent to recordOffset = 0,
/// pageNo = 2 is equivalent to recordOffset = 20
/// and so on. 
/// </summary>
public int? RecordOffset { get; set; }
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
/// For synchronization; retrieve all product groups that have been updated after a certain time. To learn more about synchronization best practices, see Synchronizing Data with “changedSince” 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
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

#region GetProductCategories Settings

public class GetProductCategoriesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductCategories";
public int? ParentCategoryID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
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

#region GetProductPrices Settings

public class GetProductPricesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductPrices";
public int? ProductID { get; set; }
/// <summary>
/// Multiple product IDs, separated by commas, such as: 1,2,3,4,5. Returns error 1162 if the list is longer than 10 000 elements. 
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

#region GetProductCostForSpecificAmount Settings

public class GetProductCostForSpecificAmountSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductCostForSpecificAmount";
public int? WarehouseID { get; set; }
/// <summary>
/// Product ID. You can ask cost for multiple products at once. Replace "#" with 1, 2, 3 etc. For example: productID1 and amount1, productID2 and amount2, etc. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// Product amount 
/// </summary>
public float? Amount# { get; set; }
}

#endregion

#region GetProductStock Settings

public class GetProductStockSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductStock";
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
/// Retrieve specific products. Multiple product IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Retrieve products in this specific product group. (See getProductGroups.) 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Retrieve products in this product group, or in any of its sub-groups, sub-subgroups etc. 
/// </summary>
public int? GroupIDWithSubgroups { get; set; }
/// <summary>
/// Retrieve products of this supplier. (See getSuppliers.) 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Retrieve products of this brand. (See getBrands.) 
/// </summary>
public int? BrandID { get; set; }
/// <summary>
/// Retrieve products in this priority group. (See getProductPriorityGroups.) 
/// </summary>
public int? PriorityGroupID { get; set; }
/// <summary>
/// Retrieve products in this specific category. (See getProductCategories.) 
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
/// Filter products by status: ACTIVE, NO_LONGER_ORDERED, NOT_FOR_SALE, ACTIVE_AND_NOT_FOR_SALE, ARCHIVED, or ALL_EXCEPT_ARCHIVED.
/// The last one returns all non-archived items (ie. items that are active, not for sale or no longer ordered).
/// IF you are building a Stock Replenishment Report, ACTIVE_AND_NOT_FOR_SALE is the recommended option. It returns all orderable items, skipping archived products and those marked as "not ordered any more". 
/// </summary>
public string Status { get; set; }
/// <summary>
/// If set to 1, then offline warehouses are not included in the result.
/// This parameter should be used, when warehouseID is not set. 
/// </summary>
public int? ExcludeOfflineWarehouses { get; set; }
/// <summary>
/// If set to 1, API also returns Reorder Points and Restock Levels for each item.
/// When set to 1, then warehouseID is required 
/// </summary>
public int? GetReorderPoints { get; set; }
/// <summary>
/// If set to 1, API also returns reserved amounts. 
/// </summary>
public int? GetAmountReserved { get; set; }
/// <summary>
/// If set to 1, API also returns suggested cost for each item.
/// For a definition of "suggested cost", see the description of the "suggestedPurchasePrice" field below.
/// When set to 1, then warehouseID is required 
/// </summary>
public int? GetSuggestedPurchasePrice { get; set; }
/// <summary>
/// If set to 1, API also returns average purchase price and average cost.
/// When set to 1, then warehouseID is required 
/// </summary>
public int? GetAveragePrices { get; set; }
/// <summary>
/// If set to 1, API also returns first purchase date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? GetFirstPurchaseDate { get; set; }
/// <summary>
/// If set to 1, API also returns most recent purchase date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? GetLastPurchaseDate { get; set; }
/// <summary>
/// If set to 1, API also returns most recent sale date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? GetLastSoldDate { get; set; }
/// <summary>
/// If set to 1, API returns only products with Reorder Point defined.
/// When set to 1, then warehouseID is required 
/// </summary>
public int? GetProductsWithReorderPointDefined { get; set; }
/// <summary>
/// If set to 1, API returns only products with Restock Level defined.
/// When set to 1, then warehouseID is required 
/// </summary>
public int? GetProductsWithRestockLevelDefined { get; set; }
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
}

#endregion

#region SaveProduct Settings

public class SaveProductSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveProduct";
/// <summary>
/// Product ID if you need to change existing product 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Product type, possible types are 'PRODUCT', 'BUNDLE', 'MATRIX', 'ASSEMBLY'. By default 'PRODUCT'.
/// When updating an existing product, API will leave product type unchanged. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// ID of product group. To get the list of product groups, use getProductGroups. 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// ID of product unit. To get the list of units, use getProductUnits. 
/// </summary>
public int? UnitID { get; set; }
/// <summary>
/// ID of product brand. To get the list of brands, use getBrands. 
/// </summary>
public int? BrandID { get; set; }
/// <summary>
/// Supplier ID 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// ID of VAT (tax) rate. To get the list of rates, use getVatRates. If omitted, system will apply the default rate. Note that when the item is sold, POS tax rate, if set, will override this. 
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// If set to 1, this product is tax free in ALL stores and sales locations, regardless of POS tax rate and regardless of this product's vatrateID. (Eg. a gift card.) 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TaxFree { get; set; }
/// <summary>
/// Product's code. Must be UNIQUE, unless the account is configured otherwise. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Product's second code (by convention, EAN barcode). Must be UNIQUE, unless the account is configured otherwise. 
/// </summary>
public string Code2 { get; set; }
/// <summary>
/// Third code of the item (note that this field may not be visible on product card by default). 
/// </summary>
public string Code3 { get; set; }
/// <summary>
/// Supplier's product code 
/// </summary>
public string SupplierCode { get; set; }
/// <summary>
/// Code 5 of the item. "Extra product codes" module must be enabled. 
/// </summary>
public string Code5 { get; set; }
/// <summary>
/// Code 6 of the item. "Extra product codes" module must be enabled. 
/// </summary>
public string Code6 { get; set; }
/// <summary>
/// Code 7 of the item. "Extra product codes" module must be enabled. 
/// </summary>
public string Code7 { get; set; }
/// <summary>
/// Code 8 of the item. "Extra product codes" module must be enabled. 
/// </summary>
public string Code8 { get; set; }
/// <summary>
/// If set to 1, this item is the active product. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Product status, possible statuses are 'ACTIVE', 'NO_LONGER_ORDERED', 'NOT_FOR_SALE' and 'ARCHIVED'. By default 'ACTIVE'. 
/// </summary>
public string Status { get; set; }
/// <summary>
/// If set to 1, this item is displayed in webshop. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? DisplayedInWebshop { get; set; }
/// <summary>
/// Product name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// Product description. ("Shorter" description, plain text.)
/// Field size depends on account. On newer accounts, the length of this field is 65,535 characters; on older accounts, it may be 2,000 characters. (The field can be resized upon request.)
/// </summary>
public string Description { get; set; }
/// <summary>
/// By default, description can be entered in one language only — unlike product name, which can be specified in all languages activated on the account.
/// By default, you can therefore only use the "description" field.
/// Upon request, customer support can activate at most three more description fields, for three languages. (If your account default language, for example, is English, then the English description must be stored in field "description" and field "descriptionENG" cannot be used.)
/// Field size depends on account. On newer accounts, the length of this field is 65,535 characters; on older accounts, it may be 2,000 characters. (The field can be resized upon request.)
/// </summary>
public string DescriptionEST { get; set; }
/// <summary>
/// See above. 
/// </summary>
public string DescriptionENG { get; set; }
/// <summary>
/// See above. 
/// </summary>
public string DescriptionRUS { get; set; }
/// <summary>
/// See above. 
/// </summary>
public string DescriptionFIN { get; set; }
/// <summary>
/// Longer description of the product. This is typically formatted in HTML, because Erply back office provides an HTML editor for modifying this field.
/// Field size depends on account. On newer accounts, the length of this field is 65,535 characters; on older accounts, it may be 4,000 characters. (The field can be resized upon request.)
/// </summary>
public string Longdesc { get; set; }
/// <summary>
/// By default, long description can be entered in one language only — unlike product name, which can be specified in all languages activated on the account.
/// By default, you can therefore only use the "longdesc" field.
/// Upon request, customer support can activate at most three more long description fields, for three languages. (If your account default language, for example, is English, then the English long description must be stored in field "longdesc" and field "longdescENG" cannot be used.)
/// Field size depends on account. On newer accounts, the length of this field is 65,535 characters; on older accounts, it may be 4,000 characters. (The field can be resized upon request.)
/// </summary>
public string LongdescEST { get; set; }
/// <summary>
/// See above. 
/// </summary>
public string LongdescENG { get; set; }
/// <summary>
/// See above. 
/// </summary>
public string LongdescRUS { get; set; }
/// <summary>
/// See above. 
/// </summary>
public string LongdescFIN { get; set; }
/// <summary>
/// Item's physical dimensions. Unit depends on region, check your Erply account (typically inches or mm). 
/// </summary>
public int? Length { get; set; }
public int? Width { get; set; }
public int? Height { get; set; }
/// <summary>
/// Item's net weight. Unit depends on region, check your Erply account (typically lbs or kg). 
/// </summary>
public float? NetWeight { get; set; }
/// <summary>
/// Item's gross weight (with packaging). Unit depends on region, check your Erply account (typically lbs or kg). 
/// </summary>
public float? GrossWeight { get; set; }
/// <summary>
/// Item's fluid volume, eg. for beverages or perfumery. Unit depends on locale, check your Erply account (typically mL or fl oz). 
/// </summary>
public int? Volume { get; set; }
/// <summary>
/// Default sales price of the product, excluding VAT. 
/// </summary>
public float? NetPrice { get; set; }
/// <summary>
/// Default sales price of the product, VAT included.
/// "netPrice" and "priceWithVat" do not have to be specified both - set one of them and API will calculate the other.
/// </summary>
public float? PriceWithVAT { get; set; }
/// <summary>
/// Set the value to 1 if you want the product to have a quick-select button in POS 
/// </summary>
public int? HasQuickSelectButton { get; set; }
/// <summary>
/// Set the value to 1 if this product is a serial-numbered gift card.
/// If such a product is sold from POS, its serial number should be recorded and saved into the registry of sold gift cards, using API call saveGiftCard. 
/// </summary>
public int? IsGiftCard { get; set; }
/// <summary>
/// Set the value to 1 if this product is a regular gift card. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsRegularGiftCard { get; set; }
/// <summary>
/// Set the value to 1 if this item must be non-discountable. Flag presently only applies to promotion discounts, product still can be discounted manually or using price list. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NonDiscountable { get; set; }
/// <summary>
/// Default length for the service in minutes. If Salon / SPA module is not enabled, function returns error 1006 
/// </summary>
public int? LengthInMinutes { get; set; }
/// <summary>
/// Service set-up time in minutes. Available only if Salon / Spa module is enabled on your account. 
/// </summary>
public int? SetupTimeInMinutes { get; set; }
/// <summary>
/// Service cleanup time in minutes. Available only if Salon / Spa module is enabled on your account. 
/// </summary>
public int? CleanupTimeInMinutes { get; set; }
/// <summary>
/// Set the value to 1 if this product does not grant customer reward points. Available only if Reward Points module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? RewardPointsNotAllowed { get; set; }
/// <summary>
/// Product cost 
/// </summary>
public float? Cost { get; set; }
public string ManufacturerName { get; set; }
public int? CategoryID { get; set; }
public int? PriorityGroupID { get; set; }
public int? CountryOfOriginID { get; set; }
/// <summary>
/// ID of another product, a beverage container that is always sold together with this item. 
/// </summary>
public int? ContainerID { get; set; }
/// <summary>
/// Number of beverage containers that this product contains. (Eg. if your product is "A Case of Coca-Cola", it might contain 24 cans.) 
/// </summary>
public int? ContainerAmount { get; set; }
public string DeliveryTime { get; set; }
/// <summary>
/// Amount of backbar charges for this service. 
/// </summary>
public float? BackbarCharges { get; set; }
/// <summary>
/// If set to 1, this product does not need printed labels. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? LabelsNotNeeded { get; set; }
/// <summary>
/// Set the value to 1 if this item is a non-stock product. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NonStockProduct { get; set; }
/// <summary>
/// If this field is set to 1, a prompt to enter price will appear in Berlin POS (3.26 and newer) every time the item is sold. Even if the item has a price on product card or price lists, cashier will override the price every time, so the price lists will not apply.
/// This feature can be used for random-weighted or random-priced items which are sold in units. (Inventory will be in units, but each unit might have a unique price given to it.)
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CashierMustEnterPrice { get; set; }
/// <summary>
/// (For Salon customers.) Set the value to 1 if this item is a service that walk-in customers can themselves select in the Walk-In View, and register for an appointment. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? WalkInService { get; set; }
/// <summary>
/// Type of packaging, Packaging module must be enabled, allowed values - "ORDINARY_PACKAGE", "METAL_BEVERAGE_PACKAGE" or "RETURNABLE_PACKAGE" 
/// </summary>
public string PackagingType { get; set; }
/// <summary>
/// ID of selected value in product card extra field 1. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField1Values. 
/// </summary>
public int? ExtraField1ID { get; set; }
/// <summary>
/// ID of selected value in product card extra field 2. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField2Values. 
/// </summary>
public int? ExtraField2ID { get; set; }
/// <summary>
/// ID of selected value in product card extra field 3. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField3Values. 
/// </summary>
public int? ExtraField3ID { get; set; }
/// <summary>
/// ID of selected value in product card extra field 4. The field on product card is a drop-down, and the possible values can be retrieved with API call getProductExtraField4Values. 
/// </summary>
public int? ExtraField4ID { get; set; }
/// <summary>
/// Reorder point. (If amount on hand drops below that point, the item should be re-stocked.)
/// Reorder point has to be defined for a specific warehouse / location. Replace # with warehouse ID, eg. reorderPoint1 for warehouse with ID = 1. 
/// </summary>
public float? ReorderPoint# { get; set; }
/// <summary>
/// Restock level. (Suggested amount to have on hand. The item is usually re-stocked up to this quantity.)
/// Restock level has to be defined for a specific warehouse / location. Replace # with warehouse ID, eg. restockLevel1 for warehouse with ID = 1. 
/// </summary>
public float? RestockLevel# { get; set; }
/// <summary>
/// Replacement product IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ReplacementProductIDs { get; set; }
/// <summary>
/// Related product IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> RelatedProductIDs { get; set; }
/// <summary>
/// Parent product ID. Only for matrix variations (specific colors/sizes of a matrix item). See guidelines below. 
/// </summary>
public int? ParentProductID { get; set; }
/// <summary>
/// ID of selected location in warehouse. 
/// </summary>
public int? LocationInWarehouseID { get; set; }
/// <summary>
/// Product's specific text added to location in warehouse. 
/// </summary>
public string LocationInWarehouseText { get; set; }
/// <summary>
/// Matrix product dimension ID. Only for matrix products. See guidelines below. 
/// </summary>
public int? DimensionID# { get; set; }
/// <summary>
/// Dimension Value ID. Only for matrix variations. See guidelines below. 
/// </summary>
public int? DimValueID# { get; set; }
/// <summary>
/// Guidelines for creating matrix products
/// Matrix items have 1...3 dimensions - color, size etc. Matrix dimensions can be defined in Erply backend (in Settings » Matrix Dimensions) or with API call saveMatrixDimension.
/// A dimension has a name (eg. "Letter Sizes" or Spring 2013 Colors") and a list of possible values (eg. S, M, L or Lime, Yellow, Fuchsia). API call getMatrixDimensions returns a list of all dimensions you have defined.
/// To create a matrix product, first pick the dimension(s) that apply to this particular product, eg "Waist Size" and "Length" for jeans. A matrix can have up to 3 dimensions.
/// Create the parent product (matrix product). You will not be selling this item directly, but Erply needs this item to group all sizes/colors together. Set:
/// type = MATRIX
/// dimensionID1 = first dimension ID
/// dimensionID2 = second dimension ID (if needed)
/// dimensionID3 = third dimension ID (if needed)
/// Create the specific variations (color/size combinations), each one as a separate product. Set:
/// type = PRODUCT
/// parentProductID = ID of the matrix item
/// dimValueID1, dimValueID2, dimValueID3 as needed (corresponding to how many dimensions the matrix has.)
/// </summary>
public   { get; set; }
/// <summary>
/// Sales package - amount of clear/brown glass. 
/// </summary>
public float? SalesPackageClearBrownGlass { get; set; }
/// <summary>
/// Sales package - amount of green/other glass. 
/// </summary>
public float? SalesPackageGreenOtherGlass { get; set; }
/// <summary>
/// Sales package - amount of plastic (PP, PE). 
/// </summary>
public float? SalesPackagePlasticPpPe { get; set; }
/// <summary>
/// Sales package - amount of plastic (PET). 
/// </summary>
public float? SalesPackagePlasticPet { get; set; }
/// <summary>
/// Sales package - amount of metal (Fe). 
/// </summary>
public float? SalesPackageMetalFe { get; set; }
/// <summary>
/// Sales package - amount of metal (Al). 
/// </summary>
public float? SalesPackageMetalAl { get; set; }
/// <summary>
/// Sales package - amount of other metal. 
/// </summary>
public float? SalesPackageOtherMetal { get; set; }
/// <summary>
/// Sales package - amount of cardboard. 
/// </summary>
public float? SalesPackageCardboard { get; set; }
/// <summary>
/// Sales package - amount of wood. 
/// </summary>
public float? SalesPackageWood { get; set; }
/// <summary>
/// Group package - amount of paper. 
/// </summary>
public float? GroupPackagePaper { get; set; }
/// <summary>
/// Group package - amount of plastic. 
/// </summary>
public float? GroupPackagePlastic { get; set; }
/// <summary>
/// Group package - amount of metal. 
/// </summary>
public float? GroupPackageMetal { get; set; }
/// <summary>
/// Group package - amount of wood. 
/// </summary>
public float? GroupPackageWood { get; set; }
/// <summary>
/// Transport package - amount of wood. 
/// </summary>
public float? TransportPackageWood { get; set; }
/// <summary>
/// Transport package - amount of plastic. 
/// </summary>
public float? TransportPackagePlastic { get; set; }
/// <summary>
/// Transport package - amount of cardboard. 
/// </summary>
public float? TransportPackageCardboard { get; set; }
/// <summary>
/// The product's identification number in a state registry (eg. for alcoholic beverages). 
/// </summary>
public string RegistryNumber { get; set; }
/// <summary>
/// Percentage of alcohol by volume in the beverage. 
/// </summary>
public float? AlcoholPercentage { get; set; }
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
public float? ExciseIntermediateProduct { get; set; }
public float? ExciseOtherAlcohol { get; set; }
public float? ExcisePackaging { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string LongAttributeName# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute. 
/// </summary>
public string LongAttributeValue# { get; set; }
/// <summary>
/// Parameter ID. 
/// </summary>
public int? ParameterID# { get; set; }
/// <summary>
/// Parameter value. Not needed for MULTIVALUE parameters. 
/// </summary>
public string ParameterValue# { get; set; }
/// <summary>
/// For MULTIVALUE parameters only. This should be a comma-separated list, containing those option ID-s that you want to be enabled. All other options will be disabled. 
/// </summary>
public string ParameterOptions# { get; set; }
public float? Parameter#optionID#additionalPrice { get; set; }
/// <summary>
/// Component ID. 
/// </summary>
public int? ComponentProductID# { get; set; }
/// <summary>
/// Amount. 
/// </summary>
public float? ComponentAmount# { get; set; }
}

#endregion

#region SaveProductGroup Settings

public class SaveProductGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveProductGroup";
/// <summary>
/// Product group ID if you need to change existing group 
/// </summary>
public int? ProductGroupID { get; set; }
/// <summary>
/// Product group name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// If group belongs to other group then include this parameter as parent group ID 
/// </summary>
public int? ParentGroupID { get; set; }
/// <summary>
/// If set to 1, this item is displayed in webshop. By default 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ShowInWebshop { get; set; }
/// <summary>
/// Set the value to 1 if this group's products and sub-groups must be non-discountable. Flag presently only applies to promotion discounts, product still can be discounted manually or using price list. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NonDiscountable { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveProductCategory Settings

public class SaveProductCategorySettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveProductCategory";
/// <summary>
/// Product category ID if you need to change existing category 
/// </summary>
public int? ProductCategoryID { get; set; }
/// <summary>
/// Product category name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// If category belongs to other category then include this parameter as parent category ID 
/// </summary>
public int? ParentCategoryID { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
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
/// <summary>
/// Contents of the binary image file, base64-encoded.
/// If file content is missing, API returns error 1090. If it cannot be base64-decoded, API returns error 1091. 
/// </summary>
public string Picture { get; set; }
/// <summary>
/// File name. If omitted, API will generate a random name for the image. 
/// </summary>
public string Filename { get; set; }
/// <summary>
/// Instead of uploading a file, it is possible to just provide a URL that points to the image file in an external location (a content delivery network). This feature is for internal purposes only and NOT recommended for use!
/// Must start with http:// or https://, otherwise API returns error 1015. 
/// </summary>
public string Url { get; set; }
/// <summary>
/// To be used with parameter "url". This should be a mutually-agreed classifier, identifying the CDN where the image is located. ERPLY needs it to know how to manipulate the remote images.
/// Must consist of letters and numbers only ([A-Za-z0-9]*), otherwise API returns error 1015. It cannot be used in conjunction with local image files (API will return error 1013). 
/// </summary>
public int? HostingProvider { get; set; }
}

#endregion

#region SaveMatrixDimension Settings

public class SaveMatrixDimensionSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveMatrixDimension";
/// <summary>
/// Dimension ID.
/// If this parameter is present the specified matrix dimension will be updated. 
/// </summary>
public int? DimensionID { get; set; }
/// <summary>
/// Dimension name (eg. "Color" or "Size"). 
/// </summary>
public string Name { get; set; }
public string ValueName# { get; set; }
public string ValueCode# { get; set; }
}

#endregion

#region DeleteProduct Settings

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

#region DeleteProductGroup Settings

public class DeleteProductGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteProductGroup";
/// <summary>
/// The product group to be deleted. 
/// </summary>
public int? ProductGroupID { get; set; }
}

#endregion

#region DeleteProductPicture Settings

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

#endregion
#region Customers

#region GetCustomers Settings

public class GetCustomersSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCustomers";
/// <summary>
/// Customer's ID 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// List of customer ID's, separated by commas, eg. "1,2,3,4,5". (Do not put spaces around commas.) 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CustomerIDs { get; set; }
/// <summary>
/// If set to 1, and you have supplied input parameters "seachName" or "searchPersonFullName", API will search from anywhere within the field, not just the beginning. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SearchFromMiddle { get; set; }
/// <summary>
/// Search by customer name, e-mail, phone, cellphone or customer card #. Partial matches are also returned, but InventoryAPI searches only from the beginning of each field. Set searchFromMiddle = 1 to search from anywhere within the field. 
/// </summary>
public string SearchName { get; set; }
/// <summary>
/// A more optimized customer search. It is meant for cases where API should return quickly the most relevant results, but the search does not have to be exhaustive.
/// When using searchNameIncrementally, the results are not ordered and you cannot use paging (pageNo), nor specify how many results you want to retrieve. Pay no attention to the "recordsTotal" field - it returns a random large number!
/// "searchNameIncrementally" also searches from company registry code / National ID (exact matches only), while input parameter "searchName" does not. 
/// </summary>
public string SearchNameIncrementally { get; set; }
/// <summary>
/// Search by person full name - first name, space and last name, eg. "John Smith". Partial matches are also returned, but InventoryAPI onlt searches from the beginning of the field. Set searchFromMiddle = 1 to search from anywhere within the field. 
/// </summary>
public string SearchPersonFullName { get; set; }
/// <summary>
/// Search by person first name. Exact matches only. 
/// </summary>
public string SearchPersonFirstName { get; set; }
/// <summary>
/// Search by person last name. Exact matches only. 
/// </summary>
public string SearchPersonLastName { get; set; }
/// <summary>
/// Search by email address. Exact matches only. 
/// </summary>
public string SearchEmail { get; set; }
/// <summary>
/// Search by mobile number. Exact matches only (including spaces). 
/// </summary>
public string SearchMobile { get; set; }
/// <summary>
/// Search by customer VAT no (field vatNumber). Exact matches only. 
/// </summary>
public string SearchVATNo { get; set; }
/// <summary>
/// Search by customer card # (field customerCardNumber). Exact matches only. 
/// </summary>
public string SearchCode { get; set; }
/// <summary>
/// Search by company registry code or person's national ID (field "code"). Exact matches only. 
/// </summary>
public string SearchRegistryCode { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Customer manager. (See getEmployees.) 
/// </summary>
public int? ClientManagerID { get; set; }
/// <summary>
/// Retrieve customers in this specific customer group. (See getCustomerGroups.) 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Retrieve customers in this specific customer group, or in any of its sub-groups, sub-sub-groups etc (if you have a multi-level tree of customer groups). 
/// </summary>
public int? GroupIDWithSubgroups { get; set; }
/// <summary>
/// Payer ID. 
/// </summary>
public int? PayerID { get; set; }
/// <summary>
/// Filter customers by tax office ID.
/// This is a Greece-specific field and this filter can only be used on Greek accounts. On other accounts, API will return error code 1128. 
/// </summary>
public int? TaxOfficeID { get; set; }
/// <summary>
/// Whether the customer is marked with an importance flag or not. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? FlagStatus { get; set; }
/// <summary>
/// Optional colored flag associated with this customer. Possible values: "", "red", "green", "yellow", "blue". 
/// </summary>
public string ColorStatus { get; set; }
/// <summary>
/// CUSTOMERS, CONTACTS or ALL.
/// By default CUSTOMERS.
/// ERPLY makes a distiction between 1) companies and persons who are customers in their own right, and 2) persons who are marked as contact persons of some other customer. Option "CUSTOMERS" returns only the first ones, "CONTACTS" returns only the second ones and "ALL" returns both. 
/// </summary>
public string Mode { get; set; }
/// <summary>
/// If set to 1, API also returns balance info for selected customers.
/// If you need to retrieve balances only, without customer information, take a look at API call getCustomerBalances. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetBalanceInfo { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? GetBalanceWithoutPrepayments { get; set; }
/// <summary>
/// If set to 1, API returns all default customers used for POS transactions 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetPOSDefaultCustomers { get; set; }
/// <summary>
/// Set to 1 to retrieve all addresses for selected customers. API will return the list in element "addresses", see below.
/// If you need to retrieve addresses only, without customer information, take a look at API call getAddresses. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetAddresses { get; set; }
/// <summary>
/// Set to 1 to retreive contact persons for selected customers. API will return the list in element "contactPersons", see below. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetContactPersons { get; set; }
/// <summary>
/// Set to 1 to retrieve relationships for selected customers.
/// A customer can have zero or more "associations" and zero or more "professionals" linked to them, and each one of those "associations" and professionals" is a customer in itself. One of the "associations" can be a "default association", and one of the "professionals" can be a "default professional".
/// To add a new link (relationship), ie. to specify that Customer X is an "association" for Customer Y, see the API calls saveCustomerAssociation, saveCustomerProfessional, deleteCustomerAssociation and deleteCustomerProfessional.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetAssociationsAndProfessionals { get; set; }
/// <summary>
/// If set to 1, API will not report an accurate total number of search results (the recordsTotal field will return some constant large number). This can be used to make queries more efficient. When using doNotCalculateRecordsTotal, just ask for paged results until API will no longer return any (that indicates you hve reached the end of dataset).  
/// </summary>
public string DoNotCalculateRecordsTotal { get; set; }
/// <summary>
/// Filter customers by birthday — get all customers whose birthday is on or after the specified month and day.
/// If you only specify birthdayMonthDayFrom and not birthdayMonthDayTo, all birthdays between the specified day and the end of the year are returned.
/// Combine the two filters to get birthdays in a specific range (eg. birthdays in June or July). Year wrap-around is supported: filter birthdayMonthDayFrom = "12-01", birthdayMonthDayTo = "01-31" returns birthdays in December and January.
/// Both month and day must be two digits. Use a leading zero if necessary.
/// </summary>
[JsonConverter(typeof(ISODateMMddConverter))]
public string BirthdayMonthDayFrom { get; set; }
/// <summary>
/// Filter customers by birthday — get all customers whose birthday is on or before the specified month and day.
/// If you only specify birthdayMonthDayTo and not birthdayMonthDayFrom, all birthdays between the beginning of the year and the specified day are returned.
/// Combine the two filters to get birthdays in a specific range (eg. birthdays in June or July). Year wrap-around is supported: filter birthdayMonthDayFrom = "12-01", birthdayMonthDayTo = "01-31" returns birthdays in December and January.
/// Both month and day must be two digits. Use a leading zero if necessary.
/// </summary>
[JsonConverter(typeof(ISODateMMddConverter))]
public string BirthdayMonthDayTo { get; set; }
/// <summary>
/// Get all new items that have been added since a specific point in time. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTimeFrom { get; set; }
/// <summary>
/// Get all new items that have been added before a specific point in time. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTimeTo { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
public string OrderBy { get; set; }
public string OrderByDir { get; set; }
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

#region GetAddresses Settings

public class GetAddressesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAddresses";
/// <summary>
/// Customer ID, supplier ID, or your own company's ID. See getCustomers and getSuppliers. (Customer and supplier IDs do not overlap.) Deprecated alternative name: clientID 
/// </summary>
public int? OwnerID { get; set; }
/// <summary>
/// Address type ID. See getAddressTypes. 
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
public string AddedSince { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
public string OrderBy { get; set; }
public string OrderByDir { get; set; }
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

#region GetCustomerGroups Settings

public class GetCustomerGroupsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCustomerGroups";
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetAddressTypes Settings

public class GetAddressTypesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAddressTypes";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetDefaultCustomer Settings

public class GetDefaultCustomerSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getDefaultCustomer";
/// <summary>
/// The default customer can be different for each location and register. Specify pointOfSaleID to get the correct default customer for this specific register. 
/// </summary>
public int? PointOfSaleID { get; set; }
}

#endregion

#region SaveCustomer Settings

public class SaveCustomerSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCustomer";
/// <summary>
/// ID of a customer. If this parameter is present, then the specified customer is updated. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// When companyTypeID is not known, API will try to parse the type from the value. Value will be changed (type removed) when it is found.
/// When companyTypeID is known then value will be saved as given. 
/// </summary>
public string CompanyName { get; set; }
/// <summary>
/// Value will be always saved as given. When used without companyTypeID then the first available will be set.
/// When used together with companyName then companyName will always be used instead. 
/// </summary>
public string CompanyName2 { get; set; }
/// <summary>
/// If is not set - company type ID will be calculated by analysing companyName for type-related parts.
/// If companyName2 is used then the first available will be set instead 
/// </summary>
public int? CompanyTypeID { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
public string FullName { get; set; }
/// <summary>
/// ID of a customer's title. 
/// </summary>
public int? PersonTitleID { get; set; }
/// <summary>
/// Email address for e-invoices. If this is empty, then the regular email address is used. 
/// </summary>
public string EInvoiceEmail { get; set; }
/// <summary>
/// Indicates whether the customer would like to get invoices on their email. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? EmailEnabled { get; set; }
/// <summary>
/// Indicates whether the customer would like to get e-invoices. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? EInvoiceEnabled { get; set; }
/// <summary>
/// If e-invoice operator supports sending paper mails and this value is set to 1, then the operator is allowed to send the invoice by mail (additional charges might occur). 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? MailEnabled { get; set; }
public int? OperatorIdentifier { get; set; }
/// <summary>
/// Gender: "male", "female" or empty string. For persons only. 
/// </summary>
public string Gender { get; set; }
/// <summary>
/// Customer group ID. Use getCustomerGroups. If not specified, customer will be assigned to the first customer group in the list.
/// When updating existing customer, groupID must not be set to 0. 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// National ID number (for persons) / Registry code (for companies). 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Customer's VAT number. 
/// </summary>
public string VatNumber { get; set; }
public string Email { get; set; }
public string Phone { get; set; }
public string Mobile { get; set; }
public string Fax { get; set; }
public string Skype { get; set; }
/// <summary>
/// Customer's image content in base64. Use base64_encode($imagefile) 
/// </summary>
public string ImageContent { get; set; }
/// <summary>
/// Image mime-type, allowed types are image/gif and image/jpeg 
/// </summary>
public string ImageMimeType { get; set; }
public string Website { get; set; }
/// <summary>
/// Name of customer's bank. 
/// </summary>
public string BankName { get; set; }
/// <summary>
/// Number of customer's bank account. 
/// </summary>
public string BankAccountNumber { get; set; }
/// <summary>
/// IBAN number of customer's bank account. 
/// </summary>
public string BankIBAN { get; set; }
/// <summary>
/// BIC/SWIFT identifier of customer's bank account. 
/// </summary>
public string BankSWIFT { get; set; }
/// <summary>
/// Person's birthday (not applicable to companies). 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Birthday { get; set; }
/// <summary>
/// Corresponding customer identifier in a system integrated with Erply (eg. accounting software) 
/// </summary>
public string IntegrationCode { get; set; }
/// <summary>
/// Person's job title ID. 
/// </summary>
public int? JobTitleID { get; set; }
/// <summary>
/// Use to indicate that this person is a contact person / an employee in a particular company.. 
/// </summary>
public int? CompanyID { get; set; }
/// <summary>
/// Customer manager (must be an employee, use getEmployees). 
/// </summary>
public int? CustomerManagerID { get; set; }
/// <summary>
/// Use to indicate that invoices to this customer must be addressed by default to another company. 
/// </summary>
public int? InvoicePayerID { get; set; }
/// <summary>
/// Default payment period for invoices. 
/// </summary>
public int? PaymentDays { get; set; }
/// <summary>
/// Penalty for overdue invoices, expressed as % per day, eg. "0.5". Free text. 
/// </summary>
public string PenaltyPerDay { get; set; }
/// <summary>
/// Credit limit. Use system's default currency. 
/// </summary>
public int? Credit { get; set; }
/// <summary>
/// Indicates that this customer is not allowed to receive invoices (up-front cash payments only). 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SalesBlocked { get; set; }
/// <summary>
/// Assign a reference number - if system is configured to use hand-created customer reference numbers. By default not necessary, since reference numbers are created automatically. 
/// </summary>
public string ReferenceNumber { get; set; }
/// <summary>
/// Assign the code of customer's loyalty/membership card. This code must match the sequence produced by card swipe. 
/// </summary>
public string CustomerCardNumber { get; set; }
/// <summary>
/// GLN. 
/// </summary>
public string GLN { get; set; }
/// <summary>
/// EDI code. 
/// </summary>
public string EDI { get; set; }
/// <summary>
/// Assign the customer a price list (see getPriceLists). 
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Customer's price list 2. 
/// </summary>
public int? PriceListID2 { get; set; }
/// <summary>
/// Customer's price list 3. 
/// </summary>
public int? PriceListID3 { get; set; }
/// <summary>
/// Customer type. Possible values are "DOMESTIC", "EU", "OUTSIDE_EU". 
/// </summary>
public string EuCustomerType { get; set; }
/// <summary>
/// DEPRECATED — euCustomerType is recommended instead. Indicate that this is a foreign customer, located outside EU. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? OutsideEU { get; set; }
/// <summary>
/// Customer's business area. Use getBusinessAreas. 
/// </summary>
public int? BusinessAreaID { get; set; }
/// <summary>
/// Country ID. Use getCountries. 
/// </summary>
public int? CountryID { get; set; }
/// <summary>
/// Tax office ID.
/// This is a Greece-specific field and can only be used on Greek accounts. Setting it on other accounts returns error code 1128.
/// To retrieve a list of tax offices, see getTaxOffices. 
/// </summary>
public int? TaxOfficeID { get; set; }
public string Notes { get; set; }
/// <summary>
/// User name for webshop access. Before assigning user name, use API call validateCustomerUsername to verify that the user name is unique (no other customer has it yet). 
/// </summary>
public string Username { get; set; }
/// <summary>
/// Password for webshop access. 
/// </summary>
public string Password { get; set; }
/// <summary>
/// Whether the customer is flagged or not. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? FlagStatus { get; set; }
/// <summary>
/// Color that the customer entry is marked with. Possible values: "", "yellow", "red", "blue", "green" 
/// </summary>
public string ColorStatus { get; set; }
/// <summary>
/// Indicates this customer is a tax exempt organization 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TaxExempt { get; set; }
/// <summary>
/// Indicates this customer pays invoices via factoring 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PaysViaFactoring { get; set; }
public int? TwitterID { get; set; }
public string FacebookName { get; set; }
/// <summary>
/// Last 4 numbers of customer's credit card 
/// </summary>
public string CreditCardLastNumbers { get; set; }
public int? DeliveryTypeID { get; set; }
/// <summary>
/// Location where customer was registered 
/// </summary>
public int? SignUpStoreID { get; set; }
/// <summary>
/// Most commonly used location 
/// </summary>
public int? HomeStoreID { get; set; }
/// <summary>
/// Indicates that this customer does not earn new reward points. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? RewardPointsDisabled { get; set; }
/// <summary>
/// Indicates that this customer ignores balance calculation. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CustomerBalanceDisabled { get; set; }
/// <summary>
/// Indicates that POS does not automatically print coupons to this customer. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PosCouponsDisabled { get; set; }
/// <summary>
/// Indicates that this customer is opted-out customer. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? EmailOptOut { get; set; }
/// <summary>
/// Indicates that for this customer, shipments should be (and may be) accompanied by a Waybill. At the end of the month, a summary Invoice can be issued for all the month's shipments and customer will pay then for all the shipments at once. (In the Sales module, there is a command "Create invoice from selected waybills"). If a customer does not have this flag, you should issue Invoice-Waybills instead, and the customer must pay for each shipment separately.
/// Field appears only if conf parameter enable_waybill_customers is set to 1 
/// </summary>
public int? ShipGoodsWithWaybills { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string LongAttributeName# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute. 
/// </summary>
public string LongAttributeValue# { get; set; }
}

#endregion

#region SaveAddress Settings

public class SaveAddressSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveAddress";
/// <summary>
/// Address ID. If this parameter is present, then the specified address is updated. 
/// </summary>
public int? AddressID { get; set; }
/// <summary>
/// Customer's or supplier's unique ID. (Not required if updating an existing address.) 
/// </summary>
public int? OwnerID { get; set; }
/// <summary>
/// Address type ID, see getAddressTypes. (Not required if updating an existing address.) 
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Street address.
/// If address cannot be split into parts, put the whole address into this field. 
/// </summary>
public string Street { get; set; }
/// <summary>
/// Street address, line 2. This field is exposed via Erply user interface only for US, CA and MX accounts! 
/// </summary>
public string Address2 { get; set; }
/// <summary>
/// City, region, or county 
/// </summary>
public string City { get; set; }
/// <summary>
/// Postal code or ZIP code. 
/// </summary>
public string PostalCode { get; set; }
/// <summary>
/// State. This field is exposed via Erply user interface only for US, CA and MX accounts! 
/// </summary>
public string State { get; set; }
public string Country { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveCustomerGroup Settings

public class SaveCustomerGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCustomerGroup";
/// <summary>
/// Customer group unique ID. 
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// Customer group name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
}

#endregion

#region VerifyCustomerUser Settings

public class VerifyCustomerUserSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "verifyCustomerUser";
public string Username { get; set; }
public string Password { get; set; }
}

#endregion

#region DeleteCustomer Settings

public class DeleteCustomerSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteCustomer";
/// <summary>
/// The customer to be deleted. 
/// </summary>
public int? CustomerID { get; set; }
}

#endregion

#region DeleteAddress Settings

public class DeleteAddressSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteAddress";
/// <summary>
/// The address to be deleted. 
/// </summary>
public int? AddressID { get; set; }
}

#endregion

#endregion
#region Sales

#region GetSalesDocuments Settings

public class GetSalesDocumentsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSalesDocuments";
/// <summary>
/// Search for a specific sales document by ID. 
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Multiple sales document IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> Ids { get; set; }
/// <summary>
/// Search for invoices by customer ID. When configuration parameter "api_getsalesdocuments_default_customer_sales_not_returned" is applied, and you use getSalesDocuments call with input parameter "clientID", and this is the ID of a default client, API returns an empty response. 
/// </summary>
public int? ClientID { get; set; }
/// <summary>
/// Multiple customer IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ClientIDs { get; set; }
public string ClientName { get; set; }
/// <summary>
/// Search for invoices created by this employee. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Search for invoices by warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Search for invoices by point of sale ID. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Search for invoices by project ID. 
/// </summary>
public int? ProjectID { get; set; }
/// <summary>
/// Search for invoices by product ID. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Filter invoices by payer. You can only use this filter if you have a "Payer" field on your back office invoice form — this depends on your account settings.
/// Note that setting the payer is not required, so this field may be empty on invoices.
/// </summary>
public int? PayerID { get; set; }
/// <summary>
/// Filter invoices by the recipient of goods. You can only use this filter if you have a "Ship To" field on your back office invoice form — this depends on your account settings.
/// Note that setting the recipient is not required, so this field may be empty on invoices.
/// </summary>
public int? ShipToID { get; set; }
/// <summary>
/// If this parameter is supplied, returns either only confirmed, or only non-confirmed sales documents. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
/// <summary>
/// Search for a sales document by number.
/// Please note that sales documents of different types may have the same numbers (eg. there might be an Order 100001 as well as an Invoice-Waybill 100001), so in some cases you might want to set the type filter as well.
/// By default, this field only searches for sales documents by their regular number. If you have assigned custom numbers to your sales documents (numbers that may contain letters and other characters, see saveSalesDocument → customNumber), you can enable configuration parameter search_invoice_by_regular_and_custom_number = 1, so that both fields would be searched simultaneously. 
/// </summary>
public int? Number { get; set; }
/// <summary>
/// Search by invoice number, customer name, e-mail, phone, cellphone or customer loyalty card #. API searches only from the beginning of each field.
/// Note that this only searches from regular invoice numbers, not custom ones. 
/// </summary>
public string NumberOrCustomer { get; set; }
/// <summary>
/// Search by reference number. 
/// </summary>
public string ReferenceNumber { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
/// <summary>
/// Search by deliveryDate field - customer requested delivery date for whole document. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDateFrom { get; set; }
/// <summary>
/// Search by deliveryDate field - customer requested delivery date for whole document. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDateTo { get; set; }
/// <summary>
/// Search by deliveryDate field in document rows - customer requested delivery date for one specific item. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? RowDeliveryDateFrom { get; set; }
/// <summary>
/// Search by deliveryDate field in document rows - customer requested delivery date for one specific item. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? RowDeliveryDateTo { get; set; }
/// <summary>
/// INVWAYBILL, CASHINVOICE, WAYBILL, PREPAYMENT, OFFER, EXPORTINVOICE, RESERVATION, CREDITINVOICE, ORDER, or INVOICE 
/// </summary>
public string Type { get; set; }
/// <summary>
/// You can specify multiple document types, separated by commas. 
/// </summary>
public string Types { get; set; }
/// <summary>
/// If set to 1, fetches only those sales documents which have not been fully voided/returned/credited.
/// If a sales document has been partially credited, returns only those amounts and rows that have not been credited yet. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NonReturnedItemsOnly { get; set; }
/// <summary>
/// Search for sales documents that have a custom attribute with a specific value. You need to specify the name of the attribute as well as the required value. API lets you set multiple such filters; first pair of input parameters should be searchAttributeName1 and searchAttributeValue1, second pair should be searchAttributeName2 and searchAttributeValue2 etc. In other words, replace "#" with 1, 2, 3, ... . 
/// </summary>
public string SearchAttributeName#
searchAttributeValue# { get; set; }
/// <summary>
/// If this parameter is specified, response always includes the rows (lines) of each sales document (not just the header), regardless of whether the search returned one or many results. Rows are contained in attribute "rows". 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetRowsForAllInvoices { get; set; }
/// <summary>
/// If this parameter is specified, response will always include customer, payer and ship to data. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetCustomerInformation { get; set; }
/// <summary>
/// If set to 1, API also returns returned payments for selected sales documents.  
/// </summary>
public string GetReturnedPayments { get; set; }
/// <summary>
/// If set to 1, API also returns sales invoice creation timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? GetAddedTimestamp { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DueDateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DueDateTo { get; set; }
/// <summary>
/// If set to 1, API returns only unpaid sales documents.  
/// </summary>
public int? UnpaidItemsOnly { get; set; }
/// <summary>
/// If set to 1, API also returns the cost of goods sold.  
/// </summary>
public string GetCOGS { get; set; }
/// <summary>
/// If set to 1, API returns only unfulfilled documents.  
/// </summary>
public string GetUnfulfilledDocuments { get; set; }
/// <summary>
/// PENDING, READY, MAILED, PRINTED, SHIPPED, FULFILLED, CANCELLED or NOT_CANCELLED (returns all documents except cancelled ones) 
/// </summary>
public string InvoiceState { get; set; }
public int? AssignmentID { get; set; }
/// <summary>
/// If set to 1, API will not return invoice rows that contain a gift card. This is useful for implementing a rule in POS that gift cards cannot be returned. When a customer is doing a return with receipt, and cashier calls up the original receipt to select items to be retuned, gift cards will not be listed. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ExcludeGiftCards { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
public string OrderBy { get; set; }
public string OrderByDir { get; set; }
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

#region GetServices Settings

public class GetServicesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getServices";
public int? ServiceID { get; set; }
/// <summary>
/// Searches from service name 
/// </summary>
public string SearchName { get; set; }
public int? GroupID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
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

#region GetWarehouses Settings

public class GetWarehousesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getWarehouses";
/// <summary>
/// Retrieve one specific warehouse. 
/// </summary>
public int? WarehouseID { get; set; }
public int? UserID { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Search by exact warehouse code. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Retrieve warehouses in one specific store region.
/// This filter available only if "Store regions" module has been enabled on your account.
/// To get a list of store regions, see getStoreRegions.
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Retrieve warehouses associated with one specific assortment.
/// This filter available only if "Assortments" module has been enabled on your account.
/// To get a list of assortments, see getAssignments.
/// </summary>
public int? AssortmentID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
}

#endregion

#region GetAllowedWarehouses Settings

public class GetAllowedWarehousesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAllowedWarehouses";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
public int? UserID { get; set; }
/// <summary>
/// If, for example the list of warehouses is needed to populate a dropdown list and one of the items must be preselected (when modifying an existing document), send this input parameter. The selected item must be present in the list even when user technically does not have access to that warehouse. (We want to avoid a situation where user edits an invoice and system silently changes the warehouse in which the sale was done.) 
/// </summary>
public int? SelectedWarehouseID { get; set; }
}

#endregion

#region GetEmployees Settings

public class GetEmployeesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getEmployees";
/// <summary>
/// Employee's ID 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Search from employee name, e-mail or phone. 
/// </summary>
public string SearchName { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Get employees that belong to a specific user group. Note that if employee does not have a user account, it will never be returned when using this filter. 
/// </summary>
public int? UserGroupID { get; set; }
/// <summary>
/// Search for a specific employee by user name or e-mail address. 
/// </summary>
public int? UsernameOrEmail { get; set; }
/// <summary>
/// Get employees that work in a particular location (have access rights for a particular location). 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Set this to 1 if you are using Salon / Spa module and want to get a list of services (products) that each stylist performs. This information will be returned in attribute productIDs - see below. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetProductInfo { get; set; }
/// <summary>
/// Filter employees by birthday — get all employees whose birthday is on or after the specified month and day.
/// If you only specify birthdayMonthDayFrom and not birthdayMonthDayTo, all birthdays between the specified day and the end of the year are returned.
/// Combine the two filters to get birthdays in a specific range (eg. birthdays in June or July). Year wrap-around is supported: filter birthdayMonthDayFrom = "12-01", birthdayMonthDayTo = "01-31" returns birthdays in December and January.
/// Both month and day must be two digits. Use a leading zero if necessary.
/// </summary>
[JsonConverter(typeof(ISODateMMddConverter))]
public string BirthdayMonthDayFrom { get; set; }
/// <summary>
/// Filter employees by birthday — get all employees whose birthday is on or before the specified month and day.
/// If you only specify birthdayMonthDayTo and not birthdayMonthDayFrom, all birthdays between the beginning of the year and the specified day are returned.
/// Combine the two filters to get birthdays in a specific range (eg. birthdays in June or July). Year wrap-around is supported: filter birthdayMonthDayFrom = "12-01", birthdayMonthDayTo = "01-31" returns birthdays in December and January.
/// Both month and day must be two digits. Use a leading zero if necessary.
/// </summary>
[JsonConverter(typeof(ISODateMMddConverter))]
public string BirthdayMonthDayTo { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
public string OrderBy { get; set; }
public string OrderByDir { get; set; }
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

#region GetProjects Settings

public class GetProjectsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProjects";
/// <summary>
/// Project ID. 
/// </summary>
public int? ProjectID { get; set; }
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Project type ID, see getProjectTypes. 
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Project status ID, see getProjectStatuses. 
/// </summary>
public int? StatusID { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDateTo { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDateTo { get; set; }
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

#region GetPointsOfSale Settings

public class GetPointsOfSaleSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPointsOfSale";
public int? PointOfSaleID { get; set; }
public int? WarehouseID { get; set; }
/// <summary>
/// Search by register name. Partial matches are also returned, but API searches only from the beginning of each field — not from the middle. 
/// </summary>
public string SearchName { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetPriceLists Settings

public class GetPriceListsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPriceLists";
/// <summary>
/// Retrieve one specific price list. 
/// </summary>
public int? PricelistID { get; set; }
/// <summary>
/// Retrieve specific price lists. Multiple price list IDs, separated by commas. Will return 1030 error if array is provided. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PriceListIDs { get; set; }
/// <summary>
/// Set to 1 to retrieve sales price (VAT included) that applies to specified sales location. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetPricesWithVAT { get; set; }
public int? WarehouseID { get; set; }
public int? PointOfSaleID { get; set; }
/// <summary>
/// Retrieve price lists for which the starting date is on or after the specified date (or for which no starting date has been set). 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDateFrom { get; set; }
/// <summary>
/// Retrieve price lists for which the starting date is on or before the specified date (or for which no starting date has been set). 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDateTo { get; set; }
/// <summary>
/// Retrieve price lists for which the end date is on or after the specified date (or for which no end date has been set). 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDateFrom { get; set; }
/// <summary>
/// Retrieve price lists for which the end date is on or before the specified date (or for which no end date has been set). 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDateTo { get; set; }
/// <summary>
/// Filter price lists by type. A comma-separated list of price list types, possible types are 'BASE_PRICE_LIST', 'STORE_PRICE_LIST'.
/// Type filter can be used only if the "Price list types" module has been enabled on your account; otherwise error 1006 will be returned. Contact customer support to enable that feature.
/// An invalid type will return error 1016.
/// </summary>
public string Types { get; set; }
/// <summary>
/// Set to 1 to retrieve only price list headers, but not the contents of each price list.
/// This may be useful if you only need to enumerate the available price lists (fetch IDs and names), but not the items and prices in each list. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetHeadersOnly { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Get price lists that have been modified since the specified timestamp. Useful for synchronizing data. Price lists will be returned with their full contents. 
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
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetVatRates Settings

public class GetVatRatesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getVatRates";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// 'id', 'name', 'active' or 'order' (default sorting order). 
/// </summary>
public string OrderBy { get; set; }
/// <summary>
/// 'asc' (ascending) or 'desc' (descending). By default 'desc' 
/// </summary>
public string OrderByDir { get; set; }
/// <summary>
/// 0 for archived taxes, 1 for active taxes 
/// </summary>
public int? Active { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 1000. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
}

#endregion

#region GetCurrencies Settings

public class GetCurrenciesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCurrencies";
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetCampaigns Settings

public class GetCampaignsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCampaigns";
/// <summary>
/// Promotion ID. Use to retrieve one specific sales promotion. 
/// </summary>
public int? CampaignID { get; set; }
/// <summary>
/// "auto", "manual" or "coupon". See below for a description of each type. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Search for promotions which are active today (ie. which do not have any date restrictions, or the date range of which includes today's date).
/// When additional module Optionally Disable Promotions is enabled, then the promotion has to be "enabled" for it to be active. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ActiveToday { get; set; }
/// <summary>
/// Warehouse ID. Search for promotions that have been configured to apply in this specific location only.
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Search for promotions that are associated with this specific region. (This will NOT return promotions that do not have any region restriction, ie. which are configured to apply in all stores.)
/// A comma-separated list of store region IDs.
/// Using this field will return error 1028 if "Store regions" and "Promotion regions" modules are not enabled on this account.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> StoreRegionIDs { get; set; }
/// <summary>
/// Search for promotions that are associated with this specific customer group. (This will NOT return promotions that do not have any restrictions by customer group, ie. which are configured to apply to all customer groups.)
/// A comma-separated list of customer group IDs.
/// Using this field will return error 1028 if "Promotion regions" module is not enabled on this account.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CustomerGroupIDs { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
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
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetPayments Settings

public class GetPaymentsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPayments";
/// <summary>
/// Retrieve one specific payment. 
/// </summary>
public int? PaymentID { get; set; }
/// <summary>
/// Retrieve multiple payments, IDs separated by commas. Eg. "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PaymentIDs { get; set; }
public int? CustomerID { get; set; }
/// <summary>
/// Retrieve payments on a specific invoice. 
/// </summary>
public int? DocumentID { get; set; }
/// <summary>
/// Retrieve payments on multiple invoices (or sales documents), IDs separated by commas. Eg. "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DocumentIDs { get; set; }
/// <summary>
/// Filter payments by date range. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
/// <summary>
/// Filter payments by type. For a more detailed explanation of possible payment types, see the "type" field below. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Filter payments by type ID. If you set field "type" (see above), "typeID" is not necessary. For a list of payment types, see getPaymentTypes. 
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Filter payments by gift card VAT rate ID. 
/// </summary>
public int? GiftCardVatRateID { get; set; }
/// <summary>
/// 0 or 1, by default 0.
/// Set this filter flag to retrieve only payments that have been paid explicitly towards a specific invoice. This is because customer may also pay an invoice partly or fully with "store credit". Paying with "store credit" typically means that an earlier, existing prepayment is associated with the given invoice. This filter helps to exclude those payments.
/// Typically, this filter should be used together with invoiceID. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ExcludeStoreCreditPayments { get; set; }
/// <summary>
/// Search for a payment (a wire transfer payment imported from bank) by its archival number.
/// Note that even though archival numbers are meant to be unique, this search may return multiple results if one wire transfer imported from bank has been split into multiple payments in Erply. This may happen if customer paid for multiple invoices.
/// </summary>
public string ArchivalNumber { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
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

#region SaveSalesDocument Settings

public class SaveSalesDocumentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveSalesDocument";
/// <summary>
/// Sales document ID. Set this parameter to edit an existing sales document.
/// Please note that when confirmed already, sales invoices may not be fully editable any more. 
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Possible values: INVWAYBILL, CASHINVOICE, WAYBILL, PREPAYMENT, OFFER, EXPORTINVOICE, RESERVATION, ORDER, INVOICE, CREDITINVOICE.
/// Default value is INVWAYBILL. If you want to create a typical sales invoice, use INVWAYBILL.
/// Explanation:
/// INVWAYBILL - Deducts sold goods from inventory and accounts for revenue.
/// CASHINVOICE - Same as previous, but the printout is always formatted as a receipt, not an invoice.
/// WAYBILL - Deducts sold goods from inventory. This document is typically used in B2B environment. Create a WAYBILL if you ship items out of the warehouse, but want to bill the customer only at the end of the month, for all the items that have been shipped meanwhile. Hence, to complete the workflow, you need to follow up with an INVOICE.
/// PREPAYMENT - Prepayment invoice.
/// OFFER - Sales quote.
/// EXPORTINVOICE - Deprecated. This type was meant to be used in European Union, for international sales where a 0% VAT applies and you need to have customer VAT number and a special clause on the printout. Instead, please make an INVWAYBILL (or whatever document type you want) and set euInvoiceType = "EU" or "OUTSIDE_EU".
/// RESERVATION - Reserves goods in the stock. Roughly fills the same role as an order or a sales quote. This document type is being phased out.
/// ORDER - Order from the customer (or webshop). From order, an invoice later needs to be created.
/// INVOICE - Accounts for revenue. You usually only need this document type to follow up WAYBILLs that have been created earlier (see above).
/// CREDITINVOICE - A credit invoice. You may also add a reference to the original invoice being credited (creditToDocumentID = ID of the original invoice) and specify whether the transaction is a void or return transaction ("creditInvoiceType" is "VOID" or "RETURN") 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Currency code: "EUR", "USD" etc. Currency must be defined in your Erply account. For a list of available currencies, see getCurrencies.
/// If omitted, or an unknown currency code is provided, API uses your default currency instead. If editing an existing sales document, currency code is not necessary. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the main currency against system's default currency.
/// If the invoice is in system's default currency, you do not need to specify currenyRate — but if you do, use 1.0 as the value.
/// If omitted, API will apply the current exchange rate stored in ERPLY. 
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// ID of the warehouse (location, store) from which goods are being sold. Each sales document MUST be associated with a specific warehouse.
/// If you omit this parameter, system will associate ther document with the first warehouse in your account (by ID).
/// The user name that you using to connect to the API must have access rights for the particular warehouse.
/// For a list of warehouses, see getWarehouses.
/// Field "warehouseID" cannot be changed if your account has newer inventory module, the sales document has been confirmed and it is one of those documents that causes inventory levels to change (an INVWAYBILL, CASHINVOICE, WAYBILL, EXPORTINVOICE, or CREDITINVOICE). API will return error code 1017 in that case.
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Register ID. One warehouse (store) may have many registers.
/// Setting register IDs is important if you build a POS integration. The Z Report (POS end-of-day report), for example, works by register. In other cases, pointOfSaleID is not necessary.
/// See getPointsOfSale. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// eg. 2010-01-29
/// Each sales document must have a date. If omitted, API applies current date. 
/// </summary>
public string Date { get; set; }
/// <summary>
/// eg. 14:59:00
/// If omitted, API applies current time. 
/// </summary>
public string Time { get; set; }
/// <summary>
/// Each sales document MUST be associated with a customer. If you omit this parameter, API will automatically use default POS customer, but make sure you have it defined (Settings » Configuration in Erply backend).
/// See getCustomers.
/// Please note that the semantic meaning of "customer" may differ from one account to another. On older accounts, the "Customer" effectively means "recipient of goods", and it is additionally possible to define a "payer", but this is not required. (If not set, then the specified customer is both the payer as well as the recipient.)
/// On newer accounts, the "Customer" effectively means "payer", and it is possible to define a recipient (field "Ship to"), but this is not required. Hence, the roles have been reversed.
/// This will affect you if you have a standard integration used on multiple accounts, and you need to be able to set both payers and recipients. At the moment there is no set of parameters that could be used on all accounts with the same result; you need to inspect account configuration and tailor your input to API saveSalesDocument accordingly.
/// Call getConfParameters and check the value of configuration parameter "invoice_client_is_payer"
/// If it is 1, then:
/// Use customerID for the payer;
/// shipToID for the recipient, if necessary.
/// If the value of the parameter is 0 or it has not been defined, then:
/// Use customerID for the recipient;
/// payerID for the payer, if necessary.
/// Fields "addressID, "payerAddressID" and "shipToAddressID" should be used according to the same pattern.
/// Future API versions may get a uniform way of addressing recipients and payers.
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer address to be printed on the invoice.
/// To get a list of customer addresses, you may retrieve customer record with getCustomers (pass input parameter getAddresses = 1). You may also use API call getAddresses. 
/// </summary>
public int? AddressID { get; set; }
/// <summary>
/// Only use this field if your account has a "Payer" field on invoice form. See the explanation above.
/// If invoice payer ("Bill To") is different from the receiver of goods (the "Ship To" customer), you may set this field, otherwise leave it unset.
/// </summary>
public int? PayerID { get; set; }
/// <summary>
/// Payer address ID.
/// Only use this field if your account has a "Payer" field on invoice form. See the explanation above.
/// </summary>
public int? PayerAddressID { get; set; }
/// <summary>
/// Only use this field if your account has a "Ship To" field on invoice form. See the explanation above.
/// If the recipient of goods ("Ship To") is different from invoice payer, you may set this field, otherwise leave it unset.
/// </summary>
public int? ShipToID { get; set; }
/// <summary>
/// The address ID of the receiver of goods.
/// Only use this field if your account has a "Ship To" field on invoice form. See the explanation above.
/// </summary>
public int? ShipToAddressID { get; set; }
/// <summary>
/// Customer's contact person. 
/// </summary>
public int? ContactID { get; set; }
/// <summary>
/// Invoice creator ID. Employee name is displayed on invoice printout ("Cashier" or "Invoice created by") and used for reporting purposes ("Sales By Employee"). 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// By default 1, so API automatically confirms each sales document unless you specify otherwise (set confirmInvoice = 0).
/// Note: An unconfirmed sales invoice does not (and cannot) have a number.
/// Another tip: when you integrate Erply with a web shop and consider using unconfirmed sales invoices, perhaps a better option would be generating sales orders instead. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ConfirmInvoice { get; set; }
/// <summary>
/// Number to be given to the sales document.
/// Normally not needed. API will number invoices automatically. Use only when an invoice is created offline and it must definitely receive a number BEFORE it is possible to make the API call.
/// If the document already has a number, it will not be changed. API will not return an error message.
/// Make sure that the manually-assigned number will not interfere with Erply's regular invoice numbering. This field must be an integer (digits only), and only numbers with 8 digits or more are safe to be assigned manually (these will not affect invoices made from Erply)
/// If you want to assign an invoice number that also contains letters and other characters, see the next field — customNumber.
/// API will overwrite the number if it detects it's a duplicate. In that case, return attribute "invoiceNo" will contain the correct number. If you do not want this behavior, and do not want the number to automatically change (even if it is a duplicate), set allowDuplicateNumbers = 1.
/// </summary>
public int? InvoiceNo { get; set; }
/// <summary>
/// Assign a custom number to this sales document. As opposed to invoiceNo, this field may contain letters, spacing and punctuation.
/// Please note that back office support for custom numbers is currently limited. The custom number is displayed in the list of invoices and on the printouts, but you cannot search by that field.
/// For custom numbers, API does not check for duplicates (whether another document with this number already exists). 
/// </summary>
public string CustomNumber { get; set; }
/// <summary>
/// Sales document's custom reference number. This field must be used only if you want to override default reference numbers. If a document does not have a custom reference number, Erply itself will assign a default one, using the method selected in Settings → Configuration. If this field's value is longer than 25 characters, API returns error 1014. 
/// </summary>
public string CustomReferenceNumber { get; set; }
/// <summary>
/// Prevent API from overwriting invoice number if it detects that an invoice with the same number already exists.
/// By default 0. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? AllowDuplicateNumbers { get; set; }
/// <summary>
/// Notes printed on the invoice 
/// </summary>
public string Notes { get; set; }
/// <summary>
/// Notes to be displayed on invoice form, as a notice/reminder to other users. 
/// </summary>
public string InternalNotes { get; set; }
/// <summary>
/// Project associated with the sales document. See getProjects.
/// If you want to have your sales documents categorized in a custom way, attributes may be a better choice than projects. See below. 
/// </summary>
public int? ProjectID { get; set; }
/// <summary>
/// Status of the document itself.
/// For invoices, possible values: PENDING, READY, MAILED, PRINTED. For orders, possible values are: PENDING, READY, SHIPPED, FULFILLED, CANCELLED
/// May be left unspecified, system will determine it automatically. By default, unconfirmed documents are PENDING and confirmed documents are READY. Status then gets updated to MAILED or PRINTED, determined by the method of delivery. 
/// </summary>
public string InvoiceState { get; set; }
/// <summary>
/// Expected invoice payment method: eg. CASH, CARD, TRANSFER, CHECK, GIFTCARD.
/// You can specify payment method either by code name or by ID (field paymentTypeID); both are not needed.
/// This is just an informative field, indicating how the customer will likely pay the invoice. For more accurate information and for reporting, you need to inspect the payments associated with this document. An invoice can have many payments (of different types).
/// Also, if you want this field to have a value (eg. to be able to filter invoices by payment method), you need to set it explicitly; applying a payment will not automatically update invoice's payment method.
/// A list of invoice payment methods can be retrieved with getInvoicePaymentTypes. To create your own custom methods (and assign code names if needed), see saveInvoicePaymentType. 
/// </summary>
public string PaymentType { get; set; }
/// <summary>
/// Payment method ID. If you specify paymentType (see above), this field is not needed. 
/// </summary>
public int? PaymentTypeID { get; set; }
/// <summary>
/// eg. 5
/// By default: system-specific, usually 14.
/// In how many days the invoice is due. 
/// </summary>
public int? PaymentDays { get; set; }
/// <summary>
/// By default 0
/// If specified, the printout of created invoice will not mention any due date. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? HidePaymentDays { get; set; }
/// <summary>
/// By default 1
/// Whether the discount % for discounted items is printed on the invoice 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PrintDiscounts { get; set; }
/// <summary>
/// penalty for late payments as % per day, eg. "0,5"
/// This field is only informative and system does not account penalty automatically. 
/// </summary>
public string Penalty { get; set; }
/// <summary>
/// By default 0
/// Documents that neither sell the goods nor reserve them in the stock — PREPAYMENT, OFFER and ORDER — can optionally still include a reservation. Set reserveGoods = 1 in that case. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ReserveGoods { get; set; }
/// <summary>
/// eg. 2010-03-15
/// Use if parameter "reserveGoods" is set to 1
/// Until what date the reservation is kept.
/// If unspecified, reservation lasts indefinitely (until the document is modified and reservation removed) 
/// </summary>
public string ReserveGoodsUntilDate { get; set; }
/// <summary>
/// By default 0
/// Invoices marked with "sendByMail" have an e-mail indicator in the invoices table — these are meant to be sent by customer by e-mail. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SendByEmail { get; set; }
/// <summary>
/// Normally not needed. ERPLY can automatically apply customer and store price lists and calculate up-to-date final prices for you — use calculateShoppingCart for that. 
/// </summary>
public int? PricelistID { get; set; }
/// <summary>
/// Invoice payment status.
/// Possible values: PAID, UNPAID.
/// If set to PAID, system will automatically create a payment with today's date and invoice due amount. Payment type will be set according to attribute "paymentType", if possible, and typically defaults to TRANSFER.
/// Setting the value to UNPAID does not delete or change any payments. 
/// </summary>
public string PaymentStatus { get; set; }
/// <summary>
/// Invoice payment information, who paid, when, how.
/// Max 255 characters 
/// </summary>
public string PaymentInfo { get; set; }
/// <summary>
/// For CREDITINVOICEs only. Does not apply to US locale.
/// Cash invoices have a calculation algorithm different from other sales documents. Cash invoice calculations are based on prices with VAT, so that invoice total would match the prices exactly.
/// To make the distinction possible for credit invoices as well, set the isCashInvoice attribute to 1 if the source document was a cash invoice — then system will use cash invoice calculation method. 
/// </summary>
public int? IsCashInvoice { get; set; }
/// <summary>
/// For CREDITINVOICEs only. ID of the original invoice being credited. This serves as a reference link between these two documents. 
/// </summary>
public int? CreditToDocumentID { get; set; }
/// <summary>
/// For CREDITINVOICEs only. Specify whether the cashier is voiding a previous sale (typically possible only for same-day transactions, especially if card payments are involved), or the customer is returning bought items.
/// Possible values: VOID, RETURN.
/// If omitted, the transaction is assumed to be a RETURN. 
/// </summary>
public string CreditInvoiceType { get; set; }
/// <summary>
/// The amount that customer pays from their store credit account.
/// If the customer uses their store credit to pay an invoice, do not call savePayment — instead, set this attribute.
/// Example: If invoice total is $9.99, customer pays $5 in cash and $4.99 from store credit, call savePayment with the parameters "CASH" and 5.00, and set parameter "amountPaidWithStoreCredit" to 4.99. 
/// </summary>
public float? AmountPaidWithStoreCredit { get; set; }
public string TaxExemptCertificateNumber { get; set; }
/// <summary>
/// A comma-separated list of sales associates who will receive commission from this sale.
/// There are two possible ways to assign commission. First, you may associate each invoice line with a specific employee (see invoice rows, field "employeeID"). The rest of the commission will go to invoice creator by default (field "employeeID").
/// The other option is to divide commission equally between two or more people. For that, use "otherCommissionReceivers". In that case, ERPLY will ignore field "employeeID" for commission purposes. 
/// </summary>
public string OtherCommissionReceivers { get; set; }
/// <summary>
/// Customer requested delivery date (for the whole document). You may also set requested delivery dates for each line individually, see deliveryDate# below.
/// To use this, you should enable the feature "Delivery date tracking on sales and purchase orders" in Erply backend: Settings » Configuration » Inventory and Purchase: Enable Extra Features. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDate { get; set; }
/// <summary>
/// Actual shipping date (for the whole document). 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ShippingDate { get; set; }
/// <summary>
/// Source document ID. For an invoice, source document may be a waybill, order, quote, or prepayment invoice.
/// If you create a sales order, followed by a sales invoice, set the baseDocumentID on the sales invoice to link these two documents together. 
/// </summary>
public int? BaseDocumentID { get; set; }
/// <summary>
/// Source document IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BaseDocumentIDs { get; set; }
/// <summary>
/// Deprecated.
/// For EU users: if you want to create an international invoice (where customer VAT number and a special clause is printed on the invoice), set euInvoiceType = "EU" or "OUTSIDE_EU" instead. 
/// </summary>
public string ExportInvoiceType { get; set; }
/// <summary>
/// Used primarily for categorizing sales orders. In ERPLY backend there is a report "Sales orders to be fulfilled" that provides a "delivery condition" (delivery type) filter. Types are defined in Inventory » Delivery Conditions.
/// See getDeliveryTypes. 
/// </summary>
public int? DeliveryTypeID { get; set; }
/// <summary>
/// This field:
/// Only matters for sales orders.
/// It is related to the "Orders to be fulfilled" report in ERPLY.
/// By default, ERPLY does not consider a sales order as eligible for shipping unless all ordered items are in stock. In Settings » Configuration, you can enable partial shipping.
/// If you have partial shipping enabled, but still want particular orders to be ONLY shipped in full, set this flag.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? DeliveryOnlyWhenAllItemsInStock { get; set; }
/// <summary>
/// Description of packing unit. 
/// </summary>
public string PackingUnitsDescription { get; set; }
/// <summary>
/// For European Union users. Possible values are "DOMESTIC", "EU", "OUTSIDE_EU".
/// "DOMESTIC" is the default value. Set euInvoiceType = "EU" or "OUTSIDE_EU" if you want to create an international invoice where customer VAT number and a special clause is printed on the invoice. 
/// </summary>
public string EuInvoiceType { get; set; }
public int? PackerID { get; set; }
/// <summary>
/// Integer 
/// </summary>
public int? TransactionTypeID { get; set; }
/// <summary>
/// Integer 
/// </summary>
public int? TransportTypeID { get; set; }
/// <summary>
/// Integer 
/// </summary>
public int? DeliveryTermsID { get; set; }
/// <summary>
/// Only for EU accounts 
/// </summary>
public string DeliveryTermsLocation { get; set; }
/// <summary>
/// Only for EU accounts 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TriangularTransaction { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? PurchaseOrderDone { get; set; }
/// <summary>
/// Appliance ID. This API call returns error 1006 if assignment module is not enabled on this account. 
/// </summary>
public int? ApplianceID { get; set; }
/// <summary>
/// Appliance reference. This API call returns error 1006 if assignment module is not enabled on this account. 
/// </summary>
public string ApplianceReference { get; set; }
/// <summary>
/// Assignment ID. This API call returns error 1006 if assignment module is not enabled on this account. 
/// </summary>
public int? AssignmentID { get; set; }
/// <summary>
/// Vehicle-specific attribute. This API call returns error 1006 if assignment module is not enabled on this account. 
/// </summary>
public int? VehicleMileage { get; set; }
/// <summary>
/// Sales invoice creation timestamp. Normally not needed — API will assign a timestamp automatically. For new documents only. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
/// <summary>
/// Specify rounding amount (eg. 0.02 or -0.04).
/// Normally, this is not needed. You can select a rounding option in ERPLY backend (SETTINGS → Configuration → Invoices and sales) and it will be automatically applied to all invoices. (API response always contains the rounding amount and invoice total after rounding.) Use this input parameter only if the default options are not sufficient and you need to implement a custom rounding rule.
/// Rounding is applied to invoice total with tax, after all other calculations. 
/// </summary>
public float? Rounding { get; set; }
/// <summary>
/// Assigning this field lets you retrieve invoice / receipt printouts from ERPLY that show a custom value for net total, tax and invoice total.
/// This may be useful if you are integrating with another software that has its own invoice calculation algorithm that differs from ERPLY's — and the total on the printout has to match with invoice total in the other software.
/// This only affects printouts; ERPLY accounts revenue according to its own calculations. Also: if ERPLY calculates receipt total to $8.05, you set "externalTotal" to $8.04 and customer pays $8.04, ERPLY will show the receipt as $0.01 unpaid.
/// If you edit the invoice in ERPLY back office and change items, prices or quantities, externalNetTotal / externalVatTotal / externalRounding / externalTotal values will be discarded.
/// These 4 fields are not enabled by default. Please contact ERPLY customer support if you need them. 
/// </summary>
public float? ExternalNetTotal { get; set; }
/// <summary>
/// See above. 
/// </summary>
public float? ExternalVatTotal { get; set; }
/// <summary>
/// See above. 
/// </summary>
public float? ExternalRounding { get; set; }
/// <summary>
/// See above. 
/// </summary>
public float? ExternalTotal { get; set; }
/// <summary>
/// ID of the product (SKU) sold. Either productID or serviceID can be set, but not both at the same time. Both can be omitted, however - in that case a free-text invoice row will be created. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// ID of the service sold. 
/// </summary>
public int? ServiceID# { get; set; }
/// <summary>
/// Name of the sold item (use only if you want to override the default product/service name). 
/// </summary>
public string ItemName# { get; set; }
/// <summary>
/// ID of VAT rate. 
/// </summary>
public int? VatrateID# { get; set; }
/// <summary>
/// Sold quantity.
/// Sold quantity must be a decimal, and can not be zero.
/// This is a required field; however, you may omit it if you specify a package and quantity of packages instead (fields packageID# and amountOfPackages#). 
/// </summary>
public float? Amount# { get; set; }
/// <summary>
/// Net sales price per item, pre-discount.
/// If you omit both "price" and "discount", ERPLY will automatically apply the current price in the selected location (store) to the selected customer, according to price lists.
/// If you omit "price", but set "discount", ERPLY will automatically use product card price, and will subtract the discount from product card price.
/// </summary>
public float? Price# { get; set; }
/// <summary>
/// Discount % that WILL BE SUBTRACTED from the price specified in previous parameter.
/// The algorithm is as follows:
/// discountedPrice = round((price (100 - discount) / 100), defaultDecimalPlaces)
/// lineTotal = round(discountedPrice amount), 2)
/// lineVat = round((lineTotal * (100 + vatrate) / 100), 2) 
/// </summary>
public float? Discount# { get; set; }
/// <summary>
/// Assign commission from the sale of this line item to a specific employee. 
/// </summary>
public int? EmployeeID# { get; set; }
/// <summary>
/// A comma-separated list of sales promotions that were applied to this invoice row. Needed for reporting. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CampaignIDs# { get; set; }
/// <summary>
/// Alias to campaignIDs#. Use campaignIDs# instead. 
/// </summary>
public int? CampaignID# { get; set; }
/// <summary>
/// Set this field if you want to indicate that the product was sold as packages. Use it together with "amountOfPackages#".
/// Packages are product-specific; a product can have zero or more defined packages. To retrieve a product's packages, call getProducts with input parameter getPackageInfo = 1 and see the block productPackages in the output.
/// </summary>
public int? PackageID# { get; set; }
/// <summary>
/// Amount of packages sold.
/// If you specify both amount# and amountOfPackages#, they must correspond to each other: amount# must be equal to amountOfPackages# multiplied by the quantity in one package.
/// However, it is sufficient to specify only one of the two fields; the second one will be calculated automatically.
/// </summary>
public float? AmountOfPackages# { get; set; }
/// <summary>
/// Alcohol batch number.
/// This parameter can be used only when Alcohol Wholesaling module is enabled, otherwise API will return error 1006. 
/// </summary>
public string Batch# { get; set; }
/// <summary>
/// The next fields are for automatically assigning a tax rate for this line item. You may send all the information about the sales tax (ZIP code, state / county / city names and tax rates), and API will automatically find corresponding tax rate ID, if such a tax already exists in Erply, or create a new one.
/// To use this feature, ask Erply helpdesk to enable the split tax rate (state tax / county tax / city tax) module on your account. 
/// </summary>
public string ZIPCode# { get; set; }
/// <summary>
/// State name. See above. 
/// </summary>
public string State# { get; set; }
/// <summary>
/// County name. See above. 
/// </summary>
public string County# { get; set; }
/// <summary>
/// County name. See above. 
/// </summary>
public string City# { get; set; }
/// <summary>
/// Tax category (not used right now). See above. 
/// </summary>
public string Category# { get; set; }
/// <summary>
/// State sales tax %. See above. 
/// </summary>
public float? StateSalesTax# { get; set; }
/// <summary>
/// County sales tax %. See above. 
/// </summary>
public float? CountySalesTax# { get; set; }
/// <summary>
/// City sales tax %. See above. 
/// </summary>
public float? CitySalesTax# { get; set; }
/// <summary>
/// Must be equal to StateSalesTax + CountySalesTax + CitySalesTax. See above. 
/// </summary>
public float? TotalSalesTax# { get; set; }
/// <summary>
/// A reason for returning the item (if document is a return), or for discount (if document is a regular sale). Reasons can be listed with API call getReasonCodes. Note that there are separate reason codes for discounts and returns. 
/// </summary>
public int? ReturnReasonID# { get; set; }
/// <summary>
/// Customer requested delivery date for this specific item. You can also set a requested delivery date for the whole document, see deliveryDate above.
/// To use this, you should enable the feature "Delivery date tracking on sales and purchase orders" in Erply backend: Settings » Configuration » Inventory and Purchase: Enable Extra Features. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDate# { get; set; }
/// <summary>
/// Source document ID. This can be used on invoices, to refer which row originates from which waybill. Erply back office or Actual Reports can provide a printout where invoice rows are grouped by waybill.
/// Requires CREDITINVOICE or INVOICE document type, API will return error code 1013 for other types.
/// </summary>
public int? SourceWaybillID# { get; set; }
/// <summary>
/// Recurring billing ID.
/// Set this field if you want to indicate that this invoice line originates from a recurring billing.
/// If you specify this field, you must also set "billingStartDate#" and "billingEndDate#". If this ID refers to a metered recurring billing, then "billingReadingIDs#" field is required, too; otherwise API will return error code 1010.
/// ERPLY will automatically update billing status; this period for this customer will be marked as billed.
/// Recurring billing can be set up in back office, in Sales → Recurring billing, or with API call saveBillingStatement.
/// To be able to set this field, your data model may need updating. If API returns error code 1124, please contact customer support.
/// </summary>
public int? BillingStatementID# { get; set; }
/// <summary>
/// A comma-separated list of integers.
/// You need to specify this field if you want to associate this invoice line with a recurring, metered, billing. Erply will need to know which readings of the meter the invoice must be associated with.
/// Readings can be entered in back office, when you open a Billing Statement, or with API call saveBillingStatementReading. The list of readings associated with a recurring billing can be queried with API call getBillingStatementReadings.
/// You are allowed to set this field only if billingStatementID# refers to a billing statement that is based on metered readings. Otherwise, setting this field is forbidden and API will return error code 1013.
/// If the reading IDs actually belong to another recurring billing, or a different invoice has already been associated with them, API will return error code 1130.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BillingReadingIDs# { get; set; }
/// <summary>
/// Billing start date. See previous field. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? BillingStartDate# { get; set; }
/// <summary>
/// Billing end date. See previous field. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? BillingEndDate# { get; set; }
/// <summary>
/// Applied promotion ID, if this was a promotion discount.
/// A record can have either "promotionID" or "priceListID", but not both at the same time. To specify a manual discount, omit both. 
/// </summary>
public int? PromotionRule#campaignID# { get; set; }
/// <summary>
/// Applied price list ID, if this was a price list discount.
/// A record can have either "promotionID" or "priceListID", but not both at the same time. To specify a manual discount, omit both. 
/// </summary>
public int? PromotionRule#priceListID# { get; set; }
/// <summary>
/// What quantity the promotion, price list, or manual discount applied to, on this particular invoice line.
/// If customer bought 2 or more of this item, but only one was with promotional discount (eg. a Buy One, Get One promotion), then set the value to 1.
/// If a price list discount applied, then this value should always be equal to row quantity. 
/// </summary>
public int? PromotionRule#amount# { get; set; }
/// <summary>
/// Total value (price * quantity) of the discounted items, immediately AFTER applying the discount.
/// The name of the field is incorrect, but preserved for compatibility.
/// Please note that this is not the same as "line total". If only some of the items on this invoice line were discounted, this must be the total for these discounted items only. 
/// </summary>
public float? PromotionRule#finalPrice# { get; set; }
/// <summary>
/// Total $ discount given to this invoice line. 
/// </summary>
public float? PromotionRule#totalDiscount# { get; set; }
/// <summary>
/// "ITEMS" or "INVOICE" — if this was a promotion discount.
/// "ITEMS" for line or item discounts; "INVOICE" for any discounts that applied to the whole document. (Since there is no "invoice discount" concept in ERPLY, invoice discounts need to be divided proportinally between invoice lines.) 
/// </summary>
public string PromotionRule#campaignType# { get; set; }
/// <summary>
/// Dollar discount that was specified in promotion parameters — if this was a dollar discount promotion. (For instance, if the promotion was "Get $20 off of all shoes", the field value should be 20.). 
/// </summary>
public float? PromotionRule#campaignDiscountValue# { get; set; }
/// <summary>
/// Percentage discount as it was defined in promotion description — if this was a percentage discount promotion (eg "10% off"). 
/// </summary>
public float? PromotionRule#campaignDiscountPercentage# { get; set; }
/// <summary>
/// "PRICE" or "DISCOUNT" — if this was a price list discount.
/// "PRICE" - if the price list applied a fixed price, "DISCOUNT" - if the price list applied a discount percentage. 
/// </summary>
public string PromotionRule#priceListDiscountType# { get; set; }
/// <summary>
/// Discount percentage from the price list (in case the price list discount was percentage-based). 
/// </summary>
public float? PromotionRule#priceListDiscountPercentage# { get; set; }
/// <summary>
/// Manual discount percentage — if any manual discount was applied. 
/// </summary>
public float? PromotionRule#manualDiscountPercentage# { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string LongAttributeName# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute. 
/// </summary>
public string LongAttributeValue# { get; set; }
}

#endregion

#region CalculateShoppingCart Settings

public class CalculateShoppingCartSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "calculateShoppingCart";
/// <summary>
/// Sales document ID. 
/// </summary>
public int? DocumentID { get; set; }
/// <summary>
/// Possible values: INVWAYBILL, CASHINVOICE, WAYBILL, PREPAYMENT, OFFER, EXPORTINVOICE, RESERVATION, ORDER, INVOICE, CREDITINVOICE.
/// Default value is CASHINVOICE. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// If omitted, current date will be used. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date { get; set; }
/// <summary>
/// Warehouse ID.
/// You may specify either warehouseID or pointOfSaleID, whichever is more convenient for you.
/// If you do not specify neither location nor register, API automatically assumes you are selling from the first location in your locations list (by ID). All price lists and promotions associated with that location will apply, and that location's tax rate will be set to all items.
/// To be always sure of what location's price lists, promotions and taxes are being applied, we recommend to set this parameter explicitly. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Register ID.
/// An alternative to warehouseID. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Price list ID.
/// Set this value ONLY when you want to apply just this one price list to the sale and no others. In most cases, you do not need that! API will automatically apply any store, customer, or customer group price lists that have been defined, and will combine them automatically. 
/// </summary>
public int? PricelistID { get; set; }
/// <summary>
/// Customer ID.
/// If not set, API will not make any assumptions about the customer, so no customer (or customer group) price lists will apply. If you want the sale to go to the "Default customer" or "POS Customer", send that customer's ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Exchange rate of the shopping cart currency against system's default currency. If the shopping cart is in system's default currency, this parameter does not have to be specified (but if you specify it, use 1.0 as the value).
/// Pay attention to the way rates should be divided. If your shopping cart is in JPY and your account default currency is EUR, the expected value is 0.008 (1 JPY = 0.008 EUR), not 125.
/// To get the current rate for a currency defined in Erply back office, see getCurrencies.
/// When using currencies, Erply can only apply price list prices, not any promotions.. Translating a promotion into a foreign currency has not been implemented yet. So, if you want to use the "currencyRate" input parameter, you must also specify "doNotApplyPromotions" = 1. If this parameter is specified without "doNotApplyPromotions" flag, API returns error 1010.
/// If currencyRate is not a valid positive decimal, API returns error 1014.
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// API calculateShoppingCart can also apply "a price from customer's previous quote". We assume that if a confirmed quote has been given to a customer (and it has not expired yet), then the items on the quote could be freely sold at the indicated price, as many times as the customer wants. If you want this feature, set this flag to 1.
/// If this flag has been set to 1, and there is a quote for the specified customer that has not expired yet, and it contains the specific product, the price from the quote will override price list price (even if quoted price is higher than price list price). Promotions, however, will still apply on top of the quote price as usual.
/// Currently, this flag only has an effect if you have not disabled the use of quote prices with configuration parameter "disable_automatic_price_from_previous_quote" = 1. This limitation might be removed in the future.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ApplyQuotedPrices { get; set; }
/// <summary>
/// If set to 1, then only price lists will be applied — not promotions. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? DoNotApplyPromotions { get; set; }
/// <summary>
/// If set to 1, API will also return a list of coupons that should be automatically printed from POS after the sale. See output field automaticCoupons for a more detailed explanation. We recommend to leave it unset while you are still building up shopping cart contents — but set it to 1 when the cart has been finalized and you issue the final call to calculateShoppingCart. 
/// </summary>
public int? GetAutomaticCoupons { get; set; }
/// <summary>
/// Eg: "109000002346,109000002351"
/// Coupon codes (identifiers) that cashier has scanned.
/// Erply allows you to issue printed coupons to customers. Each printed coupon must have a unique identifier. In Erply backend, all issued coupons are listed in the Retail Chain » Issued Coupons module. A coupon is basically a method for invoking a sales promotion, so if customer returns to the store with a coupon and cashier scans it, a promotion will apply.
/// The recommended API workflow for accepting coupons is as follows:
/// Use verifyIssuedCoupon to make sure that the coupon identifier exists, that the coupon has not expired and has not been redeemed yet.
/// If coupon is valid, pass its identifier into calculateShoppingCart, field couponIdentifiers, so that it would give appropriate discounts. If the coupon has any effect to the sale, API will return its code in the usedCouponIdentifiers field. (Because it may well be that the coupon is not valid in given store, or customer has not chosen to buy the items required for the promotion to kick in.)
/// If API has indicated that the coupon was indeed used, redeem it. After saving the sale with saveSalesDocument, call redeemIssuedCoupon to redeem the coupon. A redeemed coupon cannot be used again.
/// NB! Coupons are not the same as "promotional codes", eg. "Get 20% off of all barbecue equipment with promo code JULY4" (which many be printed in an ad, or distributed in customer newsletter). As far as Erply is concerned, you do not need a coupon setup for that.
/// For that case, we recommend to define a manual promotion, set "JULY4" as its name, and have cashier to apply the promotion manually whenever customer presents the code.
/// Certain types of promotions allow to scan more than one coupon (the promotion will then apply multiple times):
/// Buy a specific product and get $ off entire invoice
/// Buy for at least $x and get $ off entire invoice
/// Buy for at least $x and get $ off specific items
/// Buy for at least $x and get % off specific items
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<string> CouponIdentifiers { get; set; }
/// <summary>
/// Eg: "1,4,18"
/// Old deprecated name: "manualCampaignIDs"
/// IDs of promotions that cashier has applied manually.
/// In Erply, a promotion can be configured in three ways:
/// Promotion applies automatically to all customers whenever possible (default option). API calculateShoppingCart applies all such promotions, you do not need to specify anything.
/// Promotion can be applied manually at cashier's discretion. POS would presumably list all promotions that are applicable in that way, and cashier can invoke any of these. Pass the IDs of manually selected promotions in field manualPromotionIDs.
/// Promotion applies when customer presents a coupon. Send the coupon identifiers in field couponIdentifiers (see specification above) and API will apply respective promotions if possible.
/// The promotion IDs sent in the manualPromotionIDs field must all be manual promotions; others will be ignored.
/// A promotion MAY be listed multiple times (if you want to apply it multiple times), but this only works with the following promotion types:
/// Buy a specific product and get $ off entire invoice
/// Buy for at least $x and get $ off entire invoice
/// Buy for at least $x and get $ off specific items
/// Buy for at least $x and get % off specific items
/// Also, multiple invocation does not work with one-time promotions of one-time birthday promotions. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ManualPromotionIDs { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? DoNotApplyInvoiceLevelPromotions { get; set; }
/// <summary>
/// Set a manual tax exemption to this sale.
/// If the selected customer is already marked as being tax exempt on customer card, you do not need to send this flag.
/// If customer provides a tax exemption certificate number, you may attach it to the sale using the taxExemptCertificateNumber field in saveSalesDocument. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TaxExempt { get; set; }
/// <summary>
/// Whether the sale is a domestic sale, a sale to another EU country or a sale to outside of the EU. Possible values are "DOMESTIC", "EU", "OUTSIDE_EU". The default tax rate suggested by API calculateShoppingCart depends on that.
/// If this concept does not apply (your business is not in the EU), just leave the field unset. 
/// </summary>
public string EuInvoiceType { get; set; }
/// <summary>
/// ID of the product (SKU) sold. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// Sold quantity.
/// In general, quantity can be unlimited. However, for performance reasons, API imposes two limitations.
/// If row quantity is 5000 or larger, no item-level promotions will be applied to this row, and this row will not trigger any promotions, either. (Neither "Buy this item and get discount on another product" nor "Buy this item and get discount from the whole purchase" promotions will be triggered.) Supporting these operations with larger quantities would require a lot of memory and time. Furthermore, if the "calculateShoppingCart" call is coming from POS, a large quantity is usually a cashier's typing error (product code been scanned into the "Quantity" field, for example), rather than a legitimate use case.
/// Even if row quantity is below 5000, each item-level promotion will be applied at most 1000 times. If you define a "Buy One, Get One" promotion and attempt to sell 4000 items, calculateShoppingCart will apply the discount to only 1000 items (instead of expected 2000, or every other item).
/// </summary>
public float? Amount# { get; set; }
/// <summary>
/// Net price.
/// Set this field ONLY if cashier has entered a price manually. In other cases, do NOT send this input field. API will itself find and set correct item price.
/// This parameter will overwrite product's price list price (or product card price, if no price list applies). On top of this price, API will apply promotion discounts and a manual discount. 
/// </summary>
public float? Price# { get; set; }
/// <summary>
/// Manual discount.
/// Set this field ONLY if cashier has set a manual discount for this invoice line. Manual discount will be applied cumulatively on top of promotion discounts; there is no way to "override" a promotional discount with a manual discount.
/// In general, price lists, discounts and promotions are applied by the API in the following order:
/// Price lists. Several price lists may apply to both the location and the customer, and price lists may overwrite each other in various ways.
/// If the resulting price is different from product card price, calculateShoppingCart does not show or interpret it as a discount. So, if product card price is $10 and price list price is $5, API will return that item price is just $5. It will not be shown as a 50% discount.
/// If you have specified the "price" parameter, it overwrites price list price.
/// Manual discount. If you have specified a discount percentage, it will be further subtracted from the final price.
/// Promotions.
/// </summary>
public string Discount# { get; set; }
/// <summary>
/// Set this field if you want a specific VAT / tax rate to be applied to this item. If not set, API will automatically determine the appropriate tax rate (which may be set at register, location, product group or product level). For a list of tax rates and IDs, see getVatRates.
/// For reference, this is the priority (in decreasing order) of various tax rate settings that you can specify in ERPLY backend:
/// Tax exemption is activated at POS (set input field taxExempt = 1), or customer has been defined as tax exempt
/// Product defined as "tax free in all locations" (on product card)
/// Tax rate set for product group + location (on product group card)
/// Multi-tier (New York) tax set for location (on location card)
/// Tax set for register
/// Tax set on product card
/// </summary>
public int? VatrateID# { get; set; }
}

#endregion

#region SavePayment Settings

public class SavePaymentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "savePayment";
/// <summary>
/// Payment ID.
/// Set this parameter to edit an existing payment. Omit it to create a new payment.
/// </summary>
public int? PaymentID { get; set; }
/// <summary>
/// Customer ID.
/// Not required when updating an existing payment. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Invoice ID.
/// If specified, you do not need to specify customerID — API will set customer ID equal to invoice customer if input parameter customerID is omitted.
/// Not required when updating an existing payment.
/// If you want to save an invoice and its associated payment together in one bulk request, set this field to a special value: "CURRENT_INVOICE_ID". Normally, creating two records where one references the other cannot be done within one bulk request; you would have to retrieve one record's ID before you can create the other. This is a special workaround for savePayment, saveGiftCard, saveIssuedCoupon, redeemIssuedCoupon, and subtractCustomerRewardPoints.
/// Note that if saving the invoice results in an error, the payments, coupons etc. will be created nevertheless, but without a reference to any invoice. For better error checking, you may still want to do saveSalesDocument as a separate request. 
/// </summary>
public int? DocumentID { get; set; }
/// <summary>
/// There are two ways for specifying payment type: either by its code name (field "type") or ID (field "typeID").
/// Standard code names recognized by ERPLY are CASH, TRANSFER, CARD, CREDIT, GIFTCARD, CHECK, TIP — but you can also create your own custom code names with savePaymentType.
/// By default: TRANSFER
/// Explanation:
/// CASH - in cash.
/// TRANSFER - by wire transfer.
/// CARD - by credit or debit card.
/// CHECK - by check.
/// CREDIT - via credit invoice. This type should be used when a due amount is cleared with a credit invoice, or in case of any other balancing transaction.
/// GIFTCARD - with a gift card. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Payment type ID. If you set field "type" (see above), "typeID" is not necessary. For a list of payment types, see getPaymentTypes. 
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// eg. 2010-01-29
/// If omitted, current date will be used. 
/// </summary>
public string Date { get; set; }
/// <summary>
/// Payment sum. If omitted, 0.00 will be used. 
/// </summary>
public float? Sum { get; set; }
/// <summary>
/// If omitted, 0.00 will be used. 
/// </summary>
public float? CashPaid { get; set; }
/// <summary>
/// If omitted, 0.00 will be used. 
/// </summary>
public float? CashChange { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be defined in Erply. If omitted, or an unknown currency code is provided, API uses your default currency instead. If editing an existing payment, currency code is not necessary. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Information about the payer or payment transaction. 
/// </summary>
public string Info { get; set; }
/// <summary>
/// Cardholder's name (empty if not card payment or if the information has not been supplied) 
/// </summary>
public string CardHolder { get; set; }
/// <summary>
/// Last 4 digits of credit card number (empty if not card payment or if the information has not been supplied). Erply does not store full credit card numbers. 
/// </summary>
public string CardNumber { get; set; }
/// <summary>
/// Credit card type, eg. VISA, AMEX, M/C etc. (empty if not card payment or if the information has not been supplied) Erply's Z Report displays card payments separately by type. 
/// </summary>
public string CardType { get; set; }
/// <summary>
/// Cardholder's signature. Signature encoding and encryption methods are UNSPECIFIED at the moment. Additionally in case of encryption, both parties must share a common encryption key. Not available in all accounts (savePayment may return an error if either signature or signatureIV is set) 
/// </summary>
public string Signature { get; set; }
/// <summary>
/// Initialization vector to be used if the signature is encrypted 
/// </summary>
public string SignatureIV { get; set; }
/// <summary>
/// A flag indicating that this payment is a contribution to customer's store credit account, and it is not specifically meant for paying a particular invoice.
/// System will try to associate it with any previous unpaid invoices the customer might have. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? AddedToStoreCredit { get; set; }
/// <summary>
/// This field is required for disambiguation if you want to set integration-specific fields.
/// Most importantly, it is necessary if you want to set the "aid" or "applicationLabel" fields; API needs to know whether you intend to store a PAX payment or a Cayan payment, as they both have fields with that name.
/// To store a PAX payment, you need to specify paymentServiceProvider = "pax". Your account also needs to have the "PAX payment data" module enabled. The fields you can set for a PAX payment are "aid", "entryMethod", "applicationLabel", "transactionType" and "transactionNumber".
/// To store a Cayan (Merchant Warehouse) payment, you need to specify paymentServiceProvider = "merchant_warehouse" or leave it unset. Your account also needs to have the "Cayan / Merchant Warehouse payment data" module enabled. The fields that you can set for a Cayan payment are "aid", "applicationLabel", "pinStatement", "cryptogramType", "cryptogram", and "expirationDate".
/// To store a Tyro payment, you need to specify paymentServiceProvider = "tyro". Your account also needs to have the "Tyro payment data" module enabled. The field you can set for a Tyro payment is "transactionId".
/// To store a Klarna payment, you need to specify paymentServiceProvider = "klarna". Your account also needs to have the "Klarna payment data" module enabled. The field you can set for a Klarna payment is "klarnaPaymentID".
/// To store a Givex payment, you need to specify paymentServiceProvider = "givex". Your account also needs to have the "Givex payment data" module enabled. The fields that you can set for a Givex payment are "certificateBalance", "transactionType", "statusMessage", "statusCode" and "expirationDate". 
/// </summary>
public int? PaymentServiceProvider { get; set; }
/// <summary>
/// Use this field only if you have "Cayan / Merchant Warehouse payment data" or "PAX payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public int? Aid { get; set; }
/// <summary>
/// Use this field only if you have "Cayan / Merchant Warehouse payment data" or "PAX payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string ApplicationLabel { get; set; }
/// <summary>
/// Use this field only if you have "Cayan / Merchant Warehouse payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string PinStatement { get; set; }
/// <summary>
/// Use this field only if you have "Cayan / Merchant Warehouse payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string CryptogramType { get; set; }
/// <summary>
/// Use this field only if you have "Cayan / Merchant Warehouse payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string Cryptogram { get; set; }
/// <summary>
/// Use this field only if you have "Cayan / Merchant Warehouse payment data" or "Givex payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string ExpirationDate { get; set; }
/// <summary>
/// Use this field only if you have "PAX payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string EntryMethod { get; set; }
/// <summary>
/// Use this field only if you have "PAX payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string TransactionType { get; set; }
/// <summary>
/// Use this field only if you have "PAX payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string TransactionNumber { get; set; }
/// <summary>
/// Use this field only if you have "Tyro payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public int? TransactionId { get; set; }
/// <summary>
/// Use this field only if you have "Givex payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string TransactionType { get; set; }
/// <summary>
/// Use this field only if you have "Transaction Time of a Payment" module enabled (otherwise returns error 1028).
/// This is used for a Verifone Finland or a Nixpay payment. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? TransactionTime { get; set; }
/// <summary>
/// Use this field only if you have "Klarna payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public int? KlarnaPaymentID { get; set; }
/// <summary>
/// Use this field only if you have "Givex payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public float? CertificateBalance { get; set; }
/// <summary>
/// Use this field only if you have "Givex payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public int? StatusCode { get; set; }
/// <summary>
/// Use this field only if you have "Givex payment data" module enabled (otherwise returns error 1006). 
/// </summary>
public string StatusMessage { get; set; }
/// <summary>
/// A flag which you can apply to indicate that this payment has originally been a prepayment (meaning that it was associated with a Prepayment Invoice or a Sales Order). Payments that are currently associated with a Prepayment Invoice, or a Sales Order, are typically not marked with this flag! 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsPrepayment { get; set; }
/// <summary>
/// If the payment is a gift card payment, indicate the tax rate (VAT rate) the gift card was originally sold with.
/// If left unset, or set to 0, Erply will assume that the gift card was sold with 0% tax.
/// If a gift card has been sold with tax, and customer redeems the gift card, Erply back office and Erply Books will need to be aware of that. The amount of goods and services that corresponds to the gift card's value no longer needs to be taxed, as tax has already been paid once.
/// For this sales transaction, Erply will then produce a printout that indicates the taxable total is correspondingly smaller.
/// Set this field only if payment type is "GIFTCARD". Setting this field for payments of any other type will return error code 1160.
/// </summary>
public int? GiftCardVatRateID { get; set; }
/// <summary>
/// If not set, server will assign a timestamp automatically. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
/// <summary>
/// Receiver's account number or IBAN. 
/// </summary>
public string BankAccount { get; set; }
/// <summary>
/// Transaction number. 
/// </summary>
public string BankDocumentNumber { get; set; }
/// <summary>
/// Date of wire transfer. 
/// </summary>
public string BankDate { get; set; }
/// <summary>
/// Payer's account number or IBAN. 
/// </summary>
public string BankPayerAccount { get; set; }
/// <summary>
/// Payer's name. 
/// </summary>
public string BankPayerName { get; set; }
/// <summary>
/// Payer's ID code (for persons) or registry code (for companies). 
/// </summary>
public string BankPayerCode { get; set; }
/// <summary>
/// Paid amount. 
/// </summary>
public string BankSum { get; set; }
/// <summary>
/// Reference number specified on the wire transfer. 
/// </summary>
public string BankReferenceNumber { get; set; }
/// <summary>
/// Description of the wire transfer. 
/// </summary>
public string BankDescription { get; set; }
/// <summary>
/// Currency code. 
/// </summary>
public string BankCurrency { get; set; }
/// <summary>
/// Archival number of the transaction. 
/// </summary>
public string ArchivalNumber { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region DeleteSalesDocument Settings

public class DeleteSalesDocumentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteSalesDocument";
/// <summary>
/// The document to be deleted. 
/// </summary>
public int? DocumentID { get; set; }
}

#endregion

#region DeletePayment Settings

public class DeletePaymentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deletePayment";
/// <summary>
/// The payment to be deleted. 
/// </summary>
public int? PaymentID { get; set; }
}

#endregion

#endregion
#region Webstore

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

#endregion
#region Pos

#region SendByEmail Settings

public class SendByEmailSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "sendByEmail";
/// <summary>
/// ID of the document. For invoices, their numeric identifier. In the future, longer identifying strings may be used for printing reports. 
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Document category - SALESDOCUMENT or PURCHASEDOCUMENT. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// E-mail address of the receiver. May include several addresses, separated by commas or spaces. 
/// </summary>
public string Email { get; set; }
public string SenderName { get; set; }
/// <summary>
/// If unspecified, invoice creator's email address or company's general email address will be used. 
/// </summary>
public string SenderEmail { get; set; }
/// <summary>
/// If unspecified, default email message text for this particular document type will be used. 
/// </summary>
public string Message { get; set; }
}

#endregion

#region SendToPrint Settings

public class SendToPrintSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "sendToPrint";
/// <summary>
/// ID of the document. For invoices, their numeric identifier. 
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Document category - SALESDOCUMENT or PURCHASEDOCUMENT. 
/// </summary>
public string Type { get; set; }
}

#endregion

#region POSOpenDay Settings

public class POSOpenDaySettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "POSOpenDay";
/// <summary>
/// Point of sale ID 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Employee opening the day. If omitted, Erply assumes day was opened by the user who sent the API call. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Total amount of cash in register at opening time 
/// </summary>
public float? OpenedSum { get; set; }
/// <summary>
/// Opening timestamp.
/// NB! If the record already exists (if there is a day opening at the same register, with the same timestamp), InventoryAPI just updates it. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTime { get; set; }
/// <summary>
/// Check feature, if set to 1 no any changes will be applied, used to check if the day is opened. If set to 1 parameters "openedUnixTime" and "openedSum" are not required, and will be even ignored. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? QueryOpenDay { get; set; }
/// <summary>
/// Specify the currency in which you want to open the day in the register.
/// Note: by default, this field should not be used. In a default configuration, ERPLY allows to count the cash in the register only in the default currency. The cashier should just set aside any cash received in foreign currencies, and remove it from the register at the end of the day. From back office, it is possible to manually print a Z Report that lists transactions made in a different currency, but the counted amount cannot be recorded in POS, neither when opening nor when closing the day.
/// Therefore, in the default setup, it is not possible to use the "currencyCode" field. API will return error code 1028 if you attempt to set it.
/// However, customer support can enable an extra module, "POS multicurrency". With this extra module, it becomes possible to count other currencies and record the counts.
/// In that configuration, a separate "POSOpenDay" call must be sent for each currency. If the shop accepts EUR, USD and JPY, three "POSOpenDay" calls must be made in the morning and three corresponding "POSCloseDay" calls in the evening, to store the end-of-day counts.
/// At the end of the day, it is possible to print three Z Reports, one for each currency. Each report will list the transactions, amount of cash in the beginning and at the end of the day, and overage/shortage.
/// Accepted value: for example "EUR" or "USD". The currency must be defined on your ERPLY account, in the "Currencies" module.
/// </summary>
public string CurrencyCode { get; set; }
}

#endregion

#region POSCashIN Settings

public class POSCashINSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "POSCashIN";
/// <summary>
/// Cash drop transaction ID.
/// Set this parameter to update an existing Transaction. 
/// </summary>
public int? TransactionID { get; set; }
/// <summary>
/// Point of sale ID 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Employee doing the cash drop. If omitted, Erply assumes cash drop was done by the user who sent the API call. 
/// </summary>
public int? EmployeeID { get; set; }
public float? Sum { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be defined in Erply. If omitted, or an unknown currency code is provided, API uses your default currency instead. 
/// </summary>
public string CurrencyCode { get; set; }
public string Comment { get; set; }
/// <summary>
/// Time when this cash drop took place. Correct timestamps are very important for the day end Z Report to be correct. If omitted, InventoryAPI uses current server timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region POSCashOUT Settings

public class POSCashOUTSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "POSCashOUT";
/// <summary>
/// Cash drop transaction ID.
/// Set this parameter to update an existing Transaction. 
/// </summary>
public int? TransactionID { get; set; }
/// <summary>
/// Point of sale ID 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Employee doing the payout. If omitted, Erply assumes payout was done by the user who sent the API call. 
/// </summary>
public int? EmployeeID { get; set; }
public float? Sum { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be defined in Erply. If omitted, or an unknown currency code is provided, API uses your default currency instead. 
/// </summary>
public string CurrencyCode { get; set; }
public string Comment { get; set; }
/// <summary>
/// Time when this cash payout took place. Correct timestamps are very important for the day end Z Report to be correct. If omitted, InventoryAPI uses current server timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region POSCloseDay Settings

public class POSCloseDaySettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "POSCloseDay";
/// <summary>
/// Point of sale ID 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Employee closing the day. If omitted, Erply assumes day was closed by the user who sent the API call. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// POS day opening timestamp 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTime { get; set; }
/// <summary>
/// POS day ID.
/// NB! You must provide EITHER openedUnixTime or dayID to indicate which day exactly needs to be closed. 
/// </summary>
public int? DayID { get; set; }
/// <summary>
/// Closing timestamp 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ClosedUnixTime { get; set; }
/// <summary>
/// Total amount of money left in register 
/// </summary>
public float? ClosedSum { get; set; }
/// <summary>
/// Total amount of money removed from register and deposited 
/// </summary>
public float? BankedSum { get; set; }
/// <summary>
/// ID of cash variance reason. See getReasonCodes for various reason codes. 
/// </summary>
public int? ReasonID { get; set; }
/// <summary>
/// Notes. 
/// </summary>
public string Notes { get; set; }
/// <summary>
/// Specify the currency for which you want to close the day in the register.
/// Note: by default, this field should not be used. In a default configuration, ERPLY allows to count the cash in the register only in the default currency. The cashier should just set aside any cash received in foreign currencies, and remove it from the register at the end of the day. From back office, it is possible to manually print a Z Report that lists transactions made in a different currency, but the counted amount cannot be recorded in POS, neither when opening nor when closing the day.
/// Therefore, in this setup, it is not possible to use the "currencyCode" field. API will return error code 1028 if you attempt to set it.
/// However, customer support can enable an extra module, "POS multicurrency". With this extra module, it becomes possible to count other currencies as well and record the counts.
/// In that configuration, a separate "POSOpenDay" call must be sent for each currency. If the shop accepts EUR, USD and JPY, three "POSOpenDay" calls should be made in the morning and three corresponding "POSCloseDay" calls in the evening, to store the end-of-day counts.
/// At the end of the day, it is possible to print three Z Reports, one for each currency.
/// Accepted value: for example "EUR" or "USD". The currency must be defined on your ERPLY account, in the "Currencies" module.
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Deprecated. 
/// </summary>
public int? FindLastOpenDay { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#endregion
#region Company

#region VerifyUser Settings

public class VerifyUserSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "verifyUser";
/// <summary>
/// User name 
/// </summary>
public string Username { get; set; }
/// <summary>
/// Password 
/// </summary>
public string Password { get; set; }
/// <summary>
/// Desired session length in seconds (1...86400 sec).
/// If you omit the parameter, or specify 0 or a negative value, a session with a default length of 3600 will be created. If you specify a value larger than 86400 seconds, session length will be set to 86400 seconds. 
/// </summary>
public int? SessionLength { get; set; }
}

#endregion

#endregion
#region Inventory

#region SaveWarehouse Settings

public class SaveWarehouseSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveWarehouse";
public int? WarehouseID { get; set; }
/// <summary>
/// Warehouse name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// Warehouse code. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Store region ID, available only if "Store regions" module has been enabled on your account.
/// To get a list of store regions, see getStoreRegions.
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Assortment ID.
/// An assortment defines which product can be sold and/or purchased in this location.
/// Using assortments requires the "Assortments" extra module which customer support can enable on your account.
/// To get a list of assortments and their contents, see getAssortments and getAssortmentProducts.
/// </summary>
public int? AssortmentID { get; set; }
/// <summary>
/// Warehouse first price list 
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Warehouse second price list 
/// </summary>
public int? PriceListID2 { get; set; }
/// <summary>
/// Warehouse third price list 
/// </summary>
public int? PriceListID3 { get; set; }
/// <summary>
/// A comma-separated list of store groups 
/// </summary>
public string StoreGroups { get; set; }
/// <summary>
/// Set a custom "company name" for this location.
/// Typically you should not use this field. This may be needed only if the location is a separate corporate entity: your business is a franchise chain that operates in a single ERPLY account, instead of using a separate account for each entity. 
/// </summary>
public string CompanyName { get; set; }
/// <summary>
/// Set a custom "company registry number" for this location. See the comment above. 
/// </summary>
public string CompanyCode { get; set; }
/// <summary>
/// Set a custom "company VAT number" for this location. See the comment above. 
/// </summary>
public string CompanyVatNumber { get; set; }
/// <summary>
/// Set the ID of location's address. The ID MUST be one of the addresses on your company card.
/// (It is not possible to edit company information or add corporate addresses via API, and API call getCompanyInfo does not return a list of all corporate addresses. Therefore this field is probably useful only if the address has been defined in ERPLY back office beforehand, and you know its ID.) 
/// </summary>
public int? AddressID { get; set; }
/// <summary>
/// Set a time zone for a location. This could be used if the time zone of a location is different from the time zone of the main account. Example value: "Europe/Tallinn" 
/// </summary>
public string TimeZone { get; set; }
/// <summary>
/// Set the location's phone number. This information is displayed for example on invoice and receipt printouts.
/// If you do not specify a phone number for this location, the printouts will display general corporate phone number, from your company card. (The same comment also applies to the fields below.) 
/// </summary>
public string Phone { get; set; }
/// <summary>
/// Set the location's fax number. 
/// </summary>
public string Fax { get; set; }
/// <summary>
/// Set the location's e-mail address. 
/// </summary>
public string Email { get; set; }
/// <summary>
/// Set the location's web site address. 
/// </summary>
public string Website { get; set; }
/// <summary>
/// Set the location's bank name. 
/// </summary>
public string Bank { get; set; }
/// <summary>
/// Set the location's bank account number. 
/// </summary>
public string Account { get; set; }
/// <summary>
/// Set the location's bank BIC/SWIFT code. 
/// </summary>
public string Swift { get; set; }
/// <summary>
/// Set the location's IBAN (international bank account number). 
/// </summary>
public string Iban { get; set; }
/// <summary>
/// Salon-specific attribute. Available only if Salon / Spa module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(ISOTimeHHmmConverter))]
public TimeSpan? Shift1Start { get; set; }
/// <summary>
/// Salon-specific attribute. Available only if Salon / Spa module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(ISOTimeHHmmConverter))]
public TimeSpan? Shift1End { get; set; }
/// <summary>
/// Salon-specific attribute. Available only if Salon / Spa module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(ISOTimeHHmmConverter))]
public TimeSpan? Shift2Start { get; set; }
/// <summary>
/// Salon-specific attribute. Available only if Salon / Spa module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(ISOTimeHHmmConverter))]
public TimeSpan? Shift2End { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveInventoryRegistration Settings

public class SaveInventoryRegistrationSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveInventoryRegistration";
/// <summary>
/// Inventory registration ID.
/// Set this parameter to update an existing Inventory Registration.
/// If the ERPLY account has upgraded inventory module (indicated by the (i) signifier at the lower right corner, after version number, in Erply backend), and the Inventory Registration is already in confirmed status, it is no longer possible to change:
/// warehouseID
/// currencyCode
/// document rows - amount and IDs.
/// API will return error 1017 if you attempt to change any of those fields. Document row's price can be edited but all rows and values should be presented, API will return error 1023 if you have wrong information in rows. 
/// </summary>
public int? InventoryRegistrationID { get; set; }
/// <summary>
/// Company user unique ID 
/// </summary>
public int? CreatorID { get; set; }
/// <summary>
/// ID of the warehouse 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// ID of the supplier 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Reason Code ID. To use this field, your account needs to have the "Reason codes for Inventory registrations" module enabled, otherwise API will return error code 1006. Please contact customer support to enable it. 
/// </summary>
public int? ReasonID { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be present in the system.
/// If omitted, default currency will be used. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 2010-01-29
/// If omitted, current date will be used. 
/// </summary>
public string Date { get; set; }
/// <summary>
/// Source of received inventory 
/// </summary>
public string Cause { get; set; }
/// <summary>
/// By default 1 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
/// <summary>
/// Product ID for this document line. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// Quantity to be taken into stock.
/// This value can also be negative; in that case, the quantity will be subtracted from stock (written off). When doing inventory adjustments, it might be convenient to put both positive and negative changes on the same document.
/// </summary>
public float? Amount# { get; set; }
/// <summary>
/// Unit cost. The item will be added to inventory at this specified cost. 
/// </summary>
public float? Price# { get; set; }
/// <summary>
/// Set this field if you want to indicate that the product is taken into inventory as packages. Use it together with "amountOfPackages#".
/// Packages are product-specific; a product can have zero or more defined packages. To retrieve a product's packages, call getProducts with input parameter getPackageInfo = 1 and see the block productPackages in the output.
/// To use this field, your account needs to have the "Packages on Inventory Registrations" extra module enabled, otherwise API will return error code 1028. Please contact customer support to enable it.
/// </summary>
public int? PackageID# { get; set; }
/// <summary>
/// Amount of packages.
/// If you specify both amount# and amountOfPackages#, they must correspond to each other: amount# must be equal to amountOfPackages#, multiplied by the quantity in one package.
/// However, it is sufficient to specify only one of the two fields; the second one will be calculated automatically.
/// To use this field, your account needs to have the "Packages on Inventory Registrations" extra module enabled, otherwise API will return error code 1028. Please contact customer support to enable it.
/// </summary>
public float? AmountOfPackages# { get; set; }
}

#endregion

#region SaveInventoryTransfer Settings

public class SaveInventoryTransferSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveInventoryTransfer";
/// <summary>
/// Inventory transfer ID.
/// Set this parameter to update an existing Inventory Transfer.
/// If the ERPLY account has upgraded inventory module (indicated by the (i) signifier at the lower right corner, after version number, in Erply backend), and the transfer is already in confirmed status, it is no longer possible to change:
/// warehouseFromID
/// warehouseToID
/// currencyCode
/// document rows.
/// API will return error 1017 if you attempt to change any of those fields. 
/// </summary>
public int? InventoryTransferID { get; set; }
/// <summary>
/// Employee ID (see getEmployees) — the employee that prepared the Inventory Transfer. 
/// </summary>
public int? CreatorID { get; set; }
/// <summary>
/// Source location (see getWarehouses). 
/// </summary>
public int? WarehouseFromID { get; set; }
/// <summary>
/// Destination location. 
/// </summary>
public int? WarehouseToID { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be present in the system.
/// If omitted, default currency will be used. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Possible values: TRANSFER, TRANSFER_ORDER. By default TRANSFER.
/// TRANSFER_ORDER is an "Inventory Transfer Order", or a request for transfering. In ERPLY backend, it is possible to see Inventory Transfer Orders and turn these into Inventory Transfers. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// eg. 2010-01-29
/// If omitted, current date will be used. 
/// </summary>
public string Date { get; set; }
/// <summary>
/// Source document ID. 
/// </summary>
public int? InventoryTransferOrderID { get; set; }
public string Notes { get; set; }
/// <summary>
/// By default 1.
/// Distinction of confirmed and unconfirmed Inventory Transfers is only possible with the upgraded inventory module. In old inventory system, all Inventory Transfers are regarded as "confirmed". 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
/// <summary>
/// Transfered product. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// Transfered quantity. 
/// </summary>
public float? Amount# { get; set; }
/// <summary>
/// Unit cost of the transfered item.
/// If the ERPLY account has an upgraded inventory module (indicated by the (i) signifier at the lower right corner, after version number, in Erply backend), you do not need to set this field — items are transferred automatically at FIFO cost, and if you attempt to set the cost manually, API will overwrite it anyway. 
/// </summary>
public float? Price# { get; set; }
/// <summary>
/// Set this field if you want to indicate that the product was transferred as packages. Use it together with "amountOfPackages#".
/// Packages are product-specific; a product can have zero or more defined packages. To retrieve a product's packages, call getProducts with input parameter getPackageInfo = 1 and see the block productPackages in the output.
/// To use this field, your account needs to have the "Packages on Inventory Transfers" extra module enabled, otherwise API will return error code 1028. Please contact customer support to enable it.
/// </summary>
public int? PackageID# { get; set; }
/// <summary>
/// Amount of packages transfered.
/// If you specify both amount# and amountOfPackages#, they must correspond to each other: amount# must be equal to amountOfPackages# multiplied by the quantity in one package.
/// However, it is sufficient to specify only one of the two fields; the second one will be calculated automatically.
/// To use this field, your account needs to have the "Packages on Inventory Transfers" extra module enabled, otherwise API will return error code 1028. Please contact customer support to enable it.
/// </summary>
public float? AmountOfPackages# { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveInventoryWriteOff Settings

public class SaveInventoryWriteOffSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveInventoryWriteOff";
/// <summary>
/// Inventory write&#45 
/// </summary>
public int? InventoryWriteOffID { get; set; }
/// <summary>
/// Company user unique ID 
/// </summary>
public int? CreatorID { get; set; }
/// <summary>
/// ID of the reason. See getReasonCodes. 
/// </summary>
public int? ReasonID { get; set; }
/// <summary>
/// ID of the warehouse 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// ID of the recipient of goods 
/// </summary>
public int? RecipientID { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be present in the system.
/// If omitted, default currency will be used. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 2010-01-29
/// If omitted, current date will be used. 
/// </summary>
public string Date { get; set; }
public string Comments { get; set; }
/// <summary>
/// By default 1 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
/// <summary>
/// Product ID for this document line. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// Amount for this document line 
/// </summary>
public float? Amount# { get; set; }
/// <summary>
/// Unit cost. NB! It is typically unnecessary to set this field, because ERPLY removes items from stock according to FIFO principle (items are subtracted from the oldest batch currently in stock) and the cost is taken automatically from that batch. 
/// </summary>
public float? Price# { get; set; }
}

#endregion

#region GetStocktakings Settings

public class GetStocktakingsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getStocktakings";
public int? StocktakingID { get; set; }
/// <summary>
/// Possible values: "CONFIRMED", "IN_PROGRESS". 
/// </summary>
public string Status { get; set; }
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

#region SaveStocktaking Settings

public class SaveStocktakingSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveStocktaking";
public int? WarehouseID { get; set; }
/// <summary>
/// 0 or 1, by default 0.
/// Always create the stocktaking initially in unconfirmed state (you may just omit this flag). Only when it has been finalized and all counts entered and double-checked, confirm the stocktake by re-saving it with flag confirmed = 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
/// <summary>
/// 0 or 1, by default 0.
/// Whether the stocktaking sheet should be pre-populated with a list of products that you have in stock, and their quantities at the current moment.
/// You are STRONGLY recommended to set this flag to 1. If you do not pre-populate the sheet, products will be added to the list as you count them — but then the stocktaking won't catch items that have an inventory quantity in ERPLY, but which are no longer to be found in the warehouse, and you woun't be able to write them off. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? RecordCurrentQuantities { get; set; }
/// <summary>
/// This field only works if you set recordCurrentQuantities = 1. Specifies the products to be included. Possible values:
/// ALL - all products
/// POSITIVE_STOCK - products in stock
/// NEGATIVE_STOCK - products with negative stock
/// NON_ZERO_STOCK - products with non-zero amount in stock
/// If omitted, 'NON_ZERO_STOCK' will be selected as default. 
/// </summary>
public string IncludeProducts { get; set; }
/// <summary>
/// 0 or 1, by default 0.
/// Set it to 1 if reserved items (items on layby) are physically located in another place, and won't be counted during stocktaking. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ExcludeReservations { get; set; }
}

#endregion

#region GetStocktakingReadings Settings

public class GetStocktakingReadingsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getStocktakingReadings";
public int? StocktakingID { get; set; }
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

#region SaveStocktakingReadings Settings

public class SaveStocktakingReadingsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveStocktakingReadings";
public int? StocktakingID { get; set; }
public int? ProductID# { get; set; }
public string CountPcs# { get; set; }
public string Comment# { get; set; }
}

#endregion

#region GetPurchaseDocuments Settings

public class GetPurchaseDocumentsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPurchaseDocuments";
/// <summary>
/// ID of a specific purchase document 
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Supplier ID. 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Multiple supplier IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> SupplierIDs { get; set; }
/// <summary>
/// PRCINVOICE, CASHPRCINVOICE, PRCORDER, PRCRETURN, PRCWAYBILL or PRCINVOICEONLY. See explanation below! 
/// </summary>
public string Type { get; set; }
/// <summary>
/// PENDING, PARTIALLY_RECEIVED, RECEIVED or READY. See explanation below! 
/// </summary>
public string Status { get; set; }
/// <summary>
/// Purchase document status ID 
/// </summary>
public int? StateID { get; set; }
/// <summary>
/// Filter by purchase document date field 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
/// <summary>
/// Filter by purchase document date field 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
/// <summary>
/// 0 or 1 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
/// <summary>
/// 0 or 1 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Paid { get; set; }
/// <summary>
/// Number of purchase document. 
/// </summary>
public string Number { get; set; }
/// <summary>
/// Reference number of purchase document. 
/// </summary>
public string ReferenceNumber { get; set; }
/// <summary>
/// Warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Reg. number of purchase document. 
/// </summary>
public string Regnumber { get; set; }
/// <summary>
/// ID of the system employee, who is set as the creator of the invoice/order/etc. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Filter by the ship date field 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ShipDateFrom { get; set; }
/// <summary>
/// Filter by the ship date field 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ShipDateTo { get; set; }
/// <summary>
/// Set this field to 1 to retrieve the rows for each returned purchase document.
/// Not that in some cases, rows are returned anyway — see the specification of the "rows" field below. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetRowsForAllInvoices { get; set; }
/// <summary>
/// Set this field to 1 to retrieve the inventory cost of each purchased item.
/// Cost is only a property of purchase invoices (not POs), and only products have a cost (services do not, since services are not taken into inventory). Cost is the sum of purchase price, plus shipping and other costs divided between invoice items.
/// If set to 1, API will return "unitCost" and "costTotal" for each document row, and "cost" for the whole document.  
/// </summary>
public string GetCost { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
public string OrderBy { get; set; }
public string OrderByDir { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 100. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region SavePurchaseDocument Settings

public class SavePurchaseDocumentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "savePurchaseDocument";
/// <summary>
/// ID of existing document. If this parameter is present, then an existing document is updated. 
/// </summary>
public int? Id { get; set; }
/// <summary>
/// ID of the warehouse
/// If omitted, system will associate with the warehouse with the first ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be present in the system. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Number to be given to the purchase document. 
/// </summary>
public string No { get; set; }
/// <summary>
/// If your account has configuration setting use_purchase_waybills enabled, then the possible types are:
/// PRCORDER Purchase order
/// PRCINVOICE Purchase invoice-waybill. Takes items into stock and affects your Accounts Payable.
/// A Purchase Invoice-Waybill is equivalent to making a Purchase Waybill (PRCWAYBILL), followed by a Purchase Invoice (PRCINVOICEONLY)
/// CASHPRCINVOICE Purchase receipt. Same as previous.
/// PRCRETURN Purchase return. Functionally same as a purchase invoice-waybill, but it is used to return goods back to supplier.
/// On a purchase return, amounts are negative.
/// PRCWAYBILL Purchase waybill. This document ONLY takes items into stock, and does not generate an obligation to pay.
/// PRCINVOICEONLY Purchase invoice. This is usually a follow-up for the items that have arrived earlier with an invoice-waybill.
/// For example, the supplier may send shipments continuously throughout the month, and bill the customer once a month, for all the shipments sent.
/// The invoice does not affect stock, but it affects your Accounts Payable.
/// If the setting is not enabled, possible types are:
/// PRCORDER Purchase order
/// PRCINVOICE Purchase invoice-waybill. Takes items into stock and affects your Accounts Payable. (Here, we can also call it a "purchase invoice" for short, since there are no other similar document types.)
/// CASHPRCINVOICE Purchase receipt. Same as previous.
/// PRCRETURN Purchase return. Functionally same as a purchase invoice-waybill, but it is used to return goods back to supplier.
/// By default: PRCINVOICE 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Purchase order
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase invoice-waybill. Takes items into stock and affects your Accounts Payable.
/// A Purchase Invoice-Waybill is equivalent to making a Purchase Waybill (PRCWAYBILL), followed by a Purchase Invoice (PRCINVOICEONLY)
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase receipt. Same as previous.
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase return. Functionally same as a purchase invoice-waybill, but it is used to return goods back to supplier.
/// On a purchase return, amounts are negative.
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase waybill. This document ONLY takes items into stock, and does not generate an obligation to pay.
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase invoice. This is usually a follow-up for the items that have arrived earlier with an invoice-waybill.
/// For example, the supplier may send shipments continuously throughout the month, and bill the customer once a month, for all the shipments sent.
/// The invoice does not affect stock, but it affects your Accounts Payable.
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase order
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase invoice-waybill. Takes items into stock and affects your Accounts Payable. (Here, we can also call it a "purchase invoice" for short, since there are no other similar document types.)
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase receipt. Same as previous.
/// </summary>
public   { get; set; }
/// <summary>
/// Purchase return. Functionally same as a purchase invoice-waybill, but it is used to return goods back to supplier.
/// </summary>
public   { get; set; }
/// <summary>
/// eg. 2010-01-29
/// If omitted, date of request will be used 
/// </summary>
public string Date { get; set; }
/// <summary>
/// eg. 14:59:00
/// If omitted, time of submission will be used 
/// </summary>
public string Time { get; set; }
/// <summary>
/// By default 1 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ConfirmInvoice { get; set; }
public int? SupplierID { get; set; }
public int? AddressID { get; set; }
public int? ContactID { get; set; }
/// <summary>
/// ID of the system employee, who is set as the creator of the invoice/order/etc. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Status of the document itself. See getPurchaseDocumentStatuses. 
/// </summary>
public int? StateID { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the main currency against system's default currency.
/// If the invoice is in system's default currency, does not have to be specified (but if specified, use 1.0)
/// If omitted, the current exchange rate stored in the system will be used. 
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// eg. 5
/// In how many days the purchase document is due. 
/// </summary>
public int? PaymentDays { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Paid { get; set; }
/// <summary>
/// Only for EU accounts. Transaction types can be configured in Settings → Purchase transactions (Intrastat) 
/// </summary>
public int? TransactionTypeID { get; set; }
/// <summary>
/// Only for EU accounts. Transport types can be configured in Settings → Transportation types (Intrastat) 
/// </summary>
public int? TransportTypeID { get; set; }
/// <summary>
/// Only for EU accounts. Delivery terms can be configured in Settings → Incoterms 
/// </summary>
public int? DeliveryTermsID { get; set; }
/// <summary>
/// Only for EU accounts 
/// </summary>
public string DeliveryTermsLocation { get; set; }
/// <summary>
/// Integer, only for EU accounts 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TriangularTransaction { get; set; }
public int? ProjectID { get; set; }
public string ReferenceNumber { get; set; }
/// <summary>
/// Source document IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BaseDocumentIDs { get; set; }
public string Notes { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ShipDate { get; set; }
public float? Rounding { get; set; }
public float? NetTotalForAccounting { get; set; }
public float? TotalForAccounting { get; set; }
/// <summary>
/// ID of the product. Either productID or serviceID can be set, but not both at the same time. Both can be omitted, however - in that case a free-text invoice row is created 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// ID of the service 
/// </summary>
public int? ServiceID# { get; set; }
/// <summary>
/// name of the item (use only if you want to override the default product/service name) 
/// </summary>
public string ItemName# { get; set; }
/// <summary>
/// ID of VAT rate. 
/// </summary>
public int? VatrateID# { get; set; }
/// <summary>
/// Purchased quantity.
/// On a Purchase Return, the quantity should be negative.
/// </summary>
public float? Amount# { get; set; }
/// <summary>
/// Original net price (pre-discount) per item. 
/// </summary>
public float? Price# { get; set; }
public float? Discount# { get; set; }
/// <summary>
/// Set this field if you want to indicate that the product is purchased as packages, or that you want to order the product in packages. Use it together with "amountOfPackages#".
/// Packages are product-specific; a product can have zero or more defined packages. To retrieve a product's packages, call getProducts with input parameter getPackageInfo = 1 and see the block productPackages in the output.
/// </summary>
public int? PackageID# { get; set; }
/// <summary>
/// Amount of packages sold.
/// If you specify both amount# and amountOfPackages#, they must correspond to each other: amount# must be equal to amountOfPackages# multiplied by the quantity in one package.
/// However, it is sufficient to specify only one of the two fields; the second one will be calculated automatically.
/// </summary>
public float? AmountOfPackages# { get; set; }
}

#endregion

#region DeletePurchaseDocument Settings

public class DeletePurchaseDocumentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deletePurchaseDocument";
/// <summary>
/// The document to be deleted. 
/// </summary>
public int? DocumentID { get; set; }
}

#endregion

#endregion
#region Reports

#region GetReports Settings

public class GetReportsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getReports";
/// <summary>
/// The report to retrieve. Possible values: "ZReport", "SalesReport", "totalTax".
/// The "SalesReport" and "totalTax" reports are customer-specific formats and not documented, so "ZReport" is the only option that can be actually used.
/// </summary>
public string Type { get; set; }
/// <summary>
/// If set, report will contain only the transactions in a specific POS. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// If set, report will contain only the transactions in a specific store / warehouse. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// If set, report will contain only the transactions of a specific cashier / associate / salesperson / sales manager. 
/// </summary>
public int? SalesManagerID { get; set; }
/// <summary>
/// If set, report will contain only the transactions in a specific currency. 
/// </summary>
public int? CurrencyCode { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateStart { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateEnd { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? GetShortReport { get; set; }
/// <summary>
/// By default API returns structured data. Set format to "HTML" to retrieve an HTML report 
/// </summary>
public string Format { get; set; }
}

#endregion

#region GetAccountStatements Settings

public class GetAccountStatementsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAccountStatements";
/// <summary>
/// Possible values: PAYMENT_REMINDER 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Customer group ID. 
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// Multiple customer IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CustomerIDs { get; set; }
}

#endregion

#region GetCostOfGoodsSold Settings

public class GetCostOfGoodsSoldSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCostOfGoodsSold";
/// <summary>
/// Note that API's output capacity may be limited. If you experience errors, subdivide your period into smaller chunks and request separately. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
}

#endregion

#region GetGiftCardRedeemings Settings

public class GetGiftCardRedeemingsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getGiftCardRedeemings";
/// <summary>
/// ID of gift card 
/// </summary>
public int? GiftCardID { get; set; }
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

#region GetPointOfSaleDayTotals Settings

public class GetPointOfSaleDayTotalsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPointOfSaleDayTotals";
/// <summary>
/// Point of sale ID. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Specify the currency in which the day was opened, and get today's totals for this specific currency.
/// This parameter is necessary when you want to count cash separately for different currencies. This requires the additional module "POS multicurrency"; please contact customer support to enable it on your account.
/// To count cash in multiple currencies, day must be opened in the register separately in each currency. For instance, if the store accepts EUR, USD and JPY, three POSOpenDay calls need to be sent when the day is opened; one for each currency. Day totals must be retrieved with three "getPointOfSaleDayTotals" calls, and the Z Report can be retrieved separately for each currency with getReports.
/// If the "POS multicurrency" module has not been enabled, setting a value to this input parameter will return API error code 1028. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Opening timestamp. If specified, API tries to retrieve information that specific register day, otherwise, today's information is returned. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTime { get; set; }
}

#endregion

#region GetSalesReport Settings

public class GetSalesReportSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSalesReport";
/// <summary>
/// Report type. Possible values are "SALES_BY_DATE", "SALES_BY_CUSTOMER", "SALES_BY_CUSTOMER_ACCOUNT_MANAGER", "SALES_BY_CUSTOMER_GROUP", "SALES_BY_BUSINESS_AREA", "SALES_BY_WAREHOUSE", "SALES_BY_POINT_OF_SALE", "SALES_BY_PRODUCT", "SALES_BY_PRODUCT_GROUP", "SALES_BY_PRODUCT_GROUP_WITH_DRILL_DOWN", "SALES_BY_DEPARTMENT", "SALES_BY_DEPARTMENT_WITH_DRILL_DOWN", "SALES_BY_SUPPLIER", "SALES_BY_SUPPLIER_WITH_DRILL_DOWN", "SALES_BY_CATEGORY", "SALES_BY_CATEGORY_WITH_DRILL_DOWN", "SALES_BY_BRAND", "SALES_BY_ALL_PRODUCTS", "SALES_BY_CASHIER", "SALES_BY_INVOICE", "SALES_BY_INVOICE_ROWS", "SALES_BY_WEEKDAY", "SALES_BY_HOUR", "SALES_BY_MATRIX", "SALES_BY_MATRIX_WITH_DRILL_DOWN". 
/// </summary>
public string ReportType { get; set; }
/// <summary>
/// If set to 1, sales report displays local-formatted numbers. If set to 0 or unset, sales report displays numbers in standard decimal format. 
/// </summary>
public int? LocalNumberFormatting { get; set; }
/// <summary>
/// Comparison type. Possible values are "WAREHOUSES-NET_SALES", "WAREHOUSES-SALES_COST", "WAREHOUSES-PROFIT", "WAREHOUSES-UNITS_SOLD", "WAREHOUSES-UNITS_SOLD_AND_NET_SALES", "WAREHOUSES-SALES_AND_STOCK_IN_RETAIL_PRICES", "WAREHOUSES-SALES_AND_STOCK_IN_COST", "PERIODS", "EMPLOYEES-NET_SALES", "EMPLOYEES-UNITS_SOLD", "EMPLOYEES-UNITS_SOLD_AND_NET_SALES". 
/// </summary>
public string ComparisonType { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ComparisonDateStart { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ComparisonDateEnd { get; set; }
/// <summary>
/// Setting this parameter to 1 returns a Cost of Goods Sold Report, which, in addition to total revenue, shows the cost of sold items and calculates your margins.
/// Leaving this parameter unset returns a Sales Report, which, in addition to total revenue, shows taxes (or VAT).
/// Please note that a Sales Report and a Cost of Goods Sold Report, for the same period, do not return equivalent data. The costs, revenue and taxes, if placed all side-by-side, will likely not match. Please read the additional explanations below.
/// </summary>
public int? GetCOGS { get; set; }
/// <summary>
/// Report starting date.
/// If you are fetching a Sales Report, filters "dateStart" and "dateEnd" will give you all confirmed, revenue-generating sales documents (invoice-waybills, invoices, receipts, and credit invoices) which have a date in the specified date range.
/// If you are fetching a Cost of Goods Sold Report ("getCOGS" = 1), filters "dateStart" and "dateEnd" will give you all confirmed, inventory-affecting sales documents (invoice-waybills, waybills, receipts, and credit invoices) which have been confirmed in the specified date range — or, in other words, for which the inventory transaction (subtraction of the quantities from inventory) took place during the specified dates.
/// Thus, a Sales Report and a Cost Of Goods Sold Report are going to differ if:
/// A document is confirmed later (eg. the date of an invoice-waybill is May 30, but it gets confirmed on June 2);
/// Goods are shipped to customer with a waybill, and they get their invoice later (at the end of the month).
/// This approach is useful if you want to track the total value of your warehouse and how it has changed over time. For example, the total value of inventory on April 30, plus all purchases and inventory registrations confirmed in May, minus all sales and inventory write-offs confirmed in May, will equal the total value of inventory on May 31.
/// If, however, you need to put sales and cost side-by-side, then you can alternatively fetch the Cost of Goods Sold Report using input parameters "documentDateStart" and "documentDateEnd". This will return documents filtered by their document date, not by inventory transaction date.
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateStart { get; set; }
/// <summary>
/// Report end date.
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateEnd { get; set; }
/// <summary>
/// Use if you need to filter COGS report by invoice date as explained above.
/// To use this filter, your account needs to have Classic back office version 4.12 or newer.
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DocumentDateStart { get; set; }
/// <summary>
/// Use it together with "documentDateStart".
/// To use this filter, your account needs to have Classic back office version 4.12 or newer.
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DocumentDateEnd { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be defined in Erply. If omitted, or an unknown currency code is provided, API uses your default currency instead. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Possible values are "EXCLUDE" - exclude sales of gift cards, "ONLY_GIFT_CARDS" - sales of gift cards only, "BOTH_REGULAR_AND_GIFT_CARD" - both regular and gift card sales. By default "EXCLUDE"
/// If you have specified "getCOGS" = 1, then gift card sales are always included. 
/// </summary>
public string GiftCardsSales { get; set; }
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer group ID. 
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// Customer account manager ID. 
/// </summary>
public int? CustomerAccountManagerID { get; set; }
/// <summary>
/// Customer's business area. 
/// </summary>
public int? BusinessAreaID { get; set; }
/// <summary>
/// If set, report will contain only the transactions of a specific cashier / associate / salesperson / sales manager. 
/// </summary>
public int? SalesManagerID { get; set; }
/// <summary>
/// Warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Point of sale ID. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Region. 
/// </summary>
public string Region { get; set; }
/// <summary>
/// Store group. 
/// </summary>
public string StoreGroup { get; set; }
/// <summary>
/// Product ID. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Filter the report by multiple products. The input parameter must contain a comma-separate list of product IDs, for example: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Product group ID. 
/// </summary>
public int? ProductGroupID { get; set; }
/// <summary>
/// Product category ID. 
/// </summary>
public int? CategoryID { get; set; }
/// <summary>
/// Priority group ID. 
/// </summary>
public int? PriorityGroupID { get; set; }
/// <summary>
/// Supplier ID. 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Service ID. 
/// </summary>
public int? ServiceID { get; set; }
/// <summary>
/// User group ID. 
/// </summary>
public int? UserGroupID { get; set; }
/// <summary>
/// Possible values "ALL" - show all sales, "PRODUCTS" - show product revenue only, "SERVICES" - show service and non-stock product revenue only. By default "ALL". 
/// </summary>
public string ShowProductsAndServices { get; set; }
/// <summary>
/// Brand ID. 
/// </summary>
public int? BrandID { get; set; }
/// <summary>
/// Promotion ID. 
/// </summary>
public int? CampaignID { get; set; }
/// <summary>
/// Type of transaction. Possible values are "ALL" - all transactions (sales and returns), "SALES" - sales only, "RETURNS" - returns only. By default "ALL". 
/// </summary>
public string TransactionType { get; set; }
/// <summary>
/// If set to 1, sales report displays sold bundles as bundles. If set to 0 or unset, sales report displays sold bundles by components separately. 
/// </summary>
public int? DisplayBundles { get; set; }
}

#endregion

#region GetSummaryInventoryReport Settings

public class GetSummaryInventoryReportSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSummaryInventoryReport";
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date { get; set; }
}

#endregion

#region GetAmountsOnOrder Settings

public class GetAmountsOnOrderSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAmountsOnOrder";
public int? WarehouseID { get; set; }
/// <summary>
/// Retrieve one specific product. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Retrieve products in this specific product group. (See getProductGroups.) 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Retrieve products in this product group, or in any of its sub-groups, sub-subgroups etc. 
/// </summary>
public int? GroupIDWithSubgroups { get; set; }
/// <summary>
/// Retrieve products of this supplier. (See getSuppliers.) 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Retrieve products of this brand. (See getBrands.) 
/// </summary>
public int? BrandID { get; set; }
/// <summary>
/// Retrieve products in this priority group. (See getProductPriorityGroups.) 
/// </summary>
public int? PriorityGroupID { get; set; }
/// <summary>
/// Retrieve products in this specific category. (See getProductCategories.) 
/// </summary>
public int? CategoryID { get; set; }
/// <summary>
/// Retrieve products in this category, or in any of its sub-categories, sub-sub-categories etc. 
/// </summary>
public int? CategoryIDWithSubcategories { get; set; }
/// <summary>
/// If set to 1, API returns only products with Reorder Point defined. 
/// </summary>
public int? GetProductsWithReorderPointDefined { get; set; }
/// <summary>
/// If set to 1, API returns only products with Restock Level defined. 
/// </summary>
public int? GetProductsWithRestockLevelDefined { get; set; }
public int? GetOnlyConfirmedPurchaseOrders { get; set; }
}

#endregion

#endregion
#region Storage

#region SaveObject Settings

public class SaveObjectSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveObject";
/// <summary>
/// Object ID
/// If this parameter is present the specified object will be updated. 
/// </summary>
public int? ObjectID { get; set; }
/// <summary>
/// Object group. Think of it as a database table — all objects in one group should have the same structure and same fields.
/// Note: when updating an existing object, do not change its group. Doing this will result in two objects: the original one and the updated one.
/// The group is required even when updating an existing object. 
/// </summary>
public string Group { get; set; }
/// <summary>
/// This request can only be called if you have our partnerKey. Will return error 1016 if invalid. 
/// </summary>
public string PartnerKey { get; set; }
/// <summary>
/// Field name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Field type, possible types are 'string', 'integer' and 'float'. By default 'string'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Field value. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region GetObjects Settings

public class GetObjectsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getObjects";
/// <summary>
/// Object ID. Retrieve one specific object. 
/// </summary>
public int? ObjectID { get; set; }
/// <summary>
/// Group name. Retrieve all objects from one specific group.
/// A group is like a "database table" for your custom relational objects. All objects in one group should have approximately the same data fields.
/// Object IDs are globally unique (ie., not per-group unique); if you look up an object by ID, leave the "group" field unspecified. 
/// </summary>
public string Group { get; set; }
/// <summary>
/// Search for an object that has a specific field value.
/// For example, if you using object storage to store vehicles (that have a license plate number), you may look up a vehicle with the following query: searchAttributeName1 = "licensePlate", searchAttributeValue1 = "ABC1234".
/// It is possible to use only one attribute filter right now, although searching by multiple attributes may be supported in the future.
/// </summary>
public string SearchAttributeName1
searchAttributeValue1 { get; set; }
/// <summary>
/// To use object storage, you need an API partner key. Contact ERPLY customer support to get one. Will return error 1016 if invalid. 
/// </summary>
public string PartnerKey { get; set; }
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

#region DeleteObject Settings

public class DeleteObjectSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteObject";
/// <summary>
/// The object to be deleted. 
/// </summary>
public int? ObjectID { get; set; }
/// <summary>
/// This request can only be called if you have our partnerKey. Will return error 1016 if invalid. 
/// </summary>
public string PartnerKey { get; set; }
}

#endregion

#region IncrementAttributeValue Settings

public class IncrementAttributeValueSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "incrementAttributeValue";
/// <summary>
/// ID of the object 
/// </summary>
public int? ObjectID { get; set; }
/// <summary>
/// Object field name 
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Amount to increment 
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// This request can only be called if you have our partnerKey. Will return error 1016 if invalid. 
/// </summary>
public string PartnerKey { get; set; }
}

#endregion

#region DecrementAttributeValue Settings

public class DecrementAttributeValueSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "decrementAttributeValue";
/// <summary>
/// ID of the object 
/// </summary>
public int? ObjectID { get; set; }
/// <summary>
/// Object field name 
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Amount to decrement 
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// This request can only be called if you have our partnerKey. Will return error 1016 if invalid. 
/// </summary>
public string PartnerKey { get; set; }
}

#endregion

#endregion
#region Other

#region AddAssortmentProducts Settings

public class AddAssortmentProductsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "addAssortmentProducts";
/// <summary>
/// Comma-separated list of product IDs. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Assortment ID. 
/// </summary>
public int? AssortmentID { get; set; }
/// <summary>
/// Product status, possible statuses are 'ACTIVE', 'NO_LONGER_ORDERED', 'NOT_FOR_SALE' and 'ARCHIVED'. If you don't specify this field, products will be added to assortment with the default status 'ACTIVE'. 
/// </summary>
public string Status { get; set; }
}

#endregion

#region AddCustomerRewardPoints Settings

public class AddCustomerRewardPointsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "addCustomerRewardPoints";
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Invoice ID. Sale that earned the points. 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Points must be bigger then 0. 
/// </summary>
public int? Points { get; set; }
/// <summary>
/// Unix timestamp 
/// </summary>
public string CreatedUnixTime { get; set; }
/// <summary>
/// Unix timestamp 
/// </summary>
public string ExpiryUnixTime { get; set; }
/// <summary>
/// Register ID. Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Cashier who processed the sale. Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public string Description { get; set; }
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
/// <summary>
/// Variation name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. To have multilingual names enabled, please contact our customer support. An error will be returned if you attempt to set a name in a specific language and the multilingual names are not enabled on your account. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// Variation code. 
/// </summary>
public string Code { get; set; }
}

#endregion

#region AddProductToPriceList Settings

public class AddProductToPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "addProductToPriceList";
/// <summary>
/// Price list ID 
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Product ID 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Discounted net sales price for a product. Price must be a non-negative decimal. 
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Available only if Quantity discounts module is enabled on your account. The quantity threshold from which the specified price will apply.
/// Amount must be a non-negative integer. It is not possible to add the same product with the same amount twice. 
/// </summary>
public int? Amount { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Subsidy must be a non-negative decimal. 
/// </summary>
public float? Subsidy { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account. 
/// </summary>
public int? SubsidyTypeID { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Page must be a non-negative integer. 
/// </summary>
public int? Page { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Position on page must be a non-negative integer. 
/// </summary>
public int? PositionOnPage { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Forecast units must be a non-negative integer. 
/// </summary>
public int? ForecastUnits { get; set; }
}

#endregion

#region AddProductToSupplierPriceList Settings

public class AddProductToSupplierPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "addProductToSupplierPriceList";
/// <summary>
/// Supplier price list ID. 
/// </summary>
public int? SupplierPriceListID { get; set; }
/// <summary>
/// Product ID. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Discounted net sales price for a product. Price must be a non-negative decimal. 
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Available only if Quantity discounts module is enabled on your account. The quantity threshold from which the specified price will apply.
/// Amount must be a non-negative integer. It is not possible to add the same product with the same amount twice. 
/// </summary>
public int? Amount { get; set; }
/// <summary>
/// Supplier Product Code. 
/// </summary>
public string SupplierCode { get; set; }
/// <summary>
/// Master Pack Quantity must be non-negative integer. 
/// </summary>
public int? MasterPackQuantity { get; set; }
/// <summary>
/// Minimum Order Quantity must be non-negative integer. 
/// </summary>
public int? MinimumOrderQuantity { get; set; }
/// <summary>
/// Import Code. 
/// </summary>
public string ImportCode { get; set; }
/// <summary>
/// Country ID. 
/// </summary>
public int? CountryID { get; set; }
}

#endregion

#region AddPromotionCountsToInvoice Settings

public class AddPromotionCountsToInvoiceSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "addPromotionCountsToInvoice";
/// <summary>
/// Invoice ID. 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Promotion ID 
/// </summary>
public int? PromotionID# { get; set; }
/// <summary>
/// Number of times the promotion applied 
/// </summary>
public int? PromotionCount# { get; set; }
}

#endregion

#region AddStoreRegionPriceList Settings

public class AddStoreRegionPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "addStoreRegionPriceList";
/// <summary>
/// Price list ID. 
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Store region ID. 
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Price list's position.
/// Specify this input parameter if you want to place the price list to a specific position, among this region's price lists; positionNumber = 1 sets it as the region's first price list (and moves the existing ones down), positionNumber = 2 sets it as the second price list and so on.
/// If you do not set this parameter, a new price list will be added to the end, after all the existing ones.
/// Price lists will be applied by ERPLY in the same order, meaning that each successive price list "overwrites" the previous one, or applies its discount percentage on top of the previous list price. Hence, the last price list has the highest priority. Location (store) price lists will be applied on top of region price lists.
/// If you specify a negative or zero value, error 1016 will be returned.
/// </summary>
public int? PositionNumber { get; set; }
}

#endregion

#region AddStoreRegionCustomerGroupPriceList Settings

public class AddStoreRegionCustomerGroupPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "addStoreRegionCustomerGroupPriceList";
/// <summary>
/// Price list ID. 
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Store region ID. 
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Customer group ID. 
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// Price list's position.
/// Specify this input parameter if you want to place the price list to a specific position, among this region's and this customer group's price lists; positionNumber = 1 sets it as the region's and customer group's first price list (and moves the existing ones down), positionNumber = 2 sets it as the second price list and so on.
/// If you do not set this parameter, a new price list will be added to the end, after all the existing ones.
/// If you specify a negative or zero value, error 1016 will be returned.
/// Price lists will be applied by ERPLY in the same order, meaning that each successive price list "overwrites" the previous one, or applies its discount percentage on top of the previous list price. Hence, the last price list has the highest priority.
/// A price list associated with a customer group and region is still essentially a "store price list", and the order of application, in increasing priority, is as follows:
/// Region price lists,
/// Customer group-specific region price lists,
/// Location price lists.
/// </summary>
public int? PositionNumber { get; set; }
}

#endregion

#region AdjustBinQuantities Settings

public class AdjustBinQuantitiesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "adjustBinQuantities";
/// <summary>
/// Bin ID. 
/// </summary>
public int? BinID# { get; set; }
/// <summary>
/// Product ID. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// New amount. 
/// </summary>
public float? NewAmount# { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp# { get; set; }
/// <summary>
/// Creator (employee) ID. 
/// </summary>
public int? CreatorID# { get; set; }
/// <summary>
/// Reason Code ID. 
/// </summary>
public int? ReasonCodeID# { get; set; }
}

#endregion

#region ChangePassword Settings

public class ChangePasswordSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "changePassword";
/// <summary>
/// A valid session key 
/// </summary>
public string SessionKey { get; set; }
/// <summary>
/// A valid password of current user 
/// </summary>
public string OldPassword { get; set; }
/// <summary>
/// New new password, shouldnt match old one and be shorter than 8 symbols 
/// </summary>
public string NewPassword { get; set; }
/// <summary>
/// Desired session length in seconds (1...86400 sec).
/// If you omit the parameter, or specify 0 or a negative value, a session with a default length of 3600 will be created. If you specify a value larger than 86400 seconds, session length will be set to 86400 seconds. 
/// </summary>
public int? SessionLength { get; set; }
}

#endregion

#region ClockIn Settings

public class ClockInSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "clockIn";
/// <summary>
/// Employee ID 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Register ID. This may be omitted, but if one employee works in several locations, it becomes necessary to calculate the work hours in each location separately. 
/// </summary>
public int? PointOfSaleID { get; set; }
public int? WarehouseID { get; set; }
/// <summary>
/// Clock-in time 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? InUnixTime { get; set; }
}

#endregion

#region ClockOut Settings

public class ClockOutSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "clockOut";
/// <summary>
/// Employee ID 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Register ID. This may be omitted, but if one employee works in several locations, it becomes necessary to calculate the work hours in each location separately. 
/// </summary>
public int? PointOfSaleID { get; set; }
public int? WarehouseID { get; set; }
/// <summary>
/// Clock-in time. This is a required input parameter, since API uses it to find the correct timeclock record and update it. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? InUnixTime { get; set; }
/// <summary>
/// Clock-out time 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OutUnixTime { get; set; }
}

#endregion

#region ConvertAPILanguageIdentifierForPOS Settings

public class ConvertAPILanguageIdentifierForPOSSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "convertAPILanguageIdentifierForPOS";
/// <summary>
/// String 
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public int? Language { get; set; }
}

#endregion

#region ConvertPOSLanguageIdentifier Settings

public class ConvertPOSLanguageIdentifierSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "convertPOSLanguageIdentifier";
/// <summary>
/// Language identifier from Berlin POS. (Berlin POS uses application-specific language identifiers; ISO-639 identifiers will not work.) 
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public int? Language { get; set; }
}

#endregion

#region CopyMasterListProductsToErply Settings

public class CopyMasterListProductsToErplySettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "copyMasterListProductsToErply";
/// <summary>
/// Multiple product IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
}

#endregion

#region DeleteAppliance Settings

public class DeleteApplianceSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteAppliance";
/// <summary>
/// The appliance to be deleted. 
/// </summary>
public int? ApplianceID { get; set; }
}

#endregion

#region DeleteAssignment Settings

public class DeleteAssignmentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteAssignment";
/// <summary>
/// The assignment to be deleted. 
/// </summary>
public int? AssignmentID { get; set; }
}

#endregion

#region DeleteAssignmentGroup Settings

public class DeleteAssignmentGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteAssignmentGroup";
/// <summary>
/// The assignment group to be deleted. 
/// </summary>
public int? GroupID { get; set; }
}

#endregion

#region DeleteAssortment Settings

public class DeleteAssortmentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteAssortment";
/// <summary>
/// A comma-separated list of assortment IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> AssortmentIDs { get; set; }
}

#endregion

#region DeleteBillingStatement Settings

public class DeleteBillingStatementSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteBillingStatement";
/// <summary>
/// The billing statement to be deleted. 
/// </summary>
public int? BillingStatementID { get; set; }
}

#endregion

#region DeleteBillingStatementReading Settings

public class DeleteBillingStatementReadingSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteBillingStatementReading";
/// <summary>
/// The reading to be deleted. 
/// </summary>
public int? ReadingID { get; set; }
}

#endregion

#region DeleteBinRecords Settings

public class DeleteBinRecordsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteBinRecords";
/// <summary>
/// Delete all records from specified bins. Multiple bin IDs, separated by commas, such as: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BinIDs { get; set; }
/// <summary>
/// Delete records by ID. Multiple record IDs, separated by commas, such as: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> RecordIDs { get; set; }
/// <summary>
/// Delete records from entire warehouse. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// If you want to delete all records that are associated with one document, or even multiple documents, use input parameters "documentIDs" and "documentType". Multiple document IDs, separated by commas, such as: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DocumentIDs { get; set; }
/// <summary>
/// Possible values:
/// SALES_DOCUMENT - Sales Document
/// PURCHASE_DOCUMENT - Purchase Document
/// INVENTORY_REGISTRATION - Inventory Registration
/// INVENTORY_WRITE_OFF - Inventory Write-Off
/// INVENTORY_TRANSFER - Inventory Transfer
/// </summary>
public string DocumentType { get; set; }
}

#endregion

#region DeleteCampaign Settings

public class DeleteCampaignSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteCampaign";
/// <summary>
/// The sales promotion to be deleted. 
/// </summary>
public int? CampaignID { get; set; }
}

#endregion

#region DeleteCoupon Settings

public class DeleteCouponSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteCoupon";
/// <summary>
/// The coupon rule to be deleted. 
/// </summary>
public int? CouponID { get; set; }
}

#endregion

#region DeleteCustomerAssociation Settings

public class DeleteCustomerAssociationSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteCustomerAssociation";
/// <summary>
/// A comma-separated list of relationship IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> RelationshipIDs { get; set; }
}

#endregion

#region DeleteCustomerGroup Settings

public class DeleteCustomerGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteCustomerGroup";
/// <summary>
/// The customer's group to be deleted. 
/// </summary>
public int? CustomerGroupID { get; set; }
}

#endregion

#region DeleteCustomerProfessional Settings

public class DeleteCustomerProfessionalSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteCustomerProfessional";
/// <summary>
/// A comma-separated list of relationship IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> RelationshipIDs { get; set; }
}

#endregion

#region DeleteDeliveryType Settings

public class DeleteDeliveryTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteDeliveryType";
/// <summary>
/// The delivery type to be deleted. 
/// </summary>
public int? DeliveryTypeID { get; set; }
}

#endregion

#region DeleteEmployee Settings

public class DeleteEmployeeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteEmployee";
/// <summary>
/// The employee to be deleted. 
/// </summary>
public int? EmployeeID { get; set; }
}

#endregion

#region DeleteEvent Settings

public class DeleteEventSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteEvent";
/// <summary>
/// The event to be deleted. 
/// </summary>
public int? EventID { get; set; }
}

#endregion

#region DeleteInventoryRegistration Settings

public class DeleteInventoryRegistrationSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteInventoryRegistration";
/// <summary>
/// The Inventory Registration to be deleted. 
/// </summary>
public int? InventoryRegistrationID { get; set; }
}

#endregion

#region DeleteLocationInWarehouse Settings

public class DeleteLocationInWarehouseSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteLocationInWarehouse";
/// <summary>
/// Comma-separated list of locations in warehouse to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> LocationInWarehouseIDs { get; set; }
}

#endregion

#region DeleteMatrixDimension Settings

public class DeleteMatrixDimensionSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteMatrixDimension";
/// <summary>
/// The dimension to be deleted. 
/// </summary>
public int? DimensionID { get; set; }
}

#endregion

#region DeletePriceList Settings

public class DeletePriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deletePriceList";
/// <summary>
/// A comma-separated list of price list IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PriceListIDs { get; set; }
/// <summary>
/// If set to 1, the API call also removes the price list from all locations, regions, customer groups and customers. However, to do that, you need to have the user rights to modify all locations, regions, customer groups and customers. 
/// </summary>
public int? DeleteAllAssociations { get; set; }
}

#endregion

#region DeleteSubsidyType Settings

public class DeleteSubsidyTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteSubsidyType";
/// <summary>
/// A comma-separated list of type IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> SubsidyTypeIDs { get; set; }
}

#endregion

#region DeleteSupplier Settings

public class DeleteSupplierSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteSupplier";
/// <summary>
/// The supplier to be deleted. 
/// </summary>
public int? SupplierID { get; set; }
}

#endregion

#region DeleteSupplierGroup Settings

public class DeleteSupplierGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteSupplierGroup";
/// <summary>
/// The supplier group to be deleted. 
/// </summary>
public int? SupplierGroupID { get; set; }
}

#endregion

#region DeleteProductFile Settings

public class DeleteProductFileSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteProductFile";
/// <summary>
/// The product file to be deleted. 
/// </summary>
public int? ProductFileID { get; set; }
/// <summary>
/// To delete all files of the product, set productID. 
/// </summary>
public int? ProductID { get; set; }
}

#endregion

#region DeleteProductInPriceList Settings

public class DeleteProductInPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteProductInPriceList";
/// <summary>
/// The price list where the product rows will be deleted 
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// The rows to be deleted from the price list. A comma-separated list, such as: 1,2,3.
/// You must send the IDs of price list row records — not product IDs. To find out the respective row IDs, call getProductsInPriceList first. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PriceListProductIDs { get; set; }
}

#endregion

#region DeleteProductPackage Settings

public class DeleteProductPackageSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteProductPackage";
/// <summary>
/// A comma-separated list of package IDs to be deleted. Refers to the field packageID in API getProducts, sub-structure productPackages.
/// The list may contain packages from different products.
/// Recommended length: at most 1000 IDs.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PackageIDs { get; set; }
}

#endregion

#region DeleteProductsFromSupplierPriceList Settings

public class DeleteProductsFromSupplierPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteProductsFromSupplierPriceList";
/// <summary>
/// The supplier price list where the product rows will be deleted. 
/// </summary>
public int? SupplierPriceListID { get; set; }
/// <summary>
/// The rows to be deleted from the supplier price list. A comma-separated list, such as: 1,2,3.
/// You must send the IDs of price list row records — not product IDs. To find out the respective row IDs, call getProductsInSupplierPriceList first. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> SupplierPriceListProductIDs { get; set; }
}

#endregion

#region DeleteProject Settings

public class DeleteProjectSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteProject";
/// <summary>
/// The project to be deleted. 
/// </summary>
public int? ProjectID { get; set; }
}

#endregion

#region DeleteStoreRegion Settings

public class DeleteStoreRegionSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteStoreRegion";
/// <summary>
/// A comma-separated list of store region IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> StoreRegionIDs { get; set; }
}

#endregion

#region DeleteVatRateComponent Settings

public class DeleteVatRateComponentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteVatRateComponent";
/// <summary>
/// The component to be deleted. 
/// </summary>
public int? VatRateComponentID { get; set; }
}

#endregion

#region DeleteCompanyType Settings

public class DeleteCompanyTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteCompanyType";
/// <summary>
/// A comma-separated list of company type IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CompanyTypeIDs { get; set; }
}

#endregion

#region DeletePersonTitle Settings

public class DeletePersonTitleSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deletePersonTitle";
/// <summary>
/// A comma-separated list of person title IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PersonTitleIDs { get; set; }
}

#endregion

#region DeleteJobTitle Settings

public class DeleteJobTitleSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteJobTitle";
/// <summary>
/// A comma-separated list of job title IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> JobTitleIDs { get; set; }
}

#endregion

#region DeleteBusinessArea Settings

public class DeleteBusinessAreaSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "deleteBusinessArea";
/// <summary>
/// A comma-separated list of business area IDs to be deleted. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BusinessAreaIDs { get; set; }
}

#endregion

#region EditAssortmentProducts Settings

public class EditAssortmentProductsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editAssortmentProducts";
/// <summary>
/// Comma-separated list of product IDs. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Assortment ID. 
/// </summary>
public int? AssortmentID { get; set; }
/// <summary>
/// New status for the listed products. Possible statuses are 'ACTIVE', 'NO_LONGER_ORDERED', 'NOT_FOR_SALE' and 'ARCHIVED'. 
/// </summary>
public string Status { get; set; }
}

#endregion

#region EditCompanyInfo Settings

public class EditCompanyInfoSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editCompanyInfo";
/// <summary>
/// String 
/// </summary>
public string Name { get; set; }
/// <summary>
/// String 
/// </summary>
public string Code { get; set; }
/// <summary>
/// String 
/// </summary>
public string VAT { get; set; }
/// <summary>
/// String 
/// </summary>
public string Phone { get; set; }
/// <summary>
/// String 
/// </summary>
public string Mobile { get; set; }
/// <summary>
/// String 
/// </summary>
public string Fax { get; set; }
/// <summary>
/// String 
/// </summary>
public string Email { get; set; }
/// <summary>
/// String 
/// </summary>
public string Web { get; set; }
/// <summary>
/// String 
/// </summary>
public string BankName { get; set; }
/// <summary>
/// String 
/// </summary>
public string BankAccountNumber { get; set; }
/// <summary>
/// String 
/// </summary>
public string BankIBAN { get; set; }
/// <summary>
/// String 
/// </summary>
public string BankSWIFT { get; set; }
/// <summary>
/// String 
/// </summary>
public string BankName2 { get; set; }
/// <summary>
/// String 
/// </summary>
public string BankAccountNumber2 { get; set; }
/// <summary>
/// String 
/// </summary>
public string BankIBAN2 { get; set; }
/// <summary>
/// String 
/// </summary>
public string BankSWIFT2 { get; set; }
}

#endregion

#region EditEarnedRewardPointRecord Settings

public class EditEarnedRewardPointRecordSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editEarnedRewardPointRecord";
/// <summary>
/// Record ID. 
/// </summary>
public int? TransactionID { get; set; }
/// <summary>
/// Change customer ID on the record. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Change invoice ID on the record (the sale that earned the points). 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Change the timestamp when the reward points were earned. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTime { get; set; }
/// <summary>
/// Change the expiry timestamp for these reward points. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ExpiryUnixTime { get; set; }
/// <summary>
/// Change register ID.
/// Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Change cashier who processed the sale.
/// Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Change the comment.
/// Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public string Description { get; set; }
}

#endregion

#region EditItemInMatrixDimension Settings

public class EditItemInMatrixDimensionSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editItemInMatrixDimension";
/// <summary>
/// Variation ID. 
/// </summary>
public int? ItemID { get; set; }
/// <summary>
/// Variation name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. To have multilingual names enabled, please contact our customer support. An error will be returned if you attempt to set a name in a specific language and the multilingual names are not enabled on your account. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// Variation code. 
/// </summary>
public string Code { get; set; }
}

#endregion

#region EditProductInPriceList Settings

public class EditProductInPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editProductInPriceList";
/// <summary>
/// Price list row ID. To get the records use the getProductsInPriceList API call. 
/// </summary>
public int? PriceListProductID { get; set; }
/// <summary>
/// Discounted net sales price for a product. Price must be a non-negative decimal. 
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Available only if Quantity discounts module is enabled on your account. The quantity threshold from which the specified price will apply.
/// Amount must be a non-negative integer. There must not be the same product with the same amount on the price list. 
/// </summary>
public int? Amount { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Subsidy must be a non-negative decimal. 
/// </summary>
public float? Subsidy { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account. 
/// </summary>
public int? SubsidyTypeID { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Page must be a non-negative integer. 
/// </summary>
public int? Page { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Position on page must be a non-negative integer. 
/// </summary>
public int? PositionOnPage { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Forecast units must be a non-negative integer. 
/// </summary>
public int? ForecastUnits { get; set; }
}

#endregion

#region EditProductInSupplierPriceList Settings

public class EditProductInSupplierPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editProductInSupplierPriceList";
/// <summary>
/// Supplier price list row ID. To get the records use the getProductsInSupplierPriceList API call. 
/// </summary>
public int? SupplierPriceListProductID { get; set; }
/// <summary>
/// Discounted net sales price for a product. Price must be a non-negative decimal. 
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Supplier Product Code. 
/// </summary>
public string SupplierCode { get; set; }
/// <summary>
/// Master Pack Quantity must be non-negative integer. 
/// </summary>
public int? MasterPackQuantity { get; set; }
/// <summary>
/// Minimum Order Quantity must be non-negative integer. 
/// </summary>
public int? MinimumOrderQuantity { get; set; }
/// <summary>
/// Import Code. 
/// </summary>
public string ImportCode { get; set; }
/// <summary>
/// Country ID. 
/// </summary>
public int? CountryID { get; set; }
}

#endregion

#region EditStoreRegionPriceList Settings

public class EditStoreRegionPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editStoreRegionPriceList";
/// <summary>
/// Price list ID. 
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Store region ID. 
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Price list's position.
/// Move the price list to a specific position, among this region's price lists; positionNumber = 1 sets it as the region's first price list (and moves the existing ones down), positionNumber = 2 sets it as the second price list and so on.
/// Price lists will be applied by ERPLY in the same order, meaning that each successive price list "overwrites" the previous one, or applies its discount percentage on top of the previous list price. Hence, the last price list has the highest priority. Location (store) price lists will be applied on top of region price lists.
/// If you specify a negative or zero value, error 1016 will be returned.
/// </summary>
public int? PositionNumber { get; set; }
}

#endregion

#region EditStoreRegionCustomerGroupPriceList Settings

public class EditStoreRegionCustomerGroupPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editStoreRegionCustomerGroupPriceList";
/// <summary>
/// Price list ID. 
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Store region ID. 
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Customer group ID. 
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// Price list's position.
/// Move the price list to a specific position, among this region's and this customer group's price lists; positionNumber = 1 sets it as the region's and customer group's first price list (and moves the existing ones down), positionNumber = 2 sets it as the second price list and so on.
/// Price lists will be applied by ERPLY in the same order, meaning that each successive price list "overwrites" the previous one, or applies its discount percentage on top of the previous list price. Hence, the last price list has the highest priority.
/// If you specify a negative or zero value, error 1016 will be returned.
/// </summary>
public int? PositionNumber { get; set; }
}

#endregion

#region EditUsedRewardPointRecord Settings

public class EditUsedRewardPointRecordSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "editUsedRewardPointRecord";
/// <summary>
/// Record ID. 
/// </summary>
public int? TransactionID { get; set; }
/// <summary>
/// Change customer ID on the record. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Change invoice ID on the record (the sale that subtracted the points). 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Change promotion ID (the promotion that caused the points to be subtracted). 
/// </summary>
public int? CampaignID { get; set; }
/// <summary>
/// Change warehouse (store, location) ID (location where the points were subtracted). 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Change register ID. 
/// </summary>
public int? SalepointID { get; set; }
/// <summary>
/// Change cashier who applied the reward point-subtracting promotion. 
/// </summary>
public int? SalespersonID { get; set; }
/// <summary>
/// Change ID of the issued coupon (if reward points were exchanged for a coupon). Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// Change comment. Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public string Description { get; set; }
}

#endregion

#region FindMasterListProducts Settings

public class FindMasterListProductsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "findMasterListProducts";
/// <summary>
/// Search for a product by code or EAN/UPC. Returns all items where beginning of the code (or the EAN/UPC) matches. If the length of this field's value is less than configuration parameter "master_list_min_search_string_length", API returns error 1014. 
/// </summary>
public string SearchCode { get; set; }
}

#endregion

#region GetAppliances Settings

public class GetAppliancesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAppliances";
/// <summary>
/// Appliance ID. 
/// </summary>
public int? ApplianceID { get; set; }
/// <summary>
/// Invoice ID. 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Product ID. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
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

#region GetAppliedPromotionRecords Settings

public class GetAppliedPromotionRecordsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAppliedPromotionRecords";
/// <summary>
/// Retrieve multiple records, IDs separated by commas. Eg. "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> RecordIDs { get; set; }
/// <summary>
/// Comma-separated list of invoice IDs. Retrieve records associated with multiple invoices. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> InvoiceIDs { get; set; }
/// <summary>
/// Comma-separated list of product IDs. Retrieve records associated with multiple products. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Comma-separated list of promotion IDs. Retrieve records associated with multiple promotions. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PromotionIDs { get; set; }
/// <summary>
/// Comma-separated list of price list IDs. Retrieve records associated with multiple price lists.
/// This field can be used only if the "Applied Price Lists Report" module has been enabled on your account. Otherwise, error code 1028 will be returned.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PriceListIDs { get; set; }
/// <summary>
/// Filter records by date range. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
/// <summary>
/// Invoice location ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Invoice register ID. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 100. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetAssignmentGroups Settings

public class GetAssignmentGroupsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAssignmentGroups";
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

#region GetAssignments Settings

public class GetAssignmentsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAssignments";
/// <summary>
/// Assignment ID. 
/// </summary>
public int? AssignmentID { get; set; }
/// <summary>
/// Appliance ID. 
/// </summary>
public int? ApplianceID { get; set; }
/// <summary>
/// Vehicle ID. 
/// </summary>
public int? VehicleID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
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

#region GetAssortments Settings

public class GetAssortmentsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAssortments";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
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

#region GetAssortmentProducts Settings

public class GetAssortmentProductsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getAssortmentProducts";
/// <summary>
/// Assortment ID. Specify assortment ID to get associated products. 
/// </summary>
public int? AssortmentID { get; set; }
/// <summary>
/// Number of records API should return. By default 1000, at most 1000. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
}

#endregion

#region GetBilledUntilDate Settings

public class GetBilledUntilDateSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getBilledUntilDate";
/// <summary>
/// A comma-separated list of billing statement IDs, containing at most 500 IDs.
/// If the list contains more than 500 IDs, error code 1138 is returned.
/// . 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BillingStatementIDs { get; set; }
}

#endregion

#region GetBillingStatements Settings

public class GetBillingStatementsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getBillingStatements";
/// <summary>
/// Billing statement ID. 
/// </summary>
public int? BillingStatementID { get; set; }
/// <summary>
/// Billing statement number. 
/// </summary>
public int? BillingStatementNumber { get; set; }
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDateTo { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDateTo { get; set; }
/// <summary>
/// 0 or 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
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

#region GetBillingStatementReadings Settings

public class GetBillingStatementReadingsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getBillingStatementReadings";
/// <summary>
/// Billing statement ID. 
/// </summary>
public int? BillingStatementID { get; set; }
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

#region GetBinQuantities Settings

public class GetBinQuantitiesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getBinQuantities";
/// <summary>
/// Multiple bin IDs, separated by commas, such as: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BinIDs { get; set; }
/// <summary>
/// Multiple product IDs, separated by commas, such as: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Get quantites from preferred or unnpreferred bins only. 0 or 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Preferred { get; set; }
/// <summary>
/// Retrieve only those bins where current quantity is larger or equal to the specified value. 
/// </summary>
public float? MinimumAmount { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetBinRecords Settings

public class GetBinRecordsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getBinRecords";
/// <summary>
/// Multiple bin IDs, separated by commas, such as: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BinIDs { get; set; }
/// <summary>
/// Filter by warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Filter by multiple document IDs, separated by commas, such as: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DocumentIDs { get; set; }
/// <summary>
/// Filter by document type. Possible values:
/// SALES_DOCUMENT - Sales Document
/// PURCHASE_DOCUMENT - Purchase Document
/// INVENTORY_REGISTRATION - Inventory Registration
/// INVENTORY_WRITE_OFF - Inventory Write-Off
/// INVENTORY_TRANSFER - Inventory Transfer
/// </summary>
public string DocumentType { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? TimestampStart { get; set; }
/// <summary>
/// :Integer (Unix timestamp)  
/// </summary>
public string TimestampEnd { get; set; }
/// <summary>
/// Get records from preferred or unnpreferred bins only. 0 or 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Preferred { get; set; }
/// <summary>
/// Retrieve only records that have been added or modified since the specified timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetBins Settings

public class GetBinsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getBins";
/// <summary>
/// Get bins that belong to a specific warehouse. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Bin code. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Possible values: "ACTIVE", "ARCHIVED" (by default returns both). 
/// </summary>
public string Status { get; set; }
/// <summary>
/// Get preferred or unnpreferred bins only. 0 or 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Preferred { get; set; }
public string AllowedProduct { get; set; }
/// <summary>
/// Retrieve multiple bins, IDs separated by commas. Eg. "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BinIDs { get; set; }
}

#endregion

#region GetBusinessAreas Settings

public class GetBusinessAreasSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getBusinessAreas";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetCashIns Settings

public class GetCashInsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCashIns";
/// <summary>
/// Warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Point of sale ID. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Employee ID. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Beginning of the date interval for which you want to retrieve POS cash drops and cash payouts (deprecated alternative name: startDateTime). 
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? DateTimeFrom { get; set; }
/// <summary>
/// End of the date interval for which you want to retrieve POS cash drops and cash payouts (deprecated alternative name: endDateTime). 
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? DateTimeUntil { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
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

#region GetChangedDataSince Settings

public class GetChangedDataSinceSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getChangedDataSince";
/// <summary>
/// Timestamp. If this parameter is supplied, server returns information about all modules. You may also use the input parameters below, to get information about certain modules only.
/// Note that server clock may be different from yours. To ensure that data is exchanged correctly, server timestamps should always be used. (Server returns its timestamp with each API call, see the "requestUnixTime" attribute in response header.) 
/// </summary>
public int? ChangedSince { get; set; }
public int? CustomersChangedSince { get; set; }
public int? EmployeesChangedSince { get; set; }
public int? SuppliersChangedSince { get; set; }
public int? AddressesChangedSince { get; set; }
public int? CurrenciesChangedSince { get; set; }
public int? CustomerGroupsChangedSince { get; set; }
public int? EmailAccountsChangedSince { get; set; }
public int? GiftCardsChangedSince { get; set; }
public int? PointsOfSaleChangedSince { get; set; }
public int? PriceListsChangedSince { get; set; }
public int? ProductGroupsChangedSince { get; set; }
public int? ProductCategoriesChangedSince { get; set; }
public int? ProductsChangedSince { get; set; }
public int? ServicesChangedSince { get; set; }
public int? SupplierGroupsChangedSince { get; set; }
public int? UsersChangedSince { get; set; }
public int? EventsChangedSince { get; set; }
public int? PurchaseDocumentsChangedSince { get; set; }
public int? SalesDocumentsChangedSince { get; set; }
public int? CampaignsChangedSince { get; set; }
public int? CouponsChangedSince { get; set; }
public int? WarehousesChangedSince { get; set; }
public int? VatRatesChangedSince { get; set; }
public int? InventoryRegistrationsChangedSince { get; set; }
public int? InventoryTransfersChangedSince { get; set; }
public int? InventoryWriteOffsChangedSince { get; set; }
public int? PaymentsChangedSince { get; set; }
}

#endregion

#region GetClockedInEmployees Settings

public class GetClockedInEmployeesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getClockedInEmployees";
/// <summary>
/// Multiple Warehouse IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> WarehouseIDs { get; set; }
}

#endregion

#region GetClockIns Settings

public class GetClockInsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getClockIns";
/// <summary>
/// Timeclock record ID 
/// </summary>
public int? TimeclockRecordID { get; set; }
/// <summary>
/// Employee ID 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Warehouse ID 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// If set to 1, fetches only those timeclock records which have not been closed yet 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NotClockedOut { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? InUnixTimeFrom { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? InUnixTimeUntil { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OutUnixTimeFrom { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OutUnixTimeUntil { get; set; }
}

#endregion

#region GetCountries Settings

public class GetCountriesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCountries";
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

#region GetCoupons Settings

public class GetCouponsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCoupons";
/// <summary>
/// ID of coupon 
/// </summary>
public int? CouponID { get; set; }
/// <summary>
/// Multiple coupon IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CouponIDs { get; set; }
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

#region GetCustomerBalances Settings

public class GetCustomerBalancesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCustomerBalances";
/// <summary>
/// If omitted, current date will be used. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date { get; set; }
}

#endregion

#region GetCustomerRewardPoints Settings

public class GetCustomerRewardPointsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCustomerRewardPoints";
/// <summary>
/// Customer's ID 
/// </summary>
public int? CustomerID { get; set; }
}

#endregion

#region GetDayClosings Settings

public class GetDayClosingsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getDayClosings";
/// <summary>
/// Search for a specific POS day opening & closing. 
/// </summary>
public int? DayID { get; set; }
/// <summary>
/// Warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Point of sale ID. 
/// </summary>
public int? PointOfSaleID { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTimeFrom { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTimeUntil { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ClosedUnixTimeFrom { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ClosedUnixTimeUntil { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Search for day openings and closings in the register that were done for a specific currency.
/// Note: by default, you should not use this filter. In a default configuration, only default currency can be counted in POS, and the day opening and closing records will have no currency field at all.
/// This field can only be used if your account has the "POS multicurrency" module activated. Please contact customer support to enable it. If that module is not installed, setting this input parameter returns API error code 1028. 
/// </summary>
public string CurrencyCode { get; set; }
}

#endregion

#region GetEarnedRewardPointRecords Settings

public class GetEarnedRewardPointRecordsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getEarnedRewardPointRecords";
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Comma-separated list of customer IDs. Retrieve transactions associated with multiple customers. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CustomerIDs { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTimeFrom { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTimeTo { get; set; }
}

#endregion

#region GetEDocuments Settings

public class GetEDocumentsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getEDocuments";
/// <summary>
/// By default "XML" 
/// </summary>
public string Format { get; set; }
/// <summary>
/// Specify ALLSALESINVOICES or ALLPURCHASEINVOICES if you do not want to filter by type, or if you are querying by document ID.
/// Otherwise, the following options are available: SALESINVWAYBILL, SALESINVOICE, SALESORDER, SALESEXPORTINVOICE, SALESCASHINVOICE, SALESCREDITINVOICE, PURCHASEINVOICE, PURCHASEORDER 
/// </summary>
public string Type { get; set; }
public string DateFrom { get; set; }
public string DateTo { get; set; }
/// <summary>
/// ID of a specific e-document  
/// </summary>
public int? DocumentID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
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

#region GetEmailAccounts Settings

public class GetEmailAccountsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getEmailAccounts";
public int? UserID { get; set; }
public int? EmailAccountID { get; set; }
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

#region GetEvents Settings

public class GetEventsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getEvents";
/// <summary>
/// Retrieve one specific event. 
/// </summary>
public int? EventID { get; set; }
/// <summary>
/// Search for an event, by any text contained in event name (description). 
/// </summary>
public string Description { get; set; }
/// <summary>
/// Filter events by employee (assignee, stylist). 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Filter events by creator. 
/// </summary>
public int? SubmitterID { get; set; }
/// <summary>
/// Filter events by supplier. 
/// </summary>
public int? SupllierID { get; set; }
/// <summary>
/// Filter events by status. 
/// </summary>
public int? StatusID { get; set; }
/// <summary>
/// Filter events by type. 
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Retrieve events associated with one customer. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Comma-separated list of customer IDs. Retrieve events associated with multiple customers. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CustomerIDs { get; set; }
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? StartDateTimeFrom { get; set; }
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? StartDateTimeUntil { get; set; }
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? EndDateTimeFrom { get; set; }
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? EndDateTimeUntil { get; set; }
public int? ResourceID { get; set; }
public int? ProjectID { get; set; }
/// <summary>
/// Filter events by location.
/// Salon-specific attribute. Available only if Salon / Spa module is enabled on your account. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// This is an event type filter. getAllSalonEvents = 1 returns all special spa/salon events (appointments, employee breaks, lunches, vacations, sick days), except for the events that represent employee work schedule. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetAllSalonEvents { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Possible values: "eventID", "startTime", "endTime", "type", "status", "customerName", "employeeName", "submitterName". By default: "startTime" 
/// </summary>
public string OrderBy { get; set; }
public string OrderByDir { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 1000. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
}

#endregion

#region GetEventStatuses Settings

public class GetEventStatusesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getEventStatuses";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetEventTypes Settings

public class GetEventTypesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getEventTypes";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetFranchiseSalesDocuments Settings

public class GetFranchiseSalesDocumentsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getFranchiseSalesDocuments";
/// <summary>
/// Search for a sales document by number. 
/// </summary>
public int? Number { get; set; }
/// <summary>
/// You can specify multiple document types (INVWAYBILL, CASHINVOICE, WAYBILL, PREPAYMENT, OFFER, EXPORTINVOICE, RESERVATION, CREDITINVOICE, ORDER, or INVOICE), separated by commas. 
/// </summary>
public string Types { get; set; }
/// <summary>
/// If this filter is set, API will only return those sales documents which have at least one card payment, and where the card payment has a specified card type. 
/// </summary>
public string ContainingPaymentWithCardType { get; set; }
/// <summary>
/// If a sales document has been partially credited, returns only those amounts and rows that have not been credited yet. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NonReturnedItemsOnly { get; set; }
}

#endregion

#region GetFulfillableOrders Settings

public class GetFulfillableOrdersSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getFulfillableOrders";
/// <summary>
/// Warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateStart { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateEnd { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDateStart { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDateEnd { get; set; }
/// <summary>
/// Delivery type ID. 
/// </summary>
public int? DeliveryTypeID { get; set; }
}

#endregion

#region GetGiftCards Settings

public class GetGiftCardsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getGiftCards";
/// <summary>
/// ID of gift card 
/// </summary>
public int? GiftCardID { get; set; }
/// <summary>
/// Gift card's code 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Available only if "Gift card extras" module is enabled on your account. 
/// </summary>
public int? PurchaseInvoiceID { get; set; }
/// <summary>
/// Filter gift cards by the "time of purchase" timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? PurchasedUnixTimeFrom { get; set; }
/// <summary>
/// Filter gift cards by the "time of purchase" timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? PurchasedUnixTimeTo { get; set; }
/// <summary>
/// Filter gift cards by the "time when redeemed" timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? RedeemedUnixTimeFrom { get; set; }
/// <summary>
/// Filter gift cards by the "time when redeemed" timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? RedeemedUnixTimeTo { get; set; }
/// <summary>
/// Filter gift cards by VAT rate ID. 
/// </summary>
public int? VatrateID { get; set; }
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

#region GetHomeStores Settings

public class GetHomeStoresSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getHomeStores";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetInventoryRegistrations Settings

public class GetInventoryRegistrationsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getInventoryRegistrations";
/// <summary>
/// Get one specific Inventory Registration. 
/// </summary>
public int? InventoryRegistrationID { get; set; }
/// <summary>
/// Retrieve inventory registrations of a specific location (warehouse, store). See getWarehouses. 
/// </summary>
public int? WarehouseID { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
/// <summary>
/// Search for an Inventory Registration by the text field "Source of received inventory". Only exact matches are returned (field full contents must match). 
/// </summary>
public string Cause { get; set; }
/// <summary>
/// If set to 1, API also returns the cost. 
/// </summary>
public int? GetCost { get; set; }
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

#region GetInventoryTransferReport Settings

public class GetInventoryTransferReportSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getInventoryTransferReport";
/// <summary>
/// Retrieve either a report of inventory transfers (actual movements that have taken place), or inventory transfer orders.
/// Possible values are "TRANSFER", "TRANSFER_ORDER". 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Date range filter. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateStart { get; set; }
/// <summary>
/// Date range filter. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateEnd { get; set; }
/// <summary>
/// Currency code: EUR, USD.
/// Setting this parameter will return a report where all sums have been re-calculated into specified currency. In other words, this is NOT a filter. In almost all cases, you will want the report in your account default currency, so it is recommended to omit this parameter.
/// The specified currency must be defined in Erply. If omitted, or an unknown currency code is provided, API uses your default currency. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Filter inventory transfers by source location (warehouse, store). 
/// </summary>
public int? WarehouseFromID { get; set; }
/// <summary>
/// Filter inventory transfers by destination location (warehouse, store). 
/// </summary>
public int? WarehouseToID { get; set; }
/// <summary>
/// Filter inventory transfers by supplier. 
/// </summary>
public int? SupplierID { get; set; }
}

#endregion

#region GetInventoryTransfers Settings

public class GetInventoryTransfersSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getInventoryTransfers";
/// <summary>
/// Get one specific Inventory Transfer 
/// </summary>
public int? InventoryTransferID { get; set; }
/// <summary>
/// Retrieve transfers from a specific source location (warehouse, store). See getWarehouses. 
/// </summary>
public int? WarehouseFromID { get; set; }
/// <summary>
/// Retrieve transfers to a specific destination location (warehouse, store). See getWarehouses. 
/// </summary>
public int? WarehouseToID { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
/// <summary>
/// If set to 1, API also returns the cost. 
/// </summary>
public int? GetCost { get; set; }
/// <summary>
/// 0 or 1 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
/// <summary>
/// Possible values: TRANSFER, TRANSFER_ORDER. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// If set to 1, API returns only fulfilled Inventory Transfer Orders. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Fulfilled { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
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

#region GetInventoryWriteOffs Settings

public class GetInventoryWriteOffsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getInventoryWriteOffs";
/// <summary>
/// ID of inventory write-off 
/// </summary>
public int? InventoryWriteOffID { get; set; }
/// <summary>
/// Retrieve inventory registrations of a specific location (warehouse, store). See getWarehouses. 
/// </summary>
public int? WarehouseID { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
/// <summary>
/// If set to 1, API also returns the cost. 
/// </summary>
public int? GetCost { get; set; }
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

#region GetIssuedCoupons Settings

public class GetIssuedCouponsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getIssuedCoupons";
/// <summary>
/// Unique identifier of the coupon. 
/// </summary>
public int? UniqueIdentifier { get; set; }
/// <summary>
/// Filter coupons by status: ACTIVE, REDEEMED, EXPIRED. 
/// </summary>
public string Status { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? IssuedTimestampFrom { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? IssuedTimestampTo { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? RedeemedTimestampFrom { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? RedeemedTimestampTo { get; set; }
public int? IssuedCustomerID { get; set; }
/// <summary>
/// Comma-separated list of customer IDs. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> IssuedCustomerIDs { get; set; }
public int? RedeemedCustomerID { get; set; }
/// <summary>
/// Comma-separated list of customer IDs. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> RedeemedCustomerIDs { get; set; }
/// <summary>
/// Comma-separated list of coupon rule IDs (see getCoupons). 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CouponIDs { get; set; }
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

#region GetLocationsInWarehouse Settings

public class GetLocationsInWarehouseSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getLocationsInWarehouse";
/// <summary>
/// Retrieve multiple locations, IDs separated by commas. Eg. "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> LocationInWarehouseIDs { get; set; }
/// <summary>
/// Look up a location by its exact name. 
/// </summary>
public string Name { get; set; }
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

#region GetPointOfSaleStatuses Settings

public class GetPointOfSaleStatusesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPointOfSaleStatuses";
/// <summary>
/// Multiple register IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PointOfSaleIDs { get; set; }
/// <summary>
/// Multiple Warehouse IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> WarehouseIDs { get; set; }
}

#endregion

#region GetPrepaymentPercentages Settings

public class GetPrepaymentPercentagesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPrepaymentPercentages";
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetProductsInPriceList Settings

public class GetProductsInPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductsInPriceList";
public int? PriceListID { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 1000. 
/// </summary>
public int? RecordsOnPage { get; set; }
}

#endregion

#region GetProductsInSupplierPriceList Settings

public class GetProductsInSupplierPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductsInSupplierPriceList";
public int? SupplierPriceListID { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Number of records API should return. 
/// </summary>
public int? RecordsOnPage { get; set; }
}

#endregion

#region GetProductExtraField1Values Settings

public class GetProductExtraField1ValuesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductExtraField1Values";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 100. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Retrieve items that have been added or changed since the specified time. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetProductExtraField2Values Settings

public class GetProductExtraField2ValuesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductExtraField2Values";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 100. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Retrieve items that have been added or changed since the specified time. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetProductExtraField3Values Settings

public class GetProductExtraField3ValuesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductExtraField3Values";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 100. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Retrieve items that have been added or changed since the specified time. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetProductExtraField4Values Settings

public class GetProductExtraField4ValuesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductExtraField4Values";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 100. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
/// <summary>
/// Retrieve items that have been added or changed since the specified time. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetProductFiles Settings

public class GetProductFilesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductFiles";
/// <summary>
/// Retrieve one specific file by ID. 
/// </summary>
public int? ProductFileID { get; set; }
/// <summary>
/// Retrieve all files associated with a product. 
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

#region GetProductPackageTypes Settings

public class GetProductPackageTypesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductPackageTypes";
/// <summary>
/// Retrieve only items that have been added or changed after the specified time. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
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

#region GetProductPricesInPriceLists Settings

public class GetProductPricesInPriceListsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getProductPricesInPriceLists";
public int? ProductID { get; set; }
/// <summary>
/// Multiple product IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Specify active = 0 to retrieve net sales prices in all price lists. Specify active = 1 to retrieve net sales prices in active price lists. By default 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Get only prices that have been added or modified since the specified timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetParameters Settings

public class GetParametersSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getParameters";
/// <summary>
/// Retrieve one specific parameter. 
/// </summary>
public int? ParameterID { get; set; }
/// <summary>
/// Retrieve all parameters in a specific group. 
/// </summary>
public int? ParameterGroupID { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetPurchaseReport Settings

public class GetPurchaseReportSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPurchaseReport";
/// <summary>
/// Report type. Possible values are "PURCHASE_BY_PRODUCT", "PURCHASE_BY_PRODUCT_GROUP", "PURCHASE_BY_BRAND", "PURCHASE_BY_SUPPLIER", "PURCHASE_BY_SUPPLIER_GROUP", "PURCHASE_BY_INVOICE", "PURCHASE_BY_INVOICE_ROWS". The last option returns all purchase invoice rows, all others aggregate the data by some parameter. 
/// </summary>
public string ReportType { get; set; }
/// <summary>
/// Date range filter. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateStart { get; set; }
/// <summary>
/// Date range filter. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateEnd { get; set; }
/// <summary>
/// Currency code: EUR, USD.
/// Setting this parameter will return a report where all sums have been re-calculated into specified currency. In other words, this is NOT a filter (for retrieving EUR, USD, etc. purchase invoices separately). In almost all cases, you will want the report in your account default currency, so it is recommended to omit this parameter.
/// The specified currency must be defined in Erply. If omitted, or an unknown currency code is provided, API uses your default currency. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Filter purchase invoices by warehouse (store, location). 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Filter the report down to one specific product. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Filter purchased items by product type. Possible values are "ALL" (all products), "STOCK" (stock products), "NON_STOCK" (non-stock products). By default "ALL". 
/// </summary>
public string ProductType { get; set; }
/// <summary>
/// Filter purchased items by product group. (Items in subgroups are also included.) 
/// </summary>
public int? ProductGroupID { get; set; }
/// <summary>
/// Filter purchased items by product category. 
/// </summary>
public int? CategoryID { get; set; }
/// <summary>
/// Filter purchased items by product priority group. 
/// </summary>
public int? PriorityGroupID { get; set; }
/// <summary>
/// Filter purchase invoices by supplier. 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Filter purchased items by brand. 
/// </summary>
public int? BrandID { get; set; }
/// <summary>
/// Set to 1 if you want to include purchased services. By default, the report will only include products.
/// To further filter down the report only to items that go into inventory (ie. to exclude non-stock-products, too), set filter productType = "STOCK". 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IncludeServices { get; set; }
/// <summary>
/// This setting only makes a difference if you have enabled document types "Purchase invoice-waybill" and "Purchase waybill".
/// Setting getAccountsPayableReport = 1 will return a report of payable documents (purchase invoice-waybills and purchase invoices). Leaving it to default value will produce a report of documents that change inventory (purchase invoice-waybills and purchase waybills). If you do not have these extra fields, changing the flag will not make any difference. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetAccountsPayableReport { get; set; }
}

#endregion

#region GetReasonCodes Settings

public class GetReasonCodesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getReasonCodes";
/// <summary>
/// Possible values: "WRITEOFF" - Inventory Write-off, "RETURN" - Return, "DISCOUNT" - Discount, "REGISTRATION" - Inventory registration, "EOD_VARIANCE" - End-of-Day variance, "TAX_EXEMPTION" - Tax exemption, "CASH_IN" - Cash In, "CASH_OUT" - Cash Out, "PROMOTION" - Promotion. 
/// </summary>
public string Purpose { get; set; }
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

#region GetReceiptPrints Settings

public class GetReceiptPrintsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getReceiptPrints";
/// <summary>
/// Specify the beginning of the time range. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? StartTimestamp { get; set; }
/// <summary>
/// Specify the end of the time range. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? EndTimestamp { get; set; }
/// <summary>
/// Optionally, retrieve printings from one specific register only. If omitted, printings from all registers are returned. 
/// </summary>
public int? PointOfSaleID { get; set; }
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

#region GetRedeemedCoupons Settings

public class GetRedeemedCouponsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getRedeemedCoupons";
/// <summary>
/// Unique identifier of the coupon 
/// </summary>
public int? UniqueIdentifier { get; set; }
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

#region GetRegisterTotalSalesOverTime Settings

public class GetRegisterTotalSalesOverTimeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getRegisterTotalSalesOverTime";
/// <summary>
/// Register ID. 
/// </summary>
public int? PointOfSaleID { get; set; }
}

#endregion

#region GetReservedStock Settings

public class GetReservedStockSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getReservedStock";
public int? WarehouseID { get; set; }
/// <summary>
/// Retrieve one specific product. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Retrieve specific products. Multiple product IDs, separated by commas, such as: 1,2,3,4,5 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Retrieve products in this specific product group. (See getProductGroups.) 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Retrieve products in this product group, or in any of its sub-groups, sub-subgroups etc. 
/// </summary>
public int? GroupIDWithSubgroups { get; set; }
/// <summary>
/// Retrieve products of this supplier. (See getSuppliers.) 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Retrieve products of this brand. (See getBrands.) 
/// </summary>
public int? BrandID { get; set; }
/// <summary>
/// Retrieve products in this priority group. (See getProductPriorityGroups.) 
/// </summary>
public int? PriorityGroupID { get; set; }
/// <summary>
/// Retrieve products in this specific category. (See getProductCategories.) 
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
/// Filter products by status: ACTIVE, NO_LONGER_ORDERED, NOT_FOR_SALE, ACTIVE_AND_NOT_FOR_SALE, ARCHIVED, or ALL_EXCEPT_ARCHIVED.
/// The last one returns all non-archived items (ie. items that are active, not for sale or no longer ordered).
/// IF you are building a Stock Replenishment Report, ACTIVE_AND_NOT_FOR_SALE is the recommended option. It returns all orderable items, skipping archived products and those marked as "not ordered any more". 
/// </summary>
public string Status { get; set; }
}

#endregion

#region GetRoundedSales Settings

public class GetRoundedSalesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getRoundedSales";
/// <summary>
/// Date range filter. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
/// <summary>
/// Date range filter. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateTo { get; set; }
/// <summary>
/// Filter by warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Filter by point of sale ID. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 500. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
}

#endregion

#region GetSalesDocumentActualReportsHTML Settings

public class GetSalesDocumentActualReportsHTMLSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSalesDocumentActualReportsHTML";
/// <summary>
/// Invoice ID.
/// If you want to create a new invoice and also retrieve its printout with a single bulk request, set this field to a special value: "CURRENT_INVOICE_ID".
/// </summary>
public int? DocumentID { get; set; }
/// <summary>
/// Printout template ID.
/// You can look up template ID from back office, from the drop-down list of templates.
/// </summary>
public int? TemplateID { get; set; }
/// <summary>
/// Printout data language.
/// If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetSalesDocumentActualReportsDataset Settings

public class GetSalesDocumentActualReportsDatasetSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSalesDocumentActualReportsDataset";
/// <summary>
/// Invoice ID.
/// </summary>
public int? SalesDocumentID { get; set; }
/// <summary>
/// Data language.
/// If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetSalesTotalsByEmployeeAndDay Settings

public class GetSalesTotalsByEmployeeAndDaySettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSalesTotalsByEmployeeAndDay";
/// <summary>
/// Number of employees to retrieve. By default, API returns 50 employees (top employees by total sales during the selected period).
/// 50 is also the largest number that can be requested, but this limit can be changed with a configuration parameter.
/// </summary>
public int? NumberOfGroups { get; set; }
/// <summary>
/// Number of days. Specifying numberOfPeriods = 5 will return data for the last 5 days, including today.
/// By default, API returns last 30 days. 30 is also the largest number that can be requested, but this limit can be changed with a configuration parameter.
/// </summary>
public int? NumberOfPeriods { get; set; }
/// <summary>
/// Location ID 
/// </summary>
public int? WarehouseID { get; set; }
}

#endregion

#region GetSalesTotalsByEmployeeAndMonth Settings

public class GetSalesTotalsByEmployeeAndMonthSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSalesTotalsByEmployeeAndMonth";
/// <summary>
/// Number of employees to retrieve. By default, API returns 50 employees (top employees by total sales during the selected period).
/// 50 is also the largest number that can be requested, but this limit can be changed with a configuration parameter.
/// </summary>
public int? NumberOfGroups { get; set; }
/// <summary>
/// Number of months. Specifying numberOfPeriods = 3 will return data for the last 3 days, including current month.
/// By default, API returns last 6 months. 6 is also the largest number that can be requested, but this limit can be changed with a configuration parameter.
/// </summary>
public int? NumberOfPeriods { get; set; }
/// <summary>
/// Location ID 
/// </summary>
public int? WarehouseID { get; set; }
}

#endregion

#region GetSalesTotalsByWarehouseAndDay Settings

public class GetSalesTotalsByWarehouseAndDaySettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSalesTotalsByWarehouseAndDay";
/// <summary>
/// Number of warehouses (locations) to retrieve. By default, API returns 50 locations (top locations by total sales during the selected period).
/// 50 is also the largest number that can be requested, but this limit can be changed with a configuration parameter.
/// </summary>
public int? NumberOfGroups { get; set; }
/// <summary>
/// Number of days. Specifying numberOfPeriods = 5 will return data for the last 5 days, including today.
/// By default, API returns last 30 days. 30 is also the largest number that can be requested, but this limit can be changed with a configuration parameter.
/// </summary>
public int? NumberOfPeriods { get; set; }
}

#endregion

#region GetSalesTotalsByWarehouseAndMonth Settings

public class GetSalesTotalsByWarehouseAndMonthSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSalesTotalsByWarehouseAndMonth";
/// <summary>
/// Number of warehouses (locations) to retrieve. By default, API returns 50 locations (top locations by total sales during the selected period).
/// 50 is also the largest number that can be requested, but this limit can be changed with a configuration parameter.
/// </summary>
public int? NumberOfGroups { get; set; }
/// <summary>
/// Number of months. Specifying numberOfPeriods = 3 will return data for the last 3 days, including current month.
/// By default, API returns last 6 months. 6 is also the largest number that can be requested, but this limit can be changed with a configuration parameter.
/// </summary>
public int? NumberOfPeriods { get; set; }
}

#endregion

#region GetSchedule Settings

public class GetScheduleSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSchedule";
/// <summary>
/// beginning of the date interval for which you want to retrieve schedule 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateFrom { get; set; }
/// <summary>
/// end of the date interval for which you want to retrieve schedule 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateUntil { get; set; }
/// <summary>
/// Location, salon ID 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Employee ID. If not set, all employees in this location will be returned. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// If set to 1, API will return a list of times when employee is NOT at work. If set to 0 or unset, API will return a list of times when employee IS at work.  
/// </summary>
public string ShowTimeOff { get; set; }
/// <summary>
/// If you need to lay out a calendar visually and display the times when employee is NOT at work, you might want to only display those intervals that fall within the time period depicted in your calendar.
/// For example, if your calendar is laid out from 8am to 9pm, set calendarStartTime to 8:00:00 and calendarEndTime to 21:00:00. If on that day, employee will be working from 10am to 6pm and you want to retrieve times off, API will return two records: 8am-10am and 6pm-9pm. 
/// </summary>
[JsonConverter(typeof(ISOTimeHHmmssConverter))]
public TimeSpan? CalendarStartTime
calendarEndTime { get; set; }
}

#endregion

#region GetTimeSlots Settings

public class GetTimeSlotsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getTimeSlots";
/// <summary>
/// Location, salon ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Earliest possible start time for the time slots.
/// If unspecified, current time is used.
/// Must be local time (in that particular location's time zone). 
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? StartTime { get; set; }
/// <summary>
/// Latest possible end time for the time slots.
/// If unspecified, default value will be startTime + 2 weeks.
/// If no suitable time slots (or sets of time slots) are found, API call will return no results and you will need to re-run it with another endTime, or adjust the set of services requested.
/// Must be local time (in that particular location's time zone). 
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? EndTime { get; set; }
/// <summary>
/// Maximum number of options offered by the API. By default 5 
/// </summary>
public int? MaxOptions { get; set; }
/// <summary>
/// Set to 1 if it is important that the services would be performed in the exact same order and may not be reordered. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PreserveOrder { get; set; }
/// <summary>
/// If set to 1, returns only timeslots available for employees who have clocked in for today. (If not set, then API only considers employees' schedule).
/// Note that it only makes sense to use this option if you are asking for timeslots available today! If you ask for a longer period, then tomorrow's timeslots etc. are also constrained only to these employees who are clocked in at the present moment. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ClockedInEmployeesOnly { get; set; }
/// <summary>
/// If set to 1, API returns entries for all matching employees (clocked-in employees if clockedInEmployees = 1, otherwise all employees providing that particular service, and scheduled to be working on given day in selected salon.) Even if an employee is already occupied for the whole day, API appends an extra entry at the end of the resultset, with that employee's ID, but startTime and endTime set to "".
/// This setting makes sense if you are asking only for today's timeslots. May not be compatible with multi-appointments. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ReturnAllEmployees { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? WalkInEmployeesOnly { get; set; }
/// <summary>
/// By default, API returns only one result if multiple emplyees are ready to provide service in the exact same timeslot. (API picks one employee, by its own selection rules, and returns it.) If this option is set to 1, yo will get duplicate timeslots, too. If there are 15 stylists ready to provide haircuts at 9am, then using this setting API returns 15 timeslots (one for each employee), for each hour. The timeslots are ordered by API's own ordering rules. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetDuplicateTimeslots { get; set; }
/// <summary>
/// Indicate how many customers will be arriving (of course there might be just one customer) and which services (products) they want appointments for.
/// All employeeID's are optional parameters (use them only if the customer already knows which stylist they want), but productID is required. So in the simplest case — one customer wants one service — you must provide at least customer1productID1.
/// If that customer wants to book multiple consecutive appointments (eg. hair coloring, haircut etc.), use parameter customer1productID2, customer1productID3 and so on.
/// If a group of customers wants to arrive together and have appointments at the same time, use parameters customer2productID1 for the second customer, customer3productID1 for the third and so on. 
/// </summary>
public int? Customer#employeeID#
customer#productID# { get; set; }
}

#endregion

#region GetUnfinishedSales Settings

public class GetUnfinishedSalesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getUnfinishedSales";
/// <summary>
/// Specify the beginning of the time range. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? StartTimestamp { get; set; }
/// <summary>
/// Specify the end of the time range. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? EndTimestamp { get; set; }
/// <summary>
/// Optionally retrieve information about one specific register only. When omitted, records from all registers are returned. 
/// </summary>
public int? PointOfSaleID { get; set; }
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

#region GetUsedRewardPointRecords Settings

public class GetUsedRewardPointRecordsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getUsedRewardPointRecords";
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Comma-separated list of customer IDs. Retrieve transactions associated with multiple customers. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CustomerIDs { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTimeFrom { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTimeTo { get; set; }
}

#endregion

#region GetSellableProducts Settings

public class GetSellableProductsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSellableProducts";
public int? WarehouseID { get; set; }
}

#endregion

#region GetSubsidyTypes Settings

public class GetSubsidyTypesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSubsidyTypes";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
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

#region GetStoreRegions Settings

public class GetStoreRegionsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getStoreRegions";
/// <summary>
/// Set to 1 if you want API to return a list of each region's price lists. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetPriceLists { get; set; }
/// <summary>
/// Set to 1 if you want API to return a list of each region's customer group-specific price lists. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetCustomerGroupPriceLists { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
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

#region GetStoreRegionsAssociatedWithPriceList Settings

public class GetStoreRegionsAssociatedWithPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getStoreRegionsAssociatedWithPriceList";
/// <summary>
/// Price list ID. 
/// </summary>
public int? PriceListID { get; set; }
}

#endregion

#region GetSupplierGroups Settings

public class GetSupplierGroupsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSupplierGroups";
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetSupplierPriceLists Settings

public class GetSupplierPriceListsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSupplierPriceLists";
/// <summary>
/// Price List ID 
/// </summary>
public int? SupplierPriceListID { get; set; }
/// <summary>
/// Supplier ID 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Get price lists that have been modified since the specified timestamp. Useful for synchronizing data. Price lists will be returned with their full contents. 
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

#region GetSuppliers Settings

public class GetSuppliersSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getSuppliers";
/// <summary>
/// Supplier ID 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Search from supplier name, e-mail or phone. 
/// </summary>
public string SearchName { get; set; }
/// <summary>
/// Search from person full name. 
/// </summary>
public string SearchPersonFullName { get; set; }
/// <summary>
/// Search from person first name. 
/// </summary>
public string SearchPersonFirstName { get; set; }
/// <summary>
/// Search from person last name. 
/// </summary>
public string SearchPersonLastName { get; set; }
/// <summary>
/// Search from supplier VAT no 
/// </summary>
public string SearchVATNo { get; set; }
/// <summary>
/// Name of attribute to search from. Both "searchAttributeName" and "searchAttributeValue" have to be specified. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeName { get; set; }
/// <summary>
/// Attribute value to search for. Error 1030 will be returned if value is an array. 
/// </summary>
public string SearchAttributeValue { get; set; }
/// <summary>
/// Supplier manager. See getEmployees. 
/// </summary>
public int? SupplierManagerID { get; set; }
/// <summary>
/// Supplier group ID. See getSupplierGroups. 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// SUPPLIERS, CONTACTS or ALL.
/// By default ALL.
/// ERPLY makes a distiction between 1) companies who are suppliers in their own right, and 2) persons who are marked as contact persons of some other supplier. Option "SUPPLIERS" returns only the first ones, "CONTACTS" returns only the second ones and "ALL" returns both. 
/// </summary>
public string Mode { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
public string OrderBy { get; set; }
public string OrderByDir { get; set; }
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

#region GetTaxExemptions Settings

public class GetTaxExemptionsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getTaxExemptions";
/// <summary>
/// Date range filter. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateStart { get; set; }
/// <summary>
/// Date range filter. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DateEnd { get; set; }
/// <summary>
/// Filter by warehouse ID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Number of records API should return. By default 20, at most 500. 
/// </summary>
public int? RecordsOnPage { get; set; }
/// <summary>
/// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
/// </summary>
public int? PageNo { get; set; }
}

#endregion

#region GetTaxOffices Settings

public class GetTaxOfficesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getTaxOffices";
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetUserGroups Settings

public class GetUserGroupsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getUserGroups";
/// <summary>
/// Retrieve one specific user group. 
/// </summary>
public int? UserGroupID { get; set; }
/// <summary>
/// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ChangedSince { get; set; }
}

#endregion

#region GetUserOperationsLog Settings

public class GetUserOperationsLogSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getUserOperationsLog";
/// <summary>
/// One of the following: "customers", "employees", "suppliers", "addresses", "currencies", "customerGroups", "emailAccounts", "giftCards", "pointsOfSale", "priceLists", "productGroups", "products", "services", "supplierGroups", "users", "userGroups", "warehouses", "events", "purchaseDocuments", "salesDocuments", "pricelistProducts", "pricelistServices", "pricelistDiscounts", "payments", "inventoryRegistrations", "inventoryTransfers", "inventoryWriteOffs" 
/// </summary>
public string TableName { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? AddedFrom { get; set; }
/// <summary>
/// By default 'asc'  
/// </summary>
public string OrderByDir { get; set; }
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

#region GetUserRights Settings

public class GetUserRightsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getUserRights";
/// <summary>
/// Optional user ID to retrive one specific user data. Either userID or getCurrentUser can be set, but not both at the same time. 
/// </summary>
public int? UserID { get; set; }
/// <summary>
/// Set to 1 to get the rights of the current user. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetCurrentUser { get; set; }
}

#endregion

#region GetCompanyTypes Settings

public class GetCompanyTypesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getCompanyTypes";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetPersonTitles Settings

public class GetPersonTitlesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getPersonTitles";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region GetJobTitles Settings

public class GetJobTitlesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "getJobTitles";
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
}

#endregion

#region IncrementStocktakingReading Settings

public class IncrementStocktakingReadingSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "incrementStocktakingReading";
/// <summary>
/// deviceID and recordID can to be specified both or omitted both. 
/// </summary>
public int? DeviceID { get; set; }
public int? RecordID { get; set; }
/// <summary>
/// Stocktaking ID. 
/// </summary>
public int? StocktakingID { get; set; }
/// <summary>
/// Product ID. 
/// </summary>
public int? ProductID# { get; set; }
public float? Amount# { get; set; }
}

#endregion

#region LogProcessingOfCustomerData Settings

public class LogProcessingOfCustomerDataSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "logProcessingOfCustomerData";
/// <summary>
/// Employee doing the processing. If omitted, Erply assumes processing was done by the user who sent the API call. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Multiple customer IDs, separated by commas, such as: 1,2,3,4,5. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CustomerIDs { get; set; }
/// <summary>
/// Data processing type, can be "create", "read", "update" or "delete". 
/// </summary>
public string ActivityType { get; set; }
/// <summary>
/// Data processing reason or purpose. Maximum 255 characters. 
/// </summary>
public string Description { get; set; }
/// <summary>
/// A comma-separated list of fields that were affected by processing, or were used in processing. Possible field names are:
/// name
/// phone
/// mobilePhone
/// fax
/// email
/// address
/// nationalIdentificationNumber
/// dateOfBirth
/// gender
/// bankAccount
/// employer
/// skype
/// payer
/// website
/// licencePlate (referring to the licence plate number of a vehicle)
/// VIN (referring to the VIN of a vehicle)
/// all
/// List all the fields that were used in processing — for example, "name,phone,address". If listing a specific set of fields is not applicable (for example when deleting a customer record), set fields="all".
/// </summary>
public string Fields { get; set; }
/// <summary>
/// Set this field if you have a partner key. The partner key helps to clarify the log entry, by indicating which application did the processing. 
/// </summary>
public string PartnerKey { get; set; }
}

#endregion

#region RedeemIssuedCoupon Settings

public class RedeemIssuedCouponSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "redeemIssuedCoupon";
/// <summary>
/// A unique identifier for this printed coupon. 
/// </summary>
public int? UniqueIdentifier { get; set; }
/// <summary>
/// Invoice the coupon was redeemed with.
/// If you want to save an invoice and redeem an associated coupon together in one bulk request, set this field to a special value: "CURRENT_INVOICE_ID". Normally, creating two records where one references the other cannot be done within one bulk request; you would have to retrieve one record's ID before you can create the other. This is a special workaround for savePayment, saveGiftCard, saveIssuedCoupon, redeemIssuedCoupon, and subtractCustomerRewardPoints.
/// Note that if saving the invoice results in an error, the payments, coupons etc. will be created and coupons redeemed nevertheless, but without a reference to any invoice. For better error checking you may still want to do saveSalesDocument as a separate request. 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Customer who redeemed the coupon 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Store or location where the coupon was accepted 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Register where the coupon was accepted 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Salesperson who accepted the coupon 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Accept time 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
}

#endregion

#region RegisterReceiptPrint Settings

public class RegisterReceiptPrintSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "registerReceiptPrint";
/// <summary>
/// ID of the sales document being printed.
/// Depending on POS configuration (in the Swedish example), or depending on what you choose to store in case of a custom implementation, this can be a sales document of any type (an invoice-waybill, or even a sales order), not specifically a receipt. 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Register at which the sales document was printed. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Time of printing. If you issue this API call right before or after printing, omit this parameter and let API set it automatically. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
/// <summary>
/// Indicate if this is a reprint. (A print is a "reprint" if it is produced later — regardless of whether the customer already got a paper receipt at transaction time or not.) 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsReprint { get; set; }
}

#endregion

#region RemoveAssortmentProducts Settings

public class RemoveAssortmentProductsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "removeAssortmentProducts";
/// <summary>
/// Comma-separated list of product IDs. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDs { get; set; }
/// <summary>
/// Assortment ID. 
/// </summary>
public int? AssortmentID { get; set; }
}

#endregion

#region RemoveItemsFromMatrixDimension Settings

public class RemoveItemsFromMatrixDimensionSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "removeItemsFromMatrixDimension";
/// <summary>
/// Dimension ID. 
/// </summary>
public int? DimensionID { get; set; }
/// <summary>
/// Variation ID. 
/// </summary>
public int? VariationID# { get; set; }
}

#endregion

#region RemoveItemsFromPriceList Settings

public class RemoveItemsFromPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "removeItemsFromPriceList";
/// <summary>
/// Price list ID. 
/// </summary>
public int? PricelistID { get; set; }
/// <summary>
/// 'PRODUCT', 'PRODGROUP', or 'SERVICE'. 
/// </summary>
public string Type# { get; set; }
/// <summary>
/// Product / product group ID. 
/// </summary>
public int? Id# { get; set; }
/// <summary>
/// Available only if Quantity Discounts module is enabled on your account. (The quantity threshold from which the special price will apply.) 
/// </summary>
public int? Amount# { get; set; }
}

#endregion

#region RemoveItemsFromSupplierPriceList Settings

public class RemoveItemsFromSupplierPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "removeItemsFromSupplierPriceList";
/// <summary>
/// Price list ID. 
/// </summary>
public int? SupplierPriceListID { get; set; }
/// <summary>
/// Product ID. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// Available only if Quantity Discounts module is enabled on your account. (The quantity threshold from which the special price will apply.) 
/// </summary>
public int? Amount# { get; set; }
}

#endregion

#region RemoveStoreRegionPriceList Settings

public class RemoveStoreRegionPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "removeStoreRegionPriceList";
/// <summary>
/// Store region ID. 
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// A comma-separated list of price list IDs to be removed from this store region. (The price lists themselves will remain in the system, and can be associated with other regions or locations.) 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PriceListIDs { get; set; }
}

#endregion

#region RemoveStoreRegionCustomerGroupPriceList Settings

public class RemoveStoreRegionCustomerGroupPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "removeStoreRegionCustomerGroupPriceList";
/// <summary>
/// Store region ID. 
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Customer group ID. 
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// A comma-separated list of price list IDs to be disassociated from this combination of store region and customer group. (The price lists themselves will remain in the system, and can be associated with other regions or locations.) 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> PriceListIDs { get; set; }
}

#endregion

#region SaveAddressType Settings

public class SaveAddressTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveAddressType";
/// <summary>
/// Address type name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// ID of address type 
/// </summary>
public int? AddressTypeID { get; set; }
/// <summary>
/// Indicates whether this is a type of actively used addresses, or a type of archived/old addresses. Address which has a type where activelyUsed=0 cannot be used as a customer's shipping address on invoice. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ActivelyUsed { get; set; }
}

#endregion

#region SaveAppliance Settings

public class SaveApplianceSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveAppliance";
/// <summary>
/// Appliance ID. 
/// </summary>
public int? ApplianceID { get; set; }
/// <summary>
/// Name of appliance. Appliance-specific attribute. Available only if appliance module is enabled on your account. 
/// </summary>
public string ApplianceName { get; set; }
/// <summary>
/// Product ID. Appliance-specific attribute. Available only if appliance module is enabled on your account. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Invoice ID. 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Sales date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? SalesDate { get; set; }
/// <summary>
/// Start date of warranty. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDateOfWarranty { get; set; }
/// <summary>
/// End date of warranty. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDateOfWarranty { get; set; }
/// <summary>
/// Serial number. 
/// </summary>
public string SerialNumber { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
public string VehicleVIN { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
public string VehicleMake { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
public string VehicleModel { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
public string VehicleVersion { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
public string VehicleYearOfManufacture { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
public int? VehicleMileage { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
public string VehicleUser { get; set; }
/// <summary>
/// Additional information. 
/// </summary>
public string Notes { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveAssignment Settings

public class SaveAssignmentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveAssignment";
/// <summary>
/// Assignment ID. 
/// </summary>
public int? AssignmentID { get; set; }
public int? GroupID { get; set; }
public int? WarehouseID { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTime { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ReceivedUnixTime { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Completed { get; set; }
/// <summary>
/// Salesperson who booked time. 
/// </summary>
public int? BookerEmployeeID { get; set; }
/// <summary>
/// Salesperson who received the appliance. 
/// </summary>
public int? ReceiverEmployeeID { get; set; }
/// <summary>
/// Salesperson who returned the appliance. 
/// </summary>
public int? ReturnedByEmployeeID { get; set; }
/// <summary>
/// ID of appliance. 
/// </summary>
public int? ApplianceID { get; set; }
/// <summary>
/// ID of vehicle. 
/// </summary>
public int? VehicleID { get; set; }
public string CommentsOnWorkDone { get; set; }
public string CommentsOnWorkLeftUndone { get; set; }
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Contact person ID. 
/// </summary>
public int? ContactID { get; set; }
/// <summary>
/// Contact person name. 
/// </summary>
public string ContactPerson { get; set; }
/// <summary>
/// Contact phone. 
/// </summary>
public string ContactPersonPhone { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? VehicleHasAntiTheftBolts { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TestDrive { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? AddWasherFluid { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ReplaceWindshieldWipers { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IncludedServiceBook { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CheckExtinguisher { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ReplaceAirFilter { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CheckBodyWarranty { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if vehicle module is enabled on your account. 
/// </summary>
public int? VehicleMileage { get; set; }
public string CustomerComment# { get; set; }
/// <summary>
/// ID of the product. Either productID or serviceID can be set, but not both at the same time. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// ID of the service. 
/// </summary>
public int? ServiceID# { get; set; }
/// <summary>
/// name of the item (use only if you want to override the default product/service name) 
/// </summary>
public string ItemName# { get; set; }
public float? Amount# { get; set; }
public float? Price# { get; set; }
public float? Discount# { get; set; }
public int? FirstEmployeeID# { get; set; }
public int? SecondEmployeeID# { get; set; }
public int? ThirdEmployeeID# { get; set; }
public int? FirstEmployeeTime# { get; set; }
public int? SecondEmployeeTime# { get; set; }
public int? ThirdEmployeeTime# { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveAssignmentGroup Settings

public class SaveAssignmentGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveAssignmentGroup";
/// <summary>
/// Group ID. 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Group name. 
/// </summary>
public string Name { get; set; }
}

#endregion

#region SaveAssortment Settings

public class SaveAssortmentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveAssortment";
/// <summary>
/// Assortment ID. Specify assortment ID to edit an existing record. 
/// </summary>
public int? AssortmentID { get; set; }
/// <summary>
/// Assortment name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// Assortment code. ERPLY itself does not use assortment code for any purpose, but it may be useful for integrations. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveBillingStatement Settings

public class SaveBillingStatementSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveBillingStatement";
/// <summary>
/// ID of billing statement. If this parameter is present, then the specified statement is updated. 
/// </summary>
public int? BillingStatementID { get; set; }
/// <summary>
/// Customer ID.(Not required if updating an existing statement.) 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer address ID. 
/// </summary>
public int? CustomerAddressID { get; set; }
/// <summary>
/// Payer ID. 
/// </summary>
public int? PayerID { get; set; }
/// <summary>
/// Payer address ID. 
/// </summary>
public int? PayerAddressID { get; set; }
/// <summary>
/// ID of the employee, who is set as the creator of the billing statement. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Start date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDate { get; set; }
/// <summary>
/// End date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDate { get; set; }
/// <summary>
/// ID of the service. 
/// </summary>
public int? ServiceID { get; set; }
/// <summary>
/// ID of the product. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Customer special price. 
/// </summary>
public float? CustomerSpecialPrice { get; set; }
/// <summary>
/// Payment period. 
/// </summary>
public int? PaymentDays { get; set; }
/// <summary>
/// ID of VAT (tax) rate. To get the list of rates, use getVatRates.(Not required if updating an existing statement.) 
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Currency code: EUR, USD. Currency must be present in the system.
/// If omitted, default currency will be used. 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Period of billing statement. Possible values: "MONTH", "QUARTER", "HALFYEAR", "YEAR", "3MONTHS", "4MONTHS".(Not required if updating an existing statement.) 
/// </summary>
public string BillingStatementPeriod { get; set; }
/// <summary>
/// Time of billing statement. Possible values: "WHEN_PERIOD_STARTS", "WHEN_PERIOD_ENDS", ""BASED_ON_METERED_READINGS".(Not required if updating an existing statement.) 
/// </summary>
public string BillingStatementTime { get; set; }
/// <summary>
/// 0 or 1, by default 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// 0 or 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SendByEmail { get; set; }
/// <summary>
/// 0 or 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? MakeSeparateInvoice { get; set; }
/// <summary>
/// Service name as displayed on invoices. 
/// </summary>
public string ServiceNameOnInvoices { get; set; }
/// <summary>
/// Notes. 
/// </summary>
public string Notes { get; set; }
/// <summary>
/// Additional text printed on invoices. 
/// </summary>
public string AdditionalInvoiceNotes { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveBillingStatementReading Settings

public class SaveBillingStatementReadingSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveBillingStatementReading";
/// <summary>
/// ID of billing statement. 
/// </summary>
public int? BillingStatementID { get; set; }
/// <summary>
/// Meter reading. 
/// </summary>
public float? Reading { get; set; }
/// <summary>
/// If omitted, date of request will be used. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date { get; set; }
}

#endregion

#region SaveBin Settings

public class SaveBinSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveBin";
/// <summary>
/// Leave this field empty when creating a new bin. 
/// </summary>
public int? BinID { get; set; }
/// <summary>
/// Warehouse ID. For new bins, this field is required. For existing bins, warehouse cannot be changed. If you edit an existing bin and pass the "warehouseID" parameter, it will be ignored. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Bin code. For new bins, this field is required. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Possible values: "ACTIVE", "ARCHIVED", by default "ACTIVE". 
/// </summary>
public string Status { get; set; }
/// <summary>
/// 0 or 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Preferred { get; set; }
/// <summary>
/// A textual description; use it to indicate if this bin is only meant for storing a specific product or products. 
/// </summary>
public string AllowedProduct { get; set; }
/// <summary>
/// If the quantity in this bin falls below this value, the item should be reordered. (API client must itself establish a system what product is being referred here. This field could be used in conjunction with "allowedProduct".) 
/// </summary>
public float? ReplenishmentMinimum { get; set; }
/// <summary>
/// Maximum capacity of this bin. (API client must itself establish a system what product is being referred here. This field could be used in conjunction with "allowedProduct".) 
/// </summary>
public float? MaximumAmount { get; set; }
public int? Order { get; set; }
}

#endregion

#region SaveBinRecords Settings

public class SaveBinRecordsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveBinRecords";
/// <summary>
/// Leave this field empty when creating a new bin record. 
/// </summary>
public int? RecordID# { get; set; }
/// <summary>
/// Bin ID. For new bin records, this field is required. 
/// </summary>
public int? BinID# { get; set; }
/// <summary>
/// Product ID. For new bin records, this field is required. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// Amount. For new bin records, this field is required. 
/// </summary>
public float? Amount# { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp# { get; set; }
/// <summary>
/// Document ID. 
/// </summary>
public int? DocumentID# { get; set; }
/// <summary>
/// Document Type. Possible values:
/// SALES_DOCUMENT - Sales Document
/// PURCHASE_DOCUMENT - Purchase Document
/// INVENTORY_REGISTRATION - Inventory Registration
/// INVENTORY_WRITE_OFF - Inventory Write-Off
/// INVENTORY_TRANSFER - Inventory Transfer
/// </summary>
public string DocumentType# { get; set; }
/// <summary>
/// Creator (employee) ID. For new bin records, this field is required. 
/// </summary>
public int? CreatorID# { get; set; }
/// <summary>
/// Reason Code ID. 
/// </summary>
public int? ReasonCodeID# { get; set; }
}

#endregion

#region SaveBrand Settings

public class SaveBrandSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveBrand";
/// <summary>
/// Brand ID. 
/// </summary>
public int? BrandID { get; set; }
/// <summary>
/// Brand name. 
/// </summary>
public string Name { get; set; }
}

#endregion

#region SaveCampaign Settings

public class SaveCampaignSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCampaign";
/// <summary>
/// Leave this field empty when creating a new promotion. 
/// </summary>
public int? CampaignID { get; set; }
/// <summary>
/// Promotion start date. 
/// </summary>
public string StartDate { get; set; }
/// <summary>
/// Promotion end date. 
/// </summary>
public string EndDate { get; set; }
/// <summary>
/// Possible values: 0 or 1. Setting it to 0 disables a promotion. Default value is 1. Available only if Optionally Disable Promotions module is enabled on your account. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Enabled { get; set; }
/// <summary>
/// Promotion name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. To have multilingual names enabled, please contact our customer support. An error will be returned if you attempt to set a name in a specific language and the multilingual names are not enabled on your account. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// Describes the way promotion is applied. Possible values:
/// auto - Promotion is applied automatically to all customers, based on rules below. No coupons needed.
/// manual - Cashier selects the promotion manually. (Cashier must have relevant rights - getUserRights must return rightApplyPromotions = 1)
/// coupon - Promotion is applied when user hands in a printed coupon with a serial number.
/// Default value is "auto". 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Set this field if you want the promotion to be available only in a specific store.
/// Fields "warehouseID", "storeGroup" and "storeRegionIDs" are mutually exclusive: only one restriction can be set at a time, otherwise error code 1110 will be returned.
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Set this field if you want the promotion to be available only in a specific store group.
/// Fields "warehouseID", "storeGroup" and "storeRegionIDs" are mutually exclusive: only one restriction can be set at a time, otherwise error code 1110 will be returned.
/// "Store group" is a text field on location form.
/// </summary>
public string StoreGroup { get; set; }
/// <summary>
/// A comma-separated list of store region IDs.
/// Set this field if you want the promotion to be available only in selected store regions. To remove the restriction, set the field to an empty string.
/// Fields "warehouseID", "storeGroup" and "storeRegionIDs" are mutually exclusive: only one restriction can be set at a time, otherwise error code 1110 will be returned.
/// Using this field will return error code 1028 if "Store regions" and "Promotion regions" modules are not enabled on this account. If you supply a list containing non-numeric values, error 1016 will be returned.
/// To get a list of store regions, see getStoreRegions.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> StoreRegionIDs { get; set; }
/// <summary>
/// A comma-separated list of customer group IDs.
/// Set this field if you want the promotion to be available only for selected customer groups. To remove the restriction, set the field to an empty string.
/// Using this field will return error code 1028 if "Promotion regions" module is not enabled on this account. If you supply a list containing non-numeric values, error 1016 will be returned.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CustomerGroupIDs { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Subsidy must be a non-negative decimal. 
/// </summary>
public float? Subsidy { get; set; }
/// <summary>
/// DEPRECATED — subsidy is recommended instead. Available only if Price list row subsidy and other fields module is enabled on your account.
/// Subsidy must be a non-negative decimal. 
/// </summary>
public float? SubsidyValue { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account. 
/// </summary>
public int? SubsidyTypeID { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Page must be a non-negative integer. 
/// </summary>
public int? Page { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Position on page must be a non-negative integer. 
/// </summary>
public int? PositionOnPage { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.
/// Forecast units must be a non-negative integer. 
/// </summary>
public int? ForecastUnits { get; set; }
public float? PurchaseTotalValue { get; set; }
public int? PurchasedProductGroupID { get; set; }
public int? PurchasedProductCategoryID { get; set; }
/// <summary>
/// A comma-separated list of purchased products. 
/// </summary>
public string PurchasedProducts { get; set; }
/// <summary>
/// A comma-separated list of subsidy amounts (in euros/dollars) for each of the products specified above.
/// Subsidy is money paid by the head office to the store, to offset the store's loss of revenue, due to HQ-mandated discounts and promotions.
/// You can only use this field for promotions "Buy at least X pcs of product Y and get $ / % off each one". This is the promotion that can be defined by setting the fields "purchasedProducts", "purchasedAmount", and one of either "percentageOffMatchingItems" or "sumOffMatchingItems". Since this promotion gives discounts to the same items that customer is required to buy, the subsidies need to be associated with "purchasedProducts". These amounts of subsidy will be paid out when this promotion applies and one of the products listed above (in purchasedProducts) gets a promotional discount.
/// Attempting to set "purchasedProductSubsidies" for any other type of promotion will return error code 1132.
/// This comma-separated list must consist of non-negative decimals, and if you set this parameter, the list must be exactly of the same length as "purchasedProducts" (a corresponding subsidy amount for each product ID). For instance:
/// purchasedProducts=1,2,3,4
/// purchasedProductSubsidies=0,0.15,0.35,0
/// If the lists do not contain the same number of items, error code 1133 will be returned.
/// This field can be used only if "Price list row subsidy and other fields" module is enabled on your account.
/// </summary>
public int? PurchasedProductSubsidies { get; set; }
public int? PurchasedAmount { get; set; }
public int? RewardPoints { get; set; }
/// <summary>
/// Optional, the customer must buy a certain number of items with item price more or equal to this value, doesnt work with total value or reward points. Positive decimal or 0. 
/// </summary>
public float? PriceAtLeast { get; set; }
/// <summary>
/// Optional, the customer must buy a certain number of items with item price less or equal to this value, doesnt work with total value or reward points. Positive decimal or 0. 
/// </summary>
public float? PriceAtMost { get; set; }
/// <summary>
/// This promotion gives a percentage discount on the entire sale. 
/// </summary>
public float? PercentageOffEntirePurchase { get; set; }
/// <summary>
/// This flag applies to promotions "% off entire sale", so set it only together with percentageOffEntirePurchase, otherwise API will return error 1129.
/// Indicates that the promotion should not apply to items that have already received any discount from a price list, a manual discount by the cashier, or a discount from any preceding promotion (both item-level and invoice-level promotions).
/// By default 0.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ExcludeDiscountedFromPercentageOffEntirePurchase { get; set; }
/// <summary>
/// A further restriction for the "% off entire sale" promotion. IDs of products to which the discount percentage should not be applied.
/// A comma-separated list of product IDs.
/// </summary>
public string PercentageOffExcludedProducts { get; set; }
/// <summary>
/// A further restriction for the "% off entire sale" promotion. IDs of the only allowed products to which the discount percentage may be applied, at all. (All other products in the basket should be left unaffected by this promotion.)
/// A comma-separated list of product IDs.
/// </summary>
public string PercentageOffIncludedProducts { get; set; }
public float? SumOffEntirePurchase { get; set; }
/// <summary>
/// A comma-separated list of products. 
/// </summary>
public string SumOffExcludedProducts { get; set; }
/// <summary>
/// A comma-separated list of products. 
/// </summary>
public string SumOffIncludedProducts { get; set; }
public float? SpecialPrice { get; set; }
/// <summary>
/// In promotion "% or $ off of specific products", how many items should get the discount. Fulfilling the promotion conditions may entitle the customer to one discounted item (awardedAmount = 1), or at most N discounted items (awardedAmount > 1), or an unlimited number of items (awardedAmount = 0). The "unlimited" option may be used in promotions such as "First item costs $3, subsequent ones are $2 each". 
/// </summary>
public int? AwardedAmount { get; set; }
public int? AwardedProductGroupID { get; set; }
public int? AwardedProductCategoryID { get; set; }
/// <summary>
/// A comma-separated list of awarded products. 
/// </summary>
public string AwardedProducts { get; set; }
/// <summary>
/// A comma-separated list of subsidy amounts (in euros/dollars) for each of the awarded products specified above.
/// Subsidy is money paid to the store by the head office, to offset the store's loss of revenue, due to HQ-mandated discounts and promotions.
/// If you specify awardedProductSubsidies, these will be the amounts of subsidy that will be paid out when this promotion applies and one of the products listed above (in awardedProducts) gets a promotional discount.
/// This comma-separated list must consist of non-negative decimals, and if you set this parameter, the list must be exactly of the same length as "awardedProducts" (a corresponding subsidy amount for each product ID). For instance:
/// awardedProducts=1,2,3,4
/// awardedProductSubsidies=0,0.15,0.35,0
/// If the lists do not contain the same number of items, error code 1134 will be returned.
/// This field can be used only if "Price list row subsidy and other fields" module is enabled on your account.
/// </summary>
public int? AwardedProductSubsidies { get; set; }
/// <summary>
/// A comma-separated list of excluded products. 
/// </summary>
public string ExcludedProducts { get; set; }
/// <summary>
/// 0 or 1 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? LowestPriceItemIsAwarded { get; set; }
public float? PercentageOFF { get; set; }
public float? DiscountForOneLine { get; set; }
public float? SumOFF { get; set; }
public int? PercentageOffMatchingItems { get; set; }
public float? SumOffMatchingItems { get; set; }
/// <summary>
/// This setting only applies to promotions that look like "Get $1 of discount for 1 loyalty point". This setting makes sure that regardless of the number of points the customer has, the points can only be exchanged for a limited amount of discount (a specified % of invoice total). 
/// </summary>
public float? MaximumPointsDiscount { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? CustomerCanUseOnlyOnce { get; set; }
/// <summary>
/// Set to 1 if this is a manual promotion and it should be applied to a sale with store manager's approval only. (If you attempt to set this flag on an automatic or coupon-activated promotion, error 1076 will be returned.) 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? RequiresManagerOverride { get; set; }
/// <summary>
/// Reason Code ID. A reason code can be associated with a promotion only when its purpose has been set to "PROMOTION". 
/// </summary>
public int? ReasonID { get; set; }
/// <summary>
/// New unit price. Field "specialUnitPrice" must not be specified together with any other award and this field is only allowed together with "purchasedAmount". 
/// </summary>
public float? SpecialUnitPrice { get; set; }
/// <summary>
/// Maximum limit how many items can be purchased with this special unit price. Field "maxItemsWithSpecialUnitPrice", if specified, must be equal to or larger than "purchasedAmount". 
/// </summary>
public int? MaxItemsWithSpecialUnitPrice { get; set; }
/// <summary>
/// Maximum limit how many times the promotion can be applied to one sale. Field "redemptionLimit" is not allowed for promotions that give % off entire invoice, require reward points or apply to an unlimited number of items. Field "redemptionLimit" can only be used together with "maxItemsWithSpecialUnitPrice" (for special unit price promotions). 
/// </summary>
public int? RedemptionLimit { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveCompanyLogo Settings

public class SaveCompanyLogoSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCompanyLogo";
/// <summary>
/// Image content in base64. Use base64_encode($imagefile). 
/// </summary>
public string ImageContent { get; set; }
/// <summary>
/// Image mime-type, allowed types are image/gif, image/jpeg and image/png. 
/// </summary>
public string ImageMimeType { get; set; }
/// <summary>
/// Image type.Possible values:
/// "INVOICE_IMAGE" - This logo will be shown on invoice printouts and be considered as the "official" logo.
/// "CASHRECEIPT_IMAGE" - This logo will be shown on receipts.
/// "INVOICE_AND_RECEIPT_IMAGE" - Upload the same image for both invoices and receipts.
/// "INVOICE_SIGNATRURE" - Signature replica that will be shown on invoice printouts. 
/// </summary>
public string ImageType { get; set; }
}

#endregion

#region SaveConfParameter Settings

public class SaveConfParameterSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveConfParameter";
public string ParameterName { get; set; }
public string ParameterValue { get; set; }
}

#endregion

#region SaveCountry Settings

public class SaveCountrySettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCountry";
public int? CountryID { get; set; }
/// <summary>
/// Country name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
public string CountryCode { get; set; }
/// <summary>
/// Indicates this country is a member of the European Union, by default 0. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? MemberOfEuropeanUnion { get; set; }
}

#endregion

#region SaveCoupon Settings

public class SaveCouponSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCoupon";
/// <summary>
/// Coupon rule ID. When creating a new coupon, leave this field empty. 
/// </summary>
public int? CouponID { get; set; }
/// <summary>
/// issuedFromDate and issuedUntilDate specify the time period during which serial-numbered coupons of this type will be issued from POS.
/// It does not affect the validity of those printed coupons; the validity period is defined by the sales promotion instead). 
/// </summary>
public string IssuedFromDate { get; set; }
public string IssuedUntilDate { get; set; }
public string Name { get; set; }
public string Code { get; set; }
/// <summary>
/// If set, these coupons are issued only from a specific store/location. Either warehouseID or storeGroup can be set, but not both at the same time. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// If set, these coupons are issued only from a specific store group. 
/// </summary>
public string StoreGroup { get; set; }
/// <summary>
/// If set, the coupon gives discounts according to the specified sales promotion. 
/// </summary>
public int? CampaignID { get; set; }
/// <summary>
/// Set to 1 to make POS automatically print a coupon of this type to each customer who fulfills the following conditions: 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PrintedAutomaticallyInPOS { get; set; }
/// <summary>
/// Customer must either:
/// make a purchase with a certain value (in which case thresholdType = "this_sale" and threshold specifies how big the purchase must be: for example, $250.00 or worth 10 reward points),
/// Or customer's all purchases over the history must give a certain total (in which case thresholdType = "points_amt" and threshold specifies how much purchases the customer must have made: for example, worth a total of $500, or 125 reward points.
/// </summary>
public int? Threshold { get; set; }
/// <summary>
/// Possible values: "dollars", "points". 
/// </summary>
public string Measure { get; set; }
/// <summary>
/// Possible values: "points_amt", "this_sale". 
/// </summary>
public string ThresholdType { get; set; }
/// <summary>
/// Printing cost in reward points. 
/// </summary>
public int? PrintingCostInRewardPoints { get; set; }
/// <summary>
/// If defined, description will be printed on coupon instead of name. 
/// </summary>
public string Description { get; set; }
}

#endregion

#region SaveCurrency Settings

public class SaveCurrencySettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCurrency";
public int? CurrencyID { get; set; }
/// <summary>
/// Currency name. Example "US dollar". Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// Text on invoice. Example "dollars". Use either general parameter "nameShort" or one or more of the following parameters if you need to set the texts in specific languages. 
/// </summary>
public string NameShort { get; set; }
public string NameShortEST { get; set; }
public string NameShortENG { get; set; }
public string NameShortLAT { get; set; }
public string NameShortRUS { get; set; }
public string NameShortFIN { get; set; }
/// <summary>
/// Text on invoice. Example "cents". Use either general parameter "nameFraction" or one or more of the following parameters if you need to set the texts in specific languages. 
/// </summary>
public string NameFraction { get; set; }
public string NameFractionEST { get; set; }
public string NameFractionENG { get; set; }
public string NameFractionLAT { get; set; }
public string NameFractionRUS { get; set; }
public string NameFractionFIN { get; set; }
/// <summary>
/// Currency rate in relation to default currency. 
/// </summary>
public float? Rate { get; set; }
public string Code { get; set; }
}

#endregion

#region SaveCustomerAssociation Settings

public class SaveCustomerAssociationSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCustomerAssociation";
/// <summary>
/// Required for editing an existing relationship. 
/// </summary>
public int? RelationshipID { get; set; }
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Association ID. 
/// </summary>
public int? AssociationID { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Default { get; set; }
}

#endregion

#region SaveCustomerProfessional Settings

public class SaveCustomerProfessionalSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCustomerProfessional";
/// <summary>
/// Required for editing an existing relationship. 
/// </summary>
public int? RelationshipID { get; set; }
/// <summary>
/// Customer ID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Professional ID. 
/// </summary>
public int? ProfessionalID { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Default { get; set; }
}

#endregion

#region SaveDeliveryType Settings

public class SaveDeliveryTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveDeliveryType";
/// <summary>
/// Delivery type ID if you need to change existing type. 
/// </summary>
public int? DeliveryTypeID { get; set; }
/// <summary>
/// Delivery type code. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Delivery type name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
}

#endregion

#region SaveDocument Settings

public class SaveDocumentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveDocument";
public int? TypeID { get; set; }
public int? SeriesID { get; set; }
public int? StatusID { get; set; }
public int? ClientID { get; set; }
public int? ContactID { get; set; }
public int? ProjectID { get; set; }
/// <summary>
/// eg. 2010-01-29 
/// </summary>
public string RegDate { get; set; }
/// <summary>
/// eg. 2010-01-29 
/// </summary>
public string CreationDate { get; set; }
/// <summary>
/// eg. 2010-01-29 
/// </summary>
public string DeadlineDate { get; set; }
/// <summary>
/// Company user unique ID 
/// </summary>
public int? CreatorID { get; set; }
/// <summary>
/// Company user unique ID 
/// </summary>
public int? PersonResponsibleID { get; set; }
public string FileName { get; set; }
public string Direction { get; set; }
public string Name { get; set; }
public string Notes { get; set; }
}

#endregion

#region SaveEDocuments Settings

public class SaveEDocumentsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveEDocuments";
/// <summary>
/// By default "XML" 
/// </summary>
public string Format { get; set; }
/// <summary>
/// Possible values: SALESINVWAYBILL, SALESINVOICE, SALESORDER, SALESEXPORTINVOICE, PURCHASEINVOICE, PURCHASEORDER, PURCHASECASHINVOICE 
/// </summary>
public string Type { get; set; }
/// <summary>
/// xml file's content  
/// </summary>
public string InvoiceXML { get; set; }
/// <summary>
/// link to xml file  
/// </summary>
public string InvoiceXMLUri { get; set; }
}

#endregion

#region SaveEmployee Settings

public class SaveEmployeeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveEmployee";
public int? EmployeeID { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Employee's given name 
/// </summary>
public string FirstName { get; set; }
/// <summary>
/// Employee's surname 
/// </summary>
public string LastName { get; set; }
public string Phone { get; set; }
public string Mobile { get; set; }
public string Email { get; set; }
public string Skype { get; set; }
public string JobTitle { get; set; }
public string Notes { get; set; }
/// <summary>
/// Salon-specific attribute. Available only if Salon / Spa module is enabled on your account. A comma-separated list of product groups that employee provides. 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductGroupIDs { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveEvent Settings

public class SaveEventSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveEvent";
/// <summary>
/// ID of existing event. If this parameter is present, then an existing event is updated. 
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Name or explanation of the event. 
/// </summary>
public string Description { get; set; }
/// <summary>
/// Event type ID. For a list of types, see getEventTypes. If you have salon/spa module enabled, and want to create appointments or stylist schedule items, skip this parameter and use type = APPOINTMENT or type = SCHEDULE instead. 
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Event type. Use this field only if you have salon/spa module enabled (otherwise returns error 1006) and if you want to create a salon appointment or stylist schedule item. Possible values: APPOINTMENT, SCHEDULE, BREAK, LUNCH, VACATION, SICKDAY. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Start date and time of the event, eg. 2010-05-18 15:40:00 (must be specified in the account's default timezone) 
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? StartTime { get; set; }
/// <summary>
/// End date and time of the event, eg. 2010-05-18 16:00:00 (must be specified in the account's default timezone) 
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? EndTime { get; set; }
/// <summary>
/// ID of the customer related to this event (eg. a phone call or a meeting with particular customer) 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// ID of the customer's contact person 
/// </summary>
public int? ContactID { get; set; }
/// <summary>
/// ID of the project associated with this event. Use getProjects. 
/// </summary>
public int? ProjectID { get; set; }
/// <summary>
/// Employee whom this task was assigned to. Use getEmployees. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Employee who entered or assigned this task. Use getEmployees. 
/// </summary>
public int? SubmitterID { get; set; }
/// <summary>
/// Supplier ID. Use getSuppliers. 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Event status. For a list of statuses, see getEventStatuses.
/// If you are using salon/spa module and want to set appointment status to one of the 6 predefined statuses, do not use this parameter - use the "status" field instead. 
/// </summary>
public int? StatusID { get; set; }
/// <summary>
/// Event status ID. Use this field only if you have salon/spa module enabled (otherwise returns error 1006) and if you want to create or update an appointment. Possible values: SCHEDULED, CHECKEDIN, NOSHOW, BEINGSERVICED, CHECKEDOUT, NONE. 
/// </summary>
public string Status { get; set; }
/// <summary>
/// Resource associated with this event (a projector, a meeting room etc.). 
/// </summary>
public int? ResourceID { get; set; }
/// <summary>
/// ID of the product. If Salon / SPA module is not enabled, function returns error 1006. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// ID of the salon. If Salon / SPA module is not enabled, function returns error 1006. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// If Salon / SPA module is not enabled, function returns error 1006. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CheckInTime { get; set; }
/// <summary>
/// If Salon / SPA module is not enabled, function returns error 1006. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CheckOutTime { get; set; }
/// <summary>
/// If Salon / SPA module is not enabled, function returns error 1006. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ServiceStartTime { get; set; }
/// <summary>
/// 1 if event is completed, otherwise 0 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Completed { get; set; }
/// <summary>
/// Longer description, associated e-mail message or anything else. 
/// </summary>
public string Notes { get; set; }
/// <summary>
/// (Only applies if you are using Salon module, and only for events of type "APPOINTMENT".)
/// If set to 1, and if you are creating a new appointment, and it overlaps with an existing appointment (or a lunch, break, vacation or sick day) for the same stylist (employee), API returns error 1043. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NotOverlapping { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveEventType Settings

public class SaveEventTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveEventType";
/// <summary>
/// Set this field to edit an existing event type. 
/// </summary>
public int? EventTypeID { get; set; }
/// <summary>
/// Name of the event type. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// Whether events of this type should be displayed in calendar. 0 or 1 — by default 1. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? DisplayedInCalendar { get; set; }
}

#endregion

#region SaveEventStatus Settings

public class SaveEventStatusSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveEventStatus";
/// <summary>
/// Set this field to edit an existing event status. 
/// </summary>
public int? EventStatusID { get; set; }
/// <summary>
/// Name of the event type. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// Color in #rrggbb format, can be used to display events with different status with different colors. 
/// </summary>
public string Color { get; set; }
}

#endregion

#region SaveGiftCard Settings

public class SaveGiftCardSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveGiftCard";
/// <summary>
/// ID of an existing gift card. If this parameter is present, then the matching gift card will be updated. 
/// </summary>
public int? GiftCardID { get; set; }
/// <summary>
/// If the code matches an existing gift card, then that gift card will be updated, instead of creating a new one. 
/// </summary>
public string Code { get; set; }
public float? Value { get; set; }
/// <summary>
/// Remaining balance 
/// </summary>
public float? Balance { get; set; }
/// <summary>
/// Customer who purchased the gift card 
/// </summary>
public int? PurchasingCustomerID { get; set; }
/// <summary>
/// Date and time of purchase 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? PurchaseDateTime { get; set; }
/// <summary>
/// Store or location where the gift card was purchased 
/// </summary>
public int? PurchaseWarehouseID { get; set; }
/// <summary>
/// Register where the gift card was purchased 
/// </summary>
public int? PurchasePointOfSaleID { get; set; }
/// <summary>
/// Invoice with which the gift card was purchased.
/// If you want to save an invoice and an associated gift card together in one bulk request, set this field to a special value: "CURRENT_INVOICE_ID". Normally, creating two records where one references the other cannot be done within one bulk request; you would have to retrieve one record's ID before you can create the other. This is a special workaround for savePayment, saveGiftCard, saveIssuedCoupon, redeemIssuedCoupon, and subtractCustomerRewardPoints.
/// Note that if saving the invoice results in an error, the payments, coupons etc. will be created and coupons redeemed nevertheless, but without a reference to any invoice. For better error checking you may still want to do saveSalesDocument as a separate request. 
/// </summary>
public int? PurchaseInvoiceID { get; set; }
/// <summary>
/// Salesperson who sold the gift card 
/// </summary>
public int? PurchaseEmployeeID { get; set; }
/// <summary>
/// Customer who redeemed the gift card 
/// </summary>
public int? RedeemingCustomerID { get; set; }
/// <summary>
/// Date and time of redemption 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? RedemptionDateTime { get; set; }
/// <summary>
/// Store or location where the gift card was redeemed 
/// </summary>
public int? RedemptionWarehouseID { get; set; }
/// <summary>
/// Register where the gift card was redeemed 
/// </summary>
public int? RedemptionPointOfSaleID { get; set; }
/// <summary>
/// Invoice with which the gift card was redeemed.
/// If you want to save an invoice and redeem an associated gift card together in one bulk request, set this field to a special value: "CURRENT_INVOICE_ID". Normally, creating two records where one references the other cannot be done within one bulk request; you would have to retrieve one record's ID before you can create the other. This is a special workaround for savePayment, saveGiftCard, saveIssuedCoupon, redeemIssuedCoupon, and subtractCustomerRewardPoints.
/// Note that if saving the invoice results in an error, the payments, coupons etc. will be created and coupons redeemed nevertheless, but without a reference to any invoice. For better error checking you may still want to do saveSalesDocument as a separate request. 
/// </summary>
public int? RedemptionInvoiceID { get; set; }
/// <summary>
/// Salesperson who accepted the gift card 
/// </summary>
public int? RedemptionEmployeeID { get; set; }
/// <summary>
/// Gift card expiration date. Note that gift card expiration is not enabled by default. Contact us if you need to enable gift card expiration. If not enabled, this field's value will not be saved in database. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ExpirationDate { get; set; }
/// <summary>
/// Indicate the tax rate (VAT rate) the gift card was sold with.
/// If you omit this field or set the value to 0, Erply will assume the gift card was sold with 0% tax.
/// Taxing gift cards at time of purchase may sometimes be required due to the EU Council Directive 2016/1065, which defines the concept of "single-purpose vouchers".
/// A list of defined tax rates can be fetched with API call getVatRates. 
/// </summary>
public int? VatrateID { get; set; }
}

#endregion

#region SaveInvoicePaymentType Settings

public class SaveInvoicePaymentTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveInvoicePaymentType";
/// <summary>
/// Set this field to edit an existing payment method. Omit to add a new method. 
/// </summary>
public int? InvoicePaymentTypeID { get; set; }
/// <summary>
/// A code name for this payment method.
/// In saveSalesDocument and getSalesDocuments API calls, you can refer to a payment method by its code name. This is convenient when working with standard payment methods (CASH, CARD etc.). However, you can also give code names to your own custom payment methods. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Payment method name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// Integer 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PaidImmediately { get; set; }
}

#endregion

#region SaveIssuedCoupon Settings

public class SaveIssuedCouponSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveIssuedCoupon";
/// <summary>
/// Issued coupon ID.
/// Set this parameter to update an existing issued coupon.  
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// ID of the coupon code (see getCoupons). Coupon code is like the "blueprint" or "type" of a printed coupon. The "blueprint" specifies in what circumstances the coupons will be printed from POS, and what promotion will apply when customer returns with the coupon — ie., what discount or extra value it effectively carries.
/// Not required when updating an existing coupon. 
/// </summary>
public int? CouponID { get; set; }
/// <summary>
/// A unique identifier for this printed coupon. You may leave this parameter unset and have API generate an identifier automatically. However, if you need, you may assign it yourself. For reference, here is a specification how ERPLY's Offline POS generates coupon IDs:
/// An identifier consists of digits only, and is structured as follows:
/// Point of sale ID - max 3 digits (left padding not needed)
/// Coupon ID - 4 digits (padded with zeroes)
/// Sequential number (each register may keep its own sequence) - 7 digits (padded with zeroes)
/// 4 random digits - to ensure within reason that malicious customer would not be able to guess the identifiers of outstanding coupons, and fabricate coupons using guessed identifiers
/// Note that if this parameter is not unique, error code 1012 is returned.
/// When creating a new coupon, either uniqueIdentifier or pointOfSaleID is required; if you do not set the former, then the latter is compulsory.
/// When updating an existing coupon, this field is not required. But it is possible to update an existing coupon and change its uniqueIdentifier, if you need that. 
/// </summary>
public int? UniqueIdentifier { get; set; }
/// <summary>
/// Invoice the coupon was issued with.
/// If you want to save an invoice and an associated coupon together in one bulk request, set this field to a special value: "CURRENT_INVOICE_ID". Normally, creating two records where one references the other cannot be done within one bulk request; you would have to retrieve one record's ID before you can create the other. This is a special workaround for savePayment, saveGiftCard, saveIssuedCoupon, redeemIssuedCoupon, and subtractCustomerRewardPoints.
/// Note that if saving the invoice results in an error, the payments, coupons etc. will be created and coupons redeemed nevertheless, but without a reference to any invoice. For better error checking you may still want to do saveSalesDocument as a separate request.
/// Alias: issuedInvoiceID. 
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Customer the coupon was issued to.
/// Alias: issuedCustomerID. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Store or location where the coupon was issued.
/// Alias: issuedWarehouseID. 
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Register where the coupon was issued.
/// Either uniqueIdentifier or pointOfSaleID is required; if you do not set the former, then the latter is compulsory.
/// Alias: issuedPointOfSaleID. 
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Salesperson who issued the coupon.
/// Alias: issuedEmployeeID. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Issue time.
/// Alias: issuedTimestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
/// <summary>
/// Expiry date 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ExpiryDate { get; set; }
/// <summary>
/// Denotes whether the coupon was printed automatically (as per coupon terms and conditions) or did the salesperson choose it manually. Values other than 0 are interpreted as "true". 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsPrintedAutomatically { get; set; }
/// <summary>
/// If set to 1, API will not subtract reward points from customer's point balance. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? DoNotSubtractRewardPoints { get; set; }
/// <summary>
/// Invoice the coupon was redeemed with.
/// DO NOT use the saveIssuedCoupon API call, nor any of the following fields, to mark a coupon as redeemed. There is a separate API call, redeemIssuedCoupon, for that. Only use these fields if the coupon has already been redeemed and you want to edit coupon data without changing its status.
/// When creating a new coupon, these fields do not (currently) have any effect. 
/// </summary>
public int? RedeemedInvoiceID { get; set; }
public int? RedeemedCustomerID { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? RedeemedTimestamp { get; set; }
public int? RedeemedWarehouseID { get; set; }
public int? RedeemedPointOfSaleID { get; set; }
public int? RedeemedEmployeeID { get; set; }
}

#endregion

#region SaveLocationInWarehouse Settings

public class SaveLocationInWarehouseSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveLocationInWarehouse";
/// <summary>
/// Set this field to edit an existing location in warehouse. Omit to add a new one. 
/// </summary>
public int? LocationInWarehouseID { get; set; }
/// <summary>
/// Name for the location in warehouse. 
/// </summary>
public string Name { get; set; }
}

#endregion

#region SaveMasterListProducts Settings

public class SaveMasterListProductsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveMasterListProducts";
/// <summary>
/// This parameter must contain a JSON array of products. Each array element contains the following fields:
/// Field name Type Description
/// code String (20) Product's code
/// code2 String (20) Product's second code (by convention, EAN barcode)
/// code3 String (20) Third code of the item
/// supplierCode String (20) Supplier's product code
/// code5 String (20) Code 5 of the item. "Extra product codes" module must be enabled.
/// code6 String (20) Code 6 of the item. "Extra product codes" module must be enabled.
/// code7 String (20) Code 7 of the item. "Extra product codes" module must be enabled.
/// code8 String (20) Code 8 of the item. "Extra product codes" module must be enabled.
/// name String (255) Product name
/// netPrice Decimal, max. 4 decimal places Default sales price of the product, excluding VAT
/// group String (255) Matched to existing groups by name. If not found, a new one is created.
/// category String (255) Matched to existing categories by name. If not found, a new one is created.
/// brand String (255) Matched to existing brands by name. If not found, a new one is created.
/// priorityGroup String (255) Matched to existing priority groups by name. If not found, a new one is created.
/// supplier String (255) Matched to existing suppliers by name. If not found, a new one is created.
/// cost Decimal, 2 decimal places Product cost
/// status String Product status, possible statuses are 'ACTIVE', 'NO_LONGER_ORDERED', 'NOT_FOR_SALE' and 'ARCHIVED'. By default 'ACTIVE'.
/// pictureURL String Picture URL
/// </summary>
public string Data { get; set; }
public   { get; set; }
/// <summary>
/// String (20)
/// </summary>
public string Code { get; set; }
/// <summary>
/// String (20)
/// </summary>
public string Code2 { get; set; }
/// <summary>
/// String (20)
/// </summary>
public string Code3 { get; set; }
/// <summary>
/// String (20)
/// </summary>
public string SupplierCode { get; set; }
/// <summary>
/// String (20)
/// </summary>
public string Code5 { get; set; }
/// <summary>
/// String (20)
/// </summary>
public string Code6 { get; set; }
/// <summary>
/// String (20)
/// </summary>
public string Code7 { get; set; }
/// <summary>
/// String (20)
/// </summary>
public string Code8 { get; set; }
/// <summary>
/// String (255)
/// </summary>
public string Name { get; set; }
/// <summary>
/// Decimal, max. 4 decimal places
/// </summary>
public string NetPrice { get; set; }
/// <summary>
/// String (255)
/// </summary>
public string Group { get; set; }
/// <summary>
/// String (255)
/// </summary>
public string Category { get; set; }
/// <summary>
/// String (255)
/// </summary>
public string Brand { get; set; }
/// <summary>
/// String (255)
/// </summary>
public string PriorityGroup { get; set; }
/// <summary>
/// String (255)
/// </summary>
public string Supplier { get; set; }
/// <summary>
/// Decimal, 2 decimal places
/// </summary>
public string Cost { get; set; }
/// <summary>
/// String
/// </summary>
public string Status { get; set; }
/// <summary>
/// String
/// </summary>
public string PictureURL { get; set; }
}

#endregion

#region SavePaymentType Settings

public class SavePaymentTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "savePaymentType";
/// <summary>
/// Set this field to edit an existing payment type. Omit to add a new type. 
/// </summary>
public int? PaymentTypeID { get; set; }
/// <summary>
/// A code name for this payment type.
/// In savePayment and getPayments API calls, you can refer to a payment type either by ID or by code name. Code name may be more convenient when working with standard payment types (CASH, CARD etc.). However, you can give code names to your own custom types, too.
/// Standard types that ERPLY recognizes (there may be standard functionality attached to payments of these type) are: CASH, CARD, CREDIT, GIFTCARD, CHECK, TRANSFER, TIP. 
/// </summary>
public string Type { get; set; }
/// <summary>
/// Payment type name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// Name on receipt. Use either general parameter "print_name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Print_name { get; set; }
public string Print_nameEST { get; set; }
public string Print_nameENG { get; set; }
public string Print_nameLAT { get; set; }
public string Print_nameRUS { get; set; }
public string Print_nameFIN { get; set; }
/// <summary>
/// Quick Books debit account 
/// </summary>
public string QuickBooksDebitAccount { get; set; }
}

#endregion

#region SavePriceList Settings

public class SavePriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "savePriceList";
/// <summary>
/// Price list ID.
/// If this parameter is present the specified price list will be updated. 
/// </summary>
public int? PricelistID { get; set; }
/// <summary>
/// Price list name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. To have multilingual names enabled, please contact our customer support. An error will be returned if you attempt to set a name in a specific language and the multilingual names are not enabled on your account. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// Valid From date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDate { get; set; }
/// <summary>
/// Valid Until date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDate { get; set; }
/// <summary>
/// Setting this field to 1 activates the price list, setting it to 0 disables it. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Price list type. Possible types are 'BASE_PRICE_LIST', 'STORE_PRICE_LIST'. Certain customers have additional, custom price list types, too; please refer to private documentation on those.
/// To use this field, you need to have the "Price list types" extra module. Please contact customer support to have it activated on your account.
/// If you attempt to use this field and the extra module has not been enabled, API will return error code 1006.
/// If the "Price list types" module has been enabled, this is a required field.
/// An invalid type will return error 1016. Error 1016 will also be returned if you attempt to create or edit a price list with any other type than "STORE_PRICE_LIST" and you do not have rights for that.
/// </summary>
public string Type { get; set; }
/// <summary>
/// Possible types are 'PRODUCT', 'PRODGROUP' or 'SERVICE'. 
/// </summary>
public string Type# { get; set; }
/// <summary>
/// Product, or product group ID, depending on rule type 
/// </summary>
public int? Id# { get; set; }
/// <summary>
/// Discounted sales price for a product. (For products only.) Required field for products. 
/// </summary>
public float? Price# { get; set; }
/// <summary>
/// Discount % for a product group (For product groups only). 
/// </summary>
public float? DiscountPercent# { get; set; }
/// <summary>
/// Available only if Quantity discounts module is enabled on your account. The quantity threshold from which the specified price will apply. 
/// </summary>
public int? Amount# { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveProductFile Settings

public class SaveProductFileSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveProductFile";
/// <summary>
/// Use productFileID to edit or replace an existing file. You may edit general information of the file (productID, name, fileTypeID, isInformationFile) or replace/update the file as well, as needed. 
/// </summary>
public int? ProductFileID { get; set; }
/// <summary>
/// Product ID. For new files, this field is required. 
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// File type ID. See getProductFileTypes. 
/// </summary>
public int? FileTypeID { get; set; }
/// <summary>
/// A flag you can use for classification purposes (value: 0 or 1). 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsInformationFile { get; set; }
/// <summary>
/// A descriptive name for the file 
/// </summary>
public string Name { get; set; }
/// <summary>
/// Contents of the binary file, base64-encoded.
/// If file content is missing, API returns error 1090. If it cannot be base64-decoded, API returns error 1091. 
/// </summary>
public string File { get; set; }
/// <summary>
/// File name. 
/// </summary>
public string Filename { get; set; }
/// <summary>
/// Instead of uploading a file, it is possible to just provide a URL that points to the file in an external location (a content delivery network). This feature is for internal purposes only and NOT recommended for use!
/// Must start with http:// or https://, otherwise API returns error 1015. 
/// </summary>
public string Url { get; set; }
/// <summary>
/// To be used with parameter "url". This should be a mutually-agreed classifier, identifying the CDN where the file is located.
/// Must consist of letters and numbers only ([A-Za-z0-9]*), otherwise API returns error 1015. It cannot be used in conjunction with local files (API will return error 1013). 
/// </summary>
public int? HostingProvider { get; set; }
}

#endregion

#region SaveProductPackage Settings

public class SaveProductPackageSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveProductPackage";
/// <summary>
/// Package ID. Required if you want to edit an existing package. 
/// </summary>
public int? PackageID { get; set; }
/// <summary>
/// Product ID. Required if you want to add a new package.
/// Do not set this field if you are editing an existing package — error 1013 will be returned. A package cannot be "transfered" from one product to another; delete it and add a new one instead.
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Package type ID, see API getProductPackageTypes. Required if you want to add a new package. 
/// </summary>
public int? PackageTypeID { get; set; }
/// <summary>
/// Amount that this package contains. Required if you want to add a new package.
/// Must be a positive decimal, otherwise error 1014 is returned.
/// </summary>
public float? PackageAmount { get; set; }
/// <summary>
/// Package barcode.
/// This is just an informative field at the moment. Neither back office nor POS allow to scan products by their package barcode. This field might be useful for third-party integrations, however.
/// </summary>
public string PackageCode { get; set; }
/// <summary>
/// Package weight without packing materials. (Back office specifies the unit of this field as "kg" or "lbs", depending on your account's country.)
/// Must be a positive decimal, zero, or empty string, otherwise error 1014 is returned.
/// </summary>
public float? PackageNetWeight { get; set; }
/// <summary>
/// Package total weight. (Back office specifies the unit of this field as "kg" or "lbs", depending on your account's country.)
/// Must be a positive decimal, zero, or empty string, otherwise error 1014 is returned.
/// </summary>
public float? PackageGrossWeight { get; set; }
/// <summary>
/// Physical dimensions of the package. (Back office specifies the unit of this field as "mm" or "in", depending on your account's country.)
/// Must be a positive decimal, zero, or empty string, otherwise error 1014 is returned.
/// </summary>
public float? PackageLength { get; set; }
/// <summary>
/// Physical dimensions of the package. (Back office specifies the unit of this field as "mm" or "in", depending on your account's country.)
/// Must be a positive decimal, zero, or empty string, otherwise error 1014 is returned.
/// </summary>
public float? PackageWidth { get; set; }
/// <summary>
/// Physical dimensions of the package. (Back office specifies the unit of this field as "mm" or "in", depending on your account's country.)
/// Must be a positive decimal, zero, or empty string, otherwise error 1014 is returned.
/// </summary>
public float? PackageHeight { get; set; }
}

#endregion

#region SaveProductPriorityGroup Settings

public class SaveProductPriorityGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveProductPriorityGroup";
public int? PriorityGroupID { get; set; }
/// <summary>
/// Priority group name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
}

#endregion

#region SaveProductUnit Settings

public class SaveProductUnitSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveProductUnit";
public int? ProductUnitID { get; set; }
/// <summary>
/// Unit name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
}

#endregion

#region SaveProject Settings

public class SaveProjectSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveProject";
/// <summary>
/// Project ID.
/// If this parameter is present the specified project will be updated. 
/// </summary>
public int? ProjectID { get; set; }
/// <summary>
/// Project name.
/// Not required if updating an existing project. 
/// </summary>
public string Name { get; set; }
/// <summary>
/// Customer ID.
/// Not required if updating an existing project. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Project manager ID. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Project type ID, see getProjectTypes.
/// Not required if updating an existing project. 
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Project status ID, see getProjectStatuses.
/// Not required if updating an existing project. 
/// </summary>
public int? StatusID { get; set; }
/// <summary>
/// Start date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDate { get; set; }
/// <summary>
/// End date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDate { get; set; }
public string Notes { get; set; }
}

#endregion

#region SaveService Settings

public class SaveServiceSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveService";
/// <summary>
/// Service ID if you need to change existing service 
/// </summary>
public int? ServiceID { get; set; }
/// <summary>
/// ID of service group. To get the list of service groups, use getProductGroups. 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// ID of product unit. To get the list of units, use getProductUnits. 
/// </summary>
public int? UnitID { get; set; }
/// <summary>
/// ID of sales VAT rate. To get the list of rates, use getVatRates. If omitted, system will apply the default VAT rate. 
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Service's code. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Service name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
public string DescriptionEST { get; set; }
public string DescriptionENG { get; set; }
public string DescriptionLAT { get; set; }
public string DescriptionRUS { get; set; }
public string DescriptionFIN { get; set; }
/// <summary>
/// Default sales price of the service, excluding VAT 
/// </summary>
public float? NetPrice { get; set; }
/// <summary>
/// Default sales price of the service, VAT included. netPrice and priceWithVat do not have to be specified both - set one of them and system will do the necessary calculations. 
/// </summary>
public float? PriceWithVAT { get; set; }
/// <summary>
/// Set the value to 1 if you want to show the service in webshop as a delivery option 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ShopTransport { get; set; }
/// <summary>
/// Set the value to 1 if you want the service to have a quick-select button in POS 
/// </summary>
public int? HasQuickSelectButton { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveStoreRegion Settings

public class SaveStoreRegionSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveStoreRegion";
/// <summary>
/// Store region ID. Specify store region ID to edit an existing record. 
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Region name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
/// <summary>
/// Region code 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveSubsidyType Settings

public class SaveSubsidyTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveSubsidyType";
/// <summary>
/// Subsidy type ID. If this parameter is present, then the specified type is updated. 
/// </summary>
public int? SubsidyTypeID { get; set; }
/// <summary>
/// Subsidy type code. 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Subsidy type name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
}

#endregion

#region SaveSupplier Settings

public class SaveSupplierSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveSupplier";
/// <summary>
/// Supplier ID. Set this parameter to edit an existing supplier. Omit this parameter to create a new one. 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Supplier group ID. Use getSupplierGroups. If not specified, supplier will be assigned to the first supplier group in the list.
/// When updating existing supplier, groupID must not be set to 0. 
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Supplier manager (must be an employee, use getEmployees). 
/// </summary>
public int? SupplierManagerID { get; set; }
public string CompanyName { get; set; }
/// <summary>
/// If is not set - company type ID will be calculated by analysing company name for type-related parts. 
/// </summary>
public int? CompanyTypeID { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
public string FullName { get; set; }
/// <summary>
/// National ID number (for persons) / Registry code (for companies). 
/// </summary>
public string Code { get; set; }
/// <summary>
/// Use to indicate that this person is a contact person / an employee in a particular company.. 
/// </summary>
public int? CompanyID { get; set; }
/// <summary>
/// Person birthday (not applicable to companies). 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Birthday { get; set; }
/// <summary>
/// Supplier's VAT number. 
/// </summary>
public string VatNumber { get; set; }
/// <summary>
/// Name of supplier's bank. 
/// </summary>
public string BankName { get; set; }
/// <summary>
/// Number of supplier's bank account. 
/// </summary>
public string BankAccountNumber { get; set; }
/// <summary>
/// IBAN number of supplier's bank account. 
/// </summary>
public string BankIBAN { get; set; }
/// <summary>
/// BIC/SWIFT identifier of supplier's bank account. 
/// </summary>
public string BankSWIFT { get; set; }
public string Phone { get; set; }
public string Mobile { get; set; }
public string Fax { get; set; }
public string Email { get; set; }
public string Skype { get; set; }
public string Website { get; set; }
public string Notes { get; set; }
/// <summary>
/// Corresponding supplier identifier in a system integrated with Erply (eg. accounting software) 
/// </summary>
public string IntegrationCode { get; set; }
/// <summary>
/// ID of a VAT rate 
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Currency code, e.g. "EUR" 
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// ID of delivery terms 
/// </summary>
public int? DeliveryTermsID { get; set; }
/// <summary>
/// ID of supplier's country 
/// </summary>
public int? CountryID { get; set; }
/// <summary>
/// String 
/// </summary>
public string GLN { get; set; }
/// <summary>
/// Default payment period. 
/// </summary>
public int? PaymentDays { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveSupplierGroup Settings

public class SaveSupplierGroupSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveSupplierGroup";
/// <summary>
/// Supplier group unique ID. 
/// </summary>
public int? SupplierGroupID { get; set; }
/// <summary>
/// Supplier group name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
}

#endregion

#region SaveSupplierPriceList Settings

public class SaveSupplierPriceListSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveSupplierPriceList";
/// <summary>
/// Price list ID.
/// If this parameter is present the specified price list will be updated. 
/// </summary>
public int? SupplierPriceListID { get; set; }
/// <summary>
/// Price list name. 
/// </summary>
public string Name { get; set; }
/// <summary>
/// Supplier ID. 
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Valid From date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDate { get; set; }
/// <summary>
/// Valid Until date. 
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDate { get; set; }
/// <summary>
/// Setting this field to 1 activates the price list, setting it to 0 disables it. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Product ID. 
/// </summary>
public int? ProductID# { get; set; }
/// <summary>
/// Discounted price for a product. 
/// </summary>
public float? Price# { get; set; }
/// <summary>
/// Available only if Quantity discounts module is enabled on your account. The quantity threshold from which the specified price will apply. 
/// </summary>
public int? Amount# { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
}

#endregion

#region SaveUser Settings

public class SaveUserSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveUser";
public int? UserID { get; set; }
/// <summary>
/// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
/// Possible values:
/// 'eng' - English
/// 'spa' - Spanish
/// 'ger' - German
/// 'swe' - Swedish
/// 'fin' - Finnish
/// 'rus' - Russian
/// 'est' - Estonian
/// 'lat' - Latvian
/// 'lit' - Lithuanian
/// 'gre' - Greek
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// User group.
/// Required field when creating a new user. 
/// </summary>
public int? UserGroupID { get; set; }
/// <summary>
/// Employee's username.
/// Required field when creating a new user.
/// Each user must have a unique name. API returns error 1012 if you try to create a user with a name that already exists. 
/// </summary>
public string Name { get; set; }
/// <summary>
/// Employee's password. Password must be at least 8 characters, otherwise API returns error 1016. 
/// </summary>
public string Password { get; set; }
/// <summary>
/// User PIN. PIN must be at least 6 characters, otherwise API returns error 1016. 
/// </summary>
public string CardCode { get; set; }
/// <summary>
/// ID of the employee. 
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// 0 or 1, by default 0 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SendNotificationEmail { get; set; }
}

#endregion

#region SaveUserOperationsLog Settings

public class SaveUserOperationsLogSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveUserOperationsLog";
/// <summary>
/// One of the following: "customers", "employees", "suppliers", "addresses", "currencies", "customerGroups", "emailAccounts", "giftCards", "pointsOfSale", "priceLists", "productGroups", "products", "services", "supplierGroups", "users", "userGroups", "warehouses", "events", "purchaseDocuments", "salesDocuments", "pricelistProducts", "pricelistServices", "pricelistDiscounts", "payments", "inventoryRegistrations", "inventoryTransfers", "inventoryWriteOffs" — or a custom string 
/// </summary>
public string TableName { get; set; }
public string UserName { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
public string Operation { get; set; }
public int? ItemID { get; set; }
public string Module { get; set; }
}

#endregion

#region SaveVatRate Settings

public class SaveVatRateSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveVatRate";
public int? VatRateID { get; set; }
/// <summary>
/// VAT rate name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// VAT / tax rate.
/// When creating a new tax rate, this field is required (unless you are creating a reverse VAT, see below) and it must be a non-negative decimal. A value of 0 is allowed as well.
/// On an existing tax rate, this field can not be edited; API will ignore the input.
/// </summary>
public float? Rate { get; set; }
/// <summary>
/// Corresponding VAT code in accounting software 
/// </summary>
public string Code { get; set; }
/// <summary>
/// 0 or 1, by default 1.
/// A tax rate can be "archived" by setting active = 1; this tax rate will then no longer appear in tax rate drop-downs.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// 0 or 1, by default 0.
/// Reverse VAT is a concept used in Europe. It means that in certain cases, the obligation to pay VAT (value-added tax) lies on the buyer, not the seller. A seller can issue an invoice where one or multiple lines are subject to reverse VAT. This amount of VAT must then be paid by the buyer directly to the Tax Department, and this VAT amount is not included in the total sum payable to the seller.
/// To create a Reverse VAT rate, leave the rate field unspecified. (Otherwise API returns error 1013.) Set the flag isReverseVat to 1 and specify the rate percentage (eg. 18.5 for 18.5%) in the field reverseRate. Reverse rate can also be 0%.
/// If you populate the field "isReverseVat", then "reverseRate" must be defined as well, and vice versa. Otherwise API returns error 1016.
/// On an existing tax rate, the "isReverseVat" field cannot be edited any more. Populating this field (even if the value is same as previously) will trigger error 1013.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsReverseVat { get; set; }
/// <summary>
/// Reverse tax rate.
/// Must be a non-negative decimal. If you specify an invalid value (eg. text), API returns error 1014.
/// On an existing tax rate, the "reverseRate" field cannot be edited any more. Populating this field (even if the value is same as previously) will trigger error 1013.
/// </summary>
public float? ReverseRate { get; set; }
/// <summary>
/// Canada-specific field, ID of corresponding reduced tax rate, for GST-exempt customers. Must be existing and active tax rate ID 
/// </summary>
public int? GstExemptTaxRateID { get; set; }
/// <summary>
/// Attribute name. Name can only contain the following symbols: A-Z, a-z, 0-9, dash and underscore. 
/// </summary>
public string AttributeName# { get; set; }
/// <summary>
/// Attribute type, possible types are 'text', 'int' and 'double'. By default 'text'. 
/// </summary>
public string AttributeType# { get; set; }
/// <summary>
/// Value of the attribute. Set value to 'null' or 'undefined' to delete an attribute.
/// 'text' attribute can be any string, maximum 255 characters.
/// 'int' must be a signed 32-bit integer.
/// 'double' must be a decimal number. 
/// </summary>
public string AttributeValue# { get; set; }
/// <summary>
/// Fill this field to specify that this tax rate, or this specific combination of city, county and state tax rates, is used in a specific ZIP code area. There are web services that, given a specific US ZIP code as input, can return a list of sales tax rates that must be applied. 
/// </summary>
public string ZIPCode { get; set; }
public string Category { get; set; }
/// <summary>
/// State name. 
/// </summary>
public string State { get; set; }
/// <summary>
/// Percentage of state sales tax. 
/// </summary>
public float? StateTaxRate { get; set; }
/// <summary>
/// County name. 
/// </summary>
public string County { get; set; }
/// <summary>
/// Percentage of county sales tax. 
/// </summary>
public float? CountyTaxRate { get; set; }
/// <summary>
/// City name. 
/// </summary>
public string City { get; set; }
/// <summary>
/// Percentage of city sales tax. 
/// </summary>
public float? CityTaxRate { get; set; }
/// <summary>
/// Naming for custom sales tax component. 
/// </summary>
public string OtherTaxName { get; set; }
/// <summary>
/// Percentage of custom sales tax component. 
/// </summary>
public float? OtherTaxRate { get; set; }
}

#endregion

#region SaveVatRateComponent Settings

public class SaveVatRateComponentSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveVatRateComponent";
/// <summary>
/// Required for editing an existing component. 
/// </summary>
public int? VatRateComponentID { get; set; }
/// <summary>
/// Parent tax for this component. Required when creating a new component. 
/// </summary>
public int? VatRateID { get; set; }
/// <summary>
/// VAT rate name. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameEST { get; set; }
public string NameENG { get; set; }
public string NameLAT { get; set; }
public string NameRUS { get; set; }
public string NameFIN { get; set; }
/// <summary>
/// VAT / tax rate
/// Make sure that the component tax rates, when added up, equal the total parent tax rate. Eg. if state tax is 5%, county tax is 3% and city tax is 0.75%, make sure that you set rate = 8.75. 
/// </summary>
public float? Rate { get; set; }
/// <summary>
/// Corresponding VAT component type. Component must belong into one of 4 fixed categories, and it rarely makes sense to define two components that share the same category.
/// Following the US sales tax model, the categories are:
/// STATE (state sales tax),
/// COUNTY (county sales tax),
/// CITY (city sales tax),
/// OTHER,
/// but you can use them for your own custom setup if needed. 
/// </summary>
public string Type { get; set; }
}

#endregion

#region SaveCompanyType Settings

public class SaveCompanyTypeSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveCompanyType";
/// <summary>
/// Company type ID. Specify ID to edit an existing record. 
/// </summary>
public int? CompanyTypeID { get; set; }
/// <summary>
/// Company type naming. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
public int? Order { get; set; }
}

#endregion

#region SavePersonTitle Settings

public class SavePersonTitleSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "savePersonTitle";
/// <summary>
/// Person title ID. Specify ID to edit an existing record. 
/// </summary>
public int? PersonTitleID { get; set; }
/// <summary>
/// Person title naming. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
public int? Order { get; set; }
}

#endregion

#region SaveJobTitle Settings

public class SaveJobTitleSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveJobTitle";
/// <summary>
/// Job title ID. Specify ID to edit an existing record. 
/// </summary>
public int? JobTitleID { get; set; }
/// <summary>
/// Job title naming. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
public int? Order { get; set; }
}

#endregion

#region SaveBusinessArea Settings

public class SaveBusinessAreaSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "saveBusinessArea";
/// <summary>
/// Business area ID. Specify ID to edit an existing record. 
/// </summary>
public int? BusinessAreaID { get; set; }
/// <summary>
/// Business area naming. Use either general parameter "name" or one or more of the following parameters if you need to set the names in specific languages. 
/// </summary>
public string Name { get; set; }
public string NameENG { get; set; }
public string NameSPA { get; set; }
public string NameGER { get; set; }
public string NameSWE { get; set; }
public string NameFIN { get; set; }
public string NameRUS { get; set; }
public string NameEST { get; set; }
public string NameLAT { get; set; }
public string NameLIT { get; set; }
public string NameGRE { get; set; }
}

#endregion

#region SubtractCustomerRewardPoints Settings

public class SubtractCustomerRewardPointsSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "subtractCustomerRewardPoints";
/// <summary>
/// Customer's ID 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Transaction invoice ID.
/// If you want to save an invoice and adjust customer's point balance in one bulk request, set this field to a special value: "CURRENT_INVOICE_ID". Normally, creating two records where one references the other cannot be done within one bulk request; you would have to retrieve one record's ID before you can create the other. This is a special workaround for savePayment, saveGiftCard, saveIssuedCoupon, redeemIssuedCoupon, and subtractCustomerRewardPoints.
/// Note that if saving the invoice results in an error, the payments, coupons etc. will be created and points subtracted nevertheless, but without a reference to any invoice. For better error checking you may still want to do saveSalesDocument as a separate request. 
/// </summary>
public int? InvoiceID { get; set; }
public int? CampaignID { get; set; }
public int? WarehouseID { get; set; }
public int? SalepointID { get; set; }
public int? SalespersonID { get; set; }
/// <summary>
/// Points to subtract (must be bigger then 0). 
/// </summary>
public int? Points { get; set; }
/// <summary>
/// Transaction timestamp. 
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? SubtractedUnixTime { get; set; }
/// <summary>
/// ID of the issued coupon. Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// Available only if "Reward point extras" module is enabled on your account. 
/// </summary>
public string Description { get; set; }
}

#endregion

#region SetSalesOrderAsFulfilled Settings

public class SetSalesOrderAsFulfilledSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "setSalesOrderAsFulfilled";
/// <summary>
/// Sales order ID. 
/// </summary>
public int? OrderID { get; set; }
}

#endregion

#region SwitchUser Settings

public class SwitchUserSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "switchUser";
/// <summary>
/// A valid session key (or one that has expired in the last 2 hours) 
/// </summary>
public string SessionKey { get; set; }
/// <summary>
/// New user PIN 
/// </summary>
public string CardCode { get; set; }
/// <summary>
/// Desired session length in seconds (1...86400 sec).
/// If you omit the parameter, or specify 0 or a negative value, a session with a default length of 3600 will be created. If you specify a value larger than 86400 seconds, session length will be set to 86400 seconds. 
/// </summary>
public int? SessionLength { get; set; }
}

#endregion

#region SyncTotalProductStock Settings

public class SyncTotalProductStockSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "syncTotalProductStock";
/// <summary>
/// Unix timestamp. If this is specified, then only the stock amounts of these products will be returned, that have been sold or bought after the specified time. 
/// </summary>
public string ChangedSince { get; set; }
/// <summary>
/// If this is set to 1, then the reserved amounts are returned as well. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? GetAmountReserved { get; set; }
}

#endregion

#region UpdateBinStatus Settings

public class UpdateBinStatusSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "updateBinStatus";
/// <summary>
/// Multiple bin IDs, separated by commas, such as: "1,2,3,4,5". 
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> BinIDs { get; set; }
/// <summary>
/// Possible values: "ACTIVE", "ARCHIVED". 
/// </summary>
public string Status { get; set; }
}

#endregion

#region UpdatePrices Settings

public class UpdatePricesSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "updatePrices";
public int? ProductID# { get; set; }
/// <summary>
/// Default sales price of the product, excluding VAT 
/// </summary>
public float? NetPrice# { get; set; }
}

#endregion

#region ValidateCustomerUsername Settings

public class ValidateCustomerUsernameSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "validateCustomerUsername";
public string Username { get; set; }
}

#endregion

#region VerifyIdentityToken Settings

public class VerifyIdentityTokenSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "verifyIdentityToken";
/// <summary>
/// Json Web Token that must contain customer's account number and the right to use the 'Erply back office' app. 
/// </summary>
public string Jwt { get; set; }
}

#endregion

#region VerifyIssuedCoupon Settings

public class VerifyIssuedCouponSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "verifyIssuedCoupon";
/// <summary>
/// Unique identifier of the coupon. Typically this is printed on the coupon as a barcode. 
/// </summary>
public int? UniqueIdentifier { get; set; }
}

#endregion

#region CreateInstallation Settings

public class CreateInstallationSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "createInstallation";
/// <summary>
/// This request can only be called if you have our partnerKey. 
/// </summary>
public string PartnerKey { get; set; }
public string CompanyName { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
public string Phone { get; set; }
public string Website { get; set; }
public string Email { get; set; }
/// <summary>
/// two-letter country code - country where the business is located. By default US. Will return 1177 error if new signups are not allowed for provided country. 
/// </summary>
public string CountryCode { get; set; }
/// <summary>
/// State identifier (for US, CA and AU) 
/// </summary>
public string Region { get; set; }
/// <summary>
/// Default language of this account. Possible values:
/// eng - English
/// est - Estonian
/// fin - Finnish
/// ger - German
/// gre - Greek
/// lat - Latvian
/// lit - Lithuanian
/// rus - Russian
/// spa - Spanish
/// swe - Swedish
/// If omitted, 'eng' will be selected as default. 
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
public string AddressLine1 { get; set; }
public string AddressLine2 { get; set; }
public string AddressPostCode { get; set; }
public string AddressCountry { get; set; }
/// <summary>
/// Reseller identifier (account will be visible to the specified reseller) 
/// </summary>
public string Reseller { get; set; }
/// <summary>
/// If not defined, it is generated automatically 
/// </summary>
public string Username { get; set; }
/// <summary>
/// If not defined, it is generated automatically, if password is defined call will return 1100 error if does not contain at least 8 characters or 1102 error if does not contain at least one small letter, one capital letter and one digit 
/// </summary>
public string Password { get; set; }
/// <summary>
/// IP address of the user signing up 
/// </summary>
public string IpAddress { get; set; }
/// <summary>
/// Set to 'inventoryapi' or 'erply'. The wording of the e-mail sent to user is slightly different. Default value is 'erply'. 
/// </summary>
public string Context { get; set; }
/// <summary>
/// If an entry has already been created in ERPLY customer registry, then caller can provide customer ID. Customer name, contact information, country code, default language, reseller ID, username and password can be omitted. If necessary, just set parameter sendEmail. 
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Name of the plan that user signed up to. For informative purposes only. 
/// </summary>
public string PlanName { get; set; }
/// <summary>
/// Monthly fee of the plan that user signed up to. For informative purposes only. 
/// </summary>
public string PlanPrice { get; set; }
/// <summary>
/// Set to 1 to send an e-mail to the user, containing account information and log-in URL 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SendEmail { get; set; }
/// <summary>
/// Set to 1 to install salon-specific modules. 
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SalonModules { get; set; }
public string Notes { get; set; }
}

#endregion

#region CreateUserFromIdentityToken Settings

public class CreateUserFromIdentityTokenSettings : ErplyCall
{
[JsonIgnore]
public override string CallName { get; set; } = "createUserFromIdentityToken";
/// <summary>
/// Json Web Token 
/// </summary>
public string Jwt { get; set; }
/// <summary>
/// Employee's first name 
/// </summary>
public string FirstName { get; set; }
/// <summary>
/// Employee's last name 
/// </summary>
public string LastName { get; set; }
}

#endregion

#endregion
