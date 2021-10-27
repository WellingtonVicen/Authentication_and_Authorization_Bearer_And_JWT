using API_AUTH.Models;
using API_AUTH.Repositories;
using API_AUTH.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_AUTH.Controllers
{
    [ApiController]
    [Route("v1")]
    public class LoginController: ControllerBase
    {
        [HttpPost]
        [Route("Login")]

        public async Task<ActionResult<dynamic>> AuthenticateAsync([FromBody] User model)
        {
            var user = UserRepository.GetUser(model.UserName, model.Passowrd);

            if (user == null)
                return NotFound(new {message = "Usuario ou Senha Invalidos" });

            var token = TokenService.GenareteToken(user);

            return new
            {
                user = user,
                token
            }; 
        }
    }
}
