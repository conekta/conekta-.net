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
    /// PaymentMethodCash
    /// </summary>
    [DataContract(Name = "payment_method_cash")]
    public partial class PaymentMethodCash : IEquatable<PaymentMethodCash>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCash" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodCash() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCash" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="_object">_object (required).</param>
        /// <param name="authCode">authCode.</param>
        /// <param name="cashierId">cashierId.</param>
        /// <param name="reference">reference.</param>
        /// <param name="barcodeUrl">barcodeUrl.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="store">store.</param>
        /// <param name="storeName">storeName.</param>
        public PaymentMethodCash(string type = default(string), string _object = default(string), int? authCode = default(int?), string cashierId = default(string), string reference = default(string), string barcodeUrl = default(string), long expiresAt = default(long), string serviceName = default(string), string store = default(string), string storeName = default(string))
        {
            // to ensure "_object" is required (not null)
            if (_object == null)
            {
                throw new ArgumentNullException("_object is a required property for PaymentMethodCash and cannot be null");
            }
            this.Object = _object;
            this.Type = type;
            this.AuthCode = authCode;
            this.CashierId = cashierId;
            this.Reference = reference;
            this.BarcodeUrl = barcodeUrl;
            this.ExpiresAt = expiresAt;
            this.ServiceName = serviceName;
            this.Store = store;
            this.StoreName = storeName;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets AuthCode
        /// </summary>
        [DataMember(Name = "auth_code", EmitDefaultValue = true)]
        public int? AuthCode { get; set; }

        /// <summary>
        /// Gets or Sets CashierId
        /// </summary>
        [DataMember(Name = "cashier_id", EmitDefaultValue = true)]
        public string CashierId { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets BarcodeUrl
        /// </summary>
        [DataMember(Name = "barcode_url", EmitDefaultValue = false)]
        public string BarcodeUrl { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or Sets Store
        /// </summary>
        [DataMember(Name = "store", EmitDefaultValue = true)]
        public string Store { get; set; }

        /// <summary>
        /// Gets or Sets StoreName
        /// </summary>
        [DataMember(Name = "store_name", EmitDefaultValue = false)]
        public string StoreName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodCash {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  CashierId: ").Append(CashierId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  BarcodeUrl: ").Append(BarcodeUrl).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
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
            return this.Equals(input as PaymentMethodCash);
        }

        /// <summary>
        /// Returns true if PaymentMethodCash instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodCash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodCash input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.AuthCode == input.AuthCode ||
                    (this.AuthCode != null &&
                    this.AuthCode.Equals(input.AuthCode))
                ) && 
                (
                    this.CashierId == input.CashierId ||
                    (this.CashierId != null &&
                    this.CashierId.Equals(input.CashierId))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.BarcodeUrl == input.BarcodeUrl ||
                    (this.BarcodeUrl != null &&
                    this.BarcodeUrl.Equals(input.BarcodeUrl))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.AuthCode != null)
                {
                    hashCode = (hashCode * 59) + this.AuthCode.GetHashCode();
                }
                if (this.CashierId != null)
                {
                    hashCode = (hashCode * 59) + this.CashierId.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                if (this.BarcodeUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BarcodeUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                if (this.Store != null)
                {
                    hashCode = (hashCode * 59) + this.Store.GetHashCode();
                }
                if (this.StoreName != null)
                {
                    hashCode = (hashCode * 59) + this.StoreName.GetHashCode();
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