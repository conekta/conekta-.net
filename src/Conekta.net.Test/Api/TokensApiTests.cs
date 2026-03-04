using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class TokensApiTests : IDisposable
    {
        private TokensApi instance;

        public TokensApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new TokensApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TokensApi>(instance);
        }

        [Fact]
        public void CreateTokenTest()
        {
            var tokenRequest = new TokenRequest(
                card: new TokenRequestCard(
                    name: "test user",
                    number: "5475040095304607",
                    expMonth: "12",
                    expYear: "25",
                    cvc: "123"
                )
            );
            var response = instance.CreateToken(tokenRequest, "es");
            Assert.IsType<TokenResponse>(response);
        }
    }
}
