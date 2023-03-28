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
    ///  Class for testing PaymentMethodsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaymentMethodsApiTests
    {
        private readonly PaymentMethodsApi _instance;

        public PaymentMethodsApiTests()
        {
            Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72A"
            };
            _instance = new PaymentMethodsApi(configuration);
        }

        /// <summary>
        /// Test an instance of PaymentMethodsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<PaymentMethodsApi>(_instance);
        }

        /// <summary>
        /// Test CreateCustomerPaymentSources
        /// </summary>
        [Fact]
        public void CreateCustomerPaymentSourcesTest()
        {
            string id = "cus_2tXyF9BwPG14UMkkg";
            CreateCustomerPaymentSourcesRequest createCustomerPaymentSourcesRequest = new(
                new PaymentSourcesCash("oxxo_recurrent")
            );
            var response = _instance.CreateCustomerPaymentSources(id, createCustomerPaymentSourcesRequest);

            Assert.IsType<CreateCustomerPaymentSourcesResponse>(response);
            Assert.IsType<PaymentSourceCash>(response.ActualInstance);
            Assert.Equal(id, response.GetPaymentSourceCash().ParentId);
            Assert.False(string.IsNullOrEmpty(response.GetPaymentSourceCash().Id));
            Assert.False(string.IsNullOrEmpty(response.GetPaymentSourceCash().BarcodeUrl));
        }

        /// <summary>
        /// Test DeleteCustomerPaymentSources
        /// </summary>
        [Fact]
        public void DeleteCustomerPaymentSourcesTest()
        {
            string id = "cus_2tZWxbTPtQgGJGh8P";
            string paymentSourcesId = "src_2tZWxbTPtQgGJGh8R";

            var response = _instance.DeleteCustomerPaymentSources(id, paymentSourcesId, "en");

            Assert.IsType<UpdateCustomerPaymentSourcesResponse>(response);
            Assert.Equal(id, response.GetPaymentSourceCard().ParentId);
            Assert.Equal(paymentSourcesId, response.GetPaymentSourceCard().Id);
        }

        /// <summary>
        /// Test UpdateCustomerPaymentSources
        /// </summary>
        [Fact]
        public void UpdateCustomerPaymentSourcesTest()
        {
            string id = "cus_2tZWxbTPtQgGJGh8P";
            string paymentSourcesId = "src_2tZWxbTPtQgGJGh8R";
            UpdatePaymentSources updatePaymentSources = new(
               name: "name of person"
            );
            var response = _instance.UpdateCustomerPaymentSources(id, paymentSourcesId, updatePaymentSources);

            Assert.IsType<UpdateCustomerPaymentSourcesResponse>(response);
            Assert.Equal(updatePaymentSources.Name, response.GetPaymentSourceCard().Name);
            Assert.Equal(id, response.GetPaymentSourceCard().ParentId);
            Assert.Equal(paymentSourcesId, response.GetPaymentSourceCard().Id);
        }
    }
}
