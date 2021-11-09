using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;
using ValkyraShop.Dtos;
using ValkyraShop.Services;

namespace ValkyraShop.Controllers
{
    [Authorize]
    [Route("public/api/customers")]
    public class RegistrationController : Controller
    {
        private IRegistrationService _registrationService;
        public RegistrationController(IRegistrationService registrationService)
        {
            _registrationService = registrationService;
        }

        [AllowAnonymous]
        [HttpPost("registration")]
        public IActionResult Registration([FromBody]CustomerWebAccount webAccount)
        {
             ValidationResult validationResult = _registrationService.Register(webAccount);
            if (validationResult.ResultCode != 0)
                return BadRequest();
            return Ok();
        }

        [AllowAnonymous]
        [HttpGet("registration/validation/{id}")]
        public IActionResult Validation(string id)
        {
            _registrationService.Validate(id);            
            return Ok();
        }
    }
}
