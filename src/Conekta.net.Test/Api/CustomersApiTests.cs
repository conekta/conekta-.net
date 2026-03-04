using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class CustomersApiTests : IDisposable
    {
        private CustomersApi instance;

        public CustomersApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new CustomersApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<CustomersApi>(instance);
        }

        [Fact]
        public void CreateCustomerTest()
        {
            var customer = new Customer(
                name: "test dotnet",
                email: "test@conekta.com",
                phone: "+573143159063"
            );
            var response = instance.CreateCustomer(customer, "es");
            Assert.IsType<CustomerResponse>(response);
            Assert.NotNull(response.Id);
        }

        [Fact]
        public void GetCustomersTest()
        {
            var response = instance.GetCustomers("es");
            Assert.IsType<CustomersResponse>(response);
        }

        [Fact]
        public void GetCustomerByIdTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var response = instance.GetCustomerById(id, "es");
            Assert.IsType<CustomerResponse>(response);
            Assert.NotNull(response.Id);
        }

        [Fact]
        public void UpdateCustomerTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var updateCustomer = new UpdateCustomer(
                name: "updated name"
            );
            var response = instance.UpdateCustomer(id, updateCustomer, "es");
            Assert.IsType<CustomerResponse>(response);
        }

        [Fact]
        public void DeleteCustomerByIdTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var response = instance.DeleteCustomerById(id, "es");
            Assert.IsType<CustomerResponse>(response);
        }

        [Fact]
        public void CreateCustomerFiscalEntitiesTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            var request = new FiscalEntityRequest(
                taxId: "tax_123",
                address: new FiscalEntityRequestAddress(
                    street1: "av siempre viva",
                    city: "cdmx",
                    state: "cdmx",
                    postalCode: "11011",
                    country: "MX"
                )
            );
            var response = instance.CreateCustomerFiscalEntities(id, request, "es");
            Assert.IsType<CreateCustomerFiscalEntitiesResponse>(response);
        }

        [Fact]
        public void UpdateCustomerFiscalEntitiesTest()
        {
            string id = "cus_2tYENskzTjjgkGQLt";
            string fiscalEntitiesId = "fis_ent_2tYENskzTjjgkGQLr";
            var request = new UpdateFiscalEntityRequest(
                taxId: "tax_updated"
            );
            var response = instance.UpdateCustomerFiscalEntities(id, fiscalEntitiesId, request, "es");
            Assert.IsType<UpdateCustomerFiscalEntitiesResponse>(response);
        }
    }
}
