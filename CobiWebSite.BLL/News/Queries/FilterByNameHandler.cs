using cobiWebSite.DAL.CobiDbContext;
using cobiWebSite.DAL.NewsConfig;
using CobiWebSite.BLL.News.Commands;
using CobiWebSite.Model.News.Entities.Dtos;
using CobiWebSite.Model.News.Entities.Queries;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.BLL.News.Queries
{
    public class FilterByNameHandler : BaseApplicationServiceHandler<FilterByName,List< NewsBaseQr>>
    {
        public FilterByNameHandler(CobiWebSiteDbContext courseStoreDbContext) : base(courseStoreDbContext)
        {
        }

        protected override async Task HandleRequest(FilterByName request, CancellationToken cancellationToken)
        {
            var result =await _CobiWebSiteDbContext.NewsBases.WhereOver(request.Type).ToNewsBaseQrsAsync();


            AddRsult(result);
        }
    }
}
