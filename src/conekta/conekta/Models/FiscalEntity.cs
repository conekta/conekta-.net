using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class FiscalEntity : Resource
	{
		public string id { get; set; }
		public string tax_id { get; set; }
		public string company_name { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public Address address { get; set; }
		public string parent_id { get; set; }

		public FiscalEntity update(string data)
		{
			FiscalEntity fiscal_entity = this.toClass(this.toObject(this.update("/customers/" + this.parent_id + "/fiscal_entities/" + this.id, data)).ToString());
			return fiscal_entity;
		}

		public FiscalEntity destroy()
		{
			this.delete("/customers/" + this.parent_id + "/fiscal_entities/" + this.id);
			return this;
		}

		public FiscalEntity toClass(string json)
		{
			FiscalEntity fiscal_entity = JsonConvert.DeserializeObject<FiscalEntity>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return fiscal_entity;
		}
	}
}
