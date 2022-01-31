using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployDetails.Models
{
    public class Employee
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public bool IsPermanant { get; set; }
    }
}
