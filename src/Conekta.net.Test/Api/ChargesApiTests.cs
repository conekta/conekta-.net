/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Xunit;

using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    /// <summary>
    ///  Class for testing ChargesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ChargesApiTests
    {
        private readonly ChargesApi _instance;

        public ChargesApiTests()
        {
            Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new ChargesApi(configuration);
        }

        /// <summary>
        /// Test an instance of ChargesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ChargesApi>(_instance);
        }

        /// <summary>
        ///     Test OrdersCreateChargeCard
        /// </summary>
        [Fact]
        public void OrdersCreateChargeCardTest()
        {
            string id = "ord_2tVKxbhNzfUnGjnXG";
            ChargeRequest chargeRequest = new(
                amount: 40000,
                paymentMethod: new ChargeRequestPaymentMethod(type:"card", tokenId:"tok_2tVKyGpobEKAR3xVH")
            );

            var response = _instance.OrdersCreateCharge(id, chargeRequest);

            Assert.IsType<ChargeOrderResponse>(response);
            Assert.Equal(chargeRequest.Amount, response.Amount);
            Assert.Equal("charge", response.Object);
            Assert.Equal("pre_authorized", response.Status);
            Assert.Equal("card_payment", response.PaymentMethod.GetPaymentMethodCard().Object);
            Assert.Equal("credit", response.PaymentMethod.GetPaymentMethodCard().Type);
        }
        /// <summary>
        ///     Test OrdersCreateChargeCash
        /// </summary>
        [Fact]
        public void OrdersCreateChargeCashTest()
        {
            string id = "ord_2tVL8dT1Hm3y3YiaN";
            ChargeRequest chargeRequest = new(
                amount: 40000,
                paymentMethod: new ChargeRequestPaymentMethod(type:"cash")
            );

            var response = _instance.OrdersCreateCharge(id, chargeRequest);

            Assert.IsType<ChargeOrderResponse>(response);
            Assert.Equal(chargeRequest.Amount, response.Amount);
            Assert.Equal("charge", response.Object);
            Assert.Equal("pending_payment", response.Status);
            Assert.Equal("cash_payment", response.PaymentMethod.GetPaymentMethodCash().Object);
            Assert.Equal("oxxo", response.PaymentMethod.GetPaymentMethodCash().Type);
            Assert.False(string.IsNullOrEmpty(response.PaymentMethod.GetPaymentMethodCash().BarcodeUrl));
            Assert.True(string.IsNullOrEmpty(response.PaymentMethod.GetPaymentMethodCash().CashierId));
            Assert.Null(response.PaymentMethod.GetPaymentMethodCash().AuthCode);
            Assert.True(string.IsNullOrEmpty(response.PaymentMethod.GetPaymentMethodCash().Store));
        }
        /// <summary>
        ///     Test OrdersCreateChargeSpei
        /// </summary>
        [Fact]
        public void OrdersCreateChargeSpeiTest()
        {
            string id = "ord_2tVLUFrQBB4HKz1zj";
            ChargeRequest chargeRequest = new(
                amount: 40000,
                paymentMethod: new ChargeRequestPaymentMethod(type:"spei")
            );

            var response = _instance.OrdersCreateCharge(id, chargeRequest);

            Assert.IsType<ChargeOrderResponse>(response);
            Assert.Equal(chargeRequest.Amount, response.Amount);
            Assert.Equal("charge", response.Object);
            Assert.Equal("pending_payment", response.Status);
            Assert.Equal("bank_transfer_payment", response.PaymentMethod.GetPaymentMethodBankTransfer().Object);
            Assert.Equal("spei", response.PaymentMethod.GetPaymentMethodBankTransfer().Type);
            Assert.Equal("6408c87bde4b8e00010744e3", response.Id);
            Assert.Equal(id, response.OrderId);
            Assert.Equal("646180111805035472", response.PaymentMethod.GetPaymentMethodBankTransfer().Clabe);
            Assert.Equal("STP", response.PaymentMethod.GetPaymentMethodBankTransfer().Bank);
        }

    }
}
