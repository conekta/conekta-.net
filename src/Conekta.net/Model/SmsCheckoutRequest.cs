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
    /// SmsCheckoutRequest
    /// </summary>
    [DataContract(Name = "smsCheckout_request")]
    public partial class SmsCheckoutRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsCheckoutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsCheckoutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsCheckoutRequest" /> class.
        /// </summary>
        /// <param name="phonenumber">phonenumber (required).</param>
        public SmsCheckoutRequest(string phonenumber = default(string))
        {
            // to ensure "phonenumber" is required (not null)
            if (phonenumber == null)
            {
                throw new ArgumentNullException("phonenumber is a required property for SmsCheckoutRequest and cannot be null");
            }
            this.Phonenumber = phonenumber;
        }

        /// <summary>
        /// Gets or Sets Phonenumber
        /// </summary>
        /// <example>5566982090</example>
        [DataMember(Name = "phonenumber", IsRequired = true, EmitDefaultValue = true)]
        public string Phonenumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmsCheckoutRequest {\n");
            sb.Append("  Phonenumber: ").Append(Phonenumber).Append("\n");
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
