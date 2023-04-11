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
    /// WebhookLog
    /// </summary>
    [DataContract(Name = "WebhookLog")]
    public partial class WebhookLog : IEquatable<WebhookLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLog" /> class.
        /// </summary>
        /// <param name="failedAttempts">failedAttempts.</param>
        /// <param name="id">id.</param>
        /// <param name="lastAttemptedAt">lastAttemptedAt.</param>
        /// <param name="lastHttpResponseStatus">lastHttpResponseStatus.</param>
        /// <param name="_object">_object.</param>
        /// <param name="responseData">responseData.</param>
        /// <param name="url">url.</param>
        public WebhookLog(int failedAttempts = default(int), string id = default(string), int lastAttemptedAt = default(int), int lastHttpResponseStatus = default(int), string _object = default(string), Dictionary<string, Object> responseData = default(Dictionary<string, Object>), string url = default(string))
        {
            this.FailedAttempts = failedAttempts;
            this.Id = id;
            this.LastAttemptedAt = lastAttemptedAt;
            this.LastHttpResponseStatus = lastHttpResponseStatus;
            this.Object = _object;
            this.ResponseData = responseData;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets FailedAttempts
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "failed_attempts", EmitDefaultValue = false)]
        public int FailedAttempts { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>&quot;webhl_2svd2sh6GbqzyWBNZ&quot;</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastAttemptedAt
        /// </summary>
        /// <example>1669651274</example>
        [DataMember(Name = "last_attempted_at", EmitDefaultValue = false)]
        public int LastAttemptedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastHttpResponseStatus
        /// </summary>
        /// <example>200</example>
        [DataMember(Name = "last_http_response_status", EmitDefaultValue = false)]
        public int LastHttpResponseStatus { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>&quot;webhook_log&quot;</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets ResponseData
        /// </summary>
        [DataMember(Name = "response_data", EmitDefaultValue = false)]
        public Dictionary<string, Object> ResponseData { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        /// <example>&quot;https://username:password@mockoon.stg.conekta.io/payments-api/cash/merchant_approval&quot;</example>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookLog {\n");
            sb.Append("  FailedAttempts: ").Append(FailedAttempts).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastAttemptedAt: ").Append(LastAttemptedAt).Append("\n");
            sb.Append("  LastHttpResponseStatus: ").Append(LastHttpResponseStatus).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ResponseData: ").Append(ResponseData).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as WebhookLog);
        }

        /// <summary>
        /// Returns true if WebhookLog instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookLog input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailedAttempts == input.FailedAttempts ||
                    this.FailedAttempts.Equals(input.FailedAttempts)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastAttemptedAt == input.LastAttemptedAt ||
                    this.LastAttemptedAt.Equals(input.LastAttemptedAt)
                ) && 
                (
                    this.LastHttpResponseStatus == input.LastHttpResponseStatus ||
                    this.LastHttpResponseStatus.Equals(input.LastHttpResponseStatus)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.ResponseData == input.ResponseData ||
                    this.ResponseData != null &&
                    input.ResponseData != null &&
                    this.ResponseData.SequenceEqual(input.ResponseData)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                hashCode = (hashCode * 59) + this.FailedAttempts.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastAttemptedAt.GetHashCode();
                hashCode = (hashCode * 59) + this.LastHttpResponseStatus.GetHashCode();
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.ResponseData != null)
                {
                    hashCode = (hashCode * 59) + this.ResponseData.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
