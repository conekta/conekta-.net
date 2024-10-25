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
    /// create new taxes for an existing order response
    /// </summary>
    [DataContract(Name = "update_order_tax_response")]
    public partial class UpdateOrderTaxResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderTaxResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateOrderTaxResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderTaxResponse" /> class.
        /// </summary>
        /// <param name="amount">The amount to be collected for tax in cents (required).</param>
        /// <param name="description">description or tax&#39;s name (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="id">id (required).</param>
        /// <param name="varObject">varObject.</param>
        /// <param name="parentId">parentId.</param>
        public UpdateOrderTaxResponse(long amount = default(long), string description = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string id = default(string), string varObject = default(string), string parentId = default(string))
        {
            this.Amount = amount;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for UpdateOrderTaxResponse and cannot be null");
            }
            this.Description = description;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for UpdateOrderTaxResponse and cannot be null");
            }
            this.Id = id;
            this.Metadata = metadata;
            this.Object = varObject;
            this.ParentId = parentId;
        }

        /// <summary>
        /// The amount to be collected for tax in cents
        /// </summary>
        /// <value>The amount to be collected for tax in cents</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// description or tax&#39;s name
        /// </summary>
        /// <value>description or tax&#39;s name</value>
        /*
        <example>testing</example>
        */
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        /*
        <example>{key&#x3D;value}</example>
        */
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>tax_lin_2tQ8dC5mg1UADmVPo</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /*
        <example>tax_line</example>
        */
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        /*
        <example>ord_2tPAmKCEJqh8RE6nY</example>
        */
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateOrderTaxResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
            // Amount (long) minimum
            if (this.Amount < (long)0)
            {
                yield return new ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.", new [] { "Amount" });
            }

            // Description (string) minLength
            if (this.Description != null && this.Description.Length < 2)
            {
                yield return new ValidationResult("Invalid value for Description, length must be greater than 2.", new [] { "Description" });
            }

            yield break;
        }
    }

}
