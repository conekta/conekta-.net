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
    /// ErrorAllOf
    /// </summary>
    [DataContract(Name = "error_allOf")]
    public partial class ErrorAllOf : IEquatable<ErrorAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorAllOf" /> class.
        /// </summary>
        /// <param name="logId">log id.</param>
        /// <param name="type">type.</param>
        /// <param name="_object">_object.</param>
        public ErrorAllOf(string logId = default(string), string type = default(string), string _object = default(string))
        {
            this.LogId = logId;
            this.Type = type;
            this.Object = _object;
        }

        /// <summary>
        /// log id
        /// </summary>
        /// <value>log id</value>
        /// <example>&quot;507f1f77bcf86cd799439011&quot;</example>
        [DataMember(Name = "log_id", EmitDefaultValue = true)]
        public string LogId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>&quot;authentication_error&quot;</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>&quot;error&quot;</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ErrorAllOf {\n");
            sb.Append("  LogId: ").Append(LogId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as ErrorAllOf);
        }

        /// <summary>
        /// Returns true if ErrorAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogId == input.LogId ||
                    (this.LogId != null &&
                    this.LogId.Equals(input.LogId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.LogId != null)
                {
                    hashCode = (hashCode * 59) + this.LogId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
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
