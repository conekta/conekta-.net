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
    /// ChargeOrderResponse
    /// </summary>
    [DataContract(Name = "charge_order_response")]
    public partial class ChargeOrderResponse : IEquatable<ChargeOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeOrderResponse" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="channel">channel.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="currency">currency.</param>
        /// <param name="customerId">customerId.</param>
        /// <param name="description">description.</param>
        /// <param name="deviceFingerprint">deviceFingerprint.</param>
        /// <param name="failureCode">failureCode.</param>
        /// <param name="failureMessage">failureMessage.</param>
        /// <param name="fee">fee.</param>
        /// <param name="id">id.</param>
        /// <param name="livemode">livemode.</param>
        /// <param name="monthlyInstallments">monthlyInstallments.</param>
        /// <param name="_object">_object.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="paidAt">paidAt.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="referenceId">referenceId.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="status">status.</param>
        public ChargeOrderResponse(int amount = default(int), OrderResponseChannel channel = default(OrderResponseChannel), long createdAt = default(long), string currency = default(string), string customerId = default(string), string description = default(string), string deviceFingerprint = default(string), string failureCode = default(string), string failureMessage = default(string), int fee = default(int), string id = default(string), bool livemode = default(bool), int? monthlyInstallments = default(int?), string _object = default(string), string orderId = default(string), int? paidAt = default(int?), ChargeOrderResponsePaymentMethod paymentMethod = default(ChargeOrderResponsePaymentMethod), string referenceId = default(string), List<Object> refunds = default(List<Object>), string status = default(string))
        {
            this.Amount = amount;
            this.Channel = channel;
            this.CreatedAt = createdAt;
            this.Currency = currency;
            this.CustomerId = customerId;
            this.Description = description;
            this.DeviceFingerprint = deviceFingerprint;
            this.FailureCode = failureCode;
            this.FailureMessage = failureMessage;
            this.Fee = fee;
            this.Id = id;
            this.Livemode = livemode;
            this.MonthlyInstallments = monthlyInstallments;
            this.Object = _object;
            this.OrderId = orderId;
            this.PaidAt = paidAt;
            this.PaymentMethod = paymentMethod;
            this.ReferenceId = referenceId;
            this.Refunds = refunds;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or Sets Channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public OrderResponseChannel Channel { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DeviceFingerprint
        /// </summary>
        [DataMember(Name = "device_fingerprint", EmitDefaultValue = true)]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// Gets or Sets FailureCode
        /// </summary>
        [DataMember(Name = "failure_code", EmitDefaultValue = false)]
        public string FailureCode { get; set; }

        /// <summary>
        /// Gets or Sets FailureMessage
        /// </summary>
        [DataMember(Name = "failure_message", EmitDefaultValue = false)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Gets or Sets Fee
        /// </summary>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public int Fee { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyInstallments
        /// </summary>
        [DataMember(Name = "monthly_installments", EmitDefaultValue = true)]
        public int? MonthlyInstallments { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or Sets PaidAt
        /// </summary>
        [DataMember(Name = "paid_at", EmitDefaultValue = true)]
        public int? PaidAt { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public ChargeOrderResponsePaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceId
        /// </summary>
        [DataMember(Name = "reference_id", EmitDefaultValue = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Gets or Sets Refunds
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        public List<Object> Refunds { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeOrderResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DeviceFingerprint: ").Append(DeviceFingerprint).Append("\n");
            sb.Append("  FailureCode: ").Append(FailureCode).Append("\n");
            sb.Append("  FailureMessage: ").Append(FailureMessage).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  MonthlyInstallments: ").Append(MonthlyInstallments).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  PaidAt: ").Append(PaidAt).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Refunds: ").Append(Refunds).Append("\n");
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
            return this.Equals(input as ChargeOrderResponse);
        }

        /// <summary>
        /// Returns true if ChargeOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeOrderResponse input)
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
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
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
                    this.CustomerId == input.CustomerId ||
                    (this.CustomerId != null &&
                    this.CustomerId.Equals(input.CustomerId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.DeviceFingerprint == input.DeviceFingerprint ||
                    (this.DeviceFingerprint != null &&
                    this.DeviceFingerprint.Equals(input.DeviceFingerprint))
                ) && 
                (
                    this.FailureCode == input.FailureCode ||
                    (this.FailureCode != null &&
                    this.FailureCode.Equals(input.FailureCode))
                ) && 
                (
                    this.FailureMessage == input.FailureMessage ||
                    (this.FailureMessage != null &&
                    this.FailureMessage.Equals(input.FailureMessage))
                ) && 
                (
                    this.Fee == input.Fee ||
                    this.Fee.Equals(input.Fee)
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
                    this.MonthlyInstallments == input.MonthlyInstallments ||
                    (this.MonthlyInstallments != null &&
                    this.MonthlyInstallments.Equals(input.MonthlyInstallments))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.PaidAt == input.PaidAt ||
                    (this.PaidAt != null &&
                    this.PaidAt.Equals(input.PaidAt))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    (this.ReferenceId != null &&
                    this.ReferenceId.Equals(input.ReferenceId))
                ) && 
                (
                    this.Refunds == input.Refunds ||
                    this.Refunds != null &&
                    input.Refunds != null &&
                    this.Refunds.SequenceEqual(input.Refunds)
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
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.CustomerId != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.DeviceFingerprint != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceFingerprint.GetHashCode();
                }
                if (this.FailureCode != null)
                {
                    hashCode = (hashCode * 59) + this.FailureCode.GetHashCode();
                }
                if (this.FailureMessage != null)
                {
                    hashCode = (hashCode * 59) + this.FailureMessage.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Livemode.GetHashCode();
                if (this.MonthlyInstallments != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyInstallments.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.PaidAt != null)
                {
                    hashCode = (hashCode * 59) + this.PaidAt.GetHashCode();
                }
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.ReferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceId.GetHashCode();
                }
                if (this.Refunds != null)
                {
                    hashCode = (hashCode * 59) + this.Refunds.GetHashCode();
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
            yield break;
        }
    }

}
