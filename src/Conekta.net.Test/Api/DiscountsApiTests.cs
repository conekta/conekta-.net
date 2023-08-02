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
    ///  Class for testing DiscountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DiscountsApiTests
    {
        private readonly DiscountsApi _instance;

        public DiscountsApiTests()
        {
            Configuration configuration = new Configuration()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new DiscountsApi(configuration);
        }

        /// <summary>
        /// Test an instance of DiscountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<DiscountsApi>(_instance);
        }

        /// <summary>
        ///     Test OrdersCreateDiscountLine
        /// </summary>
        [Fact]
        public void OrdersCreateDiscountLineTest()
        {
            string id = "ord_2tVyWPnCPWbrV37mW";
            OrderDiscountLinesRequest orderDiscountLinesRequest = new OrderDiscountLinesRequest(
                amount: 500,
                code: "track",
                type: "loyalty"
            );

            var response = _instance.OrdersCreateDiscountLine(id, orderDiscountLinesRequest);

            Assert.IsType<DiscountLinesResponse>(response);
            Assert.Equal(id, response.ParentId);
            Assert.Equal(orderDiscountLinesRequest.Amount, response.Amount);
            Assert.False(string.IsNullOrEmpty(response.Id));
        }


        /// <summary>
        ///     Test OrdersUpdateDiscountLines
        /// </summary>
        [Fact]
        public void OrdersUpdateDiscountLinesTest()
        {
            string id = "ord_2tVyWPnCPWbrV37mW";
            string discountLinesId = "dis_lin_2tVyahK8Nts7rKRMZ";
            UpdateOrderDiscountLinesRequest orderDiscountLinesRequest = new UpdateOrderDiscountLinesRequest(
                amount: 100
            );

            var response = _instance.OrdersUpdateDiscountLines(id, discountLinesId, orderDiscountLinesRequest);

            Assert.IsType<DiscountLinesResponse>(response);
            Assert.Equal(orderDiscountLinesRequest.Amount, response.Amount);
            Assert.Equal(id, response.ParentId);
        }
    }
}
