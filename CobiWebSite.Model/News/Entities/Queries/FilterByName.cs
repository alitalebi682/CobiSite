using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Entities.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.Model.News.Entities.Queries
{
    public class FilterByName: IRequest<ApplicationServiceResponse<List<NewsBaseQr>>>
    {

        public string? Type { get; set; }
       

    }
    public class FilterByNameGroupNews : IRequest<ApplicationServiceResponse<List<NewsBaseQr>>>
    {

      
        public string GroupNewsName { get; set; }
       

    }
}
