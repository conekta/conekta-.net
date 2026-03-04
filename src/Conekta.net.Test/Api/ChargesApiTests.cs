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
            var response = instance.GetCharges("es");
            Assert.IsType<GetChargesResponse>(response);
        }

        [Fact]
        public void OrdersCreateChargeTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
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
            string id = "ord_2tNDyQbJacvUZiyfp";
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
            string id = "6524722f2b4a4101c1027a4b";
            var chargeUpdateRequest = new ChargeUpdateRequest();
            var response = instance.UpdateCharge(id, chargeUpdateRequest, "es");
            Assert.IsType<ChargeResponse>(response);
        }
    }
}
