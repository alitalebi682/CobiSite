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
    public  class UpdateTypeNewseBaseHandler : BaseApplicationServiceHandler<UpdateTypeNewsBase, TypeNewsBase>
    {
        public UpdateTypeNewseBaseHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(UpdateTypeNewsBase request, CancellationToken cancellationToken)
        {

            TypeNewsBase TypeNewsBase = _CobiWebSiteDbContext.TypeNewsBases.SingleOrDefault(C => C.Id== request.Id);

            if (TypeNewsBase == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                {
                    TypeNewsBase.TypeNewsBaseName = request.TypeNewsBaseName;
                    




                }

                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(TypeNewsBase);
            }


        }

    }
}
