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
    [DataContract(Name = "plan_request")]
    public partial class PlanRequest : IEquatable<PlanRequest>, IValidatableObject
    {
        /// <summary>
        /// The interval of time between each charge.
        /// </summary>
        /// <value>The interval of time between each charge.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum IntervalEnum
        {
            /// <summary>
            /// Enum Week for value: week
            /// </summary>
            [EnumMember(Value = "week")]
            Week = 1,

            /// <summary>
            /// Enum HalfMonth for value: half_month
            /// </summary>
            [EnumMember(Value = "half_month")]
            HalfMonth = 2,

            /// <summary>
            /// Enum Month for value: month
            /// </summary>
            [EnumMember(Value = "month")]
            Month = 3,

            /// <summary>
            /// Enum Year for value: year
            /// </summary>
            [EnumMember(Value = "year")]
            Year = 4

        }


        /// <summary>
        /// The interval of time between each charge.
        /// </summary>
        /// <value>The interval of time between each charge.</value>
        [DataMember(Name = "interval", IsRequired = true, EmitDefaultValue = true)]
        public IntervalEnum Interval { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlanRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PlanRequest" /> class.
        /// </summary>
        /// <param name="amount">The amount in cents that will be charged on the interval specified. (required).</param>
        /// <param name="currency">ISO 4217 for currencies, for the Mexican peso it is MXN/USD.</param>
        /// <param name="expiryCount">Number of repetitions of the frequency NUMBER OF CHARGES TO BE MADE, considering the interval and frequency, this evolves over time, but is subject to the expiration count..</param>
        /// <param name="frequency">Frequency of the charge, which together with the interval, can be every 3 weeks, every 4 months, every 2 years, every 5 fortnights (required).</param>
        /// <param name="id">internal reference id.</param>
        /// <param name="interval">The interval of time between each charge. (required).</param>
        /// <param name="name">The name of the plan. (required).</param>
        /// <param name="trialPeriodDays">The number of days the customer will have a free trial..</param>
        public PlanRequest(int amount = default(int), string currency = default(string), int expiryCount = default(int), int frequency = default(int), string id = default(string), IntervalEnum interval = default(IntervalEnum), string name = default(string), int trialPeriodDays = default(int))
        {
            this.Amount = amount;
            this.Frequency = frequency;
            this.Interval = interval;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for PlanRequest and cannot be null");
            }
            this.Name = name;
            this.Currency = currency;
            this.ExpiryCount = expiryCount;
            this.Id = id;
            this.TrialPeriodDays = trialPeriodDays;
        }

        /// <summary>
        /// The amount in cents that will be charged on the interval specified.
        /// </summary>
        /// <value>The amount in cents that will be charged on the interval specified.</value>
        /// <example>10000</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public int Amount { get; set; }

        /// <summary>
        /// ISO 4217 for currencies, for the Mexican peso it is MXN/USD
        /// </summary>
        /// <value>ISO 4217 for currencies, for the Mexican peso it is MXN/USD</value>
        /// <example>&quot;MXN&quot;</example>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Number of repetitions of the frequency NUMBER OF CHARGES TO BE MADE, considering the interval and frequency, this evolves over time, but is subject to the expiration count.
        /// </summary>
        /// <value>Number of repetitions of the frequency NUMBER OF CHARGES TO BE MADE, considering the interval and frequency, this evolves over time, but is subject to the expiration count.</value>
        /// <example>12</example>
        [DataMember(Name = "expiry_count", EmitDefaultValue = false)]
        public int ExpiryCount { get; set; }

        /// <summary>
        /// Frequency of the charge, which together with the interval, can be every 3 weeks, every 4 months, every 2 years, every 5 fortnights
        /// </summary>
        /// <value>Frequency of the charge, which together with the interval, can be every 3 weeks, every 4 months, every 2 years, every 5 fortnights</value>
        /// <example>1</example>
        [DataMember(Name = "frequency", IsRequired = true, EmitDefaultValue = true)]
        public int Frequency { get; set; }

        /// <summary>
        /// internal reference id
        /// </summary>
        /// <value>internal reference id</value>
        /// <example>&quot;plan_24234&quot;</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of the plan.
        /// </summary>
        /// <value>The name of the plan.</value>
        /// <example>&quot;Extra Plan3&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The number of days the customer will have a free trial.
        /// </summary>
        /// <value>The number of days the customer will have a free trial.</value>
        /// <example>0</example>
        [DataMember(Name = "trial_period_days", EmitDefaultValue = false)]
        public int TrialPeriodDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlanRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExpiryCount: ").Append(ExpiryCount).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as PlanRequest);
        }

        /// <summary>
        /// Returns true if PlanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PlanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PlanRequest input)
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
                    this.Interval.Equals(input.Interval)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TrialPeriodDays == input.TrialPeriodDays ||
                    this.TrialPeriodDays.Equals(input.TrialPeriodDays)
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
                hashCode = (hashCode * 59) + this.Frequency.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TrialPeriodDays.GetHashCode();
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

            // Frequency (int) minimum
            if (this.Frequency < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Frequency, must be a value greater than or equal to 1.", new [] { "Frequency" });
            }

            yield break;
        }
    }

}
