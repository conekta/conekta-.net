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
    /// customers response
    /// </summary>
    [DataContract(Name = "customers_extra_fields_response")]
    public partial class CustomersExtraFieldsResponse : IEquatable<CustomersExtraFieldsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersExtraFieldsResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomersExtraFieldsResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersExtraFieldsResponse" /> class.
        /// </summary>
        /// <param name="nextPageUrl">URL of the next page..</param>
        /// <param name="previousPageUrl">Url of the previous page..</param>
        /// <param name="data">data (required).</param>
        public CustomersExtraFieldsResponse(string nextPageUrl = default(string), string previousPageUrl = default(string), List<CustomersDataResponse> data = default(List<CustomersDataResponse>))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for CustomersExtraFieldsResponse and cannot be null");
            }
            this.Data = data;
            this.NextPageUrl = nextPageUrl;
            this.PreviousPageUrl = previousPageUrl;
        }

        /// <summary>
        /// URL of the next page.
        /// </summary>
        /// <value>URL of the next page.</value>
        /// <example>&quot;https://api.conekta.io/customers?next&#x3D;cus_2sagTU4GQR5e1i7A5&quot;</example>
        [DataMember(Name = "next_page_url", EmitDefaultValue = true)]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Url of the previous page.
        /// </summary>
        /// <value>Url of the previous page.</value>
        /// <example>&quot;https://api.conekta.io/customers?previous&#x3D;cus_2sagTU4GQR5e1i7A5&quot;</example>
        [DataMember(Name = "previous_page_url", EmitDefaultValue = true)]
        public string PreviousPageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public List<CustomersDataResponse> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomersExtraFieldsResponse {\n");
            sb.Append("  NextPageUrl: ").Append(NextPageUrl).Append("\n");
            sb.Append("  PreviousPageUrl: ").Append(PreviousPageUrl).Append("\n");
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
            return this.Equals(input as CustomersExtraFieldsResponse);
        }

        /// <summary>
        /// Returns true if CustomersExtraFieldsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomersExtraFieldsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomersExtraFieldsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NextPageUrl == input.NextPageUrl ||
                    (this.NextPageUrl != null &&
                    this.NextPageUrl.Equals(input.NextPageUrl))
                ) && 
                (
                    this.PreviousPageUrl == input.PreviousPageUrl ||
                    (this.PreviousPageUrl != null &&
                    this.PreviousPageUrl.Equals(input.PreviousPageUrl))
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
                if (this.NextPageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NextPageUrl.GetHashCode();
                }
                if (this.PreviousPageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousPageUrl.GetHashCode();
                }
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
