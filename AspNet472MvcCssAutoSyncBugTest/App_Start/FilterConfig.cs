﻿using System.Web;
using System.Web.Mvc;

namespace AspNet472MvcCssAutoSyncBugTest
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
