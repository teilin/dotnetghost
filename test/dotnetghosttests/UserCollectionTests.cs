using System.Threading.Tasks;
using dotnetghost;
using dotnetghost.Models.V3;
using NUnit.Framework;

namespace dotnetghosttests
{
    public class UserCollectionTests : BaseTest
    {
        private GhostClient _client;

        [SetUp]
        public void Setup()
        {
            _client = new GhostClient(base._apiUrl, base._apiKey);
        }

        [Test]
        public async void TestUserCollectionShouldreturnTheUsers()
        {
            var users = await _client.GetApiClient().Fetch<UsersCollection>("users");

            Assert.IsNotNull(users);
            Assert.Greater(0, users.Users.Count, "There has to be at least one user");
        }
    }
}