using NUnit.Framework;
using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using conekta;

namespace ConektaTest
{

	[TestFixture()]
	public class OrderTest
	{

		private int RandomNumber(int min, int max, int seed = 0)
		{
			Random random = new Random((int)DateTime.Now.Ticks + seed);
			return random.Next(min, max);
		}

		[Test()]
		public void Card()
		{
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.1.0";

			Order order = new conekta.Order().create(@"{
	            ""currency"":""MXN"",
				""customer_info"": {
					""name"": ""Jul Ceballos"",
					""phone"": ""+5215555555555"",
					""email"": ""jul@conekta.io""
				},
	            ""line_items"": [{
	              ""name"": ""Box of Cohiba S1s"",
	              ""description"": ""Imported From Mex."",
	              ""unit_price"": 35000,
	              ""quantity"": 1,
	              ""tags"": [""food"", ""mexican food""],
	              ""type"": ""physical""
	            }],
				""charges"": [{
					""source"": {
						""type"": ""card"",
						""token_id"": ""tok_test_visa_4242""
					}
				}]
	        }");

			Assert.AreEqual(order.id.GetType().ToString(), "System.String");
			Assert.AreEqual(order.status, "fulfilled");
			Assert.AreEqual(order.amount, 35000);

			order = new Order().find(order.id);

			Assert.AreEqual(order.id.GetType().ToString(), "System.String");
			Assert.AreEqual(order.status, "fulfilled");
			Assert.AreEqual(order.amount, 35000);

			order = order.refund(@"{""amount"": 35000}");

			Assert.AreEqual(order.id.GetType().ToString(), "System.String");
			Assert.AreEqual(order.status, "returned");
			Assert.AreEqual(order.amount, 35000);

			Order[] orders = new Order().where(new JObject());
			Assert.AreEqual(orders[0].id.GetType().ToString(), "System.String");
		}

		[Test()]
		public void CardError()
		{
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.1.0";

			try
			{
				new conekta.Order().create(@"{
		            ""currency"":""MXN"",
					""customer_info"": {
						""name"": ""Jul Ceballos"",
						""phone"": ""+5215555555555"",
						""email"": ""jul@conekta.io""
					}
	        	}");
			}
			catch (ConektaException e)
			{
				Assert.AreEqual(e._object, "error");
				Assert.AreEqual(e._type, "parameter_validation_error");
			}
		}

		[Test()]
		public void Oxxo()
		{
			conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
			conekta.Api.version = "1.1.0";

			Order order = new conekta.Order().create(@"{
	            ""currency"":""MXN"",
				""customer_info"": {
					""name"": ""Jul Ceballos"",
					""phone"": ""+5215555555555"",
					""email"": ""jul@conekta.io""
				},
	            ""line_items"": [{
	              ""name"": ""Box of Cohiba S1s"",
	              ""description"": ""Imported From Mex."",
	              ""unit_price"": 35000,
	              ""quantity"": 1,
	              ""tags"": [""food"", ""mexican food""],
	              ""type"": ""physical""
	            }],
				""charges"": [{
					""source"": {
						""type"": ""oxxo_cash""
					}
				}]
	        }");

			Assert.AreEqual(order.id.GetType().ToString(), "System.String");
			Assert.AreEqual(order.status, "created");
			Assert.AreEqual(order.amount, 35000);

			order = new Order().find(order.id);

			Assert.AreEqual(order.id.GetType().ToString(), "System.String");
			Assert.AreEqual(order.status, "created");
			Assert.AreEqual(order.amount, 35000);

			//order = order.refund(@"{""amount"": 35000}");

			//Assert.AreEqual(order.id.GetType().ToString(), "System.String");
			//Assert.AreEqual(order.status, "returned");
			//Assert.AreEqual(order.amount, 35000);

			Order[] orders = new Order().where(new JObject());
			Assert.AreEqual(orders[0].id.GetType().ToString(), "System.String");
		}
	}
}
