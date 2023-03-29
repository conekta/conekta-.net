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
    /// a plan
    /// </summary>
    [DataContract(Name = "plan_update_request")]
    public partial class PlanUpdateRequest : IEquatable<PlanUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanUpdateRequest" /> class.
        /// </summary>
        /// <param name="amount">The amount in cents that will be charged on the interval specified..</param>
        /// <param name="currency">ISO 4217 for currencies, for the Mexican peso it is MXN/USD.</param>
        /// <param name="expiryCount">Number of repetitions of the frequency NUMBER OF CHARGES TO BE MADE, considering the interval and frequency, this evolves over time, but is subject to the expiration count..</param>
        /// <param name="name">The name of the plan..</param>
        public PlanUpdateRequest(int amount = default(int), string currency = default(string), int expiryCount = default(int), string name = default(string))
        {
            this.Amount = amount;
            this.Currency = currency;
            this.ExpiryCount = expiryCount;
            this.Name = name;
        }

        /// <summary>
        /// The amount in cents that will be charged on the interval specified.
        /// </summary>
        /// <value>The amount in cents that will be charged on the interval specified.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// ISO 4217 for currencies, for the Mexican peso it is MXN/USD
        /// </summary>
        /// <value>ISO 4217 for currencies, for the Mexican peso it is MXN/USD</value>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Number of repetitions of the frequency NUMBER OF CHARGES TO BE MADE, considering the interval and frequency, this evolves over time, but is subject to the expiration count.
        /// </summary>
        /// <value>Number of repetitions of the frequency NUMBER OF CHARGES TO BE MADE, considering the interval and frequency, this evolves over time, but is subject to the expiration count.</value>
        [DataMember(Name = "expiry_count", EmitDefaultValue = false)]
        public int ExpiryCount { get; set; }

        /// <summary>
        /// The name of the plan.
        /// </summary>
        /// <value>The name of the plan.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlanUpdateRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExpiryCount: ").Append(ExpiryCount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as PlanUpdateRequest);
        }

        /// <summary>
        /// Returns true if PlanUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PlanUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanUpdateRequest input)
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
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.ExpiryCount == input.ExpiryCount ||
                    this.ExpiryCount.Equals(input.ExpiryCount)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiryCount.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
            // Amount (int) minimum
            if (this.Amount < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 1.", new [] { "Amount" });
            }

            // Currency (string) maxLength
            if (this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            yield break;
        }
    }

}
