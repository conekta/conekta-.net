using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

		public Plan toClass (string json)
		{
			return JsonConvert.DeserializeObject<Plan> (json, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});
		}

		public Plan create(string data)
		{
			return this.toClass(this.create ("/plans", data));
		}

		public Plan find(string id)
		{
			return this.toClass(this.find ("/plans/", id));
		}

		public Plan update (string data)
		{
			Plan plan = toClass (this.update ("/plans/" + this.id, data));
			this.id = plan.id;
			this.name = plan.name;
			this.amount = plan.amount;
			return this;
		}

		public Plan delete ()
		{
			return toClass (this.delete ("/plans/" + this.id));
		}
	}
}

