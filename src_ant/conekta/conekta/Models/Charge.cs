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

        public Charge create(string data)
        {
            string charge = this.create("/charges", data);
            return this.toClass(this.toObject(charge).ToString());
        }

        public Charge find(string id)
        {
            string charge = this.find("/charges", id);
            return this.toClass(this.toObject(charge).ToString());
        }

        public Charge[] where(string data = @"{}")
        {
            string result = this.where("/charges", data);

            Regex pattern = new Regex("\"object\":", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            result = pattern.Replace(result, "\"_object\":");

            Charge[] charges = JsonConvert.DeserializeObject<Charge[]>(result, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return charges;
        }

        public Charge capture()
        {
            return this.toClass(this.request("POST", "/charges/" + this.id + "/capture", @"{}"));
        }

        public Charge refund(int amount = 0)
        {
            if (amount > 0)
            {
                return this.toClass(this.request("POST", "/charges/" + this.id + "/refund", @"{""amount"": " + amount.ToString() + "}"));
            }
            else
            {
                return this.toClass(this.request("POST", "/charges/" + this.id + "/refund", @"{}"));
            }
        }
	}
}
