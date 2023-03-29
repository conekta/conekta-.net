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
    /// It is a parameter that allows to identify in the response, the detailed content of the plans to which the client has subscribed
    /// </summary>
    [DataContract(Name = "subscription_request")]
    public partial class SubscriptionRequest : IEquatable<SubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionRequest" /> class.
        /// </summary>
        /// <param name="planId">planId (required).</param>
        /// <param name="cardId">cardId.</param>
        /// <param name="trialEnd">trialEnd.</param>
        public SubscriptionRequest(string planId = default(string), string cardId = default(string), int trialEnd = default(int))
        {
            // to ensure "planId" is required (not null)
            if (planId == null)
            {
                throw new ArgumentNullException("planId is a required property for SubscriptionRequest and cannot be null");
            }
            this.PlanId = planId;
            this.CardId = cardId;
            this.TrialEnd = trialEnd;
        }

        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name = "plan_id", IsRequired = true, EmitDefaultValue = true)]
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or Sets CardId
        /// </summary>
        [DataMember(Name = "card_id", EmitDefaultValue = false)]
        public string CardId { get; set; }

        /// <summary>
        /// Gets or Sets TrialEnd
        /// </summary>
        [DataMember(Name = "trial_end", EmitDefaultValue = false)]
        public int TrialEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionRequest {\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  TrialEnd: ").Append(TrialEnd).Append("\n");
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
            return this.Equals(input as SubscriptionRequest);
        }

        /// <summary>
        /// Returns true if SubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
                ) && 
                (
                    this.TrialEnd == input.TrialEnd ||
                    this.TrialEnd.Equals(input.TrialEnd)
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
                if (this.PlanId != null)
                {
                    hashCode = (hashCode * 59) + this.PlanId.GetHashCode();
                }
                if (this.CardId != null)
                {
                    hashCode = (hashCode * 59) + this.CardId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TrialEnd.GetHashCode();
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
            yield break;
        }
    }

}