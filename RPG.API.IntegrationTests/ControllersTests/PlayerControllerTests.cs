using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

using RPG.API.Database;
using RPG.API.Model;
using RPG.API.IntegrationTests.Utilities;

namespace RPG.API.IntegrationTests.ControllersTests
{
    public class PlayerControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;

        public PlayerControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Given_SerializedPlayerObejct_When_SendingPostPlayerRequest_ReturnsSuccessCode()
        {
            var url = "/api/player";

            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var serviceProvider = services.BuildServiceProvider();

                    using var scope = serviceProvider.CreateScope();
                    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                    InMemoryDbSetup.ClearDbContext(db);
                });
            }).CreateClient();
            
            var response = await client.PostAsync(
                url,
                new StringContent(
                    JsonSerializer.Serialize(Dummies.GetDummyPlayer()),
                    Encoding.UTF8,
                    "application/json")
                );

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Given_NoParameters_When_SendingGetAllPlayersRequest_ReturnsSuccessCodeAndCorrectResponse()
        {
            var url = "/api/player/all";

            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var serviceProvider = services.BuildServiceProvider();

                    using var scope = serviceProvider.CreateScope();
                    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                    InMemoryDbSetup.ClearDbContext(db);
                    InMemoryDbSetup.AddDummyPlayers(db);
                });
            }).CreateClient();

            var response = await client.GetAsync(url);
            var stringResponse = await response.Content.ReadAsStringAsync();
            var deserializedResponse = JsonSerializer.Deserialize<List<Player>>(stringResponse);

            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
            Assert.True(deserializedResponse.Any());
        }

        [Fact]
        public async Task Given_ValidPlayerId_When_SendingGetPlayerRequest_ReturnsSuccessCodeAndCorrectResponse()
        {
            var url = "/api/player?id=1";

            var client = _factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureServices(services =>
                {
                    var serviceProdvider = services.BuildServiceProvider();

                    using var scope = serviceProdvider.CreateScope();
                    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                    InMemoryDbSetup.ClearDbContext(db);
                    InMemoryDbSetup.AddDummyPlayer(db);
                });
            }).CreateClient();

            var expectedResponse = Dummies.GetDummyPlayer();

            var response = await client.GetAsync(url);
            var stringResponse = await response.Content.ReadAsStringAsync();
            var deserializedResponse =  JsonSerializer.Deserialize<Player>(stringResponse);

            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
            Assert.Equal(expectedResponse, deserializedResponse);
        }
    }
}
