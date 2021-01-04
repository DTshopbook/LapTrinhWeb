using Facebook;
using Model.Dao;
using Model.EF;
using ShopBook3.Common;
using ShopBook3.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
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
                    //Response.Write("<script>alert('Đăng nhập thành công');window.location = '/';</script>");
                    return RedirectToAction("Index","Home");
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
                    //Response.Write("<script>alert('Data inserted successfully')</script>");
                    ModelState.AddModelError("", "Tên đăng nhập đã tồn tại !");
                }
                else if (dao.CheckEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email đã tồn tại !");
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
                        ViewBag.Success = "Đăng ký thành công !";
                        model = new RegisterModel();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Đăng ký không thành công!");
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
        private Uri RedirectUri
        {
            get
            {
                var uriBuilder = new UriBuilder(Request.Url);
                uriBuilder.Query = null;
                uriBuilder.Fragment = null;
                uriBuilder.Path = Url.Action("FacebookCallback");
                return uriBuilder.Uri;
            }
        }
        public ActionResult LoginFacebook()
        {
            var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
            {
                client_id = ConfigurationManager.AppSettings["FbAppId"],
                client_secret = ConfigurationManager.AppSettings["FbAppSecret"],
                redirect_uri = RedirectUri.AbsoluteUri,
                response_type = "code",
                scope = "email",
            });

            return Redirect(loginUrl.AbsoluteUri);
        }

        public ActionResult FacebookCallback(string code)
        {
            var fb = new FacebookClient();
            dynamic result = fb.Post("oauth/access_token", new
            {
                client_id = ConfigurationManager.AppSettings["FbAppId"],
                client_secret = ConfigurationManager.AppSettings["FbAppSecret"],
                redirect_uri = RedirectUri.AbsoluteUri,
                code = code
            });


            var accessToken = result.access_token;
            if (!string.IsNullOrEmpty(accessToken))
            {
                fb.AccessToken = accessToken;
                // Get the user's information, like email, first name, middle name etc
                dynamic me = fb.Get("me?fields=first_name,middle_name,last_name,id,email");
                string email = me.email;
                string userName = me.email;
                string firstname = me.first_name;
                string middlename = me.middle_name;
                string lastname = me.last_name;

                var user = new User();
                user.Email = email;
                user.Username = "dtsb"+firstname+middlename;
                user.Statuss = true;                
                user.CreateDate = DateTime.Now;
                user.Rank = 0;
                var resultInsert = new UserDao().InsertForFacebook(user);
                if (resultInsert != null)
                {
                    var userSession = new UserLogin();
                    userSession.Username = user.Username;
                    Session.Add(Common.Constant.USER_SESSION, userSession);
                }
            }
            return Redirect("/");
        }

    }
}