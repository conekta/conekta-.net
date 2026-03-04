using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class TransactionsApiTests : IDisposable
    {
        private TransactionsApi instance;

        public TransactionsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new TransactionsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<TransactionsApi>(instance);
        }

        [Fact]
        public void GetTransactionsTest()
        {
            var response = instance.GetTransactions("es", limit: 2);
            Assert.IsType<GetTransactionsResponse>(response);
        }

        [Fact]
        public void GetTransactionTest()
        {
            string id = "6456b6dfac0fd40001a64eb8";
            var response = instance.GetTransaction(id, "es");
            Assert.IsType<TransactionResponse>(response);
        }
    }
}
