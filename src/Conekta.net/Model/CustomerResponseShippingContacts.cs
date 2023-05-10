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
    /// CustomerResponseShippingContacts
    /// </summary>
    [DataContract(Name = "customer_response_shipping_contacts")]
    public partial class CustomerResponseShippingContacts : IEquatable<CustomerResponseShippingContacts>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponseShippingContacts" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerResponseShippingContacts() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponseShippingContacts" /> class.
        /// </summary>
        /// <param name="_object">Object type, in this case is list (required).</param>
        /// <param name="hasMore">Indicates if there are more pages to be requested (required).</param>
        /// <param name="data">data.</param>
        public CustomerResponseShippingContacts(string _object = default(string), bool hasMore = default(bool), List<CustomerShippingContactsDataResponse> data = default(List<CustomerShippingContactsDataResponse>))
        {
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for CustomerResponseShippingContacts and cannot be null");
            }
            this.Object = _object;
            this.HasMore = hasMore;
            this.Data = data;
        }

        /// <summary>
        /// Object type, in this case is list
        /// </summary>
        /// <value>Object type, in this case is list</value>
        /// <example>&quot;list&quot;</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Indicates if there are more pages to be requested
        /// </summary>
        /// <value>Indicates if there are more pages to be requested</value>
        /// <example>false</example>
        [DataMember(Name = "has_more", IsRequired = true, EmitDefaultValue = true)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<CustomerShippingContactsDataResponse> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerResponseShippingContacts {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as CustomerResponseShippingContacts);
        }

        /// <summary>
        /// Returns true if CustomerResponseShippingContacts instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerResponseShippingContacts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerResponseShippingContacts input)
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
                    this.HasMore == input.HasMore ||
                    this.HasMore.Equals(input.HasMore)
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                hashCode = (hashCode * 59) + this.HasMore.GetHashCode();
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
