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
    public class UpdateNewseRelatedHandler : BaseApplicationServiceHandler<UpdateNewsRelated, NewseRelated>
    {
        public UpdateNewseRelatedHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(UpdateNewsRelated request, CancellationToken cancellationToken)
        {

            NewseRelated NewsRelated = _CobiWebSiteDbContext.NewsRelateds.SingleOrDefault(C => C.Id == request.Id);

            if (NewsRelated == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                {


                    NewsRelated.NewsRelatedName = request.NewsRelatedName;
                    

                }

                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(NewsRelated);
            }


        }

    }
}
