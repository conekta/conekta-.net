using System;
using System.Reflection;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{

	public class ConektaList : Resource, ICloneable
	{
		public String next_page_url { get; set; }
		public String previous_page_url { get; set; }
		public bool has_more { get; set; }
		public object[] data { get; set; }
		public Type _type { get; set; }

		public ConektaList(Type _type)
		{
			this._type = _type;
		}

		public void next_page()
		{
			if (this.has_more)
			{
				String next_url = this.next_page_url.Replace(conekta.Api.baseUri, "");
				JObject response = JObject.Parse(this.request("GET", next_url));
				JArray compData = (JArray)response.GetValue("data");
				object[] arrData = (object[])compData.ToObject(typeof(object[]));

				var z = new object[this.data.Length + arrData.Length];
				this.data.CopyTo(z, 0);
				arrData.CopyTo(z, this.data.Length);

				this.data = (object[])z;
				this.has_more = (bool)response.GetValue("has_more");
				this.next_page_url = (String)response.GetValue("next_page_url");
				this.previous_page_url = (String)response.GetValue("next_page_url");
			}
		}

		public object at(int index)
		{
			object item = this.data[index];

			MethodInfo method = this._type.GetMethod("toClass");
			ParameterInfo[] parameters = method.GetParameters();
			object classInstance = Activator.CreateInstance(this._type, null);

			object[] parametersArray = new object[] { item.ToString() };

			return method.Invoke(classInstance, parameters.Length == 0 ? null : parametersArray);
		}
	}
}
