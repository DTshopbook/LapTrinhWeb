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
using System.Web.Script.Serialization;

namespace ShopBook3.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[Constant.CART_SESSION];
            var list = new List<CartProduct>();
            if (cart != null)
            {
                list = (List<CartProduct>)cart;
            }
            return View(list);
        }
        public ActionResult AddProduct(string productID, int amount)
        {
            var product = new ProductDao().ViewDetail(productID);
            var cart = Session[Constant.CART_SESSION];
            if (cart != null)
            {
                var list = (List<CartProduct>)cart;
                if (list.Exists(x => x.Product.ProductID == productID))
                {

                    foreach (var item in list)
                    {
                        if (item.Product.ProductID == productID)
                        {
                            item.Amount += amount;
                        }
                    }
                }
                else
                {
                    //Create new item
                    var item = new CartProduct();
                    item.Product = product;
                    item.Amount = amount;
                    list.Add(item);
                }
                //Gán vào session
                Session[Constant.CART_SESSION] = list;
            }
            else
            {
                //Create new item
                var item = new CartProduct();
                item.Product = product;
                item.Amount = amount;
                var list = new List<CartProduct>();
                list.Add(item);

                //Gán vào session
                Session[Constant.CART_SESSION] = list;
            }

            return RedirectToAction("Detail", "Product", new { ID = productID });
        }

        public JsonResult Update(string cartModel)
        {           
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartProduct>>(cartModel);
            var sessionCart = (List<CartProduct>)Session[Constant.CART_SESSION];
            foreach (var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.Product.ProductID == item.Product.ProductID && x.Product.Amount < item.Amount);
                if (jsonItem != null)
                {
                    item.Amount = jsonItem.Amount;
                }
            }
            Session[Constant.CART_SESSION] = sessionCart;
            return Json(new
            {
                status = true
            });
        }

        public JsonResult Delete(string productID)
        {
            var sessionCart = (List<CartProduct>)Session[Constant.CART_SESSION];
            sessionCart.RemoveAll(x => x.Product.ProductID == productID);
            Session[Constant.CART_SESSION] = sessionCart;
            return Json(new
            {
                status = true
            });
        }
        public JsonResult DeleteCart()
        {
            Session[Constant.CART_SESSION] = null;
            return Json(new
            {
                status = true
            });
        }

        [HttpGet]
        public ActionResult Payment()
        {
            var cart = Session[Constant.CART_SESSION];
            var user = (UserLogin)Session[Constant.USER_SESSION];
            if (user != null)
            {
                var list = new List<CartProduct>();
                if (cart != null)
                {
                    list = (List<CartProduct>)cart;
                }
                return View(list);
            }
            else
            {
                return Redirect("/login");
            }
        }

        [HttpPost]
        public ActionResult Payment(string fullname, string userphone, string useraddress, string email)
        {            
            var order = new Order();

            order.CreateDate = DateTime.Now;
            order.UserAddress = useraddress;
            order.UserPhone = userphone;
            order.UserRealName = fullname;
            order.UserEmail = email;
            order.Status = true;
            try
            {
                var orderID = new OrderDao().Insert(order);
                var sessionCart = (List<CartProduct>)Session[Constant.CART_SESSION]; 
                var detailDao = new OrderDetailDao();
                //double total = 0;
                foreach (var item in sessionCart)
                {
                    var orderDetail = new OrdersDetail();
                    orderDetail.ProductID = item.Product.ProductID;
                    orderDetail.OrderID = order.OrderID;                   
                    orderDetail.Total = Convert.ToInt32(item.Product.Price.GetValueOrDefault(0)* item.Amount);
                    orderDetail.Amount = item.Amount;
                    detailDao.Insert(orderDetail);

                    //total += (item.Product.Price.GetValueOrDefault(0) * item.Amount);
                }
                //string content = System.IO.File.ReadAllText(Server.MapPath("~/Content/Email/SendMail.html"));

                //content = content.Replace("{{CustomerName}}", fullname);
                //content = content.Replace("{{Phone}}", userphone);
                //content = content.Replace("{{Email}}", email);
                //content = content.Replace("{{Address}}", useraddress);
                //content = content.Replace("{{Total}}", total.ToString("N0"));
                //var toEmail = ConfigurationManager.AppSettings["ToEmailAddress"].ToString();

                //new Email().SendMail(email, "Đơn hàng mới từ DTBookShop", content);
                ////new Email().SendMail(toEmail, "Đơn hàng mới từ DTBookShop", content);
            }
            catch (Exception)
            {
                //ghi log
                Response.Write("<script>alert('Thất bại !')</script>");
            }
            return Redirect("/success");
        }
        public ActionResult Success()
        {
            Session[Constant.CART_SESSION] = null;
            return View();
        }   
       
    }
}