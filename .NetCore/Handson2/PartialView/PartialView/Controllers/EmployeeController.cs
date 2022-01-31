using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartialView.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PartialView.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employee> e = new List<Employee>()
            {
                new Employee{Id=1,Name="John",Salary=10000,IsPermanant=true},
                new Employee{Id=2,Name="Smith",Salary=5000,IsPermanant=false}
            };
            return View(e);
        }
    }
}
