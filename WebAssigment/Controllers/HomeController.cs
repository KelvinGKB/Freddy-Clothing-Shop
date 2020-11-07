using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization; // for serialize and deserialize  
using System.IO; // for File operation  
using WebAssigment.Models;
using System.Web.WebPages.Html;

namespace WebAssigment.Controllers
{
    public class HomeController : Controller
    {
        DBEntities db = new DBEntities();
        Setting setting = new Setting();
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

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            var user = db.Users.Where(u => u.Username == model.Username && u.Password == model.Password);

            if (user.Count()==0)
            {
                return Json(new { result = false }, JsonRequestBehavior.AllowGet);
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User model)
        {

            if (!setting.IsValidEmail(model.Email))
            {
                ModelState.AddModelError("Email", "Invalid Email Format.");
            }

            if (ModelState.IsValid)
            {
                bool role = true;
                int id = setting.GenerateId(model);

                User user = new User
                {
                    Id = id,
                    Name = null,
                    Email = model.Email,
                    ProfileURL = null,
                    ContactNo = null,
                    BirthDate = null,
                    Gender = null,
                    Username = model.Username,
                    Password = model.Password,
                    Role = role
                };
                db.Users.Add(user);
                db.SaveChanges();

                return Json(new { result = true }, JsonRequestBehavior.AllowGet);
            }

            return View(model);
        }
    }
}