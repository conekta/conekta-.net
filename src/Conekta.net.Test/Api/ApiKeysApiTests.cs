using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class ApiKeysApiTests : IDisposable
    {
        private ApiKeysApi instance;

        public ApiKeysApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new ApiKeysApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ApiKeysApi>(instance);
        }

        [Fact]
        public void GetApiKeysTest()
        {
            var response = instance.GetApiKeys("es", limit: 20);
            Assert.IsType<GetApiKeysResponse>(response);
        }

        [Fact]
        public void GetApiKeyTest()
        {
            string id = "64625cc9f3e02c00163f5e4d";
            var response = instance.GetApiKey(id, "es");
            Assert.IsType<ApiKeyResponse>(response);
        }

        [Fact]
        public void CreateApiKeyTest()
        {
            var apiKeyRequest = new ApiKeyRequest(
                description: "test key",
                role: "private"
            );
            var response = instance.CreateApiKey(apiKeyRequest, "es");
            Assert.IsType<ApiKeyCreateResponse>(response);
        }

        [Fact]
        public void UpdateApiKeyTest()
        {
            string id = "64625cc9f3e02c00163f5e4d";
            var apiKeyUpdateRequest = new ApiKeyUpdateRequest(
                description: "updated key"
            );
            var response = instance.UpdateApiKey(id, "es", apiKeyUpdateRequest);
            Assert.IsType<ApiKeyResponse>(response);
        }

        [Fact]
        public void DeleteApiKeyTest()
        {
            string id = "64625cc9f3e02c00163f5e4d";
            var response = instance.DeleteApiKey(id, "es");
            Assert.IsType<DeleteApiKeysResponse>(response);
        }
    }
}
