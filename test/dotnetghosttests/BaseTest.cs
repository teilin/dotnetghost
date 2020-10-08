using System.Threading.Tasks;
using dotnetghost;
using dotnetghost.Models.V3;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace dotnetghosttests
{
    public class BaseTest
    {
        protected string _apiUrl;
        protected string _apiKey;

        protected BaseTest()
        {
        }

        protected void LoadTestSettings()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json", false)
                .Build();

            _apiUrl = config["ApiUrl"];
            _apiKey = config["ApiKey"];
        }
    }
}