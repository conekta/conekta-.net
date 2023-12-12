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
    /// Company fiscal info model
    /// </summary>
    [DataContract(Name = "company_fiscal_info_response")]
    public partial class CompanyFiscalInfoResponse : IEquatable<CompanyFiscalInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// The resource&#39;s type
        /// </summary>
        /// <value>The resource&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum FiscalInfo for value: fiscal_info
            /// </summary>
            [EnumMember(Value = "fiscal_info")]
            FiscalInfo = 1
        }


        /// <summary>
        /// The resource&#39;s type
        /// </summary>
        /// <value>The resource&#39;s type</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? VarObject { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyFiscalInfoResponse" /> class.
        /// </summary>
        /// <param name="varObject">The resource&#39;s type.</param>
        /// <param name="taxId">Tax ID of the company.</param>
        /// <param name="legalEntityName">Legal name of the company.</param>
        /// <param name="businessType">Business type of the company.</param>
        /// <param name="phone">Phone number of the company.</param>
        /// <param name="physicalPersonBusinessType">Business type if &#39;persona_fisica&#39;.</param>
        /// <param name="address">address.</param>
        public CompanyFiscalInfoResponse(ObjectEnum? varObject = default(ObjectEnum?), string taxId = default(string), string legalEntityName = default(string), string businessType = default(string), string phone = default(string), string physicalPersonBusinessType = default(string), CompanyFiscalInfoAddressResponse address = default(CompanyFiscalInfoAddressResponse))
        {
            this.VarObject = varObject;
            this.TaxId = taxId;
            this.LegalEntityName = legalEntityName;
            this.BusinessType = businessType;
            this.Phone = phone;
            this.PhysicalPersonBusinessType = physicalPersonBusinessType;
            this.Address = address;
        }

        /// <summary>
        /// Tax ID of the company
        /// </summary>
        /// <value>Tax ID of the company</value>
        /// <example>XAXX010101000</example>
        [DataMember(Name = "tax_id", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Legal name of the company
        /// </summary>
        /// <value>Legal name of the company</value>
        /// <example>Child Company A</example>
        [DataMember(Name = "legal_entity_name", EmitDefaultValue = false)]
        public string LegalEntityName { get; set; }

        /// <summary>
        /// Business type of the company
        /// </summary>
        /// <value>Business type of the company</value>
        /// <example>persona_moral</example>
        [DataMember(Name = "business_type", EmitDefaultValue = false)]
        public string BusinessType { get; set; }

        /// <summary>
        /// Phone number of the company
        /// </summary>
        /// <value>Phone number of the company</value>
        /// <example>5555555555</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Business type if &#39;persona_fisica&#39;
        /// </summary>
        /// <value>Business type if &#39;persona_fisica&#39;</value>
        [DataMember(Name = "physical_person_business_type", EmitDefaultValue = false)]
        public string PhysicalPersonBusinessType { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public CompanyFiscalInfoAddressResponse Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyFiscalInfoResponse {\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  LegalEntityName: ").Append(LegalEntityName).Append("\n");
            sb.Append("  BusinessType: ").Append(BusinessType).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PhysicalPersonBusinessType: ").Append(PhysicalPersonBusinessType).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as CompanyFiscalInfoResponse);
        }

        /// <summary>
        /// Returns true if CompanyFiscalInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyFiscalInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyFiscalInfoResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VarObject == input.VarObject ||
                    this.VarObject.Equals(input.VarObject)
                ) && 
                (
                    this.TaxId == input.TaxId ||
                    (this.TaxId != null &&
                    this.TaxId.Equals(input.TaxId))
                ) && 
                (
                    this.LegalEntityName == input.LegalEntityName ||
                    (this.LegalEntityName != null &&
                    this.LegalEntityName.Equals(input.LegalEntityName))
                ) && 
                (
                    this.BusinessType == input.BusinessType ||
                    (this.BusinessType != null &&
                    this.BusinessType.Equals(input.BusinessType))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PhysicalPersonBusinessType == input.PhysicalPersonBusinessType ||
                    (this.PhysicalPersonBusinessType != null &&
                    this.PhysicalPersonBusinessType.Equals(input.PhysicalPersonBusinessType))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                if (this.TaxId != null)
                {
                    hashCode = (hashCode * 59) + this.TaxId.GetHashCode();
                }
                if (this.LegalEntityName != null)
                {
                    hashCode = (hashCode * 59) + this.LegalEntityName.GetHashCode();
                }
                if (this.BusinessType != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessType.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.PhysicalPersonBusinessType != null)
                {
                    hashCode = (hashCode * 59) + this.PhysicalPersonBusinessType.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
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
