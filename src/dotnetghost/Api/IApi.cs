using System.Collections.Generic;
using dotnetghost.Models;

namespace dotnetghost.Api
{
    public interface IApi
    {
        string GetToken();
        IEnumerable<TModel> Fetch<TModel>() where TModel : IFetchable;
    }
}