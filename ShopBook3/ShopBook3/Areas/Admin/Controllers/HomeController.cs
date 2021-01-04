using System.Collections.Generic;
using System.Web.Mvc;
using ShopBook3.Areas.Admin.Models;
using Newtonsoft.Json;
using Model.Dao;
using System.Linq;
using Model.EF;

namespace ShopBook3.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult ChartOfOrder()
        {
            
            List<DataPoint> dataPoints = new List<DataPoint>();
            var items = new OrderDetailDao().ListOderDetail();
            var proID = items.GroupBy(x => new {x.ProductID})
                .Select(x => new { proID = x.Select(y => y.ProductID).FirstOrDefault(), amount = x.Sum(y => y.Amount)}).ToList();

            foreach (var pro in proID)
            {
                dataPoints.Add(new DataPoint(pro.proID, pro.amount));
            }
            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);
            return View();
        }

        public ActionResult Total()
        {
            var items = new OrderDetailDao().ListOderDetail();
            var custumer = new UserDao().ListCus();
            int totalAmount = 0;
            double totalMoney = 0;
            int totalcus = 0;
            foreach (var item in items)
            {
                totalAmount += item.Amount;
                totalMoney += item.Total;
            }
            foreach(var cus in custumer)
            {
                totalcus++;
            }
            ViewBag.TotalAmount = totalAmount;
            ViewBag.TotalMoney = totalMoney.ToString("N0");
            ViewBag.TotalCus = totalcus;

            //Vẽ biểu đồ doanh thu
            List<DataPoint> dataPoints = new List<DataPoint>();
            //var items = new OrderDetailDao().ListOderDetail();
            var proID = items.GroupBy(x => new { x.ProductID })
                .Select(x => new { proID = x.Select(y => y.ProductID).FirstOrDefault(), amount = x.Sum(y => y.Amount) }).ToList();

            foreach (var pro in proID)
            {
                dataPoints.Add(new DataPoint(pro.proID, pro.amount));
            }
            ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

            return View();
        }
        [ChildActionOnly]
        public ActionResult LeftMenu()
        {
            return PartialView();
        }

        public ActionResult GetDataOfPro()
        {
            var pro = new ProductDao().Listproduct().ToString();
            return Json(pro, JsonRequestBehavior.AllowGet);              
        }
    }
}