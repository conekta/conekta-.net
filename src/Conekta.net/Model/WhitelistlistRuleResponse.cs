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
    /// WhitelistlistRuleResponse
    /// </summary>
    [DataContract(Name = "whitelistlist_rule_response")]
    public partial class WhitelistlistRuleResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WhitelistlistRuleResponse" /> class.
        /// </summary>
        /// <param name="id">Whitelist rule id.</param>
        /// <param name="field">field used for whitelists rule.</param>
        /// <param name="value">value used for whitelists rule.</param>
        /// <param name="description">use an description for whitelisted rule.</param>
        public WhitelistlistRuleResponse(string id = default(string), string field = default(string), string value = default(string), string description = default(string))
        {
            this.Id = id;
            this.Field = field;
            this.Value = value;
            this.Description = description;
        }

        /// <summary>
        /// Whitelist rule id
        /// </summary>
        /// <value>Whitelist rule id</value>
        /*
        <example>2fw8EWJusiRrxdPzT</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// field used for whitelists rule
        /// </summary>
        /// <value>field used for whitelists rule</value>
        /*
        <example>email</example>
        */
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// value used for whitelists rule
        /// </summary>
        /// <value>value used for whitelists rule</value>
        /*
        <example>email@example.com</example>
        */
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// use an description for whitelisted rule
        /// </summary>
        /// <value>use an description for whitelisted rule</value>
        /*
        <example>banned customer example@example.com</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WhitelistlistRuleResponse {\n");
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
