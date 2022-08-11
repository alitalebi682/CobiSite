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
    public class UpdateGroupNewseHandler : BaseApplicationServiceHandler<UpdateGroupNews, GroupNews>
    {
        public UpdateGroupNewseHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(UpdateGroupNews request, CancellationToken cancellationToken)
        {

            GroupNews GroupNews = _CobiWebSiteDbContext.GroupNews.SingleOrDefault(C => C.Id == request.GroupNewsId);

            if (GroupNews == null)
            {
                AddError($"با شناسه{request.GroupNewsId} یافت نشد ");
            }
            else
            {
                {
                  
                    GroupNews.PictureGroupNewsUrl = request.PictureGroupNews;
                    GroupNews.GroupNewsName = request.GroupNewsName;


                }

                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(GroupNews);
            }


        }

    }
}


    
