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
    [DataContract(Name = "webhook-key_create_response")]
    public partial class WebhookKeyCreateResponse : IEquatable<WebhookKeyCreateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookKeyCreateResponse" /> class.
        /// </summary>
        /// <param name="active">Indicates if the webhook key is active.</param>
        /// <param name="createdAt">Unix timestamp in seconds with the creation date of the webhook key.</param>
        /// <param name="id">Unique identifier of the webhook key.</param>
        /// <param name="livemode">Indicates if the webhook key is in live mode.</param>
        /// <param name="_object">Object name, value is webhook_key.</param>
        /// <param name="publicKey">Public key to be used in the webhook.</param>
        public WebhookKeyCreateResponse(bool active = default(bool), long createdAt = default(long), string id = default(string), bool livemode = default(bool), string _object = default(string), string publicKey = default(string))
        {
            this.Active = active;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Livemode = livemode;
            this.Object = _object;
            this.PublicKey = publicKey;
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
        /// Public key to be used in the webhook
        /// </summary>
        /// <value>Public key to be used in the webhook</value>
        /// <example>&quot;-----BEGIN PUBLIC KEY-----\nMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAqULpUc6D6mSAq5a0yLY/\noOjd1mWm6q+QI8y/FI4STr2F+XgKeNnMxSqnyFrHtKQ/ut4Zi45WFnJLfEQL7aW5\n67yE2dWyo6GaL7yZUfLC0Y3sHPGzaGtvDF36ISW7LliYNoMiA3Bx5/1Sr0G23pGW\n0Mp8IO1Nlz0sJWuU/d7zCz/UN6cl9g/BP4eaQ7deS56YuWcj5sTlwqFTlwN12kpA\nIzMZ7gnvYQnZTpPny5lben6QEuxTvZcPApcyOweiESjMnXfkfWOyuYtgMrbsU6oL\nA6sWa6j0pePW7AYeBqB4tyAlenkCSqzHg8bMk5Bm7hiT6I9Pls774lJbnOYmmuNE\n8QIDAQAB\n-----END PUBLIC KEY-----\n&quot;</example>
        [DataMember(Name = "public_key", EmitDefaultValue = false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookKeyCreateResponse {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
            return this.Equals(input as WebhookKeyCreateResponse);
        }

        /// <summary>
        /// Returns true if WebhookKeyCreateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookKeyCreateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookKeyCreateResponse input)
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
                ) && 
                (
                    this.PublicKey == input.PublicKey ||
                    (this.PublicKey != null &&
                    this.PublicKey.Equals(input.PublicKey))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Livemode.GetHashCode();
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.PublicKey != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKey.GetHashCode();
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
