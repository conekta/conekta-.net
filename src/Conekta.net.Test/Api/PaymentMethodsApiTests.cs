using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class PaymentMethodsApiTests : IDisposable
    {
        private PaymentMethodsApi instance;

        public PaymentMethodsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new PaymentMethodsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<PaymentMethodsApi>(instance);
        }

        [Fact]
        public void GetCustomerPaymentMethodsTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var response = instance.GetCustomerPaymentMethods(id, "es");
            Assert.IsType<GetPaymentMethodResponse>(response);
        }

        [Fact]
        public void CreateCustomerPaymentMethodsTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var request = new CreateCustomerPaymentMethodsRequest(
                new PaymentMethodCashRequest(type: "oxxo")
            );
            var response = instance.CreateCustomerPaymentMethods(id, request, "es");
            Assert.IsType<CreateCustomerPaymentMethodsResponse>(response);
        }

        [Fact]
        public void UpdateCustomerPaymentMethodsTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            string paymentMethodId = "src_2tbd5Bgy67RL9oycM";
            var updatePaymentMethods = new UpdatePaymentMethodsCard(
                name: "updated card"
            );
            var response = instance.UpdateCustomerPaymentMethods(id, paymentMethodId, updatePaymentMethods, "es");
            Assert.IsType<UpdateCustomerPaymentMethodsResponse>(response);
        }

        [Fact]
        public void DeleteCustomerPaymentMethodsTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            string paymentMethodId = "src_2tbd5Bgy67RL9oycM";
            var response = instance.DeleteCustomerPaymentMethods(id, paymentMethodId, "es");
            Assert.IsType<UpdateCustomerPaymentMethodsResponse>(response);
        }
    }
}
