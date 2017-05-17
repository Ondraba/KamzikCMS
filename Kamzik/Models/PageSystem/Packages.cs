using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kamzik.Models.PageSystem
{
    public class Packages
    {
        public List<KeyValuePair<string, string>> page()
        {
            var package = new List<KeyValuePair<string, string>>();
            package.Add(new KeyValuePair<string, string>("header", "primary-header"));
            package.Add(new KeyValuePair<string, string>("menu-left", "primary-menu-left"));
            return package;
        }
    }
}

//idea..zkusit udelat slozitejsi strukturu ktera bude definovat i css pathy atd ..widgety