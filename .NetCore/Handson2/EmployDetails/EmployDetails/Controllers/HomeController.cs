using EmployDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployDetails.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetDetails()
        {
            List<Employee> e = new List<Employee>()
{
new Employee { Id = 1, Name = "John", Salary = 10000, IsPermanant = true },
new Employee { Id = 2, Name = "Smith", Salary = 5000, IsPermanant = false },
new Employee { Id = 3, Name = "Mark", Salary = 5000, IsPermanant = false },
new Employee { Id = 3, Name = "Mary", Salary = 5000, IsPermanant = false }



      };



            return View(e);
        }

    }
}
