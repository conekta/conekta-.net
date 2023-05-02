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
    ///  Class for testing LogsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LogsApiTests 
    {
        private readonly LogsApi _instance;

        public LogsApiTests()
        {
             Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new LogsApi(configuration);
        }


        /// <summary>
        /// Test an instance of LogsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<LogsApi>(_instance);
        }

        /// <summary>
        /// Test GetLogById
        /// </summary>
        [Fact]
        public void GetLogByIdTest()
        {
            string id = "6419dd15b985080001fc280e";
            
            var response = _instance.GetLogById(id, "es");
            
            Assert.IsType<LogResponse>(response);
            Assert.NotNull(response.ResponseBody);
            Assert.NotNull(response.ResponseHeaders);
        }

        /// <summary>
        /// Test GetLogs
        /// </summary>
        [Fact]
        public void GetLogsTest()
        {
            var response = _instance.GetLogs("en", null, 20);

            Assert.IsType<LogsResponse>(response);
            Assert.Equal(20, response.Data.Count);
            Assert.NotNull(response.Data[0].RequestHeaders);
        }
    }
}
