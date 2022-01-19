using ErplyAPI.Converters;
using ErplyAPI.Sales;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace ErplyAPI.Inventory
{
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
        public int? StocktakingID { get; set; }
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
        [ErplyConverter(typeof(ListConverter))]
        public List<InventoryActivityRow> Rows { get; set; }
    }
    public class InventoryActivityRow
    {
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
    #region SaveInventoryRegistration Settings

    public class SaveInventoryRegistrationSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveInventoryRegistration";

        [ErplyConverter(typeof(ErplyConverter))]
        public InventoryRegistration InventoryRegistration { get; set; }
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
        [JsonConverter(typeof(StringEnumConverter))]
        public InventoryTransferType Type { get; set; }
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
    public enum InventoryTransferType
    {
        TRANSFER,
        TRANSFER_ORDER
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
        [JsonConverter(typeof(StringEnumConverter))]
        /// TRANSFER_ORDER is an "Inventory Transfer Order", or a request for transfering. 
        /// In ERPLY backend, it is possible to see Inventory Transfer Orders and turn these into Inventory Transfers. 
        public InventoryTransferType? Type { get; set; }
        /// <summary>
        /// Source document ID.  
        /// </summary>
        public int? InventoryTransferOrderID { get; set; }
        public int? FollowupInventoryTransferID { get; set; }
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Inventory transaction date.
        /// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
        /// Inventory Reports and COGS reports are based on the inventory transaction date.  
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? InventoryTransactionDate { get; set; }
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
        [ErplyConverter(typeof(ListConverter))]
        public List<InventoryActivityRow> Rows { get; set; }
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }

    #endregion
    #region SaveInventoryTransfer Settings

    public class SaveInventoryTransferSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveInventoryTransfer";

        [ErplyConverter(typeof(ErplyConverter))]
        public InventoryTransfer InventoryTransfer { get; set; }
    }

    #endregion

    #region SaveInventoryWriteOff Settings

    public class SaveInventoryWriteOffSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveInventoryWriteOff";

        [ErplyConverter(typeof(ErplyConverter))]
        public InventoryWriteOff InventoryWriteOff { get; set; }
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
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Inventory transaction date.
        /// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
        /// Inventory Reports and COGS reports are based on the inventory transaction date.  
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime? InventoryTransactionDate { get; set; }
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
        [ErplyConverter(typeof(ListConverter))]
        public List<InventoryActivityRow> Rows { get; set; }
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
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetCost { get; set; }
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
        /// PRCORDER, PRCINVOICE, CASHPRCINVOICE, PRCRETURN
        /// By default: PRCINVOICE 
        /// </summary>
        public PurchaseDocumentType? Type { get; set; }
        /// <summary>
        /// eg. 2010-01-29
        /// If omitted, date of request will be used 
        /// </summary>
        [ErplyConverter(typeof(ISODateConverter))]
        public DateTime? Date { get; set; }
        /// <summary>
        /// eg. 14:59:00
        /// If omitted, time of submission will be used 
        /// </summary>
        public TimeSpan Time { get; set; }
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
        /// Transaction types can be configured in Settings → Purchase transactions (Intrastat) 
        /// </summary>
        public int? TransactionTypeID { get; set; }
        /// <summary>
        /// Transport types can be configured in Settings → Transportation types (Intrastat) 
        /// </summary>
        public int? TransportTypeID { get; set; }
        /// <summary>
        /// Delivery terms can be configured in Settings → Incoterms 
        /// </summary>
        public int? DeliveryTermsID { get; set; }
        public string DeliveryTermsLocation { get; set; }
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
        [ErplyConverter(typeof(ListConverter))]
        public List<DocumentRow> Rows { get; set; }
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }
    public enum PurchaseDocumentType
    {
        PRCORDER,
        PRCINVOICE,
        CASHPRCINVOICE,
        PRCRETURN,
        PRCWAYBILL,
        PRCINVOICEONLY
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
        /// <summary>
        /// The possible statuses are:
        /// PENDING Document not confirmed.
        /// PARTIALLY_RECEIVED Purchase order (PRCORDER) only. Document has been confirmed and its status is "partially received". This status can be set manually, but typically this means that the PO has been associated with a purchase invoice, or purchase invoices, but not all ordered items have been received yet.
        /// RECEIVED Purchase order (PRCORDER) only. Document is confirmed and its status is "received".
        /// READY Any other confirmed purchase document (for example a purchase invoice or a purchase return) — or a confirmed purchase order that has not been fulfilled yet.
        /// </summary>
        public string Status { get; set; }
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
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime Date { get; set; }
        /// <summary>
        /// Inventory transaction date.
        /// This is the date on which the document was confirmed and when the items on this document were added into inventory, or removed from inventory. While "document date" can be edited by users at any time, "inventory transaction date" is always set by ERPLY and cannot be changed.
        /// Inventory Reports and COGS reports are based on the inventory transaction date.  
        /// </summary>
        [JsonConverter(typeof(ISODateConverter))]
        public DateTime InventoryTransactionDate { get; set; }
        /// <summary>
        /// eg. 14:59:00  
        /// </summary>
        [JsonConverter(typeof(ISOTimeHHmmssConverter))]
        public TimeSpan Time { get; set; }
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
        /// List of VAT (tax) rates and purchase document net totals for each rate. Each list element contains the following fields:
        /// Field name Type Description
        /// vatrateID Integer Tax rate ID, see getVatRates
        /// total Decimal Net total
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<NetTotalsByTaxRate> NetTotalsByTaxRate { get; set; }
        /// <summary>
        /// List of VAT (tax) rates and total VAT (tax) amounts for each rate. Each list element contains the following fields:
        /// Field name Type Description
        /// vatrateID Integer Tax rate ID, see getVatRates
        /// total Decimal Total VAT / tax
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<VatTotalsByTaxRate> VatTotalsByTaxRate { get; set; }
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
        /// <summary>
        /// Purchase document rows. Rows are returned only in specific cases (if you searched purchase document by ID or number, or if result set contained just one document, or if you specified getRowsForAllInvoices = 1.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<DocumentRow> Rows { get; set; }
        /// <summary>
        /// Additional attributes for the document. Each array element has the following fields:
        /// Field name Type Description
        /// attributeName String Attribute name
        /// attributeType String Attribute type
        /// attributeValue String Value of the attribute
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }

    public class NetTotalsByTaxRate
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

    public class VatTotalsByTaxRate
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
        /// <summary>
        /// Id of edited stocktaking act. 
        /// </summary>
        public int? StocktakingID { get; set; }
        /// <summary>
        /// Id of a warehouse, required for new stocktaking act creation. Cannot be updated or changed on existing stocktaking act. 
        /// </summary>
        public int? WarehouseID { get; set; }
        /// <summary>
        /// 0 or 1, by default 0.
        /// Always create the stocktaking initially in unconfirmed state (you may just omit this flag). Only when it has been finalized and all counts entered and double-checked, confirm the stocktake by re-saving it with flag confirmed = 1. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? Confirmed { get; set; }
        /// <summary>
        /// 0 or 1, by default 0. Only for new stocktaking acts, cannot be updated.
        /// Whether the stocktaking sheet should be pre-populated with a list of products that you have in stock, and their quantities at the current moment. Some fields are used to specify set of added products more exactly.
        /// You are STRONGLY recommended to set this flag to 1. If you do not pre-populate the sheet, products will be added to the list as you count them — but then the stocktaking won't catch items that have an inventory quantity in ERPLY, but which are no longer to be found in the warehouse, and you woun't be able to write them off. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? RecordCurrentQuantities { get; set; }
        /// <summary>
        /// Only for new stocktaking acts, cannot be updated. This field only works if you set recordCurrentQuantities = 1. Specifies the products to be included. Possible values:
        /// ALL - all products
        /// POSITIVE_STOCK - products in stock
        /// NEGATIVE_STOCK - products with negative stock
        /// NON_ZERO_STOCK - products with non-zero amount in stock
        /// If omitted, 'NON_ZERO_STOCK' will be selected as default. 
        /// </summary>
        public string IncludeProducts { get; set; }
        /// <summary>
        /// Only for new stocktaking acts, cannot be updated. Product group (and it's subgropus) used for new stocktaking act, used as a filter for recordCurrentQuantities = 1 and saved in stocktaking act information. 
        /// </summary>
        public int? ProductGroupID { get; set; }
        /// <summary>
        /// Only for new stocktaking acts, cannot be updated. Product category (and it's subcategories) used for new stocktaking act, used as a filter for recordCurrentQuantities = 1 and saved in stocktaking act information. 
        /// </summary>
        public int? ProductCategoryID { get; set; }
        /// <summary>
        /// Only for new stocktaking acts, cannot be updated. Brand used for new stocktaking act, used as a filter for recordCurrentQuantities = 1 and saved in stocktaking act information. 
        /// </summary>
        public int? BrandID { get; set; }
        /// <summary>
        /// Only for new stocktaking acts, cannot be updated. Supplier used for new stocktaking act, used as a filter for recordCurrentQuantities = 1 and saved in stocktaking act information. 
        /// </summary>
        public int? SupplierID { get; set; }
        /// <summary>
        /// 0 or 1, by default 0. Only for new stocktaking acts, cannot be updated.
        /// Set it to 1 if reserved items (items on layby) are physically located in another place, and won't be counted during stocktaking. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? ExcludeReservations { get; set; }
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
        /// An identifier referring to the user who created this stocktaking. This is NOT actually the user's name; it's just a string, at most 16 characters long. However, typically it matches the first 16 characters of the user's name.  
        /// </summary>
        public string AddedByUserName { get; set; }
        /// <summary>
        /// Last modification time.  
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? LastModified { get; set; }
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
        [ErplyConverter(typeof(ListConverter))]
        public List<StocktakingReading> Readings { get; set; }
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
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }

    #endregion
}