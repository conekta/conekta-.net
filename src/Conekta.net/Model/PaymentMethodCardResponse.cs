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
    /// PaymentMethodCardResponse
    /// </summary>
    [DataContract(Name = "payment_method_card_response")]
    public partial class PaymentMethodCardResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCardResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodCardResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCardResponse" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="parentId">parentId.</param>
        /// <param name="last4">last4.</param>
        /// <param name="bin">bin.</param>
        /// <param name="cardType">cardType.</param>
        /// <param name="expMonth">expMonth.</param>
        /// <param name="expYear">expYear.</param>
        /// <param name="brand">brand.</param>
        /// <param name="name">name.</param>
        /// <param name="varDefault">varDefault.</param>
        /// <param name="visibleOnCheckout">visibleOnCheckout.</param>
        /// <param name="paymentSourceStatus">paymentSourceStatus.</param>
        public PaymentMethodCardResponse(string type = default(string), string id = default(string), string varObject = default(string), long createdAt = default(long), string parentId = default(string), string last4 = default(string), string bin = default(string), string cardType = default(string), string expMonth = default(string), string expYear = default(string), string brand = default(string), string name = default(string), bool varDefault = default(bool), bool visibleOnCheckout = default(bool), string paymentSourceStatus = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for PaymentMethodCardResponse and cannot be null");
            }
            this.Type = type;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for PaymentMethodCardResponse and cannot be null");
            }
            this.Id = id;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for PaymentMethodCardResponse and cannot be null");
            }
            this.Object = varObject;
            this.CreatedAt = createdAt;
            this.ParentId = parentId;
            this.Last4 = last4;
            this.Bin = bin;
            this.CardType = cardType;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.Brand = brand;
            this.Name = name;
            this.Default = varDefault;
            this.VisibleOnCheckout = visibleOnCheckout;
            this.PaymentSourceStatus = paymentSourceStatus;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>src_2s8K1B3PBKDontpi9</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>payment_source</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>1675715413</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        /// <example>cus_2s8K1B3PBKDontpi8</example>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        /// <example>6410</example>
        [DataMember(Name = "last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        /// Gets or Sets Bin
        /// </summary>
        /// <example>40276657</example>
        [DataMember(Name = "bin", EmitDefaultValue = false)]
        public string Bin { get; set; }

        /// <summary>
        /// Gets or Sets CardType
        /// </summary>
        /// <example>debit</example>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        /// Gets or Sets ExpMonth
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "exp_month", EmitDefaultValue = false)]
        public string ExpMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpYear
        /// </summary>
        /// <example>25</example>
        [DataMember(Name = "exp_year", EmitDefaultValue = false)]
        public string ExpYear { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        /// <example>visa</example>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Fulano Perez&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Default
        /// </summary>
        [DataMember(Name = "default", EmitDefaultValue = true)]
        public bool Default { get; set; }

        /// <summary>
        /// Gets or Sets VisibleOnCheckout
        /// </summary>
        [DataMember(Name = "visible_on_checkout", EmitDefaultValue = true)]
        public bool VisibleOnCheckout { get; set; }

        /// <summary>
        /// Gets or Sets PaymentSourceStatus
        /// </summary>
        /// <example>active</example>
        [DataMember(Name = "payment_source_status", EmitDefaultValue = false)]
        public string PaymentSourceStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodCardResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  VisibleOnCheckout: ").Append(VisibleOnCheckout).Append("\n");
            sb.Append("  PaymentSourceStatus: ").Append(PaymentSourceStatus).Append("\n");
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
