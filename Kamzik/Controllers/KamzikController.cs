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
    public class KamzikController : Controller
    {
        private PageSystemDependencyContainer PSD = new PageSystemDependencyContainer();
        private PrimaryEntities _db;

        public KamzikController()
        {
            _db = PSD.getDefaultConnection();
        }

        public ActionResult getFullPageList()
        {
            return View(PSD.getPageProcessSystem().getFullPageList());
        }

        public ActionResult Details(int id, string type)
        {
            PSD.getPageProcessSystem().pageRenderStart(id,type);  
            return View(_db.T_KAMZIK_PAGE.Find(id));
        }
    }
}