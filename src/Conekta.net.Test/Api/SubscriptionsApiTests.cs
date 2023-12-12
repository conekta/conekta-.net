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
    ///  Class for testing SubscriptionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SubscriptionsApiTests
    {
        private readonly SubscriptionsApi _instance;

        public SubscriptionsApiTests()
        {
            Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new SubscriptionsApi(configuration);
        }


        /// <summary>
        /// Test an instance of SubscriptionsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<SubscriptionsApi>(_instance);
        }

        /// <summary>
        /// Test CancelSubscription
        /// </summary>
        [Fact]
        public void CancelSubscriptionTest()
        {
            string customerId = "cus_2tZWxbTPtQgGJGh8P";

            var response = _instance.CancelSubscription(customerId, "es");

            Assert.IsType<SubscriptionResponse>(response);
            Assert.Equal(customerId, response.CustomerId);
            Assert.Equal("canceled", response.Status);
            Assert.Equal(1679431258, response.CanceledAt);
        }

        /// <summary>
        /// Test CreateSubscription
        /// </summary>
        [Fact]
        public void CreateSubscriptionTest()
        {
            string customerId = "cus_2tXx8KUxw6311kEbs";
            SubscriptionRequest subscriptionRequest = new(
                planId: "contracargos-plan"
            );
            
            var response = _instance.CreateSubscription(customerId, subscriptionRequest);
            
            Assert.IsType<SubscriptionResponse>(response);
            Assert.Equal(customerId, response.CustomerId);
            Assert.Equal("past_due", response.Status);
            Assert.Equal("subscription", response.VarObject);
            Assert.Equal(subscriptionRequest.PlanId, response.PlanId);
            Assert.Equal(1679431660, response.CreatedAt);
        }

        /// <summary>
        /// Test GetSubscription
        /// </summary>
        [Fact]
        public void GetSubscriptionTest()
        {
            string customerId = "cus_2tZWxbTPtQgGJGh8P";
            var response = _instance.GetSubscription(customerId, "es");

            Assert.IsType<SubscriptionResponse>(response);
            Assert.Equal(customerId, response.CustomerId);
            Assert.Equal("subscription", response.VarObject);
        }

        /// <summary>
        /// Test PauseSubscription
        /// </summary>
        [Fact]
        public void PauseSubscriptionTest()
        {
            string customerId = "cus_2tZWxbTPtQgGJGh8P";
            var response = _instance.PauseSubscription(customerId, "es");

            Assert.IsType<SubscriptionResponse>(response);
            Assert.Equal(customerId, response.CustomerId);
            Assert.Equal("paused", response.Status);
            Assert.Equal(1679429155, response.PausedAt);
        }

        /// <summary>
        /// Test ResumeSubscription
        /// </summary>
        [Fact]
        public void ResumeSubscriptionTest()
        {
            string customerId = "cus_2tZWxbTPtQgGJGh8P";

            var response = _instance.ResumeSubscription(customerId, "en");

            Assert.IsType<SubscriptionResponse>(response);
            Assert.Equal(customerId, response.CustomerId);
            Assert.Equal("active", response.Status);
            Assert.Null(response.PausedAt);
        }

        /// <summary>
        /// Test UpdateSubscription
        /// </summary>
        [Fact]
        public void UpdateSubscriptionTest()
        {
            string customerId = "cus_2tZWxbTPtQgGJGh8P";
            SubscriptionUpdateRequest subscriptionRequest = new(
                trialEnd: 1679752328
            );

            var response = _instance.UpdateSubscription(customerId, subscriptionRequest);

            Assert.IsType<SubscriptionResponse>(response);
        }
        /// <summary>
        /// Test GetAllEventsFromSubscription
        /// </summary>
        [Fact]
        public void GetAllEventsFromSubscriptionTest()
        {
            string customerId = "cus_2rKpeXQpapLonfVke";
            var response = _instance.GetAllEventsFromSubscription(customerId, "es");

            Assert.IsType<SubscriptionEventsResponse>(response);
            Assert.False(response.HasMore);
            Assert.Equal("620ea04f6d41e80466f611a6", response.Data[0].Id);
            Assert.Equal("event", response.Data[0].VarObject);
            Assert.Equal(2, response.Data.Count);
        }
    }
}
