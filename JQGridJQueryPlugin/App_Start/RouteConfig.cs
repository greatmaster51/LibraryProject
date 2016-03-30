using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JQGridJQueryPlugin
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                url: "{controller}/{action}/{id}",
                // Thuoc tinh name va controller co the doi tuong ung theo danh sach controller;

                name: "Book",
                defaults: new { controller = "Book", action = "Index", id = UrlParameter.Optional }
                //name: "User",
                //defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}