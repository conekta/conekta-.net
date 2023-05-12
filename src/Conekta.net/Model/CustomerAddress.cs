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
    /// CustomerAddress
    /// </summary>
    [DataContract(Name = "customer_address")]
    public partial class CustomerAddress : IEquatable<CustomerAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAddress" /> class.
        /// </summary>
        /// <param name="street1">street1 (required).</param>
        /// <param name="street2">street2.</param>
        /// <param name="postalCode">postalCode (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="state">state.</param>
        /// <param name="country">this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2).</param>
        /// <param name="residential">residential.</param>
        /// <param name="externalNumber">externalNumber.</param>
        public CustomerAddress(string street1 = default(string), string street2 = default(string), string postalCode = default(string), string city = default(string), string state = default(string), string country = default(string), bool residential = default(bool), string externalNumber = default(string))
        {
            // to ensure "street1" is required (not null)
            if (street1 == null)
            {
                throw new ArgumentNullException("street1 is a required property for CustomerAddress and cannot be null");
            }
            this.Street1 = street1;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for CustomerAddress and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for CustomerAddress and cannot be null");
            }
            this.City = city;
            this.Street2 = street2;
            this.State = state;
            this.Country = country;
            this.Residential = residential;
            this.ExternalNumber = externalNumber;
        }

        /// <summary>
        /// Gets or Sets Street1
        /// </summary>
        /// <example>&quot;avenida siempre viva&quot;</example>
        [DataMember(Name = "street1", IsRequired = true, EmitDefaultValue = true)]
        public string Street1 { get; set; }

        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        /// <example>&quot;fake street&quot;</example>
        [DataMember(Name = "street2", EmitDefaultValue = false)]
        public string Street2 { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        /// <example>&quot;06100&quot;</example>
        [DataMember(Name = "postal_code", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /// <example>&quot;Ciudad de Mexico&quot;</example>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        /// <example>&quot;Ciudad de Mexico&quot;</example>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)
        /// </summary>
        /// <value>this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)</value>
        /// <example>&quot;MX&quot;</example>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Residential
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "residential", EmitDefaultValue = true)]
        public bool Residential { get; set; }

        /// <summary>
        /// Gets or Sets ExternalNumber
        /// </summary>
        [DataMember(Name = "external_number", EmitDefaultValue = false)]
        public string ExternalNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerAddress {\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
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
            return this.Equals(input as CustomerAddress);
        }

        /// <summary>
        /// Returns true if CustomerAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerAddress input)
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
                    this.Residential == input.Residential ||
                    this.Residential.Equals(input.Residential)
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
                hashCode = (hashCode * 59) + this.Residential.GetHashCode();
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
