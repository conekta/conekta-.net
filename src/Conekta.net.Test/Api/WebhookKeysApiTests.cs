using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class WebhookKeysApiTests : IDisposable
    {
        private WebhookKeysApi instance;

        public WebhookKeysApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new WebhookKeysApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<WebhookKeysApi>(instance);
        }

        [Fact]
        public void GetWebhookKeysTest()
        {
            var response = instance.GetWebhookKeys("es");
            Assert.IsType<GetWebhookKeysResponse>(response);
        }

        [Fact]
        public void GetWebhookKeyTest()
        {
            string id = "whk_123";
            var response = instance.GetWebhookKey(id, "es");
            Assert.IsType<WebhookKeyResponse>(response);
        }

        [Fact]
        public void CreateWebhookKeyTest()
        {
            var response = instance.CreateWebhookKey("es");
            Assert.IsType<WebhookKeyCreateResponse>(response);
        }

        [Fact]
        public void DeleteWebhookKeyTest()
        {
            string id = "whk_123";
            var response = instance.DeleteWebhookKey(id, "es");
            Assert.IsType<WebhookKeyDeleteResponse>(response);
        }

        [Fact]
        public void UpdateWebhookKeyTest()
        {
            string id = "whk_123";
            var response = instance.UpdateWebhookKey(id, "es");
            Assert.IsType<WebhookKeyResponse>(response);
        }
    }
}
