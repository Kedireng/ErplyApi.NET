using ErplyAPI.Products;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErplyAPI
{
    public class ErplyResponse
    {
        public Status Status { get; set; }
        public JArray Records { get; set; }
        /// <summary>
        /// Requests responses array used in Bulk api call.
        /// </summary>
        public List<ErplyResponse> Requests { get; set; }

        /// <summary>
        /// Checks if response was successful or not.
        /// </summary>
        public void ValidateSuccess()
        {
            if (Status.ResponseStatus == "ok")
                return;

            #region Server erros and misconstructed requests
            if (Status.ErrorCode == 1000) throw new ErplyException(Status, "API is under maintenance, please try again in a couple of minutes.");
            if (Status.ErrorCode == 1001) throw new ErplyException(Status, "Account not found. (It may also mean that input parameter 'clientCode' is missing.)");
            if (Status.ErrorCode == 1002) throw new ErplyException(Status, "Hourly request limit (by default 1000 requests) has been exceeded for this account. Please resume next hour.");
            if (Status.ErrorCode == 1003) throw new ErplyException(Status, "Cannot connect to account database.");
            if (Status.ErrorCode == 1005) throw new ErplyException(Status, "API call name (input parameter 'request') not specified, or unknown API call.");
            if (Status.ErrorCode == 1006) throw new ErplyException(Status, "This API call is not available on this account. (Account needs upgrading, or an extra module needs to be installed.)");
            if (Status.ErrorCode == 1007) throw new ErplyException(Status, "Unknown output format requested; input parameter 'responseType' must be set to either 'JSON' or 'XML'.");
            if (Status.ErrorCode == 1008) throw new ErplyException(Status, "Database is under regular maintenance (please try again in a couple of minutes) or your application is not connecting to the correct API server. Make sure that you are using correct API URL: https://YOURCUSTOMERCODE.erply.com/api/. If your API URL is correct, it might be that your ERPLY account has been recently transferred between hosting environments and your local DNS cache is out of date (domain name YOURCUSTOMERCODE.erply.com is not being resolved to correct web server). Try flushing DNS cache in your computer, server, or application engine.");
            if (Status.ErrorCode == 1009) throw new ErplyException(Status, "This API call requires authentication parameters (a session key, authentication key, or service key), but none were found.");
            #endregion

            #region Invalid input
            if (Status.ErrorCode == 1010) throw new ErplyException(Status, $"Required parameters are missing.('{Status.ErrorField}')");
            if (Status.ErrorCode == 1011) throw new ErplyException(Status, $"Invalid classifier ID, there is no such item.('{Status.ErrorField}')");
            if (Status.ErrorCode == 1012) throw new ErplyException(Status, $"A parameter must have a unique value.('{Status.ErrorField}')");
            if (Status.ErrorCode == 1013) throw new ErplyException(Status, $"Inconsistent parameter set (for example, both product and service IDs specified for an invoice row).");
            if (Status.ErrorCode == 1014) throw new ErplyException(Status, $"Incorrect data type or format.('{Status.ErrorField}')");
            if (Status.ErrorCode == 1015) throw new ErplyException(Status, $"Malformed request (eg. parameters containing invalid characters).");
            if (Status.ErrorCode == 1016) throw new ErplyException(Status, $"Invalid value.('{Status.ErrorField}')");
            if (Status.ErrorCode == 1017) throw new ErplyException(Status, $"Document has been confirmed and its contents and warehouse ID cannot be edited any more.");
            if (Status.ErrorCode == 1018) throw new ErplyException(Status, $"Multiple matches found, all have the same attribute value. No records will be updated.");
            if (Status.ErrorCode == 1019) throw new ErplyException(Status, $"No records found with this attribute value.");
            #endregion

            #region Authentication failures
            if (Status.ErrorCode == 1050) throw new ErplyException(Status, "Username/password missing.");
            if (Status.ErrorCode == 1051) throw new ErplyException(Status, "Login failed.");
            if (Status.ErrorCode == 1052) throw new ErplyException(Status, "User has been temporarily blocked because of repeated unsuccessful login attempts.");
            if (Status.ErrorCode == 1053) throw new ErplyException(Status, "No password has been set for this user, therefore the user cannot be logged in.");
            if (Status.ErrorCode == 1054) throw new ErplyException(Status, "API session has expired. Please call API 'VerifyUser' again (with correct credentials) to receive a new session key.");
            if (Status.ErrorCode == 1055) throw new ErplyException(Status, "Supplied session key is invalid; session not found.");
            if (Status.ErrorCode == 1056) throw new ErplyException(Status, "Supplied session key is too old. User switching is no longer Possible with this session key, please perform a full re-authentication via API 'verifyUser'.");
            if (Status.ErrorCode == 1057) throw new ErplyException(Status, "Your time-limited demo account has expired. Please create a new ERPLY demo account, or sign up for a paid account.");
            if (Status.ErrorCode == 1058) throw new ErplyException(Status, "PIN login is not supported. Provide a user name and password instead, or use the 'switchUser' API call.");
            if (Status.ErrorCode == 1059) throw new ErplyException(Status, "Unable to detect your user group.");
            #endregion

            #region Insufficient user rights
            if (Status.ErrorCode == 1060) throw new ErplyException(Status, "No viewing rights (in this module/for this item).");
            if (Status.ErrorCode == 1061) throw new ErplyException(Status, "No adding rights (in this module).");
            if (Status.ErrorCode == 1062) throw new ErplyException(Status, "No editing rights (in this module/for this item).");
            if (Status.ErrorCode == 1063) throw new ErplyException(Status, "No deleting rights (in this module/for this item).");
            if (Status.ErrorCode == 1064) throw new ErplyException(Status, "User does not have access to this location (store, warehouse).");
            if (Status.ErrorCode == 1065) throw new ErplyException(Status, "This user account does not have API access. (It may be limited to Pos or Erply backend operations only.)");
            if (Status.ErrorCode == 1066) throw new ErplyException(Status, "This user does not have the right to manage specified user group. (Error may occur when attempting to create a new user, or modify an existing one.)");
            if (Status.ErrorCode == 1067) throw new ErplyException(Status, "This account does not belong to a franchise and this API call cannot be used.");
            if (Status.ErrorCode == 1068) throw new ErplyException(Status, "This user cannot yet log in to Erply. A confirmation email has been sent; user needs to click a link in that email to verify their address.");
            #endregion

            #region Miscellaneous errors
            if (Status.ErrorCode == 1020) throw new ErplyException(Status, "Bulk API call contained more than 100 sub-requests (max 100 allowed). The whole request has been ignored.");
            if (Status.ErrorCode == 1021) throw new ErplyException(Status, "Another instance of the same report is currently running. Please wait and try again in a minute. (For long-running reports, API processes incoming requests only one at a time.)");
            if (Status.ErrorCode == 1022) throw new ErplyException(Status, "This item cannot be deleted because there are other records that reference it.");
            if (Status.ErrorCode == 1023) throw new ErplyException(Status, "Request has product rows in wrong order, or some rows are missing. When editing a confirmed Inventory Registration, only prices can be updated (not quantities and product IDs), and the request must include all rows.");
            if (Status.ErrorCode == 1024) throw new ErplyException(Status, "'Master List' functionality has been activated - products cannot be added directly to the product catalog.");
            if (Status.ErrorCode == 1025) throw new ErplyException(Status, "This bin cannot be archived because it has quantities in it.");
            if (Status.ErrorCode == 1026) throw new ErplyException(Status, "An identical record already exists.");
            if (Status.ErrorCode == 1027) throw new ErplyException(Status, "On an existing record, it is not allowed to change the value of this field.");
            if (Status.ErrorCode == 1028) throw new ErplyException(Status, "This input field in this API call cannot be used. (Account needs upgrading, or an extra module needs to be installed.)");
            if (Status.ErrorCode == 1029) throw new ErplyException(Status, "One or more values in a comma-separated list are incorrect.");
            if (Status.ErrorCode == 1040) throw new ErplyException(Status, "Invalid coupon identifier - such coupon has not been issued.");
            if (Status.ErrorCode == 1041) throw new ErplyException(Status, "Invalid coupon identifier - this coupon has already been redeemed.");
            if (Status.ErrorCode == 1042) throw new ErplyException(Status, "Customer does not have enough reward points.");
            if (Status.ErrorCode == 1043) throw new ErplyException(Status, "Employee already has an appointment on that time slot. Please choose a different start and end time for appointment.");
            if (Status.ErrorCode == 1044) throw new ErplyException(Status, "Default length for this service has not been defined in Erply backend - cannot suggest Possible time slots.");
            if (Status.ErrorCode == 1045) throw new ErplyException(Status, "Invalid coupon identifier - this coupon has expired.");
            if (Status.ErrorCode == 1046) throw new ErplyException(Status, "Sales Promotion - The promotion contains multiple conflicting requirements or conditions, please specify only one.");
            if (Status.ErrorCode == 1047) throw new ErplyException(Status, "Sales Promotion - Promotion requirements or conditions not specified.");
            if (Status.ErrorCode == 1048) throw new ErplyException(Status, "Sales Promotion - The promotion contains multiple conflicting awards, please specify only one.");
            if (Status.ErrorCode == 1049) throw new ErplyException(Status, "Sales Promotion - Promotion awards not specified.");
            if (Status.ErrorCode == 1071) throw new ErplyException(Status, "This customer can buy for a full up-front payment only.");
            if (Status.ErrorCode == 1072) throw new ErplyException(Status, "This customer does not earn new reward points.");
            if (Status.ErrorCode == 1073) throw new ErplyException(Status, "It is not Possible to create an invoice from these source documents. All source documents must have the same type and same client (or the same payer).");
            if (Status.ErrorCode == 1074) throw new ErplyException(Status, "Source document cannot be an invoice, invoice-waybill, Pos receipt or a credit invoice.");
            if (Status.ErrorCode == 1075) throw new ErplyException(Status, $"Tax already has more than one component of this type, you must use saveVatRateComponent to add or change tax components. ('{Status.ErrorField}')");
            if (Status.ErrorCode == 1076) throw new ErplyException(Status, "Sales Promotion - Only promotions with type 'manual' can be set to require manager's approval.");
            if (Status.ErrorCode == 1077) throw new ErplyException(Status, "This price list is not associated with this store region.");
            if (Status.ErrorCode == 1078) throw new ErplyException(Status, "The 'amount' field for price list items can be used only if the 'Quantity Price Lists' module has been enabled on your account.");
            if (Status.ErrorCode == 1079) throw new ErplyException(Status, "When editing a price list item, product ID can not be changed.");
            if (Status.ErrorCode == 1080) throw new ErplyException(Status, "Printing service is not running at the moment. (User can turn printing service on from their Erply account).");
            if (Status.ErrorCode == 1081) throw new ErplyException(Status, "Email sending failed.");
            if (Status.ErrorCode == 1082) throw new ErplyException(Status, "Email sending has been incorrectly set up, review settings in ERPLY. (Missing sender's address or empty message content).");
            if (Status.ErrorCode == 1083) throw new ErplyException(Status, "'Master List' functionality has not been fully set up yet, some requirements are missing.");
            if (Status.ErrorCode == 1084) throw new ErplyException(Status, "Configuration parameter 'master_list_unique_field' has been incorrectly set up.");
            if (Status.ErrorCode == 1090) throw new ErplyException(Status, "No file attached.");
            if (Status.ErrorCode == 1091) throw new ErplyException(Status, "Attached file is not encoded with Base64.");
            if (Status.ErrorCode == 1092) throw new ErplyException(Status, "Attached file exceeds allowed size limit.");
            if (Status.ErrorCode == 1100) throw new ErplyException(Status, "New password must contain at least 8 characters.");
            if (Status.ErrorCode == 1101) throw new ErplyException(Status, "New password may only contain Latin letters and digits. (This rule is enforced by configuration parameter 'password_only_alphanumeric_allowed').");
            if (Status.ErrorCode == 1102) throw new ErplyException(Status, "New password must contain at least one small letter, one capital letter and one digit. (This rule is enforced by configuration parameter 'password_alphanumeric_required').");
            if (Status.ErrorCode == 1103) throw new ErplyException(Status, "A configuration setting does not allow the user to change own password more often than once every N days.");
            if (Status.ErrorCode == 1110) throw new ErplyException(Status, "Sales Promotion - Multiple conflicting settings. A promotion must apply to all stores, or specific regions only, or specific location only, or specific store group only.");
            if (Status.ErrorCode == 1111) throw new ErplyException(Status, "Sales Promotion - Fields 'purchasedProductGroupID', 'purchasedProductCategoryID' or 'purchasedProducts' are only allowed together with 'purchasedAmount'.");
            if (Status.ErrorCode == 1112) throw new ErplyException(Status, "Sales Promotion - Multiple conflicting purchase options ('purchasedProductGroupID', 'purchasedProductCategoryID' or 'purchasedProducts') have been specified at the same time.");
            if (Status.ErrorCode == 1113) throw new ErplyException(Status, "Sales Promotion - Fields 'awardedProductGroupID', 'awardedProductCategoryID', 'awardedProducts', 'awardedAmount' are only allowed together with 'sumOFF' or 'percentageOFF'.");
            if (Status.ErrorCode == 1114) throw new ErplyException(Status, "Sales Promotion - Multiple conflicting award options ('awardedProductGroupID', 'awardedProductCategoryID', or 'awardedProducts',) have been specified at the same time.");
            if (Status.ErrorCode == 1115) throw new ErplyException(Status, "Sales Promotion - Fields 'percentageOffExcludedProducts' and 'percentageOffIncludedProducts' are only allowed together with 'percentageOffEntirePurchase'.");
            if (Status.ErrorCode == 1116) throw new ErplyException(Status, "Sales Promotion - Fields 'sumOffExcludedProducts' and 'sumOffIncludedProducts' are only allowed together with 'sumOffEntirePurchase'.");
            if (Status.ErrorCode == 1117) throw new ErplyException(Status, "Sales Promotion - Fields 'priceAtLeast' and 'priceAtMost' are only allowed together with 'purchasedAmount'.");
            if (Status.ErrorCode == 1118) throw new ErplyException(Status, "Sales Promotion - Field 'maximumPointsDiscount' can only be used together with 'rewardPoints' and 'sumOffEntirePurchase'.");
            if (Status.ErrorCode == 1119) throw new ErplyException(Status, "Sales Promotion - Field 'lowestPriceItemIsAwarded' can only be used together with 'sumOFF' or 'percentageOFF'.");
            if (Status.ErrorCode == 1120) throw new ErplyException(Status, "This account uses customer registry microservice. The list of customers, their groups and addresses is stored outside of ERPLY. Queries and updates must be sent directly to the service, using the service's own API. See the output of verifyUser for a service endpoint and authentication token.");
            if (Status.ErrorCode == 1121) throw new ErplyException(Status, "The type of a confirmed document cannot be changed.");
            if (Status.ErrorCode == 1122) throw new ErplyException(Status, "Sales Promotion - Field 'specialPrice' can only be used together with 'purchasedAmount'.");
            if (Status.ErrorCode == 1123) throw new ErplyException(Status, "Sales Promotion - Fields 'percentageOffMatchingItems' and 'sumOffMatchingItems' are only allowed together with 'purchasedAmount'.");
            if (Status.ErrorCode == 1124) throw new ErplyException(Status, "Sales Document - For creating recurring billing invoices over API, the data model of your account needs an update. Please contact customer support.");
            if (Status.ErrorCode == 1126) throw new ErplyException(Status, "This account uses customer registry microservice. This input field in this API call cannot be used; this is a limitation of the integration.");
            if (Status.ErrorCode == 1127) throw new ErplyException(Status, "This account uses customer registry microservice. This input field in this API call is not allowed to have that value; this is a limitation of the integration.");
            if (Status.ErrorCode == 1128) throw new ErplyException(Status, "This field can only be used on Greek accounts.");
            if (Status.ErrorCode == 1129) throw new ErplyException(Status, "Sales Promotion - Flag 'excludeDiscountedFromPercentageOffEntirePurchase' can only be set to 1 if you have specified 'percentageOffEntirePurchase'.");
            if (Status.ErrorCode == 1130) throw new ErplyException(Status, "Sales Document - One or more billing readings on that row are not associated with the specified billing statement or are already associated with another invoice.");
            if (Status.ErrorCode == 1131) throw new ErplyException(Status, "Sales Promotion - The purPose of the Reason Code must be 'PROMOTION'.");
            if (Status.ErrorCode == 1132) throw new ErplyException(Status, "Sales Promotion - Field 'purchasedProductSubsidies' can only be used together with 'purchasedProducts' and ('percentageOffMatchingItems' or 'sumOffMatchingItems').");
            if (Status.ErrorCode == 1133) throw new ErplyException(Status, "Sales Promotion - Field 'purchasedProductSubsidies' must contain exactly the same number of elements as field 'purchasedProducts'.");
            if (Status.ErrorCode == 1134) throw new ErplyException(Status, "Sales Promotion - Field 'awardedProductSubsidies' must contain exactly the same number of elements as field 'awardedProducts'.");
            if (Status.ErrorCode == 1136) throw new ErplyException(Status, "This location does not have an assortment.");
            if (Status.ErrorCode == 1137) throw new ErplyException(Status, "This location's assortment contains more than 10,000 products; API is not going to return the list.");
            if (Status.ErrorCode == 1138) throw new ErplyException(Status, "The number of billing statement IDs must not exceed 500.");
            if (Status.ErrorCode == 1139) throw new ErplyException(Status, "Sales Promotion - Field 'specialUnitPrice' can only be used together with 'purchasedAmount'.");
            if (Status.ErrorCode == 1140) throw new ErplyException(Status, "Sales Promotion - Field 'maxItemsWithSpecialUnitPrice' must be equal to or larger than 'purchasedAmount'.");
            if (Status.ErrorCode == 1141) throw new ErplyException(Status, "Sales Promotion - Field 'purchasedAmount' can only be used together with 'purchasedProductGroupID', 'purchasedProductCategoryID', or 'purchasedProducts'.");
            if (Status.ErrorCode == 1142) throw new ErplyException(Status, "This account uses coupon registry microservice and this API call is not supported.");
            if (Status.ErrorCode == 1143) throw new ErplyException(Status, "This account uses coupon registry microservice. This input field in this API call is not allowed to have that value; this is a limitation of the integration.");
            if (Status.ErrorCode == 1144) throw new ErplyException(Status, "Sales Promotion - Field 'redemptionLimit' is not allowed for promotions that give % off entire invoice, require reward points or apply to an unlimited number of items.");
            if (Status.ErrorCode == 1145) throw new ErplyException(Status, "Sales Promotion - Field 'redemptionLimit' can only be used together with 'maxItemsWithSpecialUnitPrice' (for special unit price promotions).");
            if (Status.ErrorCode == 1146) throw new ErplyException(Status, "You do not have an employee record. Please ask a manager to create an employee record for you.");
            if (Status.ErrorCode == 1147) throw new ErplyException(Status, "You have already confirmed your compliance with the General Data Protection Regulation.");
            if (Status.ErrorCode == 1148) throw new ErplyException(Status, "You do not have access to customer data. Please contact your manager to receive an introduction to the General Data Protection Regulation, to get instructions about proper data protection procedures and to confirm that you will comply with them.");
            if (Status.ErrorCode == 1149) throw new ErplyException(Status, "Your account country is a non-EU country and the GDPR customer data processing log is not available. (Should you need the logging feature regardless, please let us know.)");
            if (Status.ErrorCode == 1150) throw new ErplyException(Status, "If you attempt to add a integration-specific field to a payment, you also need to set input parameter 'paymentServiceProvider'. See the documentation of savePayment to find out what should be the appropriate input value for 'paymentServiceProvider'.");
            if (Status.ErrorCode == 1151) throw new ErplyException(Status, "This product cannot be added to store price list. It already occurs in a Flyer or Manager's Special price list that is active during the same time period.");
            if (Status.ErrorCode == 1152) throw new ErplyException(Status, "This store price list cannot be updated. After the update, the price list would overlap with one or more Flyer or Manager's Special price lists that contain the same products.");
            if (Status.ErrorCode == 1153) throw new ErplyException(Status, "Inventory Registration - The purPose of the Reason Code must be 'REGISTRATION'.");
            if (Status.ErrorCode == 1154) throw new ErplyException(Status, "This API call does not support the old inventory module. Please contact customer support to upgrade your inventory.");
            if (Status.ErrorCode == 1155) throw new ErplyException(Status, "Creating a new account is temporarily not Possible. Please try again in 5 minutes.");
            if (Status.ErrorCode == 1156) throw new ErplyException(Status, $"Value must not be longer than 100 characters. ('{Status.ErrorField}')");
            if (Status.ErrorCode == 1157) throw new ErplyException(Status, "This sub-request in a bulk call cannot be executed. It refers to the special value 'CURRENT_INVOICE_ID', but the preceding 'saveSalesDocument' call returned an error code and no document was created.");
            if (Status.ErrorCode == 1158) throw new ErplyException(Status, "This sub-request in a bulk call cannot be executed. It refers to the special value 'CURRENT_INVOICE_ID', but the preceding 'saveSalesDocument' call was flagged as a duplicate and no document was created.");
            if (Status.ErrorCode == 1159) throw new ErplyException(Status, "This field can only be used on EU accounts.");
            if (Status.ErrorCode == 1160) throw new ErplyException(Status, "The 'giftCardVatRateID' field for a payment can be used only if the payment's type is 'GIFTCARD'.");
            if (Status.ErrorCode == 1161) throw new ErplyException(Status, "This request is specific to Pos applications, and cannot be called by other API clients.");
            #endregion

            throw new Exception();
        }
    }

    public class Status
    {
        /// <summary>
        /// Request name, used in Bulk API Calls
        /// </summary>
        public string RequestName { get; set; }
        /// <summary>
        /// Request ID, used in Bulk API Calls
        /// </summary>
        public int? RequestID { get; set; }
        public string Request { get; set; }
        public int? RequestUnixTime { get; set; }
        public string ResponseStatus { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorField { get; set; }
        public float? GenerationTime { get; set; }
        public int? RecordsTotal { get; set; }
        public int? RecordsInResponse { get; set; }
    }
}
