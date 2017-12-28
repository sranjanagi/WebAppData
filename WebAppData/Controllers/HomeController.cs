using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppData.Models;

namespace WebAppData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TestingEntities db = new TestingEntities();
            ;
            tblEmployee employee = db.tblEmployees.SingleOrDefault(x => x.id == 1);


            Employee employeevm = new Employee();

            employeevm.id = employee.id;
            employeevm.Name = employee.Name;
            employeevm.Salary = employee.Salary;
            employeevm.DepartmentId = employee.DepartmentId;
            
           
            //  return ViewResult();
            //return View(lstEmployee);
            //return View(lstEmployee);

            //lstEmployee.Add("hello");
            /// return View(employeevm);

            return View(employeevm);
            // return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}