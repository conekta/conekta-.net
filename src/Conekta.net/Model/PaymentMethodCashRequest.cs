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
    /// PaymentMethodCashRequest
    /// </summary>
    [DataContract(Name = "payment_method_cash_request")]
    public partial class PaymentMethodCashRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCashRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodCashRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCashRequest" /> class.
        /// </summary>
        /// <param name="type">Type of payment method (required).</param>
        /// <param name="expiresAt">expiresAt.</param>
        public PaymentMethodCashRequest(string type = default(string), long expiresAt = default(long))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for PaymentMethodCashRequest and cannot be null");
            }
            this.Type = type;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Type of payment method
        /// </summary>
        /// <value>Type of payment method</value>
        /*
        <example>card | cash | spei</example>
        */
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        /*
        <example>1553273553</example>
        */
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodCashRequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
