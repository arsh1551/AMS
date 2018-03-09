using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUI.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            #region Doamin Check            
            #endregion
        }
        protected override void OnAuthorization(AuthorizationContext filterContext)
        {
            bool skipAuthorization = filterContext.ActionDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true)
           || filterContext.ActionDescriptor.ControllerDescriptor.IsDefined(typeof(AllowAnonymousAttribute), true);
            if (!skipAuthorization)
            {
                if (System.Web.HttpContext.Current.Session["currentUser"] == null)
                {

                    filterContext.Result = new RedirectResult(Url.Action("Login", "Account"));
                }
            }
        }
    }
}