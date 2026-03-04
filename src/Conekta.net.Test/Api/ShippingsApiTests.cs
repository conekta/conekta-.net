using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class ShippingsApiTests : IDisposable
    {
        private ShippingsApi instance;

        public ShippingsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new ShippingsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ShippingsApi>(instance);
        }

        [Fact]
        public void OrdersCreateShippingTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var shippingRequest = new ShippingRequest(
                amount: 5000,
                carrier: "estafeta"
            );
            var response = instance.OrdersCreateShipping(id, shippingRequest, "es");
            Assert.IsType<ShippingOrderResponse>(response);
        }

        [Fact]
        public void OrdersDeleteShippingTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string shippingId = "ship_123";
            var response = instance.OrdersDeleteShipping(id, shippingId, "es");
            Assert.IsType<ShippingOrderResponse>(response);
        }

        [Fact]
        public void OrdersUpdateShippingTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string shippingId = "ship_123";
            var shippingRequest = new ShippingRequest(
                amount: 6000,
                carrier: "dhl"
            );
            var response = instance.OrdersUpdateShipping(id, shippingId, shippingRequest, "es");
            Assert.IsType<ShippingOrderResponse>(response);
        }
    }
}
