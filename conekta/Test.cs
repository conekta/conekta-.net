using NUnit.Framework;
using System;
using System.Collections.Generic;

using conekta;

namespace ConektaTest
{
	[TestFixture ()]
	public class Test
	{

		private int RandomNumber(int min, int max, int seed=0)
		{
			Random random = new Random((int)DateTime.Now.Ticks + seed);
			return random.Next(min, max);
		}
		
		[Test ()]
		public void ChargeWithCard ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge ().create(@"{
			  ""description"":""Stogies"",
			  ""amount"": 20000,
			  ""currency"":""MXN"",
			  ""reference_id"":""9839-wolf_pack"",
			  ""card"": ""tok_test_visa_4242"",
			  ""details"": {
			    ""name"": ""Arnulfo Quimare"",
			    ""phone"": ""403-342-0642"",
			    ""email"": ""logan@x-men.org"",
			    ""customer"": {
			      ""logged_in"": true,
			      ""successful_purchases"": 14,
			      ""created_at"": 1379784950,
			      ""updated_at"": 1379784950,
			      ""offline_payments"": 4,
			      ""score"": 9
			    },
			    ""line_items"": [{
			      ""name"": ""Box of Cohiba S1s"",
			      ""description"": ""Imported From Mex."",
			      ""unit_price"": 20000,
			      ""quantity"": 1,
			      ""sku"": ""cohb_s1"",
			      ""category"": ""food""
			    }],
			    ""billing_address"": {
			      ""street1"":""77 Mystery Lane"",
			      ""street2"": ""Suite 124"",
			      ""street3"": null,
			      ""city"": ""Darlington"",
			      ""state"":""NJ"",
			      ""zip"": ""10192"",
			      ""country"": ""Mexico"",
			      ""tax_id"": ""xmn671212drx"",
			      ""company_name"":""X-Men Inc."",
			      ""phone"": ""77-777-7777"",
			      ""email"": ""purshasing@x-men.org""
			    }
			  },
        	  ""capture"": false
			}");

			Assert.AreEqual (charge.id.GetType().ToString(), "System.String");
			Assert.AreEqual (charge.amount, 20000);

			charge = new Charge ().find (charge.id);

			Assert.AreEqual (charge.id.GetType().ToString(), "System.String");
			Assert.AreEqual (charge.amount, 20000);

			charge = charge.capture ();

			Assert.AreEqual (charge.id.GetType().ToString(), "System.String");
			Assert.AreEqual (charge.amount, 20000);

			charge = charge.refund ();

			Assert.AreEqual (charge.id.GetType().ToString(), "System.String");
			Assert.AreEqual (charge.amount, 20000);

			Charge[] charges = new Charge ().where (@"{""status.ne"": ""paid""}");
			Assert.AreEqual (charges[0].id.GetType().ToString(), "System.String");
		}

		[Test ()]
		public void ChargeWithCardAndMonthlyInstallments ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge ().create(@"{
			  ""description"":""Stogies"",
			  ""amount"": 30000,
			  ""currency"":""MXN"",
			  ""reference_id"":""9839-wolf_pack"",
			  ""card"": ""tok_test_visa_4242"",
			  ""monthly_installments"": 3,
			  ""details"": {
			    ""name"": ""Arnulfo Quimare"",
			    ""phone"": ""403-342-0642"",
			    ""email"": ""logan@x-men.org"",
			    ""customer"": {
			      ""logged_in"": true,
			      ""successful_purchases"": 14,
			      ""created_at"": 1379784950,
			      ""updated_at"": 1379784950,
			      ""offline_payments"": 4,
			      ""score"": 9
			    },
			    ""line_items"": [{
			      ""name"": ""Box of Cohiba S1s"",
			      ""description"": ""Imported From Mex."",
			      ""unit_price"": 20000,
			      ""quantity"": 1,
			      ""sku"": ""cohb_s1"",
			      ""category"": ""food""
			    }],
			    ""billing_address"": {
			      ""street1"":""77 Mystery Lane"",
			      ""street2"": ""Suite 124"",
			      ""street3"": null,
			      ""city"": ""Darlington"",
			      ""state"":""NJ"",
			      ""zip"": ""10192"",
			      ""country"": ""Mexico"",
			      ""tax_id"": ""xmn671212drx"",
			      ""company_name"":""X-Men Inc."",
			      ""phone"": ""77-777-7777"",
			      ""email"": ""purshasing@x-men.org""
			    }
			  }
			}");

