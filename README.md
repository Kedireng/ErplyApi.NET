ErplyAPI.NET
======================

A Brief Intro
-------------------

ErplyAPI.NET is a .NET library for calling Erply REST API with Auth in .NET applications. It was built with simplicity in mind and using it should need as little code as possible. 

* [Visit Erply](https://erply.com/)
* [Visit Erply REST API DOCS](https://learn-api.erply.com/requests/)

Usage (WooCommerce REST API)
-------------------
  
```cs
using ErplyAPI;
using ErplyAPI.Products;

/* Erply is our main class, which handles all our requests.
 * When creating this class, VerifyUser() will be called.
 * All next request will use sessionKey gotten from this or
 * make a new VerifyUser() request if key is about to expire.
 */
// Authenticate yourself
var erply = new Erply(505789, "", "");

// Config your request
var getProductsSettings = new GetProductsSettings()
{
    Type = ProductType.PRODUCT,
    Status = ProductStatus.ACTIVE
};

// Get all products with given config
var products = erply.FetchAll<Product>(getProductsSettings);

// Create new product
var newProduct = new Product()
{
    Name = "Example product",
    Type = ProductType.PRODUCT,
    Price = 42.69f
};

// Create config for saving our new product
var saveProductSettings = new SaveProductSettings()
{
    Product = newProduct
};

// Save our product into Erply
var productID = erply.SaveProduct(saveProductSettings);

// Let's delete our newly created product
erply.DeleteProduct(new DeleteProductSettings() { ProductID = productID });

// Create list of requests
var calls = new List<ErplyCall>();

for(int i = 0; i < 200; i++)
{
    var product = new Product();
    product.Name = i.ToString();
    product.Price = i;

    var call = new SaveProductSettings()
    {
        Product = product
    };
    calls.Add(call);
}

/* Infinite amount of calls can be done with this method.
 * MakeBulkRequest() takes in a list and makes it into consumable pieces for Erply and 
 * makes as many bulk requests as needed to make all calls.
 * Good thing to keep in mind is that we don't check each response for succes or failure,
 * only individual bulk requests error codes are checked. 
 */ 
// Let's save all our product into Erply
erply.MakeBulkRequest(calls);
```