namespace ErplyAPI.Company
{
    public static class Calls
    {
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
        public static ErplyUser VerifyUser(this Erply erply, VerifyUserSettings settings) => erply.MakeRequest<ErplyUser>(settings);
    }
}
