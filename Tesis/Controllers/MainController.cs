using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Tesis.ClassModels;

namespace Tesis.Controllers
{
    // Main Controller
    public class MainController : Controller
    {
        // Index
        [HttpGet]
        [Route("/")]
        [Route("/Main/Index")]
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}
