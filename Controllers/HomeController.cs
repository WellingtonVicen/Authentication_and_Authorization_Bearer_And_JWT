using API_AUTH.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace API_AUTH.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anonimo";

        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticaded() => $"Autenticado - {User.Identity.Name}";

        [HttpGet]
        [Route("developer")]
        [Authorize(Roles = "Developer, QA, Tech-Lead")]
        public string Developer() => $"Squad Marte - {User.Identity.Name}";

        [HttpGet]
        [Route("techlead")]
        [Authorize(Roles = "Tech-Lead")]
        public string TechLead() => "Dayvid";

    }
}