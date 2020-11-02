using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAssigment.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult admin_panel(string option)
        {
            ViewBag.Option = option;

            return View();
        }

        public ActionResult _products()
        {
            return View();
        }

        public ActionResult _addProducts()
        {
            return View();
        }


    }
}