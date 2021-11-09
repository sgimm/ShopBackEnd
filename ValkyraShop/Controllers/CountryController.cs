using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValkyraShop.Controllers
{
    [Route("public/api/Country")]
    public class CountryController : Controller
    {
        [HttpGet()]
        public IActionResult GetCountries()
        {
            return Ok();
        }
    }
}
