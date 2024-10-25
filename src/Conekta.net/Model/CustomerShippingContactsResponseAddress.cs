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
    public partial class CustomerShippingContactsResponseAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerShippingContactsResponseAddress" /> class.
        /// </summary>
        /// <param name="varObject">varObject.</param>
        /// <param name="street1">street1.</param>
        /// <param name="street2">street2.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="city">city.</param>
        /// <param name="state">state.</param>
        /// <param name="country">country.</param>
        /// <param name="residential">residential.</param>
        public CustomerShippingContactsResponseAddress(string varObject = default(string), string street1 = default(string), string street2 = default(string), string postalCode = default(string), string city = default(string), string state = default(string), string country = default(string), bool? residential = default(bool?))
        {
            this.Object = varObject;
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
        /*
        <example>shipping_address</example>
        */
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets Street1
        /// </summary>
        /*
        <example>Nuevo Leon 254</example>
        */
        [DataMember(Name = "street1", EmitDefaultValue = false)]
        public string Street1 { get; set; }

        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        /*
        <example>Departamento 404</example>
        */
        [DataMember(Name = "street2", EmitDefaultValue = false)]
        public string Street2 { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        /*
        <example>06100</example>
        */
        [DataMember(Name = "postal_code", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        /*
        <example>Ciudad de Mexico</example>
        */
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        /*
        <example>Ciudad de Mexico</example>
        */
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        /*
        <example>MX</example>
        */
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Residential
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "residential", EmitDefaultValue = true)]
        public bool? Residential { get; set; }

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
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
