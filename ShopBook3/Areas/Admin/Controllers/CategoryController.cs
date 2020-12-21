using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using ShopBook3.Common;

namespace ShopBook3.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Admin/Category
        public ActionResult Index(int page = 1, int pagelist = 10)
        {
            var dao = new CategoryDao();
            var model = dao.ListAllPaging(page, pagelist);
            //ViewBag.SearchString = searchString;
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateCate()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditCate(string name)
        {
            var cate = new CategoryDao().ViewDetail(name);
            return View(cate);
        }
        [HttpPost]
        public ActionResult Create(Category cate)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryDao();
                string name = dao.Insert(cate);
                if (name != null)
                {
                    //SetAlert("Successful !", "success");
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    ModelState.AddModelError("", "Not Success !");
                }
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult Edit(Category cate)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryDao();
                var result = dao.Update(cate);
                if (result)
                {
                    //SetAlert("Success Update User !", "success");
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    ModelState.AddModelError("", "Not Successful !");
                }
            }
            return View("Index");
        }

        [HttpDelete]
        public ActionResult Delete(string cateID)
        {
            new CategoryDao().Delete(cateID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult ChangeStatus(string id)
        {
            var result = new UserDao().ChangeStatus(id);
            return Json(new
            {
                status = result
            });
        }

    }
}