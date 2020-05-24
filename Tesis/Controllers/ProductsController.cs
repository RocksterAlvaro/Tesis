using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Tesis.ClassModels;

namespace Tesis.Controllers
{
    // Products Controller
    [Authorize]
    public class ProductsController : Controller
    {
        // Imports
        AppDbContext _db;

        // Constructor
        public ProductsController(AppDbContext db)
        {
            _db = db;
        }

        // Products Main Page
        [HttpGet]
        [Route("/Products/ProductsMain")]
        public ActionResult ProductsMain()
        {
            // Return main page
            return View("ProductsMain");
        }

        // Create Product
        [HttpPost]
        [Route("/Products/CreateProduct")]
        public ActionResult CreateProduct()
        {
            // Create the product to be added to the database
            AppProducts NewProduct = new AppProducts();
            NewProduct.ProductName = Request.Form["ProductName"];
            NewProduct.ProductCost = Int32.Parse(Request.Form["ProductCost"]);
            NewProduct.ProductPrice = Int32.Parse(Request.Form["ProductPrice"]);
            NewProduct.ProductStock = Int32.Parse(Request.Form["ProductStock"]);
            NewProduct.ProductActive = true;

            // Add the new product to the database
            _db.AppProducts.Add(NewProduct);

            // Save changes
            _db.SaveChanges();

            // Reload the page
            return RedirectToAction("ProductsMain", "Products");
        }

        // Get Product
        [HttpGet]
        [Route("/Products/GetProduct/{ProductId}")]
        public ActionResult GetProduct(string ProductId)
        {
            // Search the product on the database
            var Product = _db.AppProducts.Find(ProductId);

            // Return OK
            return Json(Product);
        }

        // Edit Product
        [HttpPost]
        [Route("/Products/EditProduct")]
        public ActionResult EditProduct()
        {
            // Get the product id
            var ProductId = Request.Form["ProductId"];

            // Get the product from the database
            var Product = _db.AppProducts.Find(ProductId);

            // Edit product values
            Product.ProductName = Request.Form["ProductName"];
            Product.ProductCost = Int32.Parse(Request.Form["ProductCost"]);
            Product.ProductPrice = Int32.Parse(Request.Form["ProductPrice"]);
            Product.ProductStock = Int32.Parse(Request.Form["ProductStock"]);

            // Save changes
            _db.SaveChanges();

            // Reload page
            return RedirectToAction("ProductsMain", "Products");
        }

        // Search bar
        [HttpGet]
        [Route("/Products/SearchProduct")]
        public ActionResult SearchProduct(string SearchString)
        {
            var SearchProducts = _db.SearchBar(SearchString);

            return Json(SearchProducts);
        }

        // Delete Product
        [HttpPost]
        [Route("/Products/ActivateProduct")]
        public ActionResult DeactivateProduct(string ProductToActivateJSON, string ActiveBoolJSON)
        {
            // Deserialize active bool JSON
            var ActiveBool = JsonConvert.DeserializeObject<string>(ActiveBoolJSON);

            // Deserialize product to deactivate JSON
            var ProductToDeactivate = JsonConvert.DeserializeObject<AppProducts>(ProductToActivateJSON);

            // Deactivate product in database
            ProductToDeactivate.ProductActive = bool.Parse(ActiveBool);
            _db.Entry(ProductToDeactivate).Property(x => x.ProductActive).IsModified = true;

            // Save changes
            _db.SaveChanges();

            // Return OK
            return Ok();
        }
    }
}