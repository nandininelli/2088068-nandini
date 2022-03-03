using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [AutoValidateAntiforgeryToken]
    [Authorize(Roles="POC,Admin")]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository<Employee> empRepository;
        public EmployeeController(IRepository<Employee> empRepository)
        {
            this.empRepository = empRepository;
        }


        [HttpGet]
        [ProducesResponseType(statusCode: 500)]

        public IActionResult GetEmployees()
        {
            var emps = empRepository.Get();
            return Ok(emps);
        }

        [HttpGet("{id}", Name = "GetProd")]
        //[Route("{id}")]
        
        public IActionResult GetEmployee(int id)
        {
            var emps = empRepository.Get(p => p.Id == id);
            var emp = emps.FirstOrDefault();
            if (emp == null)
                return NotFound();
            return Ok(emp);
        }

        [HttpPost]
       
        public async Task<IActionResult> AddEmployee(Employee model)
        {
            empRepository.Add(model);
            int RowsAffected = await empRepository.SaveAsync();
            if (RowsAffected == 1)
                //return CreatedAtAction("GetProduct", new { id = model.Id });
                return CreatedAtRoute(routeName: "GetProd",
                                      routeValues: new { id = model.Id },
                                      value: model);
            return BadRequest("Add failed");
        }
        //put Handson
        [HttpPut]
        public ActionResult<Employee> PutEmployee(int id,Employee employee)
        {
            if (id == 0)
            {
                return BadRequest("Invalid Employee Id");

            }

            else if (id > 0 && employee== null){
                return BadRequest("Check Credentials");


            }
            else
            {
                return Ok(employee);
            }
        }
    }
}
