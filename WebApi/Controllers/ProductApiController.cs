using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBDistro.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsApiController : ControllerBase
    {

        private readonly ILogger<ProductsApiController> _logger;

        public ProductsApiController(ILogger<ProductsApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Product Get()
        {
           
        }
    }
}
