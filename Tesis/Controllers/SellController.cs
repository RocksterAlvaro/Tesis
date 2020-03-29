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
    // Sell Controller
    [Authorize]
    public class SellController : Controller
    {
        // Imports
        AppDbContext _db;

        // Constructor
        public SellController(AppDbContext db)
        {
            _db = db;
        }


        // Selling main page
        [HttpGet]
        [Route("/Sell/SellingMainPage")]
        public ActionResult SellingMainPage()
        {
            return View("SellingMainPage");
        }
        
        // Selling admin
        [HttpGet]
        [Route("/Sell/SellingAdmin")]
        public ActionResult SellingAdmin()
        {
            return View("SellingAdmin");
        }

        // Basic sell
        [HttpPost]
        [Route("/Sell/BasicSell")]
        public ActionResult BasicSell(int TotalPrice, string MovementProductsListJSON)
        {
            // Deserialize edit product list JSON
            var MovementProductList = JsonConvert.DeserializeObject<List<AppProducts>>(MovementProductsListJSON);

            // Update stock in database
            var NewStock = _db.InOrOutStock(MovementProductList, "Out", "Sale", TotalPrice);

            return Json(NewStock);
        }
    }
}
