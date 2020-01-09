using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Address : Resource
	{
		public string street1 { get; set; }
		public string street2 { get; set; }
		public string street3 { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public string country { get; set; }
		public string zip { get; set; }
		public bool residential { get; set; }
		public string parent_id { get; set; }
	}
}
