using Microsoft.AspNetCore.Authorization;
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
    [AllowAnonymous]
    public class AnonymousUserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MenuItem> Get()
        {
            return MenuItemOperation.GetConnection();
        }
    }
}
