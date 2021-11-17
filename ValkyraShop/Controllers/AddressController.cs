using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using ValkyraShop.Dtos;
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

        [HttpGet("{id}/addresses")]
        public IActionResult GetAddress(int id)
        {
            return Ok();
        }

        [HttpPost("addresses")]
        public IActionResult PostAddress([FromBody]CustomerAddressDto customerAddress)
        {
            if (int.Parse(HttpContext.User.Claims.ToList()[1].Value) != customerAddress.CustomerId)
                return Unauthorized();

            if (_addressServcie.AddAddress(customerAddress) != 0)
                return NotFound();

            return Ok();
        }

        [HttpDelete("addresses/{id}")]
        public IActionResult DeleteAddress(int id)
        {
            return Ok();
        }
    }
}
