using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestData.Models;

namespace TestData.Controllers
{
    public class TestTempData : Controller
    {
        public static List<TestTempData> T = new List<TestTempData>()
    {
            new TestTempData() { },
            new TestTempData() { }
        };



        public ActionResult Index()
        {
            ViewBag.mylist = T;
            return View("Index");
        }

        [HttpPost]
        public ActionResult AddEmployee()
        {

            return View("index");
        }
        public ActionResult Details(int id)
        {

            return View("index");


        }
    }
}