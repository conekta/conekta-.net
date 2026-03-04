using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class PlansApiTests : IDisposable
    {
        private PlansApi instance;

        public PlansApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new PlansApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<PlansApi>(instance);
        }

        [Fact]
        public void GetPlansTest()
        {
            var response = instance.GetPlans("es");
            Assert.IsType<GetPlansResponse>(response);
        }

        [Fact]
        public void GetPlanTest()
        {
            string id = "plan_2tZb5q8Z3PYpg6SJd";
            var response = instance.GetPlan(id, "es");
            Assert.IsType<PlanResponse>(response);
        }

        [Fact]
        public void CreatePlanTest()
        {
            var planRequest = new PlanRequest(
                name: "test plan",
                amount: 10000,
                currency: "MXN",
                interval: PlanRequest.IntervalEnum.Month
            );
            var response = instance.CreatePlan(planRequest, "es");
            Assert.IsType<PlanResponse>(response);
        }

        [Fact]
        public void UpdatePlanTest()
        {
            string id = "plan_2tZb5q8Z3PYpg6SJd";
            var updatePlan = new UpdatePlan(
                name: "updated plan"
            );
            var response = instance.UpdatePlan(id, updatePlan, "es");
            Assert.IsType<PlanResponse>(response);
        }

        [Fact]
        public void DeletePlanTest()
        {
            string id = "plan_2tZb5q8Z3PYpg6SJd";
            var response = instance.DeletePlan(id, "es");
            Assert.IsType<PlanResponse>(response);
        }
    }
}
