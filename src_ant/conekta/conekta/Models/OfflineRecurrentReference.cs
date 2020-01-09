using System;
using Newtonsoft.Json;

namespace conekta
{
    public class OfflineRecurrentReference : PaymentSource
    {
        public string reference { get; set; }
        public string barcode { get; set; }
        public string barcode_url { get; set; }
        public string provider { get; set; }
        public string expires_at { get; set; }

        public OfflineRecurrentReference ToClass(string json)
        {
            OfflineRecurrentReference reference = JsonConvert.DeserializeObject<OfflineRecurrentReference>(json, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return reference;
        }

        public OfflineRecurrentReference Update(string data)
        {
            OfflineRecurrentReference payment_source = this.ToClass(this.toObject(this.update("/customers/" + this.parent_id + "/payment_sources/" + this.id, data)).ToString());
            return payment_source;
        }
    }
}
