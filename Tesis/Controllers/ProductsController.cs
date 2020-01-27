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

        // Index
        public ActionResult Index()
        {
            return View();
        }

        // Search bar
        [HttpGet]
        [Route("/Products/SearchProduct")]
        public ActionResult SearchProduct(string SearchString)
        {
            var SearchProducts = _db.SearchBar(SearchString);

            return Json(SearchProducts);
        }
    }
}