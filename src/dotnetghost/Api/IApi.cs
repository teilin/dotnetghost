using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetghost.Models;

namespace dotnetghost.Api
{
    public interface IApi
    {
        Task<string> GetToken();
        Task<TModel> Fetch<TModel>(string resource) where TModel : IFetchable;
        Task Insert<TModel>(string resource) where TModel : IFetchable;
    }
}