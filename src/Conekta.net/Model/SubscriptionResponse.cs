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
    /// subscription model
    /// </summary>
    [DataContract(Name = "subscription_response")]
    public partial class SubscriptionResponse : IEquatable<SubscriptionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionResponse" /> class.
        /// </summary>
        /// <param name="billingCycleStart">billingCycleStart.</param>
        /// <param name="billingCycleEnd">billingCycleEnd.</param>
        /// <param name="canceledAt">canceledAt.</param>
        /// <param name="cardId">cardId.</param>
        /// <param name="chargeId">chargeId.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="customerCustomReference">customerCustomReference.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="id">id.</param>
        /// <param name="lastBillingCycleOrderId">lastBillingCycleOrderId.</param>
        /// <param name="_object">_object.</param>
        /// <param name="pausedAt">pausedAt.</param>
        /// <param name="planId">planId.</param>
        /// <param name="status">status.</param>
        /// <param name="subscriptionStart">subscriptionStart.</param>
        /// <param name="trialStart">trialStart.</param>
        /// <param name="trialEnd">trialEnd.</param>
        public SubscriptionResponse(long? billingCycleStart = default(long?), long? billingCycleEnd = default(long?), long? canceledAt = default(long?), string cardId = default(string), string chargeId = default(string), long createdAt = default(long), string customerCustomReference = default(string), string customerId = default(string), string id = default(string), string lastBillingCycleOrderId = default(string), string _object = default(string), long? pausedAt = default(long?), string planId = default(string), string status = default(string), int subscriptionStart = default(int), long? trialStart = default(long?), long? trialEnd = default(long?))
        {
            this.BillingCycleStart = billingCycleStart;
            this.BillingCycleEnd = billingCycleEnd;
            this.CanceledAt = canceledAt;
            this.CardId = cardId;
            this.ChargeId = chargeId;
            this.CreatedAt = createdAt;
            this.CustomerCustomReference = customerCustomReference;
            this.CustomerId = customerId;
            this.Id = id;
            this.LastBillingCycleOrderId = lastBillingCycleOrderId;
            this.Object = _object;
            this.PausedAt = pausedAt;
            this.PlanId = planId;
            this.Status = status;
            this.SubscriptionStart = subscriptionStart;
            this.TrialStart = trialStart;
            this.TrialEnd = trialEnd;
        }

        /// <summary>
        /// Gets or Sets BillingCycleStart
        /// </summary>
        [DataMember(Name = "billing_cycle_start", EmitDefaultValue = true)]
        public long? BillingCycleStart { get; set; }

        /// <summary>
        /// Gets or Sets BillingCycleEnd
        /// </summary>
        [DataMember(Name = "billing_cycle_end", EmitDefaultValue = true)]
        public long? BillingCycleEnd { get; set; }

        /// <summary>
        /// Gets or Sets CanceledAt
        /// </summary>
        [DataMember(Name = "canceled_at", EmitDefaultValue = true)]
        public long? CanceledAt { get; set; }

        /// <summary>
        /// Gets or Sets CardId
        /// </summary>
        [DataMember(Name = "card_id", EmitDefaultValue = false)]
        public string CardId { get; set; }

        /// <summary>
        /// Gets or Sets ChargeId
        /// </summary>
        [DataMember(Name = "charge_id", EmitDefaultValue = true)]
        public string ChargeId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CustomerCustomReference
        /// </summary>
        [DataMember(Name = "customer_custom_reference", EmitDefaultValue = false)]
        public string CustomerCustomReference { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastBillingCycleOrderId
        /// </summary>
        [DataMember(Name = "last_billing_cycle_order_id", EmitDefaultValue = false)]
        public string LastBillingCycleOrderId { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets PausedAt
        /// </summary>
        [DataMember(Name = "paused_at", EmitDefaultValue = true)]
        public long? PausedAt { get; set; }

        /// <summary>
        /// Gets or Sets PlanId
        /// </summary>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionStart
        /// </summary>
        [DataMember(Name = "subscription_start", EmitDefaultValue = false)]
        public int SubscriptionStart { get; set; }

        /// <summary>
        /// Gets or Sets TrialStart
        /// </summary>
        [DataMember(Name = "trial_start", EmitDefaultValue = true)]
        public long? TrialStart { get; set; }

        /// <summary>
        /// Gets or Sets TrialEnd
        /// </summary>
        [DataMember(Name = "trial_end", EmitDefaultValue = true)]
        public long? TrialEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionResponse {\n");
            sb.Append("  BillingCycleStart: ").Append(BillingCycleStart).Append("\n");
            sb.Append("  BillingCycleEnd: ").Append(BillingCycleEnd).Append("\n");
            sb.Append("  CanceledAt: ").Append(CanceledAt).Append("\n");
            sb.Append("  CardId: ").Append(CardId).Append("\n");
            sb.Append("  ChargeId: ").Append(ChargeId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustomerCustomReference: ").Append(CustomerCustomReference).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastBillingCycleOrderId: ").Append(LastBillingCycleOrderId).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  PausedAt: ").Append(PausedAt).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubscriptionStart: ").Append(SubscriptionStart).Append("\n");
            sb.Append("  TrialStart: ").Append(TrialStart).Append("\n");
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
            return this.Equals(input as SubscriptionResponse);
        }

        /// <summary>
        /// Returns true if SubscriptionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillingCycleStart == input.BillingCycleStart ||
                    (this.BillingCycleStart != null &&
                    this.BillingCycleStart.Equals(input.BillingCycleStart))
                ) && 
                (
                    this.BillingCycleEnd == input.BillingCycleEnd ||
                    (this.BillingCycleEnd != null &&
                    this.BillingCycleEnd.Equals(input.BillingCycleEnd))
                ) && 
                (
                    this.CanceledAt == input.CanceledAt ||
                    (this.CanceledAt != null &&
                    this.CanceledAt.Equals(input.CanceledAt))
                ) && 
                (
                    this.CardId == input.CardId ||
                    (this.CardId != null &&
                    this.CardId.Equals(input.CardId))
                ) && 
                (
                    this.ChargeId == input.ChargeId ||
                    (this.ChargeId != null &&
                    this.ChargeId.Equals(input.ChargeId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.CustomerCustomReference == input.CustomerCustomReference ||
                    (this.CustomerCustomReference != null &&
                    this.CustomerCustomReference.Equals(input.CustomerCustomReference))
                ) && 
                (
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastBillingCycleOrderId == input.LastBillingCycleOrderId ||
                    (this.LastBillingCycleOrderId != null &&
                    this.LastBillingCycleOrderId.Equals(input.LastBillingCycleOrderId))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.PausedAt == input.PausedAt ||
                    (this.PausedAt != null &&
                    this.PausedAt.Equals(input.PausedAt))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubscriptionStart == input.SubscriptionStart ||
                    this.SubscriptionStart.Equals(input.SubscriptionStart)
                ) && 
                (
                    this.TrialStart == input.TrialStart ||
                    (this.TrialStart != null &&
                    this.TrialStart.Equals(input.TrialStart))
                ) && 
                (
                    this.TrialEnd == input.TrialEnd ||
                    (this.TrialEnd != null &&
                    this.TrialEnd.Equals(input.TrialEnd))
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
                if (this.BillingCycleStart != null)
                {
                    hashCode = (hashCode * 59) + this.BillingCycleStart.GetHashCode();
                }
                if (this.BillingCycleEnd != null)
                {
                    hashCode = (hashCode * 59) + this.BillingCycleEnd.GetHashCode();
                }
                if (this.CanceledAt != null)
                {
                    hashCode = (hashCode * 59) + this.CanceledAt.GetHashCode();
                }
                if (this.CardId != null)
                {
                    hashCode = (hashCode * 59) + this.CardId.GetHashCode();
                }
                if (this.ChargeId != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.CustomerCustomReference != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerCustomReference.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LastBillingCycleOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.LastBillingCycleOrderId.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.PausedAt != null)
                {
                    hashCode = (hashCode * 59) + this.PausedAt.GetHashCode();
                }
                if (this.PlanId != null)
                {
                    hashCode = (hashCode * 59) + this.PlanId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SubscriptionStart.GetHashCode();
                if (this.TrialStart != null)
                {
                    hashCode = (hashCode * 59) + this.TrialStart.GetHashCode();
                }
                if (this.TrialEnd != null)
                {
                    hashCode = (hashCode * 59) + this.TrialEnd.GetHashCode();
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
            yield break;
        }
    }

}
