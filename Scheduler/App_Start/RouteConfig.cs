using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Scheduler
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute(
                "Default",                                              
                "{controller}/{action}",                         
                new { controller = "Home", action = "Index" }  
            );
            routes.MapRoute(
               "WithDate",                                         
               "Tasks/Create/{month}/{date}/{year}",
               new { controller = "Tasks", action = "CreateForDate"} 
           );
            routes.MapRoute(
   "GetEdit",
   "Tasks/Edit/{id}",
   new { controller = "Tasks", action = "Edit" }
);
        }
    }
}
