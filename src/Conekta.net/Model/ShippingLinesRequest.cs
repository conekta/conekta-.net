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
    /// ShippingLinesRequest
    /// </summary>
    [DataContract(Name = "shipping_lines_request")]
    public partial class ShippingLinesRequest : IEquatable<ShippingLinesRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingLinesRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShippingLinesRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingLinesRequest" /> class.
        /// </summary>
        /// <param name="amount">Shipping amount in cents (required).</param>
        /// <param name="carrier">Carrier name for the shipment.</param>
        /// <param name="trackingNumber">Tracking number can be used to track the shipment.</param>
        /// <param name="method">Method of shipment.</param>
        /// <param name="metadata">Hash where the user can send additional information for each &#39;shipping_line&#39;..</param>
        public ShippingLinesRequest(long amount = default(long), string carrier = default(string), string trackingNumber = default(string), string method = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            this.Amount = amount;
            this.Carrier = carrier;
            this.TrackingNumber = trackingNumber;
            this.Method = method;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Shipping amount in cents
        /// </summary>
        /// <value>Shipping amount in cents</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Carrier name for the shipment
        /// </summary>
        /// <value>Carrier name for the shipment</value>
        [DataMember(Name = "carrier", EmitDefaultValue = false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Tracking number can be used to track the shipment
        /// </summary>
        /// <value>Tracking number can be used to track the shipment</value>
        [DataMember(Name = "tracking_number", EmitDefaultValue = false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Method of shipment
        /// </summary>
        /// <value>Method of shipment</value>
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Hash where the user can send additional information for each &#39;shipping_line&#39;.
        /// </summary>
        /// <value>Hash where the user can send additional information for each &#39;shipping_line&#39;.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShippingLinesRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as ShippingLinesRequest);
        }

        /// <summary>
        /// Returns true if ShippingLinesRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ShippingLinesRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShippingLinesRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.TrackingNumber == input.TrackingNumber ||
                    (this.TrackingNumber != null &&
                    this.TrackingNumber.Equals(input.TrackingNumber))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Carrier != null)
                {
                    hashCode = (hashCode * 59) + this.Carrier.GetHashCode();
                }
                if (this.TrackingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.TrackingNumber.GetHashCode();
                }
                if (this.Method != null)
                {
                    hashCode = (hashCode * 59) + this.Method.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
            // Amount (long) minimum
            if (this.Amount < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.", new [] { "Amount" });
            }

            yield break;
        }
    }

}