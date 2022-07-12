using CobiWebSite.API.FreameWork;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CobiWebSite.API.News
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : BaseController

    {

        public NewsController(IMediator mediator) : base(mediator)
        {
        }
        [HttpPost("CreateNews")]
        public async Task<IActionResult> CreateNews(CreateNews NewsBase)
        {
            var response = await _mediator.Send(NewsBase);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }

        [HttpPut("UpdateTag")]
        public async Task<IActionResult> UpdateTag(UpdateNews tag)
        {
            var response = await _mediator.Send(tag);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }


        [HttpGet("FilterByName")]
        public async Task<IActionResult> SearchTag([FromQuery] FilterByName tag)
        {
            var response = await _mediator.Send(tag);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }
    }
}
