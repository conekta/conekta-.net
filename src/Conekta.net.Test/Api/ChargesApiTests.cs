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

            PaymentMethodCardRequest cardRequest = new PaymentMethodCardRequest(
                type: "credit",    
                cvc: "123",        
                expMonth: "12",    
                expYear: "2025",   
                name: "John Doe",  
                number: "4242424242424242" 
            );

            ChargeRequest chargeRequest = new(
                amount: 40000,
                paymentMethod: new ChargeRequestPaymentMethod(cardRequest)
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
            PaymentMethodCardRequest cardRequest = new PaymentMethodCardRequest(
                type: "credit",    
                cvc: "123",        
                expMonth: "12",    
                expYear: "2025",  
                name: "John Doe",  
                number: "4242424242424242" 
            );
            ChargeRequest chargeRequest = new(
                amount: 40000,
                paymentMethod: new ChargeRequestPaymentMethod(cardRequest)
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

        [Fact]
        public void OrdersCreateChargesCashTest()
        {
            string id = "ord_2wrW9arie9fUG4MfD";
            ChargeRequest chargeRequest = new(
                paymentMethod: new ChargeRequestPaymentMethod(new PaymentMethodGeneralRequest(type:"cash"))
            );
            var response = _instance.OrdersCreateCharges(id, chargeRequest);
            
            Assert.IsType<ChargesOrderResponse>(response);
            Assert.Equal(2, response.Data.Count);
            Assert.Equal("2409992", response.Data[0].Agreement);
            Assert.Equal("bbva_cash_in", response.Data[0].ProductType);
        }

        /// <summary>
        ///     Test OrdersCreateChargeSpei
        /// </summary>
        [Fact]
        public void OrdersCreateChargeSpeiTest()
        {
            string id = "ord_2tVLUFrQBB4HKz1zj";
            PaymentMethodCardRequest cardRequest = new PaymentMethodCardRequest(
                type: "credit",    
                cvc: "123",        
                expMonth: "12",    
                expYear: "2025",   
                name: "John Doe",  
                number: "4242424242424242" 
            );
            ChargeRequest chargeRequest = new(
                amount: 40000,
                paymentMethod: new ChargeRequestPaymentMethod(cardRequest)
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

        /// <summary>
        ///     Test GetAllCharges
        /// </summary>
        [Fact]
        public void GetAllChargesTest()
        {
            var response = _instance.GetCharges(
                   limit: 20,
                   acceptLanguage: "es"
               );

            Assert.IsType<GetChargesResponse>(response);
            Assert.True(response.HasMore);
            Assert.Equal(20, response.Data.Count);
            Assert.Equal("channel_2tqJMS7on7HBVqWKo", response.Data[0].Channel.Id);
            Assert.Equal("93003547316416", response.Data[0].PaymentMethod.GetPaymentMethodCash().Reference);
            Assert.True(response.Data[0].Refunds == null);
            Assert.True(string.IsNullOrEmpty(response.Data[0].ReferenceId));
        }

        [Fact]
        public void UpdateChargeTest()
        {
           var response = _instance.UpdateCharge("6524722f28c7ba0016a5b17d", new ChargeUpdateRequest(referenceId:"123456789"));
           
           Assert.IsType<ChargeResponse>(response);
           Assert.Equal("123456789", response.ReferenceId);
           Assert.Equal("charge", response.Object);
           Assert.Equal("cash_payment", response.PaymentMethod.GetPaymentMethodCash().Object);
           Assert.Equal("6524722f28c7ba0016a5b17d", response.Id);
        }
    }
}
