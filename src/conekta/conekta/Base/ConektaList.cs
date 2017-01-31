using System;
using System.Reflection;

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
			String next_url = this.next_page_url;
			String response = this.request("GET", "", "{}");
			System.Console.WriteLine(response);
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
