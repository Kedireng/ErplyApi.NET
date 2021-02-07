using System.Collections.Generic;

namespace ErplyAPI.Other
{
    public static class OtherCalls
    {
        /// <summary>
        /// Retrieve appliances or vehicles.
        /// This API call is related to the Assignments module. Depending on configuration, your Assignments module may be set up either for appliance repair (in which case it returns the list of appliances), or vehicle/car repair (it returns the list of vehicles). Vehicles have a few extra fields, compared to appliances.
        /// This API call returns error 1006 if assignment module is not enabled on your account.
        /// Important: if you operate in the European Union, the General Data Protection Regulation (GDPR) requires all processing done with customers' personal information to be logged. If the retrieved dataset contains any information that could be considered personally identifiable data of natural persons (vehicle registration numbers and VINs, for example), you are responsible for logging everything you do with the data. If it is not possible to keep the logs in the system that processes the data, you may consider writing the log entries into Erply, with the logProcessingOfCustomerData call.
        /// </summary>
        public static List<Appliance> GetAppliances(this Erply erply, GetAppliancesSettings settings) => erply.MakeRequest<List<Appliance>>(settings);
        /// <summary>
        /// Delete an appliance.
        /// This API call returns error 1006 if assignment module is not enabled on this account.
        /// </summary>
        public static void DeleteAppliance(this Erply erply, DeleteApplianceSettings settings) => erply.MakeRequest(settings);
        /// <summary>
        /// Create or update an appliance or a vehicle. Appliances / Vehicles are related to the Assignments module.
        /// If the Assignments module is not enabled on this account, error code 1006 is returned.
        /// If the created or updated appliance or vehicle belongs to a natural person and your account country is subject to the General Data Protection Regulation (GDPR), Erply logs the change in the customer information processing log.
        /// </summary>
        public static int SaveAppliance(this Erply erply, SaveApplianceSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Retrieve assignments.
        /// Assignments module is an Erply feature for repair workshops. There are two different configurations: appliance repair and vehicle repair. API call getAppliances lists your appliance/vehicle database.
        /// This API call returns error 1006 if assignment module is not enabled on this account.
        /// </summary>
        public static List<Assignment> GetAssignments(this Erply erply, GetAssignmentsSettings settings) => erply.MakeRequest<List<Assignment>>(settings);
        /// <summary>
        /// Create or update an assignment.
        /// This API call returns error 1006 if assignment module is not enabled on this account.
        /// </summary>
        public static int SaveAssignment(this Erply erply, SaveAssignmentSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Delete an assignment.
        /// This API call returns error 1006 if assignment module is not enabled on this account.
        /// </summary>
        public static void DeleteAssignment(this Erply erply, DeleteAssignmentSettings settings) => erply.MakeRequest(settings);
        /// <summary>
        /// Retrieve suppliers.
        /// Suppliers can be associated with products (see getProducts) and purchase orders / purchase invoices (see getPurchaseDocuments).
        /// </summary>
        public static List<Supplier> GetSuppliers(this Erply erply, GetSuppliersSettings settings) => erply.MakeRequest<List<Supplier>>(settings);
        /// <summary>
        /// Create or update a supplier.
        /// </summary>
        public static int SaveSupplier(this Erply erply, SaveSupplierSettings settings) => erply.MakeRequest<int>(settings);
    }
}
