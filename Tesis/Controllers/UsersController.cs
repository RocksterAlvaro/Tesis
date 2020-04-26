using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
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
        [Authorize(Roles = "Admin,ShopAdmin")]
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

        // Change password
        [HttpGet]
        [Route("/Users/ChangePassword")]
        public ActionResult OnGetChangePassword(string token)
        {
            TempData["PasswordToken"] = token;
            return View("ChangePassword");
        }

        [HttpPost]
        [Route("/Users/ChangePassword/")]
        public ActionResult OnPostChangePassword()
        {
            string UserName = Request.Form["UserName"];
            string Token = TempData["PasswordToken"].ToString();
            AppUser CurrentUser = new AppUser();

            // Search the UserName with this email
            CurrentUser = _UserManager.FindByNameAsync(UserName).Result;
            
            IdentityResult result = _UserManager.ResetPasswordAsync(CurrentUser, Token, Request.Form["Password"]).Result;

            if (result.Succeeded)
            {
                TempData["Message"] = "El cambio de contraseña ha sido exitoso. Por favor inicie sesion.";
                return RedirectToAction("Index", "Main");
            }
            else
            {
                TempData["Message"] = "Error al momento de cambiar contraseña. Intentelo de nuevo.";
                return RedirectToAction("Login", "Index");
            }
        }

        // Request change password
        [HttpGet]
        [Route("/Users/RequestChangePassword/")]
        public ActionResult OnGetRequestChangePassword()
        {
            // Sign out any previous user
            _SignInManager.SignOutAsync().Wait();

            return View("RequestChangePassword");
        }

        [HttpPost]
        [Route("/Users/RequestChangePassword/")]
        public ActionResult OnPostRequestChangePasswordAsync()
        {
            string UserName = Request.Form["UserName"];
            AppUser CurrentUser = new AppUser();

            // Search the UserName with his UserName
            CurrentUser = _UserManager.FindByNameAsync(UserName).Result;

            // Generate the change password link
            string token = _UserManager.GeneratePasswordResetTokenAsync(CurrentUser).Result;
            var resetLink = Url.Action("ChangePassword",
                    "Users", new { token = token },
                     protocol: HttpContext.Request.Scheme);

            SendEmail("EmailChangePass.html", resetLink, CurrentUser, "Cambio de contraseña");

            //TempData["Message"] = "El enlace de recuperar contraseña se ha enviado al correo electronico";

            return RedirectToAction("Index", "Main");
        }

        // Send Email
        public void SendEmail(string EmailTemplate, string link, AppUser CurrentUser, string Subject)
        {

            string htmlBody = "";

            //Html template path
            htmlBody = System.IO.File.ReadAllText("../Tesis/wwwroot/templates/emailTemplate.html");

            //Pass data to the template (user name and password recovery link)

            //Pass user name
            htmlBody = htmlBody.Replace("#CurrentUser#", CurrentUser.UserName);

            //Pass password recovery link
            htmlBody = htmlBody.Replace("#NepLink#", link);

            /* Junk Synchron
            // Create email text
            string EmailText = "El siguiente usuario: " + CurrentUser.UserName + " ha solicitado un cambio de contraseña." +
                "Por favor presione el siguiente link para realizarlo: ";

            // Build the Email
            var builder = new StringBuilder();
            builder.Append(EmailText);

            // Append link
            builder.Append("<a href=\"" + link + "\"> Reiniciar contraseña </a>");
            */
            string FinalHtml = htmlBody;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new System.Net.NetworkCredential("rocksteralvaro@gmail.com", "deadrockisalie07@");
            smtpClient.Host = "smtp.gmail.com";

            MailMessage Message = new MailMessage(
                from: "rocksteralvaro@gmail.com",
                to: CurrentUser.Email,
                subject: Subject,
                body: FinalHtml
                );

            //Show "Tesis Pos" as reminent instead of rocksteralvaro 
            Message.From = new MailAddress("rocksteralvaro@gmail.com", "Tesis POS");
            Message.IsBodyHtml = true;

            smtpClient.Send(Message);
        }
    }
}
