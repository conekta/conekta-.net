using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class LogsApiTests : IDisposable
    {
        private LogsApi instance;

        public LogsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new LogsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<LogsApi>(instance);
        }

        [Fact]
        public void GetLogsTest()
        {
            var response = instance.GetLogs("es");
            Assert.IsType<LogsResponseForRequest>(response);
        }

        [Fact]
        public void GetLogByIdTest()
        {
            string id = "6419dd15b985080001fc280e";
            var response = instance.GetLogById(id, "es");
            Assert.IsType<LogResponseForRequest>(response);
        }
    }
}
