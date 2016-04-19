using System;

namespace conekta
{

	public class Subscription
	{
		public string id { get; set; }
		public string status { get; set; }
		public int billing_cycle_start { get; set; }
		public int billing_cycle_end { get; set; }
		public string plan_id { get; set; }
		public string card_id { get; set; }
		public int created_at { get; set; }
	}

}

