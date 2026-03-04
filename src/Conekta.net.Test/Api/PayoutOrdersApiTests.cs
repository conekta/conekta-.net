using System;
using System.Collections.Generic;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class PayoutOrdersApiTests : IDisposable
    {
        private PayoutOrdersApi instance;

        public PayoutOrdersApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new PayoutOrdersApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<PayoutOrdersApi>(instance);
        }

        [Fact]
        public void GetPayoutOrdersTest()
        {
            var response = instance.GetPayoutOrders("es");
            Assert.IsType<PayoutOrdersResponse>(response);
        }

        [Fact]
        public void GetPayoutOrderByIdTest()
        {
            string id = "f2654d66-d740-457a-9a8c-f96b5196f44e";
            var response = instance.GetPayoutOrderById(id, "es");
            Assert.IsType<PayoutOrderResponse>(response);
        }

        [Fact]
        public void CreatePayoutOrderTest()
        {
            var payoutOrder = new PayoutOrderRequest(
                allowedPayoutMethods: new List<string> { "cashout" },
                amount: 3000,
                currency: "MXN",
                customerInfo: new PayoutOrderRequestCustomerInfo(
                    customerId: "cus_2tYENskzTjjgkGQLt"
                ),
                payout: new Payout(payoutMethod: new PayoutMethod(type: "cashout")),
                reason: "test payout"
            );
            var response = instance.CreatePayoutOrder(payoutOrder, "es");
            Assert.IsType<PayoutOrderResponse>(response);
        }
    }
}
