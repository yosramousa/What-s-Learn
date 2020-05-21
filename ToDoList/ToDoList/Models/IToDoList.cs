using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoList.Models
{
    public interface IToDoList
    {

        string Description { set; get; }
        string Status { set; get; }
           }
}