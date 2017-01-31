using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{

	public class ConektaList : Resource, ICloneable
	{
		public String next_page_url { get; set; }
		public String previous_page_url { get; set; }
		public object list_class { get; set; }
		public bool has_more { get; set; }
		public object[] data { get; set; }

		public object Clone()
		{
			return this.MemberwiseClone();
		}

		public void next_page()
		{
			String next_url = this.next_page_url;
			String response = this.request("GET", "", "{}");
			System.Console.WriteLine(response);
		}

		public object at(int index)
		{
			System.Console.WriteLine(index);
			System.Console.WriteLine(this);
			return this.data[index];
		}
	}
}
