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
            var response = instance.GetTransactions("es");
            Assert.IsType<GetTransactionsResponse>(response);
        }

        [Fact]
        public void GetTransactionTest()
        {
            string id = "txn_123";
            var response = instance.GetTransaction(id, "es");
            Assert.IsType<TransactionResponse>(response);
        }
    }
}
