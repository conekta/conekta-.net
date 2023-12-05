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
    /// OrderCustomerInfoResponse
    /// </summary>
    [DataContract(Name = "order_customer_info_response")]
    public partial class OrderCustomerInfoResponse : IEquatable<OrderCustomerInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderCustomerInfoResponse" /> class.
        /// </summary>
        /// <param name="customerCustomReference">Custom reference.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="phone">phone.</param>
        /// <param name="corporate">corporate (default to false).</param>
        /// <param name="_object">_object.</param>
        public OrderCustomerInfoResponse(string customerCustomReference = default(string), string name = default(string), string email = default(string), string phone = default(string), bool corporate = false, string _object = default(string))
        {
            this.CustomerCustomReference = customerCustomReference;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Corporate = corporate;
            this.Object = _object;
        }

        /// <summary>
        /// Custom reference
        /// </summary>
        /// <value>Custom reference</value>
        /// <example>&quot;custom_reference&quot;</example>
        [DataMember(Name = "customer_custom_reference", EmitDefaultValue = true)]
        public string CustomerCustomReference { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>&quot;DevTest&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        /// <example>&quot;test@conekta.com&quot;</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        /// <example>&quot;5522997233&quot;</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Corporate
        /// </summary>
        [DataMember(Name = "corporate", EmitDefaultValue = true)]
        public bool Corporate { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>&quot;customer_info&quot;</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderCustomerInfoResponse {\n");
            sb.Append("  CustomerCustomReference: ").Append(CustomerCustomReference).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Corporate: ").Append(Corporate).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderCustomerInfoResponse);
        }

        /// <summary>
        /// Returns true if OrderCustomerInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderCustomerInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderCustomerInfoResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerCustomReference == input.CustomerCustomReference ||
                    (this.CustomerCustomReference != null &&
                    this.CustomerCustomReference.Equals(input.CustomerCustomReference))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.Corporate == input.Corporate ||
                    this.Corporate.Equals(input.Corporate)
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
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
                if (this.CustomerCustomReference != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerCustomReference.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Corporate.GetHashCode();
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
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