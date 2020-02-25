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


        //Return Inventory Admin View
        [HttpGet]
        [Route("/Inventory/InventoryAdmin")]

        public ActionResult InventoryAdmin()
        {
            return View("InventoryAdmin");
        }

        //Return Inventory AI View
        [HttpGet]
        [Route("/Inventory/InventoryAI")]

        public ActionResult InventoryAI()
        {
            return View("InventoryAI");
        }

        //Return Inventory Main View
        [HttpGet]
        [Route("/Inventory/InventoryMain")]

        public ActionResult InventoryMain()
        {
            return View("InventoryMain");
        }

        // Save stock changes
        [HttpPost]
        [Route("/Inventory/SaveStock")]
        public ActionResult SaveStock(string InOrOutString, string StockOrSaleString, string EditProductsListJSON)
        {
            // Deserialize edit product list JSON
            var EditProductsList = JsonConvert.DeserializeObject<List<AppProducts>>(EditProductsListJSON);

            // Update stock in database
            var NewStock = _db.InOrOutStock(EditProductsList, InOrOutString, StockOrSaleString);

            return Json(NewStock);
        }

        // Zero Stock
        [HttpGet]
        [Route("/Inventory/StockZero")]
        public ActionResult ZeroStock()
        {
            // Update stock in database
            var Response = _db.ZeroStock();

            return Json(Response);
        }
    }
}