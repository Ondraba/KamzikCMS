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
        private ClassManagerIoC _classManager = new ClassManagerIoC();
        private PrimaryEntities _db;

        public KamzikController()
        {
            _db = _classManager.getDefaultConnection();
        }

        public ActionResult getFullPageList()
        {
            return View(_classManager.getPageProcessSystem().getFullPageList());
        }

        public ActionResult renderPageTree()
        {
            return View(_classManager.getPageProcessSystem().getFullPageList());
        }

        public ActionResult renderPage(int id, string pagetype)
        {
            _classManager.getPageProcessSystem().pageRenderStart(id, pagetype);
            return View(_db.T_KAMZIK_PAGE.Find(id));
        }

        public ActionResult Details(int id, string type)
        {
            _classManager.getPageProcessSystem().pageRenderStart(id,type);  
            return View(_db.T_KAMZIK_PAGE.Find(id));
        }

        public ActionResult ShowCreatePageForm()
        {
            return View();
        }

        [HttpPost]
        public void CreateAjaxPage(int? motherId, string systemName, string pageType, int? FK_PACKAGES_ID)
        {
            _classManager.get_R_T_KAMZIK_PAGE().createNewPage(motherId, systemName, pageType, FK_PACKAGES_ID);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //[Authorize]
        //public ActionResult CreatePage(int? motherId, string systemName, string pageType, int? FK_PACKAGES_ID)
        //{
        //    return View();
        //}
        [HttpPost]
        public ActionResult SaveDetailedInfo(string test)
        {
            return View();
        }
    }
}