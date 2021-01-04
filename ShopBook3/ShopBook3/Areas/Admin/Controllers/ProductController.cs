using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using ShopBook3.Common;
using System.Xml.Linq;
using System.Web.Script.Serialization;
using OfficeOpenXml.Core.ExcelPackage;

namespace ShopBook3.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Admin/Category
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Index(string searchString, int page = 1, int pagelist = 5)
        {
            var dao = new ProductDao();
            var model = dao.ListAllPaging(searchString, page, pagelist);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditProduct(string ProductID)
        {
            var product = new ProductDao().ViewDetail(ProductID);
            return View(product);
        }
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDao();

                string name = dao.Insert(product);
                if (name != null)
                {
                    //Response.Write("<script>alert('Thêm thành công !');window.location = '/Admin/Product/Index';</script>");                    
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    Response.Write("<script>alert('Thất bại !');</script>");
                }
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var dao = new ProductDao();
                var result = dao.Update(product);
                if (result)
                {
                    Response.Write("<script>alert('Chỉnh sửa thành công !');window.location = '/Admin/Product/Index';</script>");
                }
                else
                {
                    Response.Write("<script>alert('Thất bại');</script>");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(string id)
        {
            new ProductDao().Delete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult ChangeStatus(string proID)
        {
            var result = new ProductDao().ChangeStatus(proID);
            return Json(new
            {
                status = result
            });
        }
    }
}