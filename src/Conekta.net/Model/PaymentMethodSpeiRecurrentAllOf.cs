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
    /// use for spei responses
    /// </summary>
    [DataContract(Name = "payment_method_spei_recurrent_allOf")]
    public partial class PaymentMethodSpeiRecurrentAllOf : IEquatable<PaymentMethodSpeiRecurrentAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodSpeiRecurrentAllOf" /> class.
        /// </summary>
        /// <param name="reference">reference.</param>
        /// <param name="expiresAt">expiresAt.</param>
        public PaymentMethodSpeiRecurrentAllOf(string reference = default(string), string expiresAt = default(string))
        {
            this.Reference = reference;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        /// <example>&quot;93000262276908&quot;</example>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        /// <example>&quot;none&quot;</example>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public string ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodSpeiRecurrentAllOf {\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
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
            return this.Equals(input as PaymentMethodSpeiRecurrentAllOf);
        }

        /// <summary>
        /// Returns true if PaymentMethodSpeiRecurrentAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodSpeiRecurrentAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodSpeiRecurrentAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
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
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
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
