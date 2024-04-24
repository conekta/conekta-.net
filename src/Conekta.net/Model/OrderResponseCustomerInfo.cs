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
    /// OrderResponseCustomerInfo
    /// </summary>
    [DataContract(Name = "order_response_customer_info")]
    public partial class OrderResponseCustomerInfo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderResponseCustomerInfo" /> class.
        /// </summary>
        /// <param name="customerCustomReference">Custom reference.</param>
        /// <param name="name">name.</param>
        /// <param name="email">email.</param>
        /// <param name="phone">phone.</param>
        /// <param name="corporate">corporate (default to false).</param>
        /// <param name="varObject">varObject.</param>
        /// <param name="customerId">customerId.</param>
        public OrderResponseCustomerInfo(string customerCustomReference = default(string), string name = default(string), string email = default(string), string phone = default(string), bool corporate = false, string varObject = default(string), string customerId = default(string))
        {
            this.CustomerCustomReference = customerCustomReference;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.Corporate = corporate;
            this.Object = varObject;
            this.CustomerId = customerId;
        }

        /// <summary>
        /// Custom reference
        /// </summary>
        /// <value>Custom reference</value>
        /// <example>custom_reference</example>
        [DataMember(Name = "customer_custom_reference", EmitDefaultValue = true)]
        public string CustomerCustomReference { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>DevTest</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        /// <example>test@conekta.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        /// <example>5522997233</example>
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
        /// <example>customer_info</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets CustomerId
        /// </summary>
        /// <example>cus_23874283647</example>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string CustomerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderResponseCustomerInfo {\n");
            sb.Append("  CustomerCustomReference: ").Append(CustomerCustomReference).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Corporate: ").Append(Corporate).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
