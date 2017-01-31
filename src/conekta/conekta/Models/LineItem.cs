using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class LineItem : Resource
	{
		public string name { get; set; }
		public string description { get; set; }
		public int unit_price { get; set; }
		public int quantity { get; set; }
		public string sku { get; set; }
		public bool shippable { get; set; }
		public string[] tags { get; set; }
		public string brand { get; set; }
		public string type { get; set; }
		public string parent_id { get; set; }
		public string id { get; set; }

		public LineItem update(string data)
		{
			LineItem line_item = this.toClass(this.toObject(this.update("/orders/" + this.parent_id + "/line_items/" + this.id, data)).ToString());
			return line_item;
		}

		public LineItem destroy()
		{
			LineItem line_item = this.toClass(this.toObject(this.delete("/orders/" + this.parent_id + "/line_items/" + this.id)).ToString());
			return line_item;
		}

		public LineItem toClass(string json)
		{
			LineItem item = JsonConvert.DeserializeObject<LineItem>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return item;
		}
	}
}
