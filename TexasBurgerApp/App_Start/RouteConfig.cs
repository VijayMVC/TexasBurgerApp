using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TexasBurgerApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "AddBun",
                "{controller}/{action}/{id}",
                new
                {
                    controller = "Burger",
                    action = "Index",
                    id = ""
            });
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Burger", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
