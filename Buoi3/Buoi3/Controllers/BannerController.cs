using Buoi3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi3.Controllers
{
    public class BannerController : Controller
    {
        TMĐTEntities db = new TMĐTEntities();
        // GET: Banner
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HeaderBanner()
        {
            var headerBanner = db.Banners.Where(c => c.Name == "Header").FirstOrDefault();
            return PartialView(headerBanner);
        }
        public ActionResult LeftBanner()
        {
            var leftBanner = db.Banners.Where(c => c.Name == "Left").FirstOrDefault();
            return PartialView(leftBanner);
        }
        public ActionResult RightBanner()
        {
            var rightBanner = db.Banners.Where(c => c.Name == "Right").FirstOrDefault();
            return PartialView(rightBanner);
        }
    }
}