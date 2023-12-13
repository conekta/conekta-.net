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
    /// TokenCheckout
    /// </summary>
    [DataContract(Name = "token_checkout")]
    public partial class TokenCheckout : IEquatable<TokenCheckout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCheckout" /> class.
        /// </summary>
        /// <param name="returnsControlOn">It is a value that allows identifying the returns control on..</param>
        public TokenCheckout(string returnsControlOn = default(string))
        {
            this.ReturnsControlOn = returnsControlOn;
        }

        /// <summary>
        /// It is a value that allows identifying the returns control on.
        /// </summary>
        /// <value>It is a value that allows identifying the returns control on.</value>
        /// <example>Token</example>
        [DataMember(Name = "returns_control_on", EmitDefaultValue = false)]
        public string ReturnsControlOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenCheckout {\n");
            sb.Append("  ReturnsControlOn: ").Append(ReturnsControlOn).Append("\n");
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
            return this.Equals(input as TokenCheckout);
        }

        /// <summary>
        /// Returns true if TokenCheckout instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenCheckout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenCheckout input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReturnsControlOn == input.ReturnsControlOn ||
                    (this.ReturnsControlOn != null &&
                    this.ReturnsControlOn.Equals(input.ReturnsControlOn))
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
                if (this.ReturnsControlOn != null)
                {
                    hashCode = (hashCode * 59) + this.ReturnsControlOn.GetHashCode();
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
