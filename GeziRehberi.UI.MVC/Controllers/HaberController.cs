using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziRehberi.UI.MVC.Controllers
{
    public class HaberController : Controller
    {
        // GET: Haber
        public ActionResult Index()
        {
            return View();
        }
    }
}