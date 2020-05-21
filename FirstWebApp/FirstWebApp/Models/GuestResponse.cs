using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FirstWebApp;



namespace LuxorDemo.Models
{
    public class GuestResponse : IGuestResponse
    {
        public string Name { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public bool? WillAttend { set; get; }
    }
}