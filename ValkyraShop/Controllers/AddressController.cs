using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.DatabaseDto.Shop;
using ValkyraShop.Services;

namespace ValkyraShop.Controllers
{
    [Authorize]
    [Route("public/api/customers")]
    public class AddressController : Controller
    {
        private IAddressServcie _addressServcie;
        public AddressController(IAddressServcie addressServcie)
        {
            _addressServcie = addressServcie;
        }

        [HttpGet("addresses")]
        public IActionResult GetAddresses()
        {
            return Ok();
        }

        [HttpPost("addresses")]
        public IActionResult PostAddress(CustomerAddress customerAddress)
        {
            if (int.Parse(HttpContext.User.Claims.ToList()[1].Value) != customerAddress.CustomerId)
                return Unauthorized();

            if (_addressServcie.AddAddress(customerAddress) != 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("addresses")]
        public IActionResult DeleteAddress(CustomerAddress customerAddress)
        {
            return Ok();
        }
    }
}
