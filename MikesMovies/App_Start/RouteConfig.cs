using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MikesMovies
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            ////Creating a route for my Test controller 
            //routes.MapRoute(
            //    name: "Test",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new
            //    {
            //        controller = "Test",
            //        action = "TestMethod",
            //        id = UrlParameter.Optional
            //    });
        }
    }
}
