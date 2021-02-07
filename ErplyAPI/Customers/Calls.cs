using System.Collections.Generic;

namespace ErplyAPI.Customers
{
    public static class CustomersCalls
    {
        /// <summary>
        /// Retrieve your customer database.
        /// In addition to customer card fields, you can have API to return:
        /// </summary>
        public static List<Customer> GetCustomers(this Erply erply, GetCustomersSettings settings) => erply.MakeRequest<List<Customer>>(settings);
        /// <summary>
        /// Retrieve customer, supplier, or company addresses.
        /// Important: if you operate in the European Union, the General Data Protection Regulation (GDPR) requires all processing done with customers' personal information to be logged. If you retrieve customer addresses, you are responsible for logging everything you do with the data. If it is not possible to keep the logs in the system that processes the data, you may consider writing the log entries into Erply, with the logProcessingOfCustomerData call.
        /// </summary>
        public static List<Address> GetAddresses(this Erply erply, GetAddressesSettings settings) => erply.MakeRequest<List<Address>>(settings);
        /// <summary>
        /// Get customer groups. In ERPLY, customer groups are hierarchical; a group can contain sub-groups.
        /// </summary>
        public static List<CustomerGroup> GetCustomerGroups(this Erply erply, GetCustomerGroupsSettings settings) => erply.MakeRequest<List<CustomerGroup>>(settings);
        /// <summary>
        /// Retrieve address types.
        /// </summary>
        public static List<AddressType> GetAddressTypes(this Erply erply, GetAddressTypesSettings settings) => erply.MakeRequest<List<AddressType>>(settings);
        /// <summary>
        /// Get the ID of default customer used for POS transactions (typically, "POS Customer", "Walk-in" or similar).
        /// If such a customer is not defined, API returns no records.
        /// </summary>
        public static DefaultCustomer GetDefaultCustomer(this Erply erply, GetDefaultCustomerSettings settings) => erply.MakeRequest<DefaultCustomer>(settings);
        /// <summary>
        /// Create a new customer or update customer information. Function can be used for manipulating both companies and persons. Some parameters only apply to one or another.
        /// If the created or updated customer is a natural person and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the change in the customer information processing log.
        /// </summary>
        /// <returns>Returns created/updated customer ID</returns>
        public static int SaveCustomer(this Erply erply, SaveCustomerSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Create or update customer's or supplier's address.
        /// If the created or updated address belongs to a customer (to a natural person), and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the change in the customer information processing log.
        /// </summary>
        public static int SaveAddress(this Erply erply, SaveAddressSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Create or update a customer group.
        /// </summary>
        public static int SaveCustomerGroup(this Erply erply, SaveCustomerGroupSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Validate customer's web shop user name and password.
        /// This API call is for building a web shop that has a log-in (members-only) area. In Erply Customer module, you can assign a user name and password for each of your customers. (These user names / passwords DO NOT grant the customer any access into your ERPLY account, and cannot be used for that purpose. They can only be used in your web shop.)
        /// Use API verifyCustomerUser to validate the user name and password and retrieve the customer record that these credentials belong to. Calling This API call will not create any "session" or make the customer somehow logged into API; it just serves a verification purpose.
        /// Instead, if you want to learn how to generally authenticate yourself when connecting to Erply API — to be able to issue any API calls at all — see verifyUser.
        /// </summary>
        public static CustomerUser VerifyCustomerUser(this Erply erply, VerifyCustomerUserSettings settings) => erply.MakeRequest<CustomerUser>(settings);
        /// <summary>
        /// Delete a customer.
        /// If the deleted customer is a natural person and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the deletion in the customer information processing log.
        /// </summary>
        public static void DeleteCustomer(this Erply erply, DeleteCustomerSettings settings) => erply.MakeRequest(settings);
        /// <summary>
        /// Delete a supplier / customer / company address.
        /// If the deleted address belongs to a customer (to a natural person) and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the deletion in the customer information processing log.
        /// </summary>
        public static void DeleteAddress(this Erply erply, DeleteAddressSettings settings) => erply.MakeRequest(settings);
    }
}
