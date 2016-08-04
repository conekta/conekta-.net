using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;

namespace conekta
{
	public class Charge : Resource
	{
		public string id { get; set; }
		public string description { get; set; }
		public int amount { get; set; }
		public int monthly_installments { get; set; }
		public string currency { get; set; }
		public string reference_id { get; set; }
		public string card { get; set; }
		public string status { get; set; }
		public Cash cash { get; set; }
		public PaymentMethod payment_method { get; set; }
		public Bank bank { get; set; }
		public Details details { get; set; }

		public Charge toClass(string json)
		{
			return JsonConvert.DeserializeObject<Charge> (json, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});
		}

		public Charge create(string data)
		{
			string charge = this.create ("/charges", data);
			return this.toClass (charge);
		}

		public Charge find(string id)
		{
			string charge = this.find ("/charges", id);
			return this.toClass (charge);
		}

		public Charge[] where(string data = @"{}")
		{
			string result = this.where ("/charges", data);

			Regex pattern = new Regex("\"object\":", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			result = pattern.Replace(result, "\"_object\":");

			Charge[] charges = JsonConvert.DeserializeObject<Charge[]> (result, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});

			return charges;
		}

		public Charge capture()
		{
			return this.toClass (this.request ("POST", "/charges/" + this.id + "/capture", @"{}"));
		}

		public Charge refund(int amount = 0)
		{
			if (amount > 0) {
				return this.toClass(this.request ("POST", "/charges/" + this.id + "/refund", @"{""amount"": " + amount.ToString() + "}"));
			} else {
				return this.toClass(this.request ("POST", "/charges/" + this.id + "/refund", @"{}"));
			}
		}
	}
}