			Assert.AreEqual (charge.id.GetType().ToString(), "System.String");
		}

		[Test ()]
		public void ChargeWithOxxo ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge ().create(@"{
			  ""description"":""Stogies"",
			  ""amount"": 20000,
			  ""currency"":""MXN"",
			  ""reference_id"":""9839-wolf_pack"",
			  ""cash"": {
			    ""type"": ""oxxo"",
			    ""expires_at"": 1461823641
			  },
			  ""details"": {
			    ""name"": ""Arnulfo Quimare"",
			    ""phone"": ""403-342-0642"",
			    ""email"": ""logan@x-men.org"",
			    ""customer"": {
			      ""logged_in"": true,
			      ""successful_purchases"": 14,
			      ""created_at"": 1379784950,
			      ""updated_at"": 1379784950,
			      ""offline_payments"": 4,
			      ""score"": 9
			    },
			    ""line_items"": [{
			      ""name"": ""Box of Cohiba S1s"",
			      ""description"": ""Imported From Mex."",
			      ""unit_price"": 20000,
			      ""quantity"": 1,
			      ""sku"": ""cohb_s1"",
			      ""category"": ""food""
			    }],
			    ""billing_address"": {
			      ""street1"":""77 Mystery Lane"",
			      ""street2"": ""Suite 124"",
			      ""street3"": null,
			      ""city"": ""Darlington"",
			      ""state"":""NJ"",
			      ""zip"": ""10192"",
			      ""country"": ""Mexico"",
			      ""tax_id"": ""xmn671212drx"",
			      ""company_name"":""X-Men Inc."",
			      ""phone"": ""77-777-7777"",
			      ""email"": ""purshasing@x-men.org""
			    }
			  }
			}");

			Assert.AreEqual (charge.id.GetType().ToString(), "System.String");
		}

		[Test ()]
		public void ChargeWithSpei ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge ().create(@"{
			  ""description"":""Stogies"",
			  ""amount"": 20000,
			  ""currency"":""MXN"",
			  ""reference_id"":""9839-wolf_pack"",
			  ""bank"": {
			    ""type"": ""spei""
			  },
			  ""details"": {
			    ""name"": ""Arnulfo Quimare"",
			    ""phone"": ""403-342-0642"",
			    ""email"": ""logan@x-men.org"",
			    ""customer"": {
			      ""logged_in"": true,
			      ""successful_purchases"": 14,
			      ""created_at"": 1379784950,
			      ""updated_at"": 1379784950,
			      ""offline_payments"": 4,
			      ""score"": 9
			    },
			    ""line_items"": [{
			      ""name"": ""Box of Cohiba S1s"",
			      ""description"": ""Imported From Mex."",
			      ""unit_price"": 20000,
			      ""quantity"": 1,
			      ""sku"": ""cohb_s1"",
			      ""category"": ""food""
			    }],
			    ""billing_address"": {
			      ""street1"":""77 Mystery Lane"",
			      ""street2"": ""Suite 124"",
			      ""street3"": null,
			      ""city"": ""Darlington"",
			      ""state"":""NJ"",
			      ""zip"": ""10192"",
			      ""country"": ""Mexico"",
			      ""tax_id"": ""xmn671212drx"",
			      ""company_name"":""X-Men Inc."",
			      ""phone"": ""77-777-7777"",
			      ""email"": ""purshasing@x-men.org""
			    }
			  }
			}");

			Assert.AreEqual (charge.id.GetType().ToString(), "System.String");
		}

		[Test ()]
		public void ChargeWithBanorte ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge ().create(@"{
			  ""description"":""Stogies"",
			  ""amount"": 20000,
			  ""currency"":""MXN"",
			  ""reference_id"":""9839-wolf_pack"",
			  ""bank"": {
			    ""type"": ""banorte"",
			    ""expires_at"": 1461823641
			  },
			  ""details"": {
			    ""name"": ""Arnulfo Quimare"",
			    ""phone"": ""403-342-0642"",
			    ""email"": ""logan@x-men.org"",
			    ""customer"": {
			      ""logged_in"": true,
			      ""successful_purchases"": 14,
			      ""created_at"": 1379784950,
			      ""updated_at"": 1379784950,
			      ""offline_payments"": 4,
			      ""score"": 9
			    },
			    ""line_items"": [{
			      ""name"": ""Box of Cohiba S1s"",
			      ""description"": ""Imported From Mex."",
			      ""unit_price"": 20000,
			      ""quantity"": 1,
			      ""sku"": ""cohb_s1"",
			      ""category"": ""food""
			    }],
			    ""billing_address"": {
			      ""street1"":""77 Mystery Lane"",
			      ""street2"": ""Suite 124"",
			      ""street3"": null,
			      ""city"": ""Darlington"",
			      ""state"":""NJ"",
			      ""zip"": ""10192"",
			      ""country"": ""Mexico"",
			      ""tax_id"": ""xmn671212drx"",
			      ""company_name"":""X-Men Inc."",
			      ""phone"": ""77-777-7777"",
			      ""email"": ""purshasing@x-men.org""
			    }
			  }
			}");

			Assert.AreEqual (charge.id.GetType().ToString(), "System.String");
		}

		[Test ()]
		public void Customer ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Customer customer = new conekta.Customer ().create(@"{
			  ""name"":""James Howlett"",
			  ""email"":""james.howlett@forces.gov"",
			  ""phone"":""55-5555-5555"",
			  ""cards"":[""tok_test_visa_4242""],
			  ""plan"":""gold-plan""
			}");

			Assert.AreEqual (customer.id.GetType().ToString(), "System.String");

			customer = new conekta.Customer ().find(customer.id);

			Assert.AreEqual (customer.id.GetType().ToString(), "System.String");

			customer = customer.update(@"{
		      ""name"":""Logan"",
		      ""email"":""logan@x-men.org""
		    }");

			Assert.AreEqual (customer.name, "Logan");

			customer.createCard (@"{
		       ""token"":""tok_test_mastercard_4444""
		    }");

			Assert.AreEqual (customer.cards[1].last4, "4444");

			customer.createSubscription (@"{
		       ""plan"":""gold-plan""
		    }");

			Assert.AreEqual (customer.plan, "gold-plan");

			customer.delete ();
		}
	}
}
