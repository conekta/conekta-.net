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
    /// Address of the fiscal entity
    /// </summary>
    [DataContract(Name = "fiscal_entity_address")]
    public partial class FiscalEntityAddress : IEquatable<FiscalEntityAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FiscalEntityAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FiscalEntityAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FiscalEntityAddress" /> class.
        /// </summary>
        /// <param name="street1">Street name and number (required).</param>
        /// <param name="street2">Street name and number.</param>
        /// <param name="postalCode">Postal code (required).</param>
        /// <param name="city">City (required).</param>
        /// <param name="state">State.</param>
        /// <param name="country">this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) (required).</param>
        /// <param name="externalNumber">External number (required).</param>
        public FiscalEntityAddress(string street1 = default(string), string street2 = default(string), string postalCode = default(string), string city = default(string), string state = default(string), string country = default(string), string externalNumber = default(string))
        {
            // to ensure "street1" is required (not null)
            if (street1 == null)
            {
                throw new ArgumentNullException("street1 is a required property for FiscalEntityAddress and cannot be null");
            }
            this.Street1 = street1;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for FiscalEntityAddress and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for FiscalEntityAddress and cannot be null");
            }
            this.City = city;
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for FiscalEntityAddress and cannot be null");
            }
            this.Country = country;
            // to ensure "externalNumber" is required (not null)
            if (externalNumber == null)
            {
                throw new ArgumentNullException("externalNumber is a required property for FiscalEntityAddress and cannot be null");
            }
            this.ExternalNumber = externalNumber;
            this.Street2 = street2;
            this.State = state;
        }

        /// <summary>
        /// Street name and number
        /// </summary>
        /// <value>Street name and number</value>
        /// <example>&quot;Nuevo Leon 254&quot;</example>
        [DataMember(Name = "street1", IsRequired = true, EmitDefaultValue = true)]
        public string Street1 { get; set; }

        /// <summary>
        /// Street name and number
        /// </summary>
        /// <value>Street name and number</value>
        /// <example>&quot;Departamento 404&quot;</example>
        [DataMember(Name = "street2", EmitDefaultValue = true)]
        public string Street2 { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        /// <example>&quot;06100&quot;</example>
        [DataMember(Name = "postal_code", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        /// <example>&quot;Ciudad de Mexico&quot;</example>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        /// <example>&quot;Ciudad de Mexico&quot;</example>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)
        /// </summary>
        /// <value>this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)</value>
        /// <example>&quot;MX&quot;</example>
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// External number
        /// </summary>
        /// <value>External number</value>
        /// <example>&quot;123&quot;</example>
        [DataMember(Name = "external_number", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FiscalEntityAddress {\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExternalNumber: ").Append(ExternalNumber).Append("\n");
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
            return this.Equals(input as FiscalEntityAddress);
        }

        /// <summary>
        /// Returns true if FiscalEntityAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of FiscalEntityAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FiscalEntityAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Street1 == input.Street1 ||
                    (this.Street1 != null &&
                    this.Street1.Equals(input.Street1))
                ) && 
                (
                    this.Street2 == input.Street2 ||
                    (this.Street2 != null &&
                    this.Street2.Equals(input.Street2))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ExternalNumber == input.ExternalNumber ||
                    (this.ExternalNumber != null &&
                    this.ExternalNumber.Equals(input.ExternalNumber))
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
                if (this.Street1 != null)
                {
                    hashCode = (hashCode * 59) + this.Street1.GetHashCode();
                }
                if (this.Street2 != null)
                {
                    hashCode = (hashCode * 59) + this.Street2.GetHashCode();
                }
                if (this.PostalCode != null)
                {
                    hashCode = (hashCode * 59) + this.PostalCode.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.ExternalNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalNumber.GetHashCode();
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