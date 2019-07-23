using GeziRehberi.BLL.Abstract;
using GeziRehberi.Model;
using GeziRehberi.UI.MVC.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziRehberi.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet]
        public ActionResult Register()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            try
            {
                _userService.Insert(user);
                bool sonuc = MailHelper.SendConfirmationMail(user.Username, user.Password, user.Email, user.ID);
                if (!sonuc)
                {
                    return PartialView();
                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Veritabanı ekleme hatası!";
                return View();
            }
            ViewBag.IsSuccess = true;
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Login()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var gelenKullanici = _userService.GetUserByLogin(user.Username, user.Password);

            if (gelenKullanici.Username == "admin" && gelenKullanici.Password == "admin123")
            {
                Session["admin"] = gelenKullanici;
                return RedirectToAction("Index", "Admin");
            }

            else if (gelenKullanici != null)
            {
                Session["kullanici"] = gelenKullanici;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Kullanıcı bulunamadı";
            return PartialView();
        }


        public ActionResult Logout()
        {
            Session["kullanici"] = null;
            return RedirectToAction("Index", "Home");
        }



        public ActionResult Index()
        {
            return View();
        }
    }
}