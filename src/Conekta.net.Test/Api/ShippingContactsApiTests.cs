using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class ShippingContactsApiTests : IDisposable
    {
        private ShippingContactsApi instance;

        public ShippingContactsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new ShippingContactsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ShippingContactsApi>(instance);
        }

        [Fact]
        public void CreateCustomerShippingContactsTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var request = new CustomerShippingContactsRequest(
                phone: "+5215555555555",
                address: new CustomerShippingContactsRequestAddress(
                    street1: "av siempre viva",
                    city: "cdmx",
                    state: "cdmx",
                    postalCode: "11011",
                    country: "MX"
                )
            );
            var response = instance.CreateCustomerShippingContacts(id, request, "es");
            Assert.IsType<CustomerShippingContactsResponse>(response);
        }

        [Fact]
        public void DeleteCustomerShippingContactsTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            string shippingContactsId = "ship_cont_2tYENskzTjjgkGQLs";
            var response = instance.DeleteCustomerShippingContacts(id, shippingContactsId, "es");
            Assert.IsType<CustomerShippingContactsResponse>(response);
        }

        [Fact]
        public void UpdateCustomerShippingContactsTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            string shippingContactsId = "ship_cont_2tYENskzTjjgkGQLs";
            var request = new CustomerUpdateShippingContactsRequest(
                phone: "+5215555555555"
            );
            var response = instance.UpdateCustomerShippingContacts(id, shippingContactsId, request, "es");
            Assert.IsType<CustomerShippingContactsResponse>(response);
        }
    }
}
