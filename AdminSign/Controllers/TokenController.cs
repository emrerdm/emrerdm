using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.Text;
using Microsoft.AspNetCore.Hosting;

namespace AdminSign.Controllers
{
    public class TokenController : Controller
    {
     
        private IConfiguration Configuration;
        public TokenController(IConfiguration config)
        {
            Configuration = config;
        }
        
        public IActionResult CreateToken(string username = "admin", string password = "admin")
        {
            

            IActionResult response = Unauthorized();
            if (username.Equals(password))
            {
               
                var jwttoken = JwtTokenBuilder();

                response = Ok(new { access_token = jwttoken });
            }

            return response;
        }
        
        private string JwtTokenBuilder()
        {
             

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("testtestetstsetsetsetsetsetsetset"));
         
            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var jwtToken = new JwtSecurityToken(issuer: "test",
                audience:"test", signingCredentials: credentials,
                expires: DateTime.Now.AddMinutes(10)
                );



            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }
    }
}