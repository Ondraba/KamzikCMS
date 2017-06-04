using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kamzik.Models.PageSystem
{
    public class Packages
    {
        public List<KeyValuePair<string, string>> _p_page()
        {
            var package = new List<KeyValuePair<string, string>>();
            package.Add(new KeyValuePair<string, string>("header", "kamzik-header-standard"));
            package.Add(new KeyValuePair<string, string>("menu", "kamzik-menu-standard"));
            return package;
        }

        public List<KeyValuePair<string, string>> _p_list()
        {
            var package = new List<KeyValuePair<string, string>>();
            package.Add(new KeyValuePair<string, string>("header", "kamzik-header-standard"));
            package.Add(new KeyValuePair<string, string>("menu", "kamzik-menu-standard"));
            return package;
        }
    }
}

//idea..zkusit udelat slozitejsi strukturu ktera bude definovat i css pathy atd ..widgety