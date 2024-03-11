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
    /// List of discounts that apply to the order.
    /// </summary>
    [DataContract(Name = "update_order_discount_lines_request")]
    public partial class UpdateOrderDiscountLinesRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderDiscountLinesRequest" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="code">Discount code..</param>
        /// <param name="type">type.</param>
        public UpdateOrderDiscountLinesRequest(long amount = default(long), string code = default(string), string type = default(string))
        {
            this.Amount = amount;
            this.Code = code;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>500</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public long Amount { get; set; }

        /// <summary>
        /// Discount code.
        /// </summary>
        /// <value>Discount code.</value>
        /// <example>123</example>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>loyalty</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateOrderDiscountLinesRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Amount (long) minimum
            if (this.Amount < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
