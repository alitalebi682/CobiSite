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
    public class CreateTypeNewsBaseHandler : BaseApplicationServiceHandler<CreateTypeNewsBase, TypeNewsBase>
    {
        public CreateTypeNewsBaseHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(CreateTypeNewsBase request, CancellationToken cancellationToken)
        {
            TypeNewsBase TypeNewsBase = new()
            {

                TypeNewsBaseName = request.TypeNewsBaseName,
                





            };
            await _CobiWebSiteDbContext.TypeNewsBases.AddAsync(TypeNewsBase);
            await _CobiWebSiteDbContext.SaveChangesAsync();
            AddRsult(TypeNewsBase);
        }
    
    }
}
