using System.Collections.Generic;

namespace ErplyAPI.Inventory
{
    public static class InventoryCalls
    {
        /// <summary>
        /// Create an Inventory Write-Off or update an existing one.
        /// Inventory Write-Off is a document that removes products from inventory; it has a list of items and quantities.
        /// Non-stock products and bundles cannot be on Inventory Write-Offs (these items do not have inventory).
        /// Products can be added to stock with Inventory Registrations (see getInventoryRegistrations and saveInventoryRegistration) and moved between locations with Inventory Transfers (see getInventoryTransfers and saveInventoryTransfer).
        /// To retrieve a list of Inventory Write-Offs, see getInventoryWriteOffs.
        /// </summary>
        public static int SaveInventoryWriteOff(this Erply erply, SaveInventoryWriteOffSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Retrieve Inventory Write-Offs.
        /// Inventory Write-Off is a document that removes products from inventory; it has a list of items and quantities.
        /// Products can be added to stock with Inventory Registrations (see getInventoryRegistrations) and moved between locations with Inventory Transfers (see getInventoryTransfers).
        /// To create an Inventory Write-Off, see saveInventoryWriteOff.
        /// </summary>
        public static List<InventoryWriteOff> GetInventoryWriteOffs(this Erply erply, GetInventoryWriteOffsSettings settings) => erply.MakeRequest<List<InventoryWriteOff>>(settings);
        /// <summary>
        /// Retrieve Inventory Registrations.
        /// Inventory Registration is a document that takes products into inventory; it has a list of items and quantities. It is similar to a Purchase Invoice, but has fewer fields and is best suited for registering your initial stock quantities when you start using ERPLY — or for making inventory quantity adjustments.
        /// Non-stock products and bundles cannot be on Inventory Registrations (these items do not have inventory).
        /// Products can be removed from stock with Inventory Write-offs (see getInventoryWriteOffs) and moved between locations with Inventory Transfers (see getInventoryTransfers).
        /// To create an Inventory Registration, see saveInventoryRegistration.
        /// </summary>
        public static List<InventoryRegistration> GetInventoryRegistrations(this Erply erply, GetInventoryRegistrationsSettings settings) => erply.MakeRequest<List<InventoryRegistration>>(settings);
        /// <summary>
        /// Retrieve Inventory Transfers.
        /// In ERPLY, an Inventory Transfer is a document that moves inventory between locations (stores); subtracts from one location and adds to the other. An Inventory Transfer has a list of items and quantities.
        /// Non-stock products and bundles cannot be transfered (these items do not have inventory).
        /// To create or update an Inventory Transfer, see saveInventoryTransfer.
        /// To get a CSV report of Inventory Transfers, see getInventoryTransferReport. If you need all Transfers that have taken place in a certain time period, it is more efficient to get the report — you will get all the data with just one query.
        /// </summary>
        public static List<InventoryTransfer> GetInventoryTransfers(this Erply erply, GetInventoryTransfersSettings settings) => erply.MakeRequest<List<InventoryTransfer>>(settings);
        /// <summary>
        /// Create an Inventory Registration or update an existing one.
        /// Inventory Registration is a document that takes products into inventory; it has a list of items and quantities. It is similar to a Purchase Invoice, but has fewer fields and is best suited for registering your initial stock quantities when you start using ERPLY — or for making inventory quantity adjustments.
        /// Non-stock products and bundles cannot be on Inventory Registrations (these items do not have inventory).
        /// Products can be removed from stock with Inventory Write-offs (see getInventoryWriteOffs and saveInventoryWriteOff) and moved between locations with Inventory Transfers (see getInventoryTransfers and saveInventoryTransfer).
        /// To retrieve a list of Inventory Registrations, see getInventoryRegistrations.
        /// </summary>
        public static int SaveInventoryRegistration(this Erply erply, SaveInventoryRegistrationSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Create or update an Inventory Transfer.
        /// Inventory Transfer is a document that moves inventory between locations (stores); subtracts from one location and adds to the other. Inventory Transfer has a list of items and quantities.
        /// Non-stock products and bundles cannot be transfered (these items do not have inventory).
        /// For retrieving Inventory Transfers, see getInventoryTransfers.
        /// </summary>
        public static int SaveInventoryTransfer(this Erply erply, SaveInventoryTransferSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Returns a list of purchase documents (purchase invoices or orders), according to the supplied filtering parameters.
        /// If you have specified document ID or invoice number, or if the search criteria match a single sales document, or if you have set getRowsForAllInvoices = 1, API returns all documents together with their rows. Otherwise only document headers will be returned.
        /// If you are looking for a way to pull all purchase data for external processing, see getPurchaseReport. getPurchaseReport can output either detailed data or aggregate it as needed: it can provide totals by products, by product groups, by dates, by locations, etc.
        /// </summary>
        public static List<PurchaseDocument> GetPurchaseDocuments(this Erply erply, GetPurchaseDocumentsSettings settings) => erply.MakeRequest<List<PurchaseDocument>>(settings);
        /// <summary>
        /// Create a new purchase invoice, purchase order or purchase return, or update an existing one.
        /// </summary>
        public static PurchaseDocument SavePurchaseDocument(this Erply erply, SavePurchaseDocumentSettings settings) => erply.MakeRequest<PurchaseDocument>(settings);
        /// <summary>
        /// Delete a purchase document (invoice, order, return).
        /// </summary>
        public static void DeletePurchaseDocument(this Erply erply, DeletePurchaseDocumentSettings settings) => erply.MakeRequest(settings);
        /// <summary>
        /// Retrieve physical stocktakings.
        /// A physical stocktaking is an operation where inventory is manually re-counted; if actual count differs from the inventory quantity in ERPLY, the quantity in ERPLY is adjusted.
        /// When physical stocktaking is completed, the stocktaking act must be confirmed. Any surplus items can then be taken into inventory with an Inventory Registration, and missing items subtracted with an Inventory Write-Off.
        /// To retrieve all item counts in one specific stocktaking, see getStocktakingReadings. To start a new stocktaking (create a new stocktaking act), see saveStocktaking. To update quantities on an act, see saveStocktakingReadings and incrementStocktakingReading.
        /// </summary>
        public static List<Stocktaking> GetStocktakings(this Erply erply, GetStocktakingsSettings settings) => erply.MakeRequest<List<Stocktaking>>(settings);
        /// <summary>
        /// Create or update a physical stocktaking act.
        /// Creating the act is the first step in physical stocktaking. Next, it must be filled with quantities counted in the warehouse. After all quantities have been recorded and verified, the act must be confirmed. Finally, surplus quantities should be taken into stock with an Inventory Registration and missing quantites written off with an Inventory Write-off. Note that just confirming the act will not update your inventory yet!
        /// Inventory Registrations and Write-offs can be created manually in Erply back-end.
        /// For related API calls, see getStocktakings, getStocktakingReadings, saveStocktakingReadings and incrementStocktakingReading.
        /// </summary>
        public static int SaveStocktaking(this Erply erply, SaveStocktakingSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Retrieve item counts on one specific stocktaking act.
        /// To retrieve a list of physical stocktakings, see getStocktakings. To start a new stocktaking (create a new stocktaking act), see saveStocktaking. To update quantities on an act, see saveStocktakingReadings (to make bulk updates) or incrementStocktakingReading (to increment quantities atomically).
        /// </summary>
        public static List<StocktakingReading> GetStocktakingReadings(this Erply erply, GetStocktakingReadingsSettings settings) => erply.MakeRequest<List<StocktakingReading>>(settings);
        /// <summary>
        /// Update product count on a physical stocktaking sheet.
        /// Note! This API call should be used only in single-client mode (if your API script or application is the only one updating the quantities). If you have several applications that need to update quantities simultaneously, use incrementStocktakingReading instead.
        /// For related API calls, see getStocktakings, getStocktakingReadings and saveStocktaking.
        /// </summary>
        public static void SaveStocktakingReadings(this Erply erply, SaveStocktakingReadingsSettings settings) => erply.MakeRequest(settings);
        /// <summary>
        /// Create or update a store (location, warehouse).
        /// To retrieve a list of locations, see getWarehouses.
        /// </summary>
        public static int SaveWarehouse(this Erply erply, SaveWarehouseSettings settings) => erply.MakeRequest<int>(settings);
    }
}
