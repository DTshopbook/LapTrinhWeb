using Model.Dao;
using ShopBook3.Common;
using ShopBook3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBook3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string search,int page = 1, int pagelist = 6)
        {
            var productdao = new ProductDao();
            var model = productdao.ListAllPaging(search,page, pagelist);
            ViewBag.SearchString = search;
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult Slider()
        {
            var slide = new ProductDao().Listproduct();
            return PartialView(slide);
        }

        [ChildActionOnly]
        public ActionResult MainMenu(string searchpro)
        {
            var productdao = new ProductDao().ListAllPaging(searchpro, 1, 1);
            var model = new MenuDao();
            ViewBag.Search = searchpro;
            ViewBag.Menu = model.List();
            return PartialView();
        }

        [ChildActionOnly]
        public PartialViewResult HeaderCart()
        {
            var cart = Session[Constant.CART_SESSION];
            var list = new List<CartProduct>();
            if (cart != null)
            {
                list = (List<CartProduct>)cart;
            }
            return PartialView(list);
        }


        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            var InforWeb = new InfoWebsiteDao().ListAll();
            return PartialView(InforWeb);
        }


        public ActionResult About()
        {
            return View();
        }
        public ActionResult TermOfUse()
        {
            return View();
        }
        public ActionResult Policy()
        {
            return View();
        }
        public ActionResult Ex_Re()
        {
            return View();
        }
        public ActionResult Delivery()
        {
            return View();
        }




    }
}