﻿using System.Web;
using System.Web.Mvc;

namespace MonitoringSystem_Web_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
