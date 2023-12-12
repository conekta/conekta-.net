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
    [DataContract(Name = "order_update_fiscal_entity_request")]
    public partial class OrderUpdateFiscalEntityRequest : IEquatable<OrderUpdateFiscalEntityRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateFiscalEntityRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderUpdateFiscalEntityRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderUpdateFiscalEntityRequest" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="email">Email of the fiscal entity.</param>
        /// <param name="name">Name of the fiscal entity.</param>
        /// <param name="metadata">Metadata associated with the fiscal entity.</param>
        /// <param name="phone">Phone of the fiscal entity.</param>
        /// <param name="taxId">Tax ID of the fiscal entity.</param>
        public OrderUpdateFiscalEntityRequest(FiscalEntityAddress address = default(FiscalEntityAddress), string email = default(string), string name = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string phone = default(string), string taxId = default(string))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for OrderUpdateFiscalEntityRequest and cannot be null");
            }
            this.Address = address;
            this.Email = email;
            this.Name = name;
            this.Metadata = metadata;
            this.Phone = phone;
            this.TaxId = taxId;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public FiscalEntityAddress Address { get; set; }

        /// <summary>
        /// Email of the fiscal entity
        /// </summary>
        /// <value>Email of the fiscal entity</value>
        /// <example>test@gmail.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Name of the fiscal entity
        /// </summary>
        /// <value>Name of the fiscal entity</value>
        /// <example>Conekta Inc</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Metadata associated with the fiscal entity
        /// </summary>
        /// <value>Metadata associated with the fiscal entity</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Phone of the fiscal entity
        /// </summary>
        /// <value>Phone of the fiscal entity</value>
        /// <example>525511223344</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Tax ID of the fiscal entity
        /// </summary>
        /// <value>Tax ID of the fiscal entity</value>
        /// <example>AAA010101AAA</example>
        [DataMember(Name = "tax_id", EmitDefaultValue = true)]
        public string TaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderUpdateFiscalEntityRequest {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
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
            return this.Equals(input as OrderUpdateFiscalEntityRequest);
        }

        /// <summary>
        /// Returns true if OrderUpdateFiscalEntityRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderUpdateFiscalEntityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderUpdateFiscalEntityRequest input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.TaxId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxId.GetHashCode();
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
