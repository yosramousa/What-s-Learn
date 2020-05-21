using ITIProject.Organization.Services;
using ITIProject.Organization.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ITIProject.Organization.Presentation.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService studentService;
        public StudentController(StudentService _studentService)
        {
            studentService = _studentService;
        }

        [HttpGet]
        public ActionResult Get(int id, string name, string phone, int pageIndex, int pageSize = 20)
        {
            //var students =
            //    studentService.Get(id, name, phone, pageIndex, pageSize);
            return View();

        }
        [HttpGet]
        public ActionResult Post()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Post(StudentEditViewModel editModel)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            studentService.Add(editModel);
            return RedirectToAction("Get");
        }
        [HttpGet]
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(StudentEditViewModel editModel)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            studentService.Update(editModel);
            return RedirectToAction("Get");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            studentService.Remove(id);
            return RedirectToAction("Get");
        }
        [HttpGet]
        public ActionResult GetByID(int id)
        {
            return View(studentService.GetByID(id));
        }
    }
}
