using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using dotnetghost.Common;
using dotnetghost.Models;
using System.Text.Json;

namespace dotnetghost.Api
{
    internal sealed class AdminApi : IApi
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions();
        private readonly string _id;
        private readonly string _secret;
        private readonly string _apiUrl;
        private readonly ApiVersion _apiVersion;
        private JwtToken _token;

        public AdminApi(string apiUrl, string id, string secret, ApiVersion apiVersion = ApiVersion.V3)
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
            _apiVersion = apiVersion;
        }

        public Task<string> GetToken()
        {
            if(_token==null)
            {
                _token = TokenGenerator.Generate(_apiVersion, _id, _secret);
            }
            if(_token.DurationMinutes >= 5)
            {
                _token = TokenGenerator.Generate(_apiVersion, _id, _secret);
            }
            return Task.Factory.StartNew(() => _token.Token);
        }

        public async Task<TModel> Fetch<TModel>(string resource) where TModel : IFetchable
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_apiUrl);

                client.DefaultRequestHeaders.Add("Authorization", $"Ghost {GetToken()}");
                client.DefaultRequestHeaders.Add("Content-Type", "application/json; charset=utf-8");

                var responseStream = await client.GetStreamAsync($"ghost/api/v3/admin/{resource}");
                var responseObject = await JsonSerializer.DeserializeAsync<TModel>(responseStream, Options);

                return responseObject;
            }
        }

        public Task Insert<TModel>(string resource) where TModel : IFetchable
        {
            throw new NotImplementedException();
        }
    }
}