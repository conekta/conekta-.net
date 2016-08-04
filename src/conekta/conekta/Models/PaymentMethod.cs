using System;

namespace conekta
{
	public class PaymentMethod
	{
		public Int64 expires_at { get; set; }
		public String type { get; set; }
		public String _object { get; set; }

		/*Oxxo Payment*/
		public String barcode { get; set; }
		public String barcode_url { get; set; }
		public String store_name { get; set; }

		/*Spei Payment*/
		public String clabe { get; set; }
		public String bank { get; set; }
		public String issuing_account_holder { get; set; }
		public String issuing_account_tax_id { get; set; }
		public String issuing_account_bank { get; set; }
		public String issuing_account_number { get; set; }
		public String receiving_account_holder { get; set; }
		public String receiving_account_tax_id { get; set; }
		public String receiving_account_number { get; set; }
		public String receiving_account_bank { get; set; }
		public String reference_number { get; set; }
		public String description { get; set; }
		public String tracking_code { get; set; }

		/*Credit Card Payment*/
		public String name { get; set; }
		public String exp_month { get; set; }
		public String exp_year { get; set; }
		public String auth_code { get; set; }
		public String normalized_device_fingerprint { get; set; }
		public String last4 { get; set; }
		public String brand { get; set; }
		public String issuer { get; set; }
		public String account_type { get; set; }
		public String country { get; set; }
		public Int32 fraud_score { get; set; }

		/*Banorte payment*/
		public String service_name { get; set; }
		public String service_number { get; set; }
		public String reference { get; set; }
	}
}

