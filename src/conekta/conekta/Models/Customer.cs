using System.Text.RegularExpressions;
using System.Reflection;
using System.Collections.Generic;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
    public class Customer : Resource
    {
        public string id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public bool corporate { get; set; }
        public PaymentSource[] payment_sources { get; set; }
        public FiscalEntity[] fiscal_entities { get; set; }
        public ShippingContact[] shipping_contacts { get; set; }
        public Subscription subscription { get; set; }
        public int account_age { get; set; }
        public int paid_transactions { get; set; }
        public int first_paid_at { get; set; }
        public string created_at { get; set; }

        public Customer create(string data)
        {
            string customer = this.create("/customers", data);
            JObject customerObject = this.toObject(customer);
            return this.toClass(customerObject.ToString());
        }

        public Customer find(string id)
        {
            string customer = this.find("/customers", id);
            return this.toClass(this.toObject(customer).ToString());
        }

        public Customer[] where(JObject data)
        {
            string result = this.where("/customers", data.ToString());

            Regex pattern = new Regex("\"object\":", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            result = pattern.Replace(result, "\"_object\":");

            JObject ords = JObject.Parse(result);

            JArray list = (JArray)ords["data"];

            Customer[] customers = new Customer[list.Count];

            int counter = 0;

            foreach (var item in ords.GetValue("data"))
            {
                customers[counter] = this.toClass(this.toObject(item.ToString()).ToString());
                counter++;
            }

            return customers;
        }

        public Customer update(string data)
        {
            Customer customer = this.toClass(this.toObject(this.update("/customers/" + this.id, data)).ToString());
            return customer;
        }

        public Customer destroy()
        {
            this.delete("/customers/" + this.id);
            return this;
        }

        /// <summary>
        /// Creates a card.
        /// </summary>
        /// <returns>The Card.</returns>
        /// <param name="data">Card data.</param>
        public PaymentSource CreateCard(string data)
        {
            string card = this.create("/customers/" + this.id + "/payment_sources", data);
            Card skeleton = new Card();
            JObject cardObjet = skeleton.toObject(card);
            return (PaymentSource)skeleton.toClass(cardObjet.ToString());
        }

        /// <summary>
        /// Creates the offline recurrent reference.
        /// </summary>
        /// <returns>The OfflineRecurrentReference.</returns>
        /// <param name="data">Reference data.</param>
        public PaymentSource CreateOfflineRecurrentReference(string data)
        {
            string reference = this.create("/customers/" + this.id + "/payment_sources", data);
            OfflineRecurrentReference skeleton = new OfflineRecurrentReference();
            JObject cardObject = skeleton.toObject(reference);
            return (PaymentSource)skeleton.ToClass(cardObject.ToString());
        }

        public ShippingContact createShippingContact(string data)
        {
            string shipping_contact = this.create("/customers/" + this.id + "/shipping_contacts", data);
            ShippingContact skeleton = new ShippingContact();
            return skeleton.toClass(skeleton.toObject(shipping_contact).ToString());
        }

        public FiscalEntity createFiscalEntity(string data)
        {
            string fiscal_entity = this.create("/customers/" + this.id + "/fiscal_entities", data);
            FiscalEntity skeleton = new FiscalEntity();
            return skeleton.toClass(skeleton.toObject(fiscal_entity).ToString());
        }

        public Subscription createSubscription(string data)
        {
            string subscription = this.create("/customers/" + this.id + "/subscription", data);
            Subscription skeleton = new Subscription();
            return skeleton.toClass(skeleton.toObject(subscription).ToString());
        }

        public Customer toClass(string json)
        {
            JObject data = JObject.Parse(json);
            JArray paymentSourcesData = (JArray)data.GetValue("payment_sources");
            data.Remove("payment_sources");

            Customer customer = JsonConvert.DeserializeObject<Customer>(json, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            if (paymentSourcesData != null && paymentSourcesData.Count > 0)
            {
                for (int x = 0; x < paymentSourcesData.Count; x++)
                {
                    JObject item = (JObject)paymentSourcesData[x];

                    if (item.GetValue("type").ToString() == "oxxo_recurrent")
                    {
                        OfflineRecurrentReference paymentSource = JsonConvert.DeserializeObject<OfflineRecurrentReference>(item.ToString(), new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });

                        customer.payment_sources[x] = paymentSource;
                    }
                    else
                    {
                        Card paymentSource = JsonConvert.DeserializeObject<Card>(item.ToString(), new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        });

                        customer.payment_sources[x] = paymentSource;
                    }
                }
            }

            return customer;
        }
    }
}
