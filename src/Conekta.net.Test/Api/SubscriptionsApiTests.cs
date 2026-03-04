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
            string id = "cus_2tYENskzTjjgkGQLt";
            var response = instance.GetSubscription(id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void GetSubscriptionEventsTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var response = instance.GetSubscriptionEvents(id, "es");
            Assert.IsType<SubscriptionEventsResponse>(response);
        }

        [Fact]
        public void CreateSubscriptionTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var subscriptionRequest = new SubscriptionRequest(
                planId: "plan_2tZb5q8Z3PYpg6SJd"
            );
            var response = instance.CreateSubscription(id, subscriptionRequest, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void UpdateSubscriptionTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var updatesASubscription = new UpdatesASubscription(
                planId: "plan_2tZb5q8Z3PYpg6SJd"
            );
            var response = instance.UpdateSubscription(id, updatesASubscription, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void CancelSubscriptionTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var response = instance.CancelSubscription(id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void PauseSubscriptionTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var response = instance.PauseSubscription(id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void ResumeSubscriptionTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var response = instance.ResumeSubscription(id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void SubscriptionCreateTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            var subscriptionRequest = new SubscriptionRequest(
                planId: "plan_2tZb5q8Z3PYpg6SJd"
            );
            var response = instance.SubscriptionCreate(customerId, subscriptionRequest, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void SubscriptionCancelTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            string id = "sub_2tZWxbTPtQgGJGh8S";
            var response = instance.SubscriptionCancel(customerId, id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void SubscriptionPauseTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            string id = "sub_2tZWxbTPtQgGJGh8S";
            var response = instance.SubscriptionPause(customerId, id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void SubscriptionResumeTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            string id = "sub_2tZWxbTPtQgGJGh8S";
            var response = instance.SubscriptionResume(customerId, id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void SubscriptionUpdateTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            string id = "sub_2tZWxbTPtQgGJGh8S";
            var updatesASubscription = new UpdatesASubscription(
                planId: "plan_2tZb5q8Z3PYpg6SJd"
            );
            var response = instance.SubscriptionUpdate(customerId, id, updatesASubscription, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void SubscriptionsGetTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            string id = "sub_2tZWxbTPtQgGJGh8S";
            var response = instance.SubscriptionsGet(customerId, id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void SubscriptionsRetryTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            string id = "sub_2tZWxbTPtQgGJGh8S";
            var response = instance.SubscriptionsRetry(customerId, id, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }

        [Fact]
        public void SubscriptionEventsTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            string id = "sub_2tZWxbTPtQgGJGh8S";
            var response = instance.SubscriptionEvents(customerId, id, "es");
            Assert.IsType<SubscriptionEventsResponse>(response);
        }

        [Fact]
        public void SubscriptionListTest()
        {
            string customerId = "cus_2tYENskzTjjgkGQLt";
            var response = instance.SubscriptionList(customerId, "es");
            Assert.IsType<SubscriptionResponse>(response);
        }
    }
}
