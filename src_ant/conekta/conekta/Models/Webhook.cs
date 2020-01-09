using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Webhook : Resource
	{
		public string id { get; set; }
		public string url { get; set; }
		public string[] events { get; set; }

		public Webhook toClass (string json)
		{
			Webhook webhook = JsonConvert.DeserializeObject<Webhook> (json, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});
			return webhook;
		}

		public Webhook find (string id)
		{
			string response = this.find ("/webhooks", id);
			return this.toClass (response);
		}

		public Webhook create (string data)
		{
			Webhook webhook = this.toClass (this.create ("/webhooks", data));
			return webhook;
		}

		public Webhook update (string data)
		{
			Webhook wh = this.toClass (this.update ("/webhooks/" + this.id, data));
			this.id = wh.id;
			this.url = wh.url;
			this.events = wh.events;
			return this;
		}
	}
}

