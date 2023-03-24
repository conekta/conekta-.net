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
    /// CustomerFiscalEntitiesResponse
    /// </summary>
    [DataContract(Name = "customer_fiscal_entities_response")]
    public partial class CustomerFiscalEntitiesResponse : IEquatable<CustomerFiscalEntitiesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFiscalEntitiesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerFiscalEntitiesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFiscalEntitiesResponse" /> class.
        /// </summary>
        /// <param name="_object">_object (required).</param>
        /// <param name="hasMore">hasMore (required).</param>
        /// <param name="data">data.</param>
        public CustomerFiscalEntitiesResponse(string _object = default(string), bool hasMore = default(bool), List<CustomerFiscalEntitiesDataResponse> data = default(List<CustomerFiscalEntitiesDataResponse>))
        {
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for CustomerFiscalEntitiesResponse and cannot be null");
            }
            this.Object = _object;
            this.HasMore = hasMore;
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets HasMore
        /// </summary>
        [DataMember(Name = "has_more", IsRequired = true, EmitDefaultValue = true)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<CustomerFiscalEntitiesDataResponse> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerFiscalEntitiesResponse {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as CustomerFiscalEntitiesResponse);
        }

        /// <summary>
        /// Returns true if CustomerFiscalEntitiesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerFiscalEntitiesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerFiscalEntitiesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    this.HasMore.Equals(input.HasMore)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasMore.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
