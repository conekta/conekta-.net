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
    /// TokenCard
    /// </summary>
    [DataContract(Name = "token_card")]
    public partial class TokenCard : IEquatable<TokenCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenCard" /> class.
        /// </summary>
        /// <param name="cvc">It is a value that allows identifying the security code of the card. (required).</param>
        /// <param name="deviceFingerprint">It is a value that allows identifying the device fingerprint..</param>
        /// <param name="expMonth">It is a value that allows identifying the expiration month of the card. (required).</param>
        /// <param name="expYear">It is a value that allows identifying the expiration year of the card. (required).</param>
        /// <param name="name">It is a value that allows identifying the name of the cardholder. (required).</param>
        /// <param name="number">It is a value that allows identifying the number of the card. (required).</param>
        public TokenCard(string cvc = default(string), string deviceFingerprint = default(string), string expMonth = default(string), string expYear = default(string), string name = default(string), string number = default(string))
        {
            // to ensure "cvc" is required (not null)
            if (cvc == null)
            {
                throw new ArgumentNullException("cvc is a required property for TokenCard and cannot be null");
            }
            this.Cvc = cvc;
            // to ensure "expMonth" is required (not null)
            if (expMonth == null)
            {
                throw new ArgumentNullException("expMonth is a required property for TokenCard and cannot be null");
            }
            this.ExpMonth = expMonth;
            // to ensure "expYear" is required (not null)
            if (expYear == null)
            {
                throw new ArgumentNullException("expYear is a required property for TokenCard and cannot be null");
            }
            this.ExpYear = expYear;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TokenCard and cannot be null");
            }
            this.Name = name;
            // to ensure "number" is required (not null)
            if (number == null)
            {
                throw new ArgumentNullException("number is a required property for TokenCard and cannot be null");
            }
            this.Number = number;
            this.DeviceFingerprint = deviceFingerprint;
        }

        /// <summary>
        /// It is a value that allows identifying the security code of the card.
        /// </summary>
        /// <value>It is a value that allows identifying the security code of the card.</value>
        /// <example>&quot;123&quot;</example>
        [DataMember(Name = "cvc", IsRequired = true, EmitDefaultValue = true)]
        public string Cvc { get; set; }

        /// <summary>
        /// It is a value that allows identifying the device fingerprint.
        /// </summary>
        /// <value>It is a value that allows identifying the device fingerprint.</value>
        /// <example>&quot;zptcxk4p6w1ijwz85snf1l3bqe5g09ie&quot;</example>
        [DataMember(Name = "device_fingerprint", EmitDefaultValue = false)]
        public string DeviceFingerprint { get; set; }

        /// <summary>
        /// It is a value that allows identifying the expiration month of the card.
        /// </summary>
        /// <value>It is a value that allows identifying the expiration month of the card.</value>
        /// <example>&quot;12&quot;</example>
        [DataMember(Name = "exp_month", IsRequired = true, EmitDefaultValue = true)]
        public string ExpMonth { get; set; }

        /// <summary>
        /// It is a value that allows identifying the expiration year of the card.
        /// </summary>
        /// <value>It is a value that allows identifying the expiration year of the card.</value>
        /// <example>&quot;26&quot;</example>
        [DataMember(Name = "exp_year", IsRequired = true, EmitDefaultValue = true)]
        public string ExpYear { get; set; }

        /// <summary>
        /// It is a value that allows identifying the name of the cardholder.
        /// </summary>
        /// <value>It is a value that allows identifying the name of the cardholder.</value>
        /// <example>&quot;Miguel&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// It is a value that allows identifying the number of the card.
        /// </summary>
        /// <value>It is a value that allows identifying the number of the card.</value>
        /// <example>&quot;4242424242424242&quot;</example>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = true)]
        public string Number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenCard {\n");
            sb.Append("  Cvc: ").Append(Cvc).Append("\n");
            sb.Append("  DeviceFingerprint: ").Append(DeviceFingerprint).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
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
            return this.Equals(input as TokenCard);
        }

        /// <summary>
        /// Returns true if TokenCard instances are equal
        /// </summary>
        /// <param name="input">Instance of TokenCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenCard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Cvc == input.Cvc ||
                    (this.Cvc != null &&
                    this.Cvc.Equals(input.Cvc))
                ) && 
                (
                    this.DeviceFingerprint == input.DeviceFingerprint ||
                    (this.DeviceFingerprint != null &&
                    this.DeviceFingerprint.Equals(input.DeviceFingerprint))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
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
                if (this.Cvc != null)
                {
                    hashCode = (hashCode * 59) + this.Cvc.GetHashCode();
                }
                if (this.DeviceFingerprint != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceFingerprint.GetHashCode();
                }
                if (this.ExpMonth != null)
                {
                    hashCode = (hashCode * 59) + this.ExpMonth.GetHashCode();
                }
                if (this.ExpYear != null)
                {
                    hashCode = (hashCode * 59) + this.ExpYear.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
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
            // Cvc (string) maxLength
            if (this.Cvc != null && this.Cvc.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cvc, length must be less than 4.", new [] { "Cvc" });
            }

            // ExpMonth (string) maxLength
            if (this.ExpMonth != null && this.ExpMonth.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpMonth, length must be less than 2.", new [] { "ExpMonth" });
            }

            // ExpYear (string) maxLength
            if (this.ExpYear != null && this.ExpYear.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpYear, length must be less than 2.", new [] { "ExpYear" });
            }

            yield break;
        }
    }

}
