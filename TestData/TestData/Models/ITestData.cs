using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestData.Models
{
    public interface ITestData
    {
      
        string Name { set; get; }
        string Email { set; get; }
        string Department { set; get; }
    }
}