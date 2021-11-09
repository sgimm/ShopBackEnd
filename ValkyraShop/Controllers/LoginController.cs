using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.Services;
using ValkyraShop.DatabaseDto.Shop;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace ValkyraShop.Controllers
{
    [Route("public/api/customers")]
    public class LoginController : Controller
    {
        private ILoginService _loginService;
        private IConfiguration _configuration;
        public LoginController(ILoginService loginService, IConfiguration configuration)
        {
            _loginService = loginService;
            _configuration = configuration;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody]WebLogin webLogin)
        {
            string tmp = _configuration.GetValue<string>("TOKEN_SECRET");
            string token = _loginService.Login(webLogin, _configuration.GetValue<string>("TOKEN_SECRET"));
            if (string.IsNullOrWhiteSpace(token))
            { return Unauthorized(); }
            return Ok("{\"Authorization\":\"Bearer " + token + "\"}");
        }
    }
}
