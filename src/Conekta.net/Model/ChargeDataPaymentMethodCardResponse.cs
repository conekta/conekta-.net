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
    /// use for card responses
    /// </summary>
    [DataContract(Name = "charge_data_payment_method_card_response")]
    public partial class ChargeDataPaymentMethodCardResponse : IEquatable<ChargeDataPaymentMethodCardResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargeDataPaymentMethodCardResponse" /> class.
        /// </summary>
        /// <param name="accountType">accountType.</param>
        /// <param name="authCode">authCode.</param>
        /// <param name="brand">brand.</param>
        /// <param name="country">country.</param>
        /// <param name="expMonth">expMonth.</param>
        /// <param name="expYear">expYear.</param>
        /// <param name="fraudIndicators">fraudIndicators.</param>
        /// <param name="issuer">issuer.</param>
        /// <param name="last4">last4.</param>
        /// <param name="name">name.</param>
        public ChargeDataPaymentMethodCardResponse(string accountType = default(string), string authCode = default(string), string brand = default(string), string country = default(string), string expMonth = default(string), string expYear = default(string), List<Object> fraudIndicators = default(List<Object>), string issuer = default(string), string last4 = default(string), string name = default(string))
        {
            this.AccountType = accountType;
            this.AuthCode = authCode;
            this.Brand = brand;
            this.Country = country;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.FraudIndicators = fraudIndicators;
            this.Issuer = issuer;
            this.Last4 = last4;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or Sets AuthCode
        /// </summary>
        [DataMember(Name = "auth_code", EmitDefaultValue = false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets ExpMonth
        /// </summary>
        [DataMember(Name = "exp_month", EmitDefaultValue = false)]
        public string ExpMonth { get; set; }

        /// <summary>
        /// Gets or Sets ExpYear
        /// </summary>
        [DataMember(Name = "exp_year", EmitDefaultValue = false)]
        public string ExpYear { get; set; }

        /// <summary>
        /// Gets or Sets FraudIndicators
        /// </summary>
        [DataMember(Name = "fraud_indicators", EmitDefaultValue = false)]
        public List<Object> FraudIndicators { get; set; }

        /// <summary>
        /// Gets or Sets Issuer
        /// </summary>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Gets or Sets Last4
        /// </summary>
        [DataMember(Name = "last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargeDataPaymentMethodCardResponse {\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  FraudIndicators: ").Append(FraudIndicators).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as ChargeDataPaymentMethodCardResponse);
        }

        /// <summary>
        /// Returns true if ChargeDataPaymentMethodCardResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargeDataPaymentMethodCardResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargeDataPaymentMethodCardResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountType == input.AccountType ||
                    (this.AccountType != null &&
                    this.AccountType.Equals(input.AccountType))
                ) && 
                (
                    this.AuthCode == input.AuthCode ||
                    (this.AuthCode != null &&
                    this.AuthCode.Equals(input.AuthCode))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.ExpMonth == input.ExpMonth ||
                    (this.ExpMonth != null &&
                    this.ExpMonth.Equals(input.ExpMonth))
                ) && 
                (
                    this.ExpYear == input.ExpYear ||
                    (this.ExpYear != null &&
                    this.ExpYear.Equals(input.ExpYear))
                ) && 
                (
                    this.FraudIndicators == input.FraudIndicators ||
                    this.FraudIndicators != null &&
                    input.FraudIndicators != null &&
                    this.FraudIndicators.SequenceEqual(input.FraudIndicators)
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.Last4 == input.Last4 ||
                    (this.Last4 != null &&
                    this.Last4.Equals(input.Last4))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.AccountType != null)
                {
                    hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                }
                if (this.AuthCode != null)
                {
                    hashCode = (hashCode * 59) + this.AuthCode.GetHashCode();
                }
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.ExpMonth != null)
                {
                    hashCode = (hashCode * 59) + this.ExpMonth.GetHashCode();
                }
                if (this.ExpYear != null)
                {
                    hashCode = (hashCode * 59) + this.ExpYear.GetHashCode();
                }
                if (this.FraudIndicators != null)
                {
                    hashCode = (hashCode * 59) + this.FraudIndicators.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.Last4 != null)
                {
                    hashCode = (hashCode * 59) + this.Last4.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
