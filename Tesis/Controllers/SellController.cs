using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tesis.ClassModels;



namespace Tesis.Controllers
{
    // Home Controller
    public class SellController : Controller
    {
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
    }
}
