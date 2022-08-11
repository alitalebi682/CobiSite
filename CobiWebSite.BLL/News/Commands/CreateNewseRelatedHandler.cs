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
    public class CreateNewseRelatedHandler : BaseApplicationServiceHandler<CreateNewsRelated, NewseRelated>
    {
        public CreateNewseRelatedHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(CreateNewsRelated request, CancellationToken cancellationToken)
        {
            NewseRelated NewseRelated = new()
            {

                
                NewsRelatedName=request.NewsRelatedName,
                





            };
            await _CobiWebSiteDbContext.NewsRelateds.AddAsync(NewseRelated);
            await _CobiWebSiteDbContext.SaveChangesAsync();
            AddRsult(NewseRelated);
        }
    
    }
}
