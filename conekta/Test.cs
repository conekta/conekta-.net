using NUnit.Framework;
using System;
using System.Collections.Generic;

using conekta;

namespace ConektaTest
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void CreateChargeWithCard ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.LineItem lineItem0 = new conekta.LineItem();
			lineItem0.name = "Manicure";
			lineItem0.description = "Tratamiento en manos";
			lineItem0.unit_price = 10000;
			lineItem0.quantity = 1;

			conekta.LineItem lineItem1 = new conekta.LineItem();
			lineItem1.name = "Pedicure";
			lineItem1.description = "Tratamiento en pies";
			lineItem1.unit_price = 10000;
			lineItem1.quantity = 1;

			conekta.Details details = new conekta.Details();
			details.name = "Julian Ceballos";
			details.phone = "9999999999";
			details.email = "julian@domain.com";
			details.line_items = new System.Collections.Generic.List<conekta.LineItem> ();
			details.line_items.Add (lineItem0);
			details.line_items.Add (lineItem1);

			conekta.Charge charge = new conekta.Charge ();
			charge.amount = 10000;
			charge.description = "algo";
			charge.reference_id = "ref_01";
			charge.currency = "MXN";
			charge.card = "tok_test_visa_4242";
			charge.details = details;
			charge.create ();

			Assert.AreEqual (true, true);
		}
		[Test ()]
		public void CreateChargeWithCardAndMonthlyInstallments ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.LineItem lineItem0 = new conekta.LineItem();
			lineItem0.name = "Manicure";
			lineItem0.description = "Tratamiento en manos";
			lineItem0.unit_price = 10000;
			lineItem0.quantity = 1;

			conekta.LineItem lineItem1 = new conekta.LineItem();
			lineItem1.name = "Pedicure";
			lineItem1.description = "Tratamiento en pies";
			lineItem1.unit_price = 10000;
			lineItem1.quantity = 1;

			conekta.Details details = new conekta.Details();
			details.name = "Julian Ceballos";
			details.phone = "9999999999";
			details.email = "julian@domain.com";
			details.line_items = new System.Collections.Generic.List<conekta.LineItem> ();
			details.line_items.Add (lineItem0);
			details.line_items.Add (lineItem1);

			conekta.Charge charge = new conekta.Charge ();
			charge.amount = 30000;
			charge.description = "algo";
			charge.reference_id = "ref_01";
			charge.currency = "MXN";
			charge.card = "tok_test_visa_4242";
			charge.details = details;
			charge.monthly_installments = 3;
			charge.create ();

			Assert.AreEqual (true, true);
		}
		[Test ()]
		public void CreateChargeWithOxxo ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.LineItem lineItem0 = new conekta.LineItem();
			lineItem0.name = "Manicure";
			lineItem0.description = "Tratamiento en manos";
			lineItem0.unit_price = 10000;
			lineItem0.quantity = 1;

			conekta.LineItem lineItem1 = new conekta.LineItem();
			lineItem1.name = "Pedicure";
			lineItem1.description = "Tratamiento en pies";
			lineItem1.unit_price = 10000;
			lineItem1.quantity = 1;

			conekta.Details details = new conekta.Details();
			details.name = "Julian Ceballos";
			details.phone = "9999999999";
			details.email = "julian@domain.com";
			details.line_items = new System.Collections.Generic.List<conekta.LineItem> ();
			details.line_items.Add (lineItem0);
			details.line_items.Add (lineItem1);

			conekta.Cash cash = new conekta.Cash ();
			cash.type = "oxxo";
			cash.expires_at = new DateTime (2016, 6, 1);

			conekta.Charge charge = new conekta.Charge ();
			charge.amount = 30000;
			charge.description = "algo";
			charge.reference_id = "ref_01";
			charge.currency = "MXN";
			charge.cash = cash;
			charge.details = details;
			charge.create ();

			Assert.AreEqual (true, true);
		}
		[Test ()]
		public void CreateChargeWithSpei ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.LineItem lineItem0 = new conekta.LineItem();
			lineItem0.name = "Manicure";
			lineItem0.description = "Tratamiento en manos";
			lineItem0.unit_price = 10000;
			lineItem0.quantity = 1;

			conekta.LineItem lineItem1 = new conekta.LineItem();
			lineItem1.name = "Pedicure";
			lineItem1.description = "Tratamiento en pies";
			lineItem1.unit_price = 10000;
			lineItem1.quantity = 1;

			conekta.Details details = new conekta.Details();
			details.name = "Julian Ceballos";
			details.phone = "9999999999";
			details.email = "julian@domain.com";
			details.line_items = new System.Collections.Generic.List<conekta.LineItem> ();
			details.line_items.Add (lineItem0);
			details.line_items.Add (lineItem1);

			conekta.Bank bank = new conekta.Bank ();
			bank.type = "spei";

			conekta.Charge charge = new conekta.Charge ();
			charge.amount = 30000;
			charge.description = "algo";
			charge.reference_id = "ref_01";
			charge.currency = "MXN";
			charge.bank = bank;
			charge.details = details;
			charge.create ();

			Assert.AreEqual (true, true);
		}
		[Test ()]
		public void CreateChargeWithBanorte ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.LineItem lineItem0 = new conekta.LineItem();
			lineItem0.name = "Manicure";
			lineItem0.description = "Tratamiento en manos";
			lineItem0.unit_price = 10000;
			lineItem0.quantity = 1;

			conekta.LineItem lineItem1 = new conekta.LineItem();
			lineItem1.name = "Pedicure";
			lineItem1.description = "Tratamiento en pies";
			lineItem1.unit_price = 10000;
			lineItem1.quantity = 1;

			conekta.Details details = new conekta.Details();
			details.name = "Julian Ceballos";
			details.phone = "9999999999";
			details.email = "julian@domain.com";
			details.line_items = new System.Collections.Generic.List<conekta.LineItem> ();
			details.line_items.Add (lineItem0);
			details.line_items.Add (lineItem1);

			conekta.Bank bank = new conekta.Bank ();
			bank.type = "banorte";
			bank.expires_at = new DateTime (2016, 6, 1);


			conekta.Charge charge = new conekta.Charge ();
			charge.amount = 30000;
			charge.description = "algo";
			charge.reference_id = "ref_01";
			charge.currency = "MXN";
			charge.bank = bank;
			charge.details = details;
			charge.create ();

			Assert.AreEqual (true, true);
		}
		[Test ()]
		public void FindCharge ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge ();
			charge.id = "57146eed19ce882db100d80b";
			charge.find ();

			System.Console.WriteLine (charge.id);
			System.Console.WriteLine (charge.amount);
			System.Console.WriteLine (charge.description);

			Assert.AreEqual (true, true);
		}

		[Test ()]
		public void CreateCustomer ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Customer customer = new conekta.Customer ();
			customer.name = "James Howlett";
			customer.email = "james.howlett@forces.gov";
			customer.phone = "55-5555-5555";
			customer.cards = new System.Collections.Generic.List<string> ();
			customer.cards.Add ("tok_test_visa_4242");
			customer.plan = "gold-plan";
			customer.create ();

			Assert.AreEqual (true, true);
		}
		[Test ()]
		public void FindCustomer ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Customer customer = new conekta.Customer ();
			customer.id = "cus_hFxKZ6BUVPsDPFjST";
			customer.find ();

			Assert.AreEqual (true, true);
		}

		private int RandomNumber(int min, int max, int seed=0)
		{
			Random random = new Random((int)DateTime.Now.Ticks + seed);
			return random.Next(min, max);
		}

		[Test ()]
		public void CreatePlan ()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Plan plan = new conekta.Plan ();
			plan.id = "silver-plan" + RandomNumber(1000, 9999);
			plan.name = "Silver Plan";
			plan.amount = 10000;
			plan.currency = "MXN";
			plan.create ();

			Assert.AreEqual (true, true);
		}
	}
}
