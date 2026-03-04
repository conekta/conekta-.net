using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class AntifraudApiTests : IDisposable
    {
        private AntifraudApi instance;

        public AntifraudApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new AntifraudApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<AntifraudApi>(instance);
        }

        [Fact]
        public void GetRuleWhitelistTest()
        {
            var response = instance.GetRuleWhitelist("es");
            Assert.IsType<RiskRulesList>(response);
        }

        [Fact]
        public void CreateRuleWhitelistTest()
        {
            var data = new CreateRuleWhitelistRequest(
                description: "test rule",
                field: "email",
                value: "test@test.com"
            );
            var response = instance.CreateRuleWhitelist("es", data);
            Assert.IsType<WhitelistlistRuleResponse>(response);
        }

        [Fact]
        public void GetRuleBlacklistTest()
        {
            var response = instance.GetRuleBlacklist("es");
            Assert.IsType<RiskRulesList>(response);
        }

        [Fact]
        public void CreateRuleBlacklistTest()
        {
            var data = new CreateRuleWhitelistRequest(
                description: "test rule",
                field: "email",
                value: "blocked@test.com"
            );
            var response = instance.CreateRuleBlacklist(data, "es");
            Assert.IsType<BlacklistRuleResponse>(response);
        }

        [Fact]
        public void DeleteRuleWhitelistTest()
        {
            string id = "rule_123";
            var response = instance.DeleteRuleWhitelist(id, "es");
            Assert.IsType<DeletedWhitelistRuleResponse>(response);
        }

        [Fact]
        public void DeleteRuleBlacklistTest()
        {
            string id = "rule_123";
            var response = instance.DeleteRuleBlacklist(id, "es");
            Assert.IsType<DeletedBlacklistRuleResponse>(response);
        }
    }
}
