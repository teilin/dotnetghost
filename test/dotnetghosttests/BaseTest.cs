using System.IO;
using System.Threading.Tasks;
using dotnetghost;
using dotnetghost.Models.V3;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;

namespace dotnetghosttests
{
    public abstract class BaseTest
    {
        protected string _apiUrl;
        protected string _apiKeyContent;
        protected string _apiKeyAdmin;

        protected BaseTest()
        {
        }

        protected Task LoadTestSettings()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.test.json", false)
                .Build();

            _apiUrl = config.GetValue<string>("ApiUrl");//config["ApiUrl"];
            _apiKeyContent = config.GetValue<string>("ApiKeyContent");//config["ApiKeyContent"];
            _apiKeyAdmin = config.GetValue<string>("ApiKeyAdmin");//config["ApiKeyAdmin"];

            return Task.CompletedTask;
        }
    }
}