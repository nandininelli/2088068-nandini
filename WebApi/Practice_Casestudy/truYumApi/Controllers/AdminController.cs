using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using truYumApi.Filter;
using truYumApi.Models;

namespace truYumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return MenuItemOperation.GetConnection();
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MenuItem menuitem)
        {
           MenuItemOperation.Update(id,menuitem);
            return Ok();
        }
    }
}
