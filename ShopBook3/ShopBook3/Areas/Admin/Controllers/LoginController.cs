using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShopBook3.Areas.Admin.Models;
using Model.Dao;
using ShopBook3.Common;
using Model.EF;

namespace ShopBook3.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.LoginAdmin(model.UserName, Encrypt.MD5Hash(model.Password));
                if(result)
                {
                    var user = dao.GetByID(model.UserName);
                    var userSession = new UserLogin();
                    userSession.Username = user.Username;
                    Session.Add(Constant.USER_SESSION, userSession);
                    return RedirectToAction("Total", "Home");
                    //Response.Write("<script>alert('Đăng nhập thành công');window.location = '/Admin/Home/Total';</script>");
                }
                else
                {
                    Response.Write("<script>alert('Tên đăng nhập hoặc mật khẩu không đúng !');</script>");
                }
            }
            return View("Index");
        }

    }
}