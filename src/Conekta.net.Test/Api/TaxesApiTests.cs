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
// uncomment below to import models
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    /// <summary>
    ///  Class for testing TaxesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TaxesApiTests
    {
        private readonly TaxesApi _instance;

        public TaxesApiTests()
        {
            Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new TaxesApi(configuration);
        }


        /// <summary>
        /// Test an instance of TaxesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TaxesApi>(_instance);
        }

        /// <summary>
        ///     Test OrdersCreateTaxLines
        /// </summary>
        [Fact]
        public void OrdersCreateTaxLinesTest()
        {
            string id = "ord_2tVyWPnCPWbrV37mW";
            OrderTaxLinesRequest orderTaxLinesRequest = new(
                amount: 100,
                description: "test",
                metadata: new Dictionary<string, Object> { { "key", "value" } }
            );

            var response = _instance.OrdersCreateTaxLines(id, orderTaxLinesRequest);

            Assert.IsType<UpdateOrderTaxLinesResponse>(response);
            Assert.Equal(orderTaxLinesRequest.Amount, response.Amount);
            Assert.Equal(id, response.ParentId);
            Assert.False(string.IsNullOrEmpty(response.Id));
        }

        /// <summary>
        ///     Test OrdersUpdateTaxLines
        /// </summary>
        [Fact]
        public void OrdersUpdateTaxLinesTest()
        {
            string id = "ord_2tVyWPnCPWbrV37mW";
            string taxLinesId = "tax_lin_2tVzVp6AAptCRHhgt";
            UpdateOrderTaxLinesRequest updateOrderTaxLinesRequest = new(
                amount: 99
                );

            var response = _instance.OrdersUpdateTaxLines(id, taxLinesId, updateOrderTaxLinesRequest);

            Assert.IsType<UpdateOrderTaxLinesResponse>(response);
            Assert.Equal(updateOrderTaxLinesRequest.Amount, response.Amount);
            Assert.Equal(id, response.ParentId);
            Assert.Equal(taxLinesId, response.Id);
        }
    }
}