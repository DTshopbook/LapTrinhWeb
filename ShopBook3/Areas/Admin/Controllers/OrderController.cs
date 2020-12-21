using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model.Dao;
using Model.EF;

namespace ShopBook3.Areas.Admin.Controllers
{
    public class OrderController : BaseController
    {
        // GET: Admin/Order
        public ActionResult Index(int page = 1, int pagelist = 3)
        {
            var dao = new OrderDao();
            var model = dao.ListAllOrder(page, pagelist);
            //ViewBag.SearchString = searchString;
            return View(model);
        }
    }
}