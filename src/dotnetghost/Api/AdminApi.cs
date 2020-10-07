using System;
using System.Collections.Generic;
using dotnetghost.Common;
using dotnetghost.Models;

namespace dotnetghost.Api
{
    internal sealed class AdminApi : IApi
    {
        private readonly string _id;
        private readonly string _secret;
        private readonly string _apiUrl;
        private JwtToken _token;

        public AdminApi(string apiUrl, string id, string secret)
        {
            if(string.IsNullOrEmpty(id))
            {
                throw new ArgumentNullException("id");
            }
            if(string.IsNullOrEmpty(secret))
            {
                throw new ArgumentNullException("secret");
            }
            if(string.IsNullOrEmpty(apiUrl))
            {
                throw new ArgumentNullException("apiUrl");
            }

            _id = id;
            _secret = secret;
            _apiUrl = apiUrl;
        }

        public string GetToken()
        {
            if(_token==null)
            {
                _token = TokenGenerator.Generate(_id, _secret);
            }
            if(_token.DurationMinutes >= 5)
            {
                _token = TokenGenerator.Generate(_id, _secret);
            }
            return _token.Token;
        }

        public IEnumerable<TModel> Fetch<TModel>() where TModel : IFetchable
        {
            throw new NotImplementedException();
        }
    }
}