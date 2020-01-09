using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class ShippingContact : Resource
	{
		public string id { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public string receiver { get; set; }
		public string between_streets { get; set; }
		public Address address { get; set; }
		public string parent_id { get; set; }

		public ShippingContact update(string data)
		{
			ShippingContact shipping_contact = this.toClass(this.toObject(this.update("/customers/" + this.parent_id + "/shipping_contacts/" + this.id, data)).ToString());
			return shipping_contact;
		}

		public ShippingContact destroy()
		{
			this.delete("/customers/" + this.parent_id + "/shipping_contacts/" + this.id);
			return this;
		}

		public ShippingContact toClass(string json)
		{
			ShippingContact shipping_contact = JsonConvert.DeserializeObject<ShippingContact>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return shipping_contact;
		}
	}
}
