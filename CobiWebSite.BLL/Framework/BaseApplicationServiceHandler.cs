using cobiWebSite.DAL.CobiDbContext;

using CobiWebSite.Model.FrameWork;
using MediatR;

namespace CobiWebSite.BLL.News.Commands;

public abstract class BaseApplicationServiceHandler<TRequest, TResult> : IRequestHandler<TRequest, ApplicationServiceResponse<TResult>>
    where TRequest : IRequest<ApplicationServiceResponse<TResult>>
{
    protected readonly CobiWebSiteDbContext _CobiWebSiteDbContext;
    private ApplicationServiceResponse<TResult> _response = new ApplicationServiceResponse<TResult> { };
    public BaseApplicationServiceHandler(CobiWebSiteDbContext CobiWebSiteDbContext)
    {
        _CobiWebSiteDbContext = CobiWebSiteDbContext;
    }

    public async Task<ApplicationServiceResponse<TResult>> Handle(TRequest request, CancellationToken cancellationToken)
    {
        await HandleRequest(request, cancellationToken);
        return _response;
    }
    protected abstract Task HandleRequest(TRequest request, CancellationToken cancellationToken);

    public void AddError(string error)
    {
        _response.AddError(error);
    }

    public void AddRsult(TResult result) =>
        _response.Result = result;

}