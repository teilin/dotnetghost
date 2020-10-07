using System;
using System.Collections.Generic;
using dotnetghost.Models;

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

        public IEnumerable<TModel> Fetch<TModel>() where TModel : IFetchable
        {
            throw new NotImplementedException();
        }

        public string GetToken()
        {
            return _apiKey;
        }
    }
}