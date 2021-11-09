using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ValkyraShop.Services;

namespace ValkyraShop.Controllers
{
    [Route("public/api/Product")]
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet()]
        public IActionResult getProducts()
        {
            return Ok();
        }

        [HttpGet("/{id}")]
        public IActionResult getProduduct()
        {
            return Ok();
        }

        [HttpGet("/Top")]
        public IActionResult getTopProducts()
        {
            return Ok();
        }
    }
}
