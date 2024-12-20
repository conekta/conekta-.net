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
    [DataContract(Name = "order_fiscal_entity_address_response")]
    public partial class OrderFiscalEntityAddressResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFiscalEntityAddressResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderFiscalEntityAddressResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderFiscalEntityAddressResponse" /> class.
        /// </summary>
        /// <param name="street1">Street name and number (required).</param>
        /// <param name="street2">Street name and number.</param>
        /// <param name="postalCode">Postal code (required).</param>
        /// <param name="city">City (required).</param>
        /// <param name="state">State.</param>
        /// <param name="country">this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) (required).</param>
        /// <param name="externalNumber">External number (required).</param>
        /// <param name="varObject">varObject.</param>
        public OrderFiscalEntityAddressResponse(string street1 = default(string), string street2 = default(string), string postalCode = default(string), string city = default(string), string state = default(string), string country = default(string), string externalNumber = default(string), string varObject = default(string))
        {
            // to ensure "street1" is required (not null)
            if (street1 == null)
            {
                throw new ArgumentNullException("street1 is a required property for OrderFiscalEntityAddressResponse and cannot be null");
            }
            this.Street1 = street1;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for OrderFiscalEntityAddressResponse and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "city" is required (not null)
            if (city == null)
            {
                throw new ArgumentNullException("city is a required property for OrderFiscalEntityAddressResponse and cannot be null");
            }
            this.City = city;
            // to ensure "country" is required (not null)
            if (country == null)
            {
                throw new ArgumentNullException("country is a required property for OrderFiscalEntityAddressResponse and cannot be null");
            }
            this.Country = country;
            // to ensure "externalNumber" is required (not null)
            if (externalNumber == null)
            {
                throw new ArgumentNullException("externalNumber is a required property for OrderFiscalEntityAddressResponse and cannot be null");
            }
            this.ExternalNumber = externalNumber;
            this.Street2 = street2;
            this.State = state;
            this.Object = varObject;
        }

        /// <summary>
        /// Street name and number
        /// </summary>
        /// <value>Street name and number</value>
        /*
        <example>Nuevo Leon 254</example>
        */
        [DataMember(Name = "street1", IsRequired = true, EmitDefaultValue = true)]
        public string Street1 { get; set; }

        /// <summary>
        /// Street name and number
        /// </summary>
        /// <value>Street name and number</value>
        /*
        <example>Departamento 404</example>
        */
        [DataMember(Name = "street2", EmitDefaultValue = true)]
        public string Street2 { get; set; }

        /// <summary>
        /// Postal code
        /// </summary>
        /// <value>Postal code</value>
        /*
        <example>06100</example>
        */
        [DataMember(Name = "postal_code", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        /*
        <example>Ciudad de Mexico</example>
        */
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = true)]
        public string City { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        /*
        <example>Ciudad de Mexico</example>
        */
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)
        /// </summary>
        /// <value>this field follows the [ISO 3166-1 alpha-2 standard](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2)</value>
        /*
        <example>MX</example>
        */
        [DataMember(Name = "country", IsRequired = true, EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// External number
        /// </summary>
        /// <value>External number</value>
        /*
        <example>123</example>
        */
        [DataMember(Name = "external_number", IsRequired = true, EmitDefaultValue = true)]
        public string ExternalNumber { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /*
        <example>fiscal_entity_address</example>
        */
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderFiscalEntityAddressResponse {\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExternalNumber: ").Append(ExternalNumber).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
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
