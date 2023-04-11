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
    /// OrderRefundRequest
    /// </summary>
    [DataContract(Name = "orderRefund_request")]
    public partial class OrderRefundRequest : IEquatable<OrderRefundRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRefundRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderRefundRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRefundRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="reason">reason (required).</param>
        public OrderRefundRequest(int amount = default(int), string reason = default(string))
        {
            this.Amount = amount;
            // to ensure "reason" is required (not null)
            if (reason == null)
            {
                throw new ArgumentNullException("reason is a required property for OrderRefundRequest and cannot be null");
            }
            this.Reason = reason;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>500</example>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public int Amount { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        /// <example>&quot;suspected_fraud&quot;</example>
        [DataMember(Name = "reason", IsRequired = true, EmitDefaultValue = true)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderRefundRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as OrderRefundRequest);
        }

        /// <summary>
        /// Returns true if OrderRefundRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderRefundRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderRefundRequest input)
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
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
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
