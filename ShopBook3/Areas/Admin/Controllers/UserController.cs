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
        public ActionResult Index(int page = 1, int pagelist = 5)
        {
            var dao = new UserDao();
            var model = dao.ListAllPaging(page, pagelist);

            //ViewBag.SearchString = searchString;

            return View(model);
        }
        [HttpGet]
        public ActionResult CreateUser()
        {
            return View();
        }

        [HttpGet]
        public ActionResult EditUser(string username)
        {
            var user = new UserDao().ViewDetail(username);
            return View(user);
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();

                var encryptedMd5Pas = Encrypt.MD5Hash(user.Pasword);
                user.Pasword = encryptedMd5Pas; 

                string name = dao.Insert(user);
                if (name != null)
                {
                    //SetAlert("Thêm user thành công", "success");
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "User added failed !");
                }
            }
            return View("Index");
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
                    //SetAlert("Success Update User !", "success");
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "User update failed");
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