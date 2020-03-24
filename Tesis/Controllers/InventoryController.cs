using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Tesis.ClassModels;

namespace Tesis.Controllers
{
    // Inventory Controller
    public class InventoryController : Controller
    {
        // Imports
        AppDbContext _db;

        // Constructor
        public InventoryController(AppDbContext db)
        {
            _db = db;
        }

        // Return inventory historic movements View
        [HttpGet]
        [Route("/Inventory/InventoryHistory")]

        public ActionResult InventoryHistory()
        {
            // Return view
            return View("InventoryHistory");
        }

        // Return last stock movements
        [HttpGet]
        [Route("/Inventory/LatestStockInOut")]
        public ActionResult LatestStockInOut()
        {
            // Call the database to get the latest stock in out entries
            var LatestStockInOutJSON = _db.GetLatestStockInOut();

            // Return information as JSON
            return Json(LatestStockInOutJSON);
        }

        // Return specific movement
        [HttpGet]
        [Route("/Inventory/SpecificMovementProducts")]
        public ActionResult SpecificMovementProducts(string SpecificMovementId)
        {
            // Call the database to get the latest stock in out entries
            var SpecificMovementProductsJSON = _db.GetSpecificMovementProducts(SpecificMovementId);

            return Json(SpecificMovementProductsJSON);
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
        public ActionResult SaveStock(string InOrOutString, string StockOrSaleString, string MovementProductsListJSON)
        {
            // Deserialize edit product list JSON
            var MovementProductList = JsonConvert.DeserializeObject<List<AppProducts>>(MovementProductsListJSON);

            // Update stock in database
            var NewStock = _db.InOrOutStock(MovementProductList, InOrOutString, StockOrSaleString, 0);

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