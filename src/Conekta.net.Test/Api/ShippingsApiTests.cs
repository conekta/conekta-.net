/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    /// <summary>
    ///  Class for testing ShippingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ShippingsApiTests
    {
        private readonly ShippingsApi _instance;

        public ShippingsApiTests()
        {
            Configuration configuration = new Configuration()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new ShippingsApi(configuration);
        }
        /// <summary>
        /// Test an instance of ShippingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ShippingsApi>(_instance);
        }
        /// <summary>
        ///     Test OrdersCreateShipping
        /// </summary>
        [Fact]
        public void OrdersCreateShippingTest()
        {
            string id = "ord_2tVyWPnCPWbrV37mW";
            ShippingRequest shippingRequest = new ShippingRequest(
                amount: 500
            );

            var response = _instance.OrdersCreateShipping(id, shippingRequest);

            Assert.IsType<ShippingOrderResponse>(response);
            Assert.Equal(id, response.ParentId);
            Assert.Equal(shippingRequest.Amount, response.Amount);
            Assert.Equal("shipping_line", response.Object);
        }


        /// <summary>
        ///     Test OrdersUpdateShipping
        /// </summary>
        [Fact]
        public void OrdersUpdateShippingTest()
        {
            string id = "ord_2tVyWPnCPWbrV37mW";
            string shippingId = "ship_lin_2tVzNuDGSaDwreMg6";
            ShippingRequest shippingRequest = new ShippingRequest(
                amount: 540
            );

            var response = _instance.OrdersUpdateShipping(id, shippingId, shippingRequest);

            Assert.IsType<ShippingOrderResponse>(response);
            Assert.Equal(shippingRequest.Amount, response.Amount);
            Assert.Equal(shippingId, response.Id);
            Assert.Equal(id, response.ParentId);
        }
    }
}
