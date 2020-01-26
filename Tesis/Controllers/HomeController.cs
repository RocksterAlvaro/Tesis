using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tesis.Controllers
{
    // Home Controller
    public class HomeController : Controller
    {
        // Index
        public ActionResult Index()
        {
            return View();
        }

        /*
         * // Test Method
        public IActionResult Index()
        {
            return View();
        }
        */
    }
}
