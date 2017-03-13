using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Charge : Resource
	{
		public string id { get; set; }
		public bool livemode { get; set; }
		public string created_at { get; set; }
		public string currency { get; set; }
		public int amount { get; set; }
		public string parent_id { get; set; }
		public PaymentMethod payment_method { get; set; }

		public Charge toClass(string json)
		{
			return JsonConvert.DeserializeObject<Charge>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
		}
	}
}
