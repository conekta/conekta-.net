using System;
namespace conekta
{
	public class ShippingLine : Resource
	{
		public string id;
		public string description;
		public int amount;
		public string tracking_number;
		public string carrier;
		public string method;
	}
}
