using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace truYumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;




        public AuthController(IConfiguration config)
        {
            _config = config;
        }
        [HttpGet]
        [Route("api/Auth/{id}")]
        public IActionResult Get(int id)
        {
            if (id == -1)
                return Ok(GenerateJSONWebToken(""));
            if (id == 1)
                return Ok(GenerateJSONWebToken("Admin"));
            else
                return Ok(GenerateJSONWebToken("Customer"));



        }



        private string GenerateJSONWebToken(string userRole)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);



            var claims = new List<Claim>
{
new Claim(ClaimTypes.Role, userRole),
};





            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
            _config["Jwt:Issuer"],
            claims: claims,
            expires: DateTime.Now.AddMinutes(2),
            signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }


    }
}
