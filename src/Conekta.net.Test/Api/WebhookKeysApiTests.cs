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
            var response = instance.GetWebhookKeys("es", limit: 2);
            Assert.IsType<GetWebhookKeysResponse>(response);
        }

        [Fact]
        public void GetWebhookKeyTest()
        {
            string id = "645a5eb022e7da0001cad2a4";
            var response = instance.GetWebhookKey(id, "es");
            Assert.IsType<WebhookKeyResponse>(response);
        }

        [Fact]
        public void CreateWebhookKeyTest()
        {
            var request = new WebhookKeyRequest(active: true);
            var response = instance.CreateWebhookKey("es", request);
            Assert.IsType<WebhookKeyCreateResponse>(response);
        }

        [Fact]
        public void DeleteWebhookKeyTest()
        {
            string id = "645a59da22e7da0001cad283";
            var response = instance.DeleteWebhookKey(id, "es");
            Assert.IsType<WebhookKeyDeleteResponse>(response);
        }

        [Fact]
        public void UpdateWebhookKeyTest()
        {
            string id = "645a613622e7da0001cad882";
            var response = instance.UpdateWebhookKey(id, "es");
            Assert.IsType<WebhookKeyResponse>(response);
        }
    }
}
