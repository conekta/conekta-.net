using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class ProductsApiTests : IDisposable
    {
        private ProductsApi instance;

        public ProductsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new ProductsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ProductsApi>(instance);
        }

        [Fact]
        public void OrdersCreateProductTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var product = new Product(
                name: "test product",
                quantity: 1,
                unitPrice: 10000
            );
            var response = instance.OrdersCreateProduct(id, product, "es");
            Assert.IsType<ProductOrderResponse>(response);
        }

        [Fact]
        public void OrdersDeleteProductTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string lineItemId = "line_item_123";
            var response = instance.OrdersDeleteProduct(id, lineItemId, "es");
            Assert.IsType<ProductOrderResponse>(response);
        }

        [Fact]
        public void OrdersUpdateProductTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string lineItemId = "line_item_123";
            var updateProduct = new UpdateProduct(
                name: "updated product",
                quantity: 2,
                unitPrice: 15000
            );
            var response = instance.OrdersUpdateProduct(id, lineItemId, updateProduct, "es");
            Assert.IsType<ProductOrderResponse>(response);
        }
    }
}
