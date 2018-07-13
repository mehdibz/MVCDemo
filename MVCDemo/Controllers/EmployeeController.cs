using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Details()
        {
            Employee employee = new Employee();
            employee.EmployeeId = 101;
            employee.Name = "John";
            employee.Gender = "Male";
            employee.City = "London";

            return View(employee);
        }
    }
}