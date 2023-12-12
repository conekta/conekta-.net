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
    ///  Class for testing ProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProductsApiTests
    {
        private readonly ProductsApi _instance;

        public ProductsApiTests()
        {
            Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new ProductsApi(configuration);
        }

        /// <summary>
        /// Test an instance of ProductsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<ProductsApi>(_instance);
        }

        /// <summary>
        ///     Test OrdersCreateProduct
        /// </summary>
        [Fact]
        public void OrdersCreateProductTest()
        {
            string id = "ord_2tVyWPnCPWbrV37mW";
            Product product = new(
                description: "Mes de marz.",
                name: "Pago Mensualidad test",
                quantity: 1,
                unitPrice: 1000,
                tags: new List<string> { "Pago 2", "Pago mensualidad 2" }
            );

            var response = _instance.OrdersCreateProduct(id, product);

            Assert.IsType<ProductOrderResponse>(response);
            Assert.Equal(id, response.ParentId);
            Assert.Equal("line_item", response.VarObject);
        }

        /// <summary>
        ///     Test OrdersUpdateProduct
        /// </summary>
        [Fact]
        public void OrdersUpdateProductTest()
        {
            string id = "ord_2tVyWPnCPWbrV37mW";
            string productId = "line_item_2tVz8UkyWhSxLfUd7";
            UpdateProduct product = new(
                description: "Pago Mensualidad"
            );

            var response = _instance.OrdersUpdateProduct(id, productId, product);

            Assert.IsType<ProductOrderResponse>(response);
            Assert.Equal(id, response.ParentId);
            Assert.Equal(productId, response.Id);
            Assert.Equal("line_item", response.VarObject);
        }
    }
}
