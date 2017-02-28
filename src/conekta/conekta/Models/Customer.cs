using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Customer : Resource
	{
		public string id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public bool corporate { get; set; }
		public PaymentSource[] payment_sources { get; set; }
		public FiscalEntity[] fiscal_entities { get; set; }
		public ShippingContact[] shipping_contacts { get; set; }
		public Subscription subscription { get; set; }
		public int account_age { get; set; }
		public int paid_transactions { get; set; }
		public int first_paid_at { get; set; }

		public Customer create(string data)
		{
			string customer = this.create("/customers", data);
			return this.toClass(this.toObject(customer).ToString());
		}

		public Customer find(string id)
		{
			string customer = this.find("/customers", id);
			return this.toClass(this.toObject(customer).ToString());
		}

		public Customer[] where(JObject data)
		{
			string result = this.where("/customers", data.ToString());

			Regex pattern = new Regex("\"object\":", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			result = pattern.Replace(result, "\"_object\":");

			JObject ords = JObject.Parse(result);

			JArray list = (JArray)ords["data"];

			Customer[] customers = new Customer[list.Count];

			int counter = 0;

			foreach (var item in ords.GetValue("data"))
			{
				customers[counter] = this.toClass(this.toObject(item.ToString()).ToString());
				counter++;
			}

			return customers;
		}

		public Customer update(string data)
		{
			Customer customer = this.toClass(this.toObject(this.update("/customers/" + this.id, data)).ToString());
			return customer;
		}

		public Customer destroy()
		{
			this.delete("/customers/" + this.id);
			return this;
		}

		public PaymentSource createPaymentSource(string data)
		{
			string payment_source = this.create("/customers/" + this.id + "/payment_sources", data);
			PaymentSource skeleton = new PaymentSource();
			return skeleton.toClass(skeleton.toObject(payment_source).ToString());
		}

		public ShippingContact createShippingContact(string data)
		{
			string shipping_contact = this.create("/customers/" + this.id + "/shipping_contacts", data);
			ShippingContact skeleton = new ShippingContact();
			return skeleton.toClass(skeleton.toObject(shipping_contact).ToString());
		}

		public FiscalEntity createFiscalEntity(string data)
		{
			string fiscal_entity = this.create("/customers/" + this.id + "/fiscal_entities", data);
			FiscalEntity skeleton = new FiscalEntity();
			return skeleton.toClass(skeleton.toObject(fiscal_entity).ToString());
		}

		public Subscription createSubscription(string data)
		{
			string subscription = this.create("/customers/" + this.id + "/subscription", data);
			Subscription skeleton = new Subscription();
			return skeleton.toClass(skeleton.toObject(subscription).ToString());
		}

		public Customer toClass(string json)
		{
			Customer customer = JsonConvert.DeserializeObject<Customer>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return customer;
		}
	}
}
