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
        //GET: Admin/Order
        public ActionResult Index(int page = 1, int pagelist = 5)
        {
            var dao = new OrderDao();
            var model = dao.ListAllOrder(page, pagelist);
            //ViewBag.SearchString = searchString;
            return View(model);
        }
        //public ActionResult Index()
        //{
        //    var list = new OrderDao().ListOder();
        //    ViewBag.PageCount = Math.Ceiling(1.0 * list.Count / 5);
        //    return View();
        //}
        //public ActionResult Paginate(int page = 0, int pagelist = 5)
        //{
        //    var list = new OrderDao().ListOder();
        //    return PartialView(list.Skip(page * pagelist).Take(pagelist));
        //}

        [HttpPost]
        public JsonResult ChangeStatus(long ID)
        {
            var result = new OrderDao().ChangeStatus(ID);
            return Json(new
            {
                status = result
            });
        }
    }
}