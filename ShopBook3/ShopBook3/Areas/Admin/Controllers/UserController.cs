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
    public class UserController : BaseController
    {
        // GET: Admin/User
        public ActionResult Index(string searchString, int page = 1, int pagelist = 5)
        {
            var dao = new UserDao();
            var model = dao.ListAllPaging(searchString, page, pagelist);
            ViewBag.SearchString = searchString;
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var encryptedMd5Pas = Encrypt.MD5Hash(user.Pasword);
                user.Pasword = encryptedMd5Pas;
                user.Rank = 0;
                user.Statuss = true;
                user.CreateDate = DateTime.Now;

                var name = dao.Insert(user);

                if (name != null)
                {
                    return RedirectToAction("Index", "User");
                    //Response.Write("<script>alert('Thêm thành công !');window.location = '/Admin/User/Index';</script>");                   
                }
                else
                {
                    Response.Write("<script>alert('Thất bại !');</script>");
                }
            }
            return View("Index");   
        }

        [HttpGet]
        public ActionResult EditUser(string name)
        {
            var user = new UserDao().ViewDetail(name);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (!string.IsNullOrEmpty(user.Pasword))
                {
                    var encryptedMd5Pas = Encrypt.MD5Hash(user.Pasword);
                    user.Pasword = encryptedMd5Pas;
                }
                var result = dao.Update(user);
                if (result)
                {
                    return RedirectToAction("Index", "User");
                    //Response.Write("<script>alert('Cập nhật thành công !');window.location = '/Admin/User/Index';</script>");
                }
                else
                {
                    Response.Write("<script>alert('Thất bại');</script>");
                }
            }
            return View("Index");
        }


        [HttpDelete]
        public ActionResult Delete(string username)
        {
            new UserDao().Delete(username);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public JsonResult ChangeStatus(string username)
        {
            var result = new UserDao().ChangeStatus(username);
            return Json(new
            {
                status = result
            });
        }

    }
}