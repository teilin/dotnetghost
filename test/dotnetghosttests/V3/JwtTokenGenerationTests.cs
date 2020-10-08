using System;
using System.Threading.Tasks;
using dotnetghost;
using dotnetghost.Models;
using NUnit.Framework;

namespace dotnetghosttests.V3
{
    public class JwtTokenGenerationTests : BaseTest
    {
        [SetUp]
        public async Task Setup()
        {
            await base.LoadTestSettings();
        }

        [Test]
        public async Task ShouldReturnJwtTokenAsString()
        {
            var client = new GhostClient(base._apiUrl, base._apiKeyAdmin);

            var token = await client.GetApiClient().GetToken();

            Assert.IsInstanceOf<String>(token, "Token should be of type String");
        }
    }
}