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
    /// CustomerFiscalEntitiesDataResponse
    /// </summary>
    [DataContract(Name = "customer_fiscal_entities_data_response")]
    public partial class CustomerFiscalEntitiesDataResponse : IEquatable<CustomerFiscalEntitiesDataResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFiscalEntitiesDataResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerFiscalEntitiesDataResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFiscalEntitiesDataResponse" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="taxId">taxId.</param>
        /// <param name="email">email.</param>
        /// <param name="phone">phone.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="companyName">companyName.</param>
        /// <param name="id">id (required).</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="varDefault">varDefault.</param>
        public CustomerFiscalEntitiesDataResponse(CustomerFiscalEntitiesRequestAddress address = default(CustomerFiscalEntitiesRequestAddress), string taxId = default(string), string email = default(string), string phone = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string companyName = default(string), string id = default(string), string varObject = default(string), long createdAt = default(long), string parentId = default(string), bool varDefault = default(bool))
        {
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CustomerFiscalEntitiesDataResponse and cannot be null");
            }
            this.Address = address;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CustomerFiscalEntitiesDataResponse and cannot be null");
            }
            this.Id = id;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for CustomerFiscalEntitiesDataResponse and cannot be null");
            }
            this.VarObject = varObject;
            this.CreatedAt = createdAt;
            this.TaxId = taxId;
            this.Email = email;
            this.Phone = phone;
            this.Metadata = metadata;
            this.CompanyName = companyName;
            this.ParentId = parentId;
            this.VarDefault = varDefault;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public CustomerFiscalEntitiesRequestAddress Address { get; set; }

        /// <summary>
        /// Gets or Sets TaxId
        /// </summary>
        [DataMember(Name = "tax_id", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets CompanyName
        /// </summary>
        /// <example>conekta</example>
        [DataMember(Name = "company_name", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>ship_cont_2tKZsTYcsryyu7Ah8</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        /// <example>shipping_contact</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>1675715413</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        /// <example>cus_2tKcHxhTz7xU5SymF</example>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or Sets VarDefault
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool VarDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerFiscalEntitiesDataResponse {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  VarDefault: ").Append(VarDefault).Append("\n");
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
            return this.Equals(input as CustomerFiscalEntitiesDataResponse);
        }

        /// <summary>
        /// Returns true if CustomerFiscalEntitiesDataResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerFiscalEntitiesDataResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerFiscalEntitiesDataResponse input)
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
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.VarObject == input.VarObject ||
                    (this.VarObject != null &&
                    this.VarObject.Equals(input.VarObject))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.VarDefault == input.VarDefault ||
                    this.VarDefault.Equals(input.VarDefault)
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
                if (this.TaxId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxId.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VarDefault.GetHashCode();
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
