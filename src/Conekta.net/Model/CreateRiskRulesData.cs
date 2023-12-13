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
    /// CreateRiskRulesData
    /// </summary>
    [DataContract(Name = "create_risk_rules_data")]
    public partial class CreateRiskRulesData : IEquatable<CreateRiskRulesData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRiskRulesData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateRiskRulesData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRiskRulesData" /> class.
        /// </summary>
        /// <param name="description">Description of the rule (required).</param>
        /// <param name="field">Field to be used for the rule (required).</param>
        /// <param name="value">Value to be used for the rule (required).</param>
        public CreateRiskRulesData(string description = default(string), string field = default(string), string value = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for CreateRiskRulesData and cannot be null");
            }
            this.Description = description;
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for CreateRiskRulesData and cannot be null");
            }
            this.Field = field;
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for CreateRiskRulesData and cannot be null");
            }
            this.Value = value;
        }

        /// <summary>
        /// Description of the rule
        /// </summary>
        /// <value>Description of the rule</value>
        /// <example>this client email was verified at 20/09/22 by internal process</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Field to be used for the rule
        /// </summary>
        /// <value>Field to be used for the rule</value>
        /// <example>email | phone | card_token</example>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public string Field { get; set; }

        /// <summary>
        /// Value to be used for the rule
        /// </summary>
        /// <value>Value to be used for the rule</value>
        /// <example>email@example.com | 818081808180 | src_2qUCNd5AyQqfPMBuV</example>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateRiskRulesData {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as CreateRiskRulesData);
        }

        /// <summary>
        /// Returns true if CreateRiskRulesData instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateRiskRulesData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateRiskRulesData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
