using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tesis.ClassModels;

namespace Tesis.Controllers
{
    // Main Controller
    public class UsersController : Controller
    {
        // Imports
        AppDbContext _db;
        UserManager<AppUser> _UserManager;
        SignInManager<AppUser> _SignInManager;

        // Constructor
        public UsersController(AppDbContext db, UserManager<AppUser> UserManager, SignInManager<AppUser> SignInManager)
        {
            _db = db;
            _UserManager = UserManager;
            _SignInManager = SignInManager;
        }

        // Users login
        [HttpGet]
        [Route("/Users/Login")]
        public ActionResult OnGetLogin()
        {
            // Return main page
            return View("Login");
        }

        // Users login
        [HttpPost]
        [Route("/Users/Login")]
        public async Task<ActionResult> OnPostLogin()
        {
            // Logout
            await _SignInManager.SignOutAsync();

            // Gets the user to login
            var LoginUser = await _UserManager.FindByNameAsync(Request.Form["UserName"]);

            // Login
            var result = await _SignInManager.PasswordSignInAsync(LoginUser.UserName, Request.Form["Password"], true, false);

            if (result.Succeeded)
            {

                return RedirectToAction("ProductsMain", "Products");
                //return View("~/Views/Products/ProductsMain.cshtml");
            }

            // Return main page
            return View("Login");
        }

        // Users logout
        [HttpGet]
        [Route("/Users/Logout")]
        public async Task<ActionResult> LogoutAsync()
        {
            // Logout
            await _SignInManager.SignOutAsync();
            
            // Return to main page
            return RedirectToAction("Index", "Main");
        }

        // Users sign in
        //[Authorize]
        [HttpGet]
        [Route("/Users/SignIn")]
        public ActionResult SignIn()
        {
            // Return main page
            return View("SignIn");
        }

        // Create User
        //[Authorize]
        [HttpPost]
        [Route("/Users/CreateUser")]
        public async Task<ActionResult> CreateUser()
        {
            // Create user with the values of user from
            AppUser NewUser = new AppUser();
            NewUser.UserName = Request.Form["UserName"];
            NewUser.PhoneNumber = Request.Form["PhoneNumber"];
            NewUser.Email = Request.Form["Email"];

            // Create user in databse
            var Result = await _UserManager.CreateAsync(NewUser, Request.Form["Password"]);

            // Check if user was created correctly
            if (Result.Succeeded)
            {
                var UserRole = Request.Form["UserRole"]; // Get the selected role by the user
                await _UserManager.AddToRoleAsync(NewUser, UserRole); // Add the user a role

                // Send variable to symbolize success
                ViewBag.Successful = true;

                // Go to main page if creation was succesfull
                return View("~/Views/Main/Index.cshtml");
            }

            ViewBag.Successful = false;

            // Go to create user page if creation failed
            return RedirectToAction("SignIn", "Users");
        }
    }
}
