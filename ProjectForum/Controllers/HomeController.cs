using ProjectForum.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;
using BusinessLogicLayer.Services;

namespace ProjectForum.Controllers
{
    public class HomeController : Controller
    {
        HomeService homeService;

        public HomeController(HomeService homeService)
        {
            this.homeService = homeService;
        }


        public ActionResult Index()
        {
            return View(homeService.GetPosts);
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