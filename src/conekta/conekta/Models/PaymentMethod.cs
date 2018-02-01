﻿using System;
using conektaBase;

namespace conektaModels
{
	public class PaymentMethod : Resource
	{
		public String _object { get; set; }
		public String _type { get; set; }
		public String name { get; set; }
		public String exp_month { get; set; }
		public String exp_year { get; set; }
		public String auth_code { get; set; }
		public String last4 { get; set; }
		public String brand { get; set; }
		public String issuer { get; set; }
		public String account_type { get; set; }
		public String country { get; set; }
		public String service_name { get; set; }
		public String expires_at { get; set; }
		public String store_name { get; set; }
		public String reference { get; set; }
	}
}
