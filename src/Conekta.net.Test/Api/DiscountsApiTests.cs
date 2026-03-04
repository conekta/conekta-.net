using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class DiscountsApiTests : IDisposable
    {
        private DiscountsApi instance;

        public DiscountsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new DiscountsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<DiscountsApi>(instance);
        }

        [Fact]
        public void OrdersGetDiscountLinesTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var response = instance.OrdersGetDiscountLines(id, "es");
            Assert.IsType<GetOrderDiscountLinesResponse>(response);
        }

        [Fact]
        public void OrdersCreateDiscountLineTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            var request = new OrderDiscountLinesRequest(
                code: "PROMO10",
                type: "coupon",
                amount: 1000
            );
            var response = instance.OrdersCreateDiscountLine(id, request, "es");
            Assert.IsType<DiscountLinesResponse>(response);
        }

        [Fact]
        public void OrdersGetDiscountLineTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string discountLinesId = "disc_123";
            var response = instance.OrdersGetDiscountLine(id, discountLinesId, "es");
            Assert.IsType<DiscountLinesResponse>(response);
        }

        [Fact]
        public void OrdersDeleteDiscountLinesTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string discountLinesId = "disc_123";
            var response = instance.OrdersDeleteDiscountLines(id, discountLinesId, "es");
            Assert.IsType<DiscountLinesResponse>(response);
        }

        [Fact]
        public void OrdersUpdateDiscountLinesTest()
        {
            string id = "ord_2tNDyQbJacvUZiyfp";
            string discountLinesId = "disc_123";
            var updateRequest = new UpdateOrderDiscountLinesRequest(
                code: "PROMO20",
                amount: 2000
            );
            var response = instance.OrdersUpdateDiscountLines(id, discountLinesId, updateRequest, "es");
            Assert.IsType<DiscountLinesResponse>(response);
        }
    }
}
