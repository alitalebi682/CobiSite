using cobiWebSite.DAL.CobiDbContext;
using CobiWebSite.Model.News.Commands;
using CobiWebSite.Model.News.Entities;


namespace CobiWebSite.BLL.News.Commands;

public class CreateNewsHandler : BaseApplicationServiceHandler<CreateNews, NewsBase>
{
    public CreateNewsHandler(CobiWebSiteDbContext CobiWebSiteDbContext) : base(CobiWebSiteDbContext)
    {
    }

    protected override async Task HandleRequest(CreateNews request, CancellationToken cancellationToken)
    {
        NewsBase NewsBase = new()
        {
            Type = request.Type
            //Group = request.Group,
            //Rowtitle = request.Rowtitle,
            //GroupNews=request.GroupNews,
            //Rowmainnews=request.Rowmainnews


        };
         await _CobiWebSiteDbContext.NewsBases.AddAsync(NewsBase);
        await _CobiWebSiteDbContext.SaveChangesAsync();
        AddRsult(NewsBase);
    }
}



