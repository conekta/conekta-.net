using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class TaxLine : Resource
	{
		public string id { get; set; }
		public string description { get; set; }
		public int amount { get; set; }
		public string parent_id { get; set; }

		public TaxLine update(string data)
		{
			TaxLine tax_line = this.toClass(this.toObject(this.update("/orders/" + this.parent_id + "/tax_lines/" + this.id, data)).ToString());
			return tax_line;
		}

		public TaxLine toClass(string json)
		{
			TaxLine tax_line = JsonConvert.DeserializeObject<TaxLine>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return tax_line;
		}
	}
}
