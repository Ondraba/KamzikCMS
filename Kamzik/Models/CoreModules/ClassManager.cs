using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Kamzik.Models.PageSystem;
using Kamzik.Models.CoreModules;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Net;
using System.Data;

namespace Kamzik.Models
{
    public class ClassManagerIoC
    {
        PrimaryEntities defaultConnection = null;

        public ClassManagerIoC()
        {
            defaultConnection = Storages.mapStorages();
        }

        public PrimaryEntities getDefaultConnection()
        {
            return defaultConnection;
        }

        public PageProcessSystem getPageProcessSystem()
        {
            PageProcessSystem pageProcessSystem = new PageProcessSystem(getDefaultConnection());
            return pageProcessSystem;
        }

        public R_T_KAMZIK_PAGE get_R_T_KAMZIK_PAGE()
        {
            R_T_KAMZIK_PAGE R_T_KAMZIK_PAGE = new R_T_KAMZIK_PAGE(getDefaultConnection());
            return R_T_KAMZIK_PAGE;
        }
    }
}