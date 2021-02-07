using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErplyAPI.Company
{
    #region ErplyUser
    public class ErplyUser
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
        /// Application-specific field for ERPLY's Berlin Pos. Indicates the version number (typically an integer) of the live / production Pos version that is appropriate for this customer — or the version that has specifically been configured for this customer.
        /// This field does not mean that the customer is definitely using Berlin Pos. The customer may be using other Pos products or not using a Pos at all.
        /// Also, API does not currently provide a Pos version number for preproduction / staging / testing.  
        /// </summary>
        public string BerlinPosVersion { get; set; }
        /// <summary>
        /// Application-specific field for ERPLY's Berlin Pos. Indicates the URL from where Pos can load its static assets.
        /// The URL does not include and does not depend on Pos version number. Pos should append version number to the URL, or perform some other transformation if needed.  
        /// </summary>
        public string BerlinPosAssetsURL { get; set; }
        /// <summary>
        /// Application-specific field for ERPLY's Berlin Pos. Indicates the location of the JNLP file for Erply Point Of Sale Integrator (EPSI), which provides support for various Pos hardware.  
        /// </summary>
        public string EpsiURL { get; set; }
        /// <summary>
        /// Application-specific field for Berlin Pos - returned only for Berlin Pos.
        /// List of Cayan (Merchant Warehouse) payment gateway URLs for this particular account. This only specifies the most appropriate service endpoints for the account to use; it does not indicate that the account is actually using Cayan payment integration.
        /// This array may contain 0 or more records. If Cayan support has been disabled in this server, the array will be empty. Otherwise it will contain at least one record.
        /// </summary>
        public List<GatewayURL> CayanGatewayURLs { get; set; }
        /// <summary>
        /// Application-specific field for Berlin Pos - returned only for Berlin Pos.
        /// URLs of gateways to the Avalara tax calculation service. This only specifies the most appropriate service endpoints to use, if needed, and does not indicate that the account is actually using Avalara integration.
        /// This array may contain 0 or more records. If Avalara support has been disabled in this server, the array will be empty. Otherwise it will contain at least one record.
        /// </summary>
        public List<GatewayURL> AvalaraGatewayURLs { get; set; }
        /// <summary>
        /// Application-specific field for Berlin Pos - returned only for Berlin Pos.
        /// URLs of gateways to the Pusher messaging service, for this particular account.
        /// This array may contain 0 or more records. If Pusher support has been disabled in this server, the array will be empty. Otherwise it will contain at least one record.
        /// </summary>
        public List<GatewayURL> PusherAuthenticationURLs { get; set; }
        /// <summary>
        /// Application-specific field for Berlin Pos - returned only for Berlin Pos.
        /// URLs of gateways to the StrikeIron (Informatica) tax rate lookup service, for this particular account.
        /// This array may contain 0 or more records. If StrikeIron support has been disabled in this server, the array will be empty. Otherwise it will contain at least one record.
        /// </summary>
        public List<GatewayURL> StrikeIronGatewayURLs { get; set; }
        /// <summary>
        /// Information about standalone customer registry service.
        /// This array may contain 0 or more records. If account does not use a standalone customer registry (customers are stored in ERPLY as usual), this list will be empty. Otherwise it will contain at least one record.
        /// </summary>
        public List<RegistryURL> CustomerRegistryURLs { get; set; }
        /// <summary>
        /// Information about standalone coupon registry service.
        /// This array may contain 0 or more records. If account does not use a standalone coupon registry (coupons are stored in ERPLY as usual), this list will be empty. Otherwise it will contain at least one record.
        /// </summary>
        public List<RegistryURL> CouponRegistryURLs { get; set; }
        /// <summary>
        /// Information about standalone transaction registry service.
        /// This array may contain 0 or more records. If account does not use a standalone transaction registry (transactions are stored in ERPLY as usual), this list will be empty. Otherwise it will contain at least one record.
        /// </summary>
        public List<RegistryURL> TransactionRegistryURLs { get; set; }
        /// <summary>
        /// Information about the service that provides advertisements to the point-of-sale customer display screen. (This information is meant for Berlin Pos.)
        /// This array may contain 0 or more records. If account has not been configured to use the advertisement manager, this list will be empty. Otherwise it will contain at least one record.
        /// </summary>
        public List<RegistryURL> DisplayAdManagerURLs { get; set; }
        /// <summary>
        /// Provides URLs with downloadable packages for EPSI (Erply point of sale integrator) installation. Provides a record per each operating system with installation link.
        /// </summary>
        public List<DownloadURL> EpsiDownloadURLs { get; set; }
    }
    public class GatewayURL
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
    }
    public class RegistryURL
    {
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
    }
    public class DownloadURL
    {
        [JsonConverter(typeof(StringEnumConverter))]
        public OperatingSystem OperatingSystem { get; set; }
        /// <summary>
        /// Installation link
        /// </summary>
        public string Url { get; set; }
    }
    public enum OperatingSystem
    {
        Windows,
        macOS,
        Linux
    }
    #endregion
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
        /// <summary>
        /// If set to 1, then API will NOT return parameter "identityToken". 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? DoNotGenerateIdentityToken { get; set; }
    }

    #endregion

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

}
