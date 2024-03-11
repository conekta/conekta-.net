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
    /// token response
    /// </summary>
    [DataContract(Name = "token_response")]
    public partial class TokenResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponse" /> class.
        /// </summary>
        /// <param name="checkout">checkout.</param>
        /// <param name="id">Unique identifier for the token generated by Conekta. (required).</param>
        /// <param name="livemode">Indicates whether the token is in live mode or test mode. (required).</param>
        /// <param name="varObject">Indicates the type of object, in this case token (required).</param>
        /// <param name="used">Indicates if the token has been used (required).</param>
        public TokenResponse(TokenResponseCheckout checkout = default(TokenResponseCheckout), string id = default(string), bool livemode = default(bool), string varObject = default(string), bool used = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TokenResponse and cannot be null");
            }
            this.Id = id;
            this.Livemode = livemode;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for TokenResponse and cannot be null");
            }
            this.VarObject = varObject;
            this.Used = used;
            this.Checkout = checkout;
        }

        /// <summary>
        /// Gets or Sets Checkout
        /// </summary>
        [DataMember(Name = "checkout", EmitDefaultValue = true)]
        [Obsolete]
        public TokenResponseCheckout Checkout { get; set; }

        /// <summary>
        /// Unique identifier for the token generated by Conekta.
        /// </summary>
        /// <value>Unique identifier for the token generated by Conekta.</value>
        /// <example>cus_2tHJfJ79KyUwpxTik</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Indicates whether the token is in live mode or test mode.
        /// </summary>
        /// <value>Indicates whether the token is in live mode or test mode.</value>
        /// <example>true</example>
        [DataMember(Name = "livemode", IsRequired = true, EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Indicates the type of object, in this case token
        /// </summary>
        /// <value>Indicates the type of object, in this case token</value>
        /// <example>token</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// Indicates if the token has been used
        /// </summary>
        /// <value>Indicates if the token has been used</value>
        /// <example>false</example>
        [DataMember(Name = "used", IsRequired = true, EmitDefaultValue = true)]
        public bool Used { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenResponse {\n");
            sb.Append("  Checkout: ").Append(Checkout).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  Used: ").Append(Used).Append("\n");
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
            yield break;
        }
    }

}
