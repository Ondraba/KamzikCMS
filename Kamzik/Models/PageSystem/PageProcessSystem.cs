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


namespace Kamzik.Models.PageSystem
{
    public class PageProcessSystem
    {
        private PrimaryEntities _db;

        public PageProcessSystem(PrimaryEntities _db)
        {
            this._db = _db;
        }

        public IEnumerable<T_KAMZIK_PAGE> getFullPageList()
        {
            return _db.T_KAMZIK_PAGE.ToList();
        }

        public bool pageHealthCheck(int id)
        {
            bool okStatus = false;
            var pageToFind = _db.T_KAMZIK_PAGE.Find(id);
            if (pageToFind != null)
            {
                okStatus = true;
            }
            return okStatus;
        }

        public void pageRenderStart(int id, string type)
        {
            if (pageHealthCheck(id))
            {
                switch (type)
                {
                    case "ROOT":
                        { };
                        break;
                    case "LIST":
                        { };
                        break;
                    case "PAGE":
                        { };
                        break;
                    default:
                        { };
                        break;
                    
                }
            }
        }

        


    }
}