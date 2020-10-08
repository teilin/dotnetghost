using System.Threading.Tasks;
using dotnetghost;
using dotnetghosttests;
using dotnetghost.Models.V3;
using NUnit.Framework;
using System.Threading;

namespace dotnetghosttests.V3
{
    public class UserCollectionTests : BaseTest
    {
        private GhostClient _client;

        [SetUp]
        public async Task Setup()
        {
            await base.LoadTestSettings();

            _client = new GhostClient(base._apiUrl, base._apiKeyAdmin);
        }

        [Test]
        public async Task TestUserCollectionShouldreturnTheUsers()
        {
            var users = await _client.GetApiClient().Fetch<UsersCollection>("users", CancellationToken.None);

            Assert.IsNotNull(users);
            Assert.Greater(0, users.Users.Count, "There has to be at least one user");
        }
    }
}