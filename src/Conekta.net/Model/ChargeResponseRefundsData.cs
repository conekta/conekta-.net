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
    /// ChargeResponseRefundsData
    /// </summary>
    [DataContract(Name = "charge_response_refunds_data")]
    public partial class ChargeResponseRefundsData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeResponseRefundsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChargeResponseRefundsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeResponseRefundsData" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="authCode">authCode.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="expiresAt">refund expiration date.</param>
        /// <param name="id">id (required).</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="status">refund status.</param>
        public ChargeResponseRefundsData(long amount = default(long), string authCode = default(string), long createdAt = default(long), long expiresAt = default(long), string id = default(string), string varObject = default(string), string status = default(string))
        {
            this.Amount = amount;
            this.CreatedAt = createdAt;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ChargeResponseRefundsData and cannot be null");
            }
            this.Id = id;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for ChargeResponseRefundsData and cannot be null");
            }
            this.Object = varObject;
            this.AuthCode = authCode;
            this.ExpiresAt = expiresAt;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /*
        <example>-15000</example>
        */
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Gets or Sets AuthCode
        /// </summary>
        /*
        <example>867372</example>
        */
        [DataMember(Name = "auth_code", EmitDefaultValue = false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /*
        <example>1678226878</example>
        */
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// refund expiration date
        /// </summary>
        /// <value>refund expiration date</value>
        /*
        <example>1678226878</example>
        */
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>6407b5bee1329a000175ba11</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /*
        <example>refund</example>
        */
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// refund status
        /// </summary>
        /// <value>refund status</value>
        /*
        <example>pending</example>
        */
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeResponseRefundsData {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
