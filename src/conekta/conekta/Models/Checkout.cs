using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta.Models
{
    /// <summary>
    /// Checkout.
    /// </summary>
    public class Checkout : Resource
    {
        #region :: Properties ::

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the livemode.
        /// </summary>
        public bool livemode { get; set; }

        /// <summary>
        /// Gets or sets if the emails sents.
        /// </summary>
        public int emails_sent { get; set; }

        /// <summary>
        /// Gets or sets the paid payments count.
        /// </summary>
        public int paid_payments_count { get; set; }

        /// <summary>
        /// Gets or sets the payments limit count.
        /// </summary>
        public int payments_limit_count { get; set; }

        /// <summary>
        /// Gets or sets if the sms sents.
        /// </summary>
        public int sms_sent { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public string status { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string type { get; set; }

        /// <summary>
        /// Gets or sets the recurrent.
        /// </summary>
        public bool recurrent { get; set; }

        /// <summary>
        /// Gets or sets the expires at.
        /// </summary>
        public string expires_at { get; set; }

        /// <summary>
        /// Gets or sets the allowed payment methods.
        /// </summary>
        public string[] allowed_payment_methods { get; set; }

        /// <summary>
        /// Gets or sets if needs shipping contact.
        /// </summary>
        public bool needs_shipping_contact { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public int[] monthly_installments_options { get; set; }

        /// <summary>
        /// Gets or sets if monthly installments are enabled.
        /// </summary>
        public bool monthly_installments_enabled { get; set; }

        /// <summary>
        /// Gets or sets flag for on demand enabled.
        /// </summary>
        public bool on_demand_enabled { get; set; }

        /// <summary>
        /// Gets or sets the expired at.
        /// </summary>
        public int expired_at { get; set; }

        /// <summary>
        /// Gets or sets the slug.
        /// </summary>
        public string slug { get; set; }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// Gets or set the object.
        /// </summary>
        public string _object { get; set; }

        #endregion

        #region :: Methods ::

        /// <summary>
        /// Creates a checkout.
        /// </summary>
        /// <param name="data">Parameters.</param>
        /// <returns>Checkout object.</returns>
        public Checkout create(string data)
        {
            string checkout = create("/checkouts", data);
            return toClass(checkout);
        }

        /// <summary>
        /// Finds a checkout.
        /// </summary>
        /// <param name="id">Checkout id.</param>
        /// <returns>Checkout object.</returns>
        public Checkout find(string id)
        {
            string checkout = find($"/checkouts", id);
            return toClass(checkout);
        }

        /// <summary>
        /// Gets arrar of chekout.
        /// </summary>
        /// <param name="data">Parameters</param>
        /// <returns>Arrar of Checkout.</returns>
        public Checkout[] where(JObject data)
        {
            string result = where("/checkouts", data.ToString());

            result = result.Replace("\"object\"", "\"_object\"");

            JObject ords = JObject.Parse(result);

            JArray list = (JArray)ords["data"];

            List<Checkout> checkouts = new List<Checkout>();

            foreach (var item in list)
            {
                checkouts.Add(toClass(JsonConvert.SerializeObject(item)));
            }

            return checkouts.ToArray();
        }

        /// <summary>
        /// Sends sms.
        /// </summary>
        /// <param name="data">Parameters.</param>
        /// <returns>Checkout object.</returns>
        public Checkout send_sms(string data)
        {
            string checkout = request("POST", $"/checkouts/{id}/sms", data);
            return toClass(checkout);
        }

        /// <summary>
        /// Sends email.
        /// </summary>
        /// <param name="data">Parameters.</param>
        /// <returns>Checkout object.</returns>
        public Checkout send_email(string data)
        {
            string checkout = request("POST", $"/checkouts/{id}/email", data);
            return toClass(checkout);
        }

        /// <summary>
        /// Cancel checkout.
        /// </summary>
        /// <param name="data">Parameters.</param>
        /// <returns>Checkout object.</returns>
        public Checkout cancel(string data)
        {
            string checkout = request("PUT", $"/checkouts/{id}/cancel", data);
            return toClass(checkout);
        }

        /// <summary>
        /// Convert string to class.
        /// </summary>
        /// <param name="json">String to convert.</param>
        /// <returns>Checkout object.</returns>
        public Checkout toClass(string json)
        {
            json = json.Replace("\"object\"", "\"_object\"");

            Checkout checkout = JsonConvert.DeserializeObject<Checkout>(json,
              new JsonSerializerSettings
              {
                  NullValueHandling = NullValueHandling.Ignore
              });

            return checkout;
        }

        #endregion
    }
}
