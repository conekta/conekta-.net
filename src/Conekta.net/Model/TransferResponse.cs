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
    /// A transfer represents the action of sending an amount to a business bank account including the status, amount and method used to make the transfer.
    /// </summary>
    [DataContract(Name = "transfer_response")]
    public partial class TransferResponse : IEquatable<TransferResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferResponse" /> class.
        /// </summary>
        /// <param name="amount">Amount in cents of the transfer..</param>
        /// <param name="createdAt">Date and time of creation of the transfer in Unix format..</param>
        /// <param name="currency">The currency of the transfer. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217).</param>
        /// <param name="id">Unique identifier of the transfer..</param>
        /// <param name="livemode">Indicates whether the transfer was created in live mode or test mode..</param>
        /// <param name="destination">destination.</param>
        /// <param name="_object">Object name, which is transfer..</param>
        /// <param name="statementDescription">Description of the transfer..</param>
        /// <param name="statementReference">Reference number of the transfer..</param>
        /// <param name="status">Code indicating transfer status..</param>
        public TransferResponse(long amount = default(long), long createdAt = default(long), string currency = default(string), string id = default(string), bool livemode = default(bool), TransferDestinationResponse destination = default(TransferDestinationResponse), string _object = default(string), string statementDescription = default(string), string statementReference = default(string), string status = default(string))
        {
            this.Amount = amount;
            this.CreatedAt = createdAt;
            this.Currency = currency;
            this.Id = id;
            this.Livemode = livemode;
            this.Destination = destination;
            this.Object = _object;
            this.StatementDescription = statementDescription;
            this.StatementReference = statementReference;
            this.Status = status;
        }

        /// <summary>
        /// Amount in cents of the transfer.
        /// </summary>
        /// <value>Amount in cents of the transfer.</value>
        /// <example>10000</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public long Amount { get; set; }

        /// <summary>
        /// Date and time of creation of the transfer in Unix format.
        /// </summary>
        /// <value>Date and time of creation of the transfer in Unix format.</value>
        /// <example>1553273553</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// The currency of the transfer. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217)
        /// </summary>
        /// <value>The currency of the transfer. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217)</value>
        /// <example>&quot;MXN&quot;</example>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Unique identifier of the transfer.
        /// </summary>
        /// <value>Unique identifier of the transfer.</value>
        /// <example>&quot;5b0337d4dD344ef954fe1X4b6&quot;</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Indicates whether the transfer was created in live mode or test mode.
        /// </summary>
        /// <value>Indicates whether the transfer was created in live mode or test mode.</value>
        /// <example>true</example>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public TransferDestinationResponse Destination { get; set; }

        /// <summary>
        /// Object name, which is transfer.
        /// </summary>
        /// <value>Object name, which is transfer.</value>
        /// <example>&quot;transfer&quot;</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Description of the transfer.
        /// </summary>
        /// <value>Description of the transfer.</value>
        /// <example>&quot;Conekta 4401234&quot;</example>
        [DataMember(Name = "statement_description", EmitDefaultValue = false)]
        public string StatementDescription { get; set; }

        /// <summary>
        /// Reference number of the transfer.
        /// </summary>
        /// <value>Reference number of the transfer.</value>
        /// <example>&quot;4401234&quot;</example>
        [DataMember(Name = "statement_reference", EmitDefaultValue = false)]
        public string StatementReference { get; set; }

        /// <summary>
        /// Code indicating transfer status.
        /// </summary>
        /// <value>Code indicating transfer status.</value>
        /// <example>&quot;pending&quot;</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  StatementDescription: ").Append(StatementDescription).Append("\n");
            sb.Append("  StatementReference: ").Append(StatementReference).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransferResponse);
        }

        /// <summary>
        /// Returns true if TransferResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Livemode == input.Livemode ||
                    this.Livemode.Equals(input.Livemode)
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.StatementDescription == input.StatementDescription ||
                    (this.StatementDescription != null &&
                    this.StatementDescription.Equals(input.StatementDescription))
                ) && 
                (
                    this.StatementReference == input.StatementReference ||
                    (this.StatementReference != null &&
                    this.StatementReference.Equals(input.StatementReference))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Livemode.GetHashCode();
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.StatementDescription != null)
                {
                    hashCode = (hashCode * 59) + this.StatementDescription.GetHashCode();
                }
                if (this.StatementReference != null)
                {
                    hashCode = (hashCode * 59) + this.StatementReference.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
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
