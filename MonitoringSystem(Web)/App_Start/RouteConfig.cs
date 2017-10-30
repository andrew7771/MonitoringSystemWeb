using System;
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
                name: "toSubjectsWeb",
                url: "SubjectsWeb/{action}/{groupId}",
                defaults: new { controller = "SubjectsWeb", action = "Index", groupId = UrlParameter.Optional },
                namespaces: new string[] { "MonitoringSystem_Web_.Controllers" }
                );

            //показывает оценки для всех студентов в группе по предмету
            routes.MapRoute(
                name: "toMarksWeb",
                url: "SubjectsWeb/{action}/{groupId}/{subjectId}",
                defaults: new { controller = "SubjectsWeb", action = "Index", groupId = UrlParameter.Optional, subjectId = UrlParameter.Optional },
                namespaces: new string[] { "MonitoringSystem_Web_.Controllers" }
                );

            routes.MapRoute(
                name: "toCPMarksWeb",
                url: "SubjectCPsWeb/{action}/{groupId}/{subjectId}",
                defaults: new { controller = "SubjectCPsWeb", action = "Index", groupId = UrlParameter.Optional, subjectId = UrlParameter.Optional },
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