using System;
namespace conekta
{
	public class Customer : Resource
	{
		public string id { get; set; }
		public string name { get; set; }
		public string email { get; set; }
		public string phone { get; set; }
		public bool is_corporate { get; set; }
	}
}
