using GeziRehberi.BLL.Abstract;
using GeziRehberi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeziRehberi.UI.MVC.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        ICityService _cityService;
        ICommentService _commentService;
        public CityController(ICityService cityService, ICommentService commentService)
        {
            _cityService = cityService;
            _commentService = commentService;
        }

        public ActionResult Index(int id)
        {
            return View(_cityService.Get(id));
        }


        public ActionResult Comment(int id)
        {
            ViewBag.Comments = _commentService.GetAll().Where(x => x.CityID == id);
            return PartialView(_cityService.Get(id));
        }


        public ActionResult PostComment(string comment, int id)
        {
            User user = Session["kullanici"] as User;
            Comments yeniYorum = new Comments();
            yeniYorum.Comment = comment;
            yeniYorum.CityID = id;
            yeniYorum.UserID = user.ID;
            yeniYorum.Date = DateTime.Now;
            _commentService.Insert(yeniYorum);

            return RedirectToAction("Comment", "City", new { id });
        }

    }
}