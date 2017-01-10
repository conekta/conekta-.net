using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{

	public class ConektaObject : ICloneable
	{
		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public String toJSON()
		{
			String json = JsonConvert.SerializeObject(this.Clone (), new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});

			/* Order optional fields */
			json = json.Replace ("\"monthly_installments\":0,", "");
			json = json.Replace ("\"bank\":{\"type\":\"spei\",\"expires_at\":\"0001-01-01T00:00:00\"},", "\"bank\":{\"type\":\"spei\"},");
			json = json.Replace (",\"logged_in\":false,\"successful_purchases\":0,\"created_at\":0,\"updated_at\":0,\"offline_payments\":0,\"score\":0", "");
			json = json.Replace (",\"frequency\":0,\"trial_period_days\":0,\"expiry_count\":0", "");
			return json;
		}
	}
}
