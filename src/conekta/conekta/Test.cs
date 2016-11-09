using NUnit.Framework;
using System;
using System.Collections.Generic;

using Newtonsoft.Json.Linq;

using conekta;

namespace ConektaTest
{
	[TestFixture()]
	public class WebhookTest
	{

		public Webhook wh;

		[Test()]
		public void Create()
		{
			wh = new conekta.Webhook().create(@"{
                    ""url"": ""http://requestb.in/1gze6sp1"",
                    ""events"": [""charge.created"", ""charge.paid"", ""charge.under_fraud_review"",
                      ""charge.fraudulent"", ""charge.refunded"", ""charge.created"", ""customer.created"",
                      ""customer.updated"", ""customer.deleted"", ""webhook.created"", ""webhook.updated"",
                      ""webhook.deleted"", ""charge.chargeback.created"", ""charge.chargeback.updated"",
                      ""charge.chargeback.under_review"", ""charge.chargeback.lost"", ""charge.chargeback.won"",
                      ""payout.created"", ""payout.retrying"", ""payout.paid_out"", ""payout.failed"",
                      ""plan.created"", ""plan.updated"", ""plan.deleted"", ""subscription.created"",
                      ""subscription.paused"", ""subscription.resumed"", ""subscription.canceled"",
                      ""subscription.expired"", ""subscription.updated"", ""subscription.paid"",
                      ""subscription.payment_failed"", ""payee.created"", ""payee.updated"",
                      ""payee.deleted"", ""payee.payout_method.created"",
                      ""payee.payout_method.updated"", ""payee.payout_method.deleted""
                    ]
                  }");
			Assert.AreEqual(wh.id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void Find()
		{
			wh = new conekta.Webhook().find(wh.id);
			Assert.AreEqual(wh.id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void Update()
		{
			try
			{
				wh.update(@"{""url"": ""http://conekta.io""}");
				Assert.AreEqual(wh.url, "http://conekta.io");
			}
			catch (ConektaException ex)
			{
				Assert.AreEqual(ex._type, "parameter_validation_error");
			}
		}

	}

	[TestFixture()]
	public class LogTest
	{

		[Test()]
		public void Where()
		{
			JObject[] logs = new conekta.Log().where();

			Assert.AreEqual(logs[0].GetValue("url").GetType().ToString(), "Newtonsoft.Json.Linq.JValue");
		}

	}

	[TestFixture()]
	public class PlanTest
	{
		[Test()]
		public void Create()
		{
			conekta.Plan plan = new conekta.Plan().create(@"{
                   ""id"":""gold-plan1991"",
                   ""name"":""Gold Plan 1991"",
                   ""amount"":10000
                }");

			Assert.AreEqual(plan.id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void Edit()
		{
			conekta.Plan plan = new conekta.Plan().find("gold-plan1991");
			plan.update(@"{
                   ""name"":""Gold Plan 500"",
                   ""amount"":55555
                }");

			Assert.AreEqual(plan.name, "Gold Plan 500");
			Assert.AreEqual(plan.amount, 55555);
		}

		[Test()]
		public void Find()
		{
			conekta.Plan plan = new conekta.Plan().find("gold-plan1991");

			Assert.AreEqual(plan.id, "gold-plan1991");
		}

		[Test()]
		public void Remove()
		{
			conekta.Plan plan = new conekta.Plan().find("gold-plan1991");
			plan.delete();
		}
	}

	[TestFixture()]
	public class CustomerTest
	{
		public Customer customer;

		[Test()]
		public void Create()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			this.customer = new conekta.Customer().create(@"{
                    ""name"":""James Howlett"",
                    ""email"":""james.howlett@forces.gov"",
                    ""phone"":""55-5555-5555"",
                    ""cards"":[""tok_test_visa_4242""],
                    ""plan"":""gold-plan""
                  }");

			Assert.AreEqual(this.customer.id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void Find()
		{
			this.customer = new conekta.Customer().find(this.customer.id);

			Assert.AreEqual(this.customer.id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void Update()
		{
			this.customer = this.customer.update(@"{
                  ""name"":""Logan"",
                  ""email"":""logan@x-men.org""
                }");

			Assert.AreEqual(this.customer.name, "Logan");
		}

		[Test()]
		public void ManageCard()
		{
			this.customer.createCard(@"{
                   ""token"":""tok_test_mastercard_4444""
                }");

			Assert.AreEqual(this.customer.cards[1].last4, "4444");

			this.customer.cards[1].update(@"{""token"": ""tok_test_mastercard_5100""}");

			Assert.AreEqual(this.customer.cards[1].last4, "5100");

			int previous = this.customer.cards.Count;

			this.customer.cards[1].delete();

			int current = this.customer.cards.Count;

			Assert.AreEqual(previous - 1, current);
		}

		[Test()]
		public void ManageSubscription()
		{
			this.customer.createSubscription(@"{
                   ""plan"":""gold-plan""
                }");

			Assert.AreEqual(this.customer.plan, "gold-plan");

			this.customer.subscription.update(@"{
                   ""plan"":""opal-plan""
                }");

			Assert.AreEqual(this.customer.subscription.plan_id, "opal-plan");

			this.customer.subscription.pause();

			Assert.AreEqual(this.customer.subscription.status, "paused");

			this.customer.subscription.resume();

			Assert.AreEqual(this.customer.subscription.status, "active");

			this.customer.subscription.cancel();

			Assert.AreEqual(this.customer.subscription.status, "canceled");
		}
	}

	[TestFixture()]
	public class ChargeTest
	{

		private int RandomNumber(int min, int max, int seed = 0)
		{
			Random random = new Random((int)DateTime.Now.Ticks + seed);
			return random.Next(min, max);
		}

		[Test()]
		public void Card()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge().create(@"{
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

			Assert.AreEqual(charge.payment_method.type, "credit");
			Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
			Assert.AreEqual(charge.amount, 20000);

			charge = new Charge().find(charge.id);

			Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
			Assert.AreEqual(charge.amount, 20000);

			charge = charge.capture();

			Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
			Assert.AreEqual(charge.amount, 20000);

			charge = charge.refund();

			Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
			Assert.AreEqual(charge.amount, 20000);

			Charge[] charges = new Charge().where(@"{""status.ne"": ""paid""}");
			Assert.AreEqual(charges[0].id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void MonthlyInstallments()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge().create(@"{
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

			Assert.AreEqual(charge.payment_method.type, "credit");
			Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void Oxxo()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge().create(@"{
                    ""description"":""Stogies"",
                    ""amount"": 20000,
                    ""currency"":""MXN"",
                    ""reference_id"":""9839-wolf_pack"",
                    ""cash"": {
                      ""type"": ""oxxo"",
                      ""expires_at"": 1476057600
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

			Assert.AreEqual(charge.payment_method.type, "oxxo");
			Assert.AreEqual(charge.payment_method.barcode.GetType().ToString(), "System.String");
			Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void Spei()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge().create(@"{
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
			
			Assert.AreEqual(charge.payment_method.type, "spei");
			Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void Banorte()
		{
			conekta.Api.locale = "es";
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.0.0";

			conekta.Charge charge = new conekta.Charge().create(@"{
                    ""description"":""Stogies"",
                    ""amount"": 20000,
                    ""currency"":""MXN"",
                    ""reference_id"":""9839-wolf_pack"",
                    ""bank"": {
                      ""type"": ""banorte"",
                      ""expires_at"": 1476057600
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
			
			Assert.AreEqual(charge.payment_method.type, "banorte");
			Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
		}
	}
}
