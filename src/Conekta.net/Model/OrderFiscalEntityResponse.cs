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
    /// Fiscal entity of the order, Currently it is a purely informative field
    /// </summary>
    [DataContract(Name = "order_fiscal_entity_response")]
    public partial class OrderFiscalEntityResponse : IEquatable<OrderFiscalEntityResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFiscalEntityResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderFiscalEntityResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFiscalEntityResponse" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="email">Email of the fiscal entity.</param>
        /// <param name="metadata">Metadata associated with the fiscal entity.</param>
        /// <param name="name">Name of the fiscal entity.</param>
        /// <param name="taxId">Tax ID of the fiscal entity.</param>
        /// <param name="id">ID of the fiscal entity (required).</param>
        /// <param name="createdAt">The time at which the object was created in seconds since the Unix epoch (required).</param>
        /// <param name="_object">_object (required).</param>
        /// <param name="phone">Phone of the fiscal entity.</param>
        public OrderFiscalEntityResponse(OrderFiscalEntityAddressResponse address = default(OrderFiscalEntityAddressResponse), string email = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string name = default(string), string taxId = default(string), string id = default(string), long createdAt = default(long), string _object = default(string), string phone = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for OrderFiscalEntityResponse and cannot be null");
            }
            this.Address = address;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for OrderFiscalEntityResponse and cannot be null");
            }
            this.Id = id;
            this.CreatedAt = createdAt;
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for OrderFiscalEntityResponse and cannot be null");
            }
            this.Object = _object;
            this.Email = email;
            this.Metadata = metadata;
            this.Name = name;
            this.TaxId = taxId;
            this.Phone = phone;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public OrderFiscalEntityAddressResponse Address { get; set; }

        /// <summary>
        /// Email of the fiscal entity
        /// </summary>
        /// <value>Email of the fiscal entity</value>
        /// <example>&quot;test@gmail.com&quot;</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Metadata associated with the fiscal entity
        /// </summary>
        /// <value>Metadata associated with the fiscal entity</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Name of the fiscal entity
        /// </summary>
        /// <value>Name of the fiscal entity</value>
        /// <example>&quot;Conekta Inc&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Tax ID of the fiscal entity
        /// </summary>
        /// <value>Tax ID of the fiscal entity</value>
        /// <example>&quot;324234234&quot;</example>
        [DataMember(Name = "tax_id", EmitDefaultValue = true)]
        public string TaxId { get; set; }

        /// <summary>
        /// ID of the fiscal entity
        /// </summary>
        /// <value>ID of the fiscal entity</value>
        /// <example>&quot;fis_ent_2tN85VYaSMyDvjB3M&quot;</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The time at which the object was created in seconds since the Unix epoch
        /// </summary>
        /// <value>The time at which the object was created in seconds since the Unix epoch</value>
        /// <example>1676328434</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>&quot;fiscal_entity&quot;</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Phone of the fiscal entity
        /// </summary>
        /// <value>Phone of the fiscal entity</value>
        /// <example>&quot;+525511223344&quot;</example>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderFiscalEntityResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
            return this.Equals(input as OrderFiscalEntityResponse);
        }

        /// <summary>
        /// Returns true if OrderFiscalEntityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderFiscalEntityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderFiscalEntityResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.TaxId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxId.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
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