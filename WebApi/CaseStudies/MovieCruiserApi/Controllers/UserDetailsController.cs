using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieCruiserApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCruiserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDetailsController : ControllerBase
    {
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id, string password)
        {
            List<UserDetails> list = MovieListOperations.UserList();
            bool user = list.Any(p => p.Id == id && p.Password == password);
            if (user == true)
                return "true";
            return "falseSubmission";
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] UserDetails user)
        {
            MovieListOperations.Insert(user);
            return Ok();
        }
    }
}
