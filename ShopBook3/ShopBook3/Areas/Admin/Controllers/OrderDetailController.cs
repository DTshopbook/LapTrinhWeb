using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBook3.Areas.Admin.Controllers
{
    public class OrderDetailController : BaseController
    {
        // GET: Admin/Order
        public ActionResult Index(int page = 1, int pagelist = 5)
        {
            var dao = new OrderDetailDao();
            var model = dao.ListAllOrder(page, pagelist);
            //ViewBag.SearchString = searchString;
            return View(model);
        }


    }
}