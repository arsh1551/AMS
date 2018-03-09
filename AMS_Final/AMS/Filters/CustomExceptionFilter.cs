using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUI.Filters
{
    public class CustomExceptionFilter:FilterAttribute,IExceptionFilter
    {
        
        public void OnException(ExceptionContext filterContext)
        {

            if (!filterContext.ExceptionHandled && filterContext.Exception!=null)
            {
                //filterContext.Result = new RedirectResult("customError.html");
                filterContext.Result = new ViewResult
                {
                    ViewName = "~/Views/Shared/customError.cshtml"
                };
               
                filterContext.ExceptionHandled = true;
            }
        }

        //protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        //{
        //    //User isn't logged in
        //    if ((SessionManagement.LoggedInUser == null || SessionManagement.LoggedInUser.IndividualId == 0))
        //    {
        //        filterContext.Result = new RedirectToRouteResult(
        //                new RouteValueDictionary(new { controller = "Account", action = "Login" })
        //        );
        //    }
        //    //User is logged in but has no access
        //    else
        //    {
        //        filterContext.Result = new RedirectToRouteResult(
        //                new RouteValueDictionary(new { controller = "Account", action = "Login", area = "" })
        //        );
        //    }
        //}

        //protected override bool AuthorizeCore(HttpContextBase httpContext)
        //{
        //    bool isaurhorize = false;
        //    if (SessionManagement.LoggedInUser != null && (SessionManagement.LoggedInUser.UserRoles != null))
        //    {
        //        if (SessionManagement.LoggedInUser.UserRoles.Any(item => allowedroles.Contains(item.RoleName)))
        //            isaurhorize = true;
        //        else
        //            isaurhorize = false;
        //        return isaurhorize;
        //    }
        //    else
        //    {
        //        return isaurhorize;
        //    }

        //}
    }
}