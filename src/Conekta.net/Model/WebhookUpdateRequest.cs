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
    /// an updated webhook
    /// </summary>
    [DataContract(Name = "webhook_update_request")]
    public partial class WebhookUpdateRequest : IEquatable<WebhookUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookUpdateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookUpdateRequest" /> class.
        /// </summary>
        /// <param name="url">Here you must place the URL of your Webhook remember that you must program what you will do with the events received. Also do not forget to handle the HTTPS protocol for greater security. (required).</param>
        /// <param name="synchronous">It is a value that allows to decide if the events will be synchronous or asynchronous. We recommend asynchronous &#x3D; false (default to false).</param>
        /// <param name="subscribedEvents">subscribedEvents.</param>
        public WebhookUpdateRequest(string url = default(string), bool synchronous = false, List<string> subscribedEvents = default(List<string>))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for WebhookUpdateRequest and cannot be null");
            }
            this.Url = url;
            this.Synchronous = synchronous;
            this.SubscribedEvents = subscribedEvents;
        }

        /// <summary>
        /// Here you must place the URL of your Webhook remember that you must program what you will do with the events received. Also do not forget to handle the HTTPS protocol for greater security.
        /// </summary>
        /// <value>Here you must place the URL of your Webhook remember that you must program what you will do with the events received. Also do not forget to handle the HTTPS protocol for greater security.</value>
        /// <example>&quot;https://webhook.site/89277eaa-a8e4-4306-8dc5-f55c80703dc8&quot;</example>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// It is a value that allows to decide if the events will be synchronous or asynchronous. We recommend asynchronous &#x3D; false
        /// </summary>
        /// <value>It is a value that allows to decide if the events will be synchronous or asynchronous. We recommend asynchronous &#x3D; false</value>
        /// <example>false</example>
        [DataMember(Name = "synchronous", EmitDefaultValue = true)]
        public bool Synchronous { get; set; }

        /// <summary>
        /// Gets or Sets SubscribedEvents
        /// </summary>
        [DataMember(Name = "subscribed_events", EmitDefaultValue = false)]
        public List<string> SubscribedEvents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookUpdateRequest {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Synchronous: ").Append(Synchronous).Append("\n");
            sb.Append("  SubscribedEvents: ").Append(SubscribedEvents).Append("\n");
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
            return this.Equals(input as WebhookUpdateRequest);
        }

        /// <summary>
        /// Returns true if WebhookUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Synchronous == input.Synchronous ||
                    this.Synchronous.Equals(input.Synchronous)
                ) && 
                (
                    this.SubscribedEvents == input.SubscribedEvents ||
                    this.SubscribedEvents != null &&
                    input.SubscribedEvents != null &&
                    this.SubscribedEvents.SequenceEqual(input.SubscribedEvents)
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Synchronous.GetHashCode();
                if (this.SubscribedEvents != null)
                {
                    hashCode = (hashCode * 59) + this.SubscribedEvents.GetHashCode();
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
            // Url (string) pattern
            Regex regexUrl = new Regex(@"^(?!.*(localhost|127\\.0\\.0\\.1)).*$", RegexOptions.CultureInvariant);
            if (false == regexUrl.Match(this.Url).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Url, must match a pattern of " + regexUrl, new [] { "Url" });
            }

            yield break;
        }
    }

}
