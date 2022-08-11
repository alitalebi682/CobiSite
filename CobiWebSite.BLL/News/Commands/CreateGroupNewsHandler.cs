using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.BLL.News.Commands
{
    public class CreateGroupNewsHandler : BaseApplicationServiceHandler<CreateGroupNews, GroupNews>
    {
        public CreateGroupNewsHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(CreateGroupNews request, CancellationToken cancellationToken)
        {
            GroupNews GroupNews = new()
            {

                
               
                GroupNewsName=request.GroupNewsName,
                PictureGroupNewsUrl=request.PictureGroupNews,
               





            };
            await _CobiWebSiteDbContext.GroupNews.AddAsync(GroupNews);
            await _CobiWebSiteDbContext.SaveChangesAsync();
            AddRsult(GroupNews);
        }
    
    }
}
