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
    /// [Shipping](https://developers.conekta.com/v2.1.0/reference/createcustomershippingcontacts) details, required in case of sending a shipping. If we do not receive a shipping_contact on the order, the default shipping_contact of the customer will be used.
    /// </summary>
    [DataContract(Name = "customer_shipping_contacts")]
    public partial class CustomerShippingContacts : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShippingContacts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerShippingContacts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShippingContacts" /> class.
        /// </summary>
        /// <param name="phone">Phone contact.</param>
        /// <param name="receiver">Name of the person who will receive the order.</param>
        /// <param name="betweenStreets">The street names between which the order will be delivered..</param>
        /// <param name="address">address (required).</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="varDefault">varDefault.</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="metadata">Metadata associated with the shipping contact.</param>
        public CustomerShippingContacts(string phone = default(string), string receiver = default(string), string betweenStreets = default(string), CustomerShippingContactsAddress address = default(CustomerShippingContactsAddress), string parentId = default(string), bool? varDefault = default(bool?), bool? deleted = default(bool?), Dictionary<string, Object> metadata = default(Dictionary<string, Object>))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CustomerShippingContacts and cannot be null");
            }
            this.Address = address;
            this.Phone = phone;
            this.Receiver = receiver;
            this.BetweenStreets = betweenStreets;
            this.ParentId = parentId;
            this.Default = varDefault;
            this.Deleted = deleted;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Phone contact
        /// </summary>
        /// <value>Phone contact</value>
        /// <example>+525511223344</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Name of the person who will receive the order
        /// </summary>
        /// <value>Name of the person who will receive the order</value>
        /// <example>Marvin Fuller</example>
        [DataMember(Name = "receiver", EmitDefaultValue = false)]
        public string Receiver { get; set; }

        /// <summary>
        /// The street names between which the order will be delivered.
        /// </summary>
        /// <value>The street names between which the order will be delivered.</value>
        /// <example>Ackerman Crescent</example>
        [DataMember(Name = "between_streets", EmitDefaultValue = false)]
        public string BetweenStreets { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public CustomerShippingContactsAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool? Default { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Metadata associated with the shipping contact
        /// </summary>
        /// <value>Metadata associated with the shipping contact</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerShippingContacts {\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  BetweenStreets: ").Append(BetweenStreets).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
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
