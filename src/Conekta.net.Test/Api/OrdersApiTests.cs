using System;
using System.Collections.Generic;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class OrdersApiTests : IDisposable
    {
        private OrdersApi instance;

        public OrdersApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new OrdersApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<OrdersApi>(instance);
        }

        [Fact]
        public void CreateOrderTest()
        {
            var products = new List<Product>
            {
                new Product(name: "toshiba", quantity: 1, unitPrice: 10000)
            };
            var customerInfo = new OrderRequestCustomerInfo(
                new CustomerInfo("test user", email: "test@test.com", phone: "+5215555555555")
            );
            var shippingContact = new CustomerShippingContactsRequest(
                metadata: new Dictionary<string, Object>
                {
                    { "test", "true" }
                }
            );
            var orderRequest = new OrderRequest(
                currency: "MXN",
                customerInfo: customerInfo,
                lineItems: products,
                shippingContact: shippingContact
            );
            var response = instance.CreateOrder(orderRequest, "es");
            Assert.IsType<OrderResponse>(response);
            Assert.NotNull(response.Id);
        }

        [Fact]
        public void GetOrdersTest()
        {
            var response = instance.GetOrders("es");
            Assert.IsType<GetOrdersResponse>(response);
        }

        [Fact]
        public void GetOrderByIdTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var response = instance.GetOrderById(id, "es");
            Assert.IsType<OrderResponse>(response);
        }

        [Fact]
        public void UpdateOrderTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var orderUpdate = new OrderUpdate(
                currency: "MXN"
            );
            var response = instance.UpdateOrder(id, orderUpdate, "es");
            Assert.IsType<OrderResponse>(response);
        }

        [Fact]
        public void CancelOrderTest()
        {
            string id = "ord_2tqaGQYZyvBsMKEgs";
            var response = instance.CancelOrder(id, "es");
            Assert.IsType<OrderResponse>(response);
        }

        [Fact]
        public void OrderRefundTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var refundRequest = new OrderRefundRequest(amount: 100, reason: "requested_by_client");
            var response = instance.OrderRefund(id, refundRequest, "es");
            Assert.IsType<OrderResponse>(response);
        }

        [Fact]
        public void OrderCancelRefundTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string refundId = "ref_123";
            var response = instance.OrderCancelRefund(id, refundId, "es");
            Assert.IsType<OrderResponse>(response);
        }

        [Fact]
        public void OrdersCreateCaptureTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var response = instance.OrdersCreateCapture(id, "es");
            Assert.IsType<OrderResponse>(response);
        }
    }
}
