using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.BLL.News.Commands
{

    public class DelateGroupNewsHandler : BaseApplicationServiceHandler<DeleteGroupNews, GroupNews>
    {
        public DelateGroupNewsHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(DeleteGroupNews request, CancellationToken cancellationToken)
        {


            var GroupNews = await _CobiWebSiteDbContext.GroupNews.Where(a => a.Id == request.Id).FirstOrDefaultAsync();


            if (GroupNews == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                _CobiWebSiteDbContext.GroupNews.Remove(GroupNews);
                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(GroupNews);
            }




        }
    }
}


