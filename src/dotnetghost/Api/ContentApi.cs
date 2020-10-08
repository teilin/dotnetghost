using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetghost.Models;
using dotnetghost.Exceptions;
using System.Threading;

namespace dotnetghost.Api
{
    internal sealed class ContentApi : IApi
    {
        private readonly string _apiKey;
        private readonly string _apiUrl;

        public ContentApi(string apiUrl, string apiKey)
        {
            if(string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException("apiKey");
            }
            if(string.IsNullOrEmpty(apiUrl))
            {
                throw new ArgumentNullException("apiUrl");
            }

            _apiKey = apiKey;
            _apiUrl = apiUrl;
        }

        public Task<TModel> Fetch<TModel>(string resource, CancellationToken cancellation) where TModel : IFetchable
        {
            throw new NotImplementedException();
        }

        public Task<string> GetToken()
        {
            return Task.Factory.StartNew(() => _apiKey);
        }

        public Task Insert<TModel>(string resource, CancellationToken cancellation) where TModel : IFetchable
        {
            throw new OperationNotAllowedUsingContentApiException(_apiUrl, resource, "Insert");
        }
    }
}