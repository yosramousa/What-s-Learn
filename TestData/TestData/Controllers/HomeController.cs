using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestData.Models;

namespace TestData.Controllers
{
    public class HomeController : Controller
    {
        companyDataContext c = new companyDataContext();

        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {

            return View();

        }
        public ActionResult TestTempData()
        {
            if (Session["userInfo"] != null)
            {
                var index = c.employees.Select(i => i);
                ViewBag.mylist = index;
                return View();
            }

            return RedirectToAction("Index");

        }


        [HttpPost]
        public ActionResult login()
        {
            string name = Request.Form["UserName"].ToString();
            string pass = Request.Form["Password"].ToString();
            var emp = c.employees.FirstOrDefault(i => i.UserName == name && i.Password == pass);
            if (emp != null)

            {
                LoginModel l = new LoginModel() { UserName = name, Password = pass };
                Session["userInfo"] = l;

                return RedirectToAction("TestTempData");

            }


            return RedirectToAction("Index");

        }

        public ActionResult Add()
        {
            if (Session["UserInfo"] == null)
                return RedirectToAction("Index");
            var deps = c.Departments.Select(d => d);
            List<SelectListItem> ls = new List<SelectListItem>();

            foreach (var temp in deps)
            {
                ls.Add(new SelectListItem() { Text = temp.Name, Value = temp.ID.ToString() });
            }

            ViewBag.DepList = ls;







            return View();
        }
        [HttpPost]
        public ActionResult Add(employee emp)
        {
            if (Session["UserInfo"] == null)
                return RedirectToAction("Index");
            if (!ModelState.IsValid)
            {
                var deps = c.Departments.Select(d => d);
                List<SelectListItem> ls = new List<SelectListItem>();

                foreach (var temp in deps)
                {
                    ls.Add(new SelectListItem() { Text = temp.Name, Value = temp.ID.ToString() });
                }

                ViewBag.DepList = ls;
                return View();
            }
            c.employees.InsertOnSubmit(emp);
            c.SubmitChanges();


            return RedirectToAction("TestTempData");
        }
        public ActionResult Details(int id)
        {
            if (Session["UserInfo"] == null)
                return RedirectToAction("Index");
            var emp = c.employees.FirstOrDefault(e => e.ID == id);
            if (emp != null)
            {
                return View(emp);
            }
            return RedirectToAction("TestTempData");


        }
        public ActionResult Delete(int id)
        {
            if (Session["UserInfo"] == null)
                return RedirectToAction("Index");
            var emp = c.employees.FirstOrDefault(e => e.ID == id);
            if (emp != null)
            {
                c.employees.DeleteOnSubmit(emp);
                c.SubmitChanges();
            }


            return RedirectToAction("TestTempData");

        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            if (Session["UserInfo"] == null)
                return RedirectToAction("Index");
            var emp = c.employees.FirstOrDefault(e => e.ID == id);
            if (emp != null)
            {
                var deps = c.Departments.Select(d => d);
                List<SelectListItem> ls = new List<SelectListItem>();

                foreach (var temp in deps)
                {
                    ls.Add(new SelectListItem() { Text = temp.Name, Value = temp.ID.ToString() });
                }

                ViewBag.DepList = ls;
                return View(emp);
            }


            return RedirectToAction("TestTempData");

        }
        [HttpPost]
        public ActionResult Update(employee em)
        {
            if (Session["UserInfo"] == null)
                return RedirectToAction("Index");
            if (!ModelState.IsValid) {
              var ee = c.employees.FirstOrDefault(e => e.ID == em.ID);

                var deps = c.Departments.Select(d => d);
                List<SelectListItem> ls = new List<SelectListItem>();

                foreach (var temp in deps)
                {
                    ls.Add(new SelectListItem() { Text = temp.Name, Value = temp.ID.ToString() });
                }

                ViewBag.DepList = ls;
                return View(ee);
            }
            var emp = c.employees.FirstOrDefault(e => e.ID == em.ID);
            emp.Name = em.Name;
            emp.Email = em.Email;
            emp.UserName = em.UserName;
            emp.Password = em.Password;

            emp.DeptID = em.DeptID;
            c.SubmitChanges();


      
            return RedirectToAction("TestTempData");
        }
    }
}