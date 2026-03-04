using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class SubscriptionsCustomerPortalApiTests : IDisposable
    {
        private SubscriptionsCustomerPortalApi instance;

        public SubscriptionsCustomerPortalApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new SubscriptionsCustomerPortalApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<SubscriptionsCustomerPortalApi>(instance);
        }

        [Fact]
        public void CreateCustomerPortalTest()
        {
            string subscriptionId = "sub_2tZWxbTPtQgGJGh8S";
            var response = instance.CreateCustomerPortal(subscriptionId, "es");
            Assert.IsType<CustomerPortalResponse>(response);
        }

        [Fact]
        public void GetCustomerPortalTest()
        {
            string subscriptionId = "sub_2tZWxbTPtQgGJGh8S";
            var response = instance.GetCustomerPortal(subscriptionId, "es");
            Assert.IsType<CustomerPortalResponse>(response);
        }
    }
}
