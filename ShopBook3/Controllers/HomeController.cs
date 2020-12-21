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
        public ActionResult Index(int page = 1, int pagelist = 6)
        {
            var productdao = new ProductDao();
            var model = productdao.ListAllPaging(page, pagelist);           
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult Slider()
        {
            var slide = new ProductDao().Listproduct();
            return PartialView(slide);
        }
        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            var model = new MenuDao().List(1);
            return PartialView(model);
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

        public ActionResult About()
        {
            return View();
        }
    }
}