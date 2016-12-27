using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Order : Resource
	{
		public string id { get; set; }
		public int amount { get; set; }
		public string currency { get; set; }
		public string status { get; set; }
		public LineItem[] line_items { get; set; }
		public ShippingLine[] shipping_lines { get; set; }
		public TaxLine[] tax_lines { get; set; }
		public DiscountLine[] discount_lines { get; set; }
		public string customer_id { get; set; }
		public Customer customer_info { get; set; }
		public string shipping_contact_id { get; set; }
		public ShippingContact shipping_contact { get; set; }
		public FiscalEntity fiscal_entity { get; set; }
		public Charge[] charges { get; set; }
		public Return[] returns { get; set; }
		public string _object { get; set; }

		public Order create(string data)
		{
			string charge = this.create("/orders", data);
			return this.toClass(this.toObject(charge).ToString());
		}

		public Order find(string id)
		{
			string order = this.find("/orders", id);
			return this.toClass(this.toObject(order).ToString());
		}

		public Order[] where(JObject data)
		{
			string result = this.where("/orders", data.ToString());

			Regex pattern = new Regex("\"object\":", RegexOptions.Multiline | RegexOptions.IgnoreCase);
			result = pattern.Replace(result, "\"_object\":");

			JObject ords = JObject.Parse(result);

			JArray list = (JArray)ords["data"];

			Order[] orders = new Order[list.Count];

			int counter = 0;

			foreach (var item in ords.GetValue("data"))
			{
				orders[counter] = this.toClass(this.toObject(item.ToString()).ToString());
				counter++;
			}
			
			return orders;
		}

		public Order update(string data)
		{
			Order order = this.toClass(this.update("/orders/" + this.id, data));
			this.id = order.id;
			return this;
		}

		public Order capture()
		{
			string charge = this.request("PUT", "/orders/" + this.id + "/capture", @"{}");
			System.Console.WriteLine(charge);
			return this.toClass(this.toObject(charge).ToString());
		}

		public Order refund(string data)
		{
			string charge = this.request("POST", "/orders/" + this.id + "/returns", data);
			JObject obj = new Charge().toObject(charge);
			return this.find(obj.GetValue("parent_id").ToString());
		}

		public Order toClass(string json)
		{
			Order order = JsonConvert.DeserializeObject<Order>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return order;
		}
	}
}
