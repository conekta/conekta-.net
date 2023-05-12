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
    /// The charges to be made
    /// </summary>
    [DataContract(Name = "charge_request")]
    public partial class ChargeRequest : IEquatable<ChargeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChargeRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeRequest" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="monthlyInstallments">How many months without interest to apply, it can be 3, 6, 9, 12 or 18.</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="referenceId">Custom reference to add to the charge.</param>
        public ChargeRequest(int amount = default(int), int monthlyInstallments = default(int), ChargeRequestPaymentMethod paymentMethod = default(ChargeRequestPaymentMethod), string referenceId = default(string))
        {
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new ArgumentNullException("paymentMethod is a required property for ChargeRequest and cannot be null");
            }
            this.PaymentMethod = paymentMethod;
            this.Amount = amount;
            this.MonthlyInstallments = monthlyInstallments;
            this.ReferenceId = referenceId;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>40000</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// How many months without interest to apply, it can be 3, 6, 9, 12 or 18
        /// </summary>
        /// <value>How many months without interest to apply, it can be 3, 6, 9, 12 or 18</value>
        [DataMember(Name = "monthly_installments", EmitDefaultValue = false)]
        public int MonthlyInstallments { get; set; }

        /// <summary>
        /// Gets or Sets PaymentMethod
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true, EmitDefaultValue = true)]
        public ChargeRequestPaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Custom reference to add to the charge
        /// </summary>
        /// <value>Custom reference to add to the charge</value>
        [DataMember(Name = "reference_id", EmitDefaultValue = false)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  MonthlyInstallments: ").Append(MonthlyInstallments).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
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
            return this.Equals(input as ChargeRequest);
        }

        /// <summary>
        /// Returns true if ChargeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeRequest input)
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
                    this.MonthlyInstallments == input.MonthlyInstallments ||
                    this.MonthlyInstallments.Equals(input.MonthlyInstallments)
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
                hashCode = (hashCode * 59) + this.MonthlyInstallments.GetHashCode();
                if (this.PaymentMethod != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentMethod.GetHashCode();
                }
                if (this.ReferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ReferenceId.GetHashCode();
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
            yield break;
        }
    }

}
