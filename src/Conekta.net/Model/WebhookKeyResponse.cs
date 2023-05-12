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
    /// webhook keys model
    /// </summary>
    [DataContract(Name = "webhook-key_response")]
    public partial class WebhookKeyResponse : IEquatable<WebhookKeyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookKeyResponse" /> class.
        /// </summary>
        /// <param name="active">Indicates if the webhook key is active.</param>
        /// <param name="createdAt">Unix timestamp in seconds with the creation date of the webhook key.</param>
        /// <param name="deactivatedAt">Unix timestamp in seconds with the deactivation date of the webhook key.</param>
        /// <param name="id">Unique identifier of the webhook key.</param>
        /// <param name="livemode">Indicates if the webhook key is in live mode.</param>
        /// <param name="_object">Object name, value is webhook_key.</param>
        public WebhookKeyResponse(bool active = default(bool), long createdAt = default(long), long? deactivatedAt = default(long?), string id = default(string), bool livemode = default(bool), string _object = default(string))
        {
            this.Active = active;
            this.CreatedAt = createdAt;
            this.DeactivatedAt = deactivatedAt;
            this.Id = id;
            this.Livemode = livemode;
            this.Object = _object;
        }

        /// <summary>
        /// Indicates if the webhook key is active
        /// </summary>
        /// <value>Indicates if the webhook key is active</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Unix timestamp in seconds with the creation date of the webhook key
        /// </summary>
        /// <value>Unix timestamp in seconds with the creation date of the webhook key</value>
        /// <example>1577836800</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Unix timestamp in seconds with the deactivation date of the webhook key
        /// </summary>
        /// <value>Unix timestamp in seconds with the deactivation date of the webhook key</value>
        /// <example>1577836800</example>
        [DataMember(Name = "deactivated_at", EmitDefaultValue = true)]
        public long? DeactivatedAt { get; set; }

        /// <summary>
        /// Unique identifier of the webhook key
        /// </summary>
        /// <value>Unique identifier of the webhook key</value>
        /// <example>&quot;62730ba6fb7dfd6a712f118e&quot;</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Indicates if the webhook key is in live mode
        /// </summary>
        /// <value>Indicates if the webhook key is in live mode</value>
        /// <example>false</example>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Object name, value is webhook_key
        /// </summary>
        /// <value>Object name, value is webhook_key</value>
        /// <example>&quot;webhook_key&quot;</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookKeyResponse {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DeactivatedAt: ").Append(DeactivatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
            return this.Equals(input as WebhookKeyResponse);
        }

        /// <summary>
        /// Returns true if WebhookKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookKeyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.DeactivatedAt == input.DeactivatedAt ||
                    (this.DeactivatedAt != null &&
                    this.DeactivatedAt.Equals(input.DeactivatedAt))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Livemode == input.Livemode ||
                    this.Livemode.Equals(input.Livemode)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.DeactivatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.DeactivatedAt.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Livemode.GetHashCode();
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
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
