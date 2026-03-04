using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class SubscriptionsApiTests : IDisposable
    {
        private SubscriptionsApi instance;

        public SubscriptionsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new SubscriptionsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<SubscriptionsApi>(instance);
        }

        [Fact]
        public void GetSubscriptionTest()
        {
            string id = "cus_2tZWxbTPtQgGJGh8P";
            var response = instance.GetSubscription(id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void GetSubscriptionEventsTest()
        {
            string id = "cus_2rKpeXQpapLonfVke";
            var response = instance.GetSubscriptionEvents(id, "es");
            Assert.IsType<SubscriptionEventsResponse>(response);
        }

        [Fact]
        public void CreateSubscriptionTest()
        {
            string id = "cus_2tZWxbTPtQgGJGh8P";
            var subscriptionRequest = new SubscriptionRequest(
                planId: "plan_2tZb5q8Z3PYpg6SJd"
            );
            var response = instance.CreateSubscription(id, subscriptionRequest, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void UpdateSubscriptionTest()
        {
            string id = "cus_2tZWxbTPtQgGJGh8P";
            var updatesASubscription = new UpdatesASubscription(
                planId: "plan_2tZb5q8Z3PYpg6SJd"
            );
            var response = instance.UpdateSubscription(id, updatesASubscription, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void CancelSubscriptionTest()
        {
            string id = "cus_2tZWxbTPtQgGJGh8P";
            var response = instance.CancelSubscription(id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void PauseSubscriptionTest()
        {
            string id = "cus_2tZWxbTPtQgGJGh8P";
            var response = instance.PauseSubscription(id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void ResumeSubscriptionTest()
        {
            string id = "cus_2tZWxbTPtQgGJGh8P";
            var response = instance.ResumeSubscription(id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }
    }
}
