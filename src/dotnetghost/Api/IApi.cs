using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using dotnetghost.Models;

namespace dotnetghost.Api
{
    public interface IApi
    {
        Task<string> GetToken();
        Task<TModel> Fetch<TModel>(string resource, CancellationToken cancellation) where TModel : IFetchable;
        Task Insert<TModel>(string resource, CancellationToken cancellation) where TModel : IFetchable;
    }
}