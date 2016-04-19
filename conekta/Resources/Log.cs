using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Log : Resource
	{
		public JObject[] where (string data = @"{}")
		{
			string result = this.where ("/logs", data);

			JObject[] logs = JsonConvert.DeserializeObject<JObject[]> (result, new JsonSerializerSettings {
				NullValueHandling = NullValueHandling.Ignore
			});

			return logs;
		}
	}
}

