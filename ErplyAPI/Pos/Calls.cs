using System;
using System.Collections.Generic;
using System.Text;

namespace ErplyAPI.Pos
{
    public static class PosCalls
    {
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
        public static POSOpenDay POSOpenDay(this Erply erply, POSOpenDaySettings settings) => erply.MakeRequest<POSOpenDay>(settings);
        /// <summary>
        /// Drop an amount of cash in register.
        /// By convention, a cash drop with an amount of 0 is an indicator of "No Sale", ie. just opening the drawer. So if you want to record drawer openings (and have these printed on the Z Report), send a cash drop event with amount 0.
        /// For cash payouts, use POSCashOUT. To get a list of all cash drops and cash payouts, use getCashIns.
        /// </summary>
        public static POSCashIN POSCashIN(this Erply erply, POSCashINSettings settings) => erply.MakeRequest<POSCashIN>(settings);
        /// <summary>
        /// Pay out an amount of cash from register.
        /// For cash drops, use POSCashIN. To get a list of all cash drops and cash payouts, use getCashIns.
        /// </summary>
        public static POSCashOUT POSCashOUT(this Erply erply, POSCashOUTSettings settings) => erply.MakeRequest<POSCashOUT>(settings);
        /// <summary>
        /// Close the day (or cashier's shift) in POS. The day must be previously opened with POSOpenDay.
        /// To close the day, cashier needs to count the amount of cash at the register, and indicate how much of it will be stored at the register (closedSum) and how much taken away and deposited (bankedSum).
        /// Both the opening and closing (and the amount of cash counted at opening time and closing time) will be recorded on the Z Report.
        /// A log of POS openings and closings can be retrieved with getDayClosings.
        /// To get a report of total payments by type, before closing the day (for reconciliation), see getPointOfSaleDayTotals.
        /// </summary>
        public static POSCloseDay POSCloseDay(this Erply erply, POSCloseDaySettings settings) => erply.MakeRequest<POSCloseDay>(settings);
    }
}
