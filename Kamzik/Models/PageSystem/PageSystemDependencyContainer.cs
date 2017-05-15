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


namespace Kamzik.Models.PageSystem
{
    public class PageSystemDependencyContainer
    {
        PrimaryEntities defaultConnection = null;

        public PageSystemDependencyContainer()
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
    }
}