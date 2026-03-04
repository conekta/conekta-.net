using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class BalancesApiTests : IDisposable
    {
        private BalancesApi instance;

        public BalancesApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new BalancesApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<BalancesApi>(instance);
        }

        [Fact]
        public void GetBalanceTest()
        {
            var response = instance.GetBalance("es");
            Assert.IsType<BalanceResponse>(response);
        }
    }
}
