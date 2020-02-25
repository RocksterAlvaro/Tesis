using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tesis.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        [Route("/Login/LoginMain")]
        public IActionResult loginMain()
        {
            return View("LoginMain"); 
        }


        [HttpGet]
        [Route("/Login/SigninMain")]
        public IActionResult SigninMain()
        {
            return View("SigninMain");
        }
    }
}