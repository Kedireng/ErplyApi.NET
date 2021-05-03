using ErplyAPI.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace ErplyAPI.Other
{
    #region SaveAppliance Settings

    public class SaveApplianceSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveAppliance";

        [ErplyConverter(typeof(ErplyConverter))]
        public Appliance Appliance { get; set; }
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
        [JsonProperty("applianceName")]
        public string Name { get; set; }
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
        /// Additional attributes.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }

    #endregion

    #region GetAssignmentsSettings Settings

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
    #region DeleteAssignmentSettings Settings

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
    #region SaveAssignmentSettings Settings

    public class SaveAssignmentSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveAssignment";

        /// <summary>
        /// Contact person ID. 
        /// </summary>
        public int? ContactID { get; set; }

        [ErplyConverter(typeof(ErplyConverter))]
        public Assignment Assignment { get; set; }
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
        [JsonProperty("createdUnixTime")]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Timestamp (date and time) of when the appliance/vehicle was brought in for repair.  
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        [JsonProperty("receivedUnixTime")]
        public DateTime? ReceivedDate { get; set; }
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
        [ErplyConverter(typeof(ListConverter))]
        public List<CustomerComment> CustomerComments { get; set; }
        [ErplyConverter(typeof(ListConverter))]
        public List<AssignmentRow> AssignmentRows { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? LastModified { get; set; }
        /// <summary>
        /// Additional attributes.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }
    public class AssignmentRow
    {
        /// <summary>
        /// ID of the product. Either productID or serviceID can be set, but not both at the same time. 
        /// </summary>
        public int? ProductID { get; set; }
        /// <summary>
        /// ID of the service. 
        /// </summary>
        public int? ServiceID { get; set; }
        /// <summary>
        /// name of the item (use only if you want to override the default product/service name) 
        /// </summary>
        public string ItemName { get; set; }
        public float? Amount { get; set; }
        public float? Price { get; set; }
        public float? Discount { get; set; }
        public int? FirstEmployeeID { get; set; }
        public int? SecondEmployeeID { get; set; }
        public int? ThirdEmployeeID { get; set; }
        public int? FirstEmployeeTime { get; set; }
        public int? SecondEmployeeTime { get; set; }
        public int? ThirdEmployeeTime { get; set; }
    }
    public class CustomerComment
    {
        [ErplyProperty("customerComment")]
        public string Comment { get; set; }
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
        /// ERPLY makes a distiction between 1) companies who are suppliers in their own right, and 2) persons who are marked as contact persons of some other supplier. Option "SUPPLIERS" returns only the first ones, "CONTACTS" returns only the second ones and "ALL" returns both. 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public SupplierMode Mode { get; set; }
        /// <summary>
        /// Retrieve only items that have been added or modified since the specified timestamp. Use it to keep a local database in sync with ERPLY. 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? ChangedSince { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderBy OrderBy { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderByDirection OrderByDir { get; set; }
        /// <summary>
        /// Number of records API should return. By default 20, at most 100. 
        /// </summary>
        public int? RecordsOnPage { get; set; }
        /// <summary>
        /// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
        /// </summary>
        public int? PageNo { get; set; }
    }
    public enum SupplierMode
    {
        SUPPLIERS,
        CONTACTS,
        ALL
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
        [JsonConverter(typeof(StringEnumConverter))]
        public SupplierType SupplierType { get; set; }
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
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
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
    public enum SupplierType
    {
        COMPANY,
        PERSON
    }
    #endregion
    #region SaveSupplier Settings

    public class SaveSupplierSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveSupplier";
        /// <summary>
        /// If is not set - company type ID will be calculated by analysing company name for type-related parts. 
        /// </summary>
        public int? CompanyTypeID { get; set; }
        
        [ErplyConverter(typeof(ErplyConverter))]
        public Supplier Supplier { get; set; }
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
}
