using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

using Newtonsoft.Json.Linq;

namespace ErplyAPI.Products
{
    public static class ProductsCalls
    {
        /// <summary>
        /// Retrieve your product database.
        /// 
        /// In addition to product card fields, you can have API to return:
        /// Inventory quantities(set getStockInfo to true);
        /// Costs and purchase prices(set getFIFOCost to true);
        /// Price list prices in a particular store(set getPriceListPrices to true);
        /// Recipes for assembly and bundle products(set getRecipes to true);
        /// Package options(set getPackageInfo to true);
        /// Replacement products(set getReplacementProducts to true);
        /// Related products(set getRelatedProducts to true);
        /// Product parameters(set getParameters to true);
        /// Quantities of packaging materials that the product contains(set getPackagingMaterials to true);
        /// Product files(manuals, specifications) (set getRelatedFiles to true);
        /// Beverage containers(set getContainerInfo to true);
        /// Detailed list of variations for a matrix product(set getMatrixVariations to true).
        /// 
        /// To add or edit a product, use saveProduct.To retrieve inventory quantities ONLY, or to synchronize that data, use getProductStock.To retrieve only price list prices, use getProductPrices.
        /// 
        /// Services are also considered a special kind of products — non-stock products.
        /// </summary>
        /// <returns>Returns list of all gotten products. Throws error if something went wrong with Erply.</returns>
        public static List<Product> GetProducts(this Erply erply, GetProductsSettings settings) => erply.MakeRequest<List<Product>>(settings);
        /// <summary>
        /// Create or update a product. Needs product Name and GroupID for creating and ID for updating!
        /// </summary>
        /// <param name="product">Product to create or update</param>
        /// <returns>Returns ID of the created/updated item.</returns>
        public static int SaveProduct(this Erply erply, SaveProductSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Retrieve product pictures.
        /// For each picture, ERPLY provides 4 URLs for 4 different image sizes. These URLs must not be hotlinked — you need to download the images to your application and serve them from there.
        /// Access to images is currently limited and the images are not accessible by default. If you need to access the files, please contact ERPLY customer support.
        /// The same information is also available through API call getProducts (field images), so if you need to query product information anyway, getProducts can also provide you the list of images for each product.
        /// </summary>
        public static List<ProductImage> GetProductPictures(this Erply erply, GetProductPicturesSettings settings) => erply.MakeRequest<List<ProductImage>>(settings);
        /// <summary>
        /// Attach a new picture to a product, or replace an existing picture.
        /// To retrieve a list of images attached to a product, call getProducts and see the element "images". To remove a picture, use deleteProductPicture.
        /// </summary>
        /// <returns>Returns ID of the created/updated item.</returns>
        public static int SaveProductPicture(this Erply erply, SaveProductPictureSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Delete a product. Products that have any number of transactions associated with them (sales, purchases or inventory) cannot be deleted; API returns error 1063. Instead, we always recommend to archive the product — setting its status to "ARCHIVED".
        /// In ERPLY backend, deleting products is no longer possible; clicking the "X" button always archives a product.
        /// </summary>
        /// <param name="productID">Product's ID to delete</param>
        public static void DeleteProduct(this Erply erply, DeleteProductSettings settings) => erply.MakeRequest(settings);
        /// <summary>
        /// Delete a product picture.
        /// </summary>
        /// <param name="productPictureID">The product picture to be deleted. Set to -1 if using productID</param>
        /// <param name="productID">To delete all pictures of the product, set productID. Set to -1 if using productPictureID</param>
        public static void DeleteProductPicture(this Erply erply, DeleteProductPictureSettings settings) => erply.MakeRequest(settings);

        /// <summary>
        /// Retrive your product group database.
        /// Groups are a way of categorizing your product database, and several API calls support filtering by group.
        /// Products can additionally be organized into categories (getProductCategories, hierarchical), brands (getBrands, a flat list), and priority groups(getProductPriorityGroups, a flat list)
        /// </summary>
        /// <returns>Returns list of all gotten product groups. Throws error if something went wrong with Erply.</returns>
        public static List<ProductGroup> GetProductGroups(this Erply erply, GetProductGroupsSettings settings) => erply.MakeRequest<List<ProductGroup>>(settings);
        /// <summary>
        /// Create or update a product group. Needs product group name for creating and ID for updating!
        /// </summary>
        /// <param name="productGroup">Product group to create or update</param>
        /// <returns>Returns ID of the created/updated item.  </returns>
        public static int SaveProductGroup(this Erply erply, SaveProductGroupSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Delete a product group. Note that products belonging to this group, as well as subgroups, will NOT be deleted or recategorized.
        /// </summary>
        /// <param name="productGroupID">ProductGroup's ID to delete</param>
        public static void DeleteProductGroup(this Erply erply, DeleteProductGroupSettings settings) => erply.MakeRequest(settings);

        /// <summary>
        /// Retrieve the list of product categories.
        /// Categories are a way of categorizing your product database, and several API calls support filtering by category.
        /// Products can additionally be organized into groups (getProductGroups, hierarchical), brands (getBrands, a flat list) and priority groups(getProductPriorityGroups, a flat list).
        /// </summary>
        /// <returns>Returns a list of product categories</returns>
        public static List<ProductCategory> GetProductCategories(this Erply erply, GetProductCategoriesSettings settings) => erply.MakeRequest<List<ProductCategory>>(settings);
        /// <summary>
        /// Create or update a product category. Needs product category name for creating and ID for updating!
        /// </summary>
        /// <param name="product">Product category to create or update</param>
        /// <returns>Returns ID of the created/updated item.</returns>
        public static int SaveProductCategory(this Erply erply, SaveProductCategorySettings settings) => erply.MakeRequest<int>(settings);

        /// <summary>
        /// Retrieve the list of product priority groups.
        /// Priority groups are a way of categorizing your product database, and several API calls support filtering by priority group.
        /// Products can additionally be organized into groups (getProductGroups), categories (getProductCategories), and brands (getBrands).
        /// </summary>
        /// <returns>Returns a list of product priority groups.</returns>
        public static List<ProductPriorityGroup> GetProductPriorityGroups(this Erply erply, GetProductPriorityGroupsSettings settings) => erply.MakeRequest<List<ProductPriorityGroup>>(settings);
        /// <summary>
        /// Create or update product priority group.
        /// </summary>
        /// <returns>Returns ID of the created/updated item.  </returns>
        public static int SaveProductPriorityGroup(this Erply erply, SaveProductPriorityGroupSettings settings) => erply.MakeRequest<int>(settings);

        /// <summary>
        /// Retrieve the list of all the possile product units
        /// </summary>
        /// <returns>Returns a list of product possible units.</returns>
        public static List<ProductUnit> GetProductUnits(this Erply erply) => erply.MakeRequest<List<ProductUnit>>(new ErplyCall() { CallName = "getProductUnits" });
        /// <summary>
        /// Create or update product unit.
        /// </summary>
        /// <returns>Returns ID of the created/updated item.  </returns>
        public static int SaveProductUnit(this Erply erply, SaveProductUnitSettings settings) => erply.MakeRequest<int>(settings);

        /// <summary>
        /// Retrieve a product's net sales price in a certain location, or net sales price for a specific customer — according to any price lists that apply.
        /// You can query prices for a single product(by supplying parameter productID) or multiple products at a time(by supplying parameter productIDs).
        /// If you do not want a price for a specific customer or location, but just need to know which price lists contain a specific item, see getProductPricesInPriceLists.
        /// </summary>
        /// <returns>Returns a list of product priority groups.</returns>
        public static List<ProductPrices> GetProductPrices(this Erply erply, GetProductPricesSettings settings) => erply.MakeRequest<List<ProductPrices>>(settings);

        /// <summary>
        /// Retrieve a product's net sales price in a certain location, or net sales price for a specific customer — according to any price lists that apply.
        /// You can query prices for a single product(by supplying parameter productID) or multiple products at a time(by supplying parameter productIDs).
        /// If you do not want a price for a specific customer or location, but just need to know which price lists contain a specific item, see getProductPricesInPriceLists.
        /// </summary>
        /// <returns>Returns a list of product priority groups.</returns>
        public static List<ProductCostForSpecificAmount> GetProductCostForSpecificAmount(this Erply erply, GetProductCostForSpecificAmountSettings settings) => erply.MakeRequest<List<ProductCostForSpecificAmount>>(settings);

        /// <summary>
        /// Retrieve a product's net sales price in a certain location, or net sales price for a specific customer — according to any price lists that apply.
        /// You can query prices for a single product(by supplying parameter productID) or multiple products at a time(by supplying parameter productIDs).
        /// If you do not want a price for a specific customer or location, but just need to know which price lists contain a specific item, see getProductPricesInPriceLists.
        /// </summary>
        /// <returns>Returns a list of product priority groups.</returns>
        public static List<ProductStock> GetProductStock(this Erply erply, GetProductStockSettings settings)
        {
            JObject records = erply.MakeRequest<JObject>(settings);

            if (records.HasValues && !settings.UseCSVMethod)
            {
                List<ProductStock> products = records.ToObject<List<ProductStock>>();

                return products;
            }
            else if (records.HasValues && settings.UseCSVMethod)
            {
                string link = records[0].Value<string>("reportLink");

                using (MemoryStream stream = new MemoryStream(new WebClient().DownloadData(link)))
                {
                    return CSVReader.ReadCSVToObject<ProductStock>(stream);
                }
            }
            else
            {
                throw new Exception("Something went wrong with GetProductStock call!");
            }
        }
    }
}
