using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class TaxesApiTests : IDisposable
    {
        private TaxesApi instance;

        public TaxesApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new TaxesApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TaxesApi>(instance);
        }

        [Fact]
        public void OrdersCreateTaxesTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var orderTaxRequest = new OrderTaxRequest(
                description: "IVA",
                amount: 1600
            );
            var response = instance.OrdersCreateTaxes(id, orderTaxRequest, "es");
            Assert.IsType<OrderTaxResponse>(response);
        }

        [Fact]
        public void OrdersDeleteTaxesTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string taxId = "tax_lin_123";
            var response = instance.OrdersDeleteTaxes(id, taxId, "es");
            Assert.IsType<OrderTaxResponse>(response);
        }

        [Fact]
        public void OrdersUpdateTaxesTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string taxId = "tax_lin_123";
            var updateRequest = new OrdersUpdateTaxesRequest(
                description: "IVA updated",
                amount: 1800
            );
            var response = instance.OrdersUpdateTaxes(id, taxId, updateRequest, "es");
            Assert.IsType<OrderTaxResponse>(response);
        }
    }
}
