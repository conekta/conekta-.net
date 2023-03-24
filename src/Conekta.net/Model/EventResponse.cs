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
    /// event model
    /// </summary>
    [DataContract(Name = "event_response")]
    public partial class EventResponse : IEquatable<EventResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventResponse" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="data">data.</param>
        /// <param name="id">id.</param>
        /// <param name="livemode">livemode.</param>
        /// <param name="_object">_object.</param>
        /// <param name="type">type.</param>
        /// <param name="webhookLogs">webhookLogs.</param>
        /// <param name="webhookStatus">webhookStatus.</param>
        public EventResponse(long createdAt = default(long), Dictionary<string, Object> data = default(Dictionary<string, Object>), string id = default(string), bool livemode = default(bool), string _object = default(string), string type = default(string), List<WebhookLog> webhookLogs = default(List<WebhookLog>), string webhookStatus = default(string))
        {
            this.CreatedAt = createdAt;
            this.Data = data;
            this.Id = id;
            this.Livemode = livemode;
            this.Object = _object;
            this.Type = type;
            this.WebhookLogs = webhookLogs;
            this.WebhookStatus = webhookStatus;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public Dictionary<string, Object> Data { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets WebhookLogs
        /// </summary>
        [DataMember(Name = "webhook_logs", EmitDefaultValue = false)]
        public List<WebhookLog> WebhookLogs { get; set; }

        /// <summary>
        /// Gets or Sets WebhookStatus
        /// </summary>
        [DataMember(Name = "webhook_status", EmitDefaultValue = false)]
        public string WebhookStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventResponse {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WebhookLogs: ").Append(WebhookLogs).Append("\n");
            sb.Append("  WebhookStatus: ").Append(WebhookStatus).Append("\n");
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
            return this.Equals(input as EventResponse);
        }

        /// <summary>
        /// Returns true if EventResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EventResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EventResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.WebhookLogs == input.WebhookLogs ||
                    this.WebhookLogs != null &&
                    input.WebhookLogs != null &&
                    this.WebhookLogs.SequenceEqual(input.WebhookLogs)
                ) && 
                (
                    this.WebhookStatus == input.WebhookStatus ||
                    (this.WebhookStatus != null &&
                    this.WebhookStatus.Equals(input.WebhookStatus))
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
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.WebhookLogs != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookLogs.GetHashCode();
                }
                if (this.WebhookStatus != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookStatus.GetHashCode();
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
