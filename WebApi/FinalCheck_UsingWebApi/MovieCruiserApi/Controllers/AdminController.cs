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
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MovieList> Get()
        {
            return MovieListOperations.GetConnection();
        }

        // PUT: api/Admin/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] MovieList movie)
        {
            MovieListOperations.Update(id, movie);
            return Ok();
        }
    }
}
