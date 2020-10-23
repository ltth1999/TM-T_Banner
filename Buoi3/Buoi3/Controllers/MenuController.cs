using Buoi3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Buoi3.Controllers
{
    public class MenuController : Controller
    {
        TMĐTEntities db = new TMĐTEntities();
        // GET: Menu
        public ActionResult Index()
        {
            var menus = db.Menus;
            return PartialView(menus);
        }
    }
}