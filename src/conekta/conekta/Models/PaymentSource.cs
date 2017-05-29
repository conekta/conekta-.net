using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class PaymentSource : Resource
	{
		public string id { get; set; }
		public string type { get; set; }

		/* In case card token */
		public string token_id { get; set; }

		/* In case card object*/
		public string name { get; set; }
		public string number { get; set; }
		public string exp_month { get; set; }
		public string exp_year { get; set; }
		public string cvc { get; set; }
		public string last4 { get; set; }
		public string bin { get; set; }
		public string brand { get; set; }
		public Address address { get; set; }

		public string parent_id { get; set; }

		public PaymentSource update(string data)
		{
			PaymentSource payment_source = this.toClass(this.toObject(this.update("/customers/" + this.parent_id + "/payment_sources/" + this.id, data)).ToString());
			return payment_source;
		}

		public PaymentSource destroy()
		{
			this.delete("/customers/" + this.parent_id + "/payment_sources/" + this.id);
			return this;
		}

		public PaymentSource toClass(string json)
		{
			PaymentSource payment_source = JsonConvert.DeserializeObject<PaymentSource>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return payment_source;
		}
	}
}
