using ErplyAPI.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace ErplyAPI.Pos
{
    #region POSOpenDay Settings

    public class POSOpenDaySettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "POSOpenDay";
        /// <summary>
        /// Point of sale ID 
        /// </summary>
        public int? PointOfSaleID { get; set; }
        /// <summary>
        /// Employee opening the day. If omitted, Erply assumes day was opened by the user who sent the API call. 
        /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
        /// Total amount of cash in register at opening time 
        /// </summary>
        public float? OpenedSum { get; set; }
        /// <summary>
        /// Opening timestamp.
        /// NB! If the record already exists (if there is a day opening at the same register, with the same timestamp), InventoryAPI just updates it. 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? OpenedUnixTime { get; set; }
        /// <summary>
        /// Check feature, if set to 1 no any changes will be applied, used to check if the day is opened. If set to 1 parameters "openedUnixTime" and "openedSum" are not required, and will be even ignored. 
        /// </summary>
        [JsonConverter(typeof(BoolConverter))]
        public bool? QueryOpenDay { get; set; }
        /// <summary>
        /// Specify the currency in which you want to open the day in the register.
        /// Note: by default, this field should not be used. In a default configuration, ERPLY allows to count the cash in the register only in the default currency. The cashier should just set aside any cash received in foreign currencies, and remove it from the register at the end of the day. From back office, it is possible to manually print a Z Report that lists transactions made in a different currency, but the counted amount cannot be recorded in POS, neither when opening nor when closing the day.
        /// Therefore, in the default setup, it is not possible to use the "currencyCode" field. API will return error code 1028 if you attempt to set it.
        /// However, customer support can enable an extra module, "POS multicurrency". With this extra module, it becomes possible to count other currencies and record the counts.
        /// In that configuration, a separate "POSOpenDay" call must be sent for each currency. If the shop accepts EUR, USD and JPY, three "POSOpenDay" calls must be made in the morning and three corresponding "POSCloseDay" calls in the evening, to store the end-of-day counts.
        /// At the end of the day, it is possible to print three Z Reports, one for each currency. Each report will list the transactions, amount of cash in the beginning and at the end of the day, and overage/shortage.
        /// Accepted value: for example "EUR" or "USD". The currency must be defined on your ERPLY account, in the "Currencies" module.
        /// </summary>
        public string CurrencyCode { get; set; }
    }

    #endregion
    #region POSOpenDay

    public class POSOpenDay : ErplyItem
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
        public bool? WarningDayAlreadyOpen { get; set; }
    }

    #endregion

    #region POSCashIN Settings

    public class POSCashINSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "POSCashIN";
        /// <summary>
        /// Cash drop transaction ID.
        /// Set this parameter to update an existing Transaction. 
        /// </summary>
        public int? TransactionID { get; set; }
        /// <summary>
        /// Point of sale ID 
        /// </summary>
        public int? PointOfSaleID { get; set; }
        /// <summary>
        /// Employee doing the cash drop. If omitted, Erply assumes cash drop was done by the user who sent the API call. 
        /// </summary>
        public int? EmployeeID { get; set; }
        public float? Sum { get; set; }
        /// <summary>
        /// Currency code: EUR, USD. Currency must be defined in Erply. If omitted, or an unknown currency code is provided, API uses your default currency instead. 
        /// </summary>
        public string CurrencyCode { get; set; }
        public string Comment { get; set; }
        /// <summary>
        /// Time when this cash drop took place. Correct timestamps are very important for the day end Z Report to be correct. If omitted, InventoryAPI uses current server timestamp. 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        /// <summary>
        /// Additional attributes.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }

    #endregion
    #region POSCashIN

    public class POSCashIN : ErplyItem
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

    #region POSCashOUT Settings

    public class POSCashOUTSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "POSCashOUT";
        /// <summary>
        /// Cash drop transaction ID.
        /// Set this parameter to update an existing Transaction. 
        /// </summary>
        public int? TransactionID { get; set; }
        /// <summary>
        /// Point of sale ID 
        /// </summary>
        public int? PointOfSaleID { get; set; }
        /// <summary>
        /// Employee doing the payout. If omitted, Erply assumes payout was done by the user who sent the API call. 
        /// </summary>
        public int? EmployeeID { get; set; }
        public float? Sum { get; set; }
        /// <summary>
        /// Currency code: EUR, USD. Currency must be defined in Erply. If omitted, or an unknown currency code is provided, API uses your default currency instead. 
        /// </summary>
        public string CurrencyCode { get; set; }
        public string Comment { get; set; }
        /// <summary>
        /// Time when this cash payout took place. Correct timestamps are very important for the day end Z Report to be correct. If omitted, InventoryAPI uses current server timestamp. 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? Added { get; set; }
        /// <summary>
        /// Additional attributes.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }

    #endregion
    #region POSCashOUT

    public class POSCashOUT : ErplyItem
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

    #region POSCloseDay Settings

    public class POSCloseDaySettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "POSCloseDay";
        /// <summary>
        /// Point of sale ID 
        /// </summary>
        public int? PointOfSaleID { get; set; }
        /// <summary>
        /// Employee closing the day. If omitted, Erply assumes day was closed by the user who sent the API call. 
        /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
        /// POS day opening timestamp 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? OpenedUnixTime { get; set; }
        /// <summary>
        /// POS day ID.
        /// NB! You must provide EITHER openedUnixTime or dayID to indicate which day exactly needs to be closed. 
        /// </summary>
        public int? DayID { get; set; }
        /// <summary>
        /// Closing timestamp 
        /// </summary>
        [JsonConverter(typeof(UnixTimestampConverter))]
        public DateTime? ClosedUnixTime { get; set; }
        /// <summary>
        /// Total amount of money left in register 
        /// </summary>
        public float? ClosedSum { get; set; }
        /// <summary>
        /// Total amount of money removed from register and deposited 
        /// </summary>
        public float? BankedSum { get; set; }
        /// <summary>
        /// ID of cash variance reason. See getReasonCodes for various reason codes. 
        /// </summary>
        public int? ReasonID { get; set; }
        /// <summary>
        /// Notes. 
        /// </summary>
        public string Notes { get; set; }
        /// <summary>
        /// Specify the currency for which you want to close the day in the register.
        /// Note: by default, this field should not be used. In a default configuration, ERPLY allows to count the cash in the register only in the default currency. The cashier should just set aside any cash received in foreign currencies, and remove it from the register at the end of the day. From back office, it is possible to manually print a Z Report that lists transactions made in a different currency, but the counted amount cannot be recorded in POS, neither when opening nor when closing the day.
        /// Therefore, in this setup, it is not possible to use the "currencyCode" field. API will return error code 1028 if you attempt to set it.
        /// However, customer support can enable an extra module, "POS multicurrency". With this extra module, it becomes possible to count other currencies as well and record the counts.
        /// In that configuration, a separate "POSOpenDay" call must be sent for each currency. If the shop accepts EUR, USD and JPY, three "POSOpenDay" calls should be made in the morning and three corresponding "POSCloseDay" calls in the evening, to store the end-of-day counts.
        /// At the end of the day, it is possible to print three Z Reports, one for each currency.
        /// Accepted value: for example "EUR" or "USD". The currency must be defined on your ERPLY account, in the "Currencies" module.
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Deprecated. 
        /// </summary>
        public int? FindLastOpenDay { get; set; }
        /// <summary>
        /// Additional attributes.
        /// </summary>
        [ErplyConverter(typeof(ListConverter))]
        public List<Attribute> Attributes { get; set; }
    }

    #endregion
    #region POSCloseDay

    public class POSCloseDay : ErplyItem
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
        public bool? WarningDayNotOpen { get; set; }
        /// <summary>
        /// If the day has already been closed (ie., InventoryAPI finds a record with the same pointOfSaleID and opening time and notices it has already been closed), then day closing sums are updated and InventoryAPI raises this flag. This is just for information.  
        /// </summary>
        public bool? WarningDayAlreadyClosed { get; set; }
    }

    #endregion

    #region SendByEmail Settings

    public class SendByEmailSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "sendByEmail";
        /// <summary>
        /// ID of the document. For invoices, their numeric identifier. In the future, longer identifying strings may be used for printing reports. 
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Document category - SALESDOCUMENT or PURCHASEDOCUMENT. 
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// E-mail address of the receiver. May include several addresses, separated by commas or spaces. 
        /// </summary>
        public string Email { get; set; }
        public string SenderName { get; set; }
        /// <summary>
        /// If unspecified, invoice creator's email address or company's general email address will be used. 
        /// </summary>
        public string SenderEmail { get; set; }
        /// <summary>
        /// If unspecified, default email message text for this particular document type will be used. 
        /// </summary>
        public string Message { get; set; }
    }

    #endregion

    #region SendToPrint Settings

    public class SendToPrintSettings : ErplyCall
    {
        [JsonIgnore]
        public override string CallName { get; set; } = "sendToPrint";
        /// <summary>
        /// ID of the document. For invoices, their numeric identifier. 
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// Document category - SALESDOCUMENT or PURCHASEDOCUMENT. 
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public DocumentCategory? Type { get; set; }
    }

    public enum DocumentCategory
    {
        SALESDOCUMENT,
        PURCHASEDOCUMENT
    }

    #endregion
}
