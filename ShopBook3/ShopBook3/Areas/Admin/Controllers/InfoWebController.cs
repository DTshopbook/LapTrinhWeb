using Model.Dao;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBook3.Areas.Admin.Controllers
{
    public class InfoWebController : BaseController
    {
        // GET: Admin/InfoWeb
        public ActionResult Index(int page = 1, int pagelist = 1)
        {
            var dao = new InfoWebsiteDao();
            var model = dao.ListAllPaging(page,pagelist);
            return View(model);
        }

        [HttpGet]
        public ActionResult Edit(string name)
        {
            var web = new InfoWebsiteDao().ViewDetail(name);
            return View(web);
        }
        [HttpPost]
        public ActionResult Edit(InfoWebsite webname)
        {
            if (ModelState.IsValid)
            {
                var dao = new InfoWebsiteDao();
                var result = dao.Update(webname);
                if (result)
                {
                    return RedirectToAction("Index", "InfoWeb");
                    //Response.Write("<script>alert('Chỉnh sửa thành công !');window.location = '/Admin/InfoWeb/Index';</script>");
                }
                else
                {
                    Response.Write("<script>alert('Thất bại !');</script>");
                }
            }
            return View("Index");
        }



    }
}