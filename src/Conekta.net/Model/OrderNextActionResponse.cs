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
    /// contains the following attributes that will guide to continue the flow
    /// </summary>
    [DataContract(Name = "order_next_action_response")]
    public partial class OrderNextActionResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderNextActionResponse" /> class.
        /// </summary>
        /// <param name="redirectToUrl">redirectToUrl.</param>
        /// <param name="type">Indicates the type of action to be taken.</param>
        public OrderNextActionResponse(OrderNextActionResponseRedirectToUrl redirectToUrl = default(OrderNextActionResponseRedirectToUrl), string type = default(string))
        {
            this.RedirectToUrl = redirectToUrl;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets RedirectToUrl
        /// </summary>
        [DataMember(Name = "redirect_to_url", EmitDefaultValue = false)]
        public OrderNextActionResponseRedirectToUrl RedirectToUrl { get; set; }

        /// <summary>
        /// Indicates the type of action to be taken
        /// </summary>
        /// <value>Indicates the type of action to be taken</value>
        /// <example>redirect_to_url</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderNextActionResponse {\n");
            sb.Append("  RedirectToUrl: ").Append(RedirectToUrl).Append("\n");
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
            yield break;
        }
    }

}
