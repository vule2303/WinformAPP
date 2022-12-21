using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Eshop.Controllers
{
    public class MYCrikcetersController : Controller
    {
        // GET: MYCrikceters

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome()
        {
            ViewBag.Message = "Sachin Tendulkar"; //gọi trong phần view in ra màn hình
            return View();
        }
    }
}