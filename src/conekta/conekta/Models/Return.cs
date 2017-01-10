using System;
namespace conekta
{
	public class Return : Resource
	{
		public bool livemode { get; set; }
		public int amount { get; set; }
		public string currency { get; set; }
		public LineItem[] items { get; set; }
		public string charge_id { get; set; }
		public string reason { get; set; }
		public string id { get; set; }
		public string _object { get; set; }
		public int created_at { get; set; }
		public string parent_id { get; set; }
	}
}
