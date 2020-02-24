using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tesis.ClassModels;

namespace Tesis.Controllers
{
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

        // Search bar
        [HttpGet]
        [Route("/Products/SearchProduct")]
        public ActionResult SearchProduct(string SearchString)
        {
            var SearchProducts = _db.SearchBar(SearchString);

            return Json(SearchProducts);
        }

        // Search bar
        [HttpPost]
        [Route("/Products/CreateProduct")]
        public ActionResult CreateProduct()
        {
            AppProducts NewProduct = new AppProducts();
            NewProduct.ProductName = Request.Form["ProductName"];
            NewProduct.ProductCost = Int32.Parse(Request.Form["ProductCost"]);
            NewProduct.ProductPrice = Int32.Parse(Request.Form["ProductPrice"]);
            NewProduct.ProductStock = Int32.Parse(Request.Form["ProductStock"]);

            _db.AppProducts.Add(NewProduct);

            _db.SaveChanges();

            return RedirectToAction("ProductsMain", "Products");
        }
    }
}