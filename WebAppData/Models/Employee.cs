using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppData.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Salary { get; set; }
        public string DepartmentId { get; set; }

    }
}