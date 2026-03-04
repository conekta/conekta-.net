using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class ChargesApiTests : IDisposable
    {
        private ChargesApi instance;

        public ChargesApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new ChargesApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ChargesApi>(instance);
        }

        [Fact]
        public void GetChargesTest()
        {
            var response = instance.GetCharges("es", limit: 20);
            Assert.IsType<GetChargesResponse>(response);
        }

        [Fact]
        public void OrdersCreateChargeTest()
        {
            string id = "ord_2tVKxbhNzfUnGjnXG";
            var chargeRequest = new ChargeRequest(
                paymentMethod: new ChargeRequestPaymentMethod(
                    new PaymentMethodGeneralRequest(type: "oxxo")
                )
            );
            var response = instance.OrdersCreateCharge(id, chargeRequest, "es");
            Assert.IsType<ChargeOrderResponse>(response);
        }

        [Fact]
        public void OrdersCreateChargesTest()
        {
            string id = "ord_2wrW9arie9fUG4MfD";
            var chargeRequest = new ChargeRequest(
                paymentMethod: new ChargeRequestPaymentMethod(
                    new PaymentMethodGeneralRequest(type: "oxxo")
                )
            );
            var response = instance.OrdersCreateCharges(id, chargeRequest, "es");
            Assert.IsType<ChargesOrderResponse>(response);
        }

        [Fact]
        public void UpdateChargeTest()
        {
            string id = "6524722f28c7ba0016a5b17d";
            var chargeUpdateRequest = new ChargeUpdateRequest();
            var response = instance.UpdateCharge(id, chargeUpdateRequest, "es");
            Assert.IsType<ChargeResponse>(response);
        }
    }
}
