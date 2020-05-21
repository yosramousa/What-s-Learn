using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public class ToDoListResponse : IToDoList
    {
        public int ID { get; set; }
        public string Description { set; get; }
        public string Status { set; get; }
       }
}