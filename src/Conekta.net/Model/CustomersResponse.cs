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
    /// CustomersResponse
    /// </summary>
    [DataContract(Name = "customers_response")]
    public partial class CustomersResponse : IEquatable<CustomersResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomersResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersResponse" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="hasMore">Indicates if there are more pages to be requested (required).</param>
        /// <param name="varObject">Object type, in this case is list (required).</param>
        /// <param name="nextPageUrl">URL of the next page..</param>
        /// <param name="previousPageUrl">Url of the previous page..</param>
        public CustomersResponse(List<CustomerResponse> data = default(List<CustomerResponse>), bool hasMore = default(bool), string varObject = default(string), string nextPageUrl = default(string), string previousPageUrl = default(string))
        {
            this.HasMore = hasMore;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for CustomersResponse and cannot be null");
            }
            this.VarObject = varObject;
            this.Data = data;
            this.NextPageUrl = nextPageUrl;
            this.PreviousPageUrl = previousPageUrl;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<CustomerResponse> Data { get; set; }

        /// <summary>
        /// Indicates if there are more pages to be requested
        /// </summary>
        /// <value>Indicates if there are more pages to be requested</value>
        /// <example>false</example>
        [DataMember(Name = "has_more", IsRequired = true, EmitDefaultValue = true)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Object type, in this case is list
        /// </summary>
        /// <value>Object type, in this case is list</value>
        /// <example>list</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// URL of the next page.
        /// </summary>
        /// <value>URL of the next page.</value>
        /// <example>https://api.conekta.io/resources?limit&#x3D;10&amp;next&#x3D;chrg_1</example>
        [DataMember(Name = "next_page_url", EmitDefaultValue = true)]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Url of the previous page.
        /// </summary>
        /// <value>Url of the previous page.</value>
        /// <example>https://api.conekta.io/resources?limit&#x3D;10&amp;previous&#x3D;chrg_1</example>
        [DataMember(Name = "previous_page_url", EmitDefaultValue = true)]
        public string PreviousPageUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomersResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  NextPageUrl: ").Append(NextPageUrl).Append("\n");
            sb.Append("  PreviousPageUrl: ").Append(PreviousPageUrl).Append("\n");
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
            return this.Equals(input as CustomersResponse);
        }

        /// <summary>
        /// Returns true if CustomersResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomersResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    this.HasMore.Equals(input.HasMore)
                ) && 
                (
                    this.VarObject == input.VarObject ||
                    (this.VarObject != null &&
                    this.VarObject.Equals(input.VarObject))
                ) && 
                (
                    this.NextPageUrl == input.NextPageUrl ||
                    (this.NextPageUrl != null &&
                    this.NextPageUrl.Equals(input.NextPageUrl))
                ) && 
                (
                    this.PreviousPageUrl == input.PreviousPageUrl ||
                    (this.PreviousPageUrl != null &&
                    this.PreviousPageUrl.Equals(input.PreviousPageUrl))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasMore.GetHashCode();
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                if (this.NextPageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NextPageUrl.GetHashCode();
                }
                if (this.PreviousPageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousPageUrl.GetHashCode();
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
