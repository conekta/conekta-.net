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
    /// The Transaction object represents the actions or steps of an order. Statuses can be: unprocessed, pending, available, owen, paid_out, voided, capture, capture_reversal, liquidation, liquidation_reversal, payout, payout_reversal, refund, refund_reversal, chargeback, chargeback_reversal, rounding_adjustment, won_chargeback, transferred, and transferred.
    /// </summary>
    [DataContract(Name = "transaction_response")]
    public partial class TransactionResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionResponse" /> class.
        /// </summary>
        /// <param name="amount">The amount of the transaction. (required).</param>
        /// <param name="charge">Randomly assigned unique order identifier associated with the charge. (required).</param>
        /// <param name="createdAt">Date and time of creation of the transaction in Unix format. (required).</param>
        /// <param name="currency">The currency of the transaction. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217) (required).</param>
        /// <param name="fee">The amount to be deducted for taxes and commissions. (required).</param>
        /// <param name="id">Unique identifier of the transaction. (required).</param>
        /// <param name="livemode">Indicates whether the transaction was created in live mode or test mode. (required).</param>
        /// <param name="net">The net amount after deducting commissions and taxes. (required).</param>
        /// <param name="varObject">Object name, which is transaction. (required).</param>
        /// <param name="status">Code indicating transaction status. (required).</param>
        /// <param name="type">Transaction Type (required).</param>
        public TransactionResponse(long amount = default(long), string charge = default(string), long createdAt = default(long), string currency = default(string), long fee = default(long), string id = default(string), bool livemode = default(bool), long net = default(long), string varObject = default(string), string status = default(string), string type = default(string))
        {
            this.Amount = amount;
            // to ensure "charge" is required (not null)
            if (charge == null)
            {
                throw new ArgumentNullException("charge is a required property for TransactionResponse and cannot be null");
            }
            this.Charge = charge;
            this.CreatedAt = createdAt;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for TransactionResponse and cannot be null");
            }
            this.Currency = currency;
            this.Fee = fee;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TransactionResponse and cannot be null");
            }
            this.Id = id;
            this.Livemode = livemode;
            this.Net = net;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for TransactionResponse and cannot be null");
            }
            this.VarObject = varObject;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for TransactionResponse and cannot be null");
            }
            this.Status = status;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for TransactionResponse and cannot be null");
            }
            this.Type = type;
        }

        /// <summary>
        /// The amount of the transaction.
        /// </summary>
        /// <value>The amount of the transaction.</value>
        /// <example>1000</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Randomly assigned unique order identifier associated with the charge.
        /// </summary>
        /// <value>Randomly assigned unique order identifier associated with the charge.</value>
        /// <example>5ee7ec58885a45585e6d9f8m</example>
        [DataMember(Name = "charge", IsRequired = true, EmitDefaultValue = true)]
        public string Charge { get; set; }

        /// <summary>
        /// Date and time of creation of the transaction in Unix format.
        /// </summary>
        /// <value>Date and time of creation of the transaction in Unix format.</value>
        /// <example>1553273553</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// The currency of the transaction. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217)
        /// </summary>
        /// <value>The currency of the transaction. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217)</value>
        /// <example>MXN</example>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The amount to be deducted for taxes and commissions.
        /// </summary>
        /// <value>The amount to be deducted for taxes and commissions.</value>
        /// <example>560</example>
        [DataMember(Name = "fee", IsRequired = true, EmitDefaultValue = true)]
        public long Fee { get; set; }

        /// <summary>
        /// Unique identifier of the transaction.
        /// </summary>
        /// <value>Unique identifier of the transaction.</value>
        /// <example>5ee7ec5b8dea41085erb7f9e</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Indicates whether the transaction was created in live mode or test mode.
        /// </summary>
        /// <value>Indicates whether the transaction was created in live mode or test mode.</value>
        /// <example>true</example>
        [DataMember(Name = "livemode", IsRequired = true, EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// The net amount after deducting commissions and taxes.
        /// </summary>
        /// <value>The net amount after deducting commissions and taxes.</value>
        /// <example>440</example>
        [DataMember(Name = "net", IsRequired = true, EmitDefaultValue = true)]
        public long Net { get; set; }

        /// <summary>
        /// Object name, which is transaction.
        /// </summary>
        /// <value>Object name, which is transaction.</value>
        /// <example>transaction</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// Code indicating transaction status.
        /// </summary>
        /// <value>Code indicating transaction status.</value>
        /// <example>pending</example>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Transaction Type
        /// </summary>
        /// <value>Transaction Type</value>
        /// <example>capture</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Charge: ").Append(Charge).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Net: ").Append(Net).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            // Currency (string) maxLength
            if (this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            yield break;
        }
    }

}
