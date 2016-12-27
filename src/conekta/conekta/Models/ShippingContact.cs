using System;
namespace conekta
{
	public class ShippingContact : Resource
	{
		public string id;
		public string email;
		public string phone;
		public string receiver;
		public AddressBoundary between_streets;
		public Address address;
	}
}
