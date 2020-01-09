using Newtonsoft.Json;

namespace conekta
{
	public class PaymentSource : Resource
	{
		public string id { get; set; }
        public string type { get; set; }
        public bool deleted { get; set; }

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
