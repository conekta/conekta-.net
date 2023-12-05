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
    /// CustomerShippingContactsResponseAddress
    /// </summary>
    [DataContract(Name = "customer_shipping_contacts_response_address")]
    public partial class CustomerShippingContactsResponseAddress : IEquatable<CustomerShippingContactsResponseAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShippingContactsResponseAddress" /> class.
        /// </summary>
        /// <param name="_object">_object.</param>
        /// <param name="street1">street1.</param>
        /// <param name="street2">street2.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="country">country.</param>
        /// <param name="residential">residential.</param>
        public CustomerShippingContactsResponseAddress(string _object = default(string), string street1 = default(string), string street2 = default(string), string postalCode = default(string), string city = default(string), string state = default(string), string country = default(string), bool residential = default(bool))
        {
            this.Object = _object;
            this.Street1 = street1;
            this.Street2 = street2;
            this.PostalCode = postalCode;
            this.City = city;
            this.State = state;
            this.Country = country;
            this.Residential = residential;
        }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>&quot;shipping_address&quot;</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets Street1
        /// </summary>
        /// <example>&quot;Nuevo Leon 254&quot;</example>
        [DataMember(Name = "street1", EmitDefaultValue = false)]
        public string Street1 { get; set; }

        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        /// <example>&quot;Departamento 404&quot;</example>
        [DataMember(Name = "street2", EmitDefaultValue = false)]
        public string Street2 { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        /// <example>&quot;06100&quot;</example>
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /// <example>&quot;Ciudad de Mexico&quot;</example>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        /// <example>&quot;Ciudad de Mexico&quot;</example>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerShippingContactsResponseAddress {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
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
            return this.Equals(input as CustomerShippingContactsResponseAddress);
        }

        /// <summary>
        /// Returns true if CustomerShippingContactsResponseAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerShippingContactsResponseAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerShippingContactsResponseAddress input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
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
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
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
