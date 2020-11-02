using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization; // for serialize and deserialize  
using System.IO; // for File operation  
using WebAssigment.Models;

namespace WebAssigment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult product_list(string department)
        {
            string file = Server.MapPath("~/Content/JSON/Brands.json");
            string Json = System.IO.File.ReadAllText(file);
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var brandlist = ser.Deserialize<List<Brands>>(Json);

            string file2 = Server.MapPath("~/Content/JSON/Categories.json");
            string Json2 = System.IO.File.ReadAllText(file2);
            JavaScriptSerializer ser2 = new JavaScriptSerializer();
            var cat_list = ser2.Deserialize<List<Categories>>(Json2);


            ViewBag.Department = department;
            ViewBag.Brandlist = brandlist.OrderBy(b => b.Name); // Sort By Name
            ViewBag.CatList = cat_list;


            return View();

        }


        public ActionResult product_detail()
        {
            return View();
        }


    }
}