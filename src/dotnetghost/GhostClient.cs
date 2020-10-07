using System;
using dotnetghost.Api;

namespace dotnetghost
{
    public sealed class GhostClient
    {
        private readonly string _apiKey;
        private readonly string _apiUrl;

        public GhostClient(string apiUrl, string apiKey)
        {
            if(string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentNullException(apiKey);
            }
            if(string.IsNullOrEmpty(apiUrl))
            {
                throw new ArgumentNullException("apiUrl");
            }

            _apiKey = apiKey;
            _apiUrl = apiUrl;
        }

        public IApi GetApiClient()
        {
            var secets = _apiKey.Split(':');

            if(secets.Length==1)
            {
                return (IApi)new ContentApi(_apiUrl, secets[0]);
            }
            else if(secets.Length==2)
            {
                return (IApi)new AdminApi(_apiUrl, secets[0], secets[1]);
            }
            else
            {
                throw new NotSupportedException("Unsupported api token");
            }
        }
    }
}
