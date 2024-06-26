/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Xunit;

using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    /// <summary>
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class EventsApiTests
    {
        private readonly EventsApi _instance;

        public EventsApiTests()
        {
            Configuration configuration = new()
            {
                BasePath = BaseTest.BasePath,
                AccessToken = "key_uMxL6X1txuxyzQzJEXt72Aaaa"
            };
            _instance = new EventsApi(configuration);
        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<EventsApi>(_instance);
        }

        /// <summary>
        /// Test GetEvent
        /// </summary>
        [Fact]
        public void GetEventTest()
        {
            string id = "63fe3d2ddf70970001cfb41a";
            var response = _instance.GetEvent(id, "en");

            Assert.IsType<EventResponse>(response);
            Assert.Single(response.WebhookLogs);
            Assert.Equal("event", response.Object);
            Assert.Equal("webhook_ping", response.Type);
            Assert.True(response.Livemode);
            Assert.Equal("webhl_2tSipZiQaZ1DLH33n", response.WebhookLogs[0].Id);
            Assert.True(Uri.IsWellFormedUriString(response.WebhookLogs[0].Url, UriKind.Absolute));
            Assert.Equal("ping", response.Data["action"]);
        }

        /// <summary>
        /// Test GetEvents
        /// </summary>
        [Fact]
        public void GetEventsTest()
        {
            var response = _instance.GetEvents("es");

            Assert.IsType<GetEventsResponse>(response);
            Assert.True(response.HasMore);
            Assert.Null(response.PreviousPageUrl);
            Assert.NotNull(response.NextPageUrl);
            Assert.Equal("list", response.Object);
            Assert.Equal(20, response.Data.Count);
        }

        /// <summary>
        /// Test ResendEvent
        /// </summary>
        [Fact]
        public void ResendEventTest()
        {
            const String eventId = "6463d6e35a4c3e001819e760";
            const String webhookLogId = "webhl_2svd2sh6GbqzyWBNZ";

            var response = _instance.ResendEvent(eventId, webhookLogId);

            Assert.IsType<EventsResendResponse>(response);
            Assert.Equal(webhookLogId, response.Id);
            Assert.Equal((int)System.Net.HttpStatusCode.MethodNotAllowed, response.LastHttpResponseStatus);
        }
    }
}
