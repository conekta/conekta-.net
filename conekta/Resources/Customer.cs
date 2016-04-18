using System;
using System.Collections.Generic;

namespace conekta
{
	public class Customer : Resource
	{
		public string id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public List<Card> cards { get; set; }
		public string plan { get; set; }

		public bool logged_in { get; set; }
		public int successful_purchases { get; set; }
		public int created_at { get; set; }
		public int updated_at { get; set; }
		public int offline_payments { get; set; }
		public int score { get; set; }

		public void create()
		{
			String data = this.toJSON();

			this.create ("/customers", data);
		}

		public void find()
		{
			this.find ("/customers", this.id);
		}
	}
}

