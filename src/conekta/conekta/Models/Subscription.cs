using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{

	public class Subscription : Resource
	{
		public string id { get; set; }
		public string status { get; set; }
		public string plan { get; set; }
		public string plan_id { get; set; }
		public string card_id { get; set; }
		public int billing_cycle_start { get; set; }
		public int billing_cycle_end { get; set; }
		public int created_at { get; set; }
		public string customer_id { get; set; }

		public Subscription toSubscription(string json)
		{
			Subscription subscription = JsonConvert.DeserializeObject<Subscription> (json, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});
			return subscription;
		}

		public Subscription update (string data)
		{
			Subscription subscription = toSubscription (this.update ("/customers/" + this.customer_id + "/subscription", data));
			this.id = subscription.id;
			this.status = subscription.status;
			this.plan = subscription.plan_id;
			this.plan_id = subscription.plan_id;
			this.card_id = subscription.card_id;
			this.billing_cycle_start = subscription.billing_cycle_start;
			this.billing_cycle_end = subscription.billing_cycle_end;
			this.created_at = subscription.created_at;
			return this;
		}

		public Subscription pause ()
		{
			Subscription subscription = toSubscription (this.create ("/customers/" + this.customer_id + "/subscription/pause", @"{}"));
			this.status = subscription.status;
			return this;
		}

		public Subscription resume ()
		{
			Subscription subscription = toSubscription (this.create ("/customers/" + this.customer_id + "/subscription/resume", @"{}"));
			this.status = subscription.status;
			return this;
		}

		public Subscription cancel ()
		{
			Subscription subscription = toSubscription (this.create ("/customers/" + this.customer_id + "/subscription/cancel", @"{}"));
			this.status = subscription.status;
			return this;
		}

		public Subscription toClass(string json)
		{
			Subscription subscription = JsonConvert.DeserializeObject<Subscription>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return subscription;
		}
	}

}

