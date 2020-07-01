using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;
using RPG.API.Model;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RPG.API.IntegrationTests.ControllersTests
{
    public class PlayerControllerTests : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly CustomWebApplicationFactory<Startup> _factory;
        private HttpClient _client;

        public PlayerControllerTests(CustomWebApplicationFactory<Startup> factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        [Fact]
        public async Task Given_SerializedPlayerObejct_When_SendingPostPlayerRequest_ReturnsSuccessCode()
        {
            var url = "/api/player";

            var response = await _client.PostAsync(
                url,
                new StringContent(
                    JsonSerializer.Serialize(GetDummyPlayer()),
                    Encoding.UTF8,
                    "application/json")
                );

            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task Given_NoParameters_When_SendingGetAllPlayersRequest_ReturnsSuccessCodeAndCorrectResponse()
        {
            var url = "/api/player/all";

            var response = await _client.GetAsync(url);
            var stringResposne = await response.Content.ReadAsStringAsync();
            var deserializedResponse = JsonSerializer.Deserialize<List<Player>>(stringResposne);

            response.EnsureSuccessStatusCode();
            Assert.Equal("application/json; charset=utf-8", response.Content.Headers.ContentType.ToString());
            Assert.True(deserializedResponse.Any());
        }

        private Player GetDummyPlayer()
        {
            return new Player
            {
                Id = 1,
                Name = "Tester",
                Proffesion = "Warrior",
                Health = 100,
                Resource = 1,
                Strength = 1,
                Dexterity = 1,
                Intelligence = 1,
                Level = 1,
                Items = new List<Item>()
            };
        }
    }
}
