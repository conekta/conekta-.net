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
    /// DiscountLinesResponse
    /// </summary>
    [DataContract(Name = "discount_lines_response")]
    public partial class DiscountLinesResponse : IEquatable<DiscountLinesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountLinesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscountLinesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountLinesResponse" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="code">Discount code. (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="id">id.</param>
        /// <param name="_object">_object.</param>
        /// <param name="parentId">parentId.</param>
        public DiscountLinesResponse(long amount = default(long), string code = default(string), string type = default(string), string id = default(string), string _object = default(string), string parentId = default(string))
        {
            this.Amount = amount;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for DiscountLinesResponse and cannot be null");
            }
            this.Code = code;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for DiscountLinesResponse and cannot be null");
            }
            this.Type = type;
            this.Id = id;
            this.Object = _object;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Discount code.
        /// </summary>
        /// <value>Discount code.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscountLinesResponse {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
            return this.Equals(input as DiscountLinesResponse);
        }

        /// <summary>
        /// Returns true if DiscountLinesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountLinesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountLinesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
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
            // Amount (long) minimum
            if (this.Amount < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
