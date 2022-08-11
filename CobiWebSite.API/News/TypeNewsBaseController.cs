using CobiWebSite.API.FreameWork;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities;
using CobiWebSite.Model.News.Entities.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CobiWebSite.API.News
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeNewsBaseController : BaseController

    {

        public TypeNewsBaseController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("CreateTypeNewsBase")]
        public async Task<IActionResult> CreateTypeNewsBase(CreateTypeNewsBase TypeNewsBase)
        {
            var response = await _mediator.Send(TypeNewsBase);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);



        }

        [HttpPut("UpdateTypeNewsBase")]
        public async Task<IActionResult> UpdateTypeNewsBase(UpdateTypeNewsBase TypeNewsBase)
        {
            var response = await _mediator.Send(TypeNewsBase);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }




        [HttpDelete("DeletetypeNewsBase")]
        public async Task<IActionResult> DeleteTypeNewsBase(DeleteTypeNewsBase TypeNewsBase)
        {
            var response = await _mediator.Send(TypeNewsBase);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }





    }
}
