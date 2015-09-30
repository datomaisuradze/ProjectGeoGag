using ProjectForum.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;

namespace ProjectForum.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext ProjectForumdb = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CategoryInfo(string id)
        {
            //var Posts=ForumDb.Posts.Where(i => i.PostCategory == id);
            return View("CategoryInfo");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}