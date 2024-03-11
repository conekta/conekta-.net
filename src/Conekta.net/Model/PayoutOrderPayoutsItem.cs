/*
 * Conekta API
 *
 * Conekta sdk
 *
 * The version of the OpenAPI document: 2.1.0
 * Contact: engineering@conekta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Conekta.net.Client.OpenAPIDateConverter;

namespace Conekta.net.Model
{
    /// <summary>
    /// PayoutOrderPayoutsItem
    /// </summary>
    [DataContract(Name = "payout_order_payouts_item")]
    public partial class PayoutOrderPayoutsItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutOrderPayoutsItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutOrderPayoutsItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutOrderPayoutsItem" /> class.
        /// </summary>
        /// <param name="amount">The amount of the payout. (required).</param>
        /// <param name="currency">The currency in which the payout is made. (required).</param>
        /// <param name="expiresAt">The expiration date of the payout..</param>
        /// <param name="id">The id of the payout. (required).</param>
        /// <param name="livemode">The live mode of the payout. (required).</param>
        /// <param name="varObject">The object of the payout. (required).</param>
        /// <param name="payoutOrderId">The id of the payout order..</param>
        /// <param name="status">The status of the payout..</param>
        public PayoutOrderPayoutsItem(int amount = default(int), string currency = default(string), long expiresAt = default(long), string id = default(string), bool livemode = default(bool), string varObject = default(string), string payoutOrderId = default(string), string status = default(string))
        {
            this.Amount = amount;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for PayoutOrderPayoutsItem and cannot be null");
            }
            this.Currency = currency;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PayoutOrderPayoutsItem and cannot be null");
            }
            this.Id = id;
            this.Livemode = livemode;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for PayoutOrderPayoutsItem and cannot be null");
            }
            this.VarObject = varObject;
            this.ExpiresAt = expiresAt;
            this.PayoutOrderId = payoutOrderId;
            this.Status = status;
        }

        /// <summary>
        /// The amount of the payout.
        /// </summary>
        /// <value>The amount of the payout.</value>
        /// <example>3000</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public int Amount { get; set; }

        /// <summary>
        /// The currency in which the payout is made.
        /// </summary>
        /// <value>The currency in which the payout is made.</value>
        /// <example>MXN</example>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The expiration date of the payout.
        /// </summary>
        /// <value>The expiration date of the payout.</value>
        /// <example>1677626837</example>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// The id of the payout.
        /// </summary>
        /// <value>The id of the payout.</value>
        /// <example>payout_2vZwsRAhhGp2dFDJx</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The live mode of the payout.
        /// </summary>
        /// <value>The live mode of the payout.</value>
        /// <example>true</example>
        [DataMember(Name = "livemode", IsRequired = true, EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// The object of the payout.
        /// </summary>
        /// <value>The object of the payout.</value>
        /// <example>payout</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// The id of the payout order.
        /// </summary>
        /// <value>The id of the payout order.</value>
        /// <example>f2654d66-d740-457a-9a8c-f96b5196f44e</example>
        [DataMember(Name = "payout_order_id", EmitDefaultValue = false)]
        public string PayoutOrderId { get; set; }

        /// <summary>
        /// The status of the payout.
        /// </summary>
        /// <value>The status of the payout.</value>
        /// <example>open</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayoutOrderPayoutsItem {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  PayoutOrderId: ").Append(PayoutOrderId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
