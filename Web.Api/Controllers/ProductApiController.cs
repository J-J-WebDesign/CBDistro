using System;
using System.Collections.Generic;
using CBDistro.Models.Domain;
using CBDistro.Models.Requests;
using CBDistro.Services.Interfaces;
using CBDistro.Web.Api.Controllers;
using CBDistro.Web.Controllers;
using CBDistro.Web.Models.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/products"),]
    public class ProductsApiController : BaseApiController
    {
        private IProductService _service = null;
        public ProductsApiController(IProductService service, ILogger<PingApiController> logger) : base(logger)
        {
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
        [HttpPost("add")]
        public ActionResult<ItemResponse<int>> Add(ProductAddRequest model)
        {
            ObjectResult result = null;
            int code = 200;

            try
            {
                int id = _service.Add(model);
                ItemResponse<int> response = new ItemResponse<int> { Item = id };
                result = Created201(response);
            }
            catch (Exception ex)
            {
                base.Logger.LogError(ex.ToString());
                ErrorResponse response = new ErrorResponse(ex.Message);
                result = StatusCode(500, response);
            }
            return StatusCode(code, result);
        }
    }
}
