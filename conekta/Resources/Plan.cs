using System;

namespace conekta
{
	public class Plan : Resource
	{
		public String id { get; set; }
		public String name { get; set; }
		public int amount { get; set; }
		public String currency { get; set; }
		public String interval { get; set; }
		public int frequency { get; set; }
		public int trial_period_days { get; set; }
		public int expiry_count { get; set; }

		public void create()
		{
			String data = this.toJSON();

			this.create ("/plans", data);
		}

		public void find()
		{
			this.find ("/plans", this.id);
		}
	}
}

