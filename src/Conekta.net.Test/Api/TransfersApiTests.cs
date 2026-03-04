using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class TransfersApiTests : IDisposable
    {
        private TransfersApi instance;

        public TransfersApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new TransfersApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TransfersApi>(instance);
        }

        [Fact]
        public void GetTransfersTest()
        {
            var response = instance.GetTransfers("es");
            Assert.IsType<GetTransfersResponse>(response);
        }

        [Fact]
        public void GetTransferTest()
        {
            string id = "transfer_123";
            var response = instance.GetTransfer(id, "es");
            Assert.IsType<TransferResponse>(response);
        }
    }
}
