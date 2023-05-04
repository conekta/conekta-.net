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
    /// logs model
    /// </summary>
    [DataContract(Name = "logs_response")]
    public partial class LogsResponse : IEquatable<LogsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogsResponse" /> class.
        /// </summary>
        /// <param name="nextPageUrl">URL of the next page..</param>
        /// <param name="previousPageUrl">Url of the previous page..</param>
        /// <param name="data">set to page results..</param>
        public LogsResponse(string nextPageUrl = default(string), string previousPageUrl = default(string), List<LogsResponseData> data = default(List<LogsResponseData>))
        {
            this.NextPageUrl = nextPageUrl;
            this.PreviousPageUrl = previousPageUrl;
            this.Data = data;
        }

        /// <summary>
        /// True, if there are more pages.
        /// </summary>
        /// <value>True, if there are more pages.</value>
        [DataMember(Name = "has_more", EmitDefaultValue = true)]
        public bool HasMore { get; private set; }

        /// <summary>
        /// Returns false as HasMore should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasMore()
        {
            return false;
        }
        /// <summary>
        /// The object type
        /// </summary>
        /// <value>The object type</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; private set; }

        /// <summary>
        /// Returns false as Object should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeObject()
        {
            return false;
        }
        /// <summary>
        /// URL of the next page.
        /// </summary>
        /// <value>URL of the next page.</value>
        [DataMember(Name = "next_page_url", EmitDefaultValue = true)]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Url of the previous page.
        /// </summary>
        /// <value>Url of the previous page.</value>
        [DataMember(Name = "previous_page_url", EmitDefaultValue = true)]
        public string PreviousPageUrl { get; set; }

        /// <summary>
        /// set to page results.
        /// </summary>
        /// <value>set to page results.</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public List<LogsResponseData> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogsResponse {\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as LogsResponse);
        }

        /// <summary>
        /// Returns true if LogsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LogsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HasMore == input.HasMore ||
                    this.HasMore.Equals(input.HasMore)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                hashCode = (hashCode * 59) + this.HasMore.GetHashCode();
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
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
