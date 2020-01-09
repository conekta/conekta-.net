using Newtonsoft.Json;
namespace conekta
{
    /// <summary>
    /// Representation of PaymentSource of type Card.
    /// </summary>
    public class Card : PaymentSource
    {
        public string token_id { get; set; }

        public string name { get; set; }
        public string number { get; set; }
        public string exp_month { get; set; }
        public string reference { get; set; }
        public string exp_year { get; set; }
        public string cvc { get; set; }
        public string last4 { get; set; }
        public string bin { get; set; }
        public string brand { get; set; }
        public Address address { get; set; }

        /// <summary>
        /// Convert json string of a card into a Card object.
        /// </summary>
        /// <returns>The class.</returns>
        /// <param name="json">Json string of a card</param>
        public Card toClass(string json)
        {
            Card card = JsonConvert.DeserializeObject<Card>(json, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return card;
        }

        /// <summary>
        /// Update the specified card.
        /// </summary>
        /// <returns>The Card updated</returns>
        /// <param name="data">Json String of the card data to be updated</param>
        public Card Update(string data)
        {
            Card payment_source = this.toClass(this.toObject(this.update("/customers/" + this.parent_id + "/payment_sources/" + this.id, data)).ToString());
            return payment_source;
        }

    }
}
