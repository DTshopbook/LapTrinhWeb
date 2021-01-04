using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ShopBook3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

      //      routes.IgnoreRoute("{*botdetect}",
      //new { botdetect = @"(.*)BotDetectCaptcha\.ashx" });
          routes.MapRoute(
                name: "Login",
                url: "login",
                defaults: new { controller = "User", action = "Login", id = UrlParameter.Optional },
                namespaces: new string[] { "ShopBook3.Controllers" }
            );
            routes.MapRoute(
                name: "About",
                url: "about",
                defaults: new { controller = "Home", action = "About", id = UrlParameter.Optional },
                namespaces: new string[] { "ShopBook3.Controllers" }
            );
            routes.MapRoute(
                name: "CategoryByID",
                url: "Category/{cateID}",
                defaults: new { controller = "Product", action = "Category", id = UrlParameter.Optional },
                namespaces: new string[] { "ShopBook3.Controllers" }
            );
            routes.MapRoute(
                name: "Success",
                url: "success",
                defaults: new { controller = "Cart", action = "Success", id = UrlParameter.Optional },
                namespaces: new string[] { "ShopBook3.Controllers" }
            );
            routes.MapRoute(
                name: "Payment Cart",
                url: "payment",
                defaults: new { controller = "Cart", action = "Payment", id = UrlParameter.Optional },
                namespaces: new string[] { "ShopBook3.Controllers" }
            );
            routes.MapRoute(
                name: "Cart",
                url: "cart",
                defaults: new { controller = "Cart", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "ShopBook3.Controllers" }
            );
            routes.MapRoute(
                name: "Add Cart",
                url: "add-to-cart",
                defaults: new { controller = "Cart", action = "AddProduct", id = UrlParameter.Optional },
                namespaces: new string[] { "ShopBook3.Controllers" }
            );
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Product Detail",
                url: "product/{action}/{productID}",
                defaults: new { controller = "Product", action = "Detail", id = UrlParameter.Optional },
                namespaces: new string[] { "ShopBook3.Controllers" }
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] {"ShopBook3.Controllers"}
            );
        }
    }
}
