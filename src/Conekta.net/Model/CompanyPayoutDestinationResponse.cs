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
    /// Company payout destination model
    /// </summary>
    [DataContract(Name = "company_payout_destination_response")]
    public partial class CompanyPayoutDestinationResponse : IEquatable<CompanyPayoutDestinationResponse>, IValidatableObject
    {
        /// <summary>
        /// The resource&#39;s type
        /// </summary>
        /// <value>The resource&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum PayoutDestination for value: payout_destination
            /// </summary>
            [EnumMember(Value = "payout_destination")]
            PayoutDestination = 1

        }


        /// <summary>
        /// The resource&#39;s type
        /// </summary>
        /// <value>The resource&#39;s type</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Type of the payout destination
        /// </summary>
        /// <value>Type of the payout destination</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: bank_account
            /// </summary>
            [EnumMember(Value = "bank_account")]
            BankAccount = 1

        }


        /// <summary>
        /// Type of the payout destination
        /// </summary>
        /// <value>Type of the payout destination</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyPayoutDestinationResponse" /> class.
        /// </summary>
        /// <param name="_object">The resource&#39;s type.</param>
        /// <param name="currency">currency of the receiving account.</param>
        /// <param name="accountHolderName">Name of the account holder.</param>
        /// <param name="bank">Name of the bank.</param>
        /// <param name="type">Type of the payout destination.</param>
        /// <param name="accountNumber">Account number of the receiving account.</param>
        public CompanyPayoutDestinationResponse(ObjectEnum? _object = default(ObjectEnum?), string currency = default(string), string accountHolderName = default(string), string bank = default(string), TypeEnum? type = default(TypeEnum?), string accountNumber = default(string))
        {
            this.Object = _object;
            this.Currency = currency;
            this.AccountHolderName = accountHolderName;
            this.Bank = bank;
            this.Type = type;
            this.AccountNumber = accountNumber;
        }

        /// <summary>
        /// currency of the receiving account
        /// </summary>
        /// <value>currency of the receiving account</value>
        /// <example>&quot;MXN&quot;</example>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string Currency { get; set; }

        /// <summary>
        /// Name of the account holder
        /// </summary>
        /// <value>Name of the account holder</value>
        /// <example>&quot;Child Company A&quot;</example>
        [DataMember(Name = "account_holder_name", EmitDefaultValue = false)]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// Name of the bank
        /// </summary>
        /// <value>Name of the bank</value>
        /// <example>&quot;BBVA&quot;</example>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public string Bank { get; set; }

        /// <summary>
        /// Account number of the receiving account
        /// </summary>
        /// <value>Account number of the receiving account</value>
        /// <example>&quot;123456789012345678&quot;</example>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyPayoutDestinationResponse {\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AccountHolderName: ").Append(AccountHolderName).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
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
            return this.Equals(input as CompanyPayoutDestinationResponse);
        }

        /// <summary>
        /// Returns true if CompanyPayoutDestinationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyPayoutDestinationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyPayoutDestinationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Object == input.Object ||
                    this.Object.Equals(input.Object)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.AccountHolderName == input.AccountHolderName ||
                    (this.AccountHolderName != null &&
                    this.AccountHolderName.Equals(input.AccountHolderName))
                ) && 
                (
                    this.Bank == input.Bank ||
                    (this.Bank != null &&
                    this.Bank.Equals(input.Bank))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
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
                hashCode = (hashCode * 59) + this.Object.GetHashCode();
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.AccountHolderName != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolderName.GetHashCode();
                }
                if (this.Bank != null)
                {
                    hashCode = (hashCode * 59) + this.Bank.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
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