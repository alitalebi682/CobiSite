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

            ///add picture
            //
            var data = HttpContext.Request.Form;
            var dic = Request.Form.ToDictionary(x => x.Key, x => x.Value.ToString());


            foreach (var kvp in data.Keys)
            {
                PropertyInfo pi =
                    NewsBase.GetType()
                        .GetProperty(kvp, BindingFlags.Public | BindingFlags.Instance);
                if (pi != null)
                {
                    pi.SetValue(NewsBase, dic[kvp], null);
                }
            }

            if (data.Files.Count > 0)
            {
                IFormFile img = data.Files[0];
                NewsBase.AttachpicturesUrl = img.FileName;
                string savePath = Path.Combine(Directory.GetCurrentDirectory(),
                    "wwwroot/images", NewsBase.AttachpicturesUrl);
                using (var fileStream = new FileStream(savePath, FileMode.Create))
                {
                    img.CopyTo(fileStream);
                }
            }



        }



        [HttpPut("UpdateNews")]
        public async Task<IActionResult> UpdateNews(UpdateNews UpdateNews)
        {
            var response = await _mediator.Send(UpdateNews);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }


        [HttpGet("FilterByName")]
        public async Task<IActionResult> SearchNews([FromQuery] FilterByName filterByName)
        {
            var response = await _mediator.Send(filterByName);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }

        [HttpDelete("DeleteNews")]
        public async Task<IActionResult> DeleteNews(DeleteNews deleteNews)
        {
            var response = await _mediator.Send(deleteNews);
            if (response.IsSuccess)
            {
                return Ok(response.Result);
            }
            return response.IsSuccess ? Ok(response.Result) : BadRequest(response.Errors);
        }





    }
}
