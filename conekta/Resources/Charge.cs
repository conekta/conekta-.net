using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class Charge : Resource
	{
		public string id { get; set; }
		public string description { get; set; }
		public int amount { get; set; }
		public int monthly_installments { get; set; }
		public string currency { get; set; }
		public string reference_id { get; set; }
		public string card { get; set; }
		public Cash cash { get; set; }
		public Bank bank { get; set; }
		public Details details { get; set; }

		public void set_attrs(JObject charge)
		{
			System.Console.WriteLine (charge);
			this.id = charge.GetValue ("id").ToString();
			this.description = charge.GetValue ("description").ToString ();
			this.amount = (int)charge.GetValue ("amount");
			this.currency = charge.GetValue ("currency").ToString();
			this.reference_id = charge.GetValue ("reference_id").ToString();

			try {
				this.card = charge.GetValue("card").ToString();
			} catch (Exception e) {
				var x = e.Data;
			}

			try {
				conekta.Bank bank = new conekta.Bank();
				bank.type = 
				//String bank = charge.GetValue("bank").ToString();
				//this.card = charge.GetValue("card").ToString();
			} catch (Exception e) {
				var x = e.Data;
			}

		}


		public void create()
		{
			String data = this.toJSON();

			JObject charge = this.create ("/charges", data);
			this.set_attrs (charge);
		}

		public void find()
		{
			JObject charge = this.find ("/charges", this.id);
			this.set_attrs (charge);
		}

		public void update()
		{
			
		}
	}
}
