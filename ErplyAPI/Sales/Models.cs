using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using ErplyAPI.Converters;

namespace ErplyAPI.Sales
{
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
        [JsonConverter(typeof(StringEnumConverter))]
        public SalesDocumentType? Type { get; set; }
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<SalesDocumentType> Types { get; set; }
        /// <summary>
        /// Search for sales documents that have a custom attribute with a specific value. You need to specify the name of the attribute as well as the required value.
        /// </summary>
        public List<Attribute> SearchAttributes { get; set; }
        /// <summary>
        /// If set to 1, fetches only those sales documents which have not been fully voided/returned/credited.
        /// If a sales document has been partially credited, returns only those amounts and rows that have not been credited yet. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? NonReturnedItemsOnly { get; set; }
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
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetReturnedPayments { get; set; }
        /// <summary>
        /// If set to 1, API also returns sales invoice creation timestamp. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetAddedTimestamp { get; set; }
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? DueDateFrom { get; set; }
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? DueDateTo { get; set; }
        /// <summary>
        /// If set to 1, API returns only unpaid sales documents.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? UnpaidItemsOnly { get; set; }
        /// <summary>
        /// If set to 1, API also returns the cost of goods sold.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetCOGS { get; set; }
        /// <summary>
        /// If set to 1, API returns only unfulfilled documents.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetUnfulfilledDocuments { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public SalesDocumentState? InvoiceState { get; set; }
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
        /// <summary>
        /// 'documentID', 'dateAndNumber', 'clientName', or 'lastChanged'.
        /// </summary>
        public OrderBy? OrderBy { get; set; }
        public OrderByDirection? OrderByDir { get; set; }
        /// <summary>
        /// Number of records API should return. By default 20, at most 100. 
        /// </summary>
        public int? RecordsOnPage { get; set; }
        /// <summary>
        /// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
        /// </summary>
        public int? PageNo { get; set; }
    }
    public enum SalesDocumentType
    {
        INVWAYBILL,
        CASHINVOICE,
        WAYBILL,
        PREPAYMENT,
        OFFER,
        EXPORTINVOICE,
        RESERVATION,
        CREDITINVOICE,
        ORDER,
        INVOICE,
        DOMESTIC,
        EU,
        OUTSIDE_EU,
        EU_WITH_VAT
    }
    public enum SalesDocumentState
    {
        PENDING,
        READY,
        MAILED,
        PRINTED,
        SHIPPED,
        FULFILLED,
        CANCELLED,
        NOT_CANCELLED
    }
    #endregion
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
        [JsonConverter(typeof(StringEnumConverter))]
        public SalesDocumentType? Type { get; set; }
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
        /// <summary>
        /// Number to be given to the sales document.
        /// Normally not needed.API will number invoices automatically.Use only when an invoice is created offline and it must definitely receive a number BEFORE it is possible to make the API call.
        /// If the document already has a number, it will not be changed.API will not return an error message.
        /// Make sure that the manually-assigned number will not interfere with Erply's regular invoice numbering. This field must be an integer (digits only), and only numbers with 8 digits or more are safe to be assigned manually (these will not affect invoices made from Erply)
        /// If you want to assign an invoice number that also contains letters and other characters, see the next field — customNumber.
        /// API will overwrite the number if it detects it's a duplicate. In that case, return attribute "invoiceNo" will contain the correct number. If you do not want this behavior, and do not want the number to automatically change (even if it is a duplicate), set allowDuplicateNumbers = 1.
        /// </summary>        
        public string Number { get; set; }
        [JsonProperty("invoiceNo")]
        private string InvoiceNo
        {
            get
            {
                return Number;
            }
            set
            {
                Number = value;
            }
        }
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Inventory transaction date.
        /// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
        /// Inventory Reports and COGS reports are based on the inventory transaction date.  
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? InventoryTransactionDate { get; set; }
        /// <summary>
        /// eg. 14:59:00  
        /// </summary>
        [JsonConverter(typeof(ISOTimeHHmmssConverter))]
        public TimeSpan? Time { get; set; }
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
        public int? CustomerID { get; set; }
        [JsonProperty("clientID")]
        private int? ClientID
        {
            get
            {
                return CustomerID;
            }
            set
            {
                CustomerID = value;
            }
        }
        /// <summary>
        /// Customer name.  
        /// </summary>
        public string CustomerName { get; set; }
        [JsonProperty("clientName")]
        private string ClientName
        {
            get
            {
                return CustomerName;
            }
            set
            {
                CustomerName = value;
            }
        }
        /// <summary>
        /// Customer e-mail address.  
        /// </summary>
        public string CustomerEmail { get; set; }
        [JsonProperty("clientEmail")]
        private string ClientEmail
        {
            get
            {
                return CustomerEmail;
            }
            set
            {
                CustomerEmail = value;
            }
        }
        /// <summary>
        /// Code of customer's loyalty/membership card. This corresponds to the "customerCardNumber" field in API call getCustomers.  
        /// </summary>
        public string CustomerCardNumber { get; set; }
        [JsonProperty("clientCardNumber")]
        private string ClientCardNumber
        {
            get
            {
                return CustomerCardNumber;
            }
            set
            {
                CustomerCardNumber = value;
            }
        }
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
        [JsonConverter(typeof(StringEnumConverter))]
        public SalesDocumentState? InvoiceState { get; set; }
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
        /// Array of source documents. For an invoice, source documents may be waybills, orders, quotes, or prepayment invoices. For a credit invoice, the source document is the original invoice being credited. This element is always present but may be empty if there are no source documents.
        /// Array elements have the following attributes:
        /// id - Integer - Invoice ID
        /// number - String - Invoice number
        /// type - String - Invoice type (see above for the list of defined types)
        /// date - Date (yyyy-mm-dd) - Invoice date.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<BaseDocument> BaseDocuments { get; set; }
        /// <summary>
        /// This element is always present but may be empty.
        /// Array elements have the following attributes:
        /// id - Integer - Invoice ID
        /// number - String - Invoice number
        /// type - String - Invoice type (see above for the list of defined types)
        /// date - Date (yyyy-mm-dd) - Invoice date.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<BaseDocument> FollowUpDocuments { get; set; }
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
        /// List of VAT (tax) rates and invoice net totals for each rate. Each list element contains the following fields:
        /// Field name Type Description
        /// vatrateID Integer Tax rate ID, see getVatRates
        /// total Decimal Net total
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<NetTotalByTaxRate> NetTotalsByTaxRate { get; set; }
        /// <summary>
        /// List of VAT (tax) rates and total VAT (tax) amounts for each rate. Each list element contains the following fields:
        /// Field name Type Description
        /// vatrateID Integer Tax rate ID, see getVatRates
        /// total Decimal Total VAT / tax
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<VatTotalByTaxRate> VatTotalsByTaxRate { get; set; }
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
        /// <summary>
        /// Penalty for late payments as % per day, eg. "0,5"
        /// This field is only informative and system does not account penalty automatically.
        /// </summary>
        public string Penalty { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool? TriangularTransaction { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool? PurchaseOrderDone { get; set; }
        public int? TransactionTypeID { get; set; }
        public string TransactionTypeName { get; set; }
        public int? TransportTypeID { get; set; }
        public string TransportTypeName { get; set; }
        public string DeliveryTerms { get; set; }
        public int? DeliveryTermsID { get; set; }
        public string DeliveryTermsLocation { get; set; }
        /// <summary>
        /// Document type.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public SalesDocumentType? EuInvoiceType { get; set; }
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
        /// <summary>
        /// API returns this attribute if parameter "getReturnedPayments" is specified.  
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<ReturnedPayment> ReturnedPayments { get; set; }
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
        /// If you have specified document ID or invoice number, or if the search criteria match a single sales document, or if you have set getRowsForAllInvoices = 1, API returns all documents together with their rows.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<DocumentRow> Rows { get; set; }
        /// <summary>
        /// If specified, the printout of created invoice will not mention any due date. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? HidePaymentDays { get; set; }
        /// <summary>
        /// Invoices marked with "sendByMail" have an e-mail indicator in the invoices table — these are meant to be sent by customer by e-mail. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? SendByEmail { get; set; }
        /// <summary>
        /// Invoice payment information, who paid, when, how.
        /// Max 255 characters
        /// </summary>
        public string PaymentInfo { get; set; }
        /// <summary>
        /// For CREDITINVOICEs only. Does not apply to US locale.
        /// Cash invoices have a calculation algorithm different from other sales documents.Cash invoice calculations are based on prices with VAT, so that invoice total would match the prices exactly.
        /// To make the distinction possible for credit invoices as well, set the isCashInvoice attribute to 1 if the source document was a cash invoice — then system will use cash invoice calculation method.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? IsCashInvoice { get; set; }
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
        /// Source document ID. For an invoice, source document may be a waybill, order, quote, or prepayment invoice.
        /// If you create a sales order, followed by a sales invoice, set the baseDocumentID on the sales invoice to link these two documents together. 
        /// </summary>
        public int? BaseDocumentID { get; set; }
        /// <summary>
        /// Source document IDs.
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> BaseDocumentIDs { get; set; }
    }
    public class NetTotalByTaxRate
    {
        /// <summary>
        /// Tax rate ID, see getVatRates
        /// </summary>
        public int? VatrateID { get; set; }
        /// <summary>
        /// Net total
        /// </summary>
        public float? Total { get; set; }
    }
    public class VatTotalByTaxRate
    {
        /// <summary>
        /// Tax rate ID, see getVatRates
        /// </summary>
        public int? VatrateID { get; set; }
        /// <summary>
        /// Total VAT / tax
        /// </summary>
        public float? Total { get; set; }
    }
    public class ReturnedPayment
    {
        /// <summary>
        /// Payment type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Payment sum
        /// </summary>
        public float? Sum { get; set; }
    }
    public class BaseDocument
    {
        public int ID { get; set; }
        public string Numer { get; set; }
        public string Type { get; set; }
    }
    public class Rate
    {
        public int ID { get; set; }
        public int Total { get; set; }
    }
    public class DocumentRow
    {
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
        /// List of campaigns (sales promotions) that have been applied to this invoice row. Needed for reporting.
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
        [ErplyProperty("State")]
        public string State { get; set; }
        [ErplyProperty("County")]
        public string County { get; set; }
        [ErplyProperty("Category")]
        public string Category { get; set; }
        [ErplyProperty("City")]
        public string City { get; set; }
        [ErplyProperty("StateSalesTax")]
        public float? StateSalesTax { get; set; }
        [ErplyProperty("CitySalesTax")]
        public float? CitySalesTax { get; set; }
        [ErplyProperty("TotalSalesTax")]
        public float? TotalSalesTax { get; set; }
        /// <summary>
        /// You need to specify this field if you want to associate this invoice line with a recurring, metered, billing. Erply will need to know which readings of the meter the invoice must be associated with.
        /// Readings can be entered in back office, when you open a Billing Statement, or with API call saveBillingStatementReading.The list of readings associated with a recurring billing can be queried with API call getBillingStatementReadings.
        /// You are allowed to set this field only if billingStatementID# refers to a billing statement that is based on metered readings. Otherwise, setting this field is forbidden and API will return error code 1013.
        /// If the reading IDs actually belong to another recurring billing, or a different invoice has already been associated with them, API will return error code 1130.
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> BillingReadingIDs { get; set; }
        [ErplyProperty("ZIPCode")]
        public string ZIPCode { get; set; }
    }
    #endregion
    #region SaveSalesDocument Settings
    public class SaveSalesDocumentSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveSalesDocument";

        /// <summary>
        /// By default 1, so API automatically confirms each sales document unless you specify otherwise (ConfirmInvoice = false).
        /// Note: An unconfirmed sales invoice does not(and cannot) have a number.
        /// Another tip: when you integrate Erply with a web shop and consider using unconfirmed sales invoices, perhaps a better option would be generating sales orders instead.
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? ConfirmInvoice { get; set; }
        /// <summary>
        /// Assign a custom number to this sales document. As opposed to invoiceNo, this field may contain letters, spacing and punctuation.
        /// Please note that back office support for custom numbers is currently limited.The custom number is displayed in the list of invoices and on the printouts, but you cannot search by that field.
        /// For custom numbers, API does not check for duplicates (whether another document with this number already exists). 
        /// </summary>
        public string CustomNumber { get; set; }
        /// <summary>
        /// Prevent API from overwriting invoice number if it detects that an invoice with the same number already exists. By default false
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? AllowDuplicateNumber { get; set; }
        public List<PromotionRule> PromotionRules { get; set; }

        [ErplyConverter(typeof(ErplyConverter))]
        public SalesDocument SalesDocument { get; set; }
    }
    [ErplyProperty("promotionRule")]
    public class PromotionRule
    {
        public List<PromotionPriceList> PriceLists { get; set; }
    }
    [ErplyProperty("priceList")]
    public class PromotionPriceList
    {
        /// <summary>
        /// Applied promotion ID, if this was a promotion discount.
        /// A record can have either "promotionID" or "priceListID", but not both at the same time.To specify a manual discount, omit both.
        /// </summary>
        public int? CampaignID { get; set; }
        /// <summary>
        /// Applied price list ID, if this was a price list discount.
        /// A record can have either "promotionID" or "priceListID", but not both at the same time.To specify a manual discount, omit both.
        /// </summary>
        public int? PriceListID { get; set; }
        /// <summary>
        /// What quantity the promotion, price list, or manual discount applied to, on this particular invoice line.
        /// If customer bought 2 or more of this item, but only one was with promotional discount (eg.a Buy One, Get One promotion), then set the value to 1.
        /// If a price list discount applied, then this value should always be equal to row quantity. 
        /// </summary>
        public int? Amount { get; set; }
        /// <summary>
        /// Total value (price * quantity) of the discounted items, immediately AFTER applying the discount.
        /// The name of the field is incorrect, but preserved for compatibility.
        /// Please note that this is not the same as "line total". If only some of the items on this invoice line were discounted, this must be the total for these discounted items only. 
        /// </summary>
        public float? FinalPrice { get; set; }
        /// <summary>
        /// Total $ discount given to this invoice line. 
        /// </summary>
        public float? TotalDiscount { get; set; }
        /// <summary>
        /// "ITEMS" or "INVOICE" — if this was a promotion discount.
        /// "ITEMS" for line or item discounts; "INVOICE" for any discounts that applied to the whole document. (Since there is no "invoice discount" concept in ERPLY, invoice discounts need to be divided proportinally between invoice lines.)
        /// </summary>
        public CampaignType? CampaignType { get; set; }
        /// <summary>
        /// Dollar discount that was specified in promotion parameters — if this was a dollar discount promotion. (For instance, if the promotion was "Get $20 off of all shoes", the field value should be 20.). 
        /// </summary>
        public float? CampaignDiscountValue { get; set; }
        /// <summary>
        /// Percentage discount as it was defined in promotion description — if this was a percentage discount promotion (eg "10% off"). 
        /// </summary>
        public float? CampaignDiscountPercentage { get; set; }
        /// <summary>
        /// "PRICE" or "DISCOUNT" — if this was a price list discount.
        /// "PRICE" - if the price list applied a fixed price, "DISCOUNT" - if the price list applied a discount percentage.
        /// </summary>
        public PriceListDiscountType? PriceListDiscountType { get; set; }
        /// <summary>
        /// Discount percentage from the price list (in case the price list discount was percentage-based). 
        /// </summary>
        public float? PriceListDiscountPercentage { get; set; }
        /// <summary>
        /// Manual discount percentage — if any manual discount was applied. 
        /// </summary>
        public float? ManualDiscountPercentage { get; set; }
    }
    public enum PriceListDiscountType
    {
        PRICE,
        DISCOUNT
    }
    public enum PromotionCampaignType
    {
        ITEMS,
        INVOICE
    }
    #endregion
    #region SaveSalesDocument Response
    public class SaveSalesDocumentResponse
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
        /// For POS receipts(type = "CASHINVOICE"), both printouts are equivalent, because receipts are always printed in receipt format.The "receiptLink" URL is only necessary for documents that could be printed out either way — eg.orders and laybys.
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
        /// List of store groups.  
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<string> StoreGroups { get; set; }
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
        /// Additional attributes. Each item looks like this:
        /// Field name Type Description
        /// attributeName String Attribute name
        /// attributeType String Attribute type
        /// attributeValue String Attribute value
        /// </summary>
        public List<Attribute> Attributes { get; set; }
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
    #region AllowedWarehouse

    public class AllowedWarehouse : ErplyItem
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
        public string UsernameOrEmail { get; set; }
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
        public DateTime? BirthdayMonthDayFrom { get; set; }
        /// <summary>
        /// Filter employees by birthday — get all employees whose birthday is on or before the specified month and day.
        /// If you only specify birthdayMonthDayTo and not birthdayMonthDayFrom, all birthdays between the beginning of the year and the specified day are returned.
        /// Combine the two filters to get birthdays in a specific range (eg. birthdays in June or July). Year wrap-around is supported: filter birthdayMonthDayFrom = "12-01", birthdayMonthDayTo = "01-31" returns birthdays in December and January.
        /// Both month and day must be two digits. Use a leading zero if necessary.
        /// </summary>
        [JsonConverter(typeof(ISODateMMddConverter))]
        public DateTime? BirthdayMonthDayTo { get; set; }
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
        /// 'employeeID', 'name', 'group' or 'lastChanged'.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderBy? OrderBy { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderByDirection? OrderByDir { get; set; }
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
        /// Array of locations (warehouse IDs) in which the employee is working.
        /// In other words, the locations for which the employee has access rights. Array elements have the following structure:
        /// Field name Type Description
        /// id Integer Warehouse ID
        /// </summary>
        public List<IDItem> Warehouses { get; set; }
        /// <summary>
        /// A comma-separated list of registers (Point of sale IDs) in which the employee is working.
        /// In other words, the registers for which the employee has access rights.
        /// Attributes warehouses and pointsOfSale both show basically the same information, because user rights are defined per-location. Using pointsOfSale just saves you the trouble of looking up register IDs for each location.  
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> PointsOfSale { get; set; }
        /// <summary>
        /// Salon-specific attribute. Available only if Salon / Spa module is enabled on your account, and if you have set getProductInfo parameter to 1.
        /// A list of services that the stylist / attendant performs. (Services are also listed in the products table, although marked as "non-stock products" - that's why this attribute returns product IDs.)
        /// Each element of the array has the following parameters:
        /// Field name Type Description
        /// productID Integer Product (service) ID
        /// productCode String Product (service) code
        /// productName String Product (service) name
        /// productGroup Integer Product (service) group
        /// For other salon-related API calls, see getSchedule and getTimeSlots. To get a list of all salon services, use API call getProducts with parameter nonStockProduct set to 1.  
        /// </summary>
        public List<EmployeeService> ProductIDs { get; set; }
        /// <summary>
        /// Additional attributes.
        /// </summary>
        public List<Attribute> Attributes { get; set; }
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
    public class EmployeeService
    {
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
        public string Productname { get; set; }
        /// <summary>
        /// Product (service) group
        /// </summary>
        public string ProductGroup { get; set; }
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
    #region PointOfSale

    public class PointOfSale : ErplyItem
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
        public string PaymentServiceProvider { get; set; }
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
        /// List of products and services that cashier can select with quick keys in this POS. The items are listed in order. Each item is either a product or a service.
        /// </summary>
        public List<PointOfSaleQuickButton> QuickButtons { get; set; }
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
        /// Additional attributes.
        /// </summary>
        public List<Attribute> Attributes { get; set; }
    }
    public class PointOfSaleQuickButton
    {
        public int? ProductID { get; set; }
        public int? ServiceID { get; set; }
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
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<PriceListType> Types { get; set; }
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
    public enum PriceListType
    {
        BASE_PRICE_LIST,
        STORE_PRICE_LIST
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
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// eg. 2010-01-29  
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? EndDate { get; set; }
        /// <summary>
        /// 0 or 1  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? Active { get; set; }
        /// <summary>
        /// Price list type, possible types are 'BASE_PRICE_LIST', 'STORE_PRICE_LIST'.
        /// This field is returned only if the "Price list types" module has been enabled on your account. Contact customer support to enable that feature.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PriceListType? Type { get; set; }
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
        [JsonProperty("pricelistRules")]
        [ErplyConverter(typeof(ListConverter))]
        public List<PriceListRule> Rules { get; set; }
        /// <summary>
        /// Additional attributes.
        /// </summary>
        public List<Attribute> Attributes { get; set; }
    }
    public class PriceListRule
    {
        public PriceListRuleType? Type { get; set; }
        public float? DiscountPercent { get; set; }
        public float? Price { get; set; }
        [JsonProperty("id")]
        public int? ID { get; set; }
        public int? RuleID { get; set; }
        public float? Amount { get; set; }
    }
    public enum PriceListRuleType
    {
        PRODUCT,
        PRODGROUP,
        SERVICE
    }

    #endregion
    #region SavePriceList Settings

    public class SavePriceListSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "savePriceList";
        [ErplyConverter(typeof(ErplyConverter))]
        public PriceList PriceList { get; set; }    
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
    #region ProductInPriceList

    public class ProductInPriceList : ErplyItem
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
    #region DeleteProductInPriceListResponse
    public class DeleteProductInPriceListResponse : ErplyItem
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
        /// Additional attributes.
        /// </summary>
        public List<Attribute> Attributes { get; set; }
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
        /// <summary>
        /// Available only if "City, county and state tax rates" module is enabled on your account.
        /// </summary>
        public List<VatrateComponent> Components { get; set; }
    }
    public class VatrateComponent
    {
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
        [JsonConverter(typeof(BoolConverter))]
        public bool? Default { get; set; }
        /// <summary>
        /// Example "dollars".  
        /// </summary>
        public string NameShort { get; set; }
        /// <summary>
        /// Example "cents"  
        /// </summary>
        public string NameFraction { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? LastModified { get; set; }
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
        [JsonConverter(typeof(StringEnumConverter))]
        public CampaignType? Type { get; set; }
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
    public enum CampaignType
    {
        AUTO,
        MANUAL,
        COUPON
    }
    #endregion
    #region Campaign

    public class Campaign : ErplyItem
    {
        public int? CampaignID { get; set; }
        /// <summary>
        /// Promotion start date.  
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? StartDate { get; set; }
        /// <summary>
        /// Promotion end date.  
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? EndDate { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Describes the way promotion is applied. Possible values:
        /// auto - Promotion is applied automatically to all customers, based on rules below. No coupons needed.
        /// manual - Cashier selects the promotion manually. (Cashier must have relevant rights - getUserRights must return rightApplyPromotions = 1)
        /// coupon - Promotion is applied when user hands in a printed coupon with a serial number.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CampaignType Type { get; set; }
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
        /// If this list contains any elements, then promotion is available only in specific store regions.
        /// "warehouseID", "storeRegions" and "storeGroup" are mutually exclusive: only one restriction is supposed to apply at a time.
        /// Each list element contains the following fields:
        /// Field name Type Description
        /// id Integer Store region ID
        /// </summary>
        public List<IDItem> StoreRegions { get; set; }
        /// <summary>
        /// If this list contains any elements, then promotion will apply only to these customer groups.
        /// Each list element contains the following fields:
        /// Field name Type Description
        /// id Integer Customer group ID
        /// </summary>
        public List<IDItem> CustomerGroups { get; set; }
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
        /// <summary>
        /// Each array element contains an integer field "productID". If "Price list row subsidy and other fields" module is enabled on your account, it will additionally contain a decimal field "subsidy".  
        /// </summary>
        public List<CampaignPurchasedProduct> PurchasedProducts { get; set; }
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
        /// <summary>
        /// A further restriction for the "% off entire sale" promotion. IDs of products to which the discount percentage should not be applied.  
        /// </summary>
        public List<int> PercentageOffExcludedProducts { get; set; }
        /// <summary>
        /// A further restriction for the "% off entire sale" promotion. IDs of the only allowed products to which the discount percentage may be applied, at all. (All other products in the basket should be left unaffected by this promotion.)  
        /// </summary>
        public List<int> PercentageOffIncludedProducts { get; set; }
        public float? SumOffEntirePurchase { get; set; }
        public int? PercentageOffMatchingItems { get; set; }
        public float? SumOffMatchingItems { get; set; }
        /// <summary>
        /// Each array element contains an integer productID attribute.  
        /// </summary>
        public List<ProductIDItem> SumOffExcludedProducts { get; set; }
        /// <summary>
        /// Each array element contains an integer productID attribute.  
        /// </summary>
        public List<ProductIDItem> SumOffIncludedProducts { get; set; }
        public float? SpecialPrice { get; set; }
        public int? AwardedProductGroupID { get; set; }
        public int? AwardedProductCategoryID { get; set; }
        /// <summary>
        /// Each array element contains an integer field "productID". If "Price list row subsidy and other fields" module is enabled on your account, it will additionally contain a decimal field "subsidy".  
        /// </summary>
        public List<ProductIDItem> AwardedProducts { get; set; }
        /// <summary>
        /// In promotion "% or $ off of specific products", how many items should get the discount. Fulfilling the promotion conditions may entitle the customer to one discounted item (awardedAmount = 1), or at most N discounted items (awardedAmount > 1), or an unlimited number of items (awardedAmount = 0). The "unlimited" option may be used in promotions such as "First item costs $3, subsequent ones are $2 each".  
        /// </summary>
        public int? AwardedAmount { get; set; }
        /// <summary>
        /// Each array element contains an integer productID attribute.  
        /// </summary>
        public List<ProductIDItem> ExcludedProducts { get; set; }
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
        /// Additional attributes.
        /// </summary>
        public List<Attribute> Attributes { get; set; }
    }
    public class CampaignPurchasedProduct
    {
        public int? ProductID { get; set; }
        public float? Subsidy { get; set; }
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
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime Date { get; set; }
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
        /// <summary>
        /// A flag indicating that this payment was once a part of customer's store credit (a pending prepayment, not associated with any invoice), but it has now been applied to a particular invoice. Customer used his/her "store credit" to pay off this invoice.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? StoreCredit { get; set; }
        /// <summary>
        /// API only returns this field if "Cayan / Merchant Warehouse payment data" (returns "merchant_warehouse"), "PAX payment data" (returns "pax"), "Tyro payment data" (returns "tyro") or "Givex payment data" (returns "givex) module is enabled on your account.  
        /// </summary>
        public string PaymentServiceProvider { get; set; }
        /// <summary>
        /// API only returns this field if "Cayan / Merchant Warehouse payment data" or "PAX payment data" module is enabled on your account.  
        /// </summary>
        public string Aid { get; set; }
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
        public string TransactionId { get; set; }
        /// <summary>
        /// API only returns this field if "Transaction Time of a Payment" module is enabled on your account.  
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? TransactionTime { get; set; }
        /// <summary>
        /// API only returns this field if "Klarna payment data" module is enabled on your account.  
        /// </summary>
        public string KlarnaPaymentID { get; set; }
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
        /// Additional attributes. Each item looks like this:
        /// Field name Type Description
        /// attributeName String Attribute name
        /// attributeType String Attribute type
        /// attributeValue String Attribute value
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }

    #endregion
    #region SavePayment Settings
    public class SavePaymentSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "savePayment";

        [ErplyConverter(typeof(ErplyConverter))]
        public Payment Payment { get; set; }

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
        public SalesDocumentType Type { get; set; }
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
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetAutomaticCoupons { get; set; }
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
        /// Use only fields 'ProductID', 'Amount', 'Price', 'Discount', 'VatrateID'. First two are required(ProductID, Amount)
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<DocumentRow> InvoiceLines { get; set; }
    }
    #endregion
    #region ShoppingCart

    public class ShoppingCart : ErplyItem
    {
        public List<ShoppingCartRow> Rows { get; set; }
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
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> AutomaticCoupons { get; set; }
        /// <summary>
        /// List of coupons that should be automatically printed to the customer after the sale has been completed.
        /// FYI: some promotions may cost points, too, and you do need to subtract those manually. See field appliedPromotions below.
        /// The recommended workflow is as follows:
        /// When calling calculateShoppingCart for the last time (you know that shopping cart has been finalized and neither contents nor cart total will not change any more), set getAutomaticCoupons = 1 and take note of the automatic coupon IDs that API returns.
        /// Save the sale with saveSalesDocument.
        /// For each provided coupon ID, call saveIssuedCoupon to generate a unique coupon number for the customer.
        /// If printing the coupon costs reward points, saveIssuedCoupon will subtract those automatically. If customer does not have a sufficient point balance, saveIssuedCoupon will return error 1042. If you want to be aware of that beforehand, you may issue a getCustomerRewardPoints API call to check customer's point balance.
        /// If you want to provide a paper coupon printout (or an e-mail etc.), you currently need to assemble it yourself. saveIssuedCoupon will return generated ID, coupon name and descriptive text that you can lay out as needed.
        /// Important! API assumes that you are calling calculateShoppingCart to prepare a sales invoice. The list of automatic coupons is provided on the assumption that customer will earn a few more points from the current sale — and those points are already counted in.
        /// Eg.: let's say that customers are always given a coupon when they reach 200 points. If a customer currently has 180 points, you call calculateShoppingCart and basket total value is $25, API will instruct you to print a coupon. (After the sale, the customer would have 205 pts, meaning that they would be eligible for the coupon.)
        /// However, this assumption does not work if you are calling calculateShoppingCart to create an order, quote, layby, waybill or prepayment invoice. In that case, ignore the printAutomaticCoupons field and do not issue any coupons.  
        /// </summary>
        public List<ShoppingCartAutomaticCoupon> PrintAutomaticCoupons { get; set; }
        /// <summary>
        /// List of coupons that had an effect on the given sale (from among all the coupons specified in input parameter couponIdentifiers). If a coupon was effective, it should be redeemed upon sale completion with API call redeemIssuedCoupon. Ineffective coupons should be given back to the customer, to be used at some other occasion.  
        /// </summary>
        [JsonConverter(typeof(CommaSeparatedStringConverter))]
        public List<int> UsedCouponIdentifiers { get; set; }
        /// <summary>
        /// Promotions that were applied to the cart.
        /// </summary>
        public List<ShoppingCartAppliedPromotion> AppliedPromotions { get; set; }
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
    public class ShoppingCartRow
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
    }
    public class ShoppingCartAutomaticCoupon
    {
        /// <summary>
        /// Coupon ID
        /// </summary>
        public int? CouponID { get; set; }
        /// <summary>
        /// Amount of reward points that this coupon "costs" to to the customer. This amount of points IS AUTOMATICALLY subtracted from customer when you call saveIssuedCoupon to create the coupon. (DO NOT call subtractCustomerRewardPoints yourself.)
        /// FYI: some promotions may cost points, too, and you do need to subtract those manually. See field appliedPromotions below.
        /// </summary>
        public float? PrintingCostInRewardPoints { get; set; }
    }
    public class ShoppingCartAppliedPromotion
    {
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
    }

    #endregion

    #region DeleteSalesDocument Settings
    public class DeleteSalesDocumentSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "deleteSalesDocument";

        public int DocumentID { get; set; }
    }
    #endregion
    #region DeleteSalesDocument Settings
    public class DeletePaymentSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "deletePayment";

        public int PaymentID { get; set; }
    }
    #endregion
}
