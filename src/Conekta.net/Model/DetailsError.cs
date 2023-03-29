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
    /// DetailsError
    /// </summary>
    [DataContract(Name = "details_error")]
    public partial class DetailsError : IEquatable<DetailsError>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsError" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="param">param.</param>
        /// <param name="message">message.</param>
        /// <param name="debugMessage">debugMessage.</param>
        public DetailsError(string code = default(string), string param = default(string), string message = default(string), string debugMessage = default(string))
        {
            this.Code = code;
            this.Param = param;
            this.Message = message;
            this.DebugMessage = debugMessage;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Param
        /// </summary>
        [DataMember(Name = "param", EmitDefaultValue = true)]
        public string Param { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets DebugMessage
        /// </summary>
        [DataMember(Name = "debug_message", EmitDefaultValue = false)]
        public string DebugMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetailsError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Param: ").Append(Param).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  DebugMessage: ").Append(DebugMessage).Append("\n");
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
            return this.Equals(input as DetailsError);
        }

        /// <summary>
        /// Returns true if DetailsError instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailsError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailsError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Param == input.Param ||
                    (this.Param != null &&
                    this.Param.Equals(input.Param))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.DebugMessage == input.DebugMessage ||
                    (this.DebugMessage != null &&
                    this.DebugMessage.Equals(input.DebugMessage))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Param != null)
                {
                    hashCode = (hashCode * 59) + this.Param.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.DebugMessage != null)
                {
                    hashCode = (hashCode * 59) + this.DebugMessage.GetHashCode();
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