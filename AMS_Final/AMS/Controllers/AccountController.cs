using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAcessLayer.ViewModels;
using ServiceLayer.Interfaces;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace TestUI.Controllers
{
    [HandleError]
    public class AccountController:Controller 
    {
        IUserService _userService = null;

        public AccountController(IUserService objUserService)
            {
            _userService = objUserService;

        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {

            LoginViewModel loginModel = new LoginViewModel();
            ViewBag.Error = TempData["errorMessage"];
            return View(loginModel);
        }


        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            //validate password also
            UserViewModel loggedInUser = _userService.ValidateUser(model.UserCode, model.Password);

            //Valid User
            if (loggedInUser != null)
            {
                if (System.Web.HttpContext.Current.Session["currentUser"] == null)
                {
                    System.Web.HttpContext.Current.Session["currentUser"] = loggedInUser;
                }

                // return Json(new { message = true });
                return RedirectToAction("Index", "User");
            }
            else
            {
                //return Json(new { message = false });
                TempData["errorMessage"] = "Invalid User Code or Password!";
                return RedirectToAction("Login");
            }

        }
        public ActionResult LogOut()
        {
            if (System.Web.HttpContext.Current.Session["currentUser"] != null)
            {
                System.Web.HttpContext.Current.Session["currentUser"] = null;
            }

            return RedirectToAction("Login");


        }

        private void SetAuthCookie(LoginViewModel userInfo, string email, bool IsPre = false)
        {
            try
            {
                HttpCookie faCookie = null;
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                string userData = serializer.Serialize(userInfo.UserCode);

                FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
                    1, email, DateTime.Now, DateTime.Now.AddHours(8), IsPre, userData);

                string encTicket = FormsAuthentication.Encrypt(authTicket);
                if (IsPre)
                {
                    faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket)
                    {
                        Expires = DateTime.Now.AddDays(30)
                    };
                }
                else
                    faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);

                Response.Cookies.Add(faCookie);
            }
            catch (Exception ex)
            {

            }
        }


    }
}