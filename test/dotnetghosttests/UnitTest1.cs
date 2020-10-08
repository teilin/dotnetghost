using dotnetghost;
using dotnetghost.Models;
using NUnit.Framework;

namespace dotnetghosttests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async void Test1()
        {
            var client = new GhostClient("https://beitostolenlive.no", "5f7c9ea5d00cb8000176700a:99405c19e047142e4f6a1ebe23a6532c03a3df75e53dbd2897adbff140ec5fc3");

            var token = await client.GetApiClient().GetToken();

            Assert.Pass();
        }
    }
}