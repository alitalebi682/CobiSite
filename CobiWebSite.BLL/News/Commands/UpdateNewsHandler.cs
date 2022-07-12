using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.Model.FrameWork;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobiWebSite.BLL.News.Commands
{
    public class UpdateNewsHandler : BaseApplicationServiceHandler<UpdateNews, NewsBase>
    {
               
            public UpdateNewsHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
            {

            }

        protected override async Task HandleRequest(UpdateNews request, CancellationToken cancellationToken)
        {

            NewsBase NewsBase = _CobiWebSiteDbContext.NewsBases.SingleOrDefault(C => C.Id ==request.Id);

            if (NewsBase == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                NewsBase.Type = request.Type;
                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(NewsBase);
            }

        }
        
    }
}
