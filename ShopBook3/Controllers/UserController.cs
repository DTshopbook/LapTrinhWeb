using Model.Dao;
using Model.EF;
using ShopBook3.Common;
using ShopBook3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace ShopBook3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, Encrypt.MD5Hash(model.Password));
                if (result)
                {
                    var user = dao.GetByID(model.UserName);
                    var userSession = new UserLogin();
                    userSession.Username = user.Username;
                    Session.Add(Constant.USER_SESSION, userSession);
                    Response.Write("<script>alert('Đăng nhập thành công');window.location = '/';</script>");
                }
                else 
                {
                    Response.Write("<script>alert('Tên đăng nhập hoặc mật khẩu không đúng !');window.location = '/login';</script>");
                }

            }
            return View(model);
        }
        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.CheckUserName(model.UserName))
                {
                    ModelState.AddModelError("", "Username available !");
                }
                else
                {
                    var user = new User();
                    user.Username = model.UserName;
                    user.Pasword = Encrypt.MD5Hash(model.Password);
                    user.CreateDate = DateTime.Now;
                    user.Statuss = true;
                    user.Rank = 0;
                    user.Email = model.Email;
                    var result = dao.Insert(user);
                    if (result != null)
                    {
                        ViewBag.Success = "Success Register !";
                        model = new RegisterModel();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Registration failed !");
                    }
                }
            }
            return View(model);
        }
        public ActionResult Logout()
        {
            Session[Constant.USER_SESSION] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}