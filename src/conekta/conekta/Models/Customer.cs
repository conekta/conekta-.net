using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Customer : Resource
	{
		public string id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public List<Card> cards { get; set; }
		public Subscription subscription { get; set; }
		public string plan { get; set; }

		public bool logged_in { get; set; }
		public int successful_purchases { get; set; }
		public int created_at { get; set; }
		public int updated_at { get; set; }
		public int offline_payments { get; set; }
		public int score { get; set; }

		public Customer toClass(string json)
		{
			return JsonConvert.DeserializeObject<Customer> (json, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});
		}

		public Card toCard(string json)
		{
			Card card = JsonConvert.DeserializeObject<Card> (json, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});
			card.customer = this;
			this.cards.Add (card);
			return card;
		}

		public Subscription toSubscription(string json)
		{
			Subscription subscription = JsonConvert.DeserializeObject<Subscription> (json, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});
			this.subscription = subscription;
			this.plan = subscription.plan_id;
			return subscription;
		}

		public Customer create(string data)
		{
			return this.toClass (this.create ("/customers", data));
		}

		public Customer find(string id)
		{
			return this.toClass (this.find ("/customers", id));
		}

		public Customer update(string data)
		{
			return this.toClass (this.update ("/customers/" + this.id, data));
		}

		public Customer delete()
		{
			return this.toClass (this.delete ("/customers/" + this.id));
		}

		public Card createCard(string data)
		{
			return this.toCard (this.create ("/customers/" + this.id + "/cards", data));
		}

		public Subscription createSubscription(string data)
		{
			return this.toSubscription (this.create ("/customers/" + this.id + "/subscription", data));
		}

	}
}

