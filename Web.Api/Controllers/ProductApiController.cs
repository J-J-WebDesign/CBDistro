using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBDistro.Models.Domain;
using CBDistro.Services;
using CBDistro.Web.Models.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static CBDistro.Services.Interfaces.IProductServices;

namespace api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsApiController : ControllerBase
    {
        private IProductService _service = null;
        private readonly ILogger<ProductsApiController> _logger;

        public ProductsApiController(IProductService service, ILogger<ProductsApiController> logger)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public ActionResult<ItemsResponse<Product>> GetAll()
        {
            int code = 200;
            BaseResponse response = null;
            try
            {
                List<Product> list = _service.GetAll();
                response = new ItemsResponse<Product>() { Items = list };
                if (list == null)
                {
                    code = 404;
                    response = new ErrorResponse("Application resource not found.");
                }
                else
                {
                    response = new ItemsResponse<Product> { Items = list };
                }
            }
            catch (Exception ex)
            {
                code = 500;
                response = new ErrorResponse(ex.Message);
            }
            return StatusCode(code, response);
        }
    }
}
