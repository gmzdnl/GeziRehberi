using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziRehberi.UI.MVC.CustomFilter
{
    public class CustomFilterAttribute:AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //kullanıcı girişi varken nasıl davranacağını belirtiyoruz
            if (System.Web.HttpContext.Current.Session["kullanici"] != null)
            {
                return true;
            }
            return false;

        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            //kullanıcı girişi yokken nasıl davranacağını belirtiyoruz
            filterContext.Result = new RedirectResult("/Account/Login");
        }
    }
}