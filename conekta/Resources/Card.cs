using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Card : Resource
	{
		public string id { get; set; }
		public string name { get; set; }
		public string brand { get; set; }
		public string last4 { get; set; }
		public string exp_month { get; set; }
		public string exp_year { get; set; }
		public int created_at { get; set; }
		public string customer_id { get; set; }
		public Customer customer { get; set; }

		public Card toCard(string json)
		{
			Card card = JsonConvert.DeserializeObject<Card> (json, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});
			return card;
		}

		public Card update (string data)
		{
			Card card = toCard (this.update ("/customers/" + this.customer_id + "/cards/" + this.id, data));
			this.id = card.id;
			this.name = card.name;
			this.brand = card.brand;
			this.last4 = card.last4;
			this.exp_month = card.exp_month;
			this.exp_year = card.exp_year;
			this.created_at = card.created_at;
			this.customer_id = card.customer_id;
			return this;
		}

		public Card delete ()
		{
			Card card = toCard (this.delete ("/customers/" + this.customer_id + "/cards/" + this.id));

			int index = customer.cards.IndexOf (this);
			customer.cards.RemoveAt (index);

			return card;
		}
	}
}

