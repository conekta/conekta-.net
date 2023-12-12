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
    /// BlacklistRuleResponse
    /// </summary>
    [DataContract(Name = "blacklist_rule_response")]
    public partial class BlacklistRuleResponse : IEquatable<BlacklistRuleResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlacklistRuleResponse" /> class.
        /// </summary>
        /// <param name="id">Blacklist rule id.</param>
        /// <param name="field">field used for blacklists rule.</param>
        /// <param name="value">value used for blacklists rule.</param>
        /// <param name="description">use an description for blacklisted rule.</param>
        public BlacklistRuleResponse(string id = default(string), string field = default(string), string value = default(string), string description = default(string))
        {
            this.Id = id;
            this.Field = field;
            this.Value = value;
            this.Description = description;
        }

        /// <summary>
        /// Blacklist rule id
        /// </summary>
        /// <value>Blacklist rule id</value>
        /// <example>2fw8EWJusiRrxdPzT</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// field used for blacklists rule
        /// </summary>
        /// <value>field used for blacklists rule</value>
        /// <example>email</example>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// value used for blacklists rule
        /// </summary>
        /// <value>value used for blacklists rule</value>
        /// <example>email@example.com</example>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// use an description for blacklisted rule
        /// </summary>
        /// <value>use an description for blacklisted rule</value>
        /// <example>secure customer example@example.com</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BlacklistRuleResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as BlacklistRuleResponse);
        }

        /// <summary>
        /// Returns true if BlacklistRuleResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BlacklistRuleResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlacklistRuleResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
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
