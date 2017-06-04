using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kamzik.Models
{
    public class R_T_KAMZIK_PAGE
    {
        private PrimaryEntities _db;

        public R_T_KAMZIK_PAGE(PrimaryEntities _db)
        {
        this._db = _db;
        } 

        public void createNewPage(int? motherId, string systemName, string pageType, int ?FK_PACKAGES_ID)
        {
            int _motherId = motherId == null ? _motherId = 0 : _motherId = (int)motherId;
            int _FK_PACKAGES_ID = FK_PACKAGES_ID == null ? _FK_PACKAGES_ID =  0 : _FK_PACKAGES_ID = (int)FK_PACKAGES_ID;

            if (_motherId == 0)
            {
                createBlankPage(systemName, pageType, _FK_PACKAGES_ID);
            }
            else
            {
                createChildPage(_motherId, systemName, pageType, _FK_PACKAGES_ID);
            }
        }

        public T_KAMZIK_PAGE createBlankPage(string systemName, string pageType, int ?FK_PACKAGES_ID)
        {
            T_KAMZIK_PAGE newParentPage = new T_KAMZIK_PAGE();
            newParentPage.SystemName = systemName;
            newParentPage.PageType = pageType;
            newParentPage.FK_PACKAGES_ID = FK_PACKAGES_ID;
            newParentPage.PageState = "NEW";    
            return newParentPage;
        }

        public T_KAMZIK_PAGE createChildPage(int motherId, string systemName, string pageType, int ?FK_PACKAGES_ID)
        {
            T_KAMZIK_PAGE newChildPage = new T_KAMZIK_PAGE();
            newChildPage.FK_SOURCE_ID = motherId;
            newChildPage.SystemName = systemName;
            newChildPage.PageType = pageType;
            newChildPage.FK_PACKAGES_ID = FK_PACKAGES_ID;
            newChildPage.PageState = "NEW";
            return newChildPage;  
        }

    }
}