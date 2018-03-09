 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceLayer.Interfaces;
using DataAcessLayer.ViewModels;
using DataAcessLayer.Models;
using System.IO;
using System.Net;
using TestUI.Filters;


namespace TestUI.Controllers
{
    //[Authorize]
    [CustomExceptionFilter]
    public class UserController : BaseController
    {
        IUserService _userService = null;

        public UserController(IUserService objUser)
        {
            _userService = objUser;

        }
        [AllowAnonymous]
        // GET: User
        public ActionResult Index()
        {
            var listUserViewModel = _userService.GetUsers();
            //test Exception Handling
           // throw new Exception();
           return View(listUserViewModel);
        }

        public ActionResult Create()
        {
            var objUser = new Users();
            var objuserList = _userService.GetUsers();
            objUser.userList = objuserList;
            List<UserRoleViewModel> roleList = _userService.GetRoles();
            objUser.UserRoles = roleList;
            return View(objUser);
        }

        [HttpPost]
        public JsonResult Create(UserViewModel user)
        {
            bool result = false;
            try
            {

                if (user.Id == 0)
                {
                    if (ModelState.IsValid)
                    {
                        
                      result= _userService.AddUser(user);
                    }

                }
                else
                {

                   // RemoveValidation(ModelState);
                    if (ModelState.IsValid)
                    {
                         _userService.AddUser(user);
                    }
                }



                List<UserViewModel> listUser = _userService.GetUsers();
              Users model = new Users();
                //  return PartialView("_userList", listUser);
                //  var data = PartialView("_userList", listUser);
                // return PartialView("_userList", listUser);

                var ReturnModel = new ReturnModel();
                ReturnModel.Data = ConvertPartialViewToString(PartialView("_userList", listUser));
                ReturnModel.HasError = !ModelState.IsValid;
                ReturnModel.Error = ValidationExceptionsForUserModel(ModelState);
                return Json(ReturnModel);

            }

            catch (Exception e)
            {
                throw;
                //throw new Exception("TestException");

            }


            // return RedirectToAction("Index");

        }

        public ActionResult Edit(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserViewModel objUserViewModel = _userService.GetUser(id);
            if (objUserViewModel == null)
            {
                return HttpNotFound();
            }
            Users objUser = new Users();
            objUser.user = objUserViewModel;
            var objuserList = _userService.GetUsers();
            var listRoles = _userService.GetRoles();
            objUser.userList = objuserList;
            objUser.UserRoles = listRoles;

            return View(objUser);


        }
        public ActionResult DeleteConfirmed(int id)
        {
            var result = _userService.DeleteUser(id);
            if (result == true)
            {
                List<UserViewModel> listUser = _userService.GetUsers();
                //MVCDemo.ViewModel.Users model = new MVCDemo.ViewModel.Users();
                return PartialView("_userList", listUser);
            }
            else
            {
                return Content("Error Deleting User!");
            }

        }
        private void RemoveValidation(ModelStateDictionary modelState)
        {
            List<string> keys = new List<string>();
            foreach (var modelkey in ModelState.Keys)
            {
                if (modelkey.ToLower().Contains("usercode") || modelkey.ToLower().Contains("email"))
                {
                    keys.Add(modelkey);
                }
                if (keys.Count == 2)
                {
                    break;
                }
            }
            foreach (var key in keys)
            {
                ModelState.Remove(key);
            }
        }
        private string ValidationExceptionsForUserModel(System.Web.Mvc.ModelStateDictionary ModelState)
        {
            var ErrorMessageSummary = "<p> ";
            //ignore specific errors mentioned below.
            //  Any changes here must be synced with POST method above
            foreach (var key in ModelState.Keys.ToList().Where(key => ModelState.ContainsKey(key)))
            {
                if (ModelState[key].Errors.Count > 0)
                {
                    foreach (var error in ModelState[key].Errors)
                    {
                        ErrorMessageSummary += "</br> " + error.ErrorMessage;
                    }
                }

            }
            return ErrorMessageSummary + " </p>";
        }

        protected string ConvertPartialViewToString(PartialViewResult partialView)
        {
            using (var sw = new StringWriter())
            {
                partialView.View = ViewEngines.Engines
                  .FindPartialView(ControllerContext, partialView.ViewName).View;

                var vc = new ViewContext(
                  ControllerContext, partialView.View, partialView.ViewData, partialView.TempData, sw);
                partialView.View.Render(vc, sw);

                var partialViewString = sw.GetStringBuilder().ToString();

                return partialViewString;
            }
        }
        [HttpPost]
        public JsonResult IsUserCodeExists(string userCode)
        {
                bool jsonMessage = false;
            var result = _userService.GetUser(userCode);
            if (result != null)
            {
                jsonMessage = true;

            }
           
            return Json(new { message = jsonMessage });

        }

    }
   
}