using System;
using System.Collections.Generic;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class WebhooksApiTests : IDisposable
    {
        private WebhooksApi instance;

        public WebhooksApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new WebhooksApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<WebhooksApi>(instance);
        }

        [Fact]
        public void GetWebhooksTest()
        {
            var response = instance.GetWebhooks("es");
            Assert.IsType<GetWebhooksResponse>(response);
        }

        [Fact]
        public void CreateWebhookTest()
        {
            var webhookRequest = new WebhookRequest(
                url: "https://webhook.site/test",
                subscribedEvents: new List<string> { "charge.created" }
            );
            var response = instance.CreateWebhook(webhookRequest, "es");
            Assert.IsType<WebhookResponse>(response);
        }

        [Fact]
        public void GetWebhookTest()
        {
            string id = "wbh_123";
            var response = instance.GetWebhook(id, "es");
            Assert.IsType<WebhookResponse>(response);
        }

        [Fact]
        public void UpdateWebhookTest()
        {
            string id = "wbh_123";
            var updateWebhook = new UpdateWebhook(
                url: "https://webhook.site/updated"
            );
            var response = instance.UpdateWebhook(id, updateWebhook, "es");
            Assert.IsType<WebhookResponse>(response);
        }

        [Fact]
        public void DeleteWebhookTest()
        {
            string id = "wbh_123";
            var response = instance.DeleteWebhook(id, "es");
            Assert.IsType<WebhookResponse>(response);
        }

        [Fact]
        public void TestWebhookTest()
        {
            string id = "wbh_123";
            var response = instance.TestWebhook(id, "es");
            Assert.IsType<WebhookResponse>(response);
        }
    }
}
