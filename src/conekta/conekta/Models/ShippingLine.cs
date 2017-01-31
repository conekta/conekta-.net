using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class ShippingLine : Resource
	{
		public string id { get; set; }
		public int amount { get; set; }
		public string tracking_number { get; set; }
		public string carrier { get; set; }
		public string method { get; set; }
		public string parent_id { get; set; }

		public ShippingLine update(string data)
		{
			ShippingLine shipping_line = this.toClass(this.toObject(this.update("/orders/" + this.parent_id + "/shipping_lines/" + this.id, data)).ToString());
			return shipping_line;
		}

		public ShippingLine destroy()
		{
			ShippingLine shipping_line = this.toClass(this.toObject(this.delete("/orders/" + this.parent_id + "/shipping_lines/" + this.id)).ToString());
			return shipping_line;
		}

		public ShippingLine toClass(string json)
		{
			ShippingLine shipping_line = JsonConvert.DeserializeObject<ShippingLine>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return shipping_line;
		}
	}
}
