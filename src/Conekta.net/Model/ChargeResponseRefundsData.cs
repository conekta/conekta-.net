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
    public partial class ChargeResponseRefundsData : IEquatable<ChargeResponseRefundsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeResponseRefundsData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChargeResponseRefundsData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeResponseRefundsData" /> class.
        /// </summary>
        /// <param name="_object">_object (required).</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="authCode">authCode.</param>
        public ChargeResponseRefundsData(string _object = default(string), long amount = default(long), string id = default(string), long createdAt = default(long), string authCode = default(string))
        {
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for ChargeResponseRefundsData and cannot be null");
            }
            this.Object = _object;
            this.Amount = amount;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ChargeResponseRefundsData and cannot be null");
            }
            this.Id = id;
            this.CreatedAt = createdAt;
            this.AuthCode = authCode;
        }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets AuthCode
        /// </summary>
        [DataMember(Name = "auth_code", EmitDefaultValue = false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeResponseRefundsData {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
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
            return this.Equals(input as ChargeResponseRefundsData);
        }

        /// <summary>
        /// Returns true if ChargeResponseRefundsData instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeResponseRefundsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeResponseRefundsData input)
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
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.AuthCode == input.AuthCode ||
                    (this.AuthCode != null &&
                    this.AuthCode.Equals(input.AuthCode))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.AuthCode != null)
                {
                    hashCode = (hashCode * 59) + this.AuthCode.GetHashCode();
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