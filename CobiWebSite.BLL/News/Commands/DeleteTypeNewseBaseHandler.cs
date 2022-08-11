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
    public class DeleteTypeNewseBaseHandler :BaseApplicationServiceHandler<DeleteTypeNewsBase, TypeNewsBase>
    {
        public DeleteTypeNewseBaseHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {
        }

        protected override async Task HandleRequest(DeleteTypeNewsBase request, CancellationToken cancellationToken)
        {


            var TypeNewsBase = await _CobiWebSiteDbContext.TypeNewsBases.Where(a => a.Id == request.Id).FirstOrDefaultAsync();


            if (TypeNewsBase == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
               





                _CobiWebSiteDbContext.TypeNewsBases.Remove(TypeNewsBase);
                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(TypeNewsBase);
            }




        }
    }
}

