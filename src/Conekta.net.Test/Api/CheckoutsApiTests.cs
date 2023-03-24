/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using Xunit;

using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    /// <summary>
    ///  Class for testing CheckoutsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CheckoutsApiTests
    {
        private readonly CheckoutsApi _instance;

        public CheckoutsApiTests()
        {
            var configuration = new Configuration
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt7as"
            };
            _instance = new CheckoutsApi(configuration);
        }

        /// <summary>
        /// Test an instance of CheckoutsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<CheckoutsApi>(_instance);
        }

        /// <summary>
        /// Test CancelCheckout
        /// </summary>
        [Fact]
        public void CancelCheckoutTest()
        {
            string id = "c7734ada-e1e9-4b22-90f6-b80a1b2006d4";
            var response = _instance.CancelCheckout(id, "es");

            Assert.IsType<CheckoutResponse>(response);
            Assert.Equal("Cancelled", response.Status);
            Assert.Equal(id, response.Id);
            Assert.Equal("checkout", response.Object);
            Assert.Equal(5, response.PaymentsLimitCount);
            Assert.False(response.CanNotExpire);
            Assert.True(response.Recurrent);
        }

        /// <summary>
        /// Test CreateCheckout
        /// </summary>
        [Fact]
        public void CreateCheckoutPaymentLinkTest()
        {
            DateTime currentTime = DateTime.UtcNow.AddDays(200);
            long expiresAt = ((DateTimeOffset)currentTime).ToUnixTimeSeconds();
            Checkout checkout = new(
                allowedPaymentMethods: new List<string>() { "card", "cash", "bank_transfer" },
                type: "PaymentLink",
                name: "Payment Link Name netcore sdk",
                recurrent: false,
                needsShippingContact: false,
                expiresAt: expiresAt,
                orderTemplate: new CheckoutOrderTemplate("MXN", new List<LineItems>() { new LineItems(name: "toshiba", quantity: 1, unitPrice: 500) })
            );
            CheckoutResponse response = _instance.CreateCheckout(checkout);

            Assert.IsType<CheckoutResponse>(response);
            Assert.Equal(expiresAt, response.ExpiresAt);
            Assert.Equal("e4bcbed2-194c-4540-a922-b6d7531925a3", response.Id);
            Assert.Equal(checkout.Type, response.Type);
            Assert.Equal(checkout.AllowedPaymentMethods, response.AllowedPaymentMethods);
            Assert.Equal(checkout.Name, response.Name);
        }

        /// <summary>
        /// Test EmailCheckout
        /// </summary>
        [Fact]
        public void EmailCheckoutTest()
        {
            string id = "102bdf5c-3ee6-48ec-a9ff-40ec6f5f054b";
            EmailCheckoutRequest emailCheckoutRequest = new("example@conekta.com");

            var response = _instance.EmailCheckout(id, emailCheckoutRequest);

            Assert.IsType<CheckoutResponse>(response);
            Assert.Equal(1, response.EmailsSent);
            Assert.Equal(0, response.SmsSent);
            Assert.Equal(id, response.Id);
            Assert.Equal("Issued", response.Status);
            Assert.True(response.Recurrent);
            Assert.Equal("value", response.Metadata["key"]);
        }

        /// <summary>
        /// Test GetCheckout
        /// </summary>
        [Fact]
        public void GetCheckoutTest()
        {
            var id = "bac0ed14-6888-4d1d-927a-c80d3f55c009";
            var response = _instance.GetCheckout(id, "es");

            Assert.IsType<CheckoutResponse>(response);
            Assert.Equal(id, response.Id);
            Assert.Equal("Expired", response.Status);
            Assert.Equal("HostedPayment", response.Type);
            Assert.NotEmpty(response.Url);
            Assert.NotEmpty(response.SuccessUrl);
            Assert.NotEmpty(response.FailureUrl);
        }

        /// <summary>
        /// Test GetCheckouts
        /// </summary>
        [Fact]
        public void GetCheckoutsTest()
        {
            var response = _instance.GetCheckouts("en");

            Assert.IsType<CheckoutsResponse>(response);
            Assert.Equal("list", response.Object);
            Assert.Equal("https://api-core.stg.conekta.io/checkouts?next=bac0ed14-6888-4d1d-927a-c80d3f55c009", response.NextPageUrl);
            Assert.Equal(20, response.Data.Count);
        }

        /// <summary>
        /// Test SmsCheckout
        /// </summary>
        [Fact]
        public void SmsCheckoutTest()
        {
            string id = "ce1076bb-5ee6-4d08-a0e2-ec0bfbc49883";
            SmsCheckoutRequest smsCheckoutRequest = new("5566982090");

            var response = _instance.SmsCheckout(id, smsCheckoutRequest);

            Assert.IsType<CheckoutResponse>(response);
            Assert.Equal(id, response.Id);
            Assert.Equal(1, response.SmsSent);
            Assert.Equal(0, response.EmailsSent);
        }
    }
}
