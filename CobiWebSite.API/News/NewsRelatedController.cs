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
    public class NewsRelatedController : BaseController

    {

        public NewsRelatedController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("CreateGroupNews")]
        public async Task<IActionResult> CreateNewsRelated(CreateNewsRelated NewsRelated)
        {
            var response = await _mediator.Send(NewsRelated);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);



        }

        [HttpPut("UpdateNewsRelated")]
        public async Task<IActionResult> UpdateNewsRelated(UpdateNewsRelated NewsRelated)
        {
            var response = await _mediator.Send(NewsRelated);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }




        [HttpDelete("DeleteGroupNews")]
        public async Task<IActionResult> DeleteNewsRelated(DelateNewsRelated NewsRelated)
        {
            var response = await _mediator.Send(NewsRelated);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }





    }
}
