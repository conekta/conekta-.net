/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System.Collections.Generic;
using Xunit;

using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    /// <summary>
    ///  Class for testing TransfersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class TransfersApiTests
    {
        private readonly TransfersApi _instance;

        public TransfersApiTests()
        {
            Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new TransfersApi(configuration);
        }

        /// <summary>
        /// Test an instance of TransfersApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TransfersApi>(_instance);
        }

        /// <summary>
        /// Test GetTransfer
        /// </summary>
        [Fact]
        public void GetTransferTest()
        {
            const string id = "64462930651b2600017b6d43";
            var response = _instance.GetTransfer(id);
            
            Assert.IsType<TransferResponse>(response);
            Assert.Equal(id, response.Id);
            Assert.NotNull(response.Destination);
            Assert.Equal("bank_transfer", response.Destination.Type);
            Assert.Equal("transfer", response.Object);
            Assert.IsType<TransferDestinationResponse>(response.Destination);
        }

        /// <summary>
        /// Test GetTransfers
        /// </summary>
        [Fact]
        public void GetTransfersTest()
        {
            const int limit = 5;
            var response = _instance.GetTransfers(limit: limit);
            
            Assert.IsType<GetTransfersResponse>(response);
            Assert.Equal(limit, response.Data.Count);
            Assert.True(response.HasMore);
            Assert.NotNull(response.NextPageUrl);
            Assert.IsType<List<TransfersResponse>>(response.Data);
            Assert.Equal("pytmtd_2tkZEwpk1cWYvFZhQ", response.Data[0].Method.Id);
        }
        /// <summary>
        /// Test GetTransfers
        /// </summary>
        [Fact]
        public void GetTransfersWithNextTest()
        {
            const int limit = 6;
            var response = _instance.GetTransfers(limit: limit, next: "6419562fdb5c8a0001e1cd61");
            
            Assert.IsType<GetTransfersResponse>(response);
            Assert.Equal(limit, response.Data.Count);
            Assert.True(response.HasMore);
            Assert.NotNull(response.NextPageUrl);
            Assert.NotNull(response.PreviousPageUrl);
            Assert.IsType<List<TransfersResponse>>(response.Data);
            Assert.Equal("pytmtd_2tXokM6kBiAySsCB6", response.Data[0].Method.Id);
        }
    }
}
