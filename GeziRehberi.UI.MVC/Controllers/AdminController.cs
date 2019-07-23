using GeziRehberi.DAL.Concrete.EntityFramework;
using GeziRehberi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziRehberi.UI.MVC.Controllers
{
    public class AdminController : Controller
    {
        GeziDbContext _db;

        public AdminController()
        {
            _db = new GeziDbContext();
        }
        // GET: Admin

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List(int commentid = 0)
        {
            List<Comments> comments;

            if (commentid == 0)
            {
                comments = _db.Comments.ToList();
            }
            else
            {
                comments = _db.Comments.Where(a => a.ID == commentid).ToList();
            }
            return View(comments);
        }

        public ActionResult Delete(int? commentid)
        {
            if (!commentid.HasValue)
            {
                return RedirectToAction("List");
            }

            Comments c = _db.Comments.Where(a => a.ID == commentid).SingleOrDefault();

            if (c == null)
            {
                return RedirectToAction("List");
            }
            return View(c);
        }

        [HttpPost]
        public ActionResult Delete(int commentID)
        {
            Comments deleted = _db.Comments.Find(commentID);
            _db.Set<Comments>().Remove(deleted);
            _db.SaveChanges();
            return RedirectToAction("List");
        }



        public ActionResult UserList(int userID = 0)
        {
            List<User> users;

            if (userID == 0)
            {
                users = _db.User.ToList();
            }
            else
            {
                users = _db.User.Where(a => a.ID == userID).ToList();
            }
            return View(users);
        }

        public ActionResult UserDelete(int? userID)
        {
            if (!userID.HasValue)
            {
                return RedirectToAction("UserList");
            }

            User user = _db.User.Where(a => a.ID == userID).SingleOrDefault();

            if (user == null)
            {
                return RedirectToAction("UserList");
            }
            return View(user);
        }

        [HttpPost]
        public ActionResult UserDelete(int userID)
        {
            User deleted = _db.User.Find(userID);
            _db.Set<User>().Remove(deleted);
            _db.SaveChanges();
            return RedirectToAction("UserList");
        }


        public ActionResult Guncelle()
        {
            return View();
        }


        [HttpGet]
        public ActionResult GezilecekYerEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GezilecekYerEkle(VisitingPlaces visitingPlaces)
        {
            _db.VisitingPlaces.Add(visitingPlaces);

            try
            {
                int result = _db.SaveChanges();
                //result içinde etkilenen satır sayısı tutulur

                if (result > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                ViewBag.IsSuccess = false;
                return View();
            }
           
        }
    }
}