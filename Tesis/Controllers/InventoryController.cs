using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Tesis.ClassModels;

namespace Tesis.Controllers
{
    public class InventoryController : Controller
    {
        // Imports
        AppDbContext _db;

        // Constructor
        public InventoryController(AppDbContext db)
        {
            _db = db;
        }

        // Save stock changes
        [HttpPost]
        [Route("/Inventory/SaveStock")]
        public ActionResult SaveStock(string EditProductsListJSON, string AddOrDeleteString)
        {
            // Deserialize edit product list JSON
            var EditProductsList = JsonConvert.DeserializeObject<List<AppProducts>>(EditProductsListJSON);

            // Update stock in database
            var NewStock = _db.AddOrDeleteStock(EditProductsList, AddOrDeleteString);

            return Json(NewStock);
        }
    }
}