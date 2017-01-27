using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using SimpleBlog.Controllers;

namespace SimpleBlog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //not working??
            //routes.MapRoute("Home", "", new { contoller = "Posts", action = "Index" });

            //this stores a string array of possibly confolicting PostCotrollers in differing areas to use in the routing below
            //when passed in it makes sure the routes use the correct namespace and therefore correct controller - action 
            var namespaces = new[] { typeof(PostsController).Namespace };

            //Login Route
            routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "Auth", action = "Login" },
                namespaces: namespaces
            );

            //Home Route
            routes.MapRoute(
                name: "Home",
                url: "",
                defaults: new { controller = "Posts", action = "Index"},
                namespaces: namespaces
            );

            //Default
            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);
        }
    }
}
