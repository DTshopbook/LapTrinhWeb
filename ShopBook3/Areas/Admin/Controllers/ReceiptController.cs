﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopBook3.Areas.Admin.Controllers
{
    public class ReceiptController : BaseController
    {
        // GET: Admin/Receipt
        public ActionResult Index()
        {
            return View();
        }
    }
}