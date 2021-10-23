#region Products

#region Product

public class Product : ErplyItem
{
/// <summary>
/// Product ID  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Product type. The type can be:
/// PRODUCT - A regular item.
/// BUNDLE - A bundle product. Bundle products do not have an inventory quantity. When a bundle is sold, it is the components that are actually drawn from inventory. A bundle cannot be purchased, counted or taken into stock. The composition of a bundle product is described by its recipe. To retrieve the recipes for all bundle products, set input parameter getRecipes = 1. API then returns the field productComponents.
/// MATRIX - a matrix product. Matrix product has a number of variations - specific colors or sizes of the same design or model. The matrix product itself does not have inventory and cannot be purchased or sold. To get the list of variations for each matrix product, see the output field productVariations (which is always returned, but only contains variation IDs), or variationList (which contains more detailed information, but which you have to specifically request with getMatrixVariations = 1).
/// ASSEMBLY - An assembly product. An assembly is similar to a bundle (it has a list of components), but it is an inventory item in its own right. An assembly can be purchased as a whole, and it can also be "assembled". Assembling is a procedure that subtracts the components from inventory and takes the finished product into stock.
/// </summary>
public string Type { get; set; }
/// <summary>
/// Value 0 indicates an archived product, and is equivalent to status = ARCHIVED. Archived products should not be displayed to users.
/// Value 1 indicates an active item. For a more detailed breakdown of active products, see the next field.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Product status, possible statuses are 'ACTIVE', 'NO_LONGER_ORDERED', 'NOT_FOR_SALE' and 'ARCHIVED'.  
/// </summary>
public string Status { get; set; }
/// <summary>
/// Product name.
/// Products can have different names in each language. Use input parameter lang to specify which language you want to retrieve. By default, API returns product names in account's default language.
/// If you want to retrieve names in all languages with one API call, set input parameter getAllLanguages = 1. In addition to field name, API will then return fields nameENG, nameGER, etc. — one for each language enabled on your account.  
/// </summary>
public string Name { get; set; }
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
public int? SupplierID { get; set; }
public string SupplierName { get; set; }
public int? UnitID { get; set; }
public string UnitName { get; set; }
/// <summary>
/// If set to 1, this product is tax free in ALL stores and sales locations, regardless of POS tax rate and regardless of this product's vatrateID. (Eg. a gift card.)  
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
/// Value 1 indicates that this item has a quick-select button in POS.
/// This field is DEPRECATED, because in Erply backend you can actually define different POS quick select buttons for each shop (location, warehouse). Therefore you should use API call getPointsOfSale to retrieve POS quick buttons. For each register, API will return a quickButtons structure.
/// (Quick buttons are specified per-store, but getPointsOfSale returns them separately for each register.)
/// Please note that quick buttons may contain both services and products. We are phasing out services (new accounts do not have this module and should use non-stock products instead), but older accounts still have and use them.
/// If you are only interested in product buttons, you can still use API call getProducts. Set the filters quickPosProducts = 1 and warehouseID.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? HasQuickSelectButton { get; set; }
/// <summary>
/// 1 if this item is a serial numbered gift card.
/// If such a product is sold from POS, its serial number should be recorded and saved into the registry of sold gift cards, using API function saveGiftCard.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsGiftCard { get; set; }
/// <summary>
/// 1 if this item is a regular gift card.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsRegularGiftCard { get; set; }
/// <summary>
/// 1 if this item is marked as non-discountable. Non-discountable products are related to calculateShoppingCart call. This field show only product's own flag, product can be non-discountable for card calculation if it's group, or any of group's parent group is marked as non-discountable, or if product is any type of gift card. Flag presently only applies to promotion discounts, product still can be discounted manually or using price list.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NonDiscountable { get; set; }
public string ManufacturerName { get; set; }
/// <summary>
/// Priority group ID. See getProductPriorityGroups.  
/// </summary>
public int? PriorityGroupID { get; set; }
/// <summary>
/// Country ID. See getCountries.  
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
/// 0 or 1. API returns this attribute if Salon / SPA module is enabled.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? WalkInService { get; set; }
/// <summary>
/// 0 or 1. API returns this attribute if Reward Points module is enabled.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? RewardPointsNotAllowed { get; set; }
/// <summary>
/// 0 or 1.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? NonStockProduct { get; set; }
/// <summary>
/// If this field is set to 1, a prompt to enter price will appear in Berlin POS (3.26 and newer) every time the item is sold. (Even if the item has a price on product card or price lists, cashier will override the price every time, so the price lists will not apply.)
/// This feature is used for random-weighted or random-priced items which are sold in units. (Inventory will be in units, but each unit might have a unique price given to it.)
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CashierMustEnterPrice { get; set; }
/// <summary>
/// Item's net weight. Unit depends on region, check your Erply account (typically lbs or kg)  
/// </summary>
public string NetWeight { get; set; }
/// <summary>
/// Item's gross weight (with packaging). Unit depends on region, check your Erply account (typically lbs or kg)  
/// </summary>
public string GrossWeight { get; set; }
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
/// Product unit cost.
/// This is an informative, unchanging cost you can edit yourself on Erply's product card. To get real current costs for the batches in stock, use FIFOCost instead.  
/// </summary>
public float? Cost { get; set; }
/// <summary>
/// Average product unit cost, for the batches currently in stock.
/// To retrieve this field, set getFIFOCost = 1. If you have specified warehouse ID, API returns FIFO cost of selected products in one specific warehouse. Otherwise, the cost given is an average over all warehouses. See the structure "warehouses" below to get costs for each warehouse separately.
/// Cost = purchase price + freight and other additional costs.  
/// </summary>
public float? FIFOCost { get; set; }
/// <summary>
/// Average purchase price, for the batches currently in stock.
/// Purchase price is basically the same as FIFO cost, but excluding freight and other additional costs.
/// To retrieve this field, set getFIFOCost = 1. If you have specified warehouse ID, API returns purchase price of selected products in one specific warehouse. Otherwise, the purchase price given is an average over all warehouses. See the structure "warehouses" below to get purchase prices for each warehouse separately.  
/// </summary>
public float? PurchasePrice { get; set; }
/// <summary>
/// Amount of backbar charges for this service.  
/// </summary>
public string BackbarCharges { get; set; }
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
/// 0 or 1. A flag that indicates whether the image is stored as a local file in Erply, or as a URL to an external location, eg. a content delivery network.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? External { get; set; }
/// <summary>
/// A codename for the hosting provider, if the file is stored in an external location. May be empty.
/// This is used only for ERPLY's internal purposes, eg. to know how to remove image files from a specific CDN when the picture is removed from ERPLY.
/// </summary>
public int? HostingProvider { get; set; }
/// <summary>
/// name of the dimension (eg. "Size")
/// </summary>
public string Name { get; set; }
/// <summary>
/// name of dimension's value (eg. "Medium")
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
/// name of the dimension (eg. "Size")
/// </summary>
public string Name { get; set; }
/// <summary>
/// name of dimension's value (eg. "Medium")
/// </summary>
public string Value { get; set; }
/// <summary>
/// code of dimension's value (eg. "M")
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
/// <summary>
/// For matrix variations only: the ID of matrix parent product.  
/// </summary>
public int? ParentProductID { get; set; }
/// <summary>
/// ID of another product, a beverage container that is always sold together with this item.  
/// </summary>
public int? ContainerID { get; set; }
/// <summary>
/// Name of the associated product, the beverage container. Set parameter getContainerInfo=1 to retrieve this field.  
/// </summary>
public string ContainerName { get; set; }
/// <summary>
/// Code of the associated product, the beverage container. Set parameter getContainerInfo=1 to retrieve this field.  
/// </summary>
public string ContainerCode { get; set; }
/// <summary>
/// Number of beverage containers that this product contains. (Eg. if your product is "A Case of Coca-Cola", it might contain 24 cans.) Set parameter getContainerInfo=1 to retrieve this field.  
/// </summary>
public string ContainerAmount { get; set; }
/// <summary>
/// Type of packaging, Packaging module must be enabled, possible values - "ORDINARY_PACKAGE", "METAL_BEVERAGE_PACKAGE", "RETURNABLE_PACKAGE" or empty.  
/// </summary>
public string PackagingType { get; set; }
/// <summary>
/// Package ID
/// </summary>
public int? PackageID { get; set; }
/// <summary>
/// Package type name in current language
/// </summary>
public string PackageType { get; set; }
/// <summary>
/// Package type ID, full list in getProductPackageTypes
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
/// <summary>
/// ID of the file
/// </summary>
public int? FileID { get; set; }
/// <summary>
/// A descriptive name for the file. May be empty.
/// </summary>
public string Name { get; set; }
/// <summary>
/// File type ID. Types are defined in Settings » Inventory settings » Product file types. See getProductFileTypes.
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// name of the file type
/// </summary>
public string TypeName { get; set; }
/// <summary>
/// A flag for categorizing the files
/// </summary>
public int? IsInformationFile { get; set; }
/// <summary>
/// URL of file.
/// </summary>
public string FileURL { get; set; }
/// <summary>
/// 0 or 1. A flag that indicates whether the file is stored as a local file in Erply, or as a URL to an external location, eg. a content delivery network.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? External { get; set; }
/// <summary>
/// A codename for the hosting provider, if the file is stored in an external location. May be empty.
/// This is used only for ERPLY's internal purposes, eg. to know how to remove files from a specific CDN when the file is removed from ERPLY.
/// </summary>
public int? HostingProvider { get; set; }
/// <summary>
/// ID of the component product
/// </summary>
public int? ComponentID { get; set; }
/// <summary>
/// Component amount
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// Sales price (VAT excluded) that applies to specified sales location or customer. API returns this attribute if parameter "getPriceListPrices" is specified.  
/// </summary>
public float? PriceListPrice { get; set; }
/// <summary>
/// Sales price (VAT included) that applies to specified sales location or customer. API returns this attribute if parameter "getPriceListPrices" is specified.  
/// </summary>
public float? PriceListPriceWithVat { get; set; }
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
/// <summary>
/// Location in warehouse. DEPRECATED — this is a merged field that contains both the "location in warehouse" classifier selected from a drop-down, and the contents of the "location in warehouse" text field. To get these values separately, see the following fields.  
/// </summary>
public string LocationInWarehouse { get; set; }
/// <summary>
/// ID of product's location in warehouse (selected from a drop-down list). To get a list of the classifiers, see getLocationsInWarehouse.  
/// </summary>
public int? LocationInWarehouseID { get; set; }
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
public string ***** { get; set; }
/// <summary>
/// The product's identification number in a state registry (eg. for alcoholic beverages).  
/// </summary>
public string RegistryNumber { get; set; }
/// <summary>
/// Percentage of alcohol by volume in the beverage.  
/// </summary>
public string AlcoholPercentage { get; set; }
/// <summary>
/// List of current batches in stock (batch identification numbers), separated by semicolons. This field is only meant to be used for specific reporting purposes (eg. for alcoholic beverages), where batches are identified by an official identification number. Erply does not manage these "batches" automatically; it only allows to associate a sales document row with a batch number.  
/// </summary>
public string Batches { get; set; }
/// <summary>
/// Number and date of the excise declaration for this product (eg. an alcoholic beverage), and other relevant information about the declaration  
/// </summary>
public string ExciseDeclaration { get; set; }
public string ExciseFermentedProductUnder6 { get; set; }
public string ExciseWineOver6 { get; set; }
public string ExciseFermentedProductOver6 { get; set; }
public string ExciseIntermediateProduct { get; set; }
public string ExciseOtherAlcohol { get; set; }
public string ExcisePackaging { get; set; }
public string **** { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
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
}

#endregion

#region ProductGroup

public class ProductGroup : ErplyItem
{
/// <summary>
/// Product group ID.  
/// </summary>
public int? ProductGroupID { get; set; }
/// <summary>
/// Product group name.
/// Product groups can have different names in each language. Use input parameter lang to specify which language you want to retrieve. By default, API returns names in account's default language.
/// If you want to retrieve names in all languages with one API call, set input parameter getAllLanguages = 1. In addition to field name, API will then return fields nameENG, nameGER, etc. — one for each language enabled on your account.  
/// </summary>
public string Name { get; set; }
/// <summary>
/// 1 if product group should be displayed in webshop.  
/// </summary>
public int? ShowInWebshop { get; set; }
/// <summary>
/// 1 if this group is marked as non-discountable. Non-discountable products and groups are related to calculateShoppingCart call. This field show only groups's own flag, product can be non-discountable for card calculation if it's group, or any of group's parent group is marked as non-discountable, or if product is any type of gift card. Flag presently only applies to promotion discounts, product still can be discounted manually or using price list.  
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
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
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

#region ProductCategory

public class ProductCategory : ErplyItem
{
public int? ProductCategoryID { get; set; }
public int? ParentCategoryID { get; set; }
public string ProductCategoryName { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
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

#region ProductPriorityGroup

public class ProductPriorityGroup : ErplyItem
{
public int? PriorityGroupID { get; set; }
public string PriorityGroupName { get; set; }
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

#region ProductUnit

public class ProductUnit : ErplyItem
{
public int? UnitID { get; set; }
public string Name { get; set; }
}

#endregion

#region ProductPrice

public class ProductPrice : ErplyItem
{
public int? ProductID { get; set; }
/// <summary>
/// Price on product card.  
/// </summary>
public float? DefaultPrice { get; set; }
public float? DefaultPriceWithVAT { get; set; }
/// <summary>
/// Price that applies to this sales location or this customer.  
/// </summary>
public float? SpecialPrice { get; set; }
public float? SpecialPriceWithVAT { get; set; }
}

#endregion

#region ProductCostForSpecificAmount

public class ProductCostForSpecificAmount : ErplyItem
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
/// IF THERE IS NOT ENOUGH INVENTORY, API can only return a preliminary cost value! This is because the real cost will be determined by the next Purchase Invoice or Inventory Registration. If that is the case, costIsPreliminary will be set to 1 and amountActuallyInStock will tell the actual current stock quantity.  
/// </summary>
public float? AmountActuallyInStock { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? CostIsPreliminary { get; set; }
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
/// This includes the amounts that are reserved to specific customers: via Sales Orders, for example. If you want to get only available inventory, subtract amountReserved from amountInStock.  
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
/// Otherwise, the price on most recent purchase invoice (regardless of supplier or location) is returned.
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
/// Cost = purchase price + freight costs. If you multiply this field by amountInStock, you will get the total current value of your inventory.
/// Whenever you sell from inventory, ERPLY will naturally calculate cost for the specific sold items, not use this average value. Each sold item has its own cost, since it is drawn from a specific batch (according to FIFO). If you are interested in the cost of the sold item, you can use API calls:
/// getProductCostForSpecificAmount — if you need to know the cost before you create the sales document.
/// getCostOfGoodsSold — if the sale has already taken place. Returns all sold items and their costs in a specified time period.
/// getSalesDocuments — returns the total cost of all items on the invoice (field "cost"), if you specify input parameter getCOGS = 1.
/// To retrieve this field, set getAveragePrices = 1.  
/// </summary>
public float? AverageCost { get; set; }
/// <summary>
/// ISO date (yyyy-mm-dd)  
/// </summary>
public string FirstPurchaseDate { get; set; }
/// <summary>
/// ISO date (yyyy-mm-dd)  
/// </summary>
public string LastPurchaseDate { get; set; }
/// <summary>
/// ISO date (yyyy-mm-dd)  
/// </summary>
public string LastSoldDate { get; set; }
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

#region Product

public class Product : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? ProductID { get; set; }
}

#endregion

#region ProductGroup

public class ProductGroup : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? ProductGroupID { get; set; }
}

#endregion

#region ProductCategory

public class ProductCategory : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? ProductCategoryID { get; set; }
}

#endregion

#region ProductPicture

public class ProductPicture : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? ProductPictureID { get; set; }
}

#endregion

#region MatrixDimension

public class MatrixDimension : ErplyItem
{
/// <summary>
/// ID of the created or updated matrix dimension.  
/// </summary>
public int? DimensionID { get; set; }
}

#endregion

#endregion
#region Customers

#region Customer

public class Customer : ErplyItem
{
/// <summary>
/// (deprecated alternative name: id)  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// COMPANY or PERSON.
/// For companies, the following attributes are set: fullName, companyName (both have the same value).
/// For persons, the following attributes are set: fullName, firstName, lastName. fullName is a combination of latter two: "lastName, firstName".
/// fullName can be used for displaying customer's name wherever needed.
/// Guidelines for applications with a customer edit form:
/// Companies should have one name field and the attribute that is edited should be companyName.
/// Persons should have separate fields for given name and surname (respective attributes: firstName, lastName).
/// Note: API call saveCustomer also has an input parameter "fullName" (when using that, system tries to interpret and split the name as required), but it should be used only when brokering data from some other system where a better data format is not available.  
/// </summary>
public string CustomerType { get; set; }
/// <summary>
/// Full name of the customer, use for displaying customer name.  
/// </summary>
public string FullName { get; set; }
/// <summary>
/// For companies only.  
/// </summary>
public string CompanyName { get; set; }
/// <summary>
/// Company type ID, for companies only.  
/// </summary>
public int? CompanyTypeID { get; set; }
/// <summary>
/// (Given name.) For persons only.  
/// </summary>
public string FirstName { get; set; }
/// <summary>
/// (Surname.) For persons only.  
/// </summary>
public string LastName { get; set; }
/// <summary>
/// Person title ID.  
/// </summary>
public int? PersonTitleID { get; set; }
/// <summary>
/// Email address for e-invoices. If this is empty, then the regular email address is used.  
/// </summary>
public string EInvoiceEmail { get; set; }
/// <summary>
/// Indicates whether the customer would like to get invoices on their email (0 or 1).  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? EmailEnabled { get; set; }
/// <summary>
/// Indicates whether the customer would like to get e-invoices (0 or 1).  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? EInvoiceEnabled { get; set; }
/// <summary>
/// If e-invoice operator supports sending paper mails and this value is set to 1, then the operator is allowed to send the invoice by mail (additional charges might occur) (0 or 1).  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? MailEnabled { get; set; }
public int? OperatorIdentifier { get; set; }
/// <summary>
/// Gender: "male", "female" or empty string.  
/// </summary>
public string Gender { get; set; }
/// <summary>
/// Customer group ID.  
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Country ID.  
/// </summary>
public int? CountryID { get; set; }
public string GroupName { get; set; }
/// <summary>
/// Payer ID  
/// </summary>
public int? PayerID { get; set; }
public string Phone { get; set; }
public string Mobile { get; set; }
public string Email { get; set; }
public string Fax { get; set; }
/// <summary>
/// National ID number (for persons) / Registry code (for companies).  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Person's birthday  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Birthday { get; set; }
/// <summary>
/// Corresponding customer identifier in a system integrated with Erply (eg. accounting software)  
/// </summary>
public string IntegrationCode { get; set; }
/// <summary>
/// Whether the customer is marked with an importance flag or not  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? FlagStatus { get; set; }
/// <summary>
/// Optional colored flag associated with this customer. Possible values: "", "red", "green", "yellow", "blue".  
/// </summary>
public string ColorStatus { get; set; }
/// <summary>
/// URL to customer's image file.  
/// </summary>
public string Image { get; set; }
/// <summary>
/// Indicates this customer is a tax exempt organization.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TaxExempt { get; set; }
/// <summary>
/// Indicates this customer pays invoices via factoring.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PaysViaFactoring { get; set; }
/// <summary>
/// Do not use. Does NOT return reward points information.
/// To retrieve customer's reward points balance, use getCustomerRewardPoints.  
/// </summary>
public int? RewardPoints { get; set; }
public int? TwitterID { get; set; }
public string FacebookName { get; set; }
/// <summary>
/// Last 4 numbers of customer's credit card.  
/// </summary>
public string CreditCardLastNumbers { get; set; }
/// <summary>
/// GLN.  
/// </summary>
public string GLN { get; set; }
/// <summary>
/// EDI code.  
/// </summary>
public string EDI { get; set; }
/// <summary>
/// Indicates this customer is a default customer.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsPOSDefaultCustomer { get; set; }
/// <summary>
/// Customer type. Possible values are "DOMESTIC", "EU", "OUTSIDE_EU".  
/// </summary>
public string EuCustomerType { get; set; }
/// <summary>
/// Credit limit.  
/// </summary>
public int? Credit { get; set; }
/// <summary>
/// 0 or 1, by default 0.
/// Indicates that this customer is not allowed to receive invoices (up-front cash payments only).  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? SalesBlocked { get; set; }
/// <summary>
/// Customer's reference number, if system is configured to use hand-assigned reference numbers (by default not).  
/// </summary>
public string ReferenceNumber { get; set; }
/// <summary>
/// Code of customer's loyalty/membership card. This code matches the sequence produced by card swipe.  
/// </summary>
public string CustomerCardNumber { get; set; }
/// <summary>
/// 0 or 1.
/// Indicates that this customer does not earn new reward points.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? RewardPointsDisabled { get; set; }
/// <summary>
/// 0 or 1.
/// Indicates that this customer ignores balance calculation.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CustomerBalanceDisabled { get; set; }
/// <summary>
/// 0 or 1.
/// Indicates that POS does not automatically print coupons to this customer.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PosCouponsDisabled { get; set; }
/// <summary>
/// 0 or 1.
/// Indicates that this customer is opted-out customer.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? EmailOptOut { get; set; }
/// <summary>
/// Employee's username  
/// </summary>
public string LastModifierUsername { get; set; }
/// <summary>
/// 0 or 1.
/// Indicates that for this customer, shipments should be (and may be) accompanied by a Waybill. At the end of the month, a summary Invoice can be issued for all the month's shipments and customer will pay then for all the shipments at once. (In the Sales module, there is a command "Create invoice from selected waybills"). If a customer does not have this flag, you should issue Invoice-Waybills instead, and the customer must pay for each shipment separately.
/// Field appears only if conf parameter enable_waybill_customers is set to 1.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ShipGoodsWithWaybills { get; set; }
/// <summary>
/// Address ID
/// </summary>
public int? AddressID { get; set; }
/// <summary>
/// Full formatted address, on one line. Address parts are joined by commas, eg:
/// 145 West 64th St, Apartment 135, New York, NY 10067
/// </summary>
public string Address { get; set; }
/// <summary>
/// Street address
/// </summary>
public string Street { get; set; }
/// <summary>
/// Street address, line 2.
/// Only US, CA, MX, AU, DE, AT and CH users have this field in Erply.
/// </summary>
public string Address2 { get; set; }
/// <summary>
/// City, region, or county
/// </summary>
public string City { get; set; }
/// <summary>
/// Postal code or ZIP code
/// </summary>
public string PostalCode { get; set; }
/// <summary>
/// State.
/// Only US, CA, MX, AU, DE, AT and CH users have this field in Erply.
/// </summary>
public string State { get; set; }
public string Country { get; set; }
/// <summary>
/// Address type ID
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Address type
/// </summary>
public string TypeName { get; set; }
public int? ContactPersonID { get; set; }
/// <summary>
/// Full name of the contact person, use for displaying.
/// </summary>
public string FullName { get; set; }
public string FirstName { get; set; }
public string LastName { get; set; }
/// <summary>
/// Contact person's customer group ID.
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Contact person's group name.
/// </summary>
public string GroupName { get; set; }
public string Phone { get; set; }
public string Mobile { get; set; }
public string Email { get; set; }
public string Fax { get; set; }
/// <summary>
/// National ID number.
/// </summary>
public string Code { get; set; }
/// <summary>
/// Corresponding identifier in a system integrated with Erply (eg. accounting software)
/// </summary>
public string IntegrationCode { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Flagstatus { get; set; }
/// <summary>
/// Optional colored flag associated with this contact person. Possible values: "", "red", "green", "yellow", "blue".
/// </summary>
public string ColorStatus { get; set; }
/// <summary>
/// URL to customer's image file.
/// </summary>
public string Image { get; set; }
public int? TwitterID { get; set; }
public string FacebookName { get; set; }
public string CustomerCardNumber { get; set; }
public string Skype { get; set; }
public string Website { get; set; }
/// <summary>
/// Name of contact person's bank.
/// </summary>
public string BankName { get; set; }
/// <summary>
/// Number of contact person's bank account.
/// </summary>
public string BankAccountNumber { get; set; }
/// <summary>
/// IBAN number of contact person's bank account.
/// </summary>
public string BankIBAN { get; set; }
/// <summary>
/// BIC/SWIFT identifier of contact person's bank account.
/// </summary>
public string BankSWIFT { get; set; }
/// <summary>
/// Person's birthday.
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Birthday { get; set; }
/// <summary>
/// Person's job title.
/// </summary>
public int? JobTitleID { get; set; }
public string JobTitleName { get; set; }
/// <summary>
/// Contact person's customer manager.
/// </summary>
public int? CustomerManagerID { get; set; }
public string CustomerManagerName { get; set; }
/// <summary>
/// Contact person's business area.
/// </summary>
public int? BusinessAreaID { get; set; }
public string BusinessAreaName { get; set; }
public string Notes { get; set; }
/// <summary>
/// Default association ID.  
/// </summary>
public int? DefaultAssociationID { get; set; }
/// <summary>
/// Default association name.  
/// </summary>
public string DefaultAssociationName { get; set; }
/// <summary>
/// Default professional ID.  
/// </summary>
public int? DefaultProfessionalID { get; set; }
/// <summary>
/// Default professional name.  
/// </summary>
public string DefaultProfessionalName { get; set; }
public int? RelationshipID { get; set; }
/// <summary>
/// Association ID
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Association name
/// </summary>
public string Name { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Default { get; set; }
public int? RelationshipID { get; set; }
/// <summary>
/// Professional ID
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Professional name
/// </summary>
public string Name { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Default { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Amount that the customer has prepaid (NEGATIVE VALUE) or is currently due (POSITIVE VALUE). NB! The sign of the value is opposite to the usual expectation, since that's how balances are usually kept in accounting.  
/// </summary>
public float? ActualBalance { get; set; }
/// <summary>
/// The credit limit that has been set to the customer.  
/// </summary>
public int? CreditLimit { get; set; }
/// <summary>
/// This value shows how much of the credit is actually available at the moment. availableCredit = creditLimit - actualBalance.  
/// </summary>
public float? AvailableCredit { get; set; }
/// <summary>
/// If set to 0, customer cannot use the "pay later" option, and must pay up-front in full for each purchase.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CreditAllowed { get; set; }
/// <summary>
/// Customer's VAT number.  
/// </summary>
public string VatNumber { get; set; }
public string Skype { get; set; }
public string Website { get; set; }
public string WebshopUsername { get; set; }
public string WebshopLastLogin { get; set; }
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
/// Person's job title ID  
/// </summary>
public int? JobTitleID { get; set; }
public string JobTitleName { get; set; }
/// <summary>
/// (Persons only.) Company where this person is an employee / a contact person.  
/// </summary>
public int? CompanyID { get; set; }
public string EmployerName { get; set; }
/// <summary>
/// Customer manager ID  
/// </summary>
public int? CustomerManagerID { get; set; }
public string CustomerManagerName { get; set; }
/// <summary>
/// Default payment period for invoices.  
/// </summary>
public int? PaymentDays { get; set; }
/// <summary>
/// Penalty for overdue invoices, expressed as % per day, eg. "0.5". Free text.  
/// </summary>
public string PenaltyPerDay { get; set; }
/// <summary>
/// Customer's price list 1  
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Customer's price list 2  
/// </summary>
public int? PriceListID2 { get; set; }
/// <summary>
/// Customer's price list 3  
/// </summary>
public int? PriceListID3 { get; set; }
/// <summary>
/// Indicates that this is a foreign customer, located outside EU. DEPRECATED — euCustomerType is recommended instead.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? OutsideEU { get; set; }
/// <summary>
/// Customer's business area.  
/// </summary>
public int? BusinessAreaID { get; set; }
public string BusinessAreaName { get; set; }
public int? DeliveryTypeID { get; set; }
/// <summary>
/// Location where customer was registered.  
/// </summary>
public int? SignUpStoreID { get; set; }
/// <summary>
/// Most commonly used location.  
/// </summary>
public int? HomeStoreID { get; set; }
/// <summary>
/// Tax office ID. This is a Greece-specific field and is only returned on Greek accounts.  
/// </summary>
public int? TaxOfficeID { get; set; }
public string Notes { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
/// <summary>
/// ID of the employee  
/// </summary>
public int? LastModifierEmployeeID { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
/// <summary>
/// Full formatted address, on one line. Address parts are joined by commas, eg:
/// 145 West 64th St, Apartment 135, New York, NY 10067  
/// </summary>
public string Address { get; set; }
/// <summary>
/// Street address (or more generally, address line 1).  
/// </summary>
public string Street { get; set; }
/// <summary>
/// Street address, line 2.
/// Only US, CA, MX and AU users have this field in Erply.  
/// </summary>
public string Address2 { get; set; }
/// <summary>
/// City, region, or county.  
/// </summary>
public string City { get; set; }
/// <summary>
/// Postal code or ZIP code.  
/// </summary>
public string PostalCode { get; set; }
/// <summary>
/// State.
/// Only US, CA, MX and AU users have this field in Erply.  
/// </summary>
public string State { get; set; }
public string Country { get; set; }
/// <summary>
/// Address type ID.  
/// </summary>
public int? AddressTypeID { get; set; }
/// <summary>
/// Address type.  
/// </summary>
public string AddressTypeName { get; set; }
}

#endregion

#region Address

public class Address : ErplyItem
{
public int? AddressID { get; set; }
/// <summary>
/// Customer's or supplier's unique ID (deprecated alternative name: clientID)  
/// </summary>
public int? OwnerID { get; set; }
/// <summary>
/// Address type ID, see getAddressTypes.  
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Address type.  
/// </summary>
public string TypeName { get; set; }
/// <summary>
/// Some address types are "archival types" -- addresses in these groups are not used for invoicing. This parameter indicates whether the type of this address is an archival type or not.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TypeActivelyUsed { get; set; }
/// <summary>
/// Street address (or more generally, address line 1).  
/// </summary>
public string Street { get; set; }
/// <summary>
/// Street address, line 2. This field is exposed via Erply user interface only for US, CA and MX accounts!  
/// </summary>
public string Address2 { get; set; }
/// <summary>
/// City, region, or county.  
/// </summary>
public string City { get; set; }
/// <summary>
/// Postal code or ZIP code.(deprecated alternative name: postcode)  
/// </summary>
public string PostalCode { get; set; }
/// <summary>
/// State. This field is exposed via Erply user interface only for US, CA and MX accounts!  
/// </summary>
public string State { get; set; }
public string Country { get; set; }
public string Added { get; set; }
public string LastModified { get; set; }
/// <summary>
/// Employee's username  
/// </summary>
public string LastModifierUsername { get; set; }
/// <summary>
/// ID of the employee  
/// </summary>
public int? LastModifierEmployeeID { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region CustomerGroup

public class CustomerGroup : ErplyItem
{
/// <summary>
/// Customer group ID.  
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// Parent element ID.  
/// </summary>
public int? ParentID { get; set; }
public string Name { get; set; }
/// <summary>
/// Customer group price list 1.  
/// </summary>
public int? PricelistID { get; set; }
/// <summary>
/// Customer group price list 2.  
/// </summary>
public int? PricelistID2 { get; set; }
/// <summary>
/// Customer group price list 3.  
/// </summary>
public int? PricelistID3 { get; set; }
/// <summary>
/// Customer group price list 4.  
/// </summary>
public int? PricelistID4 { get; set; }
/// <summary>
/// Customer group price list 5.  
/// </summary>
public int? PricelistID5 { get; set; }
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

#region AddressType

public class AddressType : ErplyItem
{
public int? Id { get; set; }
public string Name { get; set; }
/// <summary>
/// Indicates whether this is a type of actively used addresses, or a type of archived/old addresses. Address which has a type where activelyUsed=0 cannot be used as a customer's shipping address on invoice.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ActivelyUsed { get; set; }
public string Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region DefaultCustomer

public class DefaultCustomer : ErplyItem
{
/// <summary>
/// ID of the default customer  
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Name of the customer  
/// </summary>
public string Name { get; set; }
/// <summary>
/// ID of the customer group where the customer belongs  
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Name of the customer group  
/// </summary>
public string GroupName { get; set; }
}

#endregion

#region Customer

public class Customer : ErplyItem
{
public int? CustomerID { get; set; }
public string AlreadyExists(0or1) { get; set; }
}

#endregion

#region Address

public class Address : ErplyItem
{
/// <summary>
/// ID of the created/updated address item.  
/// </summary>
public int? AddressID { get; set; }
}

#endregion

#region CustomerGroup

public class CustomerGroup : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? CustomerGroupID { get; set; }
}

#endregion

#region verifyCustomerUser

public class verifyCustomerUser : ErplyItem
{
/// <summary>
/// ID of the customer in customer registry  
/// </summary>
public int? ClientID { get; set; }
/// <summary>
/// customer's username (the same that was used for logging in)  
/// </summary>
public string ClientUsername { get; set; }
/// <summary>
/// Full name of the customer  
/// </summary>
public string ClientName { get; set; }
/// <summary>
/// Customer's given name  
/// </summary>
public string ClientFirstName { get; set; }
/// <summary>
/// Customer's surname  
/// </summary>
public string ClientLastName { get; set; }
/// <summary>
/// ID of the customer group where the user belongs  
/// </summary>
public int? ClientGroupID { get; set; }
/// <summary>
/// name of the customer group  
/// </summary>
public string ClientGroupName { get; set; }
/// <summary>
/// ID of company (if user is a contact person of a particular company)  
/// </summary>
public int? CompanyID { get; set; }
public string CompanyName { get; set; }
}

#endregion

#endregion
#region Sales

#region SalesDocument

public class SalesDocument : ErplyItem
{
/// <summary>
/// invoice ID  
/// </summary>
public int? Id { get; set; }
/// <summary>
/// INVWAYBILL, CASHINVOICE, WAYBILL, PREPAYMENT, OFFER, EXPORTINVOICE, RESERVATION, CREDITINVOICE, ORDER or INVOICE  
/// </summary>
public string Type { get; set; }
/// <summary>
/// Used only if document type is EXPORTINVOICE. Value: EU or NOTEU  
/// </summary>
public string ExportInvoiceType { get; set; }
/// <summary>
/// Currency code: EUR, USD.  
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the invoice currency against system's default currency.  
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// ID of the warehouse from which goods are sold.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Name of the warehouse.  
/// </summary>
public string WarehouseName { get; set; }
/// <summary>
/// Point of sale ID.  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Point of sale name.  
/// </summary>
public string PointOfSaleName { get; set; }
public int? PricelistID { get; set; }
public string Number { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Inventory transaction date.
/// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
/// Inventory Reports and COGS reports are based on the inventory transaction date.  
/// </summary>
public string InventoryTransactionDate { get; set; }
/// <summary>
/// eg. 14:59:00  
/// </summary>
public string Time { get; set; }
/// <summary>
/// Customer ID. Each invoice is always associated with a customer. See getCustomers.
/// Please note that the semantic meaning of "customer" may differ from one account to another. On older accounts, the "Customer" effectively means "recipient of goods", and it is additionally possible to define a "payer", but this is not required. (If not set, then the specified customer is both the payer as well as the recipient.)
/// On newer accounts, the "Customer" effectively means "payer", and it is possible to define a recipient (field "Ship to"), but this is not required. Hence, the roles have been reversed.
/// This will affect you if you have a standard integration used on multiple accounts, and you need to be able to set both payers and recipients. At the moment there is no way to process the output of getSalesDocuments with the same approach on all accounts; you need to inspect account configuration and tailor your processing logic accordingly.
/// Call getConfParameters and check the value of configuration parameter "invoice_client_is_payer".
/// If it is 1, then:
/// Payer can be found from the field clientID;
/// Recipient, if it has been specified, can be found from the field shipToID.
/// If the value of the parameter is 0 or it has not been defined, then:
/// Recipient can be found from the field customerID;
/// Payer, if defined, can be found from the field payerID.
/// Fields "addressID", "payerAddressID" and "shipToAddressID" should be interpreted according to the same pattern.
/// Future API versions may get a uniform way of addressing recipients and payers.
/// </summary>
public int? ClientID { get; set; }
/// <summary>
/// Customer name.  
/// </summary>
public string ClientName { get; set; }
/// <summary>
/// Customer e-mail address.  
/// </summary>
public string ClientEmail { get; set; }
/// <summary>
/// Code of customer's loyalty/membership card. This corresponds to the "customerCardNumber" field in API call getCustomers.  
/// </summary>
public string ClientCardNumber { get; set; }
/// <summary>
/// ID of customer's address on this invoice.  
/// </summary>
public int? AddressID { get; set; }
/// <summary>
/// Customer's address — full address, formatted.  
/// </summary>
public string Address { get; set; }
/// <summary>
/// Indicates this customer pays invoices via factoring. (This is a flag you can set on customer card.)  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ClientPaysViaFactoring { get; set; }
/// <summary>
/// This field only appears if your account has a "Payer" field on invoice form. See the longer explanation above.
/// Invoice payer ("Bill To") — if different from the receiver of goods.
/// If payer and recipient are the same, the "Payer" field in ERPLY is typically left empty, and fields "payerID", "payerName", "payerAddressID", "payerAddress", "payerPaysViaFactoring" in API output will not contain any values.
/// </summary>
public int? PayerID { get; set; }
/// <summary>
/// Invoice payer name.
/// This field only appears if your account has a "Payer" field on invoice form. See the longer explanation above.
/// </summary>
public string PayerName { get; set; }
/// <summary>
/// Invoice bill-to address ID.
/// This field only appears if your account has a "Payer" field on invoice form. See the longer explanation above.
/// </summary>
public int? PayerAddressID { get; set; }
/// <summary>
/// Invoice bill-to address — full address, formatted.
/// This field only appears if your account has a "Payer" field on invoice form. See the longer explanation above.
/// </summary>
public string PayerAddress { get; set; }
/// <summary>
/// Indicates this customer pays invoices via factoring. (This is a flag you can set on customer card.)
/// Possible value: 0 or 1.
/// This field only appears if your account has a "Payer" field on invoice form. See the longer explanation above.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PayerPaysViaFactoring { get; set; }
/// <summary>
/// This field only appears if your account has a "Ship To" field on invoice form. See the longer explanation above.
/// The recipient of goods ("Ship To") - if different from the payer.
/// If the recipient and payer are the same person, the "Ship To" field in ERPLY is typically left empty, and fields "shipToID", "shipToAddressId", "shipToAddress" in API output will not contain any values.
/// </summary>
public int? ShipToID { get; set; }
/// <summary>
/// Name of the receiver of goods.
/// This field only appears if your ERPLY account has a "Ship To" field on invoice form. See the longer explanation above.
/// </summary>
public string ShipToName { get; set; }
/// <summary>
/// The address ID of the receiver of goods.
/// This field only appears if your ERPLY account has a "Ship To" field on invoice form. See the longer explanation above.
/// </summary>
public int? ShipToAddressID { get; set; }
/// <summary>
/// Invoice ship-to address — full address, formatted.
/// This field only appears if your ERPLY account has a "Ship To" field on invoice form. See the longer explanation above.
/// </summary>
public string ShipToAddress { get; set; }
public int? ContactID { get; set; }
public string ContactName { get; set; }
/// <summary>
/// Invoice (order, quote) creator ID.  
/// </summary>
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
public int? ProjectID { get; set; }
/// <summary>
/// PENDING, READY, MAILED, PRINTED, SHIPPED, FULFILLED or CANCELLED  
/// </summary>
public string InvoiceState { get; set; }
/// <summary>
/// Expected invoice payment method: eg. CASH, CARD, TRANSFER, CHECK, GIFTCARD.
/// This is just an informative field, indicating how the customer will likely pay the invoice. For more accurate information and for reporting, you need to inspect the payments associated with this document. An invoice can have many payments (of different types).
/// A list of invoice payment methods can be retrieved with getInvoicePaymentTypes. To create your own custom methods (and assign code names if needed), see saveInvoicePaymentType.  
/// </summary>
public string PaymentType { get; set; }
/// <summary>
/// Payment method ID. This provides exactly the same information as field paymentType above — but as an ID, not a code name.  
/// </summary>
public int? PaymentTypeID { get; set; }
/// <summary>
/// In how many days the invoice is due.  
/// </summary>
public int? PaymentDays { get; set; }
/// <summary>
/// Invoice payment status.
/// Possible values: PAID, UNPAID.  
/// </summary>
public string PaymentStatus { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PreviousReturnsExist { get; set; }
/// <summary>
/// Whether the discount % for discounted items should be printed on the invoice, 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PrintDiscounts { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
/// <summary>
/// Notes printed on the invoice  
/// </summary>
public string Notes { get; set; }
/// <summary>
/// Notes to be displayed on invoice form, as a notice/reminder to other users.  
/// </summary>
public string InternalNotes { get; set; }
/// <summary>
/// Invoice net total.  
/// </summary>
public float? NetTotal { get; set; }
/// <summary>
/// Invoice total tax (total VAT).
/// Please note that any possible effect from payments is ignored. If the customer has paid with a "single-purpose voucher" (as defined in EU Council Directive 2016/1065), which essentially is a gift card with VAT, then API getSalesDocuments does not show the sales document's vatTotal as being correspondingly smaller.
/// If you need the true amount of VAT for accounting purposes, you need to inspect the related payments yourself.
/// </summary>
public float? VatTotal { get; set; }
/// <summary>
/// Tax rate ID, see getVatRates
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Net total
/// </summary>
public float? Total { get; set; }
/// <summary>
/// Tax rate ID, see getVatRates
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Total VAT / tax
/// </summary>
public float? Total { get; set; }
public float? Rounding { get; set; }
/// <summary>
/// =netTotal+vatTotal+rounding  
/// </summary>
public float? Total { get; set; }
public float? Paid { get; set; }
/// <summary>
/// A custom net total for this invoice, possibly calculated by another software. For a description of how this field could be used in practice, see saveSalesDocument, field "externalNetTotal".  
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
public string TaxExemptCertificateNumber { get; set; }
public int? PackerID { get; set; }
/// <summary>
/// Sales document's reference number. If a sales document has a custom reference number, API returns this number (otherwise returns a standard generated number).  
/// </summary>
public string ReferenceNumber { get; set; }
/// <summary>
/// Sales document's custom reference number.  
/// </summary>
public string CustomReferenceNumber { get; set; }
/// <summary>
/// Total cost of all items in invoice's currency.
/// API returns this attribute if parameter "getCOGS" is specified. To get the cost in main currency multiply cost with currencyRate.  
/// </summary>
public float? Cost { get; set; }
/// <summary>
/// Documents that neither sell the goods nor reserve them in the stock — PREPAYMENT, OFFER and ORDER — can optionally still include a reservation.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ReserveGoods { get; set; }
/// <summary>
/// Until what date the reservation is kept.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ReserveGoodsUntilDate { get; set; }
/// <summary>
/// Customer requested delivery date (for the whole document).  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDate { get; set; }
public int? DeliveryTypeID { get; set; }
public string DeliveryTypeName { get; set; }
/// <summary>
/// Actual shipping date (for the whole document).  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ShippingDate { get; set; }
/// <summary>
/// Description of packing unit.  
/// </summary>
public string PackingUnitsDescription { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? TriangularTransaction { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? PurchaseOrderDone { get; set; }
public int? TransactionTypeID { get; set; }
public string TransactionTypeName { get; set; }
public int? TransportTypeID { get; set; }
public string TransportTypeName { get; set; }
public string DeliveryTerms { get; set; }
public string DeliveryTermsLocation { get; set; }
/// <summary>
/// Document type. Possible values are "DOMESTIC", "EU", "OUTSIDE_EU".  
/// </summary>
public string EuInvoiceType { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? DeliveryOnlyWhenAllItemsInStock { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
/// <summary>
/// Employee's username.  
/// </summary>
public string LastModifierUsername { get; set; }
/// <summary>
/// Sales invoice creation timestamp.
/// API returns this attribute if parameter "getAddedTimestamp" is specified.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
/// <summary>
/// URL pointing to a HTML printout version of the document.
/// This URL is valid only for 24 hours; if you want to send the invoice / order by e-mail, you must retrieve the contents of this URL and enclose it as an attachment, instead of sending the URL itself.
/// Alternatively, instead of the standard printout, you can retrieve a custom printout with API call getSalesDocumentActualReportsHTML, using an Actual Reports template of your choice.
/// </summary>
public string InvoiceLink { get; set; }
/// <summary>
/// URL pointing to a receipt-sized HTML printout version of the document.
/// For POS receipts (type = "CASHINVOICE"), both printouts are equivalent, because receipts are always printed in receipt format. The "receiptLink" URL is only necessary for documents that could be printed out either way — eg. orders and laybys.
/// This URL is valid only for 24 hours; if you want to send the invoice / order by e-mail, you must retrieve the contents of this URL and enclose it as an attachment, instead of sending the URL itself.  
/// </summary>
public string ReceiptLink { get; set; }
public float? AmountAddedToStoreCredit { get; set; }
public float? AmountPaidWithStoreCredit { get; set; }
/// <summary>
/// Appliance ID. Available only if your account is configured for appliance or vehicle repair.  
/// </summary>
public int? ApplianceID { get; set; }
/// <summary>
/// Appliance reference. Available only if your account is configured for appliance or vehicle repair.  
/// </summary>
public string ApplianceReference { get; set; }
/// <summary>
/// Assignment ID. Available only if your account is configured for appliance or vehicle repair.  
/// </summary>
public int? AssignmentID { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if your account is configured for vehicle repair.  
/// </summary>
public int? VehicleMileage { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Invoice row ID. That is a transient value, it changes every time the document is re-saved. This field has only been provided to provide an easier mapping between getSalesDocuments and getAppliedPromotionRecords.
/// </summary>
public int? RowID { get; set; }
/// <summary>
/// Product ID.
/// The item on the invoice may be either:
/// a product;
/// a service (although services are deprecated and disabled entirely on newer accounts, so most likely you can ignore that option);
/// or a free-text item (in which case both productID and serviceID are 0 and the only information is item name in the field itemName.
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Service ID.
/// Please note that services are deprecated and we recommend to use non-stock products instead.
/// </summary>
public int? ServiceID { get; set; }
/// <summary>
/// Product or service name. This may differ from the product name on product card; users have the option to overwrite name when they add the item to invoice.
/// </summary>
public string ItemName { get; set; }
/// <summary>
/// Product code.
/// </summary>
public string Code { get; set; }
/// <summary>
/// ID of VAT rate.
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Sold quantity.
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// Net sales price per item, pre-discount.
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Discount % that WILL BE SUBTRACTED from the price specified in previous parameter.
/// The algorithm is as follows:
/// discountedPrice = round((price (100 - discount) / 100), defaultDecimalPlaces)
/// lineTotal = round(discountedPrice amount), 2)
/// lineVat = round((lineTotal * (100 + vatrate) / 100), 2)
/// </summary>
public float? Discount { get; set; }
/// <summary>
/// Discounted sales price per item, VAT excluded.
/// </summary>
public float? FinalNetPrice { get; set; }
/// <summary>
/// Discounted sales price per item, VAT included.
/// </summary>
public float? FinalPriceWithVAT { get; set; }
public float? RowNetTotal { get; set; }
public float? RowVAT { get; set; }
public float? RowTotal { get; set; }
/// <summary>
/// Customer requested delivery date for this specific item.
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDate { get; set; }
/// <summary>
/// A reason for returning the item (if document is a return), or for discount (if document is a regular sale). Reasons can be listed with API call getReasonCodes.
/// </summary>
public int? ReturnReasonID { get; set; }
/// <summary>
/// Employee receiving commission on the sale of this line item.
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// A comma-separated list of campaigns (sales promotions) that have been applied to this invoice row. Needed for reporting.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> CampaignIDs { get; set; }
/// <summary>
/// ID of another product, a beverage container that is always sold together with this item.
/// </summary>
public int? ContainerID { get; set; }
/// <summary>
/// Number of beverage containers that this product contains.
/// </summary>
public int? ContainerAmount { get; set; }
/// <summary>
/// Indicates that this product has a zero price on product card.
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? OriginalPriceIsZero { get; set; }
/// <summary>
/// Package ID, if the item has been sold in packages. To retrieve the packages of a particular product, see getProducts, block "productPackages".
/// </summary>
public int? PackageID { get; set; }
/// <summary>
/// Amount of packages
/// </summary>
public float? AmountOfPackages { get; set; }
/// <summary>
/// Amount of products contained in one package
/// </summary>
public float? AmountInPackage { get; set; }
/// <summary>
/// Readable package type name
/// </summary>
public string PackageType { get; set; }
/// <summary>
/// Type ID of the package.
/// </summary>
public int? PackageTypeID { get; set; }
/// <summary>
/// Source document ID. Only appears on document types CREDITINVOICE and INVOICE. Indicates which waybill this row originated from (if this invoice has been created from one or more waybills).
/// </summary>
public int? SourceWaybillID { get; set; }
/// <summary>
/// Recurring billing ID, if this invoice line is associated with a recurring billing.
/// In back office, recurring billings can be found in Sales → Recurring billing and the billings can be retrieved with API call getBillingStatements.
/// </summary>
public int? BillingStatementID { get; set; }
/// <summary>
/// Related to previous field.
/// Start date of the period for which customer was billed.
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? BillingStartDate { get; set; }
/// <summary>
/// Related to previous field.
/// End date of the period for which the customer was billed.
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? BillingEndDate { get; set; }
/// <summary>
/// Alcohol batch number.
/// This field is returned only when Alcohol Wholesaling module is enabled.
/// </summary>
public string Batch { get; set; }
/// <summary>
/// Product unit cost in invoice's currency.
/// API returns this attribute if parameter getCOGS is specified.
/// It is the weighted average of each individual item that has been subtracted from inventory using the FIFO principle. To get the cost in main currency multiply cost with currencyRate.
/// </summary>
public string WarehouseValue { get; set; }
}

#endregion

#region Service

public class Service : ErplyItem
{
public int? ServiceID { get; set; }
public string Code { get; set; }
/// <summary>
/// ID of service unit. To get the list of units, use getProductUnits.  
/// </summary>
public int? UnitID { get; set; }
public string UnitName { get; set; }
/// <summary>
/// ID of VAT (tax) rate. To get the list of rates, use getVatRates.  
/// </summary>
public int? VatrateID { get; set; }
public string Vatrate { get; set; }
public int? GroupID { get; set; }
/// <summary>
/// Is this option meant to show on webshop as delivery option.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? WebshopTransportOption { get; set; }
public string Name { get; set; }
public string Description { get; set; }
public float? Price { get; set; }
public float? PriceWithVat { get; set; }
/// <summary>
/// 1 if this item has a quick-select button in POS  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? HasQuickSelectButton { get; set; }
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

#region Warehouse

public class Warehouse : ErplyItem
{
public int? WarehouseID { get; set; }
/// <summary>
/// Store / location / warehouse name.  
/// </summary>
public string Name { get; set; }
/// <summary>
/// Location / warehouse code. This may be useful for integration purposes.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// ID of the location address. This refers to one of the addresses you have defined on company card.  
/// </summary>
public int? AddressID { get; set; }
/// <summary>
/// Full address, formatted. This is the same address that the above ID refers to.  
/// </summary>
public string Address { get; set; }
/// <summary>
/// Street address (or more generally, address line 1).  
/// </summary>
public string Street { get; set; }
/// <summary>
/// Street address, line 2. This field is exposed via Erply user interface only for US, CA, AU, MX, DE, AT and CH accounts!  
/// </summary>
public string Address2 { get; set; }
/// <summary>
/// City, region, or county.  
/// </summary>
public string City { get; set; }
/// <summary>
/// Postal code or ZIP code.(deprecated alternative name: postcode)  
/// </summary>
public string ZIPcode { get; set; }
/// <summary>
/// State. This field is exposed via Erply user interface only for US, CA, AU, MX, DE, AT and CH accounts!  
/// </summary>
public string State { get; set; }
/// <summary>
/// Country.  
/// </summary>
public string Country { get; set; }
/// <summary>
/// Company name.
/// Typically you should not customize your company name per-location. This may be needed only if the location is a different corporate entity (your business is a franchise chain that operates in a single ERPLY account, instead of using a separate account for each entity).
/// The corresponding field in API getCompanyInfo is "name".  
/// </summary>
public string CompanyName { get; set; }
/// <summary>
/// Company registration number.
/// Typically the registration number does not vary per-location, see the comments above.
/// The corresponding field in API getCompanyInfo is "code".  
/// </summary>
public string CompanyCode { get; set; }
/// <summary>
/// Company VAT number.
/// Typically the VAT number does not vary per-location, see the comments above.
/// The corresponding field in API getCompanyInfo is "VAT".  
/// </summary>
public string CompanyVatNumber { get; set; }
/// <summary>
/// Location phone number.  
/// </summary>
public string Phone { get; set; }
/// <summary>
/// Location fax number.  
/// </summary>
public string Fax { get; set; }
/// <summary>
/// Location e-mail address.  
/// </summary>
public string Email { get; set; }
/// <summary>
/// Location website address.  
/// </summary>
public string Website { get; set; }
/// <summary>
/// Name of bank (where this location has a bank account).  
/// </summary>
public string BankName { get; set; }
/// <summary>
/// Bank account number.  
/// </summary>
public string BankAccountNumber { get; set; }
/// <summary>
/// IBAN (international bank account number).  
/// </summary>
public string Iban { get; set; }
/// <summary>
/// Bank's BIC/SWIFT identifier.  
/// </summary>
public string Swift { get; set; }
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
/// Warehouse first price list.  
/// </summary>
public int? PricelistID { get; set; }
/// <summary>
/// Warehouse second price list.  
/// </summary>
public int? PricelistID2 { get; set; }
/// <summary>
/// Warehouse third price list.  
/// </summary>
public int? PricelistID3 { get; set; }
/// <summary>
/// Warehouse fourth price list.  
/// </summary>
public int? PricelistID4 { get; set; }
/// <summary>
/// Warehouse fifth price list.  
/// </summary>
public int? PricelistID5 { get; set; }
/// <summary>
/// A comma-separated list of store groups.  
/// </summary>
public string StoreGroups { get; set; }
public int? DefaultCustomerGroupID { get; set; }
/// <summary>
/// Salon-specific attribute. Available only if Salon / Spa module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? OnlineAppointmentsEnabled { get; set; }
/// <summary>
/// Shows if this warehouse has been assigned to be an "offline location" for another store. ("Offline inventory" or "offline location" is typically where the returned items are placed; they will go through inspection and will be moved either back to the store, or written off.)  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsOfflineInventory { get; set; }
/// <summary>
/// Time zone of this location. This field is populated only if the time zone is different from the account's main time zone. To get the account's main timezone use the API call getConfParameters.  
/// </summary>
public string TimeZone { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region AllowedWarehous

public class AllowedWarehous : ErplyItem
{
/// <summary>
/// ID of the warehouse  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Name of the warehouse  
/// </summary>
public string Name { get; set; }
}

#endregion

#region Employee

public class Employee : ErplyItem
{
/// <summary>
/// (deprecated alternative name: id)  
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Full name of the customer, use for displaying customer name.  
/// </summary>
public string FullName { get; set; }
/// <summary>
/// For companies only.  
/// </summary>
public string EmployeeName { get; set; }
/// <summary>
/// (Given name.) For persons only.  
/// </summary>
public string FirstName { get; set; }
/// <summary>
/// (Surname.) For persons only.  
/// </summary>
public string LastName { get; set; }
public string Phone { get; set; }
public string Mobile { get; set; }
public string Email { get; set; }
public string Fax { get; set; }
/// <summary>
/// National ID number  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Gender: "male", "female" or empty string  
/// </summary>
public string Gender { get; set; }
/// <summary>
/// If employee does not have user account, this attribute is not returned.  
/// </summary>
public int? UserID { get; set; }
/// <summary>
/// If employee does not have user account, this attribute is not returned.  
/// </summary>
public string Username { get; set; }
/// <summary>
/// If employee does not have user account, this attribute is not returned.  
/// </summary>
public int? UserGroupID { get; set; }
/// <summary>
/// DO NOT USE - NOT A STANDARD FIELD. Indicates whether this employee performs coloring.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PerformsColoring { get; set; }
/// <summary>
/// Warehouse ID
/// </summary>
public int? Id { get; set; }
/// <summary>
/// A comma-separated list of registers (Point of sale IDs) in which the employee is working.
/// In other words, the registers for which the employee has access rights.
/// Attributes warehouses and pointsOfSale both show basically the same information, because user rights are defined per-location. Using pointsOfSale just saves you the trouble of looking up register IDs for each location.  
/// </summary>
public string PointsOfSale { get; set; }
/// <summary>
/// Product (service) ID
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Product (service) code
/// </summary>
public string ProductCode { get; set; }
/// <summary>
/// Product (service) name
/// </summary>
public string ProductName { get; set; }
/// <summary>
/// Product (service) group
/// </summary>
public int? ProductGroup { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Last modification time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
public string LastModifiedByUserName { get; set; }
public string Skype { get; set; }
/// <summary>
/// Person's birthday  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Birthday { get; set; }
/// <summary>
/// Person's job title ID  
/// </summary>
public int? JobTitleID { get; set; }
public string JobTitleName { get; set; }
public string Notes { get; set; }
/// <summary>
/// Creation time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
}

#endregion

#region Project

public class Project : ErplyItem
{
/// <summary>
/// Project ID.  
/// </summary>
public int? ProjectID { get; set; }
/// <summary>
/// Project name.  
/// </summary>
public string Name { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer name.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// Project manager ID.  
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Name of project manager.  
/// </summary>
public string EmployeeName { get; set; }
/// <summary>
/// Project type ID.  
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Name of project type.  
/// </summary>
public string TypeName { get; set; }
/// <summary>
/// Project status ID.  
/// </summary>
public int? StatusID { get; set; }
/// <summary>
/// Name of project status.  
/// </summary>
public string StatusName { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDate { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDate { get; set; }
/// <summary>
/// Notes.  
/// </summary>
public string Notes { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
}

#endregion

#region PointsOfSale

public class PointsOfSale : ErplyItem
{
public int? PointOfSaleID { get; set; }
public string Name { get; set; }
/// <summary>
/// ID of the warehouse  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Name of the warehouse  
/// </summary>
public string WarehouseName { get; set; }
public string Address { get; set; }
public string Phone { get; set; }
/// <summary>
/// Opening hours  
/// </summary>
public string StoreHours { get; set; }
/// <summary>
/// Latitude (geographical location)  
/// </summary>
public float? GeoLatitude { get; set; }
/// <summary>
/// Longitude (geographical location)  
/// </summary>
public float? GeoLongitude { get; set; }
/// <summary>
/// Card payment terminal / card swiper  
/// </summary>
public int? PaymentServiceProvider { get; set; }
public float? ReceiptWidth { get; set; }
/// <summary>
/// Default VAT (tax) rate ID in this register.
/// NB! In ERPLY there is a whole hierarchy of tax rates, and rules for applying these tax rates. POS default tax rate is just one possible rule; tax rate may also be set at product level, location level, or product group level. Finally, certain customers may be marked as tax exempt, and there are different multi-tier tax rates.
/// You should use API call calculateShoppingCart to retrieve the appropriate tax rate for a specific customer and product in a specific location.  
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Default VAT (tax) rate percentage. See above.  
/// </summary>
public float? Vatrate { get; set; }
/// <summary>
/// Multi-tier tax: threshold for Tier 2 tax. See a commoent about tax rates above.  
/// </summary>
public int? VatSumRange1 { get; set; }
/// <summary>
/// Multi-tier tax: Tier 2 tax percentage.  
/// </summary>
public int? VatrateIDrange1 { get; set; }
/// <summary>
/// Multi-tier tax: threshold for Tier 3 tax. See a commoent about tax rates above.  
/// </summary>
public int? VatSumRange2 { get; set; }
/// <summary>
/// Multi-tier tax: Tier 3 tax percentage.  
/// </summary>
public int? VatrateIDrange2 { get; set; }
/// <summary>
/// Print salesperson's name on receipt  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PrintSalesPersonName { get; set; }
/// <summary>
/// Shop name on customer display  
/// </summary>
public string ShopName { get; set; }
public int? DefaultCustomerID { get; set; }
/// <summary>
/// Whether customers are allowed to use store credit in this POS.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? StoreCreditEnabled { get; set; }
/// <summary>
/// For Windows Point Of Sale / Touch POS. Last invoice number issued by the POS application. POS application uses this field to continue correct numbering after reinstall/reload.
/// You may also use these numbers for your own API application (eg. a webshop), provided that you are NOT using our Windows Point Of Sale software. The correct way to use this field is to take the provided number and add 1 to it.
/// A separate number series is used, different from the one in Erply backend. The numbers consist of 8+ digits (a register ID prefix + number sequence 1,000,000...3,999,999).  
/// </summary>
public int? LastInvoiceNo { get; set; }
/// <summary>
/// For Windows Point Of Sale only. Last coupon number issued by Windows Point Of Sale. The Windows application uses this field to continue correct numbering after reinstall.  
/// </summary>
public int? LastCouponNo { get; set; }
/// <summary>
/// ID of a product
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// ID of the service
/// </summary>
public int? ServiceID { get; set; }
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
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region PriceList

public class PriceList : ErplyItem
{
public int? PricelistID { get; set; }
public string Name { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string StartDate { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string EndDate { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Price list type, possible types are 'BASE_PRICE_LIST', 'STORE_PRICE_LIST'.
/// This field is returned only if the "Price list types" module has been enabled on your account. Contact customer support to enable that feature.
/// </summary>
public string Type { get; set; }
/// <summary>
/// Creation time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string AddedByUserName { get; set; }
/// <summary>
/// Last modification time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
public string LastModifiedByUserName { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region VatRate

public class VatRate : ErplyItem
{
public int? Id { get; set; }
/// <summary>
/// For displaying purposes. If rate = 20, then name may be "20%", for example.  
/// </summary>
public string Name { get; set; }
public float? Rate { get; set; }
/// <summary>
/// Corresponding VAT code in accounting software.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// 0 for archived taxes, 1 for active taxes.  
/// </summary>
public int? Active { get; set; }
/// <summary>
/// 0 for regular taxes, 1 for reverse taxes.
/// Reverse VAT is a concept used in Europe. It means that in certain cases, the obligation to pay VAT (value-added tax) lies on the buyer, not the seller. A seller can issue an invoice where one or multiple lines are subject to reverse VAT. This amount of VAT must then be paid by the buyer directly to the Tax Department, and this VAT amount is not included in the total sum payable to the seller.
/// The rate of a reverse VAT can be found from the field reverseRate.
/// </summary>
public int? IsReverseVat { get; set; }
/// <summary>
/// The rate of a reverse VAT.
/// A tax can only have reverseRate (if it is Reverse VAT) or rate (if it is a regular tax), but not both at the same time.
/// </summary>
public float? ReverseRate { get; set; }
/// <summary>
/// Canada-specific field, contains ID of corresponding reduced tax rate, for GST-exempt customers.  
/// </summary>
public int? GstExemptTaxRateID { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// ZIP code signifying the area where this tax rate is used (if you have defined it when creating the tax rate).  
/// </summary>
public string ZIPCode { get; set; }
/// <summary>
/// Category of this tax rate (generally not used).  
/// </summary>
public string Category { get; set; }
/// <summary>
/// State name.  
/// </summary>
public string State { get; set; }
/// <summary>
/// County name.  
/// </summary>
public string County { get; set; }
/// <summary>
/// City name.  
/// </summary>
public string City { get; set; }
public int? ComponentID { get; set; }
/// <summary>
/// Possible types are:
/// STATE
/// COUNTY
/// CITY
/// OTHER
/// </summary>
public string Type { get; set; }
/// <summary>
/// Name for displaying purposes.
/// </summary>
public string Name { get; set; }
/// <summary>
/// Tax percentage.
/// </summary>
public float? Rate { get; set; }
}

#endregion

#region Currency

public class Currency : ErplyItem
{
public int? CurrencyID { get; set; }
public string Code { get; set; }
/// <summary>
/// Example "US dollar"  
/// </summary>
public string Name { get; set; }
/// <summary>
/// Currency rate in relation to default currency  
/// </summary>
public float? Rate { get; set; }
/// <summary>
/// 1 if yes, 0 if no. Only one currency can be default  
/// </summary>
public int? Default { get; set; }
/// <summary>
/// Example "dollars".  
/// </summary>
public string NameShort { get; set; }
/// <summary>
/// Example "cents"  
/// </summary>
public string NameFraction { get; set; }
public string Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region Campaign

public class Campaign : ErplyItem
{
public int? CampaignID { get; set; }
/// <summary>
/// Promotion start date.  
/// </summary>
public string StartDate { get; set; }
/// <summary>
/// Promotion end date.  
/// </summary>
public string EndDate { get; set; }
public string Name { get; set; }
/// <summary>
/// Describes the way promotion is applied. Possible values:
/// auto - Promotion is applied automatically to all customers, based on rules below. No coupons needed.
/// manual - Cashier selects the promotion manually. (Cashier must have relevant rights - getUserRights must return rightApplyPromotions = 1)
/// coupon - Promotion is applied when user hands in a printed coupon with a serial number.
/// </summary>
public string Type { get; set; }
/// <summary>
/// If this field has a value other than 0, the promotion is available only in a specific store.
/// "warehouseID", "storeRegions" and "storeGroup" are mutually exclusive: only one restriction is supposed to apply at a time.
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// If this field has a value, the promotion is available only in a specific store group.
/// "warehouseID", "storeRegions" and "storeGroup" are mutually exclusive: only one restriction is supposed to apply at a time.
/// "Store group" is a text field on location form.
/// </summary>
public string StoreGroup { get; set; }
/// <summary>
/// Store region ID
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Customer group ID
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Indicates that it is possible to apply this promotion manually multiple times.
/// This depends on the structure of the promotion. Some kinds of promotions support multiple application; for others it is not supported or it would not make sense. The flag is always 0 for non-manual (automatic or coupon-activated) promotions, for one-time promotions and one-time birthday promotions.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CanBeAppliedManuallyMultipleTimes { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public float? Subsidy { get; set; }
/// <summary>
/// DEPRECATED — subsidy is recommended instead. Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public float? SubsidyValue { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public int? SubsidyTypeID { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public int? Page { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public int? PositionOnPage { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public int? ForecastUnits { get; set; }
public float? PurchaseTotalValue { get; set; }
public int? PurchasedProductGroupID { get; set; }
public int? PurchasedProductCategoryID { get; set; }
public int? PurchasedAmount { get; set; }
public int? RewardPoints { get; set; }
/// <summary>
/// If this field is set, then the promotion rule does not apply automatically, but only when customer hands in a particular coupon.  
/// </summary>
public int? RequiredCouponID { get; set; }
/// <summary>
/// Code of the abovementioned coupon.  
/// </summary>
public string RequiredCouponCode { get; set; }
/// <summary>
/// If this field more than zero the customer must buy a certain number of items with item price more or equal to this value, doesnt work with total value or reward points.  
/// </summary>
public float? PriceAtLeast { get; set; }
/// <summary>
/// If this field more than zero the customer must buy a certain number of items with item price more or equal to this value, doesnt work with total value or reward points.  
/// </summary>
public float? PriceAtMost { get; set; }
/// <summary>
/// If set to 1, indicates that this is a manual promotion that can be applied to a sale with store manager's approval only. API client (POS) must implement the approval process itself; it is not enforced by API.  
/// </summary>
public int? RequiresManagerOverride { get; set; }
/// <summary>
/// This promotion gives a percentage discount on the entire sale.  
/// </summary>
public float? PercentageOffEntirePurchase { get; set; }
/// <summary>
/// This flag applies to promotions "% off entire sale", so you should inspect it only if percentageOffEntirePurchase contains a non-zero value.
/// Indicates that the promotion should not apply to items that have already received any discount from a price list, a manual discount by the cashier, or a discount from any preceding promotion (both item-level and invoice-level promotions).
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? ExcludeDiscountedFromPercentageOffEntirePurchase { get; set; }
public float? SumOffEntirePurchase { get; set; }
public int? PercentageOffMatchingItems { get; set; }
public float? SumOffMatchingItems { get; set; }
public float? SpecialPrice { get; set; }
public int? AwardedProductGroupID { get; set; }
public int? AwardedProductCategoryID { get; set; }
/// <summary>
/// In promotion "% or $ off of specific products", how many items should get the discount. Fulfilling the promotion conditions may entitle the customer to one discounted item (awardedAmount = 1), or at most N discounted items (awardedAmount > 1), or an unlimited number of items (awardedAmount = 0). The "unlimited" option may be used in promotions such as "First item costs $3, subsequent ones are $2 each".  
/// </summary>
public int? AwardedAmount { get; set; }
/// <summary>
/// Reason Code ID that is associated with this promotion.  
/// </summary>
public int? ReasonID { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? LowestPriceItemIsAwarded { get; set; }
public float? PercentageOFF { get; set; }
public float? DiscountForOneLine { get; set; }
/// <summary>
/// Possible values: 0 or 1. Available only if Optionally Disable Promotions module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Enabled { get; set; }
public float? SumOFF { get; set; }
/// <summary>
/// This setting only applies to promotions that look like "Get $1 of discount for 1 loyalty point". This setting makes sure that regardless of the number of points the customer has, the points can only be exchanged for a limited amount of discount (a specified % of invoice total).  
/// </summary>
public float? MaximumPointsDiscount { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? CustomerCanUseOnlyOnce { get; set; }
/// <summary>
/// New unit price.  
/// </summary>
public float? SpecialUnitPrice { get; set; }
/// <summary>
/// Maximum limit how many items can be purchased with this special unit price.  
/// </summary>
public int? MaxItemsWithSpecialUnitPrice { get; set; }
/// <summary>
/// Maximum limit how many times the promotion can be applied to one sale.  
/// </summary>
public int? RedemptionLimit { get; set; }
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
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region Payment

public class Payment : ErplyItem
{
public int? PaymentID { get; set; }
/// <summary>
/// ID of the invoice that was paid. It is not possible to associate a payment with more than 1 invoice; in that case, the payment should be split into parts.  
/// </summary>
public int? DocumentID { get; set; }
/// <summary>
/// ID of the customer who made the payment. In most cases, it should be the same as the customer who received the invoice.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Payment type ID. See getPaymentTypes.  
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Payment type code name. It corresponds to the type ID above, but especially with standard payment types (cash payment, card payment etc.) the code name is easier to identify.
/// Standard code names recognized by ERPLY are CASH, TRANSFER (for wire transfer), CARD, CREDIT, GIFTCARD, CHECK, TIP — but you can also create your own custom code names with savePaymentType.
/// "CREDIT" means "paid with a credit invoice", this type should be used when a due amount is cleared with a credit invoice, or in case of any other balancing transaction.  
/// </summary>
public string Type { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Paid amount  
/// </summary>
public float? Sum { get; set; }
/// <summary>
/// Currency code: EUR, USD.  
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the payment currency against system's default currency.  
/// </summary>
public float? CurrencyRate { get; set; }
public float? CashPaid { get; set; }
public float? CashChange { get; set; }
/// <summary>
/// Information about the payer. Deprecated name: "receipt_payer".  
/// </summary>
public string Info { get; set; }
/// <summary>
/// Cardholder's name (for card payments only).
/// The same field is also returned as an attribute, named "cardholder_name". If you want to update this field using API call savePayment, you should pass the new value through "cardholder_name" attribute.  
/// </summary>
public string CardHolder { get; set; }
/// <summary>
/// Last 4 digits of credit card number (for card payments only). Erply does not store full credit card numbers.
/// The same field is also returned as an attribute, named "card_number". If you want to update this field using API call savePayment, you should pass the new value through "card_number" attribute.  
/// </summary>
public string CardNumber { get; set; }
/// <summary>
/// Credit card type, eg. VISA, AMEX, M/C etc. (for card payments only). Erply's Z Report displays card payments separately by type.
/// The same field is also returned as an attribute, named "card_type". If you want to update this field using API call savePayment, you should pass the new value through "card_type" attribute.  
/// </summary>
public string CardType { get; set; }
/// <summary>
/// Card payment authorization code.
/// The same field is also returned as an attribute, named "authCode". If you want to update this field using API call savePayment, you should pass the new value through "authCode" attribute.  
/// </summary>
public string AuthorizationCode { get; set; }
/// <summary>
/// Card payment reference number.
/// The same field is also returned as an attribute, named "refNo". If you want to update this field using API call savePayment, you should pass the new value through "refNo" attribute.  
/// </summary>
public string ReferenceNumber { get; set; }
/// <summary>
/// A flag indicating whether this payment has originally been a prepayment (meaning that it was associated with a Prepayment Invoice or a Sales Order). If the payment is currently associated with a Prepayment Invoice, or a Sales Order, it does not have this flag! The flag is only applied by ERPLY back office when a payment is transferred from a Prepayment Invoice / Sales Order to an Invoice or an Invoice-Waybill.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsPrepayment { get; set; }
public int? BankTransactionID { get; set; }
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
public string ***** { get; set; }
/// <summary>
/// A flag indicating that this payment was once a part of customer's store credit (a pending prepayment, not associated with any invoice), but it has now been applied to a particular invoice. Customer used his/her "store credit" to pay off this invoice.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? StoreCredit { get; set; }
/// <summary>
/// API only returns this field if "Cayan / Merchant Warehouse payment data" (returns "merchant_warehouse"), "PAX payment data" (returns "pax"), "Tyro payment data" (returns "tyro") or "Givex payment data" (returns "givex) module is enabled on your account.  
/// </summary>
public int? PaymentServiceProvider { get; set; }
/// <summary>
/// API only returns this field if "Cayan / Merchant Warehouse payment data" or "PAX payment data" module is enabled on your account.  
/// </summary>
public int? Aid { get; set; }
/// <summary>
/// API only returns this field if "Cayan / Merchant Warehouse payment data" or "PAX payment data" module is enabled on your account.  
/// </summary>
public string ApplicationLabel { get; set; }
/// <summary>
/// API only returns this field if "Cayan / Merchant Warehouse payment data" module is enabled on your account.  
/// </summary>
public string PinStatement { get; set; }
/// <summary>
/// API only returns this field if "Cayan / Merchant Warehouse payment data" module is enabled on your account.  
/// </summary>
public string CryptogramType { get; set; }
/// <summary>
/// API only returns this field if "Cayan / Merchant Warehouse payment data" module is enabled on your account.  
/// </summary>
public string Cryptogram { get; set; }
/// <summary>
/// API only returns this field if "Cayan / Merchant Warehouse payment data" or "Givex payment data" module is enabled on your account.  
/// </summary>
public string ExpirationDate { get; set; }
/// <summary>
/// API only returns this field if "PAX payment data" module is enabled on your account.  
/// </summary>
public string EntryMethod { get; set; }
/// <summary>
/// API only returns this field if "PAX payment data" module is enabled on your account.  
/// </summary>
public string TransactionType { get; set; }
/// <summary>
/// API only returns this field if "PAX payment data" module is enabled on your account.  
/// </summary>
public string TransactionNumber { get; set; }
/// <summary>
/// API only returns this field if "Tyro payment data" module is enabled on your account.  
/// </summary>
public int? TransactionId { get; set; }
/// <summary>
/// API only returns this field if "Givex payment data" module is enabled on your account.  
/// </summary>
public string TransactionType { get; set; }
/// <summary>
/// API only returns this field if "Transaction Time of a Payment" module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? TransactionTime { get; set; }
/// <summary>
/// API only returns this field if "Klarna payment data" module is enabled on your account.  
/// </summary>
public int? KlarnaPaymentID { get; set; }
/// <summary>
/// API only returns this field if "Givex payment data" module is enabled on your account.  
/// </summary>
public float? CertificateBalance { get; set; }
/// <summary>
/// API only returns this field if "Givex payment data" module is enabled on your account.  
/// </summary>
public int? StatusCode { get; set; }
/// <summary>
/// API only returns this field if "Givex payment data" module is enabled on your account.  
/// </summary>
public string StatusMessage { get; set; }
/// <summary>
/// On payments with type = "GIFTCARD", this value indicates the tax rate (VAT rate) the gift card was originally sold with. On payments of any other type, the value will presumably be always 0.
/// If the value is 0, you may assume that the gift card was sold without tax. (Historically, this was the only option that Erply supported.) Support for taxed gift cards has been added due to the EU Council Directive 2016/1065, which defines the concept of "single-purpose vouchers".
/// If customer has redeemed a gift card with tax, it means that on the sales transaction associated with this payment, taxable total and amount of tax should be correspondingly regarded smaller. (Please note that getSalesDocuments itself does not report that information.)
/// The full workflow (selling gift cards with tax and redeeming them properly) requires Berlin POS.
/// </summary>
public int? GiftCardVatRateID { get; set; }
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
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region PaymentType

public class PaymentType : ErplyItem
{
/// <summary>
/// Payment type ID.  
/// </summary>
public int? Id { get; set; }
/// <summary>
/// A code name for this payment type.
/// In savePayment and getPayments API calls, you can refer to a payment type either by ID or by code name. Code name may be more convenient when working with standard payment types (CASH, CARD etc.). However, you can also give code names to your own custom payment methods.
/// Standard types that ERPLY recognizes (there may be standard functionality attached to payments of these type) are: CASH, CARD, CREDIT, GIFTCARD, CHECK, TRANSFER, TIP.  
/// </summary>
public string Type { get; set; }
/// <summary>
/// Payment type name  
/// </summary>
public string Name { get; set; }
/// <summary>
/// Name on receipt  
/// </summary>
public string Print_name { get; set; }
/// <summary>
/// Quick Books debit account  
/// </summary>
public string QuickBooksDebitAccount { get; set; }
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

#region SalesDocument

public class SalesDocument : ErplyItem
{
/// <summary>
/// ID of the created (or updated) document  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Document number.
/// For unconfirmed sales invoices, this field will be "0" — these documents do not have a number yet, it is assigned when the invoice gets confirmed.
/// If you assigned a custom number to this sales document (one that may contain letters and other characters), the value of this field will also be "0". See the next field, customNumber, instead.  
/// </summary>
public string InvoiceNo { get; set; }
/// <summary>
/// Custom number of the document  
/// </summary>
public string CustomNumber { get; set; }
/// <summary>
/// URL pointing to a HTML version of the invoice.
/// This URL is valid only for 24 hours; if you want to send the invoice / order by e-mail, you must retrieve the contents of this URL and enclose it as an attachment, instead of sending the URL itself.
/// Alternatively, instead of the standard printout, you can retrieve a custom printout with API call getSalesDocumentActualReportsHTML, using an Actual Reports template of your choice.
/// </summary>
public string InvoiceLink { get; set; }
/// <summary>
/// URL pointing to a receipt-sized HTML printout version of the document.
/// For POS receipts (type = "CASHINVOICE"), both printouts are equivalent, because receipts are always printed in receipt format. The "receiptLink" URL is only necessary for documents that could be printed out either way — eg. orders and laybys.
/// This URL is valid only for 24 hours; if you want to send the invoice / order by e-mail, you must retrieve the contents of this URL and enclose it as an attachment, instead of sending the URL itself.
/// This URL is valid only for 24 hours; if you want to send the invoice / order by e-mail, you must retrieve the contents of this URL and enclose it as an attachment, instead of sending the URL itself.  
/// </summary>
public string ReceiptLink { get; set; }
/// <summary>
/// Net total of the invoice  
/// </summary>
public float? Net { get; set; }
/// <summary>
/// Total VAT of the invoice  
/// </summary>
public float? Vat { get; set; }
/// <summary>
/// Rounding amount applied to invoice total  
/// </summary>
public float? Rounding { get; set; }
/// <summary>
/// Invoice total (= net + vat + rounding)  
/// </summary>
public float? Total { get; set; }
}

#endregion

#region ShoppingCart

public class ShoppingCart : ErplyItem
{
/// <summary>
/// Row number
/// </summary>
public int? RowNumber { get; set; }
/// <summary>
/// Product ID
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Item quantity
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// VAT / tax rate ID
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// VAT / tax rate as a percentage.
/// </summary>
public float? VatRate { get; set; }
/// <summary>
/// Original unit net price. If you specified price manually, this is the manual price. Otherwise this is the price from price lists.
/// </summary>
public float? OriginalPrice { get; set; }
/// <summary>
/// original price (VAT included)
/// </summary>
public float? OriginalPriceWithVAT { get; set; }
/// <summary>
/// Total cumulative discount % from promotions.
/// </summary>
public float? PromotionDiscount { get; set; }
/// <summary>
/// Alias: originalDiscount.
/// Discount % that you set manually.
/// </summary>
public float? ManualDiscount { get; set; }
/// <summary>
/// Total cumulative discount: promotions + manual.
/// Note that percentages multiply! Here is an example:
/// Item price: $1
/// Promotional discount: 10%
/// Manual discount: 10%
/// ⇒ Final price:
/// $1 - 10% - 10% = $0.81
/// ⇒ Total cumulative discount: 19%.
/// </summary>
public float? Discount { get; set; }
/// <summary>
/// Final unit net price, after promotions. (= originalPrice - discount)
/// </summary>
public float? FinalPrice { get; set; }
/// <summary>
/// Final unit price with VAT / tax.
/// </summary>
public float? FinalPriceWithVAT { get; set; }
/// <summary>
/// Price-based sales tax is used in Massachusetts, US. If item price exceeds a certain threshold, then the part above threshold is taxed at a different, secondary tax rate. This is the threshold value (in dollars).
/// </summary>
public float? PriceBasedTaxThreshold { get; set; }
/// <summary>
/// Price-based sales tax. Secondary tax rate.
/// </summary>
public float? PriceBasedTaxRate { get; set; }
/// <summary>
/// Net total (unit net price, times quantity).
/// </summary>
public float? RowNetTotal { get; set; }
/// <summary>
/// Total tax or VAT.
/// </summary>
public float? RowVAT { get; set; }
/// <summary>
/// Row total with tax or VAT.
/// </summary>
public float? RowTotal { get; set; }
/// <summary>
/// Is row non-discountable. This is a summarized information about possibility to discount this item, can be used to prevent discounting actions for this item in cart interface. Non discountable cases: gift cards, products marked as non-discountable, products with product group or one of parent product groups marked as non-discountable.
/// </summary>
public int? NonDiscountable { get; set; }
/// <summary>
/// Applied promotion ID — if the applied discount was a promotion.
/// </summary>
public int? PromotionRule#campaignID# { get; set; }
/// <summary>
/// Applied price list ID — if the discount was a price list discount.
/// </summary>
public int? PromotionRule#priceListID# { get; set; }
/// <summary>
/// Applied promotion or price list name. (Empty for manual discounts.)
/// </summary>
public string PromotionRule#name# { get; set; }
/// <summary>
/// What quantity the promotion / price list applied to, on this particular invoice line. If customer bought 2 or more of this item, but only one was with promotional discount (eg. a Buy One, Get One promotion), then the returned value is 1.
/// </summary>
public int? PromotionRule#amount# { get; set; }
/// <summary>
/// Final total of the discounted items (price * quantity) immediately AFTER applying the promotion, price list or manual discount.
/// Field name is incorrect, but preserved for compatibility.
/// Note that this is not the same as line total after discount. If the discount only applied to some of the items on the line, this will be the total for these discounted items only.
/// </summary>
public float? PromotionRule#finalPrice# { get; set; }
/// <summary>
/// Total $ discount given to this invoice line.
/// </summary>
public float? PromotionRule#totalDiscount# { get; set; }
/// <summary>
/// "ITEMS" or "INVOICE". Type of the promotion, if the applied discount was a promotion.
/// "ITEMS" for line or item discounts; "INVOICE" for any discounts that applied to the whole document. (Since there is no "invoice discount" concept in ERPLY, invoice discounts need to be divided proportinally between invoice lines.)
/// </summary>
public string PromotionRule#campaignType# { get; set; }
/// <summary>
/// Dollar discount that was specified in promotion parameters — if this was a dollar discount promotion. (For example, if the promotion was "Get $20 off of all shoes", the field value is 20.)
/// </summary>
public float? PromotionRule#campaignDiscountValue# { get; set; }
/// <summary>
/// Percentage discount as it was defined in promotion description — if this was a percentage discount promotion (eg "10% off").
/// </summary>
public float? PromotionRule#campaignDiscountPercentage# { get; set; }
/// <summary>
/// "PRICE" or "DISCOUNT".
/// This field is populated only for applied price lists, not promotions.
/// "PRICE" if the price list applied a fixed price, "DISCOUNT" if the price list applied a discount percentage.
/// </summary>
public string PromotionRule#priceListDiscountType# { get; set; }
/// <summary>
/// Percentage discount as it was defined in price list — if this was a percentage discount (eg "10% off").
/// </summary>
public float? PromotionRule#priceListDiscountPercentage# { get; set; }
/// <summary>
/// Manual discount percentage — if this was a manual discount.
/// </summary>
public float? PromotionRule#manualDiscountPercentage# { get; set; }
public float? NetTotal { get; set; }
public float? VatTotal { get; set; }
public float? Rounding { get; set; }
/// <summary>
/// =netTotal+vatTotal+rounding  
/// </summary>
public float? Total { get; set; }
/// <summary>
/// Eg:"1,4,18"
/// Superseded by printAutomaticCoupons, see next.  
/// </summary>
public string AutomaticCoupons { get; set; }
/// <summary>
/// Coupon ID
/// </summary>
public int? CouponID { get; set; }
/// <summary>
/// Amount of reward points that this coupon "costs" to to the customer. This amount of points IS AUTOMATICALLY subtracted from customer when you call saveIssuedCoupon to create the coupon. (DO NOT call subtractCustomerRewardPoints yourself.)
/// FYI: some promotions may cost points, too, and you do need to subtract those manually. See field appliedPromotions below.
/// </summary>
public float? PrintingCostInRewardPoints { get; set; }
/// <summary>
/// Eg: "109000002346,109000002351"
/// Comma-separated list of coupons that had an effect on the given sale (from among all the coupons specified in input parameter couponIdentifiers). If a coupon was effective, it should be redeemed upon sale completion with API call redeemIssuedCoupon. Ineffective coupons should be given back to the customer, to be used at some other occasion.  
/// </summary>
public int? UsedCouponIdentifiers { get; set; }
/// <summary>
/// Promotion ID (see getCampaigns)
/// </summary>
public int? PromotionID { get; set; }
/// <summary>
/// How many times the promotion was applied.
/// Certain promotions (all promotions that give a receipt discount, or depend on invoice total) only apply once. BOGO promotions can apply multiple times, depending on the amount that customer buys.
/// </summary>
public int? Count { get; set; }
/// <summary>
/// Amount of reward points that this promotion requires from the customer. This amount of points must be multiplied by the "count" field and subtracted from customer when sale is completed, using subtractCustomerRewardPoints.
/// </summary>
public int? RewardPoints { get; set; }
/// <summary>
/// API analyzes the current shopping cart and customer history, and returns a plain-text message if it makes an interesting observation:
/// Customer should buy one more item (or $x more) and will be eligible for a promotion;
/// Recommended items that customer regularly purchases, and should presumably buy now again;
/// Recommended items that go well with the items already in the shopping cart;
/// When was customer's last visit;
/// What is customer's total purchase history;
/// Etc.
/// .
/// This field might not ber enabled by default, so let us know if you want to retrieve this information.  
/// </summary>
public string Information { get; set; }
/// <summary>
/// This field (and the next ones) notify the cashier if there is a promotion "Buy X and get product Y for free", promotion prerequisites have been fulfilled (customer has purchased X), but free gift Y has not been added to the basket yet. This field contains the product ID of the free gift item.  
/// </summary>
public int? FreeExtraProductID { get; set; }
/// <summary>
/// See previous. Product code of the free gift item.  
/// </summary>
public string FreeExtraProductCode { get; set; }
/// <summary>
/// See previous. Name of the free gift item.  
/// </summary>
public string FreeExtraProductName { get; set; }
/// <summary>
/// See previous. Free-text notification about the free gift item that is available. Can be displayed in POS UI.  
/// </summary>
public string FreeExtraNotification { get; set; }
}

#endregion

#region Payment

public class Payment : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? PaymentID { get; set; }
}

#endregion

#endregion
#region Webstore

#region MatrixDimension

public class MatrixDimension : ErplyItem
{
public int? DimensionID { get; set; }
public string Name { get; set; }
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

#endregion
#region Pos

#region pOSOpenDay

public class pOSOpenDay : ErplyItem
{
/// <summary>
/// Point of sale ID  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// The time when POS was opened.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTime { get; set; }
/// <summary>
/// ID of the POS day (or in other words, the cashier's shift).
/// NB! To later close the day with API call POSCloseDay, you need to provide EITHER dayID or openedUnixTime, so make sure to store one of these parameters.  
/// </summary>
public int? DayID { get; set; }
/// <summary>
/// If the exact same day opening — same register, same timestamp — has already been recorded, InventoryAPI sets this flag to true. This is for information only.
/// USAGE NOTE: While POS records are being synchronised, it may temporarily happen that two days of the same register are concurrently open. This is not an error. InventoryAPI requires that each close-day event must include the original open-day timestamp as well, so matching up day openings and closings is not a problem. In that case, no flags are raised.  
/// </summary>
public string WarningDayAlreadyOpen { get; set; }
}

#endregion

#region pOSCashIN

public class pOSCashIN : ErplyItem
{
/// <summary>
/// ID of the created/updated cash drop transaction.  
/// </summary>
public int? TransactionID { get; set; }
public int? PointOfSaleID { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? AddedUnixTime { get; set; }
}

#endregion

#region pOSCashOUT

public class pOSCashOUT : ErplyItem
{
/// <summary>
/// ID of the created/updated cash drop transaction.  
/// </summary>
public int? TransactionID { get; set; }
public int? PointOfSaleID { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? AddedUnixTime { get; set; }
}

#endregion

#region pOSCloseDay

public class pOSCloseDay : ErplyItem
{
/// <summary>
/// POS day ID.  
/// </summary>
public int? DayID { get; set; }
public int? PointOfSaleID { get; set; }
/// <summary>
/// The time when POS was last opened.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTime { get; set; }
/// <summary>
/// The time when POS was closed.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ClosedUnixTime { get; set; }
/// <summary>
/// If corresponding day-open event is not found, InventoryAPI automatically creates it (assuming that the amount in register was 0) and sets this flag to true. This is just for information.  
/// </summary>
public string WarningDayNotOpen { get; set; }
/// <summary>
/// If the day has already been closed (ie., InventoryAPI finds a record with the same pointOfSaleID and opening time and notices it has already been closed), then day closing sums are updated and InventoryAPI raises this flag. This is just for information.  
/// </summary>
public string WarningDayAlreadyClosed { get; set; }
}

#endregion

#endregion
#region Company

#region CompanyInfo

public class CompanyInfo : ErplyItem
{
/// <summary>
/// Record ID. You do not need to use this field, because getCompanyInfo always outputs one single record.  
/// </summary>
public int? Id { get; set; }
/// <summary>
/// Company name  
/// </summary>
public string Name { get; set; }
/// <summary>
/// Company's registry code  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Company's VAT number  
/// </summary>
public string VAT { get; set; }
/// <summary>
/// Corporate phone number  
/// </summary>
public string Phone { get; set; }
/// <summary>
/// Corporate cellphone number  
/// </summary>
public string Mobile { get; set; }
/// <summary>
/// Corporate fax number  
/// </summary>
public string Fax { get; set; }
/// <summary>
/// Corporate e-mail address  
/// </summary>
public string Email { get; set; }
/// <summary>
/// Website address  
/// </summary>
public string Web { get; set; }
/// <summary>
/// Name of company's bank.  
/// </summary>
public string BankName { get; set; }
/// <summary>
/// Number of company's bank account.  
/// </summary>
public string BankAccountNumber { get; set; }
/// <summary>
/// IBAN number of company's bank account.  
/// </summary>
public string BankIBAN { get; set; }
/// <summary>
/// BIC/SWIFT identifier of company's bank account.  
/// </summary>
public string BankSWIFT { get; set; }
/// <summary>
/// Name of company's bank.  
/// </summary>
public string BankName2 { get; set; }
/// <summary>
/// Number of company's bank account.  
/// </summary>
public string BankAccountNumber2 { get; set; }
/// <summary>
/// IBAN number of company's bank account.  
/// </summary>
public string BankIBAN2 { get; set; }
/// <summary>
/// BIC/SWIFT identifier of company's bank account.  
/// </summary>
public string BankSWIFT2 { get; set; }
/// <summary>
/// Full postal address. Company may have several addresses defined; this API call returns only the first one of these.  
/// </summary>
public string Address { get; set; }
/// <summary>
/// DO NOT USE THIS FIELD. See getConfParameters → "country" instead (to check which country settings this ERPLY account runs with).  
/// </summary>
public string Country { get; set; }
/// <summary>
/// DEPRECATED — getConfParameters → "default_client_idDat" is recommended instead.
/// The ID of default POS customer. Note that each POS register may actually have a different default customer; this is just the fallback value. See getPointsOfSale.  
/// </summary>
public int? DefaultClientID { get; set; }
/// <summary>
/// DEPRECATED — getConfParameters → "invoice_rounding" is recommended instead.
/// The rounding setting applied to sales invoices . Possible values: 0.01 (no rounding), 0.05 (rounding to nearest 5 sub-units - cents, pennies etc.), 0.1, 1 (rounding to the nearest unit - euro, dollar or pound)  
/// </summary>
public float? InvoiceRounding { get; set; }
/// <summary>
/// DEPRECATED — getConfParameters → "default_currency" is recommended instead.
/// The 3-letter currency code of account's default currency (eg. "USD")  
/// </summary>
public string DefaultCurrency { get; set; }
}

#endregion

#region verifyUser

public class verifyUser : ErplyItem
{
/// <summary>
/// ID of the user account  
/// </summary>
public int? UserID { get; set; }
/// <summary>
/// The same username that was passed as input  
/// </summary>
public string UserName { get; set; }
/// <summary>
/// ID of the company employee that has the abovementioned user account  
/// </summary>
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
/// <summary>
/// ID of the user group where the user belongs  
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// name of the user group  
/// </summary>
public string GroupName { get; set; }
/// <summary>
/// IP address of the API client.  
/// </summary>
public string IpAddress { get; set; }
/// <summary>
/// session identifier, to be used for subsequent API calls.  
/// </summary>
public string SessionKey { get; set; }
/// <summary>
/// time after which the session key expires (in seconds).  
/// </summary>
public int? SessionLength { get; set; }
/// <summary>
/// URL from where user can log into ERPLY backend, through web browser.
/// This URL does not affect API usage and should not be used for sending API calls.  
/// </summary>
public string LoginUrl { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the version number (typically an integer) of the live / production POS version that is appropriate for this customer — or the version that has specifically been configured for this customer.
/// This field does not mean that the customer is definitely using Berlin POS. The customer may be using other POS products or not using a POS at all.
/// Also, API does not currently provide a POS version number for preproduction / staging / testing.  
/// </summary>
public string BerlinPOSVersion { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the URL from where POS can load its static assets.
/// The URL does not include and does not depend on POS version number. POS should append version number to the URL, or perform some other transformation if needed.  
/// </summary>
public string BerlinPOSAssetsURL { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the location of the JNLP file for Erply Point Of Sale Integrator (EPSI), which provides support for various POS hardware.  
/// </summary>
public string EpsiURL { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls (eg. "V1/Customer/create") to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the customer service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the coupon service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the transaction service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Possible values - "Windows", "macOS" and "Linux"
/// </summary>
public string OperatingSystem { get; set; }
/// <summary>
/// Installation link
/// </summary>
public string Url { get; set; }
}

#endregion

#endregion
#region Inventory

#region Warehouse

public class Warehouse : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? WarehouseID { get; set; }
}

#endregion

#region InventoryRegistration

public class InventoryRegistration : ErplyItem
{
/// <summary>
/// ID of the newly-created item. Deprecated alternative name: inventoryReceiptID  
/// </summary>
public int? InventoryRegistrationID { get; set; }
}

#endregion

#region InventoryTransfer

public class InventoryTransfer : ErplyItem
{
/// <summary>
/// ID of the created or updated document.  
/// </summary>
public int? InventoryTransferID { get; set; }
}

#endregion

#region InventoryWriteOff

public class InventoryWriteOff : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? InventoryWriteOffID { get; set; }
}

#endregion

#region Stocktaking

public class Stocktaking : ErplyItem
{
public int? StocktakingID { get; set; }
public string Warehouses { get; set; }
public int? ProdgroupID { get; set; }
public int? BrandID { get; set; }
/// <summary>
/// Possible values: "CONFIRMED", "IN_PROGRESS".  
/// </summary>
public string Status { get; set; }
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

#region Stocktaking

public class Stocktaking : ErplyItem
{
public int? StocktakingID { get; set; }
}

#endregion

#region StocktakingReading

public class StocktakingReading : ErplyItem
{
public int? ProductID { get; set; }
/// <summary>
/// amount in stock  
/// </summary>
public string InStock { get; set; }
/// <summary>
/// amount reserved  
/// </summary>
public string Reserved { get; set; }
public string CountPcs { get; set; }
public string Comment { get; set; }
}

#endregion

#region PurchaseDocument

public class PurchaseDocument : ErplyItem
{
/// <summary>
/// Purchase document ID  
/// </summary>
public int? Id { get; set; }
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
/// </summary>
public string Type { get; set; }
public string PRCORDER { get; set; }
public string PRCINVOICE { get; set; }
public string CASHPRCINVOICE { get; set; }
public string PRCRETURN { get; set; }
public string PRCWAYBILL { get; set; }
public string PRCINVOICEONLY { get; set; }
public string PRCORDER { get; set; }
public string PRCINVOICE { get; set; }
public string CASHPRCINVOICE { get; set; }
public string PRCRETURN { get; set; }
/// <summary>
/// The possible statuses are:
/// PENDING Document not confirmed.
/// PARTIALLY_RECEIVED Purchase order (PRCORDER) only. Document has been confirmed and its status is "partially received". This status can be set manually, but typically this means that the PO has been associated with a purchase invoice, or purchase invoices, but not all ordered items have been received yet.
/// RECEIVED Purchase order (PRCORDER) only. Document is confirmed and its status is "received".
/// READY Any other confirmed purchase document (for example a purchase invoice or a purchase return) — or a confirmed purchase order that has not been fulfilled yet.
/// </summary>
public string Status { get; set; }
public string PENDING { get; set; }
public string PARTIALLY_RECEIVED { get; set; }
public string RECEIVED { get; set; }
public string READY { get; set; }
/// <summary>
/// Currency code: EUR, USD.  
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the purchase document currency against system's default currency.  
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// ID of the warehouse  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Name of the warehouse  
/// </summary>
public string WarehouseName { get; set; }
/// <summary>
/// Number of purchase document  
/// </summary>
public string Number { get; set; }
/// <summary>
/// Reg. number of purchase document  
/// </summary>
public string Regnumber { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Inventory transaction date.
/// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
/// Inventory Reports and COGS reports are based on the inventory transaction date.  
/// </summary>
public string InventoryTransactionDate { get; set; }
/// <summary>
/// eg. 14:59:00  
/// </summary>
public string Time { get; set; }
public int? SupplierID { get; set; }
public string SupplierName { get; set; }
/// <summary>
/// ID of supplier's group (see getSupplierGroups).  
/// </summary>
public int? SupplierGroupID { get; set; }
public int? AddressID { get; set; }
public string Address { get; set; }
public int? ContactID { get; set; }
public string ContactName { get; set; }
/// <summary>
/// ID of the system employee, who is set as the creator of the invoice/order/etc.  
/// </summary>
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
public int? SupplierID2 { get; set; }
public string SupplierName2 { get; set; }
public int? StateID { get; set; }
/// <summary>
/// In how many days the purchase document is due.  
/// </summary>
public int? PaymentDays { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Paid { get; set; }
public int? TransactionTypeID { get; set; }
public int? TransportTypeID { get; set; }
public int? DeliveryTermsID { get; set; }
public string DeliveryTermsLocation { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? TriangularTransaction { get; set; }
public int? ProjectID { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
public string ReferenceNumber { get; set; }
public string Notes { get; set; }
public float? Rounding { get; set; }
public float? NetTotal { get; set; }
public float? VatTotal { get; set; }
/// <summary>
/// =netTotal+vatTotal+rounding  
/// </summary>
public float? Total { get; set; }
/// <summary>
/// Tax rate ID, see getVatRates
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Net total
/// </summary>
public float? Total { get; set; }
/// <summary>
/// Tax rate ID, see getVatRates
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Total VAT / tax
/// </summary>
public float? Total { get; set; }
/// <summary>
/// URL pointing to a HTML printout version of the document.
/// This URL is valid only for 24 hours; if you want to send the purchase invoice / PO by e-mail, you must retrieve the contents of this URL and enclose it as an attachment, instead of sending the URL itself.  
/// </summary>
public string InvoiceLink { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string ShipDate { get; set; }
/// <summary>
/// Total inventory cost of the purchased products. Cost equals invoice net total, less services and non-stock products (since services are not taken into inventory, they can never have cost) + shipping and handling costs.
/// Cost is always in account's default currency. This field is returned only if you set getCost = 1.  
/// </summary>
public float? Cost { get; set; }
public float? NetTotalForAccounting { get; set; }
public float? TotalForAccounting { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
public int? ProductID { get; set; }
public int? ServiceID { get; set; }
public string ItemName { get; set; }
public string Code { get; set; }
public string Code2 { get; set; }
/// <summary>
/// ID of VAT rate.
/// </summary>
public int? VatrateID { get; set; }
public float? Amount { get; set; }
/// <summary>
/// Net price per item
/// </summary>
public float? Price { get; set; }
public float? Discount { get; set; }
/// <summary>
/// Supplier quoted delivery date. Available only if the feature "Delivery date tracking on sales and purchase orders" is enabled on your account.
/// </summary>
public string DeliveryDate { get; set; }
/// <summary>
/// Inventory cost for 1 unit. Cost is always in account's default currency. Returned only if you set getCost = 1.
/// </summary>
public float? UnitCost { get; set; }
/// <summary>
/// unitCost multiplied by amount. Returned only if you set getCost = 1.
/// </summary>
public float? CostTotal { get; set; }
/// <summary>
/// Package ID, if the item has been purchased in packages. To retrieve the packages of a particular product, see getProducts, block "productPackages".
/// </summary>
public int? PackageID { get; set; }
/// <summary>
/// Amount of packages
/// </summary>
public float? AmountOfPackages { get; set; }
/// <summary>
/// Amount of products contained in one package
/// </summary>
public float? AmountInPackage { get; set; }
/// <summary>
/// Readable package type name
/// </summary>
public string PackageType { get; set; }
/// <summary>
/// Type ID of the package.
/// </summary>
public int? PackageTypeID { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Value of the attribute
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region PurchaseDocument

public class PurchaseDocument : ErplyItem
{
/// <summary>
/// ID of the created (or updated) document  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Reg. number of the document (if it was confirmed)  
/// </summary>
public string InvoiceRegNo { get; set; }
public string InvoiceNo { get; set; }
/// <summary>
/// URL pointing to a HTML version of the document.
/// This URL is valid only for 24 hours; if you want to send the purchase invoice / PO by e-mail, you must retrieve the contents of this URL and enclose it as an attachment, instead of sending the URL itself.  
/// </summary>
public string InvoiceLink { get; set; }
/// <summary>
/// Net total of the document  
/// </summary>
public float? Net { get; set; }
/// <summary>
/// Total VAT of the document  
/// </summary>
public float? Vat { get; set; }
/// <summary>
/// Document total  
/// </summary>
public float? Total { get; set; }
}

#endregion

#endregion
#region Reports

#region Report

public class Report : ErplyItem
{
/// <summary>
/// If HTML format was selected, this variable contains the report HTML.  
/// </summary>
public string Htm { get; set; }
}

#endregion

#region AccountStatement

public class AccountStatement : ErplyItem
{
/// <summary>
/// Customer ID  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Name of the customer.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// Customer group ID  
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// Name of customer group.  
/// </summary>
public string CustomerGroupName { get; set; }
/// <summary>
/// Email of the customer.  
/// </summary>
public string Email { get; set; }
/// <summary>
/// URL pointing to pdf file  
/// </summary>
public string StatementLink { get; set; }
/// <summary>
/// For some customers, balance calculation may be disabled (typically the anonymous retail customer who is the default customer in POS). This flag can manually be set on customer card. If flag is set, balanceEnabled = 0.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? BalanceEnabled { get; set; }
}

#endregion

#region CostOfGoodsSold

public class CostOfGoodsSold : ErplyItem
{
/// <summary>
/// Sales document date, eg. 2010-01-29.  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Sales document ID.  
/// </summary>
public int? InvID { get; set; }
/// <summary>
/// Sales document number.  
/// </summary>
public string InvNo { get; set; }
/// <summary>
/// ID of the warehouse from which goods are sold.  
/// </summary>
public int? WrhID { get; set; }
/// <summary>
/// ID of the product.  
/// </summary>
public int? ProdID { get; set; }
/// <summary>
/// Sold amount.  
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// Net sales total. Does not include VAT / sales tax.  
/// </summary>
public float? Price { get; set; }
/// <summary>
/// The cost of goods sold.  
/// </summary>
public float? Cost { get; set; }
}

#endregion

#region GiftCardRedeeming

public class GiftCardRedeeming : ErplyItem
{
/// <summary>
/// ID of gift card  
/// </summary>
public int? GiftCardID { get; set; }
public float? Redeemed { get; set; }
/// <summary>
/// Remaining balance  
/// </summary>
public float? RemainingBalance { get; set; }
/// <summary>
/// Invoice ID  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Invoice number  
/// </summary>
public string InvoiceNo { get; set; }
/// <summary>
/// Payment ID  
/// </summary>
public int? PaymentID { get; set; }
/// <summary>
/// Customer ID  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Warehouse ID  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Warehouse code  
/// </summary>
public string WarehouseCode { get; set; }
/// <summary>
/// Point of sale ID  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Employee ID  
/// </summary>
public int? EmployeeID { get; set; }
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? DateTime { get; set; }
}

#endregion

#region PointOfSaleDayTotal

public class PointOfSaleDayTotal : ErplyItem
{
/// <summary>
/// Point of sale ID.  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Opening timestamp.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTime { get; set; }
/// <summary>
/// Employee opening the day.  
/// </summary>
public int? OpenedEmployeeID { get; set; }
/// <summary>
/// CASH, CARD or TRANSFER  
/// </summary>
public string PaymentType { get; set; }
/// <summary>
/// Credit card type, eg. VISA, AMEX, M/C etc. (for card payments only).  
/// </summary>
public string CardType { get; set; }
/// <summary>
/// Total amount of cash in register at opening time.  
/// </summary>
public float? BeginningAmount { get; set; }
public float? TransactionsTotal { get; set; }
public float? OtherChangesTotal { get; set; }
public float? ExpectedAmount { get; set; }
/// <summary>
/// Closing timestamp.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ClosedUnixTime { get; set; }
/// <summary>
/// Employee closing the day.  
/// </summary>
public int? ClosedEmployeeID { get; set; }
}

#endregion

#region SalesReport

public class SalesReport : ErplyItem
{
/// <summary>
/// Link to report file.
/// Note: if you try calling API getSalesReport and the output does not look as described below, your Erply account may need updating. Please contact helpdesk.
/// The report is a CSV file in "latin1" encoding. Fields are separated by semicolons and quoted with double quotes. The file has a header line (with standard column headers, for identifying which field contains which data) and a footer line (with totals). Here is a sample:
/// "";"PRODUCT_ID";"SERVICE_ID";"CODE";"EAN_CODE";"NAME";"SOLD_QUANTITY";"UNIT";"NET_SALES_TOTAL";"SALES_WITH_VAT_TOTAL";"DISCOUNT_TOTAL";
/// "1";"239";"0";"1409575";"###";"LargeCoffee";"98";"";"1862.00";"2234.40";"-1045.66";
/// "2";"243";"0";"1409579";"###";"Croissant";"17";"";"240.55";"288.66";"-98.94";
/// "3";"1";"0";"001";"3711234567890";"Donut";"21";"tk";"210.00";"252.00";"0.00";
/// "4";"242";"0";"1409578";"###";"SmallCoffee";"14";"";"116.62";"139.94";"0.00";
/// "5";"241";"0";"1409577";"###";"CheeseSandwich";"65";"";"53.95";"64.74";"0.00";
/// "TOTAL";;;;;;"215.00";;"2483.12";"2979.74";"-1144.60";
/// The escape character for literal quote characters is ", like in Microsoft Excel: "This ""word"" is quoted".
/// First line is a header line. Each column has a specific header identifier and you can use the headers to parse data out of the file. The last line in file is a total line, identified by the word "TOTAL" in line number column.
/// There are two basic report types: Sales revenue reports and COGS reports. Revenue reports show revenue and taxes. COGS reports show cost of sold goods and profit. By default, API returns a Sales Report. To get COGS report, use getCOGS = 1.
/// All Sales Revenue reports have the following columns. (Columns are not necessarily in this specific order - here we have adjusted the order for clarity.)
/// LINE_NUMBER
/// SOLD_QUANTITY
/// NET_SALES_TOTAL
/// SALES_WITH_VAT_TOTAL
/// DISCOUNT_TOTAL
/// DISCOUNT_PERCENTAGE
/// The following Sales Reports will also show total VAT (total sales tax) for each tax rate:
/// SALES_BY_SUPPLIER, SALES_BY_CATEGORY, SALES_BY_BRAND, SALES_BY_CUSTOMER, SALES_BY_CUSTOMER_ACCOUNT_MANAGER, SALES_BY_CUSTOMER_GROUP, SALES_BY_BUSINESS_AREA, SALES_BY_DATE, SALES_BY_WAREHOUSE, SALES_BY_POINT_OF_SALE, SALES_BY_CASHIER
/// A tax column header looks like this:
/// VAT_TOTAL - ID:2 - 9%
/// It has three parts, separated by " - ". The first part is keyword "VAT_TOTAL". Second part contains the string "ID:", followed by tax rate ID. (use API call getVatRates to get a list of all tax rates and their IDs.). Third part is the name of the tax rate.
/// Since there is a separate column for each tax rate, the number of columns will vary.
/// All COGS reports have the following columns:
/// LINE_NUMBER
/// SOLD_QUANTITY
/// PURCHASE_VALUE
/// WAREHOUSE_VALUE
/// NET_SALES_TOTAL
/// DISCOUNT_TOTAL
/// DISCOUNT_PERCENTAGE
/// SALES_PROFIT
/// PROFIT_PERCENT
/// MARKUP_PERCENT
/// The rest of the columns depend on selected report type (ie. how data is grouped). In SALES_BY_PRODUCT, each report line corresponds to one product. IN SALES_BY_EMPLOYEE, each report line corresponds to one employee.
/// Reports SALES_BY_PRODUCT, SALES_BY_PRODUCT_GROUP_WITH_DRILL_DOWN, SALES_BY_DEPARTMENT_WITH_DRILL_DOWN, SALES_BY_SUPPLIER_WITH_DRILL_DOWN, SALES_BY_CATEGORY_WITH_DRILL_DOWN, SALES_BY_MATRIX, SALES_BY_MATRIX_WITH_DRILL_DOWN have the following columns:
/// PRODUCT_ID
/// SERVICE_ID
/// CODE
/// EAN_CODE
/// NAME
/// UNIT
/// Reports SALES_BY_PRODUCT_GROUP, SALES_BY_DEPARTMENT, SALES_BY_SUPPLIER, SALES_BY_CATEGORY, SALES_BY_BRAND, SALES_BY_CUSTOMER, SALES_BY_CUSTOMER_ACCOUNT_MANAGER, SALES_BY_CUSTOMER_GROUP, SALES_BY_BUSINESS_AREA, the next columns are:
/// GROUP_ID, or SUPPLIER_ID, or CATEGORY_ID, or BRAND_ID, or CUSTOMER_ID, or EMPLOYEE_ID, or BUSINESS_AREA_ID
/// NAME
/// Report SALES_BY_ALL_PRODUCTS has the following columns:
/// PRODUCT_ID
/// SERVICE_ID
/// CODE
/// EAN_CODE
/// NAME
/// UNIT
/// Report SALES_BY_DATE has the following columns:
/// DATE
/// AVERAGE_UNITS_PER_TRANSACTION
/// AVERAGE_VALUE_SOLD
/// NUMBER_OF_SALES
/// Report SALES_BY_WAREHOUSE has the following columns:
/// LOCATION_ID
/// LOCATION
/// Report SALES_BY_POINT_OF_SALE has the following columns:
/// REGISTER_ID
/// REGISTER
/// Report SALES_BY_CASHIER has the following columns:
/// EMPLOYEE_ID
/// NAME
/// AVERAGE_UNITS_PER_TRANSACTION
/// AVERAGE_VALUE_SOLD
/// NUMBER_OF_SALES
/// Report SALES_BY_INVOICE has the following columns:
/// SALES_DOCUMENT_ID
/// DATE
/// SALES_DOCUMENT
/// CUSTOMER
/// CUSTOMER_ID
/// Report SALES_BY_INVOICE_ROWS has the following columns:
/// SALES_DOCUMENT_ID
/// DATE
/// SALES_DOCUMENT
/// CODE
/// NAME
/// PRODUCT_ID
/// SERVICE_ID
/// CUSTOMER
/// CUSTOMER_ID
/// Report SALES_BY_WEEKDAY has the following columns:
/// DAY_OF_WEEK
/// DAY_NUMBER
/// Report SALES_BY_HOUR has the following column:
/// HOUR
/// </summary>
public string ReportLink { get; set; }
}

#endregion

#region SummaryInventoryReport

public class SummaryInventoryReport : ErplyItem
{
/// <summary>
/// Warehouse ID  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Amount in stock  
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// Total value of inventory in purchase prices (wholesale prices). Does not include shipping or other extra costs.  
/// </summary>
public float? TotalPurchaseValue { get; set; }
/// <summary>
/// Total cost value of inventory. Cost includes purchase prices + shipping and other extra costs.  
/// </summary>
public float? TotalCostValue { get; set; }
/// <summary>
/// Total value of inventory in sales prices.  
/// </summary>
public float? TotalSalesValue { get; set; }
}

#endregion

#region AmountsOnOrder

public class AmountsOnOrder : ErplyItem
{
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
public float? Amount { get; set; }
}

#endregion

#endregion
#region Storage

#region Object

public class Object : ErplyItem
{
/// <summary>
/// ID of the created (or updated) object  
/// </summary>
public int? ObjectID { get; set; }
}

#endregion

#region Object

public class Object : ErplyItem
{
public int? ObjectID { get; set; }
public string Group { get; set; }
}

#endregion

#region incrementAttributeValue

public class incrementAttributeValue : ErplyItem
{
/// <summary>
/// Attribute value after update  
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region decrementAttributeValue

public class decrementAttributeValue : ErplyItem
{
/// <summary>
/// Attribute value after update  
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#endregion
#region Other

#region AssortmentProduct

public class AssortmentProduct : ErplyItem
{
/// <summary>
/// Comma-separated list of already products that already exist in this assortment. Note that the status of these items will not be changed. To change the status of items that already are in the assortment, use editAssortmentProducts.  
/// </summary>
public string ProductsAlreadyInAssortment { get; set; }
/// <summary>
/// Comma-separated list of non-existing products.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
}

#endregion

#region CustomerRewardPoint

public class CustomerRewardPoint : ErplyItem
{
/// <summary>
/// ID of the newly-created item.  
/// </summary>
public int? TransactionID { get; set; }
public int? CustomerID { get; set; }
public int? Points { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTime { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ExpiryUnixTime { get; set; }
}

#endregion

#region ItemToMatrixDimension

public class ItemToMatrixDimension : ErplyItem
{
/// <summary>
/// ID of the created value.  
/// </summary>
public int? ItemID { get; set; }
}

#endregion

#region ProductToPriceList

public class ProductToPriceList : ErplyItem
{
/// <summary>
/// ID of the created price list row  
/// </summary>
public int? PriceListProductID { get; set; }
}

#endregion

#region ProductToSupplierPriceList

public class ProductToSupplierPriceList : ErplyItem
{
/// <summary>
/// ID of the created supplier price list row.  
/// </summary>
public int? SupplierPriceListProductID { get; set; }
}

#endregion

#region changePassword

public class changePassword : ErplyItem
{
/// <summary>
/// ID of the user account (who was just authenticated with PIN)  
/// </summary>
public int? UserID { get; set; }
/// <summary>
/// User name  
/// </summary>
public string UserName { get; set; }
/// <summary>
/// ID of the company employee that has the abovementioned user account  
/// </summary>
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
/// <summary>
/// ID of the user group where the user belongs  
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// name of the user group  
/// </summary>
public string GroupName { get; set; }
/// <summary>
/// IP address of the API client.  
/// </summary>
public string IpAddress { get; set; }
/// <summary>
/// A new session identifier, to be used for subsequent API calls.  
/// </summary>
public string SessionKey { get; set; }
/// <summary>
/// time after which the session key expires (in seconds).  
/// </summary>
public int? SessionLength { get; set; }
public string LoginUrl { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the version number (typically an integer) of the live / production POS version that is appropriate for this customer — or the version that has specifically been configured for this customer.
/// This field does not mean that the customer is definitely using Berlin POS. The customer may be using other POS products or not using a POS at all.
/// Also, API does not currently provide a POS version number for preproduction / staging / testing.  
/// </summary>
public string BerlinPOSVersion { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the URL from where POS can load its static assets.
/// The URL does not include and does not depend on POS version number. POS should append version number to the URL, or perform some other transformation if needed.  
/// </summary>
public string BerlinPOSAssetsURL { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the location of the JNLP file for Erply Point Of Sale Integrator (EPSI), which provides support for various POS hardware.  
/// </summary>
public string EpsiURL { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls (eg. "V1/Customer/create") to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the customer service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the coupon service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the transaction service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Possible values - "Windows", "macOS" and "Linux"
/// </summary>
public string OperatingSystem { get; set; }
/// <summary>
/// Installation link
/// </summary>
public string Url { get; set; }
}

#endregion

#region clockIn

public class clockIn : ErplyItem
{
public int? EmployeeID { get; set; }
public int? PointOfSaleID { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? InUnixTime { get; set; }
/// <summary>
/// If the exact same clock-in event — with the same timestamp — has already been recorded, API sets this flag to true. This is for information only.
/// USAGE NOTE: When you call clockOut, you need to include the clock-in timestamp, too. API needs this to match the clock-in and clock-out events.
/// On the other hand, this requirement makes data synchronization easier. If you have a number of local clock-in and clock-out events and need to send them all to the server, you may do it by sending all clock-ins first, followed by all clock-outs. In other words, you do not need to make sure that each employee's clock-in event is necessarily followed by the same employee's clock-out event.  
/// </summary>
public string WarningAlreadyClockedIn { get; set; }
}

#endregion

#region clockOut

public class clockOut : ErplyItem
{
public int? EmployeeID { get; set; }
public int? PointOfSaleID { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? InUnixTime { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OutUnixTime { get; set; }
/// <summary>
/// If there is no corresponding clock-in record yet, InventoryAPI automatically creates it and sets this flag to true. This is just for information.  
/// </summary>
public string WarningNotClockedInYet { get; set; }
/// <summary>
/// If the employee has already clocked out (ie., InventoryAPI finds the timeclock record with matching employee ID and clock-in time and notices it has already been closed), then clock-out time gets updated and InventoryAPI raises this flag. This is just for information.  
/// </summary>
public string WarningClockedOutAlready { get; set; }
}

#endregion

#region convertAPILanguageIdentifierForPOS

public class convertAPILanguageIdentifierForPOS : ErplyItem
{
/// <summary>
/// Language identifier from Berlin POS.  
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public int? Language { get; set; }
}

#endregion

#region convertPOSLanguageIdentifier

public class convertPOSLanguageIdentifier : ErplyItem
{
/// <summary>
/// Language identifier to be used in API calls.  
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public int? Language { get; set; }
}

#endregion

#region copyMasterListProductsToErply

public class copyMasterListProductsToErply : ErplyItem
{
/// <summary>
/// Comma-separated list of product IDs that were not found in Master List.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> ProductIDsNotFound { get; set; }
}

#endregion

#region Assortment

public class Assortment : ErplyItem
{
/// <summary>
/// Comma-separated IDs of assortments that were found and successfully deleted.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of values that were not numeric, or IDs which did not refer to valid, existing assortments.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
/// <summary>
/// Comma-separated list of assortments that are still associated with stores (locations) and cannot be deleted. To fix this, use API calls getWarehouses and saveWarehouse to see which locations belong to this assortment, and apply a different assortment to them (or remove assortment ID from these locations).  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NotDeletableIDs { get; set; }
}

#endregion

#region CustomerAssociation

public class CustomerAssociation : ErplyItem
{
/// <summary>
/// Comma-separated list of relationship IDs that were found and successfully deleted.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of relationship IDs that were not found.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
}

#endregion

#region CustomerProfessional

public class CustomerProfessional : ErplyItem
{
/// <summary>
/// Comma-separated list of relationship IDs that were found and successfully deleted.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of relationship IDs that were not found.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
}

#endregion

#region LocationInWarehouse

public class LocationInWarehouse : ErplyItem
{
/// <summary>
/// Comma-separated list of deleted IDs.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of non-existing IDs.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
/// <summary>
/// Comma-separated list of IDs for which you do not have sufficient rights to delete.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NotDeletableIDs { get; set; }
}

#endregion

#region PriceList

public class PriceList : ErplyItem
{
/// <summary>
/// Comma-separated IDs of price lists that were found and successfully deleted.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of values that were not numeric, or IDs which did not refer to valid, existing price lists.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
/// <summary>
/// Comma-separated list of price lists that are still associated with locations, regions, customer groups, or customers, and cannot therefore be deleted.
/// You can override this with the flag deleteAllAssociations = 1 to delete all the associations along with the price list itself.
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NotDeletableIDs { get; set; }
/// <summary>
/// Comma-separated IDs of price lists that cannot be deleted.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NotSufficientRightsIDs { get; set; }
}

#endregion

#region SubsidyType

public class SubsidyType : ErplyItem
{
/// <summary>
/// Comma-separated IDs of types that were found and successfully deleted.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of values that were not numeric, or IDs which did not refer to a valid, existing type.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
/// <summary>
/// Comma-separated list of types that were found, but which are associated with at least one price list row, or for which you do not have the rights to delete.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NotDeletableIDs { get; set; }
}

#endregion

#region ProductInPriceList

public class ProductInPriceList : ErplyItem
{
/// <summary>
/// The rows that were deleted. Comma-separated list of integers.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// A comma-separated list of IDs that were not valid integers, and IDs of rows that do not exist in this price list.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
}

#endregion

#region ProductPackage

public class ProductPackage : ErplyItem
{
/// <summary>
/// Comma-separated IDs of packages that were found and successfully deleted.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of values that were not numeric, or IDs which did not refer to a valid, existing package.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
}

#endregion

#region ProductsFromSupplierPriceList

public class ProductsFromSupplierPriceList : ErplyItem
{
/// <summary>
/// The rows that were deleted. Comma-separated list of integers.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// A comma-separated list of row IDs that do not exist in this supplier price list.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
}

#endregion

#region StoreRegion

public class StoreRegion : ErplyItem
{
/// <summary>
/// Comma-separated IDs of regions that were found and successfully deleted.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of values that were not numeric, or IDs which did not refer to valid, existing regions.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
/// <summary>
/// Comma-separated list of regions that still contain stores (locations) and cannot be deleted. To fix this, use API calls getWarehouses and saveWarehouse to see which locations belong to this region, and recategorize them to a different region (or remove store region ID from these locations).  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NotDeletableIDs { get; set; }
}

#endregion

#region AssortmentProduct

public class AssortmentProduct : ErplyItem
{
/// <summary>
/// Comma-separated list of product IDs that this assortment does not contain. These do not get automatically added into the assortment. Call addAssortmentProducts to add them.  
/// </summary>
public string ProductsNotInAssortment { get; set; }
}

#endregion

#region EarnedRewardPointRecord

public class EarnedRewardPointRecord : ErplyItem
{
/// <summary>
/// Transaction ID.  
/// </summary>
public int? TransactionID { get; set; }
}

#endregion

#region ItemInMatrixDimension

public class ItemInMatrixDimension : ErplyItem
{
/// <summary>
/// ID of the updated value.  
/// </summary>
public int? ItemID { get; set; }
}

#endregion

#region ProductInPriceList

public class ProductInPriceList : ErplyItem
{
/// <summary>
/// ID of the edited price list row  
/// </summary>
public int? PriceListProductID { get; set; }
}

#endregion

#region ProductInSupplierPriceList

public class ProductInSupplierPriceList : ErplyItem
{
/// <summary>
/// ID of the edited supplier price list row.  
/// </summary>
public int? SupplierPriceListProductID { get; set; }
}

#endregion

#region UsedRewardPointRecord

public class UsedRewardPointRecord : ErplyItem
{
/// <summary>
/// Transaction ID.  
/// </summary>
public int? TransactionID { get; set; }
}

#endregion

#region findMasterListProduct

public class findMasterListProduct : ErplyItem
{
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Product name.  
/// </summary>
public string Name { get; set; }
/// <summary>
/// First code of the item (by convention, this is used for company's internal code).  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Second code of the item (by convention, this is used for EAN/UPC barcode).  
/// </summary>
public string Code2 { get; set; }
/// <summary>
/// Third code of the item.  
/// </summary>
public string Code3 { get; set; }
/// <summary>
/// Supplier's product code.  
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
/// Default sales price of the product, excluding VAT  
/// </summary>
public float? NetPrice { get; set; }
/// <summary>
/// ID of assignment group.  
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Name of assignment group.  
/// </summary>
public string GroupName { get; set; }
public int? CategoryID { get; set; }
public string CategoryName { get; set; }
public int? BrandID { get; set; }
public string BrandName { get; set; }
public int? PriorityGroupID { get; set; }
public string PriorityGroupName { get; set; }
public int? SupplierID { get; set; }
public string SupplierName { get; set; }
/// <summary>
/// Product cost  
/// </summary>
public float? Cost { get; set; }
/// <summary>
/// Product status, possible statuses are 'ACTIVE', 'NO_LONGER_ORDERED', 'NOT_FOR_SALE' and 'ARCHIVED'. By default 'ACTIVE'.  
/// </summary>
public string Status { get; set; }
/// <summary>
/// Picture URL.  
/// </summary>
public string PictureURL { get; set; }
}

#endregion

#region Appliance

public class Appliance : ErplyItem
{
/// <summary>
/// Appliance ID.  
/// </summary>
public int? ApplianceID { get; set; }
/// <summary>
/// Name of appliance. Appliance-specific attribute. Available only if your account is configured for appliance repair.  
/// </summary>
public string ApplianceName { get; set; }
/// <summary>
/// Product ID. Appliance-specific attribute.Available only if your account is configured for appliance repair.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Product name. Appliance-specific attribute .Available only if your account is configured for appliance repair.  
/// </summary>
public string ProductName { get; set; }
/// <summary>
/// First code of the product (by convention, this is used for company's internal code). Appliance-specific attribute. Available only if your account is configured for appliance repair.  
/// </summary>
public string ProductCode { get; set; }
/// <summary>
/// Second code of the product (by convention, this is used for EAN/UPC barcode). Appliance-specific attribute. Available only if your account is configured for appliance repair.  
/// </summary>
public string ProductCode2 { get; set; }
/// <summary>
/// Invoice ID the appliance/vehicle was sold with.  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Invoice number.  
/// </summary>
public string InvoiceNo { get; set; }
/// <summary>
/// Customer ID (appliance/vehicle buyer).  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer name.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// Customer e-mail address.  
/// </summary>
public string CustomerEmail { get; set; }
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
/// Vehicle-specific attribute. Available only if your account is configured for vehicle repair.  
/// </summary>
public string VehicleVIN { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if your account is configured for vehicle repair.  
/// </summary>
public string VehicleMake { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if your account is configured for vehicle repair.  
/// </summary>
public string VehicleModel { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if your account is configured for vehicle repair.  
/// </summary>
public string VehicleVersion { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if your account is configured for vehicle repair.  
/// </summary>
public string VehicleYearOfManufacture { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if your account is configured for vehicle repair.  
/// </summary>
public int? VehicleMileage { get; set; }
/// <summary>
/// Vehicle-specific attribute. Available only if your account is configured for vehicle repair.  
/// </summary>
public string VehicleUser { get; set; }
/// <summary>
/// Additional information.  
/// </summary>
public string Notes { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region AppliedPromotionRecord

public class AppliedPromotionRecord : ErplyItem
{
public int? RecordID { get; set; }
/// <summary>
/// Invoice date.  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Invoice location ID.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Invoice register ID.  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Invoice creator ID.  
/// </summary>
public int? InvoiceCreatorID { get; set; }
/// <summary>
/// Attendant ID.  
/// </summary>
public int? AttendantID { get; set; }
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Invoice ID.  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Invoice row ID.
/// Use invoiceID and rowID to match this record to the correct invoice and invoice row in getSalesDocuments.
/// Note however that row IDs are transient values; they change every time a sales document is re-saved. So do not rely on row IDs for data synchronization.
/// </summary>
public int? RowID { get; set; }
/// <summary>
/// Promotion ID, if the applied discount was a promotion.
/// Each returned record is either: 1) promotion discount (if promotionID has a non-zero value); 2) price list discount (if priceListID has a non-zero value; 3) manual discount (if both fields are zero).
/// </summary>
public int? PromotionID { get; set; }
/// <summary>
/// Promotion name, if the applied discount was a promotion.  
/// </summary>
public string PromotionName { get; set; }
/// <summary>
/// Price list ID, if the applied discount was a price list.
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Price list name, if the applied discount was a price list.  
/// </summary>
public string PriceListName { get; set; }
/// <summary>
/// Total amount of the product on invoice row.  
/// </summary>
public float? TotalAmount { get; set; }
/// <summary>
/// Total amount to which the discount applied.
/// A price list discount always applies to the whole row, and "discountedAmount" is equal to "totalAmount". Other types (manual discount and promotion discount), however, may also apply to individual items within one row, in which case "discountedAmount" is smaller than "totalAmount".
/// </summary>
public float? DiscountedAmount { get; set; }
/// <summary>
/// Unit price immediately before this promotion / price list / manual discount applied. (Note that multiple promotions and/or price lists can apply to one sold item; the discounts typically cumulate).
/// For US accounts, this is the net price. For other countries, this is the price with VAT.  
/// </summary>
public float? PriceBeforePromotion { get; set; }
/// <summary>
/// priceBeforePromotion multiplied by discountedAmount. Note that this is not the same as "line total before the discount" — it's only the total of the items to which the discount applied.  
/// </summary>
public float? TotalBeforePromotion { get; set; }
/// <summary>
/// Final unit price immediately AFTER applying the promotion / price list.
/// For US accounts, this is the net price. For other countries, this is the price with VAT.  
/// </summary>
public float? PriceAfterPromotion { get; set; }
/// <summary>
/// priceAfterPromotion multiplied by discountedAmount. Note that this is not the same as "line total after the discount" — it's only the total of the items to which the discount applied.  
/// </summary>
public float? TotalAfterPromotion { get; set; }
/// <summary>
/// Reason code ID associated with this promotion. This field contains a non-zero value only when the discount is promotion discount, and a reason code has been defined for that promotion.  
/// </summary>
public int? PromotionReasonCodeID { get; set; }
/// <summary>
/// $ discount that the promotion / price list applied to one item.  
/// </summary>
public float? UnitDiscount { get; set; }
/// <summary>
/// Total $ discount that promotion / price list gave to invoice line.  
/// </summary>
public float? TotalDiscount { get; set; }
/// <summary>
/// "ITEMS" or "INVOICE".
/// This field is populated only for applied promotions, not applied price lists or manual discounts.
/// "ITEMS" for line promotions, "INVOICE" for any promotions that applied to the whole document.
/// </summary>
public string PromotionType { get; set; }
/// <summary>
/// $ discount that was specified in promotion parameters.
/// (A promotion can have either promotionDiscountValue or promotionDiscountPercentage, but not both.)  
/// </summary>
public float? PromotionDiscountValue { get; set; }
/// <summary>
/// Percentage discount as it was defined in promotion description.  
/// </summary>
public float? PromotionDiscountPercentage { get; set; }
/// <summary>
/// "PRICE" or "DISCOUNT".
/// This field is populated only for applied price lists, not applied promotions or manual discounts.
/// "PRICE" if the price list applied a fixed price, "DISCOUNT" if the price list applied a discount percentage.
/// </summary>
public string PriceListDiscountType { get; set; }
/// <summary>
/// Percentage discount applied by the price list (in case the discount was percentage-based, see previous field).  
/// </summary>
public float? PriceListDiscountPercentage { get; set; }
/// <summary>
/// Manual discount percentage — if this discount was a manual discount.  
/// </summary>
public float? ManualDiscountPercentage { get; set; }
/// <summary>
/// ID of the reason code for the manual discount, if cashier selected a reason. For a list of reason codes, see getReasonCodes.  
/// </summary>
public int? ManualDiscountReasonID { get; set; }
/// <summary>
/// Amount of item-level subsidy (in euros/dollars) earned by the store — per one item.
/// Item-level subsidy is the subsidy that is applied to price list prices and item-level promotions (eg. "10% off from Product X").
/// </summary>
public float? UnitItemSubsidy { get; set; }
/// <summary>
/// Amount of transaction-level subsidy (in euros/dollars) earned by the store - per one item.
/// Transaction-level subsidy is the subsidy that is applied to transaction-level promotions (eg. "$5 off entire sale").
/// </summary>
public float? UnitTransactionSubsidy { get; set; }
/// <summary>
/// Total amount of item-level subsidy (in euros/dollars) earned by the store (unitItemSubsidy multiplied by discountedAmount).
/// </summary>
public float? TotalItemSubsidy { get; set; }
/// <summary>
/// Total amount of transaction-level subsidy (in euros/dollars) earned by the store (unitTransactionSubsidy multiplied by discountedAmount).
/// </summary>
public float? TotalTransactionSubsidy { get; set; }
}

#endregion

#region AssignmentGroup

public class AssignmentGroup : ErplyItem
{
/// <summary>
/// ID of assignment group.  
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Name of assignment group.  
/// </summary>
public string GroupName { get; set; }
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

#region Assignment

public class Assignment : ErplyItem
{
/// <summary>
/// ID of assignment.  
/// </summary>
public int? AssignmentID { get; set; }
/// <summary>
/// Number of assignment.  
/// </summary>
public int? AssignmentNumber { get; set; }
/// <summary>
/// Assignment group  
/// </summary>
public int? GroupID { get; set; }
public string GroupName { get; set; }
/// <summary>
/// Location, workshop or store. Location field has been added to assignments in Erply version 2013.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Timestamp (date and time) of when the assignment was created.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTime { get; set; }
/// <summary>
/// Timestamp (date and time) of when the appliance/vehicle was brought in for repair.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ReceivedUnixTime { get; set; }
/// <summary>
/// ID of a sales quote this assignment is based on. To get quotes via API, see getSalesDocuments.  
/// </summary>
public int? SourceQuoteID { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Completed { get; set; }
/// <summary>
/// Salesperson ID who booked time for repair.  
/// </summary>
public int? BookerEmployeeID { get; set; }
/// <summary>
/// Salesperson name who booked time for repair.  
/// </summary>
public string BookerEmployeeName { get; set; }
/// <summary>
/// Salesperson ID who received the appliance/vehicle from customer.  
/// </summary>
public int? ReceiverEmployeeID { get; set; }
/// <summary>
/// Salesperson name who received the appliance/vehicle from customer.  
/// </summary>
public string ReceiverEmployeeName { get; set; }
/// <summary>
/// Salesperson ID who returned the appliance/vehicle to the customer.  
/// </summary>
public int? ReturnedByEmployeeID { get; set; }
/// <summary>
/// Salesperson name who returned the appliance/vehicle to the customer.  
/// </summary>
public string ReturnedByEmployeeName { get; set; }
public string CommentsOnWorkDone { get; set; }
public string CommentsOnWorkLeftUndone { get; set; }
/// <summary>
/// ID of appliance. Appliance-specific attribute. Available only if appliance module is enabled on your account.  
/// </summary>
public int? ApplianceID { get; set; }
/// <summary>
/// Name of appliance. Appliance-specific attribute. Available only if appliance module is enabled on your account.  
/// </summary>
public string ApplianceName { get; set; }
/// <summary>
/// Serial number of appliance. Appliance-specific attribute. Available only if appliance module is enabled on your account.  
/// </summary>
public string ApplianceSerialNumber { get; set; }
/// <summary>
/// Start date of warranty. Appliance-specific attribute. Available only if appliance module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ApplianceStartDateOfWarranty { get; set; }
/// <summary>
/// End date of warranty. Appliance-specific attribute. Available only if appliance module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ApplianceEndDateOfWarranty { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer name.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// Customer e-mail address.  
/// </summary>
public string CustomerEmail { get; set; }
/// <summary>
/// Contact person name.  
/// </summary>
public string ContactPerson { get; set; }
/// <summary>
/// Contact phone.  
/// </summary>
public string ContactPersonPhone { get; set; }
/// <summary>
/// ID of vehicle. Vehicle-specific attribute. Available only if vehicle module is enabled on your account.  
/// </summary>
public int? VehicleID { get; set; }
/// <summary>
/// Licence plate of vehicle. Vehicle-specific attribute. Available only if vehicle module is enabled on your account.  
/// </summary>
public string VehicleLicencePlate { get; set; }
/// <summary>
/// Start date of warranty. Vehicle-specific attribute. Available only if vehicle module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? VehicleStartDateOfWarranty { get; set; }
/// <summary>
/// End date of warranty. Vehicle-specific attribute. Available only if vehicle module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? VehicleEndDateOfWarranty { get; set; }
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
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region Assortment

public class Assortment : ErplyItem
{
/// <summary>
/// ID of the assortment.  
/// </summary>
public int? AssortmentID { get; set; }
/// <summary>
/// Assortment code. ERPLY itself does not use assortment code for any purpose, but it might be useful for integrations.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Assortment name.  
/// </summary>
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
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region AssortmentProduct

public class AssortmentProduct : ErplyItem
{
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Product status: 'ACTIVE', 'NO_LONGER_ORDERED', 'NOT_FOR_SALE' or 'ARCHIVED'.  
/// </summary>
public string Status { get; set; }
}

#endregion

#region BilledUntilDate

public class BilledUntilDate : ErplyItem
{
/// <summary>
/// Billing statement ID.  
/// </summary>
public int? BillingStatementID { get; set; }
/// <summary>
/// End date of the last billed period, or "0000-00-00" if the billing is deactivated, no invoices have been issued yet, or no readings have been entered yet.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? BilledUntil { get; set; }
}

#endregion

#region BillingStatement

public class BillingStatement : ErplyItem
{
/// <summary>
/// ID of billing statement.  
/// </summary>
public int? BillingStatementID { get; set; }
/// <summary>
/// Number of billing statement.  
/// </summary>
public int? BillingStatementNumber { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer name.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// Customer address ID.  
/// </summary>
public int? CustomerAddressID { get; set; }
/// <summary>
/// Payer ID.  
/// </summary>
public int? PayerID { get; set; }
/// <summary>
/// Payer name.  
/// </summary>
public string PayerName { get; set; }
/// <summary>
/// Payer address ID.  
/// </summary>
public int? PayerAddressID { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDate { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDate { get; set; }
/// <summary>
/// Payment period.  
/// </summary>
public int? PaymentDays { get; set; }
/// <summary>
/// ID of the product.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// ID of the service.  
/// </summary>
public int? ServiceID { get; set; }
/// <summary>
/// Service name as displayed on invoices.  
/// </summary>
public string ServiceNameOnInvoices { get; set; }
public int? Active { get; set; }
/// <summary>
/// Currency code.  
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// ID of VAT rate.  
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Customer special price.  
/// </summary>
public float? CustomerSpecialPrice { get; set; }
/// <summary>
/// ID of the employee, who is set as the creator of the billing statement.  
/// </summary>
public int? EmployeeID { get; set; }
public int? SendByEmail { get; set; }
public int? MakeSeparateInvoice { get; set; }
/// <summary>
/// Additional text printed on invoices.  
/// </summary>
public string AdditionalInvoiceNotes { get; set; }
/// <summary>
/// Notes.  
/// </summary>
public string Notes { get; set; }
/// <summary>
/// Period of billing statement. Possible values: "MONTH", "QUARTER", "HALFYEAR", "YEAR", "3MONTHS", "4MONTHS".  
/// </summary>
public string BillingStatementPeriod { get; set; }
/// <summary>
/// Time of billing statement. Possible values: "WHEN_PERIOD_STARTS", "WHEN_PERIOD_ENDS", "BASED_ON_METERED_READINGS".  
/// </summary>
public string BillingStatementTime { get; set; }
/// <summary>
/// Last reading.  
/// </summary>
public float? LastReading { get; set; }
/// <summary>
/// Date of last reading.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? LastReadingDate { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region BillingStatementReading

public class BillingStatementReading : ErplyItem
{
/// <summary>
/// Reading ID.  
/// </summary>
public int? ReadingID { get; set; }
/// <summary>
/// Billing statement ID.  
/// </summary>
public int? BillingStatementID { get; set; }
public string Date { get; set; }
public float? Reading { get; set; }
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

#region BinQuantity

public class BinQuantity : ErplyItem
{
/// <summary>
/// Bin ID.  
/// </summary>
public int? BinID { get; set; }
/// <summary>
/// Bin code.  
/// </summary>
public string BinCode { get; set; }
/// <summary>
/// Indicates if this bin is preferred.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? BinPreferred { get; set; }
/// <summary>
/// Warehouse ID.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// First code of the product (by convention, this is used for company's internal code).  
/// </summary>
public string ProductCode { get; set; }
/// <summary>
/// Second code of the product (by convention, this is used for EAN/UPC barcode).  
/// </summary>
public string ProductCode2 { get; set; }
/// <summary>
/// Third code of the product.  
/// </summary>
public string ProductCode3 { get; set; }
/// <summary>
/// Supplier's product code.  
/// </summary>
public string ProductSupplierCode { get; set; }
/// <summary>
/// Code 5 of the product. "Extra product codes" module must be enabled.  
/// </summary>
public string ProductCode5 { get; set; }
/// <summary>
/// Code 6 of the product. "Extra product codes" module must be enabled.  
/// </summary>
public string ProductCode6 { get; set; }
/// <summary>
/// Code 7 of the product. "Extra product codes" module must be enabled.  
/// </summary>
public string ProductCode7 { get; set; }
/// <summary>
/// Code 8 of the product. "Extra product codes" module must be enabled.  
/// </summary>
public string ProductCode8 { get; set; }
public float? Amount { get; set; }
}

#endregion

#region BinRecord

public class BinRecord : ErplyItem
{
/// <summary>
/// Bin ID.  
/// </summary>
public int? BinID { get; set; }
/// <summary>
/// Bin code.  
/// </summary>
public string BinCode { get; set; }
/// <summary>
/// Indicates if this bin is preferred.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? BinPreferred { get; set; }
/// <summary>
/// Warehouse ID.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// First code of the product (by convention, this is used for company's internal code).  
/// </summary>
public string ProductCode { get; set; }
/// <summary>
/// Second code of the product (by convention, this is used for EAN/UPC barcode).  
/// </summary>
public string ProductCode2 { get; set; }
/// <summary>
/// Third code of the product.  
/// </summary>
public string ProductCode3 { get; set; }
/// <summary>
/// Supplier's product code.  
/// </summary>
public string ProductSupplierCode { get; set; }
/// <summary>
/// Code 5 of the product. "Extra product codes" module must be enabled.  
/// </summary>
public string ProductCode5 { get; set; }
/// <summary>
/// Code 6 of the product. "Extra product codes" module must be enabled.  
/// </summary>
public string ProductCode6 { get; set; }
/// <summary>
/// Code 7 of the product. "Extra product codes" module must be enabled.  
/// </summary>
public string ProductCode7 { get; set; }
/// <summary>
/// Code 8 of the product. "Extra product codes" module must be enabled.  
/// </summary>
public string ProductCode8 { get; set; }
/// <summary>
/// Record ID.  
/// </summary>
public int? RecordID { get; set; }
public float? Amount { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
/// <summary>
/// Document ID.  
/// </summary>
public int? DocumentID { get; set; }
/// <summary>
/// Document type. Possible values:
/// SALES_DOCUMENT - Sales Document
/// PURCHASE_DOCUMENT - Purchase Document
/// INVENTORY_REGISTRATION - Inventory Registration
/// INVENTORY_WRITE_OFF - Inventory Write-Off
/// INVENTORY_TRANSFER - Inventory Transfer
/// </summary>
public string DocumentType { get; set; }
/// <summary>
/// Creator (employee) ID.  
/// </summary>
public int? CreatorID { get; set; }
/// <summary>
/// Reason Code ID.  
/// </summary>
public int? ReasonCodeID { get; set; }
}

#endregion

#region Bin

public class Bin : ErplyItem
{
/// <summary>
/// Bin ID.  
/// </summary>
public int? BinID { get; set; }
/// <summary>
/// Warehouse ID.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Bin code.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Possible values: "ACTIVE", "ARCHIVED".  
/// </summary>
public string Status { get; set; }
/// <summary>
/// Indicates if this bin is preferred.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Preferred { get; set; }
/// <summary>
/// A textual description; may be used to indicate that this bin is only meant for storing a specific product or products.  
/// </summary>
public string AllowedProduct { get; set; }
/// <summary>
/// If the quantity in this bin falls below this value, the item should be reordered. (API does not indicate what is the product that is kept in this bin and needs to be reordered.)  
/// </summary>
public float? ReplenishmentMinimum { get; set; }
/// <summary>
/// Maximum capacity of this bin. (Products come in different sizes; API does not indicate what product is being assumed here.)  
/// </summary>
public float? MaximumAmount { get; set; }
public int? Order { get; set; }
}

#endregion

#region BusinessArea

public class BusinessArea : ErplyItem
{
public int? Id { get; set; }
/// <summary>
/// business area name.  
/// </summary>
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

#region CashIn

public class CashIn : ErplyItem
{
/// <summary>
/// ID of the cash drop or cash payout transaction.
/// In ERPLY, cash drops and payouts are stored in the same table, so there cannot be a cash drop and cash payout with the same ID.  
/// </summary>
public int? TransactionID { get; set; }
public float? Sum { get; set; }
/// <summary>
/// Currency code: EUR, USD.  
/// </summary>
public string CurrencyCode { get; set; }
public float? CurrencyRate { get; set; }
/// <summary>
/// Warehouse ID.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Warehouse name.  
/// </summary>
public string WarehouseName { get; set; }
/// <summary>
/// Point of sale ID.  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Point of sale name.  
/// </summary>
public int? PointOfSaleName { get; set; }
/// <summary>
/// Employee ID.  
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Employee name.  
/// </summary>
public string EmployeeName { get; set; }
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? DateTime { get; set; }
public string Comment { get; set; }
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
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region ChangedDataSince

public class ChangedDataSince : ErplyItem
{
/// <summary>
/// Possible values: "customers", "employees", "suppliers", "addresses", "currencies", "customerGroups", "emailAccounts", "giftCards", "pointsOfSale", "priceLists", "productGroups", "productCategories", "products", "services", "supplierGroups", "users", "warehouses", "vatRates", "events", "purchaseDocuments", "salesDocuments", "inventoryRegistrations", "inventoryTransfers", "inventoryWriteOffs", "payments".  
/// </summary>
public string TableName { get; set; }
/// <summary>
/// A value of 1 indicates that there have been new items added or existing items have been updated since the given timestamp.
/// Calling an appropriate getZZZ API function (such as getCustomers, getProducts), with the same changedSince timestamp, will give a list of changed items.
/// The corresponding functions are as follows:
/// customers getCustomers
/// employees or users getEmployees
/// suppliers getSuppliers
/// addresses getAddresses
/// currencies getCurrencies
/// customerGroups getCustomerGroups
/// emailAccounts getEmailAccounts
/// giftCards getGiftCards
/// pointsOfSale getPointsOfSale
/// priceLists getPriceLists
/// productGroups getProductGroups
/// products getProducts
/// services getServices
/// supplierGroups getSupplierGroups
/// warehouses getWarehouses
/// vatRates getVatRates
/// events getEvents
/// purchaseDocuments getPurchaseDocuments
/// salesDocuments getSalesDocuments
/// inventoryRegistrations getInventoryRegistrations
/// inventoryTransfers getInventoryTransfers
/// inventoryWriteOffs getInventoryWriteOffs
/// payments getPayments
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Updated { get; set; }
public string Customers { get; set; }
public string Employeesorusers { get; set; }
public string Suppliers { get; set; }
public string Addresses { get; set; }
public string Currencies { get; set; }
public string CustomerGroups { get; set; }
public string EmailAccounts { get; set; }
public string GiftCards { get; set; }
public string PointsOfSale { get; set; }
public string ProductGroups { get; set; }
public string Products { get; set; }
public string Services { get; set; }
public string SupplierGroups { get; set; }
public string Warehouses { get; set; }
public string VatRates { get; set; }
public string Events { get; set; }
public string PurchaseDocuments { get; set; }
public string SalesDocuments { get; set; }
public string InventoryRegistrations { get; set; }
public string InventoryTransfers { get; set; }
public string InventoryWriteOffs { get; set; }
public string Payments { get; set; }
/// <summary>
/// A value of 1 indicates that there have been items deleted since the given timestamp.
/// Calling API function getUserOperationsLog with the same timestamp and tableName will return the list of deleted IDs.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Deleted { get; set; }
}

#endregion

#region ClockedInEmployee

public class ClockedInEmployee : ErplyItem
{
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
public int? WarehouseID { get; set; }
public string WarehouseName { get; set; }
/// <summary>
/// Clock-in time as ISO date and time string ("yyyy-mm-dd hh:mm:ss"). This date and time is in the time zone of the location/store where employee clocked in. (Or in account's general time zone, if no time zone has been specified for the location.)  
/// </summary>
public string ClockInTime { get; set; }
/// <summary>
/// Clock-in time  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ClockInUnixTime { get; set; }
}

#endregion

#region ClockIn

public class ClockIn : ErplyItem
{
public int? TimeclockRecordID { get; set; }
public int? EmployeeID { get; set; }
public int? WarehouseID { get; set; }
/// <summary>
/// Clock-in time  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? InUnixTime { get; set; }
/// <summary>
/// Clock-out time. If employee has not clocked out yet, this field is set to 0.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OutUnixTime { get; set; }
}

#endregion

#region ConfParameter

public class ConfParameter : ErplyItem
{
public string GeneralSettings
 { get; set; }
/// <summary>
/// Do not edit. Country where this business resides. An uppercase two-letter country code, see http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2.  
/// </summary>
public string Country { get; set; }
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
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Account timezone. Names according to the tz database are used, eg. "America/New_York" or "Europe/Paris". See http://en.wikipedia.org/wiki/Tz_database and http://en.wikipedia.org/wiki/List_of_tz_database_time_zones.  
/// </summary>
public string Timezone { get; set; }
/// <summary>
/// Date format to be used. Format descriptor consists of letters Y, m, d and interpunctuation.
/// Y - 4-digit year
/// m - month, with leading zeroes (00 to 12)
/// d - day of month, with leading zeroes (00 to 31)
/// . Examples: "m/d/Y" - default US date format. "d/m/Y", "d.m.Y" - typical European formats etc.  
/// </summary>
public string Dateformat { get; set; }
/// <summary>
/// Number format to be used. This format descriptor consists of two letters. The first one is decimal separator and the second one is thousands separator. 3-digit grouping is assumed!
/// Examples: ".," - default US format (190,000.35), ", " - a sample European format (190 000,35)  
/// </summary>
public string Numberformat { get; set; }
/// <summary>
/// fiscal year start date. Format '0000-mm-dd'. By default January 1.  
/// </summary>
public string Fiscal_year_start_date { get; set; }
/// <summary>
/// Sales report export format. If 'csv', export as CSV. If 'xls' or empty, export as Excel file.  
/// </summary>
public string Export_sales_report_to_excel { get; set; }
/// <summary>
/// Custom CSV field separator defined by the user. Typically, it is not necessary to use this field. If users have NOT overridden the default CSV separator, then this field is missing or empty.
/// To get the actual CSV separator used in reporting (either the country-specific default, or the user-defined one, whichever is in effect), see the next parameter, "csv_field_separator" instead.  
/// </summary>
public string Csv_separator { get; set; }
/// <summary>
/// The symbol that is used as a field separator in getSalesReport CSV output (or the CSV-formatted reports that can be downloaded from the back office).
/// By default, ERPLY uses a default region-specific separator which is either a semicolon or a comma. However, it can be overridden in the account settings (Settings → Configuration in the back office).  
/// </summary>
public string Csv_field_separator { get; set; }
/// <summary>
/// show company name in title bar  
/// </summary>
public string Show_company_name_in_title_bar { get; set; }
/// <summary>
/// Default help URL
/// </summary>
public string Help { get; set; }
/// <summary>
/// Help URL displayed in Berlin POS
/// </summary>
public string HelpPOS { get; set; }
/// <summary>
/// URL to Erply terms of Service
/// </summary>
public string Terms_of_service { get; set; }
/// <summary>
/// URL to Erply knowledge base
/// </summary>
public string Knowledge_base { get; set; }
public string InvoicesandSales
 { get; set; }
/// <summary>
/// Default payment deadline  
/// </summary>
public string Payment_deadline { get; set; }
/// <summary>
/// There are four possible values:
/// "-1" - invoice totals must not be rounded.
/// "0" - invoice totals to be rounded to closest 0.05 currency units.
/// "10" - invoice totals should be rounded to closest 0.1 currency units.
/// "100" - invoice totals should be rounded to full currency units.
/// Rounding is a separate operation that takes place at the very end of calculating invoice total. It does not affect invoice net total or tax. Example rounding:
/// Invoice total: 32.89
/// Tax: 2.63
/// Subtotal: 35.52
/// Rounding: -0.02
/// Invoice total: 35.50  
/// </summary>
public int? Invoice_rounding { get; set; }
/// <summary>
/// If 1, dashboard graphs and widgets show sales revenue. If 0, dashboard graphs and widgets show the sales value of goods shipped from warehouse.  
/// </summary>
public string Make_sales_reports_by_revenue { get; set; }
/// <summary>
/// On invoices made from billing statements, use today's date  
/// </summary>
public string Billing_invoice_use_todays_date { get; set; }
/// <summary>
/// Allow to enter final prices (with VAT included) on sales invoices  
/// </summary>
public string Final_price_input_on_invoice { get; set; }
/// <summary>
/// Display prices both in selected currency and main currency  
/// </summary>
public string Always_show_eek_prices_on_invoice_form { get; set; }
/// <summary>
/// Allow to create invoices for contact persons  
/// </summary>
public string AllowCreateInvForContactPerson { get; set; }
/// <summary>
/// Do not create credit refund automatically  
/// </summary>
public string Do_not_create_automatic_credit_refund { get; set; }
/// <summary>
/// Select a method for setting price list prices for matrix products. If 1 - Only matrix products are added to price lists. The same price will apply to all colors and sizes. If 0 - Each variation (color and size) is added to the price list as a separate item  
/// </summary>
public string Use_matrix_price_in_pricelist { get; set; }
/// <summary>
/// For all purchases, customer collects X reward points per one unit of currency  
/// </summary>
public string Reward_points_per_currency_unit { get; set; }
/// <summary>
/// Reward points are valid for X months. If 0, points will not expire.  
/// </summary>
public string Reward_points_duration { get; set; }
/// <summary>
/// Select a method for calculating employee sales commission. 'percentage' - employees have commission percentage rates, 'amount' - each product has a specific sales commission amount.  
/// </summary>
public string Commission_method { get; set; }
/// <summary>
/// Default employee commission rate on net sales (%)  
/// </summary>
public string Commission_percentage { get; set; }
/// <summary>
/// Show accounts receivable and calculate customer balance: 'by_payer' - according to invoice payers. 'by_receiver' or empty - according to customers (receivers of goods)  
/// </summary>
public string Accounts_receivable_listed { get; set; }
/// <summary>
/// An order is considered completed when: 'packing_list_sent' - A waybill (invoice-waybill) has been made and a packing list sent to the warehouse. 'waybill_made' or empty - A waybill (invoice-waybill) has been made  
/// </summary>
public string Order_is_completed_when { get; set; }
/// <summary>
/// Partial fulfilment splits sales order  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Partial_fulfilment_splits_order { get; set; }
/// <summary>
/// in POS and on invoices, every line can be associated with an attendant  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Use_attendants_in_pos { get; set; }
/// <summary>
/// "Unpaid invoices" report also shows credit invoices  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Show_credit_in_unpaid_invoices_report { get; set; }
/// <summary>
/// After crediting a billing statement invoice you can make a new invoice for the same period  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Remake_billing_invoice_if_credited { get; set; }
public string SalesDocumentPrintouts
 { get; set; }
/// <summary>
/// Print reference numbers on invoices. 'orgper', 'orgper_manual' or 'invoice'  
/// </summary>
public string Ref_no { get; set; }
/// <summary>
/// Products can have several codes. On inventory and purchase documents, show: 'code' / 'code2'  
/// </summary>
public string Code_on_invoice { get; set; }
/// <summary>
/// Company's own code is printed on invoices and waybills  
/// </summary>
public string Code_on_salesdocument { get; set; }
/// <summary>
/// EAN/UPC code is printed on invoices and waybills  
/// </summary>
public string Code2_on_salesdocument { get; set; }
/// <summary>
/// Code 3 is printed on invoices and waybills  
/// </summary>
public string Code3_on_salesdocument { get; set; }
/// <summary>
/// Manufacturer code is printed on invoices and waybills  
/// </summary>
public string Code4_on_salesdocument { get; set; }
/// <summary>
/// Code 5 is printed on invoices and waybills. "Extra product codes" module must be enabled  
/// </summary>
public string Code5_on_salesdocument { get; set; }
/// <summary>
/// Code 6 is printed on invoices and waybills. "Extra product codes" module must be enabled  
/// </summary>
public string Code6_on_salesdocument { get; set; }
/// <summary>
/// Code 7 is printed on invoices and waybills. "Extra product codes" module must be enabled  
/// </summary>
public string Code7_on_salesdocument { get; set; }
/// <summary>
/// Code 8 is printed on invoices and waybills. "Extra product codes" module must be enabled  
/// </summary>
public string Code8_on_salesdocument { get; set; }
/// <summary>
/// On packing lists, show: 'code0' - same code as on invoices. 'code1' - company's own code. 'code2', 'code3' or 'code4'  
/// </summary>
public string ShowCodeXOnPackListDoc { get; set; }
/// <summary>
/// Sort packing list and delivery act by: 'name', 'code', code2', 'code3', 'code4'  
/// </summary>
public string Sort_packinglist_by { get; set; }
/// <summary>
/// Print a barcode on each invoice line: Enable for Invoice-waybills  
/// </summary>
public string Barcode_on_invwaybilldocument { get; set; }
/// <summary>
/// Print a barcode on each invoice line: Enable for Waybills  
/// </summary>
public string Barcode_on_waybilldocument { get; set; }
/// <summary>
/// Generate barcode from: 'code', code2', 'code3', 'code4'  
/// </summary>
public string Barcode_configuration { get; set; }
/// <summary>
/// Discount rate is printed on invoices by default  
/// </summary>
public string Discount_printed_on_invoices { get; set; }
/// <summary>
/// Announcement/message printed on invoices. {LANG} signifies language code.  
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Message in the footer of cash receipt  
/// </summary>
public string Receipt_footer { get; set; }
/// <summary>
/// Do not print receipt # as a barcode on receipts.  
/// </summary>
public string No_barcode_on_receipt_footer { get; set; }
/// <summary>
/// Invoice printouts include blanks for recipient's name and signature  
/// </summary>
public string Receiver_signature_on_invoice { get; set; }
/// <summary>
/// Print customer balance on invoices and invoice-waybills  
/// </summary>
public string Display_customer_balance_on_invoice { get; set; }
/// <summary>
/// If set to 1, and if customers pays with a gift card, receipt should display the remaining balance of the gift card.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Print_giftcard_balance_on_receipt { get; set; }
/// <summary>
/// Invoice printout shows lines grouped by waybill number  
/// </summary>
public string Invoice_group_rows_by_waybill { get; set; }
/// <summary>
/// Factoring notice on the invoice  
/// </summary>
public string Factoring { get; set; }
/// <summary>
/// Additional text in the footer of invoice  
/// </summary>
public string InvoiceExtraFooterLine { get; set; }
public string Sendinginvoicesbye-mail
 { get; set; }
/// <summary>
/// Add an import link to purchase and sales documents sent out by e-mail  
/// </summary>
public string Import_link_in_invoice_mail { get; set; }
/// <summary>
/// Default text used when sending invoice by e-mail. {LANG} signifies language code.  
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// Document type-specific text used when sending invoice by e-mail. {1} signifies sales document type ID and {2} signifies language code.  
/// </summary>
public string Mailtemplateinv{1}{2} { get; set; }
public string SalesQuotes
 { get; set; }
/// <summary>
/// display product pictures on sales quotes  
/// </summary>
public string Display_pictures_on_quotes { get; set; }
public string ExporttoHansaFinancials
 { get; set; }
/// <summary>
/// Accounts receivable  
/// </summary>
public string Hansa_receivables_account { get; set; }
/// <summary>
/// Revenue from goods  
/// </summary>
public string Hansa_goods_revenue_account { get; set; }
/// <summary>
/// Revenue from services (if unset, goods revenue account will be used)  
/// </summary>
public string Hansa_services_revenue_account { get; set; }
/// <summary>
/// Invoice rounding (if unset, rounding will not be sent as a separate invoice row)  
/// </summary>
public string Hansa_rounding_account { get; set; }
/// <summary>
/// Payment condition "Cash"  
/// </summary>
public string Hansa_cash_code { get; set; }
/// <summary>
/// Payment condition "Card"  
/// </summary>
public string Hansa_card_code { get; set; }
/// <summary>
/// Payment condition "Credited"  
/// </summary>
public string Hansa_credit_code { get; set; }
/// <summary>
/// Export product codes  
/// </summary>
public string Hansa_include_product_codes { get; set; }
/// <summary>
/// Accounts payable  
/// </summary>
public string Hansa_payables_account { get; set; }
/// <summary>
/// Warehouse  
/// </summary>
public string Hansa_warehouse_account { get; set; }
public string GoogleAppsIntegration
 { get; set; }
/// <summary>
/// Default user group ID for new users arriving through Google Apps  
/// </summary>
public string Googleapps_default_usergroup { get; set; }
public string BalancestatementsandPaymentreminders
 { get; set; }
/// <summary>
/// balance statement letter, header text  
/// </summary>
public string Balance_statement_text1 { get; set; }
/// <summary>
/// balance statement letter, footer text  
/// </summary>
public string Balance_statement_text2 { get; set; }
/// <summary>
/// payment reminder letter, header text  
/// </summary>
public string Payment_reminder_text1 { get; set; }
/// <summary>
/// payment reminder letter, footer text  
/// </summary>
public string Payment_reminder_text2 { get; set; }
/// <summary>
/// default period for balance statement letters. If 'last_month' or empty, then send end-of-month statement. 'last_year' = end-of-year statement  
/// </summary>
public string Default_period_for_balance_statements { get; set; }
public string SpaandSalonSettings
 { get; set; }
/// <summary>
/// email required when customer books an appointment  
/// </summary>
public string Salon_booking_email_required { get; set; }
/// <summary>
/// phone required when customer books an appointment  
/// </summary>
public string Salon_booking_phone_required { get; set; }
/// <summary>
/// email or phone required when customer books an appointment  
/// </summary>
public string Salon_booking_email_or_phone_required { get; set; }
/// <summary>
/// Extra charge or service 1. This is a product ID.  
/// </summary>
public int? Salon_booking_charge1_service { get; set; }
/// <summary>
/// Extra charge or service 2. This is a product ID.  
/// </summary>
public int? Salon_booking_charge2_service { get; set; }
/// <summary>
/// Extra charge or service 3. This is a product ID.  
/// </summary>
public int? Salon_booking_charge3_service { get; set; }
/// <summary>
/// Extra charge 1 is applied when booking: 'walk-in', 'online' or 'phone'  
/// </summary>
public string Salon_booking_charge1_channel { get; set; }
/// <summary>
/// Extra charge 2 is applied when booking: 'walk-in', 'online' or 'phone'  
/// </summary>
public string Salon_booking_charge2_channel { get; set; }
/// <summary>
/// Extra charge 3 is applied when booking: 'walk-in', 'online' or 'phone'  
/// </summary>
public string Salon_booking_charge3_channel { get; set; }
/// <summary>
/// Require credit card information when appointment is booked: online  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Salon_require_credit_card_for_online_booking { get; set; }
/// <summary>
/// Require credit card information when appointment is booked: over phone  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Salon_require_credit_card_for_phone_booking { get; set; }
/// <summary>
/// Customers must book appointments at least X hours in advance.  
/// </summary>
public int? Salon_booking_in_advance_min { get; set; }
/// <summary>
/// Customers can book appointments at most "1w", "2w", "3w" (n weeks) or "1m", "2m", "3m" "6m" (n months) in advance  
/// </summary>
public string Salon_booking_in_advance_max { get; set; }
/// <summary>
/// cancellation fee  
/// </summary>
public float? Salon_cancellation_fee { get; set; }
/// <summary>
/// cancellation service. This is a product ID.  
/// </summary>
public int? Salon_cancellation_service { get; set; }
/// <summary>
/// Cancellation fee is charged when appointment is canceled less than X hours before the appointment start time  
/// </summary>
public int? Salon_cancellation_deadline { get; set; }
public string POSSettings
 { get; set; }
/// <summary>
/// ID of default POS customer (the one that is selected in POS by default, typically "POS Customer", "Walk-in Customer" or similar). NB! It is possible to override this in POS settings, each register may have its own default customer. See getPointsOfSale.  
/// </summary>
public int? Default_client_idDat { get; set; }
/// <summary>
/// Use POS with touchscreen interface  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Touchscreen_pos { get; set; }
/// <summary>
/// In POS, days must be opened and closed  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Pos_opening_required { get; set; }
/// <summary>
/// POS: products identified by barcode will be instantly added to invoice  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Pos_add_rows_automatically { get; set; }
/// <summary>
/// Enable automatic printing in POS (Firefox plugin "JS Print Setup" required)  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Quickpos { get; set; }
/// <summary>
/// Remove numeric keypad and display more quick select buttons  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Do_not_use_numpad { get; set; }
/// <summary>
/// If customer gets a discount, print a line with total discount on sales receipt.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Show_total_discount_on_receipt { get; set; }
/// <summary>
/// Title of that line (eg. "Loyal customer rewards"). By default the line is titled "Total Discount".  
/// </summary>
public string Total_discount_label { get; set; }
/// <summary>
/// When ringing up the same product several times, quantity of the last line is incremented  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Pos_group_items_together { get; set; }
/// <summary>
/// Use gift cards with serial numbers  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Pos_use_giftcards_with_serial_numbers { get; set; }
/// <summary>
/// Log cashier automatically out after an idle period of X seconds.  
/// </summary>
public int? Pos_timeout { get; set; }
public string OfflinePOSSettings
 { get; set; }
/// <summary>
/// enable check payments  
/// </summary>
public string Allow_pay_with_check { get; set; }
/// <summary>
/// Cashier must ask for customer's: Email address  
/// </summary>
public string Pos_require_email { get; set; }
/// <summary>
/// Cashier must ask for customer's: Facebook name  
/// </summary>
public string Pos_require_facebook { get; set; }
/// <summary>
/// Cashier must ask for customer's: Twitter ID  
/// </summary>
public string Pos_require_twitter { get; set; }
/// <summary>
/// Cashier is reminded to ask for customer's information. 'beginning' - at the beginning of transaction, 'end' - at the end of transaction.  
/// </summary>
public string Pos_ask_customer_data { get; set; }
/// <summary>
/// Debit/credit card payments. If 0, customer inserts card and selects whether to pay by debit or credit. If 1, salesperson must ask customer's preferred payment type and select the correct option in POS  
/// </summary>
public string Show_debit_button_on_pos { get; set; }
/// <summary>
/// POS will prompt cashier to deposit cash when amount in drawer exceeds $X  
/// </summary>
public string Cash_out_warning_treshold { get; set; }
/// <summary>
/// Prompting interval in minutes  
/// </summary>
public string Cash_out_warning_interval { get; set; }
public string OfflinePOS-weigheditems
 { get; set; }
/// <summary>
/// Barcode type - 'weight' or 'price'. If empty, then the feature has not been set up.  
/// </summary>
public string Barcode_type { get; set; }
/// <summary>
/// Barcode prefix. This parameter is set only when price barcodes are enabled.  
/// </summary>
public string Barcode_price_prefix { get; set; }
/// <summary>
/// Barcode prefix. This parameter is set only when weight barcodes are enabled.  
/// </summary>
public string Barcode_weight_prefix { get; set; }
/// <summary>
/// Length of product code (number of digits)  
/// </summary>
public int? Barcode_code_length { get; set; }
/// <summary>
/// Length of price or weight (number of digits)  
/// </summary>
public int? Barcode_measurement_length { get; set; }
/// <summary>
/// Weight precision (in kg or lbs, number of decimal places) - only for barcodes with weight  
/// </summary>
public int? Barcode_weight_decimals { get; set; }
public string InventoryandPurchase
 { get; set; }
/// <summary>
/// Stock products  
/// </summary>
public string Positive_stock_required { get; set; }
/// <summary>
/// Main warehouse ID (Stock Replenishment Report will also show stock amounts in main warehouse, in addition to the warehouse you selected.)  
/// </summary>
public string Main_warehouse { get; set; }
/// <summary>
/// If set to 1, all products must have a unique code. (Code may also be empty.)  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Product_code_unique { get; set; }
/// <summary>
/// If set to 1, all products must have a unique EAN/UPC code. (EAN / UPC code may also be empty.)  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Product_code2_unique { get; set; }
/// <summary>
/// Generate EAN codes automatically  
/// </summary>
public string Product_code2_automatic { get; set; }
/// <summary>
/// product search always returns both matrix products and variations  
/// </summary>
public string Product_search_returns_matrix_and_variations { get; set; }
/// <summary>
/// Enable adding delivery expenses to purchase invoices  
/// </summary>
public string Use_transport_costs { get; set; }
/// <summary>
/// Print weights on purchase and sales invoices  
/// </summary>
public string Weights_on_invoices { get; set; }
/// <summary>
/// Use foreign transaction statistics  
/// </summary>
public string Transport_info_on_invoices { get; set; }
/// <summary>
/// Use m² → pcs. calculator on invoices  
/// </summary>
public string Use_m2_calculator { get; set; }
/// <summary>
/// Include sales prices on purchase invoice printout  
/// </summary>
public string Prcinvoice_with_salesprice { get; set; }
/// <summary>
/// Include sales prices on inventory transfer printout  
/// </summary>
public string Prodmove_with_salesprice { get; set; }
/// <summary>
/// If purchase invoice is confirmed and there are price variances, send a notification e-mail to (separated e-mail addresses with commas)  
/// </summary>
public string Prcinvoice_send_price_variance_notice_to { get; set; }
/// <summary>
/// Enable purchase waybills and purchase invoices as separate document types  
/// </summary>
public string Use_purchase_waybills { get; set; }
/// <summary>
/// Inventory Transfer Order puts items on hold  
/// </summary>
public string Warehouse_transfer_reserves_goods { get; set; }
/// <summary>
/// Inventory Transfer Order removes items from inventory  
/// </summary>
public string Warehouse_transfer_order_removes_items { get; set; }
public string Purchaseorders
 { get; set; }
/// <summary>
/// Which product code to print on purchase orders  
/// </summary>
public string Code_on_prcorder { get; set; }
/// <summary>
/// Print purchase order without warehouse locations  
/// </summary>
public string Prcorder_without_warehouse_location { get; set; }
/// <summary>
/// Print purchase order without weights  
/// </summary>
public string Prcorder_without_weight { get; set; }
/// <summary>
/// Print purchase order without company number and VAT number  
/// </summary>
public string Prcorder_without_regcode { get; set; }
/// <summary>
/// If purchase order is confirmed and there are price variances, send a notification e-mail to (separated e-mail addresses with commas)  
/// </summary>
public string Prcorder_send_price_variance_notice_to { get; set; }
public string Assignments
 { get; set; }
/// <summary>
/// additional text on assignment printout  
/// </summary>
public string WorkorderText { get; set; }
public string ExpectedTransferReport
 { get; set; }
/// <summary>
/// Payment processing fee for: Debit cards  
/// </summary>
public string Processing_fee_debit { get; set; }
/// <summary>
/// Payment processing fee for: American Express  
/// </summary>
public string Processing_fee_amex { get; set; }
/// <summary>
/// Payment processing fee for: Visa  
/// </summary>
public string Processing_fee_visa { get; set; }
/// <summary>
/// Payment processing fee for: MasterCard  
/// </summary>
public string Processing_fee_mc { get; set; }
/// <summary>
/// Payment processing fee for: Discover  
/// </summary>
public string Processing_fee_discover { get; set; }
/// <summary>
/// In "Expected Transfer" report, Visa and MasterCard are added together  
/// </summary>
public string Expected_transfer_add_visa_mc_together { get; set; }
public string ExporttoQuickBooks
 { get; set; }
/// <summary>
/// Bank Deposit  
/// </summary>
public string Qb_bank_deposit { get; set; }
/// <summary>
/// Accounts Receivable - Trade  
/// </summary>
public string Qb_accounts_receivable_trade { get; set; }
/// <summary>
/// Sales and Use Tax Payable  
/// </summary>
public string Qb_sales_and_use_tax_payable { get; set; }
/// <summary>
/// Cash Over and Short  
/// </summary>
public string Qb_cash_over_and_short { get; set; }
/// <summary>
/// Report cash counted in POS and day over/short amounts  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Qb_counted_over_short_amounts { get; set; }
/// <summary>
/// Inventory  
/// </summary>
public string Qb_inventory { get; set; }
/// <summary>
/// Undeposited Funds  
/// </summary>
public string Qb_undeposited_funds { get; set; }
/// <summary>
/// Sales Income (default account, you may override it for specific product groups)  
/// </summary>
public string Qb_credit_default { get; set; }
/// <summary>
/// COGS (default account, you may override it for specific product groups)  
/// </summary>
public string Qb_debit_default { get; set; }
public string Matrixsettings
 { get; set; }
/// <summary>
/// when you edit a matrix product, its variations are updated with the same changes  
/// </summary>
public string Matrix_update_variations_automatically { get; set; }
/// <summary>
/// The following variation fields are not updated by default. Select the ones that you want to be updated:  
/// </summary>
public string Matrix_select_fields { get; set; }
/// <summary>
/// code  
/// </summary>
public string Matrix_update_code { get; set; }
/// <summary>
/// name  
/// </summary>
public string Matrix_update_name { get; set; }
/// <summary>
/// net sales price  
/// </summary>
public string Matrix_update_price { get; set; }
/// <summary>
/// active  
/// </summary>
public string Matrix_update_isactive { get; set; }
/// <summary>
/// show in webshop  
/// </summary>
public string Matrix_update_show_in_webshop { get; set; }
/// <summary>
/// commission amount  
/// </summary>
public string Matrix_update_commission_amount { get; set; }
/// <summary>
/// location in warehouse  
/// </summary>
public string Matrix_update_warehouse_location { get; set; }
/// <summary>
/// product cost  
/// </summary>
public string Matrix_update_costprice { get; set; }
public string SettingsnotfoundinErplySettings»Configuration
 { get; set; }
/// <summary>
/// The degree of precision for net prices. Eg. if price_decimals = 4, all net prices should be stored with 4 digits precision. Typically, price_decimals = 2 for US, 3 or 4 for European accounts. Prices with VAT/tax and invoice totals should be always calculated and displayed with a precision of 2 decimals, regardless of any settings.
/// NB! Invoice total calculation method in Erply is a separate, complicated topic. Ask us for further information.  
/// </summary>
public int? Price_decimals { get; set; }
/// <summary>
/// Not editable. Currency code (EUR, USD, JPY) of the account's default currency. See getCurrencies.  
/// </summary>
public string Default_currency { get; set; }
/// <summary>
/// Account's set-up date.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date_installed { get; set; }
/// <summary>
/// Not editable. Version number of the algorithm to be used for calculation invoice totals. The version numbers and corresponding algorithms are internally defined. This setting may change day-by-day, so it is advised to check this value at the beginning of each day. If account is not aware of algorithm versions yet, parameter will be set to 0  
/// </summary>
public int? Invoice_algorithm_version { get; set; }
/// <summary>
/// Not editable. If 0, prices in this locale are commonly shown without sales tax (US, CA). If 1, prices are commonly shown with VAT included (the rest of the world).  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Locale_uses_price_with_tax { get; set; }
/// <summary>
/// Not editable. If 1, invoice-waybill totals are calculated according to the same method as POS receipts. This is an optional feature that Erply technical support can enable.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Invoice_waybills_show_price_with_tax { get; set; }
/// <summary>
/// Comma-separated list of all languages that are installed in this account.  
/// </summary>
[JsonProperty("lang")]
[JsonConverter(typeof(StringEnumConverter))]
public Language? Language { get; set; }
/// <summary>
/// The value of this parameter is 1 if your account has English as a non-default language, and if product card has a field for English-language product description. Otherwise (if no field, or that language is not in use) the value is 0.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Product_description_eng_enabled { get; set; }
/// <summary>
/// The value of this parameter is 1 if your account has Russian as a non-default language, and if product card has a field for Russian-language product description. Otherwise (if no field, or that language is not in use) the value is 0.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Product_description_rus_enabled { get; set; }
/// <summary>
/// The value of this parameter is 1 if your account has Finnish as a non-default language, and if product card has a field for Finnish-language product description. Otherwise (if no field, or that language is not in use) the value is 0.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Product_description_fin_enabled { get; set; }
/// <summary>
/// The value of this parameter is 1 if your account has English as a non-default language, and if product card has a field for English-language long (HTML) product description. Otherwise (if no field, or that language is not in use) the value is 0.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Product_longdescription_eng_enabled { get; set; }
/// <summary>
/// The value of this parameter is 1 if your account has Russian as a non-default language, and if product card has a field for Russian-language long (HTML) product description. Otherwise (if no field, or that language is not in use) the value is 0.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Product_longdescription_rus_enabled { get; set; }
/// <summary>
/// The value of this parameter is 1 if your account has Finnish as a non-default language, and if product card has a field for Finnish-language long (HTML) product description. Otherwise (if no field, or that language is not in use) the value is 0.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Product_longdescription_fin_enabled { get; set; }
}

#endregion

#region Country

public class Country : ErplyItem
{
public int? CountryID { get; set; }
public string CountryName { get; set; }
public string CountryCode { get; set; }
/// <summary>
/// Indicates this country is a member of the European Union.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? MemberOfEuropeanUnion { get; set; }
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

#region Coupon

public class Coupon : ErplyItem
{
public int? CouponID { get; set; }
/// <summary>
/// If set, the coupon gives discounts according to the specified sales promotion.  
/// </summary>
public int? CampaignID { get; set; }
/// <summary>
/// If set, these coupons are issued only from a specific store/location.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// issuedFromDate and issuedUntilDate specify the time period when this coupon may be issued. It does not affect the validity of the coupon (the validity period is defined by the sales promotion instead).  
/// </summary>
public string IssuedFromDate { get; set; }
public string IssuedUntilDate { get; set; }
public string Name { get; set; }
public string Code { get; set; }
/// <summary>
/// If set to 0, then the cashier may issue the coupon at any time, and the following conditions are all irrelevant. If set to 1, POS will print this coupon automatically, if the following conditions are met:  
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
/// Possible values: "dollars","points".  
/// </summary>
public string Measure { get; set; }
/// <summary>
/// Possible values: "points_amt","this_sale".  
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

#region CustomerBalance

public class CustomerBalance : ErplyItem
{
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer name.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// Customer card code.  
/// </summary>
public string CustomerCardCode { get; set; }
/// <summary>
/// Customer group ID.  
/// </summary>
public int? CustomerGroupID { get; set; }
/// <summary>
/// Amount that the customer has prepaid (NEGATIVE VALUE) or is currently due (POSITIVE VALUE). NB! The sign of the value is opposite to the usual expectation, since that's how balances are usually kept in accounting.  
/// </summary>
public float? Balance { get; set; }
}

#endregion

#region CustomerRewardPoint

public class CustomerRewardPoint : ErplyItem
{
/// <summary>
/// Customer's points  
/// </summary>
public int? Points { get; set; }
}

#endregion

#region DayClosing

public class DayClosing : ErplyItem
{
/// <summary>
/// ID of the day opening & closing (or in other words, a cashier's shift).  
/// </summary>
public int? DayID { get; set; }
/// <summary>
/// Warehouse ID.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Warehouse name.  
/// </summary>
public string WarehouseName { get; set; }
/// <summary>
/// Point of sale ID.  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Point of sale name.  
/// </summary>
public string PointOfSaleName { get; set; }
/// <summary>
/// Opening timestamp.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? OpenedUnixTime { get; set; }
/// <summary>
/// Employee opening the day.  
/// </summary>
public int? OpenedByEmployeeID { get; set; }
/// <summary>
/// Employee opening the day.  
/// </summary>
public string OpenedByEmployeeName { get; set; }
/// <summary>
/// Total amount of cash in register at opening time.  
/// </summary>
public float? OpenedSum { get; set; }
/// <summary>
/// Closing timestamp.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ClosedUnixTime { get; set; }
/// <summary>
/// Employee closing the day.  
/// </summary>
public int? ClosedByEmployeeID { get; set; }
/// <summary>
/// Employee closing the day.  
/// </summary>
public string ClosedByEmployeeName { get; set; }
/// <summary>
/// Total amount of money left in register.  
/// </summary>
public float? ClosedSum { get; set; }
/// <summary>
/// Total amount of money removed from register and deposited.  
/// </summary>
public float? BankedSum { get; set; }
/// <summary>
/// Notes.  
/// </summary>
public string Notes { get; set; }
/// <summary>
/// ID of cash variance reason. See getReasonCodes for various reason codes.  
/// </summary>
public int? ReasonID { get; set; }
/// <summary>
/// The currency in which the drawer was counted.
/// In a default setup, ERPLY allows to count the drawer in the default currency only. The cashier should just set aside any cash received in foreign currencies, and remove it from the register at the end of the day. From back office, it is possible to manually print a Z Report that lists transactions made in a different currency, but the counted amount cannot be recorded in POS.
/// Therefore, in the default setup, "currencyCode" is always an empty string.
/// However, customer support can enable an extra module, "POS multicurrency". With this extra module, it becomes possible to count other currencies as well and record the counts.
/// Under that setup, POS will create a separate "day opening and closing record" for each currency. If the shop accepts EUR, USD and JPY, POS will open three "shifts" every morning, one for each currency. At the end of the day, POS will present a dialog to enter counts for all three currencies and all the three "shifts" will be closed at the same time.
/// (In addition to enabling the extra module, POS must also be configured to accept multiple currencies.)
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region DeliveryType

public class DeliveryType : ErplyItem
{
public int? DeliveryTypeID { get; set; }
public string Code { get; set; }
public string Name { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region DeliveryTerm

public class DeliveryTerm : ErplyItem
{
public int? Id { get; set; }
public string Name { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region DocumentStatus

public class DocumentStatus : ErplyItem
{
public int? DocumentStatusID { get; set; }
public string Name { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region DocumentType

public class DocumentType : ErplyItem
{
public int? DocumentTypeID { get; set; }
public string Name { get; set; }
}

#endregion

#region DocumentSery

public class DocumentSery : ErplyItem
{
public int? DocumentSeriesID { get; set; }
public string Name { get; set; }
}

#endregion

#region EarnedRewardPointRecord

public class EarnedRewardPointRecord : ErplyItem
{
/// <summary>
/// Transaction ID.  
/// </summary>
public int? TransactionID { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Code of customer's loyalty/membership card.  
/// </summary>
public string CustomerCardNumber { get; set; }
/// <summary>
/// Invoice ID. Sale that earned the points.  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Invoice number.  
/// </summary>
public string InvoiceNo { get; set; }
public int? EarnedPoints { get; set; }
public int? RemainingPoints { get; set; }
/// <summary>
/// Transaction timestamp.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTime { get; set; }
/// <summary>
/// Expiry timestamp.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ExpiryUnixTime { get; set; }
/// <summary>
/// Register ID.  
/// </summary>
public int? PointOfSaleID { get; set; }
public string PointOfSaleName { get; set; }
/// <summary>
/// Cashier who processed the sale.  
/// </summary>
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
/// <summary>
/// Available only if "Reward point extras" module is enabled on your account.  
/// </summary>
public string Description { get; set; }
}

#endregion

#region EDocument

public class EDocument : ErplyItem
{
public string XML { get; set; }
}

#endregion

#region EmailAccount

public class EmailAccount : ErplyItem
{
public int? EmailAccountID { get; set; }
public int? UserID { get; set; }
public string Server { get; set; }
public int? Port { get; set; }
public string Username { get; set; }
public string Password { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? UseSSL { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
public string SmtpServer { get; set; }
public int? SmtpPort { get; set; }
public string SmtpUsername { get; set; }
public string SmtpPassword { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? SmtpUseSSL { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DownloadEmailsSinceDate { get; set; }
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

#region EmployeeStat

public class EmployeeStat : ErplyItem
{
/// <summary>
/// Cumulative sales for this employee this month. (Total sales = sum of all invoices created by this employee. Advanced commission sharing options — sharing one invoice between multiple people, associating an invoice line with a particular attendant — are ignored). The figure is net total or total with VAT, depending on the region.  
/// </summary>
public float? TotalSalesThisMonth { get; set; }
/// <summary>
/// Cumulative sales this week. Uses locale-specific beginning of week (Sunday or Monday).  
/// </summary>
public float? TotalSalesThisWeek { get; set; }
public float? TotalSalesYesterday { get; set; }
public float? TotalSalesToday { get; set; }
/// <summary>
/// Employee's cumulative work time according to timeclock, in hours  
/// </summary>
public float? TimeWorkedThisMonth { get; set; }
public string TimeWorkedThisWeek { get; set; }
public string TimeWorkedYesterday { get; set; }
public string TimeWorkedToday { get; set; }
/// <summary>
/// Last clock-in time. This allows the API client to calculate today's worked hours in real time. If this user is not currently clocked in, the value is 0.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastClockInUnixTime { get; set; }
}

#endregion

#region Event

public class Event : ErplyItem
{
/// <summary>
/// ID of existing document. If this parameter is present, then an existing event is updated.  
/// </summary>
public int? EventID { get; set; }
/// <summary>
/// Event name or description.  
/// </summary>
public string Description { get; set; }
/// <summary>
/// Event type ID. For all event types, see getEventTypes.  
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Event type name.  
/// </summary>
public string TypeName { get; set; }
/// <summary>
/// Start date and time of the event, eg. 2010-05-18 15:40:00 (in the account's default timezone).  
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? StartTime { get; set; }
/// <summary>
/// End date and time of the event, eg. 2010-05-18 16:00:00 (in the account's default timezone).  
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? EndTime { get; set; }
/// <summary>
/// ID of the customer related to this event (eg. a phone call or a meeting with particular customer).  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Name of the customer.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// ID of the customer's contact person.  
/// </summary>
public int? ContactID { get; set; }
/// <summary>
/// Name of the contact person.  
/// </summary>
public string ContactName { get; set; }
/// <summary>
/// ID of the project associated with this event.  
/// </summary>
public int? ProjectID { get; set; }
/// <summary>
/// Name of the project.  
/// </summary>
public string ProjectName { get; set; }
/// <summary>
/// Employee whom this task was assigned to.  
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Employee name.  
/// </summary>
public string EmployeeName { get; set; }
/// <summary>
/// Employee who entered or assigned this task.  
/// </summary>
public int? SubmitterID { get; set; }
/// <summary>
/// Submitter's name.  
/// </summary>
public string SubmitterName { get; set; }
/// <summary>
/// Supplier ID.  
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Supplier name.  
/// </summary>
public string SupplierName { get; set; }
/// <summary>
/// Event status ID. For all event statuses, see getEventStatuses.  
/// </summary>
public int? StatusID { get; set; }
/// <summary>
/// Event status name.  
/// </summary>
public string StatusName { get; set; }
/// <summary>
/// 1 if this event is completed, otherwise 0  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Completed { get; set; }
/// <summary>
/// Resource associated with this event.  
/// </summary>
public int? ResourceID { get; set; }
/// <summary>
/// Resource name.  
/// </summary>
public string ResourceName { get; set; }
/// <summary>
/// Product ID. This is a salon-specific field — the service (eg. a haircut or coloring) associated with this appointment.
/// API only returns this field if Salon / SPA module is enabled on your account.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Product name. API only returns this field if Salon / SPA module is enabled on your account.  
/// </summary>
public int? ProductName { get; set; }
/// <summary>
/// Location / salon ID. API only returns this field if Salon / SPA module is enabled on your account.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// API only returns this field if Salon / SPA module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CheckInTime { get; set; }
/// <summary>
/// API only returns this field if Salon / SPA module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CheckOutTime { get; set; }
/// <summary>
/// API only returns this field if Salon / SPA module is enabled on your account.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ServiceStartTime { get; set; }
/// <summary>
/// Special codename of the event type. This is only available for special spa/salon events, if you are using the respective module. Possible values: APPOINTMENT, SCHEDULE, BREAK, LUNCH, VACATION, SICKDAY.  
/// </summary>
public string Type { get; set; }
/// <summary>
/// Name of the event status. If Salon / SPA module is enabled, possible values: SCHEDULED, CHECKEDIN, NOSHOW, BEINGSERVICED, CHECKEDOUT, NONE.  
/// </summary>
public string Status { get; set; }
/// <summary>
/// Longer description, associated e-mail message or anything else.  
/// </summary>
public string Notes { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Item's creation time. To retrieve this field, set input parameter responseMode = "detail". This field is not included in the output by default.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
}

#endregion

#region EventStatus

public class EventStatus : ErplyItem
{
public int? Id { get; set; }
public string Name { get; set; }
/// <summary>
/// Color in #rrggbb format, can be used to display events with different status with different colors. (Deprecated field name: "colour")  
/// </summary>
public string Color { get; set; }
public string Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region EventType

public class EventType : ErplyItem
{
public int? Id { get; set; }
public string Name { get; set; }
/// <summary>
/// Indicates whether events of this type are displayed in ERPLY calendar or not.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? DisplayedInCalendar { get; set; }
public string Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region FranchiseSalesDocument

public class FranchiseSalesDocument : ErplyItem
{
/// <summary>
/// This is already a "reporting ID" and not the document's original ID as it was in the particular store.  
/// </summary>
public int? Id { get; set; }
/// <summary>
/// INVWAYBILL, CASHINVOICE, WAYBILL, PREPAYMENT, OFFER, EXPORTINVOICE, RESERVATION, CREDITINVOICE, ORDER or INVOICE.  
/// </summary>
public string Type { get; set; }
/// <summary>
/// Currency code: EUR, USD.  
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the invoice currency against system's default currency.  
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// Company name from the account where the sales invoice comes from.  
/// </summary>
public string FranchiseeName { get; set; }
public string Number { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? ClientID { get; set; }
/// <summary>
/// Customer name.  
/// </summary>
public string ClientName { get; set; }
/// <summary>
/// Customer e-mail address.  
/// </summary>
public string ClientEmail { get; set; }
/// <summary>
/// Invoice address ID.  
/// </summary>
public int? AddressID { get; set; }
/// <summary>
/// Informative 
/// </summary>
public string PaymentType { get; set; }
/// <summary>
/// Notes printed on the invoice.  
/// </summary>
public string Notes { get; set; }
/// <summary>
/// Notes to be displayed on invoice form, as a notice/reminder to other users.  
/// </summary>
public string InternalNotes { get; set; }
public float? NetTotal { get; set; }
public float? VatTotal { get; set; }
public float? Rounding { get; set; }
/// <summary>
/// =netTotal+vatTotal+rounding  
/// </summary>
public float? Total { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Product ID.
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Service ID.
/// </summary>
public int? ServiceID { get; set; }
/// <summary>
/// Product or service name.
/// </summary>
public string ItemName { get; set; }
/// <summary>
/// Product code.
/// </summary>
public string Code { get; set; }
/// <summary>
/// ID of VAT rate.
/// </summary>
public int? VatrateID { get; set; }
/// <summary>
/// Sold quantity.
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// Net sales price per item, pre-discount.
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Discount %.
/// </summary>
public float? Discount { get; set; }
/// <summary>
/// Discounted sales price per item, VAT excluded.
/// </summary>
public float? FinalNetPrice { get; set; }
/// <summary>
/// Discounted sales price per item, VAT included.
/// </summary>
public float? FinalPriceWithVAT { get; set; }
public float? RowNetTotal { get; set; }
public float? RowVAT { get; set; }
public float? RowTotal { get; set; }
/// <summary>
/// This is already a "reporting ID" and not the payment's original ID as it was in the particular store.
/// </summary>
public int? PaymentID { get; set; }
/// <summary>
/// ID of the customer who made the payment.
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Payment type ID.
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Payment type code name.
/// </summary>
public string Type { get; set; }
/// <summary>
/// Payment date.
/// </summary>
public string Date { get; set; }
/// <summary>
/// Paid amount.
/// </summary>
public float? Sum { get; set; }
/// <summary>
/// Currency code: EUR, USD.
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// Exchange rate of the payment currency against system's default currency.
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// Cardholder's name (for card payments only).
/// </summary>
public string CardHolder { get; set; }
/// <summary>
/// Last 4 digits of credit card number (for card payments only).
/// </summary>
public string CardNumber { get; set; }
/// <summary>
/// Credit card type, eg. VISA, AMEX, M/C etc. (for card payments only).
/// </summary>
public string CardType { get; set; }
/// <summary>
/// Card payment authorization code.
/// </summary>
public string AuthorizationCode { get; set; }
/// <summary>
/// Card payment reference number.
/// </summary>
public string ReferenceNumber { get; set; }
}

#endregion

#region FulfillableOrder

public class FulfillableOrder : ErplyItem
{
/// <summary>
/// Sales document ID.  
/// </summary>
public int? Id { get; set; }
/// <summary>
/// ORDER  
/// </summary>
public string Type { get; set; }
public string Number { get; set; }
/// <summary>
/// Sales document date.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Customer name.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// Customer e-mail address.  
/// </summary>
public string CustomerEmail { get; set; }
/// <summary>
/// Sales document address ID.  
/// </summary>
public int? AddressID { get; set; }
/// <summary>
/// Sales document address — full address, formatted.  
/// </summary>
public string Address { get; set; }
/// <summary>
/// Customer requested delivery date (for the whole document).  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? DeliveryDate { get; set; }
public int? DeliveryTypeID { get; set; }
/// <summary>
/// Warehouse ID.  
/// </summary>
public int? WarehouseID { get; set; }
public int? ProductID { get; set; }
public string ProductCode { get; set; }
public string ProductCode2 { get; set; }
public string ProductName { get; set; }
public float? OrderedAmount { get; set; }
public float? AmountInStock { get; set; }
public float? FulfillableAmount { get; set; }
public float? Price { get; set; }
public float? Discount { get; set; }
/// <summary>
/// ID of VAT rate.
/// </summary>
public int? VatrateID { get; set; }
public string DeliveryDate { get; set; }
}

#endregion

#region GiftCard

public class GiftCard : ErplyItem
{
/// <summary>
/// ID of gift card  
/// </summary>
public int? GiftCardID { get; set; }
public string Code { get; set; }
public float? Value { get; set; }
/// <summary>
/// Remaining balance  
/// </summary>
public float? Balance { get; set; }
public int? PurchasingCustomerID { get; set; }
/// <summary>
/// Date and time of purchase  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? PurchaseDateTime { get; set; }
public int? RedeemingCustomerID { get; set; }
/// <summary>
/// Date and time of redemption  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? RedemptionDateTime { get; set; }
/// <summary>
/// Gift card expiration date. Note that gift card expiration is not enabled by default. Contact us if you need to enable gift card expiration. If not enabled, this field's value will always be an empty string. If this gift card does not have an expiration date, value will be an empty string.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ExpirationDate { get; set; }
/// <summary>
/// Invoice with which the gift card was purchased. Available only if "Gift card extras" module is enabled on your account.  
/// </summary>
public int? PurchaseInvoiceID { get; set; }
/// <summary>
/// Tax rate (VAT rate) the gift card was sold with.
/// If the value is 0, you may assume that the gift card was sold with 0% tax.
/// </summary>
public int? VatrateID { get; set; }
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

#region HomeStore

public class HomeStore : ErplyItem
{
/// <summary>
/// ID of the warehouse  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Name of the warehouse  
/// </summary>
public string Name { get; set; }
}

#endregion

#region InventoryRegistration

public class InventoryRegistration : ErplyItem
{
/// <summary>
/// ID of inventory registration  
/// </summary>
public int? InventoryRegistrationID { get; set; }
/// <summary>
/// Inventory registration number  
/// </summary>
public int? InventoryRegistrationNo { get; set; }
public int? CreatorID { get; set; }
public int? WarehouseID { get; set; }
public int? InventoryID { get; set; }
public int? SupplierID { get; set; }
/// <summary>
/// Reason Code ID. This field is returned only if the "Reason codes for Inventory registrations" module has been enabled on your account. Contact customer support to enable it.  
/// </summary>
public int? ReasonID { get; set; }
/// <summary>
/// Currency code: EUR, USD.  
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the inventory registration currency against system's default currency.  
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Inventory transaction date.
/// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
/// Inventory Reports and COGS reports are based on the inventory transaction date.  
/// </summary>
public string InventoryTransactionDate { get; set; }
/// <summary>
/// Source of received inventory  
/// </summary>
public string Cause { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
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
/// <summary>
/// ID of the product.
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Unit cost at which product was taken into inventory. However, if you need to track inventory value, it is recommended to use the "cost" field instead; see below.
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Quantity taken into stock.
/// This value can also be negative; in that case, the quantity was subtracted from stock (written off). When doing inventory adjustments, it might be convenient to put both positive and negative adjustments on the same document.
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// Unit cost. This value is retrieved from inventory records and it reflects the unit cost at which the item was taken into inventory. For negative quantities, unit cost depends on which inventory batches the subtracted quantity was drawn from.
/// To retrieve this field, you need to set input parameter "getCost" = 1.
/// </summary>
public float? Cost { get; set; }
/// <summary>
/// Package ID, if the item has been taken into inventory in packages.
/// To retrieve the packages of a particular product, see getProducts, block "productPackages".
/// This field, and the following ones, are not returned if your account does not have the "Packages on Inventory Registrations" extra module activated.
/// </summary>
public int? PackageID { get; set; }
/// <summary>
/// Amount of packages
/// </summary>
public float? AmountOfPackages { get; set; }
/// <summary>
/// Amount of products contained in one package
/// </summary>
public float? AmountInPackage { get; set; }
/// <summary>
/// Readable package type name
/// </summary>
public string PackageType { get; set; }
/// <summary>
/// Type ID of the package.
/// </summary>
public int? PackageTypeID { get; set; }
}

#endregion

#region InventoryTransferReport

public class InventoryTransferReport : ErplyItem
{
/// <summary>
/// Link to report file.
/// The report is a CSV file in "latin1" encoding. Fields are separated by semicolons and quoted with double quotes. The file has a header line (with standard column headers, for identifying which field contains which data) and a footer line (with totals). Here is a sample:
/// "LINE_NUMBER";"PRODUCT_ID";"PRODUCT_CODE";
/// "PRODUCT_NAME";"COST";"AMOUNT";"LINE_TOTAL";
/// "INVENTORY_TRANSFER_ID";"DATE";"NUMBER";
/// "NOTES";"WAREHOUSE_FROM_ID";"WAREHOUSE_TO_ID";"EMPLOYEE_ID"
/// "1";"6";"2014091611";"Croissant";"3";"1";"3";"3";"2014-08-25";"44";"notes 1";"3";"4";"31"
/// "2";"5";"2014091619";"LargeCoffee";"5";"1";"5";"59";"2014-09-16";"47";"notes 2";"4";"3";"33"
/// "TOTAL";"";"";"";"";"";"8";"";"";"";"";"";"";""
/// The escape character for literal quote characters is ", like in Microsoft Excel: "This ""word"" is quoted".
/// First line is a header line. Each column has a specific header identifier and you can use the headers to parse data out of the file. The last line in file is a total line, identified by the word "TOTAL" in line number column.
/// Report currently has the following columns, but new ones may be added in the future, so you should configure your CSV parser to extract information based on file headers.
/// LINE_NUMBER
/// PRODUCT_ID
/// PRODUCT_CODE
/// PRODUCT_NAME
/// COST
/// AMOUNT
/// LINE_TOTAL
/// INVENTORY_TRANSFER_ID
/// DATE
/// NUMBER
/// NOTES
/// WAREHOUSE_FROM_ID
/// WAREHOUSE_TO_ID
/// y
/// EMPLOYEE_ID
/// </summary>
public string ReportLink { get; set; }
}

#endregion

#region InventoryTransfer

public class InventoryTransfer : ErplyItem
{
/// <summary>
/// ID of inventory transfer  
/// </summary>
public int? InventoryTransferID { get; set; }
/// <summary>
/// Inventory transfer number  
/// </summary>
public int? InventoryTransferNo { get; set; }
public int? CreatorID { get; set; }
public int? WarehouseFromID { get; set; }
public int? WarehouseToID { get; set; }
/// <summary>
/// Currency code: EUR, USD.  
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the inventory transfer currency against system's default currency.  
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// Possible values: TRANSFER, TRANSFER_ORDER.  
/// </summary>
public string Type { get; set; }
/// <summary>
/// Source document ID.  
/// </summary>
public int? InventoryTransferOrderID { get; set; }
public int? FollowupInventoryTransferID { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Inventory transaction date.
/// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
/// Inventory Reports and COGS reports are based on the inventory transaction date.  
/// </summary>
public string InventoryTransactionDate { get; set; }
public string Notes { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
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
/// <summary>
/// ID of the transfered product.
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Unit cost at which the transfer was done. However, it is recommended to use the "cost" field instead.
/// When you create an Inventory Transfer, ERPLY sets the cost automatically, depending on which inventory batches the quantity is drawn from. In the past, it was possible to set it manually, hence we have the separate "price" field.
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Transfered quantity.
/// </summary>
public float? Amount { get; set; }
/// <summary>
/// Unit cost. This value is retrieved directly from inventory records, so it always reflects the true cost at which the items were transfered.
/// To retrieve this field, you need to set input parameter "getCost" = 1.
/// </summary>
public float? Cost { get; set; }
/// <summary>
/// Package ID, if the item has been transfered in packages.
/// To retrieve the packages of a particular product, see getProducts, block "productPackages".
/// This field, and the following ones, are not returned if your account does not have the "Packages on Inventory Transfers" extra module activated.
/// </summary>
public int? PackageID { get; set; }
/// <summary>
/// Amount of packages
/// </summary>
public float? AmountOfPackages { get; set; }
/// <summary>
/// Amount of products contained in one package
/// </summary>
public float? AmountInPackage { get; set; }
/// <summary>
/// Readable package type name
/// </summary>
public string PackageType { get; set; }
/// <summary>
/// Type ID of the package.
/// </summary>
public int? PackageTypeID { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region InventoryWriteOff

public class InventoryWriteOff : ErplyItem
{
/// <summary>
/// ID of inventory write-off  
/// </summary>
public int? InventoryWriteOffID { get; set; }
/// <summary>
/// Inventory write-off number  
/// </summary>
public int? InventoryWriteOffNo { get; set; }
public int? CreatorID { get; set; }
public int? WarehouseID { get; set; }
public int? InventoryID { get; set; }
public int? RecipientID { get; set; }
/// <summary>
/// Currency code: EUR, USD.  
/// </summary>
public string CurrencyCode { get; set; }
/// <summary>
/// eg. 1.25543
/// Exchange rate of the inventory registration currency against system's default currency.  
/// </summary>
public float? CurrencyRate { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Inventory transaction date.
/// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
/// Inventory Reports and COGS reports are based on the inventory transaction date.  
/// </summary>
public string InventoryTransactionDate { get; set; }
public string Comments { get; set; }
public int? ReasonID { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Confirmed { get; set; }
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

#region InvoicePaymentType

public class InvoicePaymentType : ErplyItem
{
public int? Id { get; set; }
/// <summary>
/// A code name for this payment method.
/// In saveSalesDocument and getSalesDocuments API calls, you can refer to a payment method by its code name. This is convenient when working with standard payment methods (CASH, CARD etc.). However, you can also give code names to your own custom payment methods.  
/// </summary>
public string Type { get; set; }
public string Name { get; set; }
/// <summary>
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? PaidImmediately { get; set; }
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

#region IssuedCoupon

public class IssuedCoupon : ErplyItem
{
/// <summary>
/// ID of the issued coupon.  
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// ID of the coupon rule (see getCoupons). Coupon rule is like the "blueprint" or "type" of a printed coupon. The "blueprint" specifies in what circumstances the coupons will be printed from POS, and what promotion will apply when customer returns with the coupon — ie., what discount or extra value it effectively carries.  
/// </summary>
public int? CouponID { get; set; }
/// <summary>
/// See previous.  
/// </summary>
public string CouponCode { get; set; }
/// <summary>
/// Promotion name.  
/// </summary>
public string CampaignName { get; set; }
/// <summary>
/// Unique identifier of the coupon.  
/// </summary>
public int? UniqueIdentifier { get; set; }
/// <summary>
/// Issue time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? IssuedTimestamp { get; set; }
/// <summary>
/// Expiry date.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ExpiryDate { get; set; }
/// <summary>
/// Invoice the coupon was issued with.  
/// </summary>
public int? IssuedInvoiceID { get; set; }
/// <summary>
/// Invoice number.  
/// </summary>
public string IssuedInvoiceNo { get; set; }
/// <summary>
/// Customer the coupon was issued to.  
/// </summary>
public int? IssuedCustomerID { get; set; }
/// <summary>
/// Code of customer's loyalty/membership card.  
/// </summary>
public int? IssuedCustomerCardNumber { get; set; }
/// <summary>
/// Store or location where the coupon was issued.  
/// </summary>
public int? IssuedWarehouseID { get; set; }
/// <summary>
/// Store or location code.  
/// </summary>
public string IssuedWarehouseCode { get; set; }
/// <summary>
/// Register where the coupon was issued.  
/// </summary>
public int? IssuedPointOfSaleID { get; set; }
/// <summary>
/// Salesperson who issued the coupon.  
/// </summary>
public int? IssuedEmployeeID { get; set; }
/// <summary>
/// Denotes whether the coupon was printed automatically (as per coupon terms and conditions) or did the salesperson choose it manually.  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsPrintedAutomatically { get; set; }
/// <summary>
/// Accept time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? RedeemedTimestamp { get; set; }
/// <summary>
/// Invoice the coupon was redeemed with.  
/// </summary>
public int? RedeemedInvoiceID { get; set; }
/// <summary>
/// Invoice number.  
/// </summary>
public string RedeemedInvoiceNo { get; set; }
/// <summary>
/// Customer who redeemed the coupon.  
/// </summary>
public int? RedeemedCustomerID { get; set; }
/// <summary>
/// Code of customer's loyalty/membership card.  
/// </summary>
public int? RedeemedCustomerCardNumber { get; set; }
/// <summary>
/// Store or location where the coupon was accepted.  
/// </summary>
public int? RedeemedWarehouseID { get; set; }
/// <summary>
/// Store or location code.  
/// </summary>
public string RedeemedWarehouseCode { get; set; }
/// <summary>
/// Register where the coupon was accepted.  
/// </summary>
public int? RedeemedPointOfSaleID { get; set; }
/// <summary>
/// Salesperson who accepted the coupon.  
/// </summary>
public int? RedeemedEmployeeID { get; set; }
/// <summary>
/// Issued coupon status, possible statuses are 'ACTIVE', 'REDEEMED' AND 'EXPIRED'.  
/// </summary>
public string Status { get; set; }
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

#region LocationsInWarehouse

public class LocationsInWarehouse : ErplyItem
{
public int? LocationInWarehouseID { get; set; }
public string LocationInWarehouseName { get; set; }
}

#endregion

#region PointOfSaleStatus

public class PointOfSaleStatus : ErplyItem
{
public int? PointOfSaleID { get; set; }
/// <summary>
/// Register name  
/// </summary>
public string Name { get; set; }
public int? WarehouseID { get; set; }
public string WarehouseName { get; set; }
/// <summary>
/// Register status - 'open' or 'closed'  
/// </summary>
public string Status { get; set; }
/// <summary>
/// Last update time (opening or closing) as ISO date and time string ("yyyy-mm-dd hh:mm:ss"). This date and time is in the time zone of the location/store where the register is located. (Or in account's general time zone, if no time zone has been specified for the location.)  
/// </summary>
public string LastUpdatedTime { get; set; }
/// <summary>
/// Last update time (opening or closing) as timestamp  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastUpdatedUnixTime { get; set; }
}

#endregion

#region PrepaymentPercentage

public class PrepaymentPercentage : ErplyItem
{
public int? PercentageID { get; set; }
/// <summary>
/// 0 ≤ percentage ≤ 100
/// If you have erroneously defined a percentage in ERPLY backend that is not numeric, or smaller than 0, or greated than 100, it gets returned as 0 (in the first two cases) or 100 (in the last case).  
/// </summary>
public float? Percentage { get; set; }
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

#region ProductsInPriceList

public class ProductsInPriceList : ErplyItem
{
/// <summary>
/// ID of a price list row.  
/// </summary>
public int? PriceListProductID { get; set; }
public int? ProductID { get; set; }
/// <summary>
/// Discounted net sales price for a product.  
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Available only if Quantity discounts module is enabled on your account. The quantity threshold from which the specified price will apply.  
/// </summary>
public int? Amount { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public float? Subsidy { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public int? SubsidyTypeID { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public int? Page { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public int? PositionOnPage { get; set; }
/// <summary>
/// Available only if Price list row subsidy and other fields module is enabled on your account.  
/// </summary>
public int? ForecastUnits { get; set; }
}

#endregion

#region ProductsInSupplierPriceList

public class ProductsInSupplierPriceList : ErplyItem
{
/// <summary>
/// ID of a supplier price list row.  
/// </summary>
public int? SupplierPriceListProductID { get; set; }
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Discounted net sales price for a product.  
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Available only if Quantity discounts module is enabled on your account. The quantity threshold from which the specified price will apply.  
/// </summary>
public int? Amount { get; set; }
/// <summary>
/// Supplier Product Code.  
/// </summary>
public string SupplierCode { get; set; }
/// <summary>
/// Master Pack Quantity.  
/// </summary>
public int? MasterPackQuantity { get; set; }
/// <summary>
/// Minimum Order Quantity.  
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

#region ProductExtraField1Values

public class ProductExtraField1Values : ErplyItem
{
/// <summary>
/// Value ID.  
/// </summary>
public int? ValueID { get; set; }
/// <summary>
/// Value code.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Value name (in the specified language, or in account's default language otherwise).  
/// </summary>
public string Name { get; set; }
/// <summary>
/// 0 for archived options, 1 for active options.  
/// </summary>
public int? IsActive { get; set; }
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

#region ProductExtraField2Values

public class ProductExtraField2Values : ErplyItem
{
/// <summary>
/// Value ID.  
/// </summary>
public int? ValueID { get; set; }
/// <summary>
/// Value code.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Value name (in the specified language, or in account's default language otherwise).  
/// </summary>
public string Name { get; set; }
/// <summary>
/// 0 for archived options, 1 for active options.  
/// </summary>
public int? IsActive { get; set; }
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

#region ProductExtraField3Values

public class ProductExtraField3Values : ErplyItem
{
/// <summary>
/// Value ID.  
/// </summary>
public int? ValueID { get; set; }
/// <summary>
/// Value code.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Value name (in the specified language, or in account's default language otherwise).  
/// </summary>
public string Name { get; set; }
/// <summary>
/// 0 for archived options, 1 for active options.  
/// </summary>
public int? IsActive { get; set; }
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

#region ProductExtraField4Values

public class ProductExtraField4Values : ErplyItem
{
/// <summary>
/// Value ID.  
/// </summary>
public int? ValueID { get; set; }
/// <summary>
/// Value code.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Value name (in the specified language, or in account's default language otherwise).  
/// </summary>
public string Name { get; set; }
/// <summary>
/// 0 for archived options, 1 for active options.  
/// </summary>
public int? IsActive { get; set; }
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

#region ProductFile

public class ProductFile : ErplyItem
{
/// <summary>
/// ID of the file.  
/// </summary>
public int? ProductFileID { get; set; }
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// A descriptive name for the file. May be empty.  
/// </summary>
public string Name { get; set; }
/// <summary>
/// File type ID. Types are defined in Settings » Inventory settings » Product file types. See getProductFileTypes.  
/// </summary>
public int? TypeID { get; set; }
/// <summary>
/// Name of the file type.  
/// </summary>
public string TypeName { get; set; }
/// <summary>
/// A flag for categorizing the files.  
/// </summary>
public int? IsInformationFile { get; set; }
/// <summary>
/// URL of file.  
/// </summary>
public string FileURL { get; set; }
/// <summary>
/// A flag that indicates whether the file is stored as a local file in Erply, or as a URL to an external location, eg. a content delivery network.  
/// </summary>
public int? External { get; set; }
/// <summary>
/// A codename for the hosting provider, if the file is stored in an external location. May be empty.
/// This is used only for ERPLY's internal purposes, eg. to know how to remove files from a specific CDN when the file is removed from ERPLY.  
/// </summary>
public int? HostingProvider { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region ProductFileType

public class ProductFileType : ErplyItem
{
public int? TypeID { get; set; }
public string Name { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string LastModified { get; set; }
}

#endregion

#region ProductPackageType

public class ProductPackageType : ErplyItem
{
public int? PackageTypeID { get; set; }
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

#region ProductPricesInPriceList

public class ProductPricesInPriceList : ErplyItem
{
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Price list ID.  
/// </summary>
public int? PricelistID { get; set; }
/// <summary>
/// Price list name.  
/// </summary>
public string PricelistName { get; set; }
/// <summary>
/// Net sales price  
/// </summary>
public float? Price { get; set; }
/// <summary>
/// Available only if Quantity discounts module has been enabled on your account. The quantity threshold from which the specified price will apply.  
/// </summary>
public int? Amount { get; set; }
}

#endregion

#region Parameter

public class Parameter : ErplyItem
{
/// <summary>
/// Parameter ID  
/// </summary>
public int? ParameterID { get; set; }
/// <summary>
/// Parameter Name (eg. "Volume")  
/// </summary>
public string ParameterName { get; set; }
/// <summary>
/// Unit of measure for numeric values (eg. "L")  
/// </summary>
public string ParameterUnitName { get; set; }
/// <summary>
/// Possible values: TEXT, NUMERIC, BOOLEAN, MULTIVALUE.  
/// </summary>
public string ParameterType { get; set; }
/// <summary>
/// Group (or set) where this parameter belongs.  
/// </summary>
public int? ParameterGroupID { get; set; }
/// <summary>
/// Set name (eg. "Parameters for refrigerators").  
/// </summary>
public string ParameterGroupName { get; set; }
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
/// <summary>
/// Option ID
/// </summary>
public int? ParameterOptionID { get; set; }
/// <summary>
/// Option name
/// </summary>
public string ParameterOptionName { get; set; }
}

#endregion

#region ProjectStatus

public class ProjectStatus : ErplyItem
{
public int? ProjectStatusID { get; set; }
public string Name { get; set; }
[JsonConverter(typeof(BoolConverter))]
public bool? Finished { get; set; }
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

#region ProjectType

public class ProjectType : ErplyItem
{
public int? ProjectTypeID { get; set; }
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

#region PurchaseDocumentStatus

public class PurchaseDocumentStatus : ErplyItem
{
public int? DocumentStatusID { get; set; }
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

#region PurchaseReport

public class PurchaseReport : ErplyItem
{
/// <summary>
/// Link to report file.
/// The report is a CSV file in "latin1" encoding. Fields are separated by semicolons and quoted with double quotes. The file has a header line (with standard column headers, for identifying which field contains which data) and a footer line (with totals). Here is a sample (this is a report by supplier):
/// "LINE_NUMBER";"SUPPLIER_ID";"NAME";"PURCHASED_QUANTITY";"PURCHASE_VALUE";
/// "PURCHASE_TAX";"PURCHASE_TOTAL_WITH_TAX";"WAREHOUSE_VALUE"
/// "1";"4";"Chamberlin Marketing 2";"125301";"418127.61";"83622.68";"501750.29";"418127.61"
/// "2";"85";"China Imports";"17";"89.2";"17.84";"107.04";"89.2"
/// "TOTAL";"";"";"125318";"418216.81";"83640.52";"501857.32";"418216.81"
/// The escape character for literal quote characters is ", like in Microsoft Excel: "This ""word"" is quoted".
/// First line is a header line. Each column has a specific header identifier and you can use the headers to parse data out of the file. The last line in file is a total line, identified by the word "TOTAL" in line number column.
/// All reports have the following columns. (Columns are not necessarily in this specific order - here we have adjusted the order for clarity.)
/// LINE_NUMBER
/// PURCHASED_QUANTITY
/// PURCHASE_VALUE
/// PURCHASE_TAX
/// PURCHASE_TOTAL_WITH_TAX
/// WAREHOUSE_VALUE
/// The rest of the columns depend on selected report type (ie. how data is grouped). In PURCHASE_BY_PRODUCT, each report line corresponds to one product. IN PURCHASE_BY_SUPPLIER, each report line corresponds to one supplier.
/// Report PURCHASE_BY_PRODUCT additionally has the following columns:
/// PRODUCT_ID
/// CODE
/// NAME
/// In reports PURCHASE_BY_PRODUCT_GROUP, PURCHASE_BY_BRAND, PURCHASE_BY_SUPPLIER, PURCHASE_BY_SUPPLIER_GROUP, the additional columns are:
/// GROUP_ID, or BRAND_ID, or SUPPLIER_ID, or SUPPLIER_GROUP_ID
/// NAME
/// Report PURCHASE_BY_INVOICE has the following additional columns:
/// PURCHASE_DOCUMENT_ID
/// SUPPLIER_ID
/// DATE
/// WAREHOUSE_ID
/// INVOICE
/// SUPPLIER
/// Report PURCHASE_BY_INVOICE_ROWS has the following additional columns:
/// PURCHASE_DOCUMENT_ID
/// SUPPLIER_ID
/// PRODUCT_ID
/// DATE
/// WAREHOUSE_ID
/// INVOICE
/// SUPPLIER
/// CODE
/// NAME
/// </summary>
public string ReportLink { get; set; }
}

#endregion

#region ReasonCode

public class ReasonCode : ErplyItem
{
public int? ReasonID { get; set; }
public string Name { get; set; }
/// <summary>
/// Possible values: "WRITEOFF" - Inventory Write-off, "RETURN" - Return, "DISCOUNT" - Discount, "REGISTRATION" - Inventory registration, "EOD_VARIANCE" - End-of-Day variance, "TAX_EXEMPTION" - Tax exemption, "CASH_IN" - Cash In, "CASH_OUT" - Cash Out, "PROMOTION" - Promotion.  
/// </summary>
public string Purpose { get; set; }
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
/// <summary>
/// Reason code  
/// </summary>
public string Code { get; set; }
}

#endregion

#region ReceiptPrint

public class ReceiptPrint : ErplyItem
{
/// <summary>
/// Sales document that was printed. Depending on POS configuration (in the Swedish example), or depending on what you have registered with registerReceiptPrint, this might be a sales document of any type (an invoice-waybill, or even a sales order), not specifically a receipt.  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Register at which the sales document was printed. This might be different from the register in which the transaction was originally made.  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Printing time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
/// <summary>
/// Whether it was a reprint or not. (A print is a "reprint" if it is produced later — regardless of whether the customer already got a paper receipt at transaction time or not.)  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? IsReprint { get; set; }
/// <summary>
/// Total value of the sales document, in sales document's currency, with VAT.  
/// </summary>
public float? InvoiceTotal { get; set; }
}

#endregion

#region RedeemedCoupon

public class RedeemedCoupon : ErplyItem
{
/// <summary>
/// ID of the redeemed coupon.  
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// ID of coupon code.  
/// </summary>
public int? CouponID { get; set; }
/// <summary>
/// Coupon code.  
/// </summary>
public string CouponCode { get; set; }
/// <summary>
/// Unique identifier of the coupon.  
/// </summary>
public int? UniqueIdentifier { get; set; }
/// <summary>
/// Accept time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
/// <summary>
/// Invoice the coupon was redeemed with.  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Invoice number.  
/// </summary>
public string InvoiceNo { get; set; }
/// <summary>
/// Customer who redeemed the coupon.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Store or location where the coupon was accepted.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Store or location code.  
/// </summary>
public string WarehouseCode { get; set; }
/// <summary>
/// Register where the coupon was accepted.  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Salesperson who accepted the coupon.  
/// </summary>
public int? EmployeeID { get; set; }
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

#region RegisterTotalSalesOverTime

public class RegisterTotalSalesOverTime : ErplyItem
{
/// <summary>
/// Total value of all confirmed sales documents (invoices, invoice-waybills, receipts), with VAT, excluding credit invoices. Sales in other currencies are converted to account's default currency.  
/// </summary>
public float? TotalSales { get; set; }
/// <summary>
/// Total value of all confirmed credit invoices, with VAT.
/// This is a negative value (it is returned with a minus sign).
/// Note that credit invoices may still contain items with positive quantities. In point of sale, it is possible to do an "exchange", where customer returns some items and purchases new ones at the same time. An "exchange" is commonly saved as a Credit Invoice, too.  
/// </summary>
public float? TotalCreditInvoices { get; set; }
/// <summary>
/// =totalSales+totalCreditInvoices  
/// </summary>
public float? Total { get; set; }
}

#endregion

#region ReservedStock

public class ReservedStock : ErplyItem
{
/// <summary>
/// Product ID.  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Reserved amount.  
/// </summary>
public float? AmountReserved { get; set; }
}

#endregion

#region RoundedSale

public class RoundedSale : ErplyItem
{
/// <summary>
/// ID of sales document.  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Invoice number.  
/// </summary>
public string InvoiceNumber { get; set; }
/// <summary>
/// eg. 2010-01-29  
/// </summary>
public string Date { get; set; }
/// <summary>
/// Rounding amount.  
/// </summary>
public float? AmountOfRounding { get; set; }
}

#endregion

#region SalesDocumentActualReportsHTML

public class SalesDocumentActualReportsHTML : ErplyItem
{
/// <summary>
/// Printout HTML output.  
/// </summary>
public string Html { get; set; }
}

#endregion

#region SalesDocumentActualReportsDataset

public class SalesDocumentActualReportsDataset : ErplyItem
{
/// <summary>
/// Invoice, receipt, order or quote number. Except for quotes, document number is assigned when document is confirmed, and thus unconfirmed documents do not have a number. Example: "14000105".  
/// </summary>
public string DocumentNumber { get; set; }
/// <summary>
/// Notes to be printed on the sales document or receipt.  
/// </summary>
public string Notes { get; set; }
/// <summary>
/// Information about the document, for internal use and handling. These should not be displayed on a printout that is delivered to the customer.  
/// </summary>
public string PrivateNotes { get; set; }
/// <summary>
/// Invoice late fee: a percentage of invoice total that will be additionally collected per day after invoice due date, while the invoice is still unpaid. A numeric value (an integer or a decimal), for example 2 or 2.5 — or an empty string.
/// Erply does not automatically collect the fee, or increase invoice total; if you want to collect a late fee, you need to manually issue a separate invoice for it.
/// </summary>
public string Penalty { get; set; }
/// <summary>
/// Document type (in selected language) and document number, joined together. Example: "Receipt 14000105".  
/// </summary>
public string DocumentName { get; set; }
/// <summary>
/// Document issue date, in localized format. Example: "05/16/2019".  
/// </summary>
public string DocumentDate { get; set; }
/// <summary>
/// Document issue time — currently always returned as "hh:mm:ss", but may potentially be changed to a localized format.  
/// </summary>
public string DocumentTime { get; set; }
/// <summary>
/// URL of a company logo, for A4 / Letter-sized printouts. You must upload the logo in Erply back office, in the Settings → Configuration module.  
/// </summary>
public string LogoOnInvoicesURL { get; set; }
/// <summary>
/// URL of a company logo, for receipt-sized printouts. You must upload the logo in Erply back office, in the Settings → Configuration module.  
/// </summary>
public string LogoOnReceiptsURL { get; set; }
/// <summary>
/// Payment method specified on the document (in selected language). You may show it on a printout in case you want to emphasize what payment method was agreed with the customer. Sales documents in Erply can be associated with multiple payments of any type, so this field is not a reliable indicator of how the invoice was actually paid.  
/// </summary>
public string PaymentType { get; set; }
/// <summary>
/// Contents of the field "Message in receipt footer" from Settings → Configuration → Receipt printouts, or from location card. (The latter overrides the former.)  
/// </summary>
public string CashReceiptGreeting { get; set; }
/// <summary>
/// The text "Application of 0% VAT rate is based on Council Directive 2006/112/EC of 28 November 2006.", for intra-EU invoices. Empty if not applicable.  
/// </summary>
public string ZeroVatRateNotice { get; set; }
/// <summary>
/// Contents of the field "Factoring notice on the invoice" from Settings → Configuration → Sales document printouts, if sales document customer has been marked as a customer who pays via factoring.  
/// </summary>
public string FactoringNoticeOnInvoice { get; set; }
/// <summary>
/// Field "Shipping date" on the document, in localized format. Example: "05/16/2019".  
/// </summary>
public string ShippingDate { get; set; }
/// <summary>
/// Only for quotes — the date until which the quote is valid. The date is in localized format. Example: "05/16/2019".  
/// </summary>
public int? ValidUntilDate { get; set; }
/// <summary>
/// Invoice due date, in localized format. Returned for all documents except quotes. Quotes cannot be "paid" and thus do not have a concept of a payment deadline. Example: "05/16/2019".  
/// </summary>
public string DeadlineDate { get; set; }
/// <summary>
/// In how many days since issuance the invoice will be due. The value is returned as a number, with the word "days" (in currently selected language) appended to it. Example: "20 days"  
/// </summary>
public string PaymentDeadlineNumberOfDays { get; set; }
/// <summary>
/// Store / location name.  
/// </summary>
public string WarehouseName { get; set; }
/// <summary>
/// Name of the register (point of sale), if the document was issued from a register.  
/// </summary>
public string RegisterName { get; set; }
/// <summary>
/// Fiscal device number for the register, configured on register form.  
/// </summary>
public string FiscalDeviceNumber { get; set; }
/// <summary>
/// Full name of the customer.  
/// </summary>
public string CustomerName { get; set; }
/// <summary>
/// Customer's company code, or a person's national ID, as entered on customer card.  
/// </summary>
public string CustomerCode { get; set; }
/// <summary>
/// Customer's phone number, as entered on customer card.  
/// </summary>
public string CustomerPhone { get; set; }
/// <summary>
/// Customer's email address, as entered on customer card.  
/// </summary>
public string CustomerEmail { get; set; }
/// <summary>
/// Customer's mobile phone number, as entered on customer card.  
/// </summary>
public string CustomerMobile { get; set; }
/// <summary>
/// Customer's fax number, as entered on customer card.  
/// </summary>
public string CustomerFax { get; set; }
/// <summary>
/// Customer's VAT number / Tax Identification Number, as entered on customer card.  
/// </summary>
public string CustomerVatNumber { get; set; }
/// <summary>
/// Name of the employee who has been designated as the customer manager, formatted as "Firstname Lastname".  
/// </summary>
public string CustomerManager { get; set; }
/// <summary>
/// Customer's loyalty number, as entered on customer card.  
/// </summary>
public string CustomerLoyaltyCardCode { get; set; }
/// <summary>
/// Name of the customer's bank, as entered on customer card.  
/// </summary>
public string CustomerBankName { get; set; }
/// <summary>
/// Customer's bank account number, as entered on customer card.  
/// </summary>
public string CustomerBankAccountNumber { get; set; }
/// <summary>
/// Name of the customer group the customer has been placed into.  
/// </summary>
public string CustomerGroup { get; set; }
/// <summary>
/// First line of the address: street and building.  
/// </summary>
public string CustomerAddressStreetAndBuilding { get; set; }
/// <summary>
/// In certain countries only: the "line 2" of an address, which may be used for apartment or suite number.  
/// </summary>
public string CustomerAddressAddressLine2 { get; set; }
/// <summary>
/// Town or city.  
/// </summary>
public string CustomerAddressTownOrCity { get; set; }
/// <summary>
/// Postal code.  
/// </summary>
public string CustomerAddressPostalCode { get; set; }
/// <summary>
/// Country, as entered on customer card.  
/// </summary>
public string CustomerAddressCountry { get; set; }
/// <summary>
/// In certain countries only: state or province.  
/// </summary>
public string CustomerAddressState { get; set; }
/// <summary>
/// Full address, address lines separated with <br> tags.  
/// </summary>
public string CustomerAddressFull { get; set; }
public string CustomerAddressLabelLine1 { get; set; }
public string CustomerAddressLabelLine2 { get; set; }
public string CustomerAddressLabelLine3 { get; set; }
public string CustomerAddressLabelLine4 { get; set; }
/// <summary>
/// Contact person's name, formatted as "Firstname Lastname".  
/// </summary>
public string CustomerContactName { get; set; }
/// <summary>
/// Contact person's email address, as entered on contact card.  
/// </summary>
public string CustomerContactEmail { get; set; }
/// <summary>
/// Contact person's phone number, as entered on contact card.  
/// </summary>
public string CustomerContactPhone { get; set; }
/// <summary>
/// Contact person's mobile phone number, as entered on contact card.  
/// </summary>
public string CustomerContactMobile { get; set; }
/// <summary>
/// Contact person's fax number, as entered on contact card.  
/// </summary>
public string CustomerContactFax { get; set; }
/// <summary>
/// Full name of the payer.  
/// </summary>
public string PayerName { get; set; }
/// <summary>
/// Payer's company code, or a person's national ID, as entered on customer card.  
/// </summary>
public string PayerCode { get; set; }
/// <summary>
/// Payer's phone number, as entered on customer card.  
/// </summary>
public string PayerPhone { get; set; }
/// <summary>
/// Payer's email address, as entered on customer card.  
/// </summary>
public string PayerEmail { get; set; }
/// <summary>
/// Payer's mobile phone number, as entered on customer card.  
/// </summary>
public string PayerMobile { get; set; }
/// <summary>
/// Payer's fax number, as entered on customer card.  
/// </summary>
public string PayerFax { get; set; }
/// <summary>
/// Payer's VAT number / Tax Identification Number, as entered on customer card.  
/// </summary>
public string PayerVatNumber { get; set; }
/// <summary>
/// Name of the employee who has been designated as the customer manager, formatted as "Firstname Lastname".  
/// </summary>
public string PayerManager { get; set; }
/// <summary>
/// Payer's loyalty number, as entered on customer card.  
/// </summary>
public string PayerLoyaltyCardCode { get; set; }
/// <summary>
/// Name of the customer's bank, as entered on customer card.  
/// </summary>
public string PayerBankName { get; set; }
/// <summary>
/// Payer's bank account number, as entered on customer card.  
/// </summary>
public string PayerBankAccountNumber { get; set; }
/// <summary>
/// Name of the customer group the customer has been placed into.  
/// </summary>
public string PayerGroup { get; set; }
/// <summary>
/// First line of the address: street and building.  
/// </summary>
public string PayerAddressStreetAndBuilding { get; set; }
/// <summary>
/// In certain countries only: the "line 2" of an address, which may contain apartment or suite number.  
/// </summary>
public string PayerAddressAddressLine2 { get; set; }
/// <summary>
/// Town or city.  
/// </summary>
public string PayerAddressTownOrCity { get; set; }
/// <summary>
/// Postal code.  
/// </summary>
public string PayerAddressPostalCode { get; set; }
/// <summary>
/// Country, as entered on customer card.  
/// </summary>
public string PayerAddressCountry { get; set; }
/// <summary>
/// In certain countries only: state or province.  
/// </summary>
public string PayerAddressState { get; set; }
/// <summary>
/// Full address, address lines separated with <br> tags.  
/// </summary>
public string PayerAddressFull { get; set; }
/// <summary>
/// Full name of the recipient (Ship To).  
/// </summary>
public string ShipToName { get; set; }
/// <summary>
/// Recipient's company code, or a person's national ID, as entered on customer card.  
/// </summary>
public string ShipToCode { get; set; }
/// <summary>
/// Recipient's phone number, as entered on customer card.  
/// </summary>
public string ShipToPhone { get; set; }
/// <summary>
/// Recipient's email address, as entered on customer card.  
/// </summary>
public string ShipToEmail { get; set; }
/// <summary>
/// Recipient's mobile phone number, as entered on customer card.  
/// </summary>
public string ShipToMobile { get; set; }
/// <summary>
/// Recipient's fax number, as entered on customer card.  
/// </summary>
public string ShipToFax { get; set; }
/// <summary>
/// Recipient's VAT number / Tax Identification Number, as entered on customer card.  
/// </summary>
public string ShipToVatNumber { get; set; }
/// <summary>
/// Name of the employee who has been designated as the customer manager, formatted as "Firstname Lastname".  
/// </summary>
public string ShipToManager { get; set; }
/// <summary>
/// Recipient's loyalty number, as entered on customer card.  
/// </summary>
public string ShipToLoyaltyCardCode { get; set; }
/// <summary>
/// First line of the address: street and building.  
/// </summary>
public string ShipToAddressStreetAndBuilding { get; set; }
/// <summary>
/// In certain countries only: the "line 2" of an address, which may contain apartment or suite number.  
/// </summary>
public string ShipToAddressAddressLine2 { get; set; }
/// <summary>
/// Town or city.  
/// </summary>
public string ShipToAddressTownOrCity { get; set; }
/// <summary>
/// Postal code.  
/// </summary>
public string ShipToAddressPostalCode { get; set; }
/// <summary>
/// Country, as entered on customer card.  
/// </summary>
public string ShipToAddressCountry { get; set; }
/// <summary>
/// In certain countries only: state or province.  
/// </summary>
public string ShipToAddressState { get; set; }
/// <summary>
/// Full address, address lines separated with <br> tags.  
/// </summary>
public string ShipToAddressFull { get; set; }
public string ShipToAddressLabelLine1 { get; set; }
public string ShipToAddressLabelLine2 { get; set; }
public string ShipToAddressLabelLine3 { get; set; }
public string ShipToAddressLabelLine4 { get; set; }
public string ReferenceNumber { get; set; }
public string CompanyName { get; set; }
public string CompanyAddressAddressLine2 { get; set; }
public string CompanyAddressTownOrCity { get; set; }
public string CompanyAddressPostalCode { get; set; }
public string CompanyAddressCountry { get; set; }
public string CompanyAddressState { get; set; }
public string CompanyAddressFull { get; set; }
public string CompanyPhone { get; set; }
public string CompanyFax { get; set; }
public string CompanyEmail { get; set; }
public string CompanyWeb { get; set; }
public string CompanyRegCode { get; set; }
public string CompanyVatNumber { get; set; }
public string CompanyNotes { get; set; }
public string CompanyAccountNumber { get; set; }
public string CompanyBank { get; set; }
public string CompanySWIFT { get; set; }
public string CompanyIBAN { get; set; }
public string CompanyAccountNumber2 { get; set; }
public string CompanyBank2 { get; set; }
public string CompanySWIFT2 { get; set; }
public string CompanyIBAN2 { get; set; }
public string EmployeeName { get; set; }
public string EmployeeJobTitle { get; set; }
public string EmployeePhone { get; set; }
public string EmployeeFax { get; set; }
public string EmployeeMobile { get; set; }
public string EmployeeEmail { get; set; }
public string ShipmentPackedBy { get; set; }
public string PackedByJobTitle { get; set; }
public string PackedByPhone { get; set; }
public string PackedByFax { get; set; }
public string PackedByMobile { get; set; }
public string PackedByEmail { get; set; }
public string Currency { get; set; }
public string CurrencySymbol { get; set; }
public string DeliveryType { get; set; }
public string ProjectName { get; set; }
public string Status { get; set; }
public string PaymentStatus { get; set; }
/// <summary>
/// This field is returned only when the "Appliances" module is installed.  
/// </summary>
public string ApplianceSerialNumber { get; set; }
/// <summary>
/// This field is returned only when the "Appliances" module is installed.  
/// </summary>
public string ApplianceReference { get; set; }
/// <summary>
/// This field is returned only when the "Cars" module is installed.  
/// </summary>
public string VehicleLicencePlate { get; set; }
/// <summary>
/// This field is returned only when the "Cars" module is installed.  
/// </summary>
public string VehicleMileage { get; set; }
/// <summary>
/// This field is returned only when the "Cars" module is installed.  
/// </summary>
public string VehicleReference { get; set; }
public int? No { get; set; }
public string Code { get; set; }
public string Code2 { get; set; }
public string Code3 { get; set; }
public string EAN { get; set; }
public string SupplierCode { get; set; }
public string Title { get; set; }
public string ProductGroup { get; set; }
public string Category { get; set; }
public string Brand { get; set; }
public string Supplier { get; set; }
public string PriorityGroup { get; set; }
public string Manufacturer { get; set; }
public string CountryOfOrigin { get; set; }
public string CountryOfOriginCode { get; set; }
public string UsualDeliveryTime { get; set; }
public string Description { get; set; }
public string LongDescription { get; set; }
public string ProductName { get; set; }
public string SalesForPeriod { get; set; }
public string Amount { get; set; }
public string Unit { get; set; }
public string FinalNetPrice { get; set; }
public string FinalPriceWithVAT { get; set; }
public string FinalNetPriceWithCurrency { get; set; }
public string FinalPriceWithVATWithCurrency { get; set; }
public string RowNetTotal { get; set; }
public string RowNetTotalWithCurrency { get; set; }
public string RowVAT { get; set; }
public string RowVATWithCurrency { get; set; }
public string RowTotal { get; set; }
public string RowTotalWithCurrency { get; set; }
public string Discount { get; set; }
public string VatRate { get; set; }
public string OriginalNetPrice { get; set; }
public int? OriginalPriceWithVAT { get; set; }
public string OriginalNetPriceWithCurrency { get; set; }
public string OriginalPriceWithVATWithCurrency { get; set; }
public string LocationInWarehouse { get; set; }
public string ImageURL1 { get; set; }
public string ImageURL2 { get; set; }
public string ImageURL3 { get; set; }
public string Packages { get; set; }
public int? AmountInStock { get; set; }
public int? AmountReserved { get; set; }
public int? AmountAvailable { get; set; }
public string ProductLength { get; set; }
public string ProductLengthWithUnit { get; set; }
public int? ProductWidth { get; set; }
public int? ProductWidthWithUnit { get; set; }
public string ProductHeight { get; set; }
public string ProductHeightWithUnit { get; set; }
public string ProductVolume { get; set; }
public string ProductVolumeWithUnit { get; set; }
public string ProductNetWeight { get; set; }
public string ProductNetWeightWithUnit { get; set; }
public string ProductGrossWeight { get; set; }
public string ProductGrossWeightWithUnit { get; set; }
public string NetWeight { get; set; }
public string NetWeightWithUnits { get; set; }
public string GrossWeight { get; set; }
public string GrossWeightWithUnits { get; set; }
public string Dimension1Name { get; set; }
public string Dimension1Value { get; set; }
public string Dimension1Code { get; set; }
public string Dimension2Name { get; set; }
public string Dimension2Value { get; set; }
public string Dimension2Code { get; set; }
public string Dimension3Name { get; set; }
public string Dimension3Value { get; set; }
public string Dimension3Code { get; set; }
public string Parameter1Name { get; set; }
public string Parameter1Value { get; set; }
public string Parameter2Name { get; set; }
public string Parameter2Value { get; set; }
public string Parameter3Name { get; set; }
public string Parameter3Value { get; set; }
public string Parameter4Name { get; set; }
public string Parameter4Value { get; set; }
public string Parameter5Name { get; set; }
public string Parameter5Value { get; set; }
public string Parameter6Name { get; set; }
public string Parameter6Value { get; set; }
public string Parameter7Name { get; set; }
public string Parameter7Value { get; set; }
public string Parameter8Name { get; set; }
public string Parameter8Value { get; set; }
public string Parameter9Name { get; set; }
public string Parameter9Value { get; set; }
public string Parameter10Name { get; set; }
public string Parameter10Value { get; set; }
public string ReasonCode { get; set; }
public string RealPercentageDiscount { get; set; }
public string RealDiscountBasePrice { get; set; }
public string RealDiscountBasePriceWithCurrency { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_name
/// </summary>
public string VatComponent_{componentName}_{componentType}_name { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_type
/// </summary>
public string VatComponent_{componentName}_{componentType}_type { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed. For example: vatComponent_my_tax_CITY_amountOfTax
/// </summary>
public string VatComponent_{componentName}_{componentType}_amountOfTax { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_amountOfTaxWithCurrency
/// </summary>
public string VatComponent_{componentName}_{componentType}_amountOfTaxWithCurrency { get; set; }
public int? No { get; set; }
public string Code { get; set; }
public string Code2 { get; set; }
public string Code3 { get; set; }
public string EAN { get; set; }
public string SupplierCode { get; set; }
public string Title { get; set; }
public string ProductGroup { get; set; }
public string Category { get; set; }
public string Brand { get; set; }
public string Supplier { get; set; }
public string PriorityGroup { get; set; }
public string Manufacturer { get; set; }
public string CountryOfOrigin { get; set; }
public string CountryOfOriginCode { get; set; }
public string UsualDeliveryTime { get; set; }
public string Description { get; set; }
public string LongDescription { get; set; }
public string ProductName { get; set; }
public string SalesForPeriod { get; set; }
public string Amount { get; set; }
public string Unit { get; set; }
public string FinalNetPrice { get; set; }
public string FinalPriceWithVAT { get; set; }
public string FinalNetPriceWithCurrency { get; set; }
public string FinalPriceWithVATWithCurrency { get; set; }
public int? RowNetTotal { get; set; }
public string RowNetTotalWithCurrency { get; set; }
public int? RowVAT { get; set; }
public string RowVATWithCurrency { get; set; }
public int? RowTotal { get; set; }
public string RowTotalWithCurrency { get; set; }
public string Discount { get; set; }
public string VatRate { get; set; }
public string OriginalNetPrice { get; set; }
public int? OriginalPriceWithVAT { get; set; }
public string OriginalNetPriceWithCurrency { get; set; }
public string OriginalPriceWithVATWithCurrency { get; set; }
public string LocationInWarehouse { get; set; }
public string ImageURL1 { get; set; }
public string ImageURL2 { get; set; }
public string ImageURL3 { get; set; }
public string Packages { get; set; }
public int? AmountInStock { get; set; }
public int? AmountReserved { get; set; }
public int? AmountAvailable { get; set; }
public string ProductLength { get; set; }
public string ProductLengthWithUnit { get; set; }
public int? ProductWidth { get; set; }
public int? ProductWidthWithUnit { get; set; }
public string ProductHeight { get; set; }
public string ProductHeightWithUnit { get; set; }
public string ProductVolume { get; set; }
public string ProductVolumeWithUnit { get; set; }
public string ProductNetWeight { get; set; }
public string ProductNetWeightWithUnit { get; set; }
public string ProductGrossWeight { get; set; }
public string ProductGrossWeightWithUnit { get; set; }
public string NetWeight { get; set; }
public string NetWeightWithUnits { get; set; }
public string GrossWeight { get; set; }
public string GrossWeightWithUnits { get; set; }
public string Dimension1Name { get; set; }
public string Dimension1Value { get; set; }
public string Dimension1Code { get; set; }
public string Dimension2Name { get; set; }
public string Dimension2Value { get; set; }
public string Dimension2Code { get; set; }
public string Dimension3Name { get; set; }
public string Dimension3Value { get; set; }
public string Dimension3Code { get; set; }
public string Parameter1Name { get; set; }
public string Parameter1Value { get; set; }
public string Parameter2Name { get; set; }
public string Parameter2Value { get; set; }
public string Parameter3Name { get; set; }
public string Parameter3Value { get; set; }
public string Parameter4Name { get; set; }
public string Parameter4Value { get; set; }
public string Parameter5Name { get; set; }
public string Parameter5Value { get; set; }
public string Parameter6Name { get; set; }
public string Parameter6Value { get; set; }
public string Parameter7Name { get; set; }
public string Parameter7Value { get; set; }
public string Parameter8Name { get; set; }
public string Parameter8Value { get; set; }
public string Parameter9Name { get; set; }
public string Parameter9Value { get; set; }
public string Parameter10Name { get; set; }
public string Parameter10Value { get; set; }
public string ReasonCode { get; set; }
public string RealPercentageDiscount { get; set; }
public string RealDiscountBasePrice { get; set; }
public string RealDiscountBasePriceWithCurrency { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_name
/// </summary>
public string VatComponent_{componentName}_{componentType}_name { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_type
/// </summary>
public string VatComponent_{componentName}_{componentType}_type { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed. For example: vatComponent_my_tax_CITY_amountOfTax
/// </summary>
public string VatComponent_{componentName}_{componentType}_amountOfTax { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_amountOfTaxWithCurrency
/// </summary>
public string VatComponent_{componentName}_{componentType}_amountOfTaxWithCurrency { get; set; }
public int? No { get; set; }
public string Code { get; set; }
public string Code2 { get; set; }
public string Code3 { get; set; }
public string EAN { get; set; }
public string SupplierCode { get; set; }
public string Title { get; set; }
public string ProductGroup { get; set; }
public string Category { get; set; }
public string Brand { get; set; }
public string Supplier { get; set; }
public string PriorityGroup { get; set; }
public string Manufacturer { get; set; }
public string CountryOfOrigin { get; set; }
public string CountryOfOriginCode { get; set; }
public string UsualDeliveryTime { get; set; }
public string Description { get; set; }
public string LongDescription { get; set; }
public string ProductName { get; set; }
public string SalesForPeriod { get; set; }
public string Amount { get; set; }
public string Unit { get; set; }
public string FinalNetPrice { get; set; }
public string FinalPriceWithVAT { get; set; }
public string FinalNetPriceWithCurrency { get; set; }
public string FinalPriceWithVATWithCurrency { get; set; }
public string RowNetTotal { get; set; }
public string RowNetTotalWithCurrency { get; set; }
public string RowVAT { get; set; }
public string RowVATWithCurrency { get; set; }
public string RowTotal { get; set; }
public string RowTotalWithCurrency { get; set; }
public string Discount { get; set; }
public string VatRate { get; set; }
public string OriginalNetPrice { get; set; }
public int? OriginalPriceWithVAT { get; set; }
public string OriginalNetPriceWithCurrency { get; set; }
public string OriginalPriceWithVATWithCurrency { get; set; }
public string LocationInWarehouse { get; set; }
public string ImageURL1 { get; set; }
public string ImageURL2 { get; set; }
public string ImageURL3 { get; set; }
public string Packages { get; set; }
public int? AmountInStock { get; set; }
public int? AmountReserved { get; set; }
public int? AmountAvailable { get; set; }
public string ProductLength { get; set; }
public string ProductLengthWithUnit { get; set; }
public int? ProductWidth { get; set; }
public int? ProductWidthWithUnit { get; set; }
public string ProductHeight { get; set; }
public string ProductHeightWithUnit { get; set; }
public string ProductVolume { get; set; }
public string ProductVolumeWithUnit { get; set; }
public string ProductNetWeight { get; set; }
public string ProductNetWeightWithUnit { get; set; }
public string ProductGrossWeight { get; set; }
public string ProductGrossWeightWithUnit { get; set; }
public string NetWeight { get; set; }
public string NetWeightWithUnits { get; set; }
public string GrossWeight { get; set; }
public string GrossWeightWithUnits { get; set; }
public string Dimension1Name { get; set; }
public string Dimension1Value { get; set; }
public string Dimension1Code { get; set; }
public string Dimension2Name { get; set; }
public string Dimension2Value { get; set; }
public string Dimension2Code { get; set; }
public string Dimension3Name { get; set; }
public string Dimension3Value { get; set; }
public string Dimension3Code { get; set; }
public string Parameter1Name { get; set; }
public string Parameter1Value { get; set; }
public string Parameter2Name { get; set; }
public string Parameter2Value { get; set; }
public string Parameter3Name { get; set; }
public string Parameter3Value { get; set; }
public string Parameter4Name { get; set; }
public string Parameter4Value { get; set; }
public string Parameter5Name { get; set; }
public string Parameter5Value { get; set; }
public string Parameter6Name { get; set; }
public string Parameter6Value { get; set; }
public string Parameter7Name { get; set; }
public string Parameter7Value { get; set; }
public string Parameter8Name { get; set; }
public string Parameter8Value { get; set; }
public string Parameter9Name { get; set; }
public string Parameter9Value { get; set; }
public string Parameter10Name { get; set; }
public string Parameter10Value { get; set; }
public string ReasonCode { get; set; }
public string RealPercentageDiscount { get; set; }
public string RealDiscountBasePrice { get; set; }
public string RealDiscountBasePriceWithCurrency { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_name
/// </summary>
public string VatComponent_{componentName}_{componentType}_name { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_type
/// </summary>
public string VatComponent_{componentName}_{componentType}_type { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed. For example: vatComponent_my_tax_CITY_amountOfTax
/// </summary>
public string VatComponent_{componentName}_{componentType}_amountOfTax { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_amountOfTaxWithCurrency
/// </summary>
public string VatComponent_{componentName}_{componentType}_amountOfTaxWithCurrency { get; set; }
/// <summary>
/// Appears on prepayment invoices. The amount that customer is required to pay in advance (before the order will be confirmed, or before the goods can be shipped). Net total (the prepayment amount without tax). Numeric string, with 2 decimal places, in localized format.  
/// </summary>
public string AdvancePaymentNetTotal { get; set; }
/// <summary>
/// Appears on prepayment invoices. The amount that customer is required to pay in advance (before the order will be confirmed, or before the goods can be shipped). Tax total (prepayment sales tax / VAT). Numeric string, with 2 decimal places, in localized format.  
/// </summary>
public string AdvancePaymentVatTotal { get; set; }
/// <summary>
/// Appears on prepayment invoices. The amount that customer is required to pay in advance (before the order will be confirmed, or before the goods can be shipped). Total (the prepayment amount with tax included). Numeric string, with 2 decimal places, in localized format.  
/// </summary>
public string AdvancePaymentTotal { get; set; }
/// <summary>
/// Same as previous, but with currency symbol prepended/appended to the amount.  
/// </summary>
public string AdvancePaymentNetTotalWithCurrency { get; set; }
/// <summary>
/// Same as previous, but with currency symbol prepended/appended to the amount.  
/// </summary>
public string AdvancePaymentVatTotalWithCurrency { get; set; }
/// <summary>
/// Same as previous, but with currency symbol prepended/appended to the amount.  
/// </summary>
public string AdvancePaymentTotalWithCurrency { get; set; }
/// <summary>
/// Sales document net total, as an integer/float value.  
/// </summary>
public float? NetTotal { get; set; }
/// <summary>
/// Sales document tax total, as an integer/float value.  
/// </summary>
public float? VatTotal { get; set; }
/// <summary>
/// Sales document rounding, as an integer/float value. Rounding may be manually applied by the user, or automatically applied if a rounding rule has been activated from Settings → Configuration: round to closest 0.05, round to closest 0.10, or round to full currency units.  
/// </summary>
public float? Rounding { get; set; }
public float? Total { get; set; }
/// <summary>
/// Sales document net total. Numeric string, with 2 decimal places, in localized format, with currency symbol prepended/appended to the amount.  
/// </summary>
public string NetTotalWithCurrency { get; set; }
/// <summary>
/// Sales document tax total. Numeric string, with 2 decimal places, in localized format, with currency symbol prepended/appended to the amount.  
/// </summary>
public string VatTotalWithCurrency { get; set; }
/// <summary>
/// Sales document rounding. Numeric string, with 2 decimal places, in localized format, with currency symbol prepended/appended to the amount.  
/// </summary>
public string RoundingWithCurrency { get; set; }
/// <summary>
/// Sales document total (net total + tax total + optional rounding). Numeric string, with 2 decimal places, in localized format, with currency symbol prepended/appended to the amount.  
/// </summary>
public string TotalWithCurrency { get; set; }
/// <summary>
/// Informative value: how much "net discount" (total amount of money) has been given to the customer in this transaction.
/// How this number gets calculated may depend on how the sales document was exactly created. For POS transactions, the total discount typically excludes price list discounts, and includes promotions and manual discounts.
/// Numeric string, with 2 decimal places, in localized format.
/// The "net discount" value should be used in a context where sales document calculation is based on net prices: in B2B invoicing, or in US/Canadian retail.
/// </summary>
public string TotalDiscountSum { get; set; }
/// <summary>
/// Informative value: how much "discount with tax" (total amount of money) has been given to the customer in this transaction.
/// How this number gets calculated may depend on how the sales document was exactly created. For POS transactions, the total discount typically excludes price list discounts, and includes promotions and manual discounts.
/// Numeric string, with 2 decimal places, in localized format.
/// The "discount with tax" value should be used in a context where sales document calculation is based on prices with VAT, ie. in non-US retail.
/// </summary>
public string TotalDiscountSumWithVAT { get; set; }
/// <summary>
/// Same as previous, but with currency symbol prepended/appended to the amount.  
/// </summary>
public string TotalDiscountSumWithCurrency { get; set; }
/// <summary>
/// Same as previous, but with currency symbol prepended/appended to the amount.  
/// </summary>
public string TotalDiscountSumWithVATWithCurrency { get; set; }
public string TotalDiscountPercent { get; set; }
public string Rate { get; set; }
public string Name { get; set; }
public int? Total { get; set; }
public string TotalWithCurrency { get; set; }
public string NetTotal { get; set; }
public string NetTotalWithCurrency { get; set; }
public string Rate { get; set; }
public string Name { get; set; }
public string Total { get; set; }
public string TotalWithCurrency { get; set; }
public string ReverseVatTotal { get; set; }
public string ReverseVatTotalWithCurrency { get; set; }
public string AdvancePaymentReverseVatTotal { get; set; }
public string AdvancePaymentReverseVatTotalWithCurrency { get; set; }
public string SumWithWords { get; set; }
public string TotalNetWeight { get; set; }
public string TotalNetWeightWithUnits { get; set; }
public string TotalGrossWeight { get; set; }
public string TotalGrossWeightWithUnits { get; set; }
public string TotalAmount { get; set; }
public string Date { get; set; }
public string Time { get; set; }
public string DateTime { get; set; }
public string Currency { get; set; }
public string Type { get; set; }
public string PayerName { get; set; }
public string Info { get; set; }
public string Sum { get; set; }
public int? Paid { get; set; }
public string Change { get; set; }
public string SumWithCurrency { get; set; }
public int? PaidWithCurrency { get; set; }
public string ChangeWithCurrency { get; set; }
public string CardNumber { get; set; }
public string CardType { get; set; }
public string CardHolder { get; set; }
public string AuthorizationCode { get; set; }
public string ReferenceNumber { get; set; }
public int? PaidTotal { get; set; }
public string InvoiceBalance { get; set; }
public int? PaidTotalWithCurrency { get; set; }
public string InvoiceBalanceWithCurrency { get; set; }
public string BaseDocuments { get; set; }
public string CurrentDateTime { get; set; }
public string CurrentDate { get; set; }
public string CurrentTime { get; set; }
public string RemainingTaxableNetTotal { get; set; }
public string RemainingTaxableVatTotal { get; set; }
public string RemainingTaxableTotal { get; set; }
public string RemainingTaxableNetTotalWithCurrency { get; set; }
public string RemainingTaxableVatTotalWithCurrency { get; set; }
public string RemainingTaxableTotalWithCurrency { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_name  
/// </summary>
public string VatComponent_{componentName}_{componentType}_name { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_type  
/// </summary>
public string VatComponent_{componentName}_{componentType}_type { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.For example: vatComponent_my_tax_CITY_amountOfTax
/// </summary>
public string VatComponent_{componentName}_{componentType}_amountOfTax { get; set; }
/// <summary>
/// These fields are returned only if module "VAT rate components" is installed.
/// For example: vatComponent_my_tax_CITY_amountOfTaxWithCurrency  
/// </summary>
public string VatComponent_{componentName}_{componentType}_amountOfTaxWithCurrency { get; set; }
/// <summary>
/// For example: attribute_deliverytype_id  
/// </summary>
public string Attribute_{attributeName} { get; set; }
}

#endregion

#region SalesTotalsByEmployeeAndDay

public class SalesTotalsByEmployeeAndDay : ErplyItem
{
/// <summary>
/// Total sales. In US, this is net sales total. In other countries, this is the sales total with VAT.  
/// </summary>
public string Total { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date { get; set; }
public int? EmployeeID { get; set; }
}

#endregion

#region SalesTotalsByEmployeeAndMonth

public class SalesTotalsByEmployeeAndMonth : ErplyItem
{
/// <summary>
/// Total sales. In US, this is net sales total. In other countries, this is the sales total with VAT.  
/// </summary>
public string Total { get; set; }
public int? Year { get; set; }
public int? Month { get; set; }
public int? EmployeeID { get; set; }
}

#endregion

#region SalesTotalsByWarehouseAndDay

public class SalesTotalsByWarehouseAndDay : ErplyItem
{
/// <summary>
/// Total sales. In US, this is net sales total. In other countries, this is the sales total with VAT.  
/// </summary>
public string Total { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date { get; set; }
public int? WarehouseID { get; set; }
}

#endregion

#region SalesTotalsByWarehouseAndMonth

public class SalesTotalsByWarehouseAndMonth : ErplyItem
{
/// <summary>
/// Total sales. In US, this is net sales total. In other countries, this is the sales total with VAT.  
/// </summary>
public string Total { get; set; }
public int? Year { get; set; }
public int? Month { get; set; }
public int? WarehouseID { get; set; }
}

#endregion

#region Schedule

public class Schedule : ErplyItem
{
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? StartTime { get; set; }
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? EndTime { get; set; }
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
public int? WarehouseID { get; set; }
}

#endregion

#region SessionKeyInfo

public class SessionKeyInfo : ErplyItem
{
/// <summary>
/// Time when the session key was created.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreationUnixTime { get; set; }
/// <summary>
/// Expiration timestamp of this session key. If you subtract the "requestUnixTime" timestamp (in API response header) from this value, you will get the remaining lifetime of your session in seconds. To extend the session, perform a new verifyUser call.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ExpireUnixTime { get; set; }
}

#endregion

#region TimeSlot

public class TimeSlot : ErplyItem
{
/// <summary>
/// Unlike other API requests, getTimeSlots does not return an array of records, but an array of appointment options - each "option" containing one or more appointment times, depending on whether you requested times for a single appointment or a set of appointments.
/// An appointment contains the following parameters:  
/// </summary>
public string - { get; set; }
/// <summary>
/// # you assigned to this customer in your input parameters.  
/// </summary>
public int? CustomerNumber { get; set; }
/// <summary>
/// Stylist assigned to this appointment  
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Service performed  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Appointment start time  
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? StartTime { get; set; }
/// <summary>
/// Appointment end time
/// </summary>
[JsonConverter(typeof(ISODateTimeConverter))]
public DateTime? EndTime { get; set; }
}

#endregion

#region UnfinishedSale

public class UnfinishedSale : ErplyItem
{
/// <summary>
/// An identifier for the cancelled / not completed transaction.  
/// </summary>
public int? TransactionID { get; set; }
/// <summary>
/// Register where the transaction was made.  
/// </summary>
public int? PointOfSaleID { get; set; }
/// <summary>
/// Time of deletion or cancelling. (Note that this makes sense for cancelled transactions only. "Not completed" transactions are all deleted at the end of the shift. The timestamp refers to the time of deletion, and does not indicate when that transaction was started.)  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
/// <summary>
/// Possible values: "CANCELLED", "NOT_COMPLETED".  
/// </summary>
public string Type { get; set; }
/// <summary>
/// Total value of the transaction — in account's default currency, with VAT.  
/// </summary>
public float? TransactionTotal { get; set; }
}

#endregion

#region UsedRewardPointRecord

public class UsedRewardPointRecord : ErplyItem
{
/// <summary>
/// Transaction ID.  
/// </summary>
public int? TransactionID { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Code of customer's loyalty/membership card.  
/// </summary>
public string CustomerCardNumber { get; set; }
/// <summary>
/// Invoice ID.  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Invoice number.  
/// </summary>
public string InvoiceNo { get; set; }
public int? CampaignID { get; set; }
public int? WarehouseID { get; set; }
/// <summary>
/// Register ID.  
/// </summary>
public int? PointOfSaleID { get; set; }
public string PointOfSaleName { get; set; }
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
public int? UsedPoints { get; set; }
/// <summary>
/// Transaction timestamp.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? CreatedUnixTime { get; set; }
/// <summary>
/// Available only if "Reward point extras" module is enabled on your account.  
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// Available only if "Reward point extras" module is enabled on your account.  
/// </summary>
public string Description { get; set; }
}

#endregion

#region SellableProduct

public class SellableProduct : ErplyItem
{
public int? ProductID { get; set; }
}

#endregion

#region ServiceEndpointsForPOS

public class ServiceEndpointsForPOS : ErplyItem
{
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// This field is either null (if support for triPOS Cloud payments has not been configured on this server), or an object with two fields: "url" and "token". These are the endpoint of the triPOS Cloud payments proxy, and an authentication token for it.
/// Example:
/// "triPOSCloudPaymentURL": {
///     "url": "https://tripos-proxy.example.com/TriPos/V1/",
///     "token": "abcdefgh"
/// }
/// </summary>
public string TriPOSCloudPaymentURL { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls (eg. "V1/Customer/create") to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the customer service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the coupon service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Possible values - "Windows", "macOS" and "Linux"
/// </summary>
public string OperatingSystem { get; set; }
/// <summary>
/// Installation link
/// </summary>
public string Url { get; set; }
}

#endregion

#region SubsidyType

public class SubsidyType : ErplyItem
{
public int? SubsidyTypeID { get; set; }
public string Code { get; set; }
public string Name { get; set; }
}

#endregion

#region StoreRegion

public class StoreRegion : ErplyItem
{
/// <summary>
/// ID of the store region.  
/// </summary>
public int? StoreRegionID { get; set; }
/// <summary>
/// Region code.  
/// </summary>
public string Code { get; set; }
/// <summary>
/// Region name.  
/// </summary>
public string Name { get; set; }
/// <summary>
/// Price list ID
/// </summary>
public int? PriceListID { get; set; }
/// <summary>
/// Number of position, related to order how price lists will be applied
/// </summary>
public int? PositionNumber { get; set; }
/// <summary>
/// Price list name
/// </summary>
public string Name { get; set; }
/// <summary>
/// From date
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? StartDate { get; set; }
/// <summary>
/// Until date
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? EndDate { get; set; }
public int? Active { get; set; }
/// <summary>
/// Price list type, possible types are 'BASE_PRICE_LIST', 'STORE_PRICE_LIST'.
/// This field is returned only if the "Price list types" module has been enabled on your account. Contact customer support to enable that feature.
/// </summary>
public string Type { get; set; }
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
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region StoreRegionsAssociatedWithPriceList

public class StoreRegionsAssociatedWithPriceList : ErplyItem
{
/// <summary>
/// ID of the store region.  
/// </summary>
public int? StoreRegionID { get; set; }
}

#endregion

#region SupplierGroup

public class SupplierGroup : ErplyItem
{
public int? SupplierGroupID { get; set; }
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

#region SupplierPriceList

public class SupplierPriceList : ErplyItem
{
/// <summary>
/// Price List ID.  
/// </summary>
public int? SupplierPriceListID { get; set; }
/// <summary>
/// Supplier ID.  
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// Supplier name.  
/// </summary>
public string SupplierName { get; set; }
/// <summary>
/// Price list name  
/// </summary>
public string Name { get; set; }
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
/// 0 or 1  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? Active { get; set; }
/// <summary>
/// Creation time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string AddedByUserName { get; set; }
/// <summary>
/// Last modification time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
public string LastModifiedByUserName { get; set; }
/// <summary>
/// ID of the product.</td
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// List price.</td
/// </summary>
public float? Price { get; set; }
/// <summary>
/// If you have Quantity Discounts module enabled, this is the minimum ordering quantity at which the specified price applies. Therefore, one product may have multiple prices in the price list, for example: one price for quantity 100 and up (amount = 100); another price for quantity 25...99 (amount = 25); and a default price (amount = 0).
/// Contact ERPLY Helpdesk if you need Quantity Discounts module to be enabled on your account.
/// </summary>
public int? Amount { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region Supplier

public class Supplier : ErplyItem
{
/// <summary>
/// Supplier ID  
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// COMPANY or PERSON.
/// For companies, the following attributes are set: fullName, companyName (both have the same value).
/// For persons, the following attributes are set: fullName, firstName, lastName. fullName is a combination of latter two: "lastName, firstName".
/// fullName can be used for displaying supplier's name wherever needed.
/// Guidelines for applications with a supplier edit form:
/// Companies should have one name field and the attribute that is edited should be companyName.
/// Persons should have separate fields for given name and surname (respective attributes: firstName, lastName).
/// Note: API call saveSupplier also has an input parameter "fullName" (when using that, system tries to interpret and split the name as required), but it should be used only when brokering data from some other system where a better data format is not available.  
/// </summary>
public string SupplierType { get; set; }
/// <summary>
/// Full name of the supplier, use for displaying supplier name.  
/// </summary>
public string FullName { get; set; }
/// <summary>
/// For companies only.  
/// </summary>
public string CompanyName { get; set; }
/// <summary>
/// (Given name.) For persons only.  
/// </summary>
public string FirstName { get; set; }
/// <summary>
/// (Surname.) For persons only.  
/// </summary>
public string LastName { get; set; }
/// <summary>
/// Supplier group ID  
/// </summary>
public int? GroupID { get; set; }
public string GroupName { get; set; }
public string Phone { get; set; }
public string Mobile { get; set; }
public string Email { get; set; }
public string Fax { get; set; }
/// <summary>
/// National ID number (for persons) / Registry code (for companies).  
/// </summary>
public string Code { get; set; }
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
/// Supplier country  
/// </summary>
public string CountryName { get; set; }
/// <summary>
/// Supplier country, as a two-letter country code (ISO 3166-1 alpha-2)  
/// </summary>
public string CountryCode { get; set; }
/// <summary>
/// One of supplier's addresses. Only for concise displaying of supplier information. To manage addresses, use API calls getAddresses and saveAddress.  
/// </summary>
public string Address { get; set; }
public string GLN { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
/// <summary>
/// Supplier VAT number.  
/// </summary>
public string VatNumber { get; set; }
public string Skype { get; set; }
public string Website { get; set; }
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
/// <summary>
/// Person birthday  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Birthday { get; set; }
/// <summary>
/// ID of company (if user is a contact person of a particular company)  
/// </summary>
public int? CompanyID { get; set; }
public string ParentCompanyName { get; set; }
/// <summary>
/// Supplier manager ID  
/// </summary>
public int? SupplierManagerID { get; set; }
public string SupplierManagerName { get; set; }
/// <summary>
/// Default payment period.  
/// </summary>
public int? PaymentDays { get; set; }
public string Notes { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
}

#endregion

#region TaxExemption

public class TaxExemption : ErplyItem
{
/// <summary>
/// Invoice ID.  
/// </summary>
public int? InvoiceID { get; set; }
/// <summary>
/// Invoice number.  
/// </summary>
public string InvoiceNumber { get; set; }
/// <summary>
/// Customer ID.  
/// </summary>
public int? CustomerID { get; set; }
/// <summary>
/// Warehouse ID.  
/// </summary>
public int? WarehouseID { get; set; }
/// <summary>
/// Invoice date.  
/// </summary>
[JsonConverter(typeof(ISODateConverter))]
public DateTime? Date { get; set; }
/// <summary>
/// Tax exemption certificate number.  
/// </summary>
public string TaxExemptCertificateNumber { get; set; }
/// <summary>
/// Amount of tax reduction. (Amount of money the customer saved, compared to if the sale had had default tax rates.)  
/// </summary>
public float? AmountExempted { get; set; }
}

#endregion

#region TaxOffice

public class TaxOffice : ErplyItem
{
public int? TaxOfficeID { get; set; }
public string Code { get; set; }
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

#region UserGroup

public class UserGroup : ErplyItem
{
public int? UserGroupID { get; set; }
public string Name { get; set; }
/// <summary>
/// Creation time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string AddedByUserName { get; set; }
/// <summary>
/// Last modification time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
public string LastModifiedByUserName { get; set; }
/// <summary>
/// Attribute name
/// </summary>
public string AttributeName { get; set; }
/// <summary>
/// Attribute type
/// </summary>
public string AttributeType { get; set; }
/// <summary>
/// Attribute value
/// </summary>
public string AttributeValue { get; set; }
}

#endregion

#region UserOperationsLog

public class UserOperationsLog : ErplyItem
{
public int? LogID { get; set; }
public string UserName { get; set; }
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Timestamp { get; set; }
public string TableName { get; set; }
/// <summary>
/// ID of the deleted item  
/// </summary>
public int? ItemID { get; set; }
}

#endregion

#region UserRight

public class UserRight : ErplyItem
{
public int? UserID { get; set; }
public string UserName { get; set; }
/// <summary>
/// ID of the user group where the user belongs  
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// Max. allowed sales discount  
/// </summary>
public int? MaxDiscount { get; set; }
/// <summary>
/// Deprecated. This field is always empty.  
/// </summary>
public string CardCode { get; set; }
/// <summary>
/// Right to set customers' credit limits and to deny credit.Possible values: 0,1.  
/// </summary>
public int? RightGiveCustomerCredit { get; set; }
/// <summary>
/// Right to create inventory registrations.Possible values: 0,1.  
/// </summary>
public int? RightCreateInventoryRegistrations { get; set; }
/// <summary>
/// Right to create inventory amortizations.Possible values: 0,1.  
/// </summary>
public int? RightCreateInventoryAmortizations { get; set; }
/// <summary>
/// Right to void transactions in POS and accept returns with receipt.Possible values: 0,1.  
/// </summary>
public int? RightMakePOSRefunds { get; set; }
/// <summary>
/// Right to accept returns without receipt.Possible values: 0,1.  
/// </summary>
public int? RightMakePOSReturnsWithoutReceipt { get; set; }
/// <summary>
/// Right to apply promotions manually or by typing in a coupon code.Possible values: 0,1.  
/// </summary>
public int? RightApplyPromotions { get; set; }
/// <summary>
/// Right to edit prices on sales invoices.Possible values: 0,1.  
/// </summary>
public int? RightChangePrices { get; set; }
/// <summary>
/// Right to edit confirmed invoices.Possible values: 0,1.  
/// </summary>
public int? RightEditConfirmedInvoices { get; set; }
/// <summary>
/// Right to edit the date on sales invoices.Possible values: 0,1.  
/// </summary>
public int? RightChangeInvoiceDate { get; set; }
/// <summary>
/// Right to edit stock and product cost directly on product card.Possible values: 0,1.  
/// </summary>
public int? RightEditStockAndProductCost { get; set; }
/// <summary>
/// Right to edit prices on purchase orders.Possible values: 0,1.  
/// </summary>
public int? RightChangePricesOnPurchaseOrders { get; set; }
/// <summary>
/// Right to edit confirmed purchase orders and purchase documents.Possible values: 0,1.  
/// </summary>
public int? RightChangeConfirmedPurchaseInvoices { get; set; }
/// <summary>
/// Right to edit item price on return without receipt (Berlin POS only). Possible values: 0,1.  
/// </summary>
public int? RightEditPriceOnReturnWithoutReceiptInPOS { get; set; }
/// <summary>
/// Right to make discounts in POS (Offline POS only). Possible values: 0,1.
/// NB!! If API does not return this attribute, assume that the default value is 1.  
/// </summary>
public int? RightMakeDiscountInPOS { get; set; }
/// <summary>
/// Right to open / close day (Offline POS only).Possible values: 0,1.
/// NB!! If API does not return this attribute, assume that the default value is 1.  
/// </summary>
public int? RightOpenAndCloseDay { get; set; }
/// <summary>
/// Right to add and edit Actual Reports printout templates. Possible values: 0,1.  
/// </summary>
public int? RightEditActualReports { get; set; }
/// <summary>
/// Right to edit customers' reward point amounts. Possible values: 0,1.  
/// </summary>
public int? RightAddRewardPoints { get; set; }
/// <summary>
/// Indicates that this user is a "store manager"-level employee, and may give manager's approval to POS operations that require it (eg. applying certain promotions or discounts). Possible values: 0,1.  
/// </summary>
public int? RightPOSManagerOverride { get; set; }
/// <summary>
/// Right to create and edit price lists with other types besides "Store Price List". Possible values: 0,1.  
/// </summary>
public int? RightEditRetailChainPriceLists { get; set; }
/// <summary>
/// Creation time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? Added { get; set; }
public string AddedByUserName { get; set; }
/// <summary>
/// Last modification time.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? LastModified { get; set; }
public string LastModifiedByUserName { get; set; }
}

#endregion

#region CompanyType

public class CompanyType : ErplyItem
{
public int? Id { get; set; }
/// <summary>
/// Company type name.  
/// </summary>
public string Name { get; set; }
public int? Order { get; set; }
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

#region PersonTitle

public class PersonTitle : ErplyItem
{
public int? Id { get; set; }
/// <summary>
/// person title name.  
/// </summary>
public string Name { get; set; }
public int? Order { get; set; }
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

#region JobTitle

public class JobTitle : ErplyItem
{
public int? Id { get; set; }
/// <summary>
/// job title name.  
/// </summary>
public string Name { get; set; }
public int? Order { get; set; }
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

#region incrementStocktakingReading

public class incrementStocktakingReading : ErplyItem
{
public int? RecordID { get; set; }
public int? StocktakingID { get; set; }
}

#endregion

#region recordGDPRConfirmation

public class recordGDPRConfirmation : ErplyItem
{
/// <summary>
/// ID of the curent user's employee account.  
/// </summary>
public int? EmployeeID { get; set; }
/// <summary>
/// Time of consent.  
/// </summary>
[JsonConverter(typeof(UnixTimestampConverter))]
public DateTime? ConsentTime { get; set; }
}

#endregion

#region redeemIssuedCoupon

public class redeemIssuedCoupon : ErplyItem
{
/// <summary>
/// ID of the redeemed coupon (however, this ID does not serve any purpose, so it does not need to be recorded)  
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// ID of coupon code  
/// </summary>
public int? CouponID { get; set; }
/// <summary>
/// Unique identifier of the coupon  
/// </summary>
public int? UniqueIdentifier { get; set; }
}

#endregion

#region registerReceiptPrint

public class registerReceiptPrint : ErplyItem
{
/// <summary>
/// The same ID that was supplied as input.  
/// </summary>
public int? InvoiceID { get; set; }
}

#endregion

#region removeAssortmentProduct

public class removeAssortmentProduct : ErplyItem
{
/// <summary>
/// Comma-separated list of removed products.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> DeletedIDs { get; set; }
/// <summary>
/// Comma-separated list of products that were not found in this assortment.  
/// </summary>
public string ProductsNotInAssortment { get; set; }
}

#endregion

#region removeStoreRegionPriceList

public class removeStoreRegionPriceList : ErplyItem
{
/// <summary>
/// Comma-separated IDs of price lists that were removed from this region.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> RemovedPriceListIDs { get; set; }
/// <summary>
/// Comma-separated list of values that were not numeric, or IDs which did not refer to existing price lists, associated with the specified region.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
}

#endregion

#region removeStoreRegionCustomerGroupPriceList

public class removeStoreRegionCustomerGroupPriceList : ErplyItem
{
/// <summary>
/// Comma-separated IDs of price lists that were removed from this region.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> RemovedPriceListIDs { get; set; }
/// <summary>
/// Comma-separated list of values that were not numeric, or IDs which did not refer to existing price lists, associated with the specified region.  
/// </summary>
[JsonConverter(typeof(CommaSeparatedStringConverter))]
public List<int> NonExistingIDs { get; set; }
}

#endregion

#region AddressType

public class AddressType : ErplyItem
{
/// <summary>
/// ID of the created/updated type item.  
/// </summary>
public int? AddressTypeID { get; set; }
}

#endregion

#region Appliance

public class Appliance : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? ApplianceID { get; set; }
}

#endregion

#region Assignment

public class Assignment : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? AssignmentID { get; set; }
}

#endregion

#region AssignmentGroup

public class AssignmentGroup : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? GroupID { get; set; }
}

#endregion

#region Assortment

public class Assortment : ErplyItem
{
/// <summary>
/// Assortment ID.  
/// </summary>
public int? AssortmentID { get; set; }
}

#endregion

#region BillingStatement

public class BillingStatement : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? BillingStatementID { get; set; }
}

#endregion

#region BillingStatementReading

public class BillingStatementReading : ErplyItem
{
/// <summary>
/// ID of billing statement.  
/// </summary>
public int? BillingStatementID { get; set; }
/// <summary>
/// ID of the newly-created item.  
/// </summary>
public int? ReadingID { get; set; }
}

#endregion

#region Bin

public class Bin : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? BinID { get; set; }
}

#endregion

#region Brand

public class Brand : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? BrandID { get; set; }
}

#endregion

#region Campaign

public class Campaign : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? CampaignID { get; set; }
}

#endregion

#region CompanyLogo

public class CompanyLogo : ErplyItem
{
/// <summary>
/// Name of the added item.  
/// </summary>
public string ImageName { get; set; }
/// <summary>
/// Name of the added item. If image type is "INVOICE_AND_RECEIPT_IMAGE", returns also this parameter.  
/// </summary>
public string ImageName2 { get; set; }
}

#endregion

#region Country

public class Country : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? CountryID { get; set; }
}

#endregion

#region Coupon

public class Coupon : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? CouponID { get; set; }
}

#endregion

#region Currency

public class Currency : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? CurrencyID { get; set; }
}

#endregion

#region CustomerAssociation

public class CustomerAssociation : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? RelationshipID { get; set; }
}

#endregion

#region CustomerProfessional

public class CustomerProfessional : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? RelationshipID { get; set; }
}

#endregion

#region DeliveryType

public class DeliveryType : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? DeliveryTypeID { get; set; }
}

#endregion

#region Document

public class Document : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? DocumentID { get; set; }
public int? DocumentNo { get; set; }
}

#endregion

#region EDocument

public class EDocument : ErplyItem
{
/// <summary>
/// Number of documents inserted  
/// </summary>
public int? InvoiceCount { get; set; }
}

#endregion

#region Employee

public class Employee : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? EmployeeID { get; set; }
}

#endregion

#region Event

public class Event : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? EventID { get; set; }
}

#endregion

#region EventType

public class EventType : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? EventTypeID { get; set; }
}

#endregion

#region EventStatu

public class EventStatu : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? EventStatusID { get; set; }
}

#endregion

#region GiftCard

public class GiftCard : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? GiftCardID { get; set; }
}

#endregion

#region InvoicePaymentType

public class InvoicePaymentType : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? InvoicePaymentTypeID { get; set; }
}

#endregion

#region IssuedCoupon

public class IssuedCoupon : ErplyItem
{
/// <summary>
/// Returns ID of the created or updated item.  
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// ID of the coupon code.  
/// </summary>
public int? CouponID { get; set; }
public string CouponCode { get; set; }
public string CouponName { get; set; }
public string CouponDescription { get; set; }
/// <summary>
/// Returns unique identifier of the coupon.  
/// </summary>
public int? UniqueIdentifier { get; set; }
/// <summary>
/// Printing cost in reward points. This is an informative field; you do not need to do anything with that value. These points are automatically subtracted from customer's point balance by the API. If the customer does not have enough points, error 1042 is returned.  
/// </summary>
public int? PrintingCostInRewardPoints { get; set; }
}

#endregion

#region LocationInWarehouse

public class LocationInWarehouse : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item.  
/// </summary>
public int? LocationInWarehouseID { get; set; }
}

#endregion

#region PaymentType

public class PaymentType : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? PaymentTypeID { get; set; }
}

#endregion

#region PriceList

public class PriceList : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? PricelistID { get; set; }
}

#endregion

#region ProductFile

public class ProductFile : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? ProductFileID { get; set; }
}

#endregion

#region ProductPackage

public class ProductPackage : ErplyItem
{
/// <summary>
/// ID of the added or modified record.  
/// </summary>
public int? PackageID { get; set; }
}

#endregion

#region ProductPriorityGroup

public class ProductPriorityGroup : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? PriorityGroupID { get; set; }
}

#endregion

#region ProductUnit

public class ProductUnit : ErplyItem
{
/// <summary>
/// ID of the created/updated item.  
/// </summary>
public int? ProductUnitID { get; set; }
}

#endregion

#region Project

public class Project : ErplyItem
{
/// <summary>
/// ID of the created (or updated) project.  
/// </summary>
public int? ProjectID { get; set; }
}

#endregion

#region Service

public class Service : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? ServiceID { get; set; }
}

#endregion

#region StoreRegion

public class StoreRegion : ErplyItem
{
/// <summary>
/// Store region ID.  
/// </summary>
public int? StoreRegionID { get; set; }
}

#endregion

#region SubsidyType

public class SubsidyType : ErplyItem
{
/// <summary>
/// ID of the newly-created item.  
/// </summary>
public int? SubsidyTypeID { get; set; }
}

#endregion

#region Supplier

public class Supplier : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? SupplierID { get; set; }
/// <summary>
/// (0 or 1)  
/// </summary>
[JsonConverter(typeof(BoolConverter))]
public bool? AlreadyExists { get; set; }
}

#endregion

#region SupplierGroup

public class SupplierGroup : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? SupplierGroupID { get; set; }
}

#endregion

#region SupplierPriceList

public class SupplierPriceList : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? SupplierPriceListID { get; set; }
}

#endregion

#region User

public class User : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? UserID { get; set; }
}

#endregion

#region UserOperationsLog

public class UserOperationsLog : ErplyItem
{
/// <summary>
/// ID of the newly-created item  
/// </summary>
public int? LogID { get; set; }
}

#endregion

#region VatRate

public class VatRate : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? VatRateID { get; set; }
}

#endregion

#region VatRateComponent

public class VatRateComponent : ErplyItem
{
/// <summary>
/// ID of the newly-created or updated item  
/// </summary>
public int? VatRateComponentID { get; set; }
}

#endregion

#region CompanyType

public class CompanyType : ErplyItem
{
/// <summary>
/// Company type ID.  
/// </summary>
public int? CompanyTypeID { get; set; }
}

#endregion

#region PersonTitle

public class PersonTitle : ErplyItem
{
/// <summary>
/// person title ID.  
/// </summary>
public int? PersonTitleID { get; set; }
}

#endregion

#region JobTitle

public class JobTitle : ErplyItem
{
/// <summary>
/// job title ID.  
/// </summary>
public int? JobTitleID { get; set; }
}

#endregion

#region BusinessArea

public class BusinessArea : ErplyItem
{
/// <summary>
/// business area ID.  
/// </summary>
public int? BusinessAreaID { get; set; }
}

#endregion

#region subtractCustomerRewardPoint

public class subtractCustomerRewardPoint : ErplyItem
{
public int? CustomerID { get; set; }
/// <summary>
/// Customer's balance  
/// </summary>
public int? RemainingPoints { get; set; }
public int? SubtractedPoints { get; set; }
}

#endregion

#region switchUser

public class switchUser : ErplyItem
{
/// <summary>
/// ID of the user account (who was just authenticated with PIN)  
/// </summary>
public int? UserID { get; set; }
/// <summary>
/// User name  
/// </summary>
public string UserName { get; set; }
/// <summary>
/// ID of the company employee that has the abovementioned user account  
/// </summary>
public int? EmployeeID { get; set; }
public string EmployeeName { get; set; }
/// <summary>
/// ID of the user group where the user belongs  
/// </summary>
public int? GroupID { get; set; }
/// <summary>
/// name of the user group  
/// </summary>
public string GroupName { get; set; }
/// <summary>
/// IP address of the API client.  
/// </summary>
public string IpAddress { get; set; }
/// <summary>
/// A new session identifier, to be used for subsequent API calls.  
/// </summary>
public string SessionKey { get; set; }
/// <summary>
/// time after which the session key expires (in seconds).  
/// </summary>
public int? SessionLength { get; set; }
public string LoginUrl { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the version number (typically an integer) of the live / production POS version that is appropriate for this customer — or the version that has specifically been configured for this customer.
/// This field does not mean that the customer is definitely using Berlin POS. The customer may be using other POS products or not using a POS at all.
/// Also, API does not currently provide a POS version number for preproduction / staging / testing.  
/// </summary>
public string BerlinPOSVersion { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the URL from where POS can load its static assets.
/// The URL does not include and does not depend on POS version number. POS should append version number to the URL, or perform some other transformation if needed.  
/// </summary>
public string BerlinPOSAssetsURL { get; set; }
/// <summary>
/// Application-specific field for ERPLY's Berlin POS. Indicates the location of the JNLP file for Erply Point Of Sale Integrator (EPSI), which provides support for various POS hardware.  
/// </summary>
public string EpsiURL { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// Service hostname
/// </summary>
public string Target { get; set; }
/// <summary>
/// Service port
/// </summary>
public int? Port { get; set; }
/// <summary>
/// For load balancing. See internal documentation.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Priority of this host. See internal documentation.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls (eg. "V1/Customer/create") to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the customer service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the coupon service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service. When the transaction service reports the token has expired, call verifyUser again to get a new one.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// URL of the service endpoint (with "https://" protocol in the beginning and "/" in the end). Append the names of API calls to this URL.
/// </summary>
public string Url { get; set; }
/// <summary>
/// Authentication token for the service.
/// </summary>
public int? Token { get; set; }
/// <summary>
/// Priority of this host. A client must attempt to contact the target host with the lowest-numbered priority it can reach. Target hosts with the same priority should be tried in pseudorandom order.
/// </summary>
public int? Priority { get; set; }
/// <summary>
/// For load balancing. When selecting a target host among those that have the same priority, the chance of trying this one first should be proportional to its weight. Larger weights SHOULD be given a proportionately higher probability of being selected.
/// </summary>
public int? Weight { get; set; }
/// <summary>
/// Possible values - "Windows", "macOS" and "Linux"
/// </summary>
public string OperatingSystem { get; set; }
/// <summary>
/// Installation link
/// </summary>
public string Url { get; set; }
}

#endregion

#region syncTotalProductStock

public class syncTotalProductStock : ErplyItem
{
/// <summary>
/// ID of a product  
/// </summary>
public int? ProductID { get; set; }
/// <summary>
/// Total amount in stock  
/// </summary>
public string AmountInStock { get; set; }
/// <summary>
/// Total amount reserved. To retrieve this field, set input parameter "getAmountReserved" = 1.
/// Important: even though Inventory Transfer Orders can also reserve inventory, this API call ignores Inventory Transfer Orders. An item reserved with a Sales Order has effectively been set aside for a specific customer, and will be sold soon. In contrast, an item reserved with an Inventory Transfer Order is not going away; it will soon be available again in another store. (And since you are using this API call, the actual location of an item is probably not important for you.)
/// Thus, the "amount reserved" returned by "syncTotalProductStock" may be different from what API getProductStock returns, or what the back office reports show.  
/// </summary>
public string AmountReserved { get; set; }
}

#endregion

#region updatePrice

public class updatePrice : ErplyItem
{
}

#endregion

#region verifyIdentityToken

public class verifyIdentityToken : ErplyItem
{
/// <summary>
/// A created session key.  
/// </summary>
public string SessionKey { get; set; }
/// <summary>
/// Back office URL.  
/// </summary>
public string BackofficeURL { get; set; }
}

#endregion

#region verifyIssuedCoupon

public class verifyIssuedCoupon : ErplyItem
{
/// <summary>
/// Internal ID of the validated coupon. This does not need to be checked however - it suffices to make sure that verifyIssuedCoupon() returns error code 0.  
/// </summary>
public int? IssuedCouponID { get; set; }
/// <summary>
/// ID if the coupon code.  
/// </summary>
public int? CouponID { get; set; }
/// <summary>
/// Identifier of the coupon, same that was passed as input parameter.  
/// </summary>
public int? UniqueIdentifier { get; set; }
public string CampaignName { get; set; }
[JsonConverter(typeof(ISODateConverter))]
public DateTime? ExpiryDate { get; set; }
}

#endregion

#region Installation

public class Installation : ErplyItem
{
/// <summary>
/// Account number (customer code) of the new account.  
/// </summary>
public string ClientCode { get; set; }
/// <summary>
/// URL where the end user can log into ERPLY back office. This is not the API endpoint URL! To connect to the account via API, use https://&lt 
/// </summary>
public string ClientUrl { get; set; }
public string Username { get; set; }
public string Password { get; set; }
}

#endregion

#region UserFromIdentityToken

public class UserFromIdentityToken : ErplyItem
{
/// <summary>
/// ID of the created user.  
/// </summary>
public int? UserID { get; set; }
}

#endregion

#endregion
