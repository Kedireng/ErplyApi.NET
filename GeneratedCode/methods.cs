#region Products

/// <summary>
/// Retrieve your product database.
/// In addition to product card fields, you can have API to return:
/// </summary>
public static List<Product> GetProducts(this Erply erply, GetProductsSettings settings) => erply.MakeRequest<List<Product>>(settings);
/// <summary>
/// Returns a HIERARCHICAL array of product groups.
/// Groups are a way of categorizing your product database, and several API calls support filtering by group.
/// Products can additionally be organized into categories (getProductCategories, hierarchical), brands (getBrands, a flat list), and priority groups (getProductPriorityGroups, a flat list)
/// </summary>
public static List<ProductGroup> GetProductGroups(this Erply erply, GetProductGroupsSettings settings) => erply.MakeRequest<List<ProductGroup>>(settings);
/// <summary>
/// Retrieve the list of product categories.
/// Categories are a way of categorizing your product database, and several API calls support filtering by category.
/// Products can additionally be organized into groups (getProductGroups, hierarchical), brands (getBrands, a flat list) and priority groups (getProductPriorityGroups, a flat list).
/// </summary>
public static List<ProductCategory> GetProductCategories(this Erply erply, GetProductCategoriesSettings settings) => erply.MakeRequest<List<ProductCategory>>(settings);
/// <summary>
/// Returns an array of product priority groups.
/// Priority groups are a way of categorizing your product database, and several API calls support filtering by priority group.
/// Products can additionally be organized into groups (getProductGroups, hierarchical), categories (getProductCategories, hierarchical), and brands (getBrands, a flat list).
/// </summary>
public static List<ProductPriorityGroup> GetProductPriorityGroups(this Erply erply, GetProductPriorityGroupsSettings settings) => erply.MakeRequest<List<ProductPriorityGroup>>(settings);
/// <summary>
/// Returns an array of product possible units.
/// </summary>
public static List<ProductUnit> GetProductUnits(this Erply erply) => erply.MakeRequest<List<ProductUnit>>(new ErplyCall() { CallName = "getProductUnits" });
/// <summary>
/// Retrieve a product's net sales price in a certain location, or net sales price for a specific customer — according to any price lists that apply.
/// You can query prices for a single product (by supplying parameter productID) or multiple products at a time (by supplying parameter productIDs).
/// If you do not want a price for a specific customer or location, but just need to know which price lists contain a specific item, see getProductPricesInPriceLists.
/// </summary>
public static List<ProductPrice> GetProductPrices(this Erply erply, GetProductPricesSettings settings) => erply.MakeRequest<List<ProductPrice>>(settings);
/// <summary>
/// Get FIFO unit cost for a specific amount of specific items you are planning to subtract from inventory.
/// API inspects all the batches that are currently in stock, calculates (according to FIFO rules) how many items should be discounted from which batch (starting with the oldest ones), and returns the weighted average cost of the resulting lot.
/// This API call is useful when you plan to make an inventory transaction (eg. a sale, transfer or inventory writeoff), but want to know the exact total cost of the items before actually making the transaction.
/// You need to specify amount, because each batch may have a different cost. The amount that you require may have to be pulled from one or multiple batches, depending on how many items are left in each batch.
/// Please contact Erply support if you plan to use this API call. Your account may need updates or customizations to be applied.
/// </summary>
public static ProductCostForSpecificAmount GetProductCostForSpecificAmount(this Erply erply, GetProductCostForSpecificAmountSettings settings) => erply.MakeRequest<ProductCostForSpecificAmount>(settings);
/// <summary>
/// Retrieve your ERPLY inventory — quantities on hand, reserved amounts, Reorder Points and Restock Levels, FIFO costs, and most recent purchase prices.
/// By default, API returns all products that have a non-zero inventory quantity in the warehouse you specified. In other words, items with a zero inventory quantity are skipped.
/// However, if you use input parameters "changedSince" (all quantities that have changed since last synchronization), or "getProductsWithReorderPointDefined" / "getProductsWithRestockLevelDefined", API will also return items with zero inventory quantity.
/// To retrieve only a list of reserved inventory quantities, see getReservedStock.
/// If you need to get total stock across all warehouses, then use API call syncTotalProductStock.
/// </summary>
public static ProductStock GetProductStock(this Erply erply, GetProductStockSettings settings) => erply.MakeRequest<ProductStock>(settings);
/// <summary>
/// Create or update a product.
/// </summary>
public static int SaveProduct(this Erply erply, SaveProductSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a product group.
/// </summary>
public static int SaveProductGroup(this Erply erply, SaveProductGroupSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a product category.
/// </summary>
public static int SaveProductCategory(this Erply erply, SaveProductCategorySettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Attach a new picture to a product, or replace an existing picture.
/// To retrieve a list of images attached to a product, call getProducts and see the element "images". To remove a picture, use deleteProductPicture.
/// </summary>
public static int SaveProductPicture(this Erply erply, SaveProductPictureSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create a matrix dimension, or add values to an existing dimension.
/// A matrix dimension is necessary for setting up matrix products. Typical matrix dimensions are, for example, "Size" (in which the values might be 2, 4, 6, 8 — or S, M, L, XL) and "Color" (which may contain Blue, Red, Black, Green etc).
/// Different matrix products can share the same dimensions, and a matrix product does not need to have variations corresponding to each value in the dimension. For example, it is sufficient to have just one dimension for all letter sizes, one for all numeric sizes and one for all kinds of colors.
/// Matrix products and their variations can be created with API call getProducts.
/// This API call is the best choice if you want to create a brand new dimension with a specific set of values. However, if a dimension already exists and you want to modify its list of values, see the following API calls instead:
/// </summary>
public static int SaveMatrixDimension(this Erply erply, SaveMatrixDimensionSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Delete a product. Products that have any number of transactions associated with them (sales, purchases or inventory) cannot be deleted; API returns error 1063. Instead, we always recommend to archive the product — setting its status to "ARCHIVED".
/// In ERPLY backend, deleting products is no longer possible; clicking the "X" button always archives a product.
/// </summary>
public static void DeleteProduct(this Erply erply, DeleteProductSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a product group. Note that products belonging to this group, as well as subgroups, will NOT be deleted or recategorized.
/// </summary>
public static void DeleteProductGroup(this Erply erply, DeleteProductGroupSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a product picture.
/// </summary>
public static void DeleteProductPicture(this Erply erply, DeleteProductPictureSettings settings) => erply.MakeRequest(settings);
#endregion
#region Customers

/// <summary>
/// Retrieve your customer database.
/// In addition to customer card fields, you can have API to return:
/// </summary>
public static List<Customer> GetCustomers(this Erply erply, GetCustomersSettings settings) => erply.MakeRequest<List<Customer>>(settings);
/// <summary>
/// Retrieve customer, supplier, or company addresses.
/// Important: if you operate in the European Union, the General Data Protection Regulation (GDPR) requires all processing done with customers' personal information to be logged. If you retrieve customer addresses, you are responsible for logging everything you do with the data. If it is not possible to keep the logs in the system that processes the data, you may consider writing the log entries into Erply, with the logProcessingOfCustomerData call.
/// </summary>
public static List<Address> GetAddresses(this Erply erply, GetAddressesSettings settings) => erply.MakeRequest<List<Address>>(settings);
/// <summary>
/// Get customer groups. In ERPLY, customer groups are hierarchical; a group can contain sub-groups.
/// </summary>
public static List<CustomerGroup> GetCustomerGroups(this Erply erply, GetCustomerGroupsSettings settings) => erply.MakeRequest<List<CustomerGroup>>(settings);
/// <summary>
/// Retrieve address types.
/// </summary>
public static List<AddressType> GetAddressTypes(this Erply erply, GetAddressTypesSettings settings) => erply.MakeRequest<List<AddressType>>(settings);
/// <summary>
/// Get the ID of default customer used for POS transactions (typically, "POS Customer", "Walk-in" or similar).
/// If such a customer is not defined, API returns no records.
/// </summary>
public static DefaultCustomer GetDefaultCustomer(this Erply erply, GetDefaultCustomerSettings settings) => erply.MakeRequest<DefaultCustomer>(settings);
/// <summary>
/// Create a new customer or update customer information. Function can be used for manipulating both companies and persons. Some parameters only apply to one or another.
/// If the created or updated customer is a natural person and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the change in the customer information processing log.
/// </summary>
public static Customer SaveCustomer(this Erply erply, SaveCustomerSettings settings) => erply.MakeRequest<Customer>(settings);
/// <summary>
/// Create or update customer's or supplier's address.
/// If the created or updated address belongs to a customer (to a natural person), and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the change in the customer information processing log.
/// </summary>
public static int SaveAddress(this Erply erply, SaveAddressSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a customer group.
/// </summary>
public static int SaveCustomerGroup(this Erply erply, SaveCustomerGroupSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Validate customer's web shop user name and password.
/// This API call is for building a web shop that has a log-in (members-only) area. In Erply Customer module, you can assign a user name and password for each of your customers. (These user names / passwords DO NOT grant the customer any access into your ERPLY account, and cannot be used for that purpose. They can only be used in your web shop.)
/// Use API verifyCustomerUser to validate the user name and password and retrieve the customer record that these credentials belong to. Calling This API call will not create any "session" or make the customer somehow logged into API; it just serves a verification purpose.
/// Instead, if you want to learn how to generally authenticate yourself when connecting to Erply API — to be able to issue any API calls at all — see verifyUser.
/// </summary>
public static verifyCustomerUser VerifyCustomerUser(this Erply erply, VerifyCustomerUserSettings settings) => erply.MakeRequest<verifyCustomerUser>(settings);
/// <summary>
/// Delete a customer.
/// If the deleted customer is a natural person and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the deletion in the customer information processing log.
/// </summary>
public static void DeleteCustomer(this Erply erply, DeleteCustomerSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a supplier / customer / company address.
/// If the deleted address belongs to a customer (to a natural person) and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the deletion in the customer information processing log.
/// </summary>
public static void DeleteAddress(this Erply erply, DeleteAddressSettings settings) => erply.MakeRequest(settings);
#endregion
#region Sales

/// <summary>
/// Retrieve sales documents (invoices, waybills, credit invoices, quotes or orders), according to the supplied filtering parameters.
/// If you have specified document ID or invoice number, or if the search criteria match a single sales document, or if you have set getRowsForAllInvoices = 1, API returns all documents together with their rows. Otherwise only document headers will be returned.
/// To create a new sales document (invoice, order or quote), see saveSalesDocument.
/// If you are looking for a way to pull all sales data for external processing, see getSalesReport. getSalesReport can output either detailed data or aggregate it as needed: it can provide totals by products, by product groups, by dates, by locations, etc.
/// </summary>
public static List<SalesDocument> GetSalesDocuments(this Erply erply, GetSalesDocumentsSettings settings) => erply.MakeRequest<List<SalesDocument>>(settings);
/// <summary>
/// Returns an array of services.
/// </summary>
public static List<Service> GetServices(this Erply erply, GetServicesSettings settings) => erply.MakeRequest<List<Service>>(settings);
/// <summary>
/// Returns a list of warehouses, or locations, or stores.
/// API call getAllowedWarehouses returns the list of those warehouses that your user has access to.
/// To populate the drop-down list of "home stores" or "sign-up stores" on customer form, see the API call getHomeStores instead.
/// </summary>
public static List<Warehouse> GetWarehouses(this Erply erply, GetWarehousesSettings settings) => erply.MakeRequest<List<Warehouse>>(settings);
/// <summary>
/// Retrieve warehouses that this particular authenticated user has access to. API call getWarehouses, on the other hand, returns all warehouses.
/// </summary>
public static List<AllowedWarehous> GetAllowedWarehouses(this Erply erply, GetAllowedWarehousesSettings settings) => erply.MakeRequest<List<AllowedWarehous>>(settings);
/// <summary>
/// Retrieve list of employees.
/// To create an employee, or update employee information, see API call saveEmployee.
/// For other employee-related API calls, see:
/// </summary>
public static List<Employee> GetEmployees(this Erply erply, GetEmployeesSettings settings) => erply.MakeRequest<List<Employee>>(settings);
/// <summary>
/// Returns an array of projects.
/// </summary>
public static List<Project> GetProjects(this Erply erply, GetProjectsSettings settings) => erply.MakeRequest<List<Project>>(settings);
/// <summary>
/// Retrieve all registers (points of sale), in all shops and locations. One shop can have many registers. A register has field "warehouseID" to indicate which store or warehouse it is located in.
/// </summary>
public static PointsOfSale GetPointsOfSale(this Erply erply, GetPointsOfSaleSettings settings) => erply.MakeRequest<PointsOfSale>(settings);
/// <summary>
/// Returns price lists and the contents of each price list.
/// Price lists may contain three types of "rules": 1) fixed prices for specified products; 2) fixed prices for specified services; 3) percentage discounts for specified product groups. (A discount applies to all products in this group and its subgroups.)
/// There can be multiple price lists associated with location, customer, or customer group and the price lists interact with each other and override each other in various ways. To apply all applicable price lists and promotions to a sale, we recommend to use API call calculateShoppingCart. (As input, you need to send all the items on your receipt. API will return the same list, with final prices for each item added.)
/// Re–implementing all price list rules in your application would be a major undertaking, and we plan to constantly add new promotion features to ERPLY.
/// If you need to add products to a price list, then use the addProductToPriceList API call.
/// To edit products on the price list use the editProductInPriceList API call.
/// To delete a product from a price list, use the deleteProductInPriceList API call.
/// To get only the products on the price list, use the getProductsInPriceList API call.
/// </summary>
public static List<PriceList> GetPriceLists(this Erply erply, GetPriceListsSettings settings) => erply.MakeRequest<List<PriceList>>(settings);
/// <summary>
/// Retrieve the list of VAT rates (or sales tax / GST / etc. rates, depending on what taxation is used in the particular country).
/// To create a new tax rate, see saveVatRate.
/// </summary>
public static List<VatRate> GetVatRates(this Erply erply, GetVatRatesSettings settings) => erply.MakeRequest<List<VatRate>>(settings);
/// <summary>
/// Get currencies (that have been defined on your ERPLY account).
/// </summary>
public static List<Currency> GetCurrencies(this Erply erply, GetCurrenciesSettings settings) => erply.MakeRequest<List<Currency>>(settings);
/// <summary>
/// Retrieve sales promotions.
/// This API call will return descriptions of promotion rules, which are generally structured as follows: "Customer must do/buy X and will get Y" (a discount, special price etc.)
/// For an API call that automatically implements all promotion rules and price lists automatically for you, see calculateShoppingCart.
/// To create a promotion rule, see saveCampaign.
/// </summary>
public static List<Campaign> GetCampaigns(this Erply erply, GetCampaignsSettings settings) => erply.MakeRequest<List<Campaign>>(settings);
/// <summary>
/// Retrieve payments.
/// In ERPLY, a payment is associated with a customer (customerID), and optionally an invoice (documentID; or some other sales document, eg. a sales order). One invoice can have many payments. Payment, on the other hand, can only be associated with one invoice at a time. If customer makes an aggregate payment towards several invoices, it needs to be split up into parts.
/// A payment may not always be associated with a specific invoice (eg. deposits, store credit).
/// To register a new payment or update an existing one, see savePayment.
/// </summary>
public static List<Payment> GetPayments(this Erply erply, GetPaymentsSettings settings) => erply.MakeRequest<List<Payment>>(settings);
/// <summary>
/// Retrieve payment types.
/// To create a new payment type, see savePaymentType.
/// </summary>
public static List<PaymentType> GetPaymentTypes(this Erply erply) => erply.MakeRequest<List<PaymentType>>(new ErplyCall() { CallName = "getPaymentTypes" });
/// <summary>
/// Create a new sales document (invoice, sales order, etc.) or update an existing one.
/// Sales documents in Erply have a header with general information (customer, date etc.) and one or more lines that list the items, quantities and prices.
/// Every sales document in Erply needs to be confirmed. When confirmed, a sales invoice, for example, 1) receives a number, 2) generates sales revenue and VAT / tax obligation and 3) removes sold items from inventory. A confirmed sales order places a reservation on ordered items. A confirmed document may not be fully editable any more, or you might need special user rights for some kinds of changes.
/// Possible sales document types are listed below. Most common ones that you'll probably need, are:
/// </summary>
public static SalesDocument SaveSalesDocument(this Erply erply, SaveSalesDocumentSettings settings) => erply.MakeRequest<SalesDocument>(settings);
/// <summary>
/// Calculate the value of a shopping cart, and have discounts, promotions and taxes automatically calculated by API. You only need to input item IDs and quantities.
/// calculateShoppingCart is a very versatile function that:
/// </summary>
public static ShoppingCart CalculateShoppingCart(this Erply erply, CalculateShoppingCartSettings settings) => erply.MakeRequest<ShoppingCart>(settings);
/// <summary>
/// Create or update a payment.
/// In ERPLY, a payment is associated with a customer, and optionally an invoice (or some other sales document, eg. a sales order). One invoice can have many payments. Payment, on the other hand, can only be associated with one invoice at a time. If customer makes an aggregate payment towards several invoices, it needs to be split up into parts.
/// If a payment is not associated with any sales document, it represents a deposit (a prepayment, customer's store credit) and can be used to pay off unpaid invoices.
/// To list payments, see getPayments.
/// A typical use case for the savePayment API call is recording a sale (that has been made in POS or in a web shop). In that case, send a saveSalesDocument API call, followed by savePayment.
/// See also calculateShoppingCart. That API call helps you calculate cart total, and also gives instructions regarding other retail features (issuing and redeeming coupons etc.)
/// </summary>
public static int SavePayment(this Erply erply, SavePaymentSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Delete a sales document (Invoice, Quote, Sales Order, etc).
/// </summary>
public static void DeleteSalesDocument(this Erply erply, DeleteSalesDocumentSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a payment.
/// </summary>
public static void DeletePayment(this Erply erply, DeletePaymentSettings settings) => erply.MakeRequest(settings);
#endregion
#region Webstore

/// <summary>
/// Returns an array of possible matrix dimensions.
/// </summary>
public static List<MatrixDimension> GetMatrixDimensions(this Erply erply, GetMatrixDimensionsSettings settings) => erply.MakeRequest<List<MatrixDimension>>(settings);
/// <summary>
/// Retrieve product brands.
/// Brands are a way of categorizing your product database, and several API calls support filtering by brand.
/// Products can additionally be organized into groups (getProductGroups, hierarchical), categories (getProductCategories, hierarchical), and priority groups (getProductPriorityGroups, a flat list).
/// </summary>
public static List<Brand> GetBrands(this Erply erply) => erply.MakeRequest<List<Brand>>(new ErplyCall() { CallName = "getBrands" });
#endregion
#region Pos

/// <summary>
/// A request for sending a document or report by email. This API call is synchronous (returns when email is sent) and can take a few seconds to complete. Sending will be handled by the server. Email subject, sender's address, message content and attachment format (HTML/PDF) will be decided serverside and are configurable from ERPLY settings.
/// </summary>
public static void SendByEmail(this Erply erply, SendByEmailSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// THIS API CALL IS DEPRECATED.
/// </summary>
public static void SendToPrint(this Erply erply, SendToPrintSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Open the day (or cashier's shift) in POS.
/// To open the day, cashier needs to count the amount of cash at the register.
/// Day must later be closed with POSCloseDay. Both the opening and closing (and the amount of cash counted at opening time and closing time) will be recorded on the Z Report.
/// A log of POS openings and closings can be retrieved with getDayClosings.
/// </summary>
public static pOSOpenDay POSOpenDay(this Erply erply, POSOpenDaySettings settings) => erply.MakeRequest<pOSOpenDay>(settings);
/// <summary>
/// Drop an amount of cash in register.
/// By convention, a cash drop with an amount of 0 is an indicator of "No Sale", ie. just opening the drawer. So if you want to record drawer openings (and have these printed on the Z Report), send a cash drop event with amount 0.
/// For cash payouts, use POSCashOUT. To get a list of all cash drops and cash payouts, use getCashIns.
/// </summary>
public static pOSCashIN POSCashIN(this Erply erply, POSCashINSettings settings) => erply.MakeRequest<pOSCashIN>(settings);
/// <summary>
/// Pay out an amount of cash from register.
/// For cash drops, use POSCashIN. To get a list of all cash drops and cash payouts, use getCashIns.
/// </summary>
public static pOSCashOUT POSCashOUT(this Erply erply, POSCashOUTSettings settings) => erply.MakeRequest<pOSCashOUT>(settings);
/// <summary>
/// Close the day (or cashier's shift) in POS. The day must be previously opened with POSOpenDay.
/// To close the day, cashier needs to count the amount of cash at the register, and indicate how much of it will be stored at the register (closedSum) and how much taken away and deposited (bankedSum).
/// Both the opening and closing (and the amount of cash counted at opening time and closing time) will be recorded on the Z Report.
/// A log of POS openings and closings can be retrieved with getDayClosings.
/// To get a report of total payments by type, before closing the day (for reconciliation), see getPointOfSaleDayTotals.
/// </summary>
public static pOSCloseDay POSCloseDay(this Erply erply, POSCloseDaySettings settings) => erply.MakeRequest<pOSCloseDay>(settings);
#endregion
#region Company

/// <summary>
/// Get information about the company running the account.
/// Note that ERPLY allows to set different contact information for each store (location, warehouse). Each store may have a different phone number, e-mail address, postal address. In ERPLY back office, you can set that on location card.
/// Even company name, registry number and VAT number can be customized per-location — although you will probably need that only if your company is a franchise chain consisting of different corporate entities; and you are using a single ERPLY account, instead of a separate account for each entity.
/// To retrieve per-location information, see API getWarehouses. Only if a location does not have eg. a phone number, you can fall back to the corporate phone number.
/// This data set can be edited with API call editCompanyInfo.
/// </summary>
public static CompanyInfo GetCompanyInfo(this Erply erply) => erply.MakeRequest<CompanyInfo>(new ErplyCall() { CallName = "getCompanyInfo" });
/// <summary>
/// Log into ERPLY API: authenticate yourself with a user name and password.
/// Each communication session with Erply API must begin with a call to verifyUser. Successful log-in will give you a session key; include it with every subsequent API call. (Send it as input parameter "sessionKey").
/// By default, session will last for one hour. When session expires, all API calls will start returning a 1054 or 1055 error; this is an indication that you should call verifyUser again to receive a fresh session key.
/// We recommend that you build authentication and session keep-alive into your API wrapper class — so that it automatically refreshes session key when it is about to expire, and is able to re-authenticate and re-issue an API call if it receives error 1054/1055.
/// If logging in does not succeed, verifyUser returns error 1050, 1051 or 1052.
/// </summary>
public static verifyUser VerifyUser(this Erply erply, VerifyUserSettings settings) => erply.MakeRequest<verifyUser>(settings);
#endregion
#region Inventory

/// <summary>
/// Create or update a store (location, warehouse).
/// To retrieve a list of locations, see getWarehouses.
/// </summary>
public static int SaveWarehouse(this Erply erply, SaveWarehouseSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create an Inventory Registration or update an existing one.
/// Inventory Registration is a document that takes products into inventory; it has a list of items and quantities. It is similar to a Purchase Invoice, but has fewer fields and is best suited for registering your initial stock quantities when you start using ERPLY — or for making inventory quantity adjustments.
/// Non-stock products and bundles cannot be on Inventory Registrations (these items do not have inventory).
/// Products can be removed from stock with Inventory Write-offs (see getInventoryWriteOffs and saveInventoryWriteOff) and moved between locations with Inventory Transfers (see getInventoryTransfers and saveInventoryTransfer).
/// To retrieve a list of Inventory Registrations, see getInventoryRegistrations.
/// </summary>
public static int SaveInventoryRegistration(this Erply erply, SaveInventoryRegistrationSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update an Inventory Transfer.
/// Inventory Transfer is a document that moves inventory between locations (stores); subtracts from one location and adds to the other. Inventory Transfer has a list of items and quantities.
/// Non-stock products and bundles cannot be transfered (these items do not have inventory).
/// For retrieving Inventory Transfers, see getInventoryTransfers.
/// </summary>
public static int SaveInventoryTransfer(this Erply erply, SaveInventoryTransferSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create an Inventory Write-Off or update an existing one.
/// Inventory Write-Off is a document that removes products from inventory; it has a list of items and quantities.
/// Non-stock products and bundles cannot be on Inventory Write-Offs (these items do not have inventory).
/// Products can be added to stock with Inventory Registrations (see getInventoryRegistrations and saveInventoryRegistration) and moved between locations with Inventory Transfers (see getInventoryTransfers and saveInventoryTransfer).
/// To retrieve a list of Inventory Write-Offs, see getInventoryWriteOffs.
/// </summary>
public static int SaveInventoryWriteOff(this Erply erply, SaveInventoryWriteOffSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Retrieve physical stocktakings.
/// A physical stocktaking is an operation where inventory is manually re-counted; if actual count differs from the inventory quantity in ERPLY, the quantity in ERPLY is adjusted.
/// When physical stocktaking is completed, the stocktaking act must be confirmed. Any surplus items can then be taken into inventory with an Inventory Registration, and missing items subtracted with an Inventory Write-Off.
/// To retrieve all item counts in one specific stocktaking, see getStocktakingReadings. To start a new stocktaking (create a new stocktaking act), see saveStocktaking. To update quantities on an act, see saveStocktakingReadings and incrementStocktakingReading.
/// </summary>
public static List<Stocktaking> GetStocktakings(this Erply erply, GetStocktakingsSettings settings) => erply.MakeRequest<List<Stocktaking>>(settings);
/// <summary>
/// Create or update a physical stocktaking act.
/// Creating the act is the first step in physical stocktaking. Next, it must be filled with quantities counted in the warehouse. After all quantities have been recorded and verified, the act must be confirmed. Finally, surplus quantities should be taken into stock with an Inventory Registration and missing quantites written off with an Inventory Write-off. Note that just confirming the act will not update your inventory yet!
/// Inventory Registrations and Write-offs can be created manually in Erply back-end.
/// For related API calls, see getStocktakings, getStocktakingReadings, saveStocktakingReadings and incrementStocktakingReading.
/// </summary>
public static int SaveStocktaking(this Erply erply, SaveStocktakingSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Retrieve item counts on one specific stocktaking act.
/// To retrieve a list of physical stocktakings, see getStocktakings. To start a new stocktaking (create a new stocktaking act), see saveStocktaking. To update quantities on an act, see saveStocktakingReadings (to make bulk updates) or incrementStocktakingReading (to increment quantities atomically).
/// </summary>
public static List<StocktakingReading> GetStocktakingReadings(this Erply erply, GetStocktakingReadingsSettings settings) => erply.MakeRequest<List<StocktakingReading>>(settings);
/// <summary>
/// Update product count on a physical stocktaking sheet.
/// Note! This API call should be used only in single-client mode (if your API script or application is the only one updating the quantities). If you have several applications that need to update quantities simultaneously, use incrementStocktakingReading instead.
/// For related API calls, see getStocktakings, getStocktakingReadings and saveStocktaking.
/// </summary>
public static void SaveStocktakingReadings(this Erply erply, SaveStocktakingReadingsSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Returns a list of purchase documents (purchase invoices or orders), according to the supplied filtering parameters.
/// If you have specified document ID or invoice number, or if the search criteria match a single sales document, or if you have set getRowsForAllInvoices = 1, API returns all documents together with their rows. Otherwise only document headers will be returned.
/// If you are looking for a way to pull all purchase data for external processing, see getPurchaseReport. getPurchaseReport can output either detailed data or aggregate it as needed: it can provide totals by products, by product groups, by dates, by locations, etc.
/// </summary>
public static List<PurchaseDocument> GetPurchaseDocuments(this Erply erply, GetPurchaseDocumentsSettings settings) => erply.MakeRequest<List<PurchaseDocument>>(settings);
/// <summary>
/// Create a new purchase invoice, purchase order or purchase return, or update an existing one.
/// </summary>
public static PurchaseDocument SavePurchaseDocument(this Erply erply, SavePurchaseDocumentSettings settings) => erply.MakeRequest<PurchaseDocument>(settings);
/// <summary>
/// Delete a purchase document (invoice, order, return).
/// </summary>
public static void DeletePurchaseDocument(this Erply erply, DeletePurchaseDocumentSettings settings) => erply.MakeRequest(settings);
#endregion
#region Reports

/// <summary>
/// Retrieve an "X Report" or "Z Report".
/// X / Z Report is a report of POS transactions and payments. The output is identical, but an X report is typically printed during the day, and a Z report at the end of the day, after counting the cash drawer.
/// X / Z Report can be retrieved either as structured data or HTML.
/// For other reports, see the following API calls:
/// </summary>
public static List<string> GetReports(this Erply erply, GetReportsSettings settings) => erply.MakeRequest<List<string>>(settings);
/// <summary>
/// Retrieve all customers who have a non-zero balance (who have unpaid invoices, prepayments, store credit etc.). For each customer, API returns a link to PDF payment reminder document, and also links to all unpaid invoices in PDF format.
/// NB! The links are valid for one-time use ONLY. You should download the PDF's and e-mail or display them as needed, but the link should not be shown or forwarded to customer.
/// </summary>
public static List<AccountStatement> GetAccountStatements(this Erply erply, GetAccountStatementsSettings settings) => erply.MakeRequest<List<AccountStatement>>(settings);
/// <summary>
/// Get the cost of goods sold for a given period. API returns an array of all sales document rows in the selected period, and the cost for each row.
/// Erply calculates cost according to FIFO principle.
/// Usage guidelines: Note that the COGS of any sale may change at any time — Erply does not freeze cost at the moment when sale takes place. Many kinds of operations may adjust it, eg. entering or correcting a purchase invoice at a later date, adding freight costs, deleting other documents etc. Find out what are the accounting principles in your company and pull COGS only when all adjustments for the given period are done — eg. at the end of month.
/// </summary>
public static CostOfGoodsSold GetCostOfGoodsSold(this Erply erply, GetCostOfGoodsSoldSettings settings) => erply.MakeRequest<CostOfGoodsSold>(settings);
/// <summary>
/// Return an array of gift card redeemings.
/// This API call returns error 1006 if "Gift card extras" module is not enabled on this account.
/// </summary>
public static List<GiftCardRedeeming> GetGiftCardRedeemings(this Erply erply, GetGiftCardRedeemingsSettings settings) => erply.MakeRequest<List<GiftCardRedeeming>>(settings);
/// <summary>
/// Returns today's cash, card and other payment type totals for the specified register (point of sale).
/// This API call is for implementing a day closing procedure in POS. API provides day totals as recorded by ERPLY; cashier can then input actual counted amounts and reconcile the differences.
/// The returned totals include all payments that have taken place since the day was opened at the register. If you provide input parameter "openedUnixTime", API will check if a day was opened at that time; if it does not find that day opening event, an empty response is returned. If the parameter is omitted, API will automatically fetch the latest opening of the register.
/// This API call can also be called after the day closing procedure, should it be necessary.
/// If you are looking for X Report / Z Report printouts, see API call getReports.
/// To open or close the register, see POSOpenDay and POSCloseDay.
/// </summary>
public static List<PointOfSaleDayTotal> GetPointOfSaleDayTotals(this Erply erply, GetPointOfSaleDayTotalsSettings settings) => erply.MakeRequest<List<PointOfSaleDayTotal>>(settings);
/// <summary>
/// Get a sales report.
/// API returns a link to CSV file that contains the report. Field separator in the CSV is region- and configuration-specific — check getConfParameters, field "csv_field_separator".
/// If you want to display sales totals in graph format, and would like to retrieve a simpler data set, see the following API calls:
/// </summary>
public static string GetSalesReport(this Erply erply, GetSalesReportSettings settings) => erply.MakeRequest<string>(settings);
/// <summary>
/// Get summary inventory report (all stores and locations).
/// For more detailed data, use getProductStock instead.
/// </summary>
public static SummaryInventoryReport GetSummaryInventoryReport(this Erply erply, GetSummaryInventoryReportSettings settings) => erply.MakeRequest<SummaryInventoryReport>(settings);
/// <summary>
/// Get product quantities on Purchase Orders that have not been fulfilled yet.
/// </summary>
public static AmountsOnOrder GetAmountsOnOrder(this Erply erply, GetAmountsOnOrderSettings settings) => erply.MakeRequest<AmountsOnOrder>(settings);
#endregion
#region Storage

/// <summary>
/// Create or update an object.
/// ERPLY has an object storage where you can store custom data for plug-ins, integrations etc.
/// For other object storage functions, see getObjects, saveObject, deleteObject (which allow to manipulate whole objects), and incrementAttributeValue, decrementAttributeValue — which provide a way to atomically increment or decrement one numeric field of a specific object (eg. to implement a counter).
/// </summary>
public static int SaveObject(this Erply erply, SaveObjectSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Retrieve your custom objects.
/// ERPLY has an object storage where you can store custom data for plug-ins, integrations etc.
/// For other object storage functions, see getObjects, saveObject, deleteObject (which allow to manipulate whole objects), and incrementAttributeValue, decrementAttributeValue — which provide a way to atomically increment or decrement one numeric field of a specific object (eg. to implement a counter).
/// </summary>
public static List<Object> GetObjects(this Erply erply, GetObjectsSettings settings) => erply.MakeRequest<List<Object>>(settings);
/// <summary>
/// Delete an object.
/// ERPLY has an object storage where you can store custom data for plug-ins, integrations etc.
/// For other object storage functions, see getObjects, saveObject, deleteObject (which allow to manipulate whole objects), and incrementAttributeValue, decrementAttributeValue — which provide a way to atomically increment or decrement one numeric field of a specific object (eg. to implement a counter).
/// </summary>
public static void DeleteObject(this Erply erply, DeleteObjectSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Increment attribute value.
/// This API call is for editing custom objects. ERPLY has a custom object storage where you can store custom data for plug-ins, integrations etc.
/// For other object storage functions, see getObjects, saveObject, deleteObject (which allow to manipulate whole objects), and incrementAttributeValue, decrementAttributeValue — which provide a way to atomically increment or decrement one numeric field of a specific object (eg. to implement a counter).
/// </summary>
public static string IncrementAttributeValue(this Erply erply, IncrementAttributeValueSettings settings) => erply.MakeRequest<string>(settings);
/// <summary>
/// Decrement attribute value.
/// This API call is for editing custom objects. ERPLY has an object storage where you can store custom data for plug-ins, integrations etc.
/// For other object storage functions, see getObjects, saveObject, deleteObject (which allow to manipulate whole objects), and incrementAttributeValue, decrementAttributeValue — which provide a way to atomically increment or decrement one numeric field of a specific object (eg. to implement a counter).
/// </summary>
public static string DecrementAttributeValue(this Erply erply, DecrementAttributeValueSettings settings) => erply.MakeRequest<string>(settings);
#endregion
#region Other

/// <summary>
/// Add products into an assortment.
/// An assortment defines which products a particular store is allowed to sell and/or to purchase.
/// To retrieve a list of assortments, see getAssortments. To edit an assortment or add a new one, see saveAssortment. To manipulate with the products associated with an assortment, see API calls getAssortmentProducts, editAssortmentProducts and removeAssortmentProducts. To retrieve all products that can be sold in location according to product status in assortment and it's card see getSellableProducts.
/// This API call is available only if "Assortments" module has been enabled on your account.
/// </summary>
public static List<AssortmentProduct> AddAssortmentProducts(this Erply erply, AddAssortmentProductsSettings settings) => erply.MakeRequest<List<AssortmentProduct>>(settings);
/// <summary>
/// Add a new points transaction and increase customer's point balance.
/// Typically, reward points accumulate automatically from customer's purchases. You can define the "dollar spent / points earned" ratio in ERPLY backend, SETTINGS → Configuration → Invoices and Sales. This API function is only for adjusting customer's point balance manually, or for building a custom loyalty program.
/// To subtract points from customer, see subtractCustomerRewardPoints. To get current point balance for a specific customer, see getCustomerRewardPoints. (There is currently no way to retrieve point balances for all customers simultaneously.)
/// If you are building a custom loyalty program, you may also take a look at getEarnedRewardPointRecords and getUsedRewardPointRecords — to retrieve a detailed list of all transactions where customer has earned or spent points.
/// </summary>
public static List<CustomerRewardPoint> AddCustomerRewardPoints(this Erply erply, AddCustomerRewardPointsSettings settings) => erply.MakeRequest<List<CustomerRewardPoint>>(settings);
/// <summary>
/// Add a new value (specific color or size) to a matrix dimension.
/// A matrix dimension is necessary for setting up matrix products. Typical matrix dimensions are, for example, "Size" (in which the values might be 2, 4, 6, 8 — or S, M, L, XL) and "Color" (which may contain Blue, Red, Black, Green etc).
/// To create a new dimension, see saveMatrixDimension. To edit an existing value (to change its name or code), see editItemInMatrixDimension. To delete a value, see removeItemsFromMatrixDimension.
/// </summary>
public static int AddItemToMatrixDimension(this Erply erply, AddItemToMatrixDimensionSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add a new row to a price list.
/// To create a price list use the savePriceList API call.
/// If you want to remove any items from the price list, use the deleteProductInPriceList API call.
/// To edit products in price list use the editProductInPriceList API call.
/// To get the products from the price list, use the getProductsInPriceList API call.
/// </summary>
public static int AddProductToPriceList(this Erply erply, AddProductToPriceListSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add a new row to a supplier price list.
/// Contact ERPLY Helpdesk to enable Supplier Price Lists module on your account. (If not enabled, API returns error 1006.)
/// To create a supplier price list use the saveSupplierPriceList API call.
/// If you want to remove any items from the supplier price list, use the deleteProductsFromSupplierPriceList API call.
/// To edit products in the supplier price list use the editProductInSupplierPriceList API call.
/// To get the products from the supplier price list, use the getProductsInSupplierPriceList API call.
/// </summary>
public static int AddProductToSupplierPriceList(this Erply erply, AddProductToSupplierPriceListSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Store how many times each promotion has applied to a sale.
/// </summary>
public static void AddPromotionCountsToInvoice(this Erply erply, AddPromotionCountsToInvoiceSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Associate a price list with a store region.
/// Store regions can be used for grouping stores (locations, warehouses). The main feature of store regions is that price lists can also be applied to a region, not just individual stores, thereby simplifying price list management. A region can have an unlimited number of price lists, unlike a location, which is limited to 5 price lists.
/// To retrieve a list of regions (and price lists associated with them), see getStoreRegions. To reorder region price lists, see editStoreRegionPriceList. To remove a price list from a region, see removeStoreRegionPriceList.
/// The price lists associated with a region will be automatically applied when making a sale from POS or creating a sales document in ERPLY back office, or when calling API calculateShoppingCart.
/// It is also possible to make a price list apply only to a specific customer group, in a region. For that, see API calls addStoreRegionCustomerGroupPriceList, editStoreRegionCustomerGroupPriceList and removeStoreRegionCustomerGroupPriceList.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static void AddStoreRegionPriceList(this Erply erply, AddStoreRegionPriceListSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Associate a price list with a customer group AND store region.
/// This price list will apply in that region, to customers of that specific customer group only.
/// To learn more about regions, see the documentation of API call getStoreRegions. With getStoreRegions, you can retrieve lists of each region's price lists and customer group-specific price lists.
/// To reorder the price lists associated with a region and customer group, see editStoreRegionCustomerGroupPriceList. To remove a customer group-specific price list from a region, see removeStoreRegionCustomerGroupPriceList.
/// The price lists associated with region and customer group will be automatically applied when making a sale from POS or creating a sales document in ERPLY back office, or when calling API calculateShoppingCart.
/// If you want a price list to apply to all customers in a region, regardless of customer group, see addStoreRegionPriceList instead.
/// If you want a price list to apply to a customer group in all stores, regardless of region, you can associate it with a customer group instead. This needs to be done in ERPLY back office (there is no API call for that), but API call getCustomerGroups can report which price lists have been applied to a customer group.
/// A price list can also be associated with a single customer, or a single store.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static void AddStoreRegionCustomerGroupPriceList(this Erply erply, AddStoreRegionCustomerGroupPriceListSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Make a bin quantity adjustment which is not related to any sales or purchase document (eg. a discrepancy found in recounting). For quantity adjustments that are related to specific sales or purchase documents, you should use saveBinRecords instead.
/// Internally, this API call will also create transaction records, just like saveBinRecords does. However, in some cases this interface may be more convenient to use.
/// You can send multiple records with one API call; append numbers 1, 2, 3, ... to the parameter names to identify values for record 1, record 2, etc. Fore example, binID1, productID1, newAmount1 for the first record, binID2, productID2, newAmount2 for the second one and so on.
/// There is no hard limit to how many records you can send with one call, but it is recommended to keep it below 500. Also, more records take a longer time to process, so make sure you will not hit a timeout while waiting for API's response.
/// </summary>
public static void AdjustBinQuantities(this Erply erply, AdjustBinQuantitiesSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// An alias for API call calculateShoppingCart.
/// calculateShoppingCart takes a list of items and quantities as input, and returns up-to-date item prices and the total value of the cart — with price lists, discounts, promotions, coupons, and taxes automatically applied.
/// </summary>
public static void ApplyPromotions(this Erply erply,  settings) => erply.MakeRequest(settings);
/// <summary>
/// changePassword allows you to change user's password. When called, it provides you a "session key" that you can use in subsequent API calls as a token of authentication. When the password is successfully changed, all other session keys for this user that are still valid will be deleted.
/// This API call may return:
/// </summary>
public static changePassword ChangePassword(this Erply erply, ChangePasswordSettings settings) => erply.MakeRequest<changePassword>(settings);
/// <summary>
/// Clock in an employee.
/// Timeclock records are used for Time and Attendance Report. (If you have the module enabled on your ERPLY account, see Reports » Commission, timeclock » Time and Attendance Report.)
/// To clock out an employee, use clockOut. To retrieve all timeclock records, use getClockIns.
/// </summary>
public static clockIn ClockIn(this Erply erply, ClockInSettings settings) => erply.MakeRequest<clockIn>(settings);
/// <summary>
/// Clock out an employee.
/// Timeclock records are used for Time and Attendance Report. (If you have the module enabled on your ERPLY account, see Reports » Commission, timeclock » Time and Attendance Report.)
/// To clock in an employee, use clockIn. To retrieve all timeclock records, use getClockIns.
/// </summary>
public static clockOut ClockOut(this Erply erply, ClockOutSettings settings) => erply.MakeRequest<clockOut>(settings);
/// <summary>
/// Convert a language identifier used in ERPLY API (eg. "est", "lit") into a language identifier used by Berlin POS (eg. "en", "ee", "fr" or "cn").
/// API checks what languages are actually installed on your account. When requesting a non-installed language, API returns error code 1016. If POS does not support the corresponding language, an appropriate fallback value is returned — typically "us" (US English).
/// </summary>
public static List<int> ConvertAPILanguageIdentifierForPOS(this Erply erply, ConvertAPILanguageIdentifierForPOSSettings settings) => erply.MakeRequest<List<int>>(settings);
/// <summary>
/// Convert a language identifier used in Berlin POS (eg. "en", "ee", "fr" or "cn") into a language identifier used by ERPLY API.
/// Many API calls take an input parameter "lang". With this API call you can check what value to use to retrieve product names, product group names, payment methods etc. in a specific language: French, Turkish or any other.
/// This API call implements two important checks/features:
/// </summary>
public static int ConvertPOSLanguageIdentifier(this Erply erply, ConvertPOSLanguageIdentifierSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Copy items from the Master List to ERPLY's active product catalog.
/// If the item with same ID does not exist in ERPLY products, API call adds it (with same ID). Otherwise overwrites product fields with the values from Master List.
/// For other Master List-related API calls, see findMasterListProducts and saveMasterListProducts.
/// </summary>
public static List<int> CopyMasterListProductsToErply(this Erply erply, CopyMasterListProductsToErplySettings settings) => erply.MakeRequest<List<int>>(settings);
/// <summary>
/// Delete an appliance.
/// This API call returns error 1006 if assignment module is not enabled on this account.
/// </summary>
public static void DeleteAppliance(this Erply erply, DeleteApplianceSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete an assignment.
/// This API call returns error 1006 if assignment module is not enabled on this account.
/// </summary>
public static void DeleteAssignment(this Erply erply, DeleteAssignmentSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete an assignment group.
/// This API call returns error 1006 if assignment module is not enabled on this account.
/// </summary>
public static void DeleteAssignmentGroup(this Erply erply, DeleteAssignmentGroupSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete an assortment.
/// An assortment defines which products a particular store is allowed to sell and/or to purchase.
/// To retrieve a list of assortments, see getAssortments. To edit an assortment or add a new one, see saveAssortment. To manipulate with the products associated with an assortment, see API calls getAssortmentProducts, addAssortmentProducts, editAssortmentProducts and removeAssortmentProducts. To retrieve all products that can be sold in location according to product status in assortment and it's card see getSellableProducts.
/// This API call is available only if "Assortments" module has been enabled on your account.
/// </summary>
public static Assortment DeleteAssortment(this Erply erply, DeleteAssortmentSettings settings) => erply.MakeRequest<Assortment>(settings);
/// <summary>
/// Delete a billing statement.
/// </summary>
public static void DeleteBillingStatement(this Erply erply, DeleteBillingStatementSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a reading of billing statement.
/// </summary>
public static void DeleteBillingStatementReading(this Erply erply, DeleteBillingStatementReadingSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a previously created record (or records). After a record is deleted, API will also update the cumulative quantity of that product in that bin.
/// </summary>
public static void DeleteBinRecords(this Erply erply, DeleteBinRecordsSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a sales promotion.
/// </summary>
public static void DeleteCampaign(this Erply erply, DeleteCampaignSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a coupon rule.
/// </summary>
public static void DeleteCoupon(this Erply erply, DeleteCouponSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a customer's "association".
/// "Associations" are a specific one-to-many, one-way relationship between customers. A customer can have zero or more "associations", each one of which is a customer in itself, and one of which can be the "default association".
/// To see a list of a customer's "associations", see getCustomers and pass the flag getAssociationsAndProfessionals = 1. API will also return the IDs of these links.
/// With deleteCustomerAssociation, you can delete the link between two customers, so that one ceases to be an "association" for the other one.
/// To create a new link between two customers, see API call saveCustomerAssociation.
/// An identical feature is "customer's professionals". See saveCustomerProfessional and deleteCustomerProfessional.
/// </summary>
public static CustomerAssociation DeleteCustomerAssociation(this Erply erply, DeleteCustomerAssociationSettings settings) => erply.MakeRequest<CustomerAssociation>(settings);
/// <summary>
/// Delete a customer group.
/// </summary>
public static void DeleteCustomerGroup(this Erply erply, DeleteCustomerGroupSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a customer's "professional".
/// "Professionals" are a specific one-to-many, one-way relationship between customers. A customer can have zero or more "professionals", each one of which is a customer in itself, and one of which can be the "default professional".
/// To see a list of a customer's "professionals", see getCustomers and pass the flag getAssociationsAndProfessionals = 1. API will also return the IDs of these links.
/// With deleteCustomerProfessional, you can delete the link between two customers, so that one ceases to be a "professional" for the other one.
/// To create a new link between two customers, see API call saveCustomerProfessional.
/// An identical feature is "customer's associations". See saveCustomerAssociation and deleteCustomerAssociation.
/// </summary>
public static CustomerProfessional DeleteCustomerProfessional(this Erply erply, DeleteCustomerProfessionalSettings settings) => erply.MakeRequest<CustomerProfessional>(settings);
/// <summary>
/// Delete a delivery type.
/// </summary>
public static void DeleteDeliveryType(this Erply erply, DeleteDeliveryTypeSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete an employee.
/// </summary>
public static void DeleteEmployee(this Erply erply, DeleteEmployeeSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete an event.
/// </summary>
public static void DeleteEvent(this Erply erply, DeleteEventSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete an Inventory Registration.
/// </summary>
public static void DeleteInventoryRegistration(this Erply erply, DeleteInventoryRegistrationSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a location in warehouse.
/// "Location in warehouse" is a product classifier. A product can have one "location in warehouse".
/// See also getLocationsInWarehouse and saveLocationInWarehouse.
/// </summary>
public static LocationInWarehouse DeleteLocationInWarehouse(this Erply erply, DeleteLocationInWarehouseSettings settings) => erply.MakeRequest<LocationInWarehouse>(settings);
/// <summary>
/// Delete a matrix dimension.
/// </summary>
public static void DeleteMatrixDimension(this Erply erply, DeleteMatrixDimensionSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a price list.
/// </summary>
public static PriceList DeletePriceList(this Erply erply, DeletePriceListSettings settings) => erply.MakeRequest<PriceList>(settings);
/// <summary>
/// Delete a subsidy type.
/// API user must have the rights to manage Subsidy types.
/// This API call returns error 1006 if "Price list row subsidy and other fields module" is not enabled on this account.
/// To save a new subsidy type or update an existing one, use the saveSubsidyType API call.
/// To find subsidy types use the getSubsidyTypes API call.
/// </summary>
public static SubsidyType DeleteSubsidyType(this Erply erply, DeleteSubsidyTypeSettings settings) => erply.MakeRequest<SubsidyType>(settings);
/// <summary>
/// Delete a supplier.
/// </summary>
public static void DeleteSupplier(this Erply erply, DeleteSupplierSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a supplier group.
/// </summary>
public static void DeleteSupplierGroup(this Erply erply, DeleteSupplierGroupSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a product file.
/// </summary>
public static void DeleteProductFile(this Erply erply, DeleteProductFileSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete products from the price list.
/// To add products to price list, use the addProductToPriceList API call.
/// To edit a product in the price list, use the editProductInPriceList API call.
/// To retrieve the products that are on the price list, use the getProductsInPriceList API call.
/// </summary>
public static ProductInPriceList DeleteProductInPriceList(this Erply erply, DeleteProductInPriceListSettings settings) => erply.MakeRequest<ProductInPriceList>(settings);
/// <summary>
/// Remove a package option (eg. "a box of 12", or "a pallet of 2500") from a product.
/// In back office, packages are listed in the subsection Packages on product card.
/// To get a list of packages for a product (and their IDs, to be able to delete them), call API getProducts and specify flag getPackageInfo = 1.
/// To add or edit a package, see saveProductPackage.
/// </summary>
public static ProductPackage DeleteProductPackage(this Erply erply, DeleteProductPackageSettings settings) => erply.MakeRequest<ProductPackage>(settings);
/// <summary>
/// Delete products from the supplier price list.
/// Contact ERPLY Helpdesk to enable Supplier Price Lists module on your account. (If not enabled, API returns error 1006.)
/// To add products to the supplier price list, use the addProductToSupplierPriceList API call.
/// To edit a product in the supplier price list, use the editProductInSupplierPriceList API call.
/// To retrieve the products that are on the supplier price list, use the getProductsInSupplierPriceList API call.
/// </summary>
public static ProductsFromSupplierPriceList DeleteProductsFromSupplierPriceList(this Erply erply, DeleteProductsFromSupplierPriceListSettings settings) => erply.MakeRequest<ProductsFromSupplierPriceList>(settings);
/// <summary>
/// Delete a project.
/// </summary>
public static void DeleteProject(this Erply erply, DeleteProjectSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a store region.
/// Store regions can be used for grouping stores (locations, warehouses). The main feature of store regions is that price lists can also be applied to a region, not just individual stores, thereby simplifying price list management. A region can also have an unlimited number of price lists, unlike a location, which is limited to 5 price lists.
/// To retrieve a list of store regions, see getStoreRegions. To edit a store region or add a new one, see saveStoreRegion. To manipulate with the price lists associated with a region, see API calls addStoreRegionPriceList, editStoreRegionPriceList and removeStoreRegionPriceList.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static StoreRegion DeleteStoreRegion(this Erply erply, DeleteStoreRegionSettings settings) => erply.MakeRequest<StoreRegion>(settings);
/// <summary>
/// Delete a component of VAT rate (or sales tax / GST / etc. rate, depending on what taxation is used in the particular country).
/// To create or edit tax component, see saveVatRateComponent.
/// The following call can be used only if the "City, county and state tax rates" module has been enabled on your account.
/// </summary>
public static void DeleteVatRateComponent(this Erply erply, DeleteVatRateComponentSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a company type. Company types are used to specify business entity type of company client.
/// To retrieve a list of company types, see getCompanyTypes. To edit a company type or add a new one, see saveCompanyType.
/// </summary>
public static void DeleteCompanyType(this Erply erply, DeleteCompanyTypeSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a person title. Person titles are used as a prefix for polite client naming.
/// To retrieve a list of person titles, see getPersonTitles. To edit a person title or add a new one, see savePersonTitle.
/// </summary>
public static void DeletePersonTitle(this Erply erply, DeletePersonTitleSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a job title. Job titles are used to specify employee's job area.
/// To retrieve a list of job titles, see getJobTitles. To edit a job title or add a new one, see saveJobTitle.
/// </summary>
public static void DeleteJobTitle(this Erply erply, DeleteJobTitleSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Delete a business area. Business areas are used to specify area of company client.
/// To retrieve a list of business areas, see getBusinessAreas. To edit a business area or add a new one, see saveBusinessArea.
/// </summary>
public static void DeleteBusinessArea(this Erply erply, DeleteBusinessAreaSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Change the status of products in an assortment.
/// An assortment defines which products a particular store is allowed to sell and/or to purchase.
/// To retrieve a list of assortments, see getAssortments. To edit an assortment or add a new one, see saveAssortment. To manipulate with the products associated with an assortment, see API calls getAssortmentProducts, addAssortmentProducts and removeAssortmentProducts. To retrieve all products that can be sold in location according to product status in assortment and it's card see getSellableProducts.
/// This API call is available only if "Assortments" module has been enabled on your account.
/// </summary>
public static List<string> EditAssortmentProducts(this Erply erply, EditAssortmentProductsSettings settings) => erply.MakeRequest<List<string>>(settings);
/// <summary>
/// Edit information of your own company.
/// This data set can be queried with API call getCompanyInfo.
/// </summary>
public static void EditCompanyInfo(this Erply erply, EditCompanyInfoSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Edit an existing record in reward point history where a customer has earned reward points.
/// The history (and transactionIDs) can be retrieved with getEarnedRewardPointRecords.
/// Under normal circumstances, you should not use this method; this is only for transfering points history from one customer to another, or for correcting errors in points history. To add or remove points, use subtractCustomerRewardPoints and addCustomerRewardPoints instead.
/// Related API calls for editing reward point usage history are getUsedRewardPointRecords and editUsedRewardPointRecord.
/// </summary>
public static int EditEarnedRewardPointRecord(this Erply erply, EditEarnedRewardPointRecordSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Edit an existing value in a matrix dimension.
/// A matrix dimension is necessary for setting up matrix products. Typical matrix dimensions are, for example, "Size" (in which the values might be 2, 4, 6, 8 — or S, M, L, XL) and "Color" (which may contain Blue, Red, Black, Green etc).
/// To create a new dimension, see saveMatrixDimension. To add a new value, see addItemToMatrixDimension. To delete a value, see removeItemsFromMatrixDimension.
/// </summary>
public static int EditItemInMatrixDimension(this Erply erply, EditItemInMatrixDimensionSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Edit an existing record in price list.
/// API call editProductInPriceList does not allow to change product ID. To switch product, the price list row should be deleted using API call deleteProductInPriceList and a new one should be added using API call addProductToPriceList.
/// If you need to retrieve the products that are on the price list, use the getProductsInPriceList API call.
/// </summary>
public static int EditProductInPriceList(this Erply erply, EditProductInPriceListSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Edit an existing record in supplier price list.
/// Contact ERPLY Helpdesk to enable Supplier Price Lists module on your account. (If not enabled, API returns error 1006.)
/// API call editProductInSupplierPriceList does not allow to change product ID (nor amount, if Quantity discounts module is enabled). To switch product, the supplier price list row should be deleted using API call deleteProductsFromSupplierPriceList and a new one should be added using API call addProductToSupplierPriceList.
/// If you need to retrieve the products that are on the supplier price list, use the getProductsInSupplierPriceList API call.
/// </summary>
public static int EditProductInSupplierPriceList(this Erply erply, EditProductInSupplierPriceListSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Edit an association between a price list and a store region (change the price list's priority).
/// Store regions can be used for grouping stores (locations, warehouses). The main feature of store regions is that price lists can also be applied to a region, not just individual stores, thereby simplifying price list management. A region can also have an unlimited number of price lists, unlike a location, which is limited to 5 price lists.
/// To retrieve a list of regions (and price lists associated with them), see getStoreRegions. To associate a price list with a region, see addStoreRegionPriceList. To remove a price list from a region, see removeStoreRegionPriceList.
/// The price lists associated with a region will be automatically applied when making a sale from POS or creating a sales document in ERPLY back office, or when calling API calculateShoppingCart.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static void EditStoreRegionPriceList(this Erply erply, EditStoreRegionPriceListSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Edit an association between price list, customer group and a store region (change the price list's priority).
/// To learn more about regions, see the documentation of API call getStoreRegions. With getStoreRegions, you can retrieve lists of each region's price lists and customer group-specific price lists.
/// To associate a new price list with a region and customer group, see addStoreRegionCustomerGroupPriceList. To remove a customer group-specific price list from a region, see removeStoreRegionCustomerGroupPriceList.
/// The price lists associated with region and customer group will be automatically applied when making a sale from POS or creating a sales document in ERPLY back office, or when calling API calculateShoppingCart.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static void EditStoreRegionCustomerGroupPriceList(this Erply erply, EditStoreRegionCustomerGroupPriceListSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Edit an existing record in reward point usage history (where an amount has been subtracted from customer's point balance).
/// The history (and transactionIDs) can be retrieved with getUsedRewardPointRecords.
/// Under normal circumstances, you should not use this method; this is only for transfering points history from one customer to another, or for correcting errors in points history. To add or remove points, use subtractCustomerRewardPoints and addCustomerRewardPoints instead.
/// Related API calls for editing the history of earned reward points are getEarnedRewardPointRecords and editEarnedRewardPointRecord.
/// </summary>
public static int EditUsedRewardPointRecord(this Erply erply, EditUsedRewardPointRecordSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Look up a Master List product by code. You can use configuration parameter "master_list_min_search_string_length" to set minimum length for the input value. By default 3. You can also use configuration parameter "master_list_max_search_results" to set number of records returned by the request. By default 100.
/// For other Master List-related API calls, see saveMasterListProducts and copyMasterListProductsToErply.
/// </summary>
public static List<findMasterListProduct> FindMasterListProducts(this Erply erply, FindMasterListProductsSettings settings) => erply.MakeRequest<List<findMasterListProduct>>(settings);
/// <summary>
/// Retrieve appliances or vehicles.
/// This API call is related to the Assignments module. Depending on configuration, your Assignments module may be set up either for appliance repair (in which case it returns the list of appliances), or vehicle/car repair (it returns the list of vehicles). Vehicles have a few extra fields, compared to appliances.
/// This API call returns error 1006 if assignment module is not enabled on your account.
/// Important: if you operate in the European Union, the General Data Protection Regulation (GDPR) requires all processing done with customers' personal information to be logged. If the retrieved dataset contains any information that could be considered personally identifiable data of natural persons (vehicle registration numbers and VINs, for example), you are responsible for logging everything you do with the data. If it is not possible to keep the logs in the system that processes the data, you may consider writing the log entries into Erply, with the logProcessingOfCustomerData call.
/// </summary>
public static List<Appliance> GetAppliances(this Erply erply, GetAppliancesSettings settings) => erply.MakeRequest<List<Appliance>>(settings);
/// <summary>
/// Retrieve a list of occurrences where a promotion discount, price list discount or a manual discount has been applied to a retail sale.
/// This information can be used to build a "discount report", outlining how many times a promotion / price list has been invoked, what items have been purchased with it and what is the total discount that customers have received through each type of discount, each price list and each promotion.
/// A built-in report providing that information can be found in ERPLY back office, Reports → Sales Promotions.
/// To start accumulating the data, get access to that back office report, and to be able to use this API call, please contact customer support and ask them to enable "Promotion Report" extra module on your account.
/// Likewise, to accumulate inforation about price lists and manual discounts as well, not only promotions, please contact customer support and ask them to additionally enable the following modules on your account:
/// </summary>
public static List<AppliedPromotionRecord> GetAppliedPromotionRecords(this Erply erply, GetAppliedPromotionRecordsSettings settings) => erply.MakeRequest<List<AppliedPromotionRecord>>(settings);
/// <summary>
/// Retrieve assignment groups.
/// This API call returns error 1006 if assignment module is not enabled on this account.
/// </summary>
public static List<AssignmentGroup> GetAssignmentGroups(this Erply erply, GetAssignmentGroupsSettings settings) => erply.MakeRequest<List<AssignmentGroup>>(settings);
/// <summary>
/// Retrieve assignments.
/// Assignments module is an Erply feature for repair workshops. There are two different configurations: appliance repair and vehicle repair. API call getAppliances lists your appliance/vehicle database.
/// This API call returns error 1006 if assignment module is not enabled on this account.
/// </summary>
public static List<Assignment> GetAssignments(this Erply erply, GetAssignmentsSettings settings) => erply.MakeRequest<List<Assignment>>(settings);
/// <summary>
/// Get a list of assortments.
/// An assortment defines which products a particular store is allowed to sell and/or to purchase.
/// To edit an assortment or add a new one, see saveAssortment. To delete an assortment, see deleteAssortment. To manipulate with the products associated with an assortment, see API calls getAssortmentProducts, addAssortmentProducts, editAssortmentProducts and removeAssortmentProducts. To retrieve all products that can be sold in location according to product status in assortment and it's card see getSellableProducts.
/// This API call is available only if "Assortments" module has been enabled on your account.
/// </summary>
public static List<Assortment> GetAssortments(this Erply erply, GetAssortmentsSettings settings) => erply.MakeRequest<List<Assortment>>(settings);
/// <summary>
/// Get a list of products contained in an assortment.
/// An assortment defines which products a particular store is allowed to sell and/or to purchase.
/// To retrieve a list of assortments, see getAssortments. To edit an assortment or add a new one, see saveAssortment. To delete an assortment, see deleteAssortment. To manipulate with the products associated with an assortment, see API calls addAssortmentProducts, editAssortmentProducts and removeAssortmentProducts. To retrieve all products that can be sold in location according to product status in assortment and it's card see getSellableProducts.
/// This API call is available only if "Assortments" module has been enabled on your account.
/// </summary>
public static List<AssortmentProduct> GetAssortmentProducts(this Erply erply, GetAssortmentProductsSettings settings) => erply.MakeRequest<List<AssortmentProduct>>(settings);
/// <summary>
/// Retrieve "billed until" dates for recurring billings.
/// This API call calculates the end date of the last billed period for each specified billing. Check these dates against the parameters of respective billings to find out which customers are already due for their next invoice. Detailed information about each billing can be retrieved with API call getBillingStatements.
/// Most importantly, you need to know:
/// </summary>
public static BilledUntilDate GetBilledUntilDate(this Erply erply, GetBilledUntilDateSettings settings) => erply.MakeRequest<BilledUntilDate>(settings);
/// <summary>
/// Retrieve all recurring billings that have been set up in ERPLY.
/// A recurring billing indicates that customer should get a monthly (yearly) invoice for the indicated services, at the indicated price.
/// After the billing has been set up, recurring invoices need to be manually created and sent from back office Sales → Recurring billing, at the beginning or at the end of a month, as appropriate.
/// Alternatively, invoices can also be created over API with the saveSalesDocument call, and associated with the billing via the "billingStatementID" field.
/// To get the "billed until" date for each recurring billing, see API call getBilledUntilDate.
/// </summary>
public static List<BillingStatement> GetBillingStatements(this Erply erply, GetBillingStatementsSettings settings) => erply.MakeRequest<List<BillingStatement>>(settings);
/// <summary>
/// Retrieve billing statement readings.
/// </summary>
public static List<BillingStatementReading> GetBillingStatementReadings(this Erply erply, GetBillingStatementReadingsSettings settings) => erply.MakeRequest<List<BillingStatementReading>>(settings);
/// <summary>
/// Retrieve the cumulative quantities in bins.
/// </summary>
public static List<BinQuantity> GetBinQuantities(this Erply erply, GetBinQuantitiesSettings settings) => erply.MakeRequest<List<BinQuantity>>(settings);
/// <summary>
/// Retrieve the list of bin records.
/// </summary>
public static List<BinRecord> GetBinRecords(this Erply erply, GetBinRecordsSettings settings) => erply.MakeRequest<List<BinRecord>>(settings);
/// <summary>
/// Retrieve the list of bins (for one warehouse, or all warehouses, or specific bins by ID).
/// </summary>
public static List<Bin> GetBins(this Erply erply, GetBinsSettings settings) => erply.MakeRequest<List<Bin>>(settings);
/// <summary>
/// Get a list of business areas. Business areas are used to specify area of company client.
/// To edit a business area or add a new one, see saveBusinessArea. To delete a business area, see deleteBusinessArea.
/// </summary>
public static List<BusinessArea> GetBusinessAreas(this Erply erply, GetBusinessAreasSettings settings) => erply.MakeRequest<List<BusinessArea>>(settings);
/// <summary>
/// Retrieve POS cash drops and cash payouts.
/// A cash drop can be recorded with API call POSCashIN and a payout with POSCashOUT. These operations are printed on the register's day-end Z Report.
/// By convention, a cash drop with an amount of 0 is an indicator of "No Sale", ie. just opening the drawer.
/// </summary>
public static List<CashIn> GetCashIns(this Erply erply, GetCashInsSettings settings) => erply.MakeRequest<List<CashIn>>(settings);
/// <summary>
/// Get information about what items have been created, updated or deleted in the server since the given timestamp.
/// Function output lists the various modules (data tables) in the system, whether there have been additions/updates, and whether there have been deletions in the particular module.
/// </summary>
public static ChangedDataSince GetChangedDataSince(this Erply erply, GetChangedDataSinceSettings settings) => erply.MakeRequest<ChangedDataSince>(settings);
/// <summary>
/// Retrieve currently clocked-in employees.
/// An employee can be clocked in with API call clockIn and clocked out with clockOut.
/// Timeclock records can be retrieved with API call getClockIns.
/// </summary>
public static List<ClockedInEmployee> GetClockedInEmployees(this Erply erply, GetClockedInEmployeesSettings settings) => erply.MakeRequest<List<ClockedInEmployee>>(settings);
/// <summary>
/// Retrieve timeclock records.
/// An employee can be clocked in with API call clockIn and clocked out with clockOut.
/// Timeclock records are used for Time and Attendance Report. (If you have the module enabled on your ERPLY account, see Reports » Commission, timeclock » Time and Attendance Report.)
/// </summary>
public static List<ClockIn> GetClockIns(this Erply erply, GetClockInsSettings settings) => erply.MakeRequest<List<ClockIn>>(settings);
/// <summary>
/// Get account configuration — all the settings from the module Settings > Configuration and also a number of hidden settings that can be enabled by Erply technical support.
/// This API call returns exactly one result record. This record contains a variable number of attributes and it is not guaranteed that any one of these attributes will be present. The contents of this record should be saved into a dictionary or an associative array, and a default value (0, unless specified otherwise) assumed for all missing ones.
/// Some of the parameters are supposed to have a decimal/integer value, or a value of 1 or 0 (true/false, enabled/disabled). However API returns almost all fields as strings. If your programming environment requires that, please cast the parameters to the correct type. In the table below, the types are marked with an asterisk.
/// Most — but not all! — settings can be edited using saveConfParameter. Do NOT edit any undocumented settings or those marked as "Not Editable".
/// </summary>
public static List<ConfParameter> GetConfParameters(this Erply erply) => erply.MakeRequest<List<ConfParameter>>(new ErplyCall() { CallName = "getConfParameters" });
/// <summary>
/// Get the list of countries. Countries are a way of categorizing your customer and supplier databases.
/// </summary>
public static List<Country> GetCountries(this Erply erply, GetCountriesSettings settings) => erply.MakeRequest<List<Country>>(settings);
/// <summary>
/// Get coupon rules.
/// Coupon rule is like the "blueprint" or "type" of a printed coupon (that is issued from POS and handed to a customer). The "blueprint" specifies in what circumstances the coupons will be printed from POS, and what promotion will apply when customer returns with the coupon — ie., what discount or extra value it effectively carries.
/// A coupon rule should be associated with a sales promotion (see getCampaigns).
/// In order for the customer to use those discounts, you need to issue the customer a coupon with an unique serial number (see getIssuedCoupons, saveIssuedCoupon). When customer returns with the coupon code, it has to be scanned at the POS. Scanning redeems the coupon, invokes the promotion associated with it, and gives customer a discount.
/// To create a coupon rule, see saveCoupon.
/// </summary>
public static List<Coupon> GetCoupons(this Erply erply, GetCouponsSettings settings) => erply.MakeRequest<List<Coupon>>(settings);
/// <summary>
/// Retrieve current balance (store credit) of all customers.
/// NB! This API call is essentially a report and can take a long time to run. Avoid calling it too frequently. API processes getCustomerBalances calls one at a time; if you issue another call while previous one is running, API returns error 1021.
/// Balance is essentially the difference between customer's total invoices and total payments. As such, balance cannot be adjusted directly. To change customer's balance (or to import initial balances), either create a payment (savePayment) or an unpaid invoice (saveSalesDocument).
/// When you create an invoice and want it to be paid off of customer's store credit (prepaid balance), set input parameter amountPaidWithStoreCredit.
/// If this call returns error 1006, please contact ERPLY helpdesk to update your account.
/// </summary>
public static List<CustomerBalance> GetCustomerBalances(this Erply erply, GetCustomerBalancesSettings settings) => erply.MakeRequest<List<CustomerBalance>>(settings);
/// <summary>
/// Get customer's current number of reward points.
/// Reward points accumulate automatically from customer's purchases. In Erply backend, you can set up how many reward points a customer earns for each $1 spent, and the reward points will accrue automatically from that point on.
/// To subtract the points ("redeem" or "use" them), use subtractCustomerRewardPoints.
/// Unfortunately, there no way yet to retrieve point balances for all customers simultaneously.
/// To add points manually (although you typically do not need to do that), see addCustomerRewardPoints. If you are building a custom loyalty program, you may also take a look at getEarnedRewardPointRecords and getUsedRewardPointRecords — to retrieve a detailed list of all transactions where customer has earned or spent points.
/// </summary>
public static List<int> GetCustomerRewardPoints(this Erply erply, GetCustomerRewardPointsSettings settings) => erply.MakeRequest<List<int>>(settings);
/// <summary>
/// Retrieve a log of POS day openings and closings.
/// POS can be opened with POSOpenDay and closed with POSCloseDay.
/// Each returned record corresponds to one day (or one cashier's shift) in one specific register.
/// If POS has been configured to accept and count multiple currencies, then for each day there will be a separate record for each currency.
/// </summary>
public static List<DayClosing> GetDayClosings(this Erply erply, GetDayClosingsSettings settings) => erply.MakeRequest<List<DayClosing>>(settings);
/// <summary>
/// An alias for getDayClosings.
/// </summary>
public static void GetDayOpenings(this Erply erply,  settings) => erply.MakeRequest(settings);
/// <summary>
/// Get delivery types.
/// "Delivery type" is a classifier for categorizing sales orders. To assign delivery type to a sales order, pass the deliveryTypeID input parameter to saveSalesDocument.
/// See also saveDeliveryType, deleteDeliveryType.
/// </summary>
public static List<DeliveryType> GetDeliveryTypes(this Erply erply) => erply.MakeRequest<List<DeliveryType>>(new ErplyCall() { CallName = "getDeliveryTypes" });
/// <summary>
/// Get delivery terms.
/// To assign delivery term to a supplier, pass the deliveryTermsID input to saveSupplier.
/// </summary>
public static List<DeliveryTerm> GetDeliveryTerms(this Erply erply) => erply.MakeRequest<List<DeliveryTerm>>(new ErplyCall() { CallName = "getDeliveryTerms" });
/// <summary>
/// Retrieve document statuses.
/// Note: Documents module in ERPLY is being phased out and is no longer developed.
/// </summary>
public static List<DocumentStatus> GetDocumentStatuses(this Erply erply) => erply.MakeRequest<List<DocumentStatus>>(new ErplyCall() { CallName = "getDocumentStatuses" });
/// <summary>
/// Retrieve document types.
/// Note: Documents module in ERPLY is being phased out and is no longer developed.
/// </summary>
public static List<DocumentType> GetDocumentTypes(this Erply erply) => erply.MakeRequest<List<DocumentType>>(new ErplyCall() { CallName = "getDocumentTypes" });
/// <summary>
/// Retrieve document series.
/// Note: Documents module in ERPLY is being phased out and is no longer developed.
/// </summary>
public static List<DocumentSery> GetDocumentSeries(this Erply erply) => erply.MakeRequest<List<DocumentSery>>(new ErplyCall() { CallName = "getDocumentSeries" });
/// <summary>
/// Retrieve all transactions where customers have earned reward points.
/// This API call is for building custom loyalty programs. For other related calls, see addCustomerRewardPoints (to add points to a customer manually) and getUsedRewardPointRecords (to retrieve transactions where customers have spent reward points}.
/// For simpler integrations, you will more likely need getCustomerRewardPoints to retrieve a customer's point balance, and subtractCustomerRewardPoints to subtract points from customer.
/// To edit one specific record, use editEarnedRewardPointRecord. (Under normal circumstances, you should not use that method; this is only for transfering points history from one customer to another, or for correcting errors in points history. To add or remove points, use subtractCustomerRewardPoints and addCustomerRewardPoints instead.)
/// </summary>
public static List<EarnedRewardPointRecord> GetEarnedRewardPointRecords(this Erply erply, GetEarnedRewardPointRecordsSettings settings) => erply.MakeRequest<List<EarnedRewardPointRecord>>(settings);
/// <summary>
/// if ID is specified, returns the corresponding EDocument. Otherwise returns a list of EDocuments, according to the supplied filtering parameters.
/// </summary>
public static List<string> GetEDocuments(this Erply erply, GetEDocumentsSettings settings) => erply.MakeRequest<List<string>>(settings);
/// <summary>
/// Returns the list of configured email accounts and the access credentials for each account
/// </summary>
public static List<EmailAccount> GetEmailAccounts(this Erply erply, GetEmailAccountsSettings settings) => erply.MakeRequest<List<EmailAccount>>(settings);
/// <summary>
/// Retrieve some total figures about employee sales performance. Currently this method only returns information about the currently authenticated user. Calling this method does not require any user rights.
/// This method returns only one record, with the fields described below.
/// These figures may be approximate, ERPLY may use optimizations to return these figures quickly (eg. to cache the calculated values). For authoritative sales data, see API call getSalesReport.
/// Unfortunately, timeclock records are not available over the API yet.
/// </summary>
public static List<EmployeeStat> GetEmployeeStats(this Erply erply) => erply.MakeRequest<List<EmployeeStat>>(new ErplyCall() { CallName = "getEmployeeStats" });
/// <summary>
/// Retrieve events or appointments.
/// In Erply backend, events (appointments) are listed in the Calendar » Tasks module.
/// To edit or add an event, use saveEvent.
/// </summary>
public static List<Event> GetEvents(this Erply erply, GetEventsSettings settings) => erply.MakeRequest<List<Event>>(settings);
/// <summary>
/// Retrieve event statuses.
/// Statuses can be added or edited with saveEventStatus.
/// </summary>
public static List<EventStatus> GetEventStatuses(this Erply erply, GetEventStatusesSettings settings) => erply.MakeRequest<List<EventStatus>>(settings);
/// <summary>
/// Retrieve event types.
/// Types can be added or edited with saveEventType.
/// </summary>
public static List<EventType> GetEventTypes(this Erply erply, GetEventTypesSettings settings) => erply.MakeRequest<List<EventType>>(settings);
/// <summary>
/// Retrieve confirmed sales documents from the reporting account which have the specified type and invoice number. If this account does not belong to a franchise, API returns error 1067.
/// </summary>
public static List<FranchiseSalesDocument> GetFranchiseSalesDocuments(this Erply erply, GetFranchiseSalesDocumentsSettings settings) => erply.MakeRequest<List<FranchiseSalesDocument>>(settings);
/// <summary>
/// Retrieve sales orders that can be fulfilled.
/// </summary>
public static List<FulfillableOrder> GetFulfillableOrders(this Erply erply, GetFulfillableOrdersSettings settings) => erply.MakeRequest<List<FulfillableOrder>>(settings);
/// <summary>
/// Retrieve gift cards.
/// To create a new gift card, or update the balance of an existing gift card, use saveGiftCard. To get a log of gift card redeemings, see getGiftCardRedeemings.
/// In ERPLY, gift cards have a "balance". A gift card can be used multiple times, until all the balance has been spent. A customer can use any gift card that has not expired and has a non-zero balance.
/// </summary>
public static List<GiftCard> GetGiftCards(this Erply erply, GetGiftCardsSettings settings) => erply.MakeRequest<List<GiftCard>>(settings);
/// <summary>
/// Get a list of Home Stores (Sign-up Stores).
/// Customers have two properties, "Home Store" (the one they visit most often) and "Sign-up Store" (where they were first registered as a loyal customer). In franchise accounts, the list of Home Stores / Sign-up Stores can be larger than just the list of account's own stores (locations). Therefore, to populate the respective drop-downs on customer form, use this API call instead of getWarehouses.
/// Additionally, getHomeStores will not return those locations that have been designated as the "offline warehouses" for returned items.
/// </summary>
public static List<HomeStore> GetHomeStores(this Erply erply, GetHomeStoresSettings settings) => erply.MakeRequest<List<HomeStore>>(settings);
/// <summary>
/// Retrieve Inventory Registrations.
/// Inventory Registration is a document that takes products into inventory; it has a list of items and quantities. It is similar to a Purchase Invoice, but has fewer fields and is best suited for registering your initial stock quantities when you start using ERPLY — or for making inventory quantity adjustments.
/// Non-stock products and bundles cannot be on Inventory Registrations (these items do not have inventory).
/// Products can be removed from stock with Inventory Write-offs (see getInventoryWriteOffs) and moved between locations with Inventory Transfers (see getInventoryTransfers).
/// To create an Inventory Registration, see saveInventoryRegistration.
/// </summary>
public static List<InventoryRegistration> GetInventoryRegistrations(this Erply erply, GetInventoryRegistrationsSettings settings) => erply.MakeRequest<List<InventoryRegistration>>(settings);
/// <summary>
/// Get an inventory transfer report.
/// API returns a link to CSV file that contains the report.
/// To retrieve the documents (Inventory Transfers) themselves, see getInventoryTransfers.
/// Sales and purchase data is also available in report format. See getSalesReport and getPurchaseReport.
/// </summary>
public static string GetInventoryTransferReport(this Erply erply, GetInventoryTransferReportSettings settings) => erply.MakeRequest<string>(settings);
/// <summary>
/// Retrieve Inventory Transfers.
/// In ERPLY, an Inventory Transfer is a document that moves inventory between locations (stores); subtracts from one location and adds to the other. An Inventory Transfer has a list of items and quantities.
/// Non-stock products and bundles cannot be transfered (these items do not have inventory).
/// To create or update an Inventory Transfer, see saveInventoryTransfer.
/// To get a CSV report of Inventory Transfers, see getInventoryTransferReport. If you need all Transfers that have taken place in a certain time period, it is more efficient to get the report — you will get all the data with just one query.
/// </summary>
public static List<InventoryTransfer> GetInventoryTransfers(this Erply erply, GetInventoryTransfersSettings settings) => erply.MakeRequest<List<InventoryTransfer>>(settings);
/// <summary>
/// Retrieve Inventory Write-Offs.
/// Inventory Write-Off is a document that removes products from inventory; it has a list of items and quantities.
/// Products can be added to stock with Inventory Registrations (see getInventoryRegistrations) and moved between locations with Inventory Transfers (see getInventoryTransfers).
/// To create an Inventory Write-Off, see saveInventoryWriteOff.
/// </summary>
public static List<InventoryWriteOff> GetInventoryWriteOffs(this Erply erply, GetInventoryWriteOffsSettings settings) => erply.MakeRequest<List<InventoryWriteOff>>(settings);
/// <summary>
/// Retrieve invoice payment methods.
/// "Payment type" or expected payment method is an informative field on invoices. It indicates how the invoice will likely be paid by the customer. (However, keep in mind that actual payments on the invoice may be different from expected payment type.)
/// To add a new type or edit an existing one, see saveInvoicePaymentType.
/// </summary>
public static List<InvoicePaymentType> GetInvoicePaymentTypes(this Erply erply) => erply.MakeRequest<List<InvoicePaymentType>>(new ErplyCall() { CallName = "getInvoicePaymentTypes" });
/// <summary>
/// Get the list of coupons that have been printed from POS and issued to customers.
/// Coupons are used in Erply to give promotional discounts. Coupons can be printed from POS and given to customers. If customer returns to the store, presents the coupon and cashier scans coupon code, a specific promotion will apply to the ongoing sale.
/// Issued coupons can be registered in Erply with saveIssuedCoupon. If customer returns to the store with a coupon, it can be validated with verifyIssuedCoupon and then redeemed with redeemIssuedCoupon. To apply coupon discount to a sale, pass coupon code to API call calculateShoppingCart. calculateShoppingCart will also notify you whether the coupon was applicable to that particular shopping cart or not.
/// This API call returns error 1006 if promotions module is not enabled on this account.
/// </summary>
public static List<IssuedCoupon> GetIssuedCoupons(this Erply erply, GetIssuedCouponsSettings settings) => erply.MakeRequest<List<IssuedCoupon>>(settings);
/// <summary>
/// Retrieve list of locations in warehouse.
/// "Location in warehouse" is a product classifier. A product can have one "location in warehouse".
/// See also saveLocationInWarehouse and deleteLocationInWarehouse.
/// </summary>
public static LocationsInWarehouse GetLocationsInWarehouse(this Erply erply, GetLocationsInWarehouseSettings settings) => erply.MakeRequest<LocationsInWarehouse>(settings);
/// <summary>
/// Retrieve statuses ('open' or 'closed') of all registers (points of sale), in all shops and locations.
/// lastUpdated records will be zero for timestamp and empty for date if this register wasnt open or closed before.
/// </summary>
public static List<PointOfSaleStatus> GetPointOfSaleStatuses(this Erply erply, GetPointOfSaleStatusesSettings settings) => erply.MakeRequest<List<PointOfSaleStatus>>(settings);
/// <summary>
/// Retrieve prepayment percentages.
/// This is a list of predefined options that user can choose from — to set what fraction of the invoice the customer must pay in advance. This list is used:
/// </summary>
public static List<PrepaymentPercentage> GetPrepaymentPercentages(this Erply erply, GetPrepaymentPercentagesSettings settings) => erply.MakeRequest<List<PrepaymentPercentage>>(settings);
/// <summary>
/// Returns products that are on the price list.
/// API user must have the view rights for all price lists.
/// To add a new price list, use the savePriceList API call.
/// If you need to add products to a price list, use the addProductToPriceList API call.
/// To edit products on the price list, use the editProductInPriceList API call.
/// To delete products from the price list, use the deleteProductInPriceList API call.
/// </summary>
public static ProductsInPriceList GetProductsInPriceList(this Erply erply, GetProductsInPriceListSettings settings) => erply.MakeRequest<ProductsInPriceList>(settings);
/// <summary>
/// Returns products that are on the supplier price list.
/// Contact ERPLY Helpdesk to enable Supplier Price Lists module on your account. (If not enabled, API returns error 1006.)
/// API user must have the view rights for all supplier price lists.
/// To add a new supplier price list, use the saveSupplierPriceList API call.
/// If you need to add products to a supplier price list, use the addProductToSupplierPriceList API call.
/// To edit products on the supplier price list, use the editProductInSupplierPriceList API call.
/// To delete products from the supplier price list, use the deleteProductsFromSupplierPriceList API call.
/// </summary>
public static ProductsInSupplierPriceList GetProductsInSupplierPriceList(this Erply erply, GetProductsInSupplierPriceListSettings settings) => erply.MakeRequest<ProductsInSupplierPriceList>(settings);
/// <summary>
/// Retrieve values for product card extra field 1 (the options in the "Extra field 1" dropdown on product card).
/// This API call is available only if "Extra product card fields" module is enabled on your account.
/// </summary>
public static ProductExtraField1Values GetProductExtraField1Values(this Erply erply, GetProductExtraField1ValuesSettings settings) => erply.MakeRequest<ProductExtraField1Values>(settings);
/// <summary>
/// Retrieve values for product card extra field 2 (the options in the "Extra field 2" dropdown on product card).
/// This API call is available only if "Extra product card fields" module is enabled on your account.
/// </summary>
public static ProductExtraField2Values GetProductExtraField2Values(this Erply erply, GetProductExtraField2ValuesSettings settings) => erply.MakeRequest<ProductExtraField2Values>(settings);
/// <summary>
/// Retrieve values for product card extra field 3 (the options in the "Extra field 3" dropdown on product card).
/// This API call is available only if "Extra product card fields" module is enabled on your account.
/// </summary>
public static ProductExtraField3Values GetProductExtraField3Values(this Erply erply, GetProductExtraField3ValuesSettings settings) => erply.MakeRequest<ProductExtraField3Values>(settings);
/// <summary>
/// Retrieve values for product card extra field 4 (the options in the "Extra field 4" dropdown on product card).
/// This API call is available only if "Extra product card fields" module is enabled on your account.
/// </summary>
public static ProductExtraField4Values GetProductExtraField4Values(this Erply erply, GetProductExtraField4ValuesSettings settings) => erply.MakeRequest<ProductExtraField4Values>(settings);
/// <summary>
/// Retrieve product files (brochures, manuals, specifications). For each file, API provides a URL.
/// Please note that the files (as well as product images) are not accessible by default. To get access to the files, please contact ERPLY customer support.
/// The same information is also available through API call getProducts (field relatedFiles), so if you need to query product information anyway, getProducts API call can also provide you the list of associated files.
/// </summary>
public static List<ProductFile> GetProductFiles(this Erply erply, GetProductFilesSettings settings) => erply.MakeRequest<List<ProductFile>>(settings);
/// <summary>
/// Returns an array of product file types.
/// </summary>
public static List<ProductFileType> GetProductFileTypes(this Erply erply) => erply.MakeRequest<List<ProductFileType>>(new ErplyCall() { CallName = "getProductFileTypes" });
/// <summary>
/// Retrieve product package types. Type IDs are needed when saving product packages with API saveProduct.
/// </summary>
public static List<ProductPackageType> GetProductPackageTypes(this Erply erply, GetProductPackageTypesSettings settings) => erply.MakeRequest<List<ProductPackageType>>(settings);
/// <summary>
/// Retrieve product pictures.
/// For each picture, ERPLY provides 4 URLs for 4 different image sizes. These URLs must not be hotlinked — you need to download the images to your application and serve them from there.
/// Access to images is currently limited and the images are not accessible by default. If you need to access the files, please contact ERPLY customer support.
/// The same information is also available through API call getProducts (field images), so if you need to query product information anyway, getProducts can also provide you the list of images for each product.
/// </summary>
public static List<ProductPicture> GetProductPictures(this Erply erply, GetProductPicturesSettings settings) => erply.MakeRequest<List<ProductPicture>>(settings);
/// <summary>
/// Retrieve a product's net sales price in price lists.
/// This API call does not use result paging; all results are returned.
/// You can query prices for a single product (by supplying parameter productID) or multiple products at a time (by supplying parameter productIDs).
/// Note that price lists can cumulate or override each other (price lists can apply to locations, as well as customers and customer groups), and price lists can also specify discount percentages for certain product groups. Therefore this API call does not help you to find the current appropriate sales price for an item. For that purpose, use calculateShoppingCart. If you only need to apply price lists, not promotions, you may also use getProductPrices.
/// API call getProducts can also provide a list price for a specific customer and location, along with other product information.
/// To retrieve price lists together with all their contents, see getPriceLists.
/// </summary>
public static List<ProductPricesInPriceList> GetProductPricesInPriceLists(this Erply erply, GetProductPricesInPriceListsSettings settings) => erply.MakeRequest<List<ProductPricesInPriceList>>(settings);
/// <summary>
/// Retrieve product parameters.
/// "Product parameters" is a ERPLY add-on module, primarily for web shops. (It is not enabled by default. If you are looking for a simple way to attach extra key-value data to products, you may want to consider using attributes instead.)
/// To work with parameters, you first need to define "parameter groups" in Erply backend, and associate these with product groups. Each group must define a set of parameters for a specific type of product. Eg.: inner and outer diameter for bearings; volume, energy rating and physical dimensions for refrigerators etc.
/// Then, on product card, you can set specific parameter values for each item (eg. Refrigerator XYZ has a volume of 250 L, energy rating "A+" and measures 500 x 650 x 1700 mm).
/// This API call will return list of parameters and which parameter group they belong to. Unfortunately, API does not have calls for listing all the groups yet, or querying which product groups are associated with which parameter groups.
/// To get products and their parameter values, use API call getProducts, set getParameters = 1 and see output field "parameters".
/// </summary>
public static List<Parameter> GetParameters(this Erply erply, GetParametersSettings settings) => erply.MakeRequest<List<Parameter>>(settings);
/// <summary>
/// Returns an array of possible project statuses.
/// </summary>
public static List<ProjectStatus> GetProjectStatuses(this Erply erply) => erply.MakeRequest<List<ProjectStatus>>(new ErplyCall() { CallName = "getProjectStatuses" });
/// <summary>
/// Returns an array of possible project types.
/// </summary>
public static List<ProjectType> GetProjectTypes(this Erply erply) => erply.MakeRequest<List<ProjectType>>(new ErplyCall() { CallName = "getProjectTypes" });
/// <summary>
/// Returns an array of purchase document possible statuses.
/// </summary>
public static List<PurchaseDocumentStatus> GetPurchaseDocumentStatuses(this Erply erply) => erply.MakeRequest<List<PurchaseDocumentStatus>>(new ErplyCall() { CallName = "getPurchaseDocumentStatuses" });
/// <summary>
/// Retrieve a purchase report.
/// API returns a link to CSV file that contains the report.
/// Sales and Inventory Transfers are also available in report format. See getSalesReport and getInventoryTransferReport.
/// </summary>
public static string GetPurchaseReport(this Erply erply, GetPurchaseReportSettings settings) => erply.MakeRequest<string>(settings);
/// <summary>
/// Get a list of reason codes.
/// </summary>
public static List<ReasonCode> GetReasonCodes(this Erply erply, GetReasonCodesSettings settings) => erply.MakeRequest<List<ReasonCode>>(settings);
/// <summary>
/// Get a list of receipt printings.
/// To register that a receipt has been printed, use API call registerReceiptPrint.
/// The presence of this API call does NOT mean that Erply back office, API and point-of-sale applications actually register all printings of invoices and receipts, and that all this information is already available over API. If you have a particular feature you want to implement, you need to create the full workflow yourself, using this pair of API calls — "registerReceiptPrint" and "getReceiptPrints".
/// At the moment, only Berlin POS uses the "registerReceiptPrint" call, and only on Swedish accounts — to meet the needs of Swedish Z Reports.
/// </summary>
public static List<ReceiptPrint> GetReceiptPrints(this Erply erply, GetReceiptPrintsSettings settings) => erply.MakeRequest<List<ReceiptPrint>>(settings);
/// <summary>
/// Get a list of coupons that have been redeemed at the register.
/// For a more generally useful API call, see getIssuedCoupons. getIssuedCoupons lists coupons with ALL statuses — active, expired, redeemed — and you can also use a status filter to retrieve any of the three.
/// </summary>
public static List<RedeemedCoupon> GetRedeemedCoupons(this Erply erply, GetRedeemedCouponsSettings settings) => erply.MakeRequest<List<RedeemedCoupon>>(settings);
/// <summary>
/// Get the total value of all transactions made in the specified register over time (all transactions that have accumulated in Erply).
/// This API call has been implemented to meet a specific requirement for Swedish Z Reports. For more general sales reports, please see getSalesReport.
/// </summary>
public static RegisterTotalSalesOverTime GetRegisterTotalSalesOverTime(this Erply erply, GetRegisterTotalSalesOverTimeSettings settings) => erply.MakeRequest<RegisterTotalSalesOverTime>(settings);
/// <summary>
/// Retrieve a list of reserved product quantities (ie. all products that have been reserved with a Sales Order, Prepayment Invoice, or a Sales Quote).
/// If you subtract the "reserved" quantity from your total inventory, you'll get the "available" quantity — the amount that can be sold while still leaving enough inventory for fulfilling Sales Orders.
/// API call getProductStock can also list the total inventory, and many other things, besides reserved amounts; getReservedStock is an optimized API call for retrieving just one piece of information.
/// If you need to get reserved stock across all locations then use API call syncTotalProductStock
/// </summary>
public static ReservedStock GetReservedStock(this Erply erply, GetReservedStockSettings settings) => erply.MakeRequest<ReservedStock>(settings);
/// <summary>
/// Retrieve invoices to which rounding was applied.
/// This API call may be useful for a report which needs to summarize and show amount of applied rounding separately from sales revenue.
/// Rounding can be configured in back office, Settings → Configuration (all invoice totals to be rounded to the nearest 5 cents, 10 cents or full currency units) or in POS (receipt total to be rounded only if customer pays in cash).
/// This report only returns confirmed Invoices, Invoice-Waybills, Receipts and Credit Invoices — ie., sales documents that incur sales revenue.
/// API call getSalesDocuments can be used to retrieve full data about documents.
/// </summary>
public static List<RoundedSale> GetRoundedSales(this Erply erply, GetRoundedSalesSettings settings) => erply.MakeRequest<List<RoundedSale>>(settings);
/// <summary>
/// Get an Actual Reports HTML printout for a sales document.
/// Actual Reports is a visual template designer integrated into Erply. Actual Reports templates can be managed in Erply back office. Erply provides a few basic templates by default, but new ones can be designed as needed. Back office lets you download a custom printout as a PDF document; the same document in HTML format is available with this API call.
/// </summary>
public static string GetSalesDocumentActualReportsHTML(this Erply erply, GetSalesDocumentActualReportsHTMLSettings settings) => erply.MakeRequest<string>(settings);
/// <summary>
/// Get an Actual Reports dataset for a sales document.
/// This API call returns basically the same result as back office sends to Actual Reports. The only difference is in VAT components and attributes - spaces in parameter names have been replaced with underscores.
/// This dataset is intended to be placed into an HTML template; each of these fields is a fragment of HTML and may contain HTML tags.
/// If you need to use this data in a non-HTML context, you should decode it appropriately:
/// </summary>
public static SalesDocumentActualReportsDataset GetSalesDocumentActualReportsDataset(this Erply erply, GetSalesDocumentActualReportsDatasetSettings settings) => erply.MakeRequest<SalesDocumentActualReportsDataset>(settings);
/// <summary>
/// Get recent daily sales totals by employee.
/// This a concise data set that suits best for displaying a graph. To get a full sales report, see getSalesReport.
/// See also getSalesTotalsByEmployeeAndMonth, getSalesTotalsByWarehouseAndDay, and getSalesTotalsByWarehouseAndMonth.
/// </summary>
public static SalesTotalsByEmployeeAndDay GetSalesTotalsByEmployeeAndDay(this Erply erply, GetSalesTotalsByEmployeeAndDaySettings settings) => erply.MakeRequest<SalesTotalsByEmployeeAndDay>(settings);
/// <summary>
/// Get recent monthly sales totals by employee.
/// This a concise data set that suits best for displaying a graph. To get a full sales report, see getSalesReport.
/// See also getSalesTotalsByEmployeeAndDay, getSalesTotalsByWarehouseAndDay, and getSalesTotalsByWarehouseAndMonth.
/// </summary>
public static SalesTotalsByEmployeeAndMonth GetSalesTotalsByEmployeeAndMonth(this Erply erply, GetSalesTotalsByEmployeeAndMonthSettings settings) => erply.MakeRequest<SalesTotalsByEmployeeAndMonth>(settings);
/// <summary>
/// Get recent daily sales by store (location).
/// This a concise data set that suits best for displaying a graph. To get a full sales report, see getSalesReport.
/// See also getSalesTotalsByEmployeeAndDay, getSalesTotalsByEmployeeAndMonth, and getSalesTotalsByWarehouseAndMonth.
/// </summary>
public static SalesTotalsByWarehouseAndDay GetSalesTotalsByWarehouseAndDay(this Erply erply, GetSalesTotalsByWarehouseAndDaySettings settings) => erply.MakeRequest<SalesTotalsByWarehouseAndDay>(settings);
/// <summary>
/// Get recent monthly sales by store (location).
/// This a concise data set that suits best for displaying a graph. To get a full sales report, see getSalesReport.
/// See also getSalesTotalsByEmployeeAndDay, getSalesTotalsByEmployeeAndMonth, and getSalesTotalsByWarehouseAndDay.
/// </summary>
public static SalesTotalsByWarehouseAndMonth GetSalesTotalsByWarehouseAndMonth(this Erply erply, GetSalesTotalsByWarehouseAndMonthSettings settings) => erply.MakeRequest<SalesTotalsByWarehouseAndMonth>(settings);
/// <summary>
/// Returns employee's work schedule. It can be retrieved in two formats: a list of employee's working hours for each day, or a list of employee's time off.
/// This API call can only be used is Salon module is enabled on your account. For other salon related functions, see getEmployees and getTimeSlots.
/// </summary>
public static Schedule GetSchedule(this Erply erply, GetScheduleSettings settings) => erply.MakeRequest<Schedule>(settings);
/// <summary>
/// Returns creation and expire information for session key that was included in this request.
/// </summary>
public static SessionKeyInfo GetSessionKeyInfo(this Erply erply) => erply.MakeRequest<SessionKeyInfo>(new ErplyCall() { CallName = "getSessionKeyInfo" });
/// <summary>
/// Returns first available appointment slots for a chosen service in a selected salon (location).
/// API will inspect employee's schedules and find first available times that have not been booked yet.
/// Using this API call, you can schedule:
/// </summary>
public static List<TimeSlot> GetTimeSlots(this Erply erply, GetTimeSlotsSettings settings) => erply.MakeRequest<List<TimeSlot>>(settings);
/// <summary>
/// Get a list of not completed and cancelled point of sale transactions.
/// This is a special integration with Berlin POS. When a sale in progress is cancelled (by clicking the red "trash can" button), the items that had been scanned so far get recorded as a "cancelled sale". If Berlin POS is configured to automatically delete pending sales at the end of a shift, these deleted documentsget recorded as "sales not completed".
/// This API call returns both of these records.
/// </summary>
public static List<UnfinishedSale> GetUnfinishedSales(this Erply erply, GetUnfinishedSalesSettings settings) => erply.MakeRequest<List<UnfinishedSale>>(settings);
/// <summary>
/// Retrive all reward point subtraction transactions.
/// This API call is for building custom loyalty programs. For other related calls, see addCustomerRewardPoints (to add points to a customer manually) and getEarnedRewardPointRecords (to retrieve transactions where customers have earned reward points}.
/// For simpler integrations, you will more likely need getCustomerRewardPoints to retrieve a customer's point balance, and subtractCustomerRewardPoints to subtract points from customer.
/// To edit one specific record, use editUsedRewardPointRecord. (Under normal circumstances, you should not use that method; this is only for transfering points history from one customer to another, or for correcting errors in points history. To add or remove points, use subtractCustomerRewardPoints and addCustomerRewardPoints instead.)
/// </summary>
public static List<UsedRewardPointRecord> GetUsedRewardPointRecords(this Erply erply, GetUsedRewardPointRecordsSettings settings) => erply.MakeRequest<List<UsedRewardPointRecord>>(settings);
/// <summary>
/// Returns IDs of all products that can be sold in the given location, according to product card status AND product's status in assortment (the product's status on both product card and in assortment must be "Active" or "No longer ordered").
/// This API call has been designed specifically for POS, and therefore it has slightly unusual behavior:
/// </summary>
public static List<int> GetSellableProducts(this Erply erply, GetSellableProductsSettings settings) => erply.MakeRequest<List<int>>(settings);
/// <summary>
/// Returns a list of service endpoints for POS applications.
/// When called by any other API clients, returns error 1161.
/// </summary>
public static List<ServiceEndpointsForPOS> GetServiceEndpointsForPOS(this Erply erply) => erply.MakeRequest<List<ServiceEndpointsForPOS>>(new ErplyCall() { CallName = "getServiceEndpointsForPOS" });
/// <summary>
/// Retrieve subsidy types.
/// This API call returns error 1006 if "Price list row subsidy and other fields module" is not enabled on this account.
/// To add new subsidy types or update existing, use the saveSubsidyType API call.
/// To delete subsidy types, use the deleteSubsidyType API call.
/// </summary>
public static List<SubsidyType> GetSubsidyTypes(this Erply erply, GetSubsidyTypesSettings settings) => erply.MakeRequest<List<SubsidyType>>(settings);
/// <summary>
/// Get a list of store regions.
/// Store regions can be used for grouping stores (locations, warehouses). The main feature of store regions is that price lists can also be applied to a region, not just individual stores, thereby simplifying price list management. A region can also have an unlimited number of price lists, unlike a location, which is limited to 5 price lists. Region can also contain customer group-specific price lists.
/// To edit a store region or add a new one, see saveStoreRegion. To delete a store region, see deleteStoreRegion. To manipulate with the price lists associated with a region, see API calls addStoreRegionPriceList, editStoreRegionPriceList and removeStoreRegionPriceList.
/// To manipulate with the price lists associated with region and customer group, see API calls addStoreRegionCustomerGroupPriceList, editStoreRegionCustomerGroupPriceList and removeStoreRegionCustomerGroupPriceList.
/// To see which regions a price list has been associated with, see the API call getStoreRegionsAssociatedWithPriceList.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static List<StoreRegion> GetStoreRegions(this Erply erply, GetStoreRegionsSettings settings) => erply.MakeRequest<List<StoreRegion>>(settings);
/// <summary>
/// Get a list of store regions that a price list has been associated with.
/// To add price lists to a region, or remove them, see API calls addStoreRegionPriceList and removeStoreRegionPriceList. To get a list of store regions, see API call getStoreRegions
/// For background information: in ERPLY, a price list always has to be associated with something to take effect. On its own, it is just a collection of prices and won't apply to any sale. A price list can be associated with:
/// </summary>
public static int GetStoreRegionsAssociatedWithPriceList(this Erply erply, GetStoreRegionsAssociatedWithPriceListSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Retrieve supplier groups.
/// </summary>
public static List<SupplierGroup> GetSupplierGroups(this Erply erply, GetSupplierGroupsSettings settings) => erply.MakeRequest<List<SupplierGroup>>(settings);
/// <summary>
/// Retrieve supplier price lists and the contents of each price list.
/// Contact ERPLY Helpdesk to enable Supplier Price Lists module on your account. (If not enabled, API returns error 1006.) Entering your supplier price lists into ERPLY is useful when creating Purchase Orders, or when receiving supplies; ERPLY will automatically populate the Price field for each item.
/// </summary>
public static List<SupplierPriceList> GetSupplierPriceLists(this Erply erply, GetSupplierPriceListsSettings settings) => erply.MakeRequest<List<SupplierPriceList>>(settings);
/// <summary>
/// Retrieve suppliers.
/// Suppliers can be associated with products (see getProducts) and purchase orders / purchase invoices (see getPurchaseDocuments).
/// </summary>
public static List<Supplier> GetSuppliers(this Erply erply, GetSuppliersSettings settings) => erply.MakeRequest<List<Supplier>>(settings);
/// <summary>
/// Retrieve sales documents where tax exemption was applied. (Customer supplied a tax exemption certificate number and their tax rate for that sale was reduced.)
/// With this information, it is possible to build a "Tax Exemption Report".
/// Please note that this API call only lists those occasions where tax exemption was manually activated in POS. Sales to customers who have the "Tax Exempt" check box checked on their customer card, are NOT listed.
/// This API call is only available if your account has Classic back office (not Berlin back office), and you must be using at least back office version 4.5.0. Otherwise, this API call will return error code 1006.
/// </summary>
public static List<TaxExemption> GetTaxExemptions(this Erply erply, GetTaxExemptionsSettings settings) => erply.MakeRequest<List<TaxExemption>>(settings);
/// <summary>
/// Retrieve tax offices.
/// </summary>
public static List<TaxOffice> GetTaxOffices(this Erply erply, GetTaxOfficesSettings settings) => erply.MakeRequest<List<TaxOffice>>(settings);
/// <summary>
/// Return an array of user groups.
/// </summary>
public static List<UserGroup> GetUserGroups(this Erply erply, GetUserGroupsSettings settings) => erply.MakeRequest<List<UserGroup>>(settings);
/// <summary>
/// Retrieve a log of all items that have been deleted from ERPLY (since a certain point of time). This is important for synchronizing data to a local database: getUserOperations lists items that you can delete from local database.
/// For more information, see the data synchronization guide: Synchronizing Data with “changedSince”
/// </summary>
public static UserOperationsLog GetUserOperationsLog(this Erply erply, GetUserOperationsLogSettings settings) => erply.MakeRequest<UserOperationsLog>(settings);
/// <summary>
/// Returns a list of users, along with their access rights. See the saveUser for user adding or editing.
/// </summary>
public static List<UserRight> GetUserRights(this Erply erply, GetUserRightsSettings settings) => erply.MakeRequest<List<UserRight>>(settings);
/// <summary>
/// Get a list of company types. Company types are used to specify business entity type of company client.
/// To edit a company type or add a new one, see saveCompanyType. To delete a company type, see deleteCompanyType.
/// </summary>
public static List<CompanyType> GetCompanyTypes(this Erply erply, GetCompanyTypesSettings settings) => erply.MakeRequest<List<CompanyType>>(settings);
/// <summary>
/// Get a list of person titles. Person titles are used as a prefix for polite client naming.
/// To edit a person title or add a new one, see savePersonTitle. To delete a person title, see deletePersonTitle.
/// </summary>
public static List<PersonTitle> GetPersonTitles(this Erply erply, GetPersonTitlesSettings settings) => erply.MakeRequest<List<PersonTitle>>(settings);
/// <summary>
/// Get a list of job titles. Job titles are used to specify employee's job area.
/// To edit a job title or add a new one, see saveJobTitle. To delete a job title, see deleteJobTitle.
/// </summary>
public static List<JobTitle> GetJobTitles(this Erply erply, GetJobTitlesSettings settings) => erply.MakeRequest<List<JobTitle>>(settings);
/// <summary>
/// Increment a product's counted quantity on a stocktaking act.
/// Use this call to implement a custom scanning / counting application. The application should issue an "incrementStocktakingReading" API call for each counted item; then the totals will be correct even if multiple devices are counting and updating quantities simultaneously.
/// For related API calls, see getStocktakings, getStocktakingReadings and saveStocktaking.
/// If you want to update quantities in bulk (and your script is the only one modifiying the stocktaking, so there are no concurrency issues), you may use saveStocktakingReadings.
/// </summary>
public static incrementStocktakingReading IncrementStocktakingReading(this Erply erply, IncrementStocktakingReadingSettings settings) => erply.MakeRequest<incrementStocktakingReading>(settings);
/// <summary>
/// Add an entry to the customer data processing log.
/// According to the General Data Protection Regulation (GDPR), all processing done with the information of natural persons – viewing, creating, changing, deleting, transferring etc. — must be logged. API automatically writes log entries when you create, update or delete customer information. However, when you retrieve customer information from API, API does not know which records are actually used and for what purpose — therefore you are responsible for logging these processing activities yourself. You can always keep the log in the system that actually does the processing; but if that option is not available, use this API call to write log entries into Erply.
/// This API call must be called whenever you fetch, transfer or synchronize customer information with any of the following API calls:
/// </summary>
public static void LogProcessingOfCustomerData(this Erply erply, LogProcessingOfCustomerDataSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Confirm that the user knows the data protection requirements of General Data Protection Regulation (a directive passed by European Parliament, taking effect in all the member states of the European Union on May 25, 2018), and agrees to follow these requirements.
/// This API call is part of the following process:
/// </summary>
public static recordGDPRConfirmation RecordGDPRConfirmation(this Erply erply) => erply.MakeRequest<recordGDPRConfirmation>(new ErplyCall() { CallName = "recordGDPRConfirmation" });
/// <summary>
/// Redeem a coupon that has been previously issued to a customer. All coupons accepted by the cashier have to be redeemed so that the coupons cannot be used again.
/// To just verify that a coupon is valid (before redeeming it), use verifyIssuedCoupon. To get the list of all issued coupons, use getIssuedCoupons.
/// redeemIssuedCoupon returns error 1040 if a coupon with such identifier has not been issued at all. If coupon has been redeemed already, API returns error 1041. If coupon has expired (and is thus not valid any more), API returns error 1045. If coupon is valid, API returns error 0.
/// </summary>
public static redeemIssuedCoupon RedeemIssuedCoupon(this Erply erply, RedeemIssuedCouponSettings settings) => erply.MakeRequest<redeemIssuedCoupon>(settings);
/// <summary>
/// Register that a receipt has been printed out from point of sale.
/// A list of all receipt printings can be retrieved with API call getReceiptPrints.
/// This API call has been implemented to meet a specific requirement of Swedish Z Reports, and it is used by Berlin POS only on Swedish accounts. However, it is also possible to implement custom workflows if needed: you can store data with API call "registerReceiptPrint" and fetch it later with "getReceiptPrints".
/// </summary>
public static int RegisterReceiptPrint(this Erply erply, RegisterReceiptPrintSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Remove products from an assortment.
/// An assortment defines which products a particular store is allowed to sell and/or to purchase.
/// To retrieve a list of assortments, see getAssortments, to edit an assortment or add a new one, see saveAssortment. To manipulate with the products associated with an assortment, see API calls getAssortmentProducts, addAssortmentProducts and editAssortmentProducts. To retrieve all products that can be sold in location according to product status in assortment and it's card see getSellableProducts.
/// This API call is available only if "Assortments" module has been enabled on your account.
/// </summary>
public static List<removeAssortmentProduct> RemoveAssortmentProducts(this Erply erply, RemoveAssortmentProductsSettings settings) => erply.MakeRequest<List<removeAssortmentProduct>>(settings);
/// <summary>
/// Remove variations from matrix dimension.
/// </summary>
public static void RemoveItemsFromMatrixDimension(this Erply erply, RemoveItemsFromMatrixDimensionSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Remove rules from price list. You need to specify rule type and the ID of the respective product or product group that you want to remove. (If using the Quantity Discounts module, you also need to specify the "amount" parameter.)
/// You can specify many such parameter pairs in one API request; give a sequential number (1, 2, 3, ...) to each such pair. The "#" character below denotes this sequential number.
/// It is also possible to remove products from the price list, by using the deleteProductInPriceList API call.
/// </summary>
public static void RemoveItemsFromPriceList(this Erply erply, RemoveItemsFromPriceListSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Remove rules from supplier price list.
/// Contact ERPLY Helpdesk to enable Supplier Price Lists module on your account. (If not enabled, API returns error 1006.)
/// You need to specify the ID of the respective product that you want to remove. (If using the Quantity Discounts module, you also need to specify the "amount" parameter.)
/// You can specify many such parameter pairs in one API request; give a sequential number (1, 2, 3, ...) to each such pair. The "#" character below denotes this sequential number.
/// </summary>
public static void RemoveItemsFromSupplierPriceList(this Erply erply, RemoveItemsFromSupplierPriceListSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Remove an association between a price list and a store region.
/// Store regions can be used for grouping stores (locations, warehouses). The main feature of store regions is that price lists can also be applied to a region, not just individual stores, thereby simplifying price list management. A region can also have an unlimited number of price lists, unlike a location, which is limited to 5 price lists.
/// To retrieve a list of regions (and price lists associated with them), see getStoreRegions. To associate a price list with a region, see addStoreRegionPriceList. To reorder region price lists, see editStoreRegionPriceList.
/// The price lists associated with a region will be automatically applied when making a sale from POS or creating a sales document in ERPLY back office, or when calling API calculateShoppingCart.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static removeStoreRegionPriceList RemoveStoreRegionPriceList(this Erply erply, RemoveStoreRegionPriceListSettings settings) => erply.MakeRequest<removeStoreRegionPriceList>(settings);
/// <summary>
/// Remove an association between price list, customer group and a store region.
/// To retrieve a list of regions (and price lists associated with them), see getStoreRegions. To associate a price list with a region, see addStoreRegionCustomerGroupPriceList. To reorder region price lists, see editStoreRegionCustomerGroupPriceList.
/// The price lists associated with region and customer group will be automatically applied when making a sale from POS or creating a sales document in ERPLY back office, or when calling API calculateShoppingCart.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static removeStoreRegionCustomerGroupPriceList RemoveStoreRegionCustomerGroupPriceList(this Erply erply, RemoveStoreRegionCustomerGroupPriceListSettings settings) => erply.MakeRequest<removeStoreRegionCustomerGroupPriceList>(settings);
/// <summary>
/// Create or update address type.
/// </summary>
public static int SaveAddressType(this Erply erply, SaveAddressTypeSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update an appliance or a vehicle. Appliances / Vehicles are related to the Assignments module.
/// If the Assignments module is not enabled on this account, error code 1006 is returned.
/// If the created or updated appliance or vehicle belongs to a natural person and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the change in the customer information processing log.
/// </summary>
public static int SaveAppliance(this Erply erply, SaveApplianceSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update an assignment.
/// This API call returns error 1006 if assignment module is not enabled on this account.
/// </summary>
public static int SaveAssignment(this Erply erply, SaveAssignmentSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update an assignment group.
/// This API call returns error 1006 if assignment module is not enabled on this account.
/// </summary>
public static int SaveAssignmentGroup(this Erply erply, SaveAssignmentGroupSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add or update an assortment.
/// An assortment defines which products a particular store is allowed to sell and/or to purchase.
/// To retrieve a list of assortments, see getAssortments. To delete an assortment, see deleteAssortment. To manipulate with the products associated with an assortment, see API calls getAssortmentProducts, addAssortmentProducts, editAssortmentProducts and removeAssortmentProducts. To retrieve all products that can be sold in location according to product status in assortment and it's card see getSellableProducts.
/// This API call is available only if "Assortments" module has been enabled on your account.
/// </summary>
public static int SaveAssortment(this Erply erply, SaveAssortmentSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Set up a recurring billing.
/// A recurring billing indicates that customer should get a monthly (yearly) invoice for the indicated services, at the indicated price.
/// After the billing has been set up, recurring invoices need to be manually created and sent from back office Sales → Recurring billing, at the beginning or at the end of a month, as appropriate.
/// Alternatively, invoices can also be created over API with the saveSalesDocument call, and associated with the billing via the "billingStatementID" field.
/// </summary>
public static int SaveBillingStatement(this Erply erply, SaveBillingStatementSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Creates a reading of billing statement.
/// </summary>
public static BillingStatementReading SaveBillingStatementReading(this Erply erply, SaveBillingStatementReadingSettings settings) => erply.MakeRequest<BillingStatementReading>(settings);
/// <summary>
/// Create or update a bin. Each bin belongs to one specific warehouse.
/// Bin codes must be per-warehouse unique. If you attempt to assign a duplicate code, API will return error 1012.
/// It is not possible to move a bin to another warehouse.
/// </summary>
public static int SaveBin(this Erply erply, SaveBinSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create a set of bin records. This is the recommended way to place items into bins (which have arrived with a Purchase Invoice or Inventory Registration) or remove sold items.
/// After saving and processing each record, API will also update the cumulative quantity of that product in that bin.
/// This call can also be used for editing existing records. In that case, API will also adjust the summarized quantity of that bin accordingly.
/// You can send multiple records with one API call; append numbers 1, 2, 3, ... to the parameter names to identify values for record 1, record 2, etc. Fore example, binID1, productID1, amount1 for the first record, binID2, productID2, amount2 for the second one and so on.
/// There is no hard limit to how many records you can send with one call, but it is recommended to keep it below 500. Also, more records take a longer time to process, so make sure you will not hit a timeout while waiting for API's response.
/// </summary>
public static void SaveBinRecords(this Erply erply, SaveBinRecordsSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Creates or updates brand.
/// </summary>
public static int SaveBrand(this Erply erply, SaveBrandSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a sales promotion.
/// A sales promotion is a rule that gives a discount when a certain condition is met — and can be configured to apply either automatically or be invoked manually by the cashier in POS.
/// For specifying unconditional discounts (that do not depend on a certain other item being purchased, or customer's total basket value), you should rather use price lists (see getPriceLists).
/// To retrieve promotions, see getCampaigns.
/// For an API call that automatically implements all promotion rules and price lists automatically for you, see calculateShoppingCart.
/// </summary>
public static int SaveCampaign(this Erply erply, SaveCampaignSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Upload company logo.
/// </summary>
public static CompanyLogo SaveCompanyLogo(this Erply erply, SaveCompanyLogoSettings settings) => erply.MakeRequest<CompanyLogo>(settings);
/// <summary>
/// Updates configuration parameter. If parameter name is invalid, returns error 1016. Some configuration parameters returned by getConfParameters — 'languages', 'additionalModules', 'invoice_algorithm_version', 'default_currency' — are derived from various other settings and you cannot directly change their value.
/// </summary>
public static void SaveConfParameter(this Erply erply, SaveConfParameterSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Creates or updates country.
/// </summary>
public static int SaveCountry(this Erply erply, SaveCountrySettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a coupon rule.
/// Coupon rule is like the "blueprint" or "type" of a printed coupon (that is issued from POS and handed to a customer). The "blueprint" specifies in what circumstances the coupons will be printed from POS, and what promotion will apply when customer returns with the coupon — ie., what discount or extra value it effectively carries.
/// A coupon rule should be associated with a sales promotion (see getCampaigns).
/// In order for the customer to use those discounts, you need to issue the customer a coupon with an unique serial number (see getIssuedCoupons, saveIssuedCoupon). When customer returns with the coupon code, it has to be scanned at the POS. Scanning redeems the coupon, invokes the promotion associated with it, and gives customer a discount.
/// To retrieve coupon rules, see getCoupons.
/// </summary>
public static int SaveCoupon(this Erply erply, SaveCouponSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Creates or updates currency.
/// </summary>
public static int SaveCurrency(this Erply erply, SaveCurrencySettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create a link between two customers — specify that one is an "association" for the other one.
/// "Associations" are a specific one-to-many, one-way relationship between customers. A customer can have zero or more "associations", each one of which is a customer in itself, and one of which can be the "default association".
/// To see a list of a customer's "associations", see getCustomers and pass the flag getAssociationsAndProfessionals = 1.
/// To delete the link between two customers, so that one ceases to be an "association" for the other one, see API call deleteCustomerAssociation.
/// An identical feature is "customer's professionals". See saveCustomerProfessional and deleteCustomerProfessional.
/// </summary>
public static int SaveCustomerAssociation(this Erply erply, SaveCustomerAssociationSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create a link between two customers — specify that one is a "professional" for the other one.
/// "Professionals" are a specific one-to-many, one-way relationship between customers. A customer can have zero or more "professionals", each one of which is a customer in itself, and one of which can be the "default professional".
/// To see a list of a customer's "professionals", see getCustomers and pass the flag getAssociationsAndProfessionals = 1.
/// To delete the link between two customers, so that one ceases to be a "professional" for the other one, see API call deleteCustomerProfessional.
/// An identical feature is "customer's associations". See saveCustomerAssociation and deleteCustomerAssociation.
/// </summary>
public static int SaveCustomerProfessional(this Erply erply, SaveCustomerProfessionalSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a delivery type.
/// </summary>
public static int SaveDeliveryType(this Erply erply, SaveDeliveryTypeSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a document.
/// Note: Documents module in ERPLY is being phased out and is no longer developed. Although you can create the records with API saveDocument, there is no corresponding getDocuments API call to retrieve saved documents.
/// </summary>
public static Document SaveDocument(this Erply erply, SaveDocumentSettings settings) => erply.MakeRequest<Document>(settings);
/// <summary>
/// Creates a new EDocument (sales invoice/order or purchase invoice/order)
/// </summary>
public static List<int> SaveEDocuments(this Erply erply, SaveEDocumentsSettings settings) => erply.MakeRequest<List<int>>(settings);
/// <summary>
/// Create or update an employee.
/// To retrieve employees, see API call getEmployees.
/// To record that employee agrees to follow the data protection requirements of General Data Protection Regulation, see API call recordGDPRConfirmation.
/// </summary>
public static int SaveEmployee(this Erply erply, SaveEmployeeSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update an event/appointment.
/// In Erply backend, events (appointments) are listed in the Calendar » Tasks module.
/// To retrieve events, use getEvents.
/// Function may return error 1043 if creating appointment and employee already has an appointment in the selected time slot. (In that case you need to requery getTimeSlots and select a different start and end time for new appointment.)
/// </summary>
public static int SaveEvent(this Erply erply, SaveEventSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update an event type.
/// To retrieve event types, see getEventTypes.
/// Events (appointments) can be managed with the getEvents and saveEvent API calls.
/// </summary>
public static int SaveEventType(this Erply erply, SaveEventTypeSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update an event status.
/// To retrieve event statuses, see getEventStatuses.
/// Events (appointments) can be managed with the getEvents and saveEvent API calls.
/// </summary>
public static List<int> SaveEventStatus(this Erply erply, SaveEventStatusSettings settings) => erply.MakeRequest<List<int>>(settings);
/// <summary>
/// Create a new gift card; or redeem an existing gift card and update its balance.
/// To retrieve a list of all gift cards, or for more information about gift cards in ERPLY, see getGiftCards.
/// </summary>
public static int SaveGiftCard(this Erply erply, SaveGiftCardSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update an invoice payment method.
/// "Payment type" or expected payment method is an informative field on invoices. It indicates how the invoice will likely be paid by the customer. (However, keep in mind that actual payments on the invoice may be different from expected payment type.)
/// To list existing invoice payment methods, see getInvoicePaymentTypes.
/// </summary>
public static int SaveInvoicePaymentType(this Erply erply, SaveInvoicePaymentTypeSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Register a printed coupon that has been issued to a customer, or update information on an existing coupon.
/// Issued coupon must have a unique identifier. Since coupons may carry monetary value, Erply keeps track of issued coupons and allows to validate (verify) a coupon when customer comes to redeem it.
/// The recommended workflow is as follows:
/// </summary>
public static IssuedCoupon SaveIssuedCoupon(this Erply erply, SaveIssuedCouponSettings settings) => erply.MakeRequest<IssuedCoupon>(settings);
/// <summary>
/// Create or update location in warehouse.
/// "Location in warehouse" is a product classifier. A product can have one "location in warehouse".
/// See also getLocationsInWarehouse and deleteLocationInWarehouse.
/// </summary>
public static int SaveLocationInWarehouse(this Erply erply, SaveLocationInWarehouseSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Import a set of products into Master List, creating new products or updating existing ones.
/// You can create or update 1000 products at a time. To use this API call, configuration parameter "master_list_unique_field" must be defined. This parameter identifies which field contains a unique code and should be used for identification and matching. By default "code". The field must be one of the code fields.
/// For other Master List-related API calls, see findMasterListProducts and copyMasterListProductsToErply.
/// </summary>
public static void SaveMasterListProducts(this Erply erply, SaveMasterListProductsSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Create or update a payment type.
/// To retrieve existing payment types, see getPaymentTypes.
/// </summary>
public static int SavePaymentType(this Erply erply, SavePaymentTypeSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create a price list, or add prices to an existing price list.
/// A price list can contain three types of rules: 1) fixed prices for specified products, 2) fixed prices for specified services, 3) percentage discounts for product groups. You may specify as many rules of each type as necessary.
/// If you need to create a very large price list (with thousands of items), we strongly recommend to create it in parts — create the list itself with the first API call, and then add items into the list with each subsequent call, eg. in batches of 1000.
/// If needed, you can edit just an existing price list's name, status and validity dates. In that case, API will not modify price list contents. However, you can also use this call for adding or updating prices in an existing price list. If you send any price list rules, API will check if the specified product or product group already exists in price list. If yes, that price list item will be updated. If not, a new one will be added.
/// If you want to remove any items from the price list, use the removeItemsFromPriceList or the deleteProductInPriceList API call.
/// It is also possible to add new items to the price list with the addProductToPriceList API call or edit a single rule with the editProductInPriceList API call.
/// If you have the Quantity Discounts module enabled, please note that each product may have multiple entries in the price list. If you want to address and update one specific rule, you also need to pass along the "amount" parameter.
/// </summary>
public static int SavePriceList(this Erply erply, SavePriceListSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Attach a new file (manual, brochure, price list, spec sheet) to product card, or replace an existing file.
/// To retrieve a list of files attached to a product, call getProducts and see the element "relatedFiles".
/// </summary>
public static int SaveProductFile(this Erply erply, SaveProductFileSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add a package option (eg. "a box of 12" or "a pallet of 2500") to a product, or modify an existing one.
/// In back office, packages are listed in the subsection Packages on product card.
/// To get a list of packages for a product (and their IDs, to be able to modify them), call API getProducts and specify flag getPackageInfo = 1.
/// To delete a package, see deleteProductPackage.
/// </summary>
public static int SaveProductPackage(this Erply erply, SaveProductPackageSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update priority group.
/// </summary>
public static int SaveProductPriorityGroup(this Erply erply, SaveProductPriorityGroupSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update product unit.
/// </summary>
public static int SaveProductUnit(this Erply erply, SaveProductUnitSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a project.
/// </summary>
public static int SaveProject(this Erply erply, SaveProjectSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a service.
/// </summary>
public static int SaveService(this Erply erply, SaveServiceSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add or update a store region.
/// Store regions can be used for grouping stores (locations, warehouses). The main feature of store regions is that price lists can also be applied to a region, not just individual stores, thereby simplifying price list management. A region can also have an unlimited number of price lists, unlike a location, which is limited to 5 price lists.
/// To retrieve a list of store regions, see getStoreRegions. To delete a store region, see deleteStoreRegion. To manipulate with the price lists associated with a region, see API calls addStoreRegionPriceList, editStoreRegionPriceList and removeStoreRegionPriceList.
/// This API call is available only if "Store regions" module has been enabled on your account.
/// </summary>
public static int SaveStoreRegion(this Erply erply, SaveStoreRegionSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a subsidy type.
/// API user must have the rights to manage Subsidy types.
/// This API call returns error 1006 if "Price list row subsidy and other fields module" is not enabled on this account.
/// It is required to add at least one name parameter. It can be either the general "name" parameter or any of the name parameters with a language code (e.g. "nameENG").
/// To find subsidy types, use the getSubsidyTypes API call.
/// To delete subsidy types, use the deleteSubsidyType API call.
/// </summary>
public static int SaveSubsidyType(this Erply erply, SaveSubsidyTypeSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a supplier.
/// </summary>
public static Supplier SaveSupplier(this Erply erply, SaveSupplierSettings settings) => erply.MakeRequest<Supplier>(settings);
/// <summary>
/// Create or update a supplier group.
/// </summary>
public static int SaveSupplierGroup(this Erply erply, SaveSupplierGroupSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create supplier price list, or add prices to an existing price list.
/// Contact ERPLY Helpdesk to enable Supplier Price Lists module on your account. (If not enabled, API returns error 1006.)
/// If you need to create a very large price list (with thousands of items), we strongly recommend to create it in parts — create the list itself with the first API call, and then add items into the list with each subsequent call, eg. in batches of 1000.
/// If needed, you can edit just an existing price list's name, status and validity dates. In that case, API will not modify price list contents. However, you can also use this call for adding or updating prices in an existing price list. If you send any price list rules, API will check if the specified product already exists in price list. If yes, that price list item will be updated. If not, a new one will be added.
/// If you want to remove any items from the price list, use the removeItemsFromSupplierPriceList API call.
/// If you have the Quantity Discounts module enabled, please note that each product may have multiple entries in the price list. If you want to address and update one specific rule, you also need to pass along the "amount" parameter.
/// </summary>
public static int SaveSupplierPriceList(this Erply erply, SaveSupplierPriceListSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a user. See the getUserRights with userID field for user data and rights retrieving.
/// This API call may return error 1061 or 1062 (if you do not have the right to add/edit users) or 1066 (if you do not have the right to manage users in that specific user group).
/// </summary>
public static int SaveUser(this Erply erply, SaveUserSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Write a custom log entry in user activity log.
/// User activity log is displayed in ERPLY backend, in Settings » Log of deleted items. As the name suggests, the log is mostly used for tracking deleted records. We strongly recommend to check with ERPLY development team before using the log for custom purposes.
/// Logs can be queried with getUserOperationsLog, but functionality is currently limited.
/// </summary>
public static int SaveUserOperationsLog(this Erply erply, SaveUserOperationsLogSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a VAT rate (or sales tax / GST / etc. rate, depending on what taxation is used in the particular country).
/// To get a list of all tax rates, see getVatRates.
/// </summary>
public static int SaveVatRate(this Erply erply, SaveVatRateSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Create or update a component of VAT rate (or sales tax / GST / etc. rate, depending on what taxation is used in the particular country).
/// To delete tax component, see deleteVatRateComponent.
/// The following call can be used only if the "City, county and state tax rates" module has been enabled on your account.
/// </summary>
public static int SaveVatRateComponent(this Erply erply, SaveVatRateComponentSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add or update company type. Company types are used to specify business entity type of company client.
/// To retrieve a list of company types, see getCompanyTypes. To delete a company type, see deleteCompanyType.
/// </summary>
public static int SaveCompanyType(this Erply erply, SaveCompanyTypeSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add or update person title. Person titles are used as a prefix for polite client naming.
/// To retrieve a list of person titles, see getPersonTitles. To delete a person title, see deletePersonTitle.
/// </summary>
public static int SavePersonTitle(this Erply erply, SavePersonTitleSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add or update job title. Job titles are used to specify employee's job area.
/// To retrieve a list of job titles, see getJobTitles. To delete a job title, see deleteJobTitle.
/// </summary>
public static int SaveJobTitle(this Erply erply, SaveJobTitleSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Add or update business area. Business areas are used to specify area of company client.
/// To retrieve a list of business areas, see getBusinessAreas. To delete a business area, see deleteBusinessArea.
/// </summary>
public static int SaveBusinessArea(this Erply erply, SaveBusinessAreaSettings settings) => erply.MakeRequest<int>(settings);
/// <summary>
/// Subtract, or "redeem", customer's reward points.
/// Reward points accrue automatically from customer's purchases. But whenever you perform an action that needs reward points to be redeemed — eg. apply a sales promotion where customer trades points for discount — you need to subtract the point amount manually, by calling subtractCustomerRewardPoints.
/// Use getCustomerRewardPoints to query for customer's current amount of points.
/// To add points manually (although you typically do not need to do that), see addCustomerRewardPoints. If you are building a custom loyalty program, you may also take a look at getEarnedRewardPointRecords and getUsedRewardPointRecords — to retrieve a detailed list of all transactions where customer has earned or spent points.
/// Points are also subtracted from customer's balance when you issue a coupon that "costs" reward points (see saveIssuedCoupon). However, this is done automatically by the API, and you do not need to call subtractCustomerRewardPoints for that.
/// </summary>
public static List<subtractCustomerRewardPoint> SubtractCustomerRewardPoints(this Erply erply, SubtractCustomerRewardPointsSettings settings) => erply.MakeRequest<List<subtractCustomerRewardPoint>>(settings);
/// <summary>
/// Change the status of one specific sales order to "fulfilled".
/// To change a sales document's status or any other properties, you can also use the more general API call, saveSalesDocument. The point of "setSalesOrderAsFulfilled" is that it does not require the user to have the permission to modify sales orders.
/// Updating a sales order's status to "fulfilled" is commonly one part of a point-of-sale transaction, but store manager may not want to give the cashiers the full authority to edit all sales orders. The point-of-sale application, however, does not need to do nothing else with the order — it just needs to update its status to "fulfilled". Therefore, we have exposed this operation as a separate API call.
/// This API call returns error code 1011 if the supplied ID does not belong to a sales order.
/// </summary>
public static void SetSalesOrderAsFulfilled(this Erply erply, SetSalesOrderAsFulfilledSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// This is an authentication function. When called, it provides you a "session key" that you can use in subsequent API calls as a token of authentication.
/// switchUser allows you to log in with user PIN (no user name / password needed); however, this API call can only be used for "user switching". It means that for calling switchUser, you need to already have a valid session key (or one that has just expired, no more than 2 hours old).
/// For a more general authentication function (that you should be using in most cases!), see verifyUser. It requires a user name and password. In verifyUser documentation, you will also find a general introduction to API authentication and sessions.
/// Successful user switch will give you a NEW session key, with the user rights of the PIN holder.
/// If authentication does not succeed, switchUser returns error 1051 or 1052. If the supplied session key is invalid, API returns error 1054 or 1055. If the session key is too old, API returns error 1056. In case of a success, API returns the information described below.
/// </summary>
public static switchUser SwitchUser(this Erply erply, SwitchUserSettings settings) => erply.MakeRequest<switchUser>(settings);
/// <summary>
/// Get each product's total inventory quantity across all locations.
/// If you don't specify "changedSince" parameter, then all the products that have stock different from 0 will be returned. Otherwise, this API call will return the total stock of products whose stock has changed after the specified time.
/// If you add parameter "getAmountReserved = 1", then API will return the reserved amounts as well. When product's stock is 0 but reserved amount is different from 0, then these products will also be returned. Input parameter "changedSince" takes into account the reservations as well if you have specified "getAmountReserved" parameter.
/// </summary>
public static syncTotalProductStock SyncTotalProductStock(this Erply erply, SyncTotalProductStockSettings settings) => erply.MakeRequest<syncTotalProductStock>(settings);
/// <summary>
/// Archive or de-archive a bin, or multiple bins simultaneously. API prevents archival if a bin still has quantities in it.
/// </summary>
public static void UpdateBinStatus(this Erply erply, UpdateBinStatusSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Update price on product card, for many products simultaneously.
/// This API call is specifically for updating product card price, but any other mass updates can be done by making API calls in bulk.
/// For editing product card in general, see saveProduct.
/// </summary>
public static void UpdatePrices(this Erply erply, UpdatePricesSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// Validate customer's web shop user name. API checks that the provided user name is unique — no other customer has such user name yet. If user name is not unique, API returns error 1012, otherwise error code 0 (success).
/// Use this API call before you assign a web shop user name and password to a customer (API call saveCustomer, fields username and password).
/// </summary>
public static void ValidateCustomerUsername(this Erply erply, ValidateCustomerUsernameSettings settings) => erply.MakeRequest(settings);
/// <summary>
/// This API call is used to sign into back office through Launchpad. It verifies if the Json Web Token is correct, Erply account is integrated with Identity and creates a new session. An error is returned if user doesn't exist in Erply or hasn't been assigned to a user group.
/// </summary>
public static verifyIdentityToken VerifyIdentityToken(this Erply erply, VerifyIdentityTokenSettings settings) => erply.MakeRequest<verifyIdentityToken>(settings);
/// <summary>
/// Validate a coupon identifier. The function verifies that the coupon has indeed been issued previously (using saveIssuedCoupon), that it has not expired, and that it has not been redeemed yet (using redeemIssuedCoupon).
/// If coupon has not been issued, returns error 1040. If coupon has been redeemed already, returns error 1041. If coupon has expired, returns error 1045. If coupon is valid, returns error 0.
/// </summary>
public static verifyIssuedCoupon VerifyIssuedCoupon(this Erply erply, VerifyIssuedCouponSettings settings) => erply.MakeRequest<verifyIssuedCoupon>(settings);
/// <summary>
/// Create a new ERPLY account.
/// </summary>
public static Installation CreateInstallation(this Erply erply, CreateInstallationSettings settings) => erply.MakeRequest<Installation>(settings);
/// <summary>
/// Create a new user to Erply. If username with the email address that's in Json Web Token already exists in Erply then an error is returned.
/// </summary>
public static int CreateUserFromIdentityToken(this Erply erply, CreateUserFromIdentityTokenSettings settings) => erply.MakeRequest<int>(settings);
#endregion
