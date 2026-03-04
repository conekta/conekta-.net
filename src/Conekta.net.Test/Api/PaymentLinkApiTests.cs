using System;
using System.Collections.Generic;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class PaymentLinkApiTests : IDisposable
    {
        private PaymentLinkApi instance;

        public PaymentLinkApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new PaymentLinkApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<PaymentLinkApi>(instance);
        }

        [Fact]
        public void GetCheckoutsTest()
        {
            var response = instance.GetCheckouts("es");
            Assert.IsType<CheckoutsResponse>(response);
        }

        [Fact]
        public void GetCheckoutTest()
        {
            string id = "checkout_123";
            var response = instance.GetCheckout(id, "es");
            Assert.IsType<CheckoutResponse>(response);
        }

        [Fact]
        public void CreateCheckoutTest()
        {
            var checkout = new Checkout(
                allowedPaymentMethods: new List<string> { "card", "cash" },
                expiresAt: 1735689600,
                name: "test checkout",
                orderTemplate: new CheckoutOrderTemplate(
                    currency: "MXN",
                    lineItems: new List<Product>
                    {
                        new Product(name: "test product", quantity: 1, unitPrice: 10000)
                    }
                ),
                recurrent: false,
                type: "PaymentLink"
            );
            var response = instance.CreateCheckout(checkout, "es");
            Assert.IsType<CheckoutResponse>(response);
        }

        [Fact]
        public void CancelCheckoutTest()
        {
            string id = "checkout_123";
            var response = instance.CancelCheckout(id, "es");
            Assert.IsType<CheckoutResponse>(response);
        }

        [Fact]
        public void EmailCheckoutTest()
        {
            string id = "checkout_123";
            var emailRequest = new EmailCheckoutRequest(email: "test@test.com");
            var response = instance.EmailCheckout(id, emailRequest, "es");
            Assert.IsType<CheckoutResponse>(response);
        }

        [Fact]
        public void SmsCheckoutTest()
        {
            string id = "checkout_123";
            var smsRequest = new SmsCheckoutRequest(phonenumber: "+5215555555555");
            var response = instance.SmsCheckout(id, smsRequest, "es");
            Assert.IsType<CheckoutResponse>(response);
        }
    }
}
