using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class IndexController : Controller

    {
        public static List<ToDoListResponse> todo = new List<ToDoListResponse>()
    {
            new ToDoListResponse() { ID = 1, Description = "taks1" ,Status = "Not Start"},
            new ToDoListResponse() { ID = 2,Description = "taks1",Status = " Start"}
        };

        


        public ActionResult Index()
        {
            ViewBag.mylist = todo;
            return View("Index");
        }
        public ActionResult callchangeFun(int todoid, int Status)
        {
            ToDoListResponse _todo = todo.First(t => t.ID == todoid);

            if (Status == 1)
            {
                if (_todo.Status == "Not Start")
                    _todo.Status = "Start";


            }
            else if (Status == 5)
            {

                _todo.Status = "End";
            }
            ViewBag.mylist = todo;
            return View("index");
        }
        [HttpPost]
        public ActionResult Add(ToDoListResponse usertodo)
        {
            usertodo.Status = "Not Start";
            usertodo.ID = 2;

            todo.Add(usertodo);


            ViewBag.mylist = todo;
            return View("index");
        }
        public ActionResult Delete(int id)
        {
            if ( todo != null ) 
                {
                ToDoListResponse _todo = todo.First(t => t.ID == id);


                todo.Remove(_todo);
               
                }
            ViewBag.mylist = todo;
            return View("index");


        }
    }
}