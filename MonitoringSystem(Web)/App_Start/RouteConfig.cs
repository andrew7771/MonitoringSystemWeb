﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MonitoringSystem_Web_
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //показывает все предметы для группы
            routes.MapRoute(
                name: "toSubjects",
                url: "Subjects/{action}/{classId}",
                defaults: new { controller = "Subjects", action = "Index", classId = UrlParameter.Optional },
                namespaces: new string[] { "MonitoringSystem_Web_.Controllers" }
                );

            routes.MapRoute(
                name: "toMarks",
                url: "Subjects/{action}/{classId}/{subjectId}",
                defaults: new { controller = "Subjects", action = "Index", classId = UrlParameter.Optional, subjectId = UrlParameter.Optional },
                namespaces: new string[] { "MonitoringSystem_Web_.Controllers" }
                );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "MonitoringSystem_Web_.Controllers" }
            );
        }
    }
}