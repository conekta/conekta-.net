using System;
using Newtonsoft.Json.Linq;

namespace conekta
{

	public class Resource : ConektaObject, ICloneable
	{
		Requestor requestor = new Requestor();

		public Resource () {}

		public JObject create(String resource_uri, String data)
		{
			var json = requestor.request("POST", resource_uri, data);
			return this.toObject (json);
		}

		public dynamic update()
		{
			return new ConektaObject();
		}

		public dynamic delete()
		{
			return new ConektaObject();
		}

		public JObject find(String resource_uri, String id)
		{
			var json = requestor.request("GET", resource_uri + "/" + id);
			return this.toObject (json);
		}

		public void where(String resource_uri, String data)
		{
			requestor.request("GET", resource_uri, data);
		}

	}

}
