using System.Collections.Generic;

namespace ErplyAPI.Webstore
{
    public static class Calls
    {
        /// <summary>
        /// Returns an array of possible matrix dimensions.
        /// </summary>
        public static List<MatrixDimension> GetMatrixDimensions(this Erply erply, GetMatrixDimensionsSettings settings) => erply.MakeRequest<List<MatrixDimension>>(settings);
        /// <summary>
        /// Create a matrix dimension, or add values to an existing dimension.
        /// A matrix dimension is necessary for setting up matrix products. Typical matrix dimensions are, for example, "Size" (in which the values might be 2, 4, 6, 8 — or S, M, L, XL) and "Color" (which may contain Blue, Red, Black, Green etc).
        /// Different matrix products can share the same dimensions, and a matrix product does not need to have variations corresponding to each value in the dimension. For example, it is sufficient to have just one dimension for all letter sizes, one for all numeric sizes and one for all kinds of colors.
        /// Matrix products and their variations can be created with API call getProducts.
        /// This API call is the best choice if you want to create a brand new dimension with a specific set of values. However, if a dimension already exists and you want to modify its list of values, see the following API calls instead:
        /// </summary>
        public static int SaveMatrixDimension(this Erply erply, SaveMatrixDimensionSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Add a new value (specific color or size) to a matrix dimension.
        /// A matrix dimension is necessary for setting up matrix products. Typical matrix dimensions are, for example, "Size" (in which the values might be 2, 4, 6, 8 — or S, M, L, XL) and "Color" (which may contain Blue, Red, Black, Green etc).
        /// To create a new dimension, see saveMatrixDimension. To edit an existing value (to change its name or code), see editItemInMatrixDimension. To delete a value, see removeItemsFromMatrixDimension.
        /// </summary>
        public static int AddItemToMatrixDimension(this Erply erply, AddItemToMatrixDimensionSettings settings) => erply.MakeRequest<int>(settings);
        /// <summary>
        /// Retrieve product brands.
        /// Brands are a way of categorizing your product database, and several API calls support filtering by brand.
        /// Products can additionally be organized into groups (getProductGroups, hierarchical), categories (getProductCategories, hierarchical), and priority groups (getProductPriorityGroups, a flat list).
        /// </summary>
        public static List<Brand> GetBrands(this Erply erply) => erply.MakeRequest<List<Brand>>(new ErplyCall() { CallName = "getBrands" });
        /// <summary>
        /// Creates or updates brand.
        /// </summary>
        public static int SaveBrand(this Erply erply, SaveBrandSettings settings) => erply.MakeRequest<int>(settings);
    }
}
