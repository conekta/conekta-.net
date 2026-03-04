using System;
using Xunit;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

namespace Conekta.net.Test.Api
{
    public class EventsApiTests : IDisposable
    {
        private EventsApi instance;

        public EventsApiTests()
        {
            Configuration config = new Configuration
            {
                BasePath = TestConfiguration.BasePath,
                AccessToken = TestConfiguration.AccessToken
            };
            instance = new EventsApi(config);
        }

        public void Dispose() { }

        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<EventsApi>(instance);
        }

        [Fact]
        public void GetEventsTest()
        {
            var response = instance.GetEvents("es");
            Assert.IsType<GetEventsResponse>(response);
        }

        [Fact]
        public void GetEventTest()
        {
            string id = "63febc2882e95b00016b6908";
            var response = instance.GetEvent(id, "es");
            Assert.IsType<EventResponse>(response);
        }

        [Fact]
        public void ResendEventTest()
        {
            string eventId = "63febc2882e95b00016b6908";
            var resendRequest = new ResendEventRequest(webhooksIds: new System.Collections.Generic.List<string> { "webhl_2tSipZiQaZ1DLH33n" });
            var response = instance.ResendEvent(eventId, resendRequest, "es");
            Assert.IsType<EventsResendResponse>(response);
        }
    }
}
