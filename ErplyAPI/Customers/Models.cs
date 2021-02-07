using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;
using ErplyAPI.Converters;

namespace ErplyAPI.Customers
{
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
        /// Optional colored flag associated with this customer.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ColorStatus? ColorStatus { get; set; }
        /// <summary>
        /// ERPLY makes a distiction between 1) companies and persons who are customers in their own right, 
        /// and 2) persons who are marked as contact persons of some other customer. 
        /// Option "CUSTOMERS" returns only the first ones, 
        /// "CONTACTS" returns only the second ones and 
        /// "ALL" returns both. 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerMode? Mode { get; set; }
        /// <summary>
        /// If set to true, API also returns balance info for selected customers.
        /// If you need to retrieve balances only, without customer information, take a look at API call getCustomerBalances. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetBalanceInfo { get; set; }
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetBalanceWithoutPrepayments { get; set; }
        /// <summary>
        /// If set to true, API returns all default customers used for POS transactions 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetPOSDefaultCustomers { get; set; }
        /// <summary>
        /// Set to true to retrieve all addresses for selected customers. API will return the list in element "addresses", see below.
        /// If you need to retrieve addresses only, without customer information, take a look at API call getAddresses. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? GetAddresses { get; set; }
        /// <summary>
        /// Set to true to retreive contact persons for selected customers. API will return the list in element "contactPersons", see below. 
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
        /// If set to ture, API will not report an accurate total number of search results (the recordsTotal field will return some constant large number). This can be used to make queries more efficient. When using doNotCalculateRecordsTotal, just ask for paged results until API will no longer return any (that indicates you hve reached the end of dataset).  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? DoNotCalculateRecordsTotal { get; set; }
        /// <summary>
        /// Filter customers by birthday — get all customers whose birthday is on or after the specified month and day.
        /// If you only specify birthdayMonthDayFrom and not birthdayMonthDayTo, all birthdays between the specified day and the end of the year are returned.
        /// Combine the two filters to get birthdays in a specific range (eg. birthdays in June or July). Year wrap-around is supported: filter birthdayMonthDayFrom = "12-01", birthdayMonthDayTo = "01-31" returns birthdays in December and January.
        /// Both month and day must be two digits. Use a leading zero if necessary.
        /// </summary>
        [JsonConverter(typeof(ISODateMMddConverter))]
        public DateTime? BirthdayMonthDayFrom { get; set; }
        /// <summary>
        /// Filter customers by birthday — get all customers whose birthday is on or before the specified month and day.
        /// If you only specify birthdayMonthDayTo and not birthdayMonthDayFrom, all birthdays between the beginning of the year and the specified day are returned.
        /// Combine the two filters to get birthdays in a specific range (eg. birthdays in June or July). Year wrap-around is supported: filter birthdayMonthDayFrom = "12-01", birthdayMonthDayTo = "01-31" returns birthdays in December and January.
        /// Both month and day must be two digits. Use a leading zero if necessary.
        /// </summary>
        [JsonConverter(typeof(ISODateMMddConverter))]
        public DateTime? BirthdayMonthDayTo { get; set; }
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
        /// <summary>
        /// 'name', 'customerID', 'group', 'colorStatus', 'lastChanged' or 'none' (no ordering). 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderBy? OrderBy { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("orderByDir")]
        public OrderByDirection? OrderByDirection { get; set; }
        /// <summary>
        /// Number of records API should return. By default 20, at most 100. 
        /// </summary>
        public int? RecordsOnPage { get; set; }
        /// <summary>
        /// API returns at most recordsOnPage items at a time. To retrive the next recordsOnPage items, send a new request with pageNo incremented by one. By default, API returns "page 1". 
        /// </summary>
        public int? PageNo { get; set; }
    }
    public enum ColorStatus
    {
        RED,
        GREEN,
        YELLOW,
        BLUE
    }
    public enum CustomerMode
    {
        CUSTOMERS,
        CONTACTS,
        ALL
    }

    #endregion
    #region Customer

    public class Customer : ErplyItem
    {
        /// <summary>
        /// (deprecated alternative name: id)  
        /// </summary>
        [JsonProperty("customerID")]
        public int? ID { get; set; }
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
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerType? CustomerType { get; set; }
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
        public string OperatorIdentifier { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CustomerGender? Gender { get; set; }
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
        /// Optional colored flag associated with this customer.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ColorStatus? ColorStatus { get; set; }
        /// <summary>
        /// URL to customer's image file.  
        /// </summary>
        [JsonProperty("image")]
        public string ImageURL { get; set; }
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
        public string TwitterID { get; set; }
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
        /// Customer type. 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public EuCustomerType? EuCustomerType { get; set; }
        /// <summary>
        /// Credit limit.  
        /// </summary>
        public int? Credit { get; set; }
        /// <summary>
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
        /// Employee's username  
        /// </summary>
        public string LastModifierUsername { get; set; }
        /// <summary>
        /// Indicates that for this customer, shipments should be (and may be) accompanied by a Waybill. At the end of the month, a summary Invoice can be issued for all the month's shipments and customer will pay then for all the shipments at once. (In the Sales module, there is a command "Create invoice from selected waybills"). If a customer does not have this flag, you should issue Invoice-Waybills instead, and the customer must pay for each shipment separately.
        /// Field appears only if conf parameter enable_waybill_customers is set to true.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? ShipGoodsWithWaybills { get; set; }
        /// <summary>
        /// All customer's postal addresses. To retrieve this element, set input parameter getAddresses to true.
        /// </summary>
        public List<CustomerAddress> Addresses { get; set; }
        /// <summary>
        /// All customer's contact persons. To retrieve this element, set input parameter getContactPersons to 1.
        /// </summary>
        public List<CustomerContactPerson> ContactPersons { get; set; }
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
        /// <summary>
        /// All customer's associations. To retrieve this element, set input parameter getAssociationsAndProfessionals to 1.
        /// </summary>
        public List<CustomerAssociation> Associations { get; set; }
        /// <summary>
        /// All customer's professionals. To retrieve this element, set input parameter getAssociationsAndProfessionals to 1.
        /// </summary>
        public List<CustomerProfessional> Professionals { get; set; }
        /// <summary>
        /// Additional attributes.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
        /// <summary>
        /// Additional attributes — longer strings. Each item looks like this:
        /// Field name Type Description
        /// attributeName String Attribute name
        /// attributeValue String Attribute value
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<LongAttribute> LongAttributes { get; set; }
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
        [JsonProperty("username")]
        private string username { get
            {
                return WebshopUsername;
            }
        }
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
        /// <summary>
        /// Use to indicate that invoices to this customer must be addressed by default to another company. 
        /// </summary>
        public int? InvoicePayerID { get; set; }
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

        /// <summary>
        /// For companies only.  
        /// </summary>
        public string CompanyName2 { get; set; }
        [JsonConverter(typeof(Base64Converter))]
        [JsonProperty("imageContent")]
        public System.Drawing.Image Image { get; set; }
        [JsonConverter(typeof(ImageMimeTypeConverter))]
        public ImageMimeType? ImageMimeType { get; set; }
        [JsonProperty("password")]
        public string WebshopPassword { get; set; }
    }
    public enum CustomerType
    {
        COMPANY,
        PERSON
    }
    public enum EuCustomerType
    {
        DOMESTIC,
        EU,
        OUTSIDE_EU
    }
    public enum ImageMimeType
    {
        GIF,
        JPEG
    }
    public enum CustomerGender
    {
        MALE,
        FEMALE
    }
    public class CustomerAddress
    {
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
    }
    public class CustomerContactPerson
    {
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
        public string TwitterID { get; set; }
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
    }
    public class CustomerAssociation
    {
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
    }
    public class CustomerProfessional
    {
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
    }

    #endregion
    #region SaveCustomer Settings
    public class SaveCustomerSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveCustomer";
        [ErplyConverter(typeof(ErplyConverter))]
        public Customer Customer { get; set; }
    }
    #endregion
    #region DeleteCustomer Settings
    public class DeleteCustomerSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "deleteCustomer";
        public int CustomerID { get; set; }
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
        /// <summary>
        /// 'ADDRESSID'
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public OrderBy OrderBy { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("orderByDir")]
        public OrderByDirection OrderByDirection { get; set; }
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
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? LastModified { get; set; }
        /// <summary>
        /// Employee's username  
        /// </summary>
        public string LastModifierUsername { get; set; }
        /// <summary>
        /// ID of the employee  
        /// </summary>
        public int? LastModifierEmployeeID { get; set; }
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
    #region SaveAddress Settings
    public class SaveAddressSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveAddress";

        [ErplyConverter(typeof(ErplyConverter))]
        public Address Address { get; set; }
    }
    #endregion
    #region DeleteAddress Settings
    public class DeleteAddressSettings : ErplyCall
    {
        public string AddressID { get; set; }
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
    #region SaveCustomerGroup Settings
    public class SaveCustomerGroupSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "saveCustomerGroups";

        [ErplyConverter(typeof(ErplyConverter))]
        public CustomerGroup CustomerGroup { get; set; }
    }
    #endregion

    #region GetAddressTypes Settings
    public class GetAddressTypesSettings : ErplyCall
    {
        /// <summary>
        /// Retrieve item names in a specific language. If omitted, API will return item names in the default language of your ERPLY account.
        /// </summary>
        [JsonProperty("lang")]
        public Language Language { get; set; }
    }
    #endregion
    #region AddressType

    public class AddressType : ErplyCall
    {

        public int? Id { get; set; }
        public string Name { get; set; }
        /// <summary>
        /// Indicates whether this is a type of actively used addresses, or a type of archived/old addresses. Address which has a type where activelyUsed=0 cannot be used as a customer's shipping address on invoice.  
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? ActivelyUsed { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? LastModified { get; set; }
    }

    #endregion

    #region GetDefaultCustomer Settings
    public class GetDefaultCustomerSettings : ErplyCall
    {
        /// <summary>
        /// The default customer can be different for each location and register. Specify pointOfSaleID to get the correct default customer for this specific register. 
        /// </summary>
        public int PointOfSaleID { get; set; }
    }
    #endregion
    #region DefaultCustomer

    public class DefaultCustomer : ErplyCall
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

    #region VerifyCustomerUser Settings
    public class VerifyCustomerUserSettings : ErplyCall
    {
        public string Username { get; set; }
        public string Password { get; set; }    
    }
    #endregion
    #region CustomerUser

    public class CustomerUser : ErplyCall
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
}
