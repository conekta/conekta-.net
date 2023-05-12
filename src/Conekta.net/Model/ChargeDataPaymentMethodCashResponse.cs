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
    /// use for cash responses
    /// </summary>
    [DataContract(Name = "charge_data_payment_method_cash_response")]
    public partial class ChargeDataPaymentMethodCashResponse : IEquatable<ChargeDataPaymentMethodCashResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeDataPaymentMethodCashResponse" /> class.
        /// </summary>
        /// <param name="authCode">authCode.</param>
        /// <param name="cashierId">cashierId.</param>
        /// <param name="reference">reference.</param>
        /// <param name="barcodeUrl">barcodeUrl.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="serviceName">serviceName.</param>
        /// <param name="store">store.</param>
        /// <param name="storeName">storeName.</param>
        public ChargeDataPaymentMethodCashResponse(int? authCode = default(int?), string cashierId = default(string), string reference = default(string), string barcodeUrl = default(string), long expiresAt = default(long), string serviceName = default(string), string store = default(string), string storeName = default(string))
        {
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
        /// Gets or Sets AuthCode
        /// </summary>
        /// <example>542563</example>
        [DataMember(Name = "auth_code", EmitDefaultValue = true)]
        public int? AuthCode { get; set; }

        /// <summary>
        /// Gets or Sets CashierId
        /// </summary>
        /// <example>&quot;OINM01010&quot;</example>
        [DataMember(Name = "cashier_id", EmitDefaultValue = true)]
        public string CashierId { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        /// <example>&quot;93000262276908&quot;</example>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets BarcodeUrl
        /// </summary>
        /// <example>&quot;https://pt-common-s3-stg.s3.amazonaws.com/644ebf80f2243197aad6cd8810375b905b613dbe.png?X-Amz-Algorithm&#x3D;AWS4-HMAC-SHA256&amp;X-Amz-Credential&#x3D;ASIA3UN6375MP4SLLCWV%2F20230203%2Fus-east-1%2Fs3%2Faws4_request&amp;X-Amz-Date&#x3D;20230203T215750Z&amp;X-Amz-Expires&#x3D;604800&amp;X-Amz-Security-Token&#x3D;IQoJb3JpZ2luX2VjEH4aCXVzLWVhc3QtMSJGMEQCICd79cu7DYu%2F4%2B3HnVVswydgU9yHcE9kmQIIk2TLoZJrAiBVZ0HxVSeboK5lhdQSqADjwQF62XX35jhC%2F2riB0M8uCqQBAj2%2F%2F%2F%2F%2F%2F%2F%2F%2F%2F8BEAIaDDc5OTgwMTA4MTY4OCIMXWZds9ZI5hzUdbeGKuQDFreMyeWnWWPqDuGZ2%2BHk6usCr%2Fl096%2FNJh9xtf8htLu56K%2FhWUTx%2BjiqFWM2O%2FF5zTS%2BIV6TqkLDZ%2BQ5Jo1miQrRmR57YDz6uP2Yd1mNZ1ouq5ipnNjUuu5UWCCBAmqyZQsrVmeMQpSV2IB%2BTERCCcW2SukFEYU%2F20%2Fzy5orsoZ8DxOW460IymR3cWBk5u3Xh2cV6Y1RdPEwDEThhqYEF5w%2ByKbLENloMsI%2FUm6sG5PPrO3yQOAP9aK2muLJs9lXQRU%2FL%2FSsmS4FKSUFOqlN6YU%2Bi2Y%2FyGIKAJT2VDkngvz5Sl%2Fadj0j%2BPKftVRV5FcEhySB6Rl%2BSkPN7kVQMJp6pS8hMJ6JCyEA%2BA3eWYdIfKgQhWVXAR4oCBfJ62DH8FU3a7WfSjjpTwfVkiReWen3GGCYfUWETTVKp46MKnJ9PG0CD3KzxKV8VfmEGc5krK%2FI%2F%2BDV2wtSa%2F9qf1%2BK1YYJIK9qZGb25ljUiGhTB4T%2BMUOSQFjetiWUoOJc5Q3Jz%2FXJbiTAMTST39MhdbCgiMgfrc8OGKN5DOVbex33Z7dn0xf%2FOCkSqurhLaG08efKQBdhLNS0RlE9hbg9yZ2ywwtQIF39fI6A7eeH0T11a5HMlvm51u4rAffPHRuEJfwJoIuj%2F2s3QzDg7%2FWeBjqmAbnPOlGfysjrDdvHyG7HVnaX02kdG%2BI3Q4PFOO4Mjaa3ocpjcfPT70%2BZ5a%2FSv5vP0jDLGrLToeM9%2BAUlNepptICRu23a1tLGW4ri0twPA%2FZ4JDTtUUUgdblyG8bKpcUTNp4oOsdmLLBz3FVyr4c2xQbDZSu2zYOtoOxB18W0AC6kIbsMWVU55Bf0mBhPeBWxGrtM4Kw1SgHHlt%2F8vetQi2OwtUcg08c%3D&amp;X-Amz-SignedHeaders&#x3D;host&amp;X-Amz-Signature&#x3D;d06dfa41550003359f2aabc8006063a80dfd806a13a54d244024946a76aa9abc&quot;</example>
        [DataMember(Name = "barcode_url", EmitDefaultValue = false)]
        public string BarcodeUrl { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets ServiceName
        /// </summary>
        /// <example>&quot;OxxoPay&quot;</example>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or Sets Store
        /// </summary>
        /// <example>&quot;10MON50EDI&quot;</example>
        [DataMember(Name = "store", EmitDefaultValue = true)]
        public string Store { get; set; }

        /// <summary>
        /// Gets or Sets StoreName
        /// </summary>
        /// <example>&quot;OXXO&quot;</example>
        [DataMember(Name = "store_name", EmitDefaultValue = false)]
        public string StoreName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeDataPaymentMethodCashResponse {\n");
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
            return this.Equals(input as ChargeDataPaymentMethodCashResponse);
        }

        /// <summary>
        /// Returns true if ChargeDataPaymentMethodCashResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeDataPaymentMethodCashResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeDataPaymentMethodCashResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
