using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBook3.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {           
            return View();
        }

        [ChildActionOnly]
        public PartialViewResult CateProduct()
        {
            var model = new CategoryDao().Listcate();
            return PartialView(model);
        }
        public ActionResult Category(string cateID)
        {
            var model = new CategoryDao().ViewDetail(cateID);
            ViewBag.CateID = new ProductDao().ListCateID(cateID);
            return View(model);
        }

        public ActionResult Detail(string productID)
        {
            var product = new ProductDao().ViewDetail(productID);
            ViewBag.RelatedPro = new ProductDao().ListRelatedProducts(productID);
            ViewBag.WriterPro = new WriterDao().ViewDetail(product.WriterID);
            ViewBag.CateProduct = new CategoryDao().ViewDetail(product.CategoryID);
            ViewBag.NxbPro = new NXBDao().ViewDetail(product.NxbID);
            return View(product);
        }
    }
}