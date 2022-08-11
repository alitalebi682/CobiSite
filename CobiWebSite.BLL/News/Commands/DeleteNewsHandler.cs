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
    public class DeleteNewsHandler : BaseApplicationServiceHandler<DeleteNews, NewsBase>
    {

        public DeleteNewsHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
        {

        }


        protected override async Task HandleRequest(DeleteNews request, CancellationToken cancellationToken)
        {
            

                var NewsBase = await _CobiWebSiteDbContext.NewsBases.Where(a => a.Id == request.Id).FirstOrDefaultAsync();


            if (NewsBase == null)
            {
                AddError($"با شناسه{request.Id} یافت نشد ");
            }
            else
            {
                _CobiWebSiteDbContext.NewsBases.Remove(NewsBase);
                await _CobiWebSiteDbContext.SaveChangesAsync();
                AddRsult(NewsBase) ;
            }




        }
    }

    }

