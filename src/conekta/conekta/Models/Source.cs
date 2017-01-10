using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Source : Resource
	{
		public string id { get; set; }
		public string type { get; set; }

		/* In case card token */
		public string token_id { get; set; }

		/* In case card object*/
		public string name { get; set; }
		public string number { get; set; }
		public string exp_month { get; set; }
		public string exp_year { get; set; }
		public string cvc { get; set; }
		public Address address { get; set; }

		public string parent_id { get; set; }

		public Source update(string data)
		{
			Source source = this.toClass(this.toObject(this.update("/customers/" + this.parent_id + "/sources/" + this.id, data)).ToString());
			return source;
		}

		public Source destroy()
		{
			this.delete("/customers/" + this.parent_id + "/sources/" + this.id);
			return this;
		}

		public Source toClass(string json)
		{
			Source source = JsonConvert.DeserializeObject<Source>(json, new JsonSerializerSettings
			{
				NullValueHandling = NullValueHandling.Ignore
			});
			return source;
		}
	}
}
