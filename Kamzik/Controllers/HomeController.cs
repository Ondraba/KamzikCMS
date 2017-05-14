using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Kamzik.Models;
using Kamzik.Models.PageSystem;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Net;
using System.Data;

namespace Kamzik.Controllers
{
    public class HomeController : Controller
    {
        private PageSystemDependencyContainer PSD = new PageSystemDependencyContainer();
        private PrimaryEntities _db; 

        public HomeController()
        {
            _db = PSD.getDefaultConnection();
        }

        public ActionResult Index()
        {
            return View(_db.PageTest.ToList());
        }

        public ActionResult GetPages()
        {
            return View(_db.PageTest.ToList());
        }

        public ActionResult CreateTestPage()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTestPage(PageTest pagetest)
        {
            return View();
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