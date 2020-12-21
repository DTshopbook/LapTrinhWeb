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

namespace ShopBook3.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Admin/Category
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Index(int page = 1, int pagelist = 3)
        {
            var dao = new ProductDao();
            var model = dao.ListAllPaging(page, pagelist);
            //ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult CreateProduct()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditProduct(string proID)
        {
            var product = new ProductDao().ViewDetail(proID);
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
                    SetAlert("Success Add Product !", "success");
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Not Success!");
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
                    SetAlert("Success Update Product !", "success");
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Not Success !");
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
        //public void SetViewBag(long? selectedId = null)
        //{
        //    var dao = new ProductCategoryDao();
        //    ViewBag.CategoryID = new SelectList(dao.ListAll(), "ID", "Name", selectedId);
        //}
    }
}