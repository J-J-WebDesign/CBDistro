using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CBDistro.Models;
using CBDistro.Models.Domain;
using CBDistro.Models.Requests;
using CBDistro.Services;
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
    [Route("api/faq"),]
    public class FAQApiController : BaseApiController
    {
        private IFAQServices _service = null;
        public FAQApiController(IFAQServices service, ILogger<PingApiController> logger) : base(logger)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<ItemsResponse<FAQ>> SelectAll()
        {
            int code = 200;
            BaseResponse response = null;
            try
            {
                List<FAQ> list = _service.SelectAll();
                response = new ItemsResponse<FAQ>() { Items = list };
                if (list == null)
                {
                    code = 404;
                    response = new ErrorResponse("Application resource not found.");
                }
                else
                {
                    response = new ItemsResponse<FAQ> { Items = list };
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
        public ActionResult<ItemResponse<int>> Add(FAQAddRequest model)
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

        [HttpPut("{Id:int}/update")]
        public ActionResult<SuccessResponse> Update(FAQUpdateRequest model)
        {
            int Code = 200;
            BaseResponse result = null;
            try
            {
                _service.Update(model);
                result = new SuccessResponse();
            }
            catch (Exception ex)
            {
                base.Logger.LogError(ex.ToString());
                result = new ErrorResponse(ex.Message);
                Code = 500;
            }
            if (model.Id == 0)
            {
                result = new ErrorResponse("Id cannot be 0.");
            }
            return StatusCode(Code, result);
        }

        [HttpDelete("{Id:int}/delete")]
        public ActionResult<SuccessResponse> Delete(FAQDeleteRequest model)
        {
            int Code = 200;
            BaseResponse result = null;
            try
            {
                _service.Delete(model);
                result = new SuccessResponse();
            }
            catch (Exception ex)
            {
                base.Logger.LogError(ex.ToString());
                result = new ErrorResponse(ex.Message);
                Code = 500;
            }
            if (model.Id == 0)
            {
                result = new ErrorResponse("Id cannot be 0.");
            }
            return StatusCode(Code, result);
        }
    }
}