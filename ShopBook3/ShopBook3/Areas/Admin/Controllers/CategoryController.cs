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
        public ActionResult Index(int page = 1, int pagelist = 5)
        {
            var dao = new CategoryDao();
            var model = dao.ListAllPaging(page, pagelist);           
            return View(model);
        }

        [HttpGet]
        public ActionResult CreateCate()
        {
            return View();
        }
        [HttpGet]
        public ActionResult EditCate(string ID)
        {
            var cate = new CategoryDao().ViewDetail(ID);
            return View(cate);
        }
        [HttpPost]
        public ActionResult Create(Category cate)
        {
            if (ModelState.IsValid)
            {
                var dao = new CategoryDao();
                cate.Statuss = true;
                string name = dao.Insert(cate);
                if (name != null)
                {                   
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    Response.Write("<script>alert('Thất bại !');</script>");
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
                    
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    Response.Write("<script>alert('Thất bại !');</script>");
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
        public JsonResult ChangeStatus(string cateID)
        {
            bool result = new CategoryDao().ChangeStatus(cateID);
            return Json(new
            {
                status = result
            });
        }


    }
}