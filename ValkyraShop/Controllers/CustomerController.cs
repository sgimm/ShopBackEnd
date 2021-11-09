using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ValkyraShop.DatabaseDto.Shop;

namespace ValkyraShop.Controllers
{
    [Authorize]
    [Route("public/api")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("Customers")]
        public Customer GetCustomer()
        {
            return _customerService.GetCustomers(int.Parse(HttpContext.User.Claims.ToList()[1].Value));
        }

        [HttpPut("Customers")]
        public IActionResult UpdateCustomer([FromBody] Customer customer)
        {
            if (int.Parse(HttpContext.User.Claims.ToList()[1].Value) == customer.Id)
            {
                _customerService.UpdateCustomer(customer);
                return Ok();
            }
            return Unauthorized();
        }
    }
}
