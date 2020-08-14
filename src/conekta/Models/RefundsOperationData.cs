using Newtonsoft.Json;

namespace Conekta.Models
{
    /// <summary>
    /// Refunds operation data.
    /// </summary>
    public class RefundsOperationData
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of the object.
        /// </summary>
        /// <value>The type of the object.</value>
        [JsonProperty(PropertyName = "object")]
        public string ObjectType { get; set; }
        
        /// <summary>
        /// Gets the amount.
        /// </summary>
        /// <value>The amount.</value>
        [JsonProperty(PropertyName = "amount")]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or sets the auth code.
        /// </summary>
        /// <value>The auth code.</value>
        [JsonProperty(PropertyName = "auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// Gets the creation date.
        /// </summary>
        [JsonProperty(PropertyName = "created_at")]
        public long CreatedAt { get; private set; }

    }
}