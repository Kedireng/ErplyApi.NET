using System.Collections.Generic;

namespace ErplyAPI.Sales
{
    public static class SalesCalls
    {
        /// <summary>
        /// Retrieve sales documents (invoices, waybills, credit invoices, quotes or orders), according to the supplied filtering parameters.
        /// If you have specified document ID or invoice number, or if the search criteria match a single sales document, or if you have set getRowsForAllInvoices = 1, API returns all documents together with their rows. Otherwise only document headers will be returned.
        /// To create a new sales document (invoice, order or quote), see saveSalesDocument.
        /// If you are looking for a way to pull all sales data for external processing, see getSalesReport. getSalesReport can output either detailed data or aggregate it as needed: it can provide totals by products, by product groups, by dates, by locations, etc.
        /// </summary>
        public static List<SalesDocument> GetSalesDocuments(this Erply erply, GetSalesDocumentsSettings settings) => erply.MakeRequest<List<SalesDocument>>(settings);
        /// <summary>
        /// Returns a List of services.
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
        public static List<AllowedWarehouse> GetAllowedWarehouses(this Erply erply, GetAllowedWarehousesSettings settings) => erply.MakeRequest<List<AllowedWarehouse>>(settings);
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
        public static List<PointOfSale> GetPointsOfSale(this Erply erply, GetPointsOfSaleSettings settings) => erply.MakeRequest<List<PointOfSale>>(settings);
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
        public static SaveSalesDocumentResponse SaveSalesDocument(this Erply erply, SaveSalesDocumentSettings settings) => erply.MakeRequest<SaveSalesDocumentResponse>(settings);
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
        /// Add a new row to a price list.
        /// To create a price list use the savePriceList API call.
        /// If you want to remove any items from the price list, use the deleteProductInPriceList API call.
        /// To edit products in price list use the editProductInPriceList API call.
        /// To get the products from the price list, use the getProductsInPriceList API call.
        /// </summary>
        public static int AddProductToPriceList(this Erply erply, AddProductToPriceListSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Edit an existing record in price list.
        /// API call editProductInPriceList does not allow to change product ID. To switch product, the price list row should be deleted using API call deleteProductInPriceList and a new one should be added using API call addProductToPriceList.
        /// If you need to retrieve the products that are on the price list, use the getProductsInPriceList API call.
        /// </summary>
        public static int EditProductInPriceList(this Erply erply, EditProductInPriceListSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Returns products that are on the price list.
        /// API user must have the view rights for all price lists.
        /// To add a new price list, use the savePriceList API call.
        /// If you need to add products to a price list, use the addProductToPriceList API call.
        /// To edit products on the price list, use the editProductInPriceList API call.
        /// To delete products from the price list, use the deleteProductInPriceList API call.
        /// </summary>
        public static List<ProductInPriceList> GetProductsInPriceList(this Erply erply, GetProductsInPriceListSettings settings) => erply.MakeRequest<List<ProductInPriceList>>(settings);
        /// <summary>
        /// Delete products from the price list.
        /// To add products to price list, use the addProductToPriceList API call.
        /// To edit a product in the price list, use the editProductInPriceList API call.
        /// To retrieve the products that are on the price list, use the getProductsInPriceList API call.
        /// </summary>
        public static DeleteProductInPriceListResponse DeleteProductInPriceList(this Erply erply, DeleteProductInPriceListSettings settings) => erply.MakeRequest<ProductInPriceList>(settings);
    }
}
