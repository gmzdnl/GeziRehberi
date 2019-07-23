using GeziRehberi.BLL.Abstract;
using GeziRehberi.BLL.Concrete;
using GeziRehberi.DAL.Concrete.EntityFramework;
using GeziRehberi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziRehberi.UI.MVC.Controllers
{
    public class HomeController : Controller
    {

        ICityService _cityService;
        IUserService _userService;
        ICommentService _commentService;
        GeziDbContext _db;

        public HomeController(ICityService cityservice, IUserService userservice, ICommentService commentService)
        {
            _db = new GeziDbContext();
            _cityService = cityservice;
            _userService = userservice;
            _commentService = commentService;

        }
        // GET: Home

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Hesap()
        {
            if (Session["kullanici"] != null)
            {
                User user = Session["kullanici"] as User;
                List<Comments> comments = _db.Comments.Where(a => a.UserID == user.ID).ToList();
                ViewBag.Comments = comments;
                return View(user);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Update()
        {
            if (Session["kullanici"] == null)
            {
                return RedirectToAction("Index");
            }

            User u = Session["kullanici"] as User;

            return View(u);
        }

        [HttpPost]
        public ActionResult Update(User user)
        {
            if (user != null)
            {
                User updatedUser = _userService.Get(user.ID);

                updatedUser.Username = user.Username;
                updatedUser.Name = user.Name;
                updatedUser.Surname = user.Surname;
                updatedUser.Email = user.Email;
                updatedUser.Password = user.Password;

                _userService.Update(updatedUser);
                return RedirectToAction("Hesap");
            }
            else
            {
                return RedirectToAction("Index");
            }

        }


        public ActionResult CommentDelete(int? commentid)
        {
            if (!commentid.HasValue)
            {
                return RedirectToAction("Hesap");
            }

            Comments c = _db.Comments.Where(a => a.ID == commentid).SingleOrDefault();

            if (c == null)
            {
                return RedirectToAction("Hesap");
            }
            return View(c);
        }

        [HttpPost]
        public ActionResult CommentDelete(int ID)
        {
            Comments deleted = _db.Comments.Find(ID);
            _db.Set<Comments>().Remove(deleted);
            _db.SaveChanges();


            return RedirectToAction("Hesap");
        }
    }
}