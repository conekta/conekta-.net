using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class CompaniesApiTests : IDisposable
    {
        private CompaniesApi instance;

        public CompaniesApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new CompaniesApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<CompaniesApi>(instance);
        }

        [Fact]
        public void GetCompaniesTest()
        {
            var response = instance.GetCompanies("es");
            Assert.IsType<GetCompaniesResponse>(response);
        }

        [Fact]
        public void GetCompanyTest()
        {
            string id = "comp_123";
            var response = instance.GetCompany(id, "es");
            Assert.IsType<CompanyResponse>(response);
        }
    }
}
