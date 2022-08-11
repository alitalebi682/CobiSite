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
    public class DeleteNewseRelatedHandler : BaseApplicationServiceHandler<DelateNewsRelated, NewseRelated>
    {
        public DeleteNewseRelatedHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(DelateNewsRelated request, CancellationToken cancellationToken)
        {


            var NewsRelated = await _CobiWebSiteDbContext.NewsRelateds.Where(a => a.Id == request.Id).FirstOrDefaultAsync();


            if (NewsRelated == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                _CobiWebSiteDbContext.NewsRelateds.Remove(NewsRelated);
                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(NewsRelated);
            }




        }
    }
}
  