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
    /// plans model
    /// </summary>
    [DataContract(Name = "plan_response")]
    public partial class PlanResponse : IEquatable<PlanResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanResponse" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="currency">currency.</param>
        /// <param name="expiryCount">expiryCount.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="id">id.</param>
        /// <param name="interval">interval.</param>
        /// <param name="livemode">livemode.</param>
        /// <param name="name">name.</param>
        /// <param name="varObject">varObject.</param>
        /// <param name="trialPeriodDays">trialPeriodDays.</param>
        public PlanResponse(int amount = default(int), long createdAt = default(long), string currency = default(string), int? expiryCount = default(int?), int frequency = default(int), string id = default(string), string interval = default(string), bool livemode = default(bool), string name = default(string), string varObject = default(string), int? trialPeriodDays = default(int?))
        {
            this.Amount = amount;
            this.CreatedAt = createdAt;
            this.Currency = currency;
            this.ExpiryCount = expiryCount;
            this.Frequency = frequency;
            this.Id = id;
            this.Interval = interval;
            this.Livemode = livemode;
            this.Name = name;
            this.VarObject = varObject;
            this.TrialPeriodDays = trialPeriodDays;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>10000</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>1666900846</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        /// <example>MXN</example>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets ExpiryCount
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "expiry_count", EmitDefaultValue = true)]
        public int? ExpiryCount { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "frequency", EmitDefaultValue = false)]
        public int Frequency { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>gold-plan</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        /// <example>month</example>
        [DataMember(Name = "interval", EmitDefaultValue = false)]
        public string Interval { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Extra Plan3</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        /// <example>plan</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string VarObject { get; set; }

        /// <summary>
        /// Gets or Sets TrialPeriodDays
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "trial_period_days", EmitDefaultValue = true)]
        public int? TrialPeriodDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlanResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExpiryCount: ").Append(ExpiryCount).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  TrialPeriodDays: ").Append(TrialPeriodDays).Append("\n");
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
            return this.Equals(input as PlanResponse);
        }

        /// <summary>
        /// Returns true if PlanResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PlanResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanResponse input)
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
                    this.ExpiryCount == input.ExpiryCount ||
                    (this.ExpiryCount != null &&
                    this.ExpiryCount.Equals(input.ExpiryCount))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    this.Frequency.Equals(input.Frequency)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.Livemode == input.Livemode ||
                    this.Livemode.Equals(input.Livemode)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.VarObject == input.VarObject ||
                    (this.VarObject != null &&
                    this.VarObject.Equals(input.VarObject))
                ) && 
                (
                    this.TrialPeriodDays == input.TrialPeriodDays ||
                    (this.TrialPeriodDays != null &&
                    this.TrialPeriodDays.Equals(input.TrialPeriodDays))
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
                if (this.ExpiryCount != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryCount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Interval != null)
                {
                    hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Livemode.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                if (this.TrialPeriodDays != null)
                {
                    hashCode = (hashCode * 59) + this.TrialPeriodDays.GetHashCode();
                }
                return hashCode;
            }
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
