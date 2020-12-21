using System.Collections.Generic;
using System.Web.Mvc;
using ShopBook3.Areas.Admin.Models;
using Newtonsoft.Json;
using Model.Dao;
namespace ShopBook3.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        // GET: Admin/Home
        public ActionResult ChartOfOrder()
        {
            List<DataPoint> dataPoints = new List<DataPoint>();
            var items = new OrderDetailDao().ListOderDetail();
            List<int> total = new List<int>();


            foreach (var item in items)
            {
                dataPoints.Add(new DataPoint(item.ProductID, item.Amount));
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
            return View();
        }
        [ChildActionOnly]
        public ActionResult LeftMenu()
        {
            return PartialView();
        }

    }
}