using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestData.Models
{
    public class TestData : ITestData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { set; get; }
        public string Department { set; get; }
    }
}