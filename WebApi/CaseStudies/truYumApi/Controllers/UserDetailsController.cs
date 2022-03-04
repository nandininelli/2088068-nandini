using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using truYumApi.Models;

namespace truYumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id, string password)
        {
            List<UserDetails> list = MenuItemOperation.UserList();
            bool user = list.Any(p => p.Id == id && p.Password == password);
            if (user == true)
                return "true";
            return "falseSubmission";
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] UserDetails user)
        {
            MenuItemOperation.Insert(user);
            return Ok();
        }
    }
}
