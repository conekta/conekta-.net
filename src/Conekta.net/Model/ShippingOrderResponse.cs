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
    /// ShippingOrderResponse
    /// </summary>
    [DataContract(Name = "shipping_order_response")]
    public partial class ShippingOrderResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingOrderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShippingOrderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShippingOrderResponse" /> class.
        /// </summary>
        /// <param name="amount">Shipping amount in cents (required).</param>
        /// <param name="carrier">Carrier name for the shipment.</param>
        /// <param name="trackingNumber">Tracking number can be used to track the shipment.</param>
        /// <param name="method">Method of shipment.</param>
        /// <param name="metadata">Hash where the user can send additional information for each &#39;shipping&#39;..</param>
        /// <param name="id">id.</param>
        /// <param name="varObject">varObject.</param>
        /// <param name="parentId">parentId.</param>
        public ShippingOrderResponse(long amount = default(long), string carrier = default(string), string trackingNumber = default(string), string method = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string id = default(string), string varObject = default(string), string parentId = default(string))
        {
            this.Amount = amount;
            this.Carrier = carrier;
            this.TrackingNumber = trackingNumber;
            this.Method = method;
            this.Metadata = metadata;
            this.Id = id;
            this.Object = varObject;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Shipping amount in cents
        /// </summary>
        /// <value>Shipping amount in cents</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Carrier name for the shipment
        /// </summary>
        /// <value>Carrier name for the shipment</value>
        /*
        <example>FEDEX</example>
        */
        [DataMember(Name = "carrier", EmitDefaultValue = false)]
        public string Carrier { get; set; }

        /// <summary>
        /// Tracking number can be used to track the shipment
        /// </summary>
        /// <value>Tracking number can be used to track the shipment</value>
        /*
        <example>TRACK123</example>
        */
        [DataMember(Name = "tracking_number", EmitDefaultValue = false)]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Method of shipment
        /// </summary>
        /// <value>Method of shipment</value>
        /*
        <example>Same day</example>
        */
        [DataMember(Name = "method", EmitDefaultValue = false)]
        public string Method { get; set; }

        /// <summary>
        /// Hash where the user can send additional information for each &#39;shipping&#39;.
        /// </summary>
        /// <value>Hash where the user can send additional information for each &#39;shipping&#39;.</value>
        /*
        <example>{key&#x3D;value}</example>
        */
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShippingOrderResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  TrackingNumber: ").Append(TrackingNumber).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Amount (long) minimum
            if (this.Amount < (long)0)
            {
                yield return new ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
