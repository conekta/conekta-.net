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
    /// Method used to make the transfer.
    /// </summary>
    [DataContract(Name = "transfer_destination_response")]
    public partial class TransferDestinationResponse : IEquatable<TransferDestinationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferDestinationResponse" /> class.
        /// </summary>
        /// <param name="accountHolder">Name of the account holder..</param>
        /// <param name="accountNumber">Account number of the bank account..</param>
        /// <param name="bank">Name of the bank..</param>
        /// <param name="createdAt">Date and time of creation of the transfer..</param>
        /// <param name="id">Unique identifier of the transfer..</param>
        /// <param name="varObject">Object name, which is bank_transfer_payout_method..</param>
        /// <param name="payeeId">Unique identifier of the payee..</param>
        /// <param name="type">Type of the payee..</param>
        public TransferDestinationResponse(string accountHolder = default(string), string accountNumber = default(string), string bank = default(string), long createdAt = default(long), string id = default(string), string varObject = default(string), string payeeId = default(string), string type = default(string))
        {
            this.AccountHolder = accountHolder;
            this.AccountNumber = accountNumber;
            this.Bank = bank;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.VarObject = varObject;
            this.PayeeId = payeeId;
            this.Type = type;
        }

        /// <summary>
        /// Name of the account holder.
        /// </summary>
        /// <value>Name of the account holder.</value>
        /// <example>John Doe</example>
        [DataMember(Name = "account_holder", EmitDefaultValue = false)]
        public string AccountHolder { get; set; }

        /// <summary>
        /// Account number of the bank account.
        /// </summary>
        /// <value>Account number of the bank account.</value>
        /// <example>012180023547896764</example>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Name of the bank.
        /// </summary>
        /// <value>Name of the bank.</value>
        /// <example>BBVA Bancomer</example>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public string Bank { get; set; }

        /// <summary>
        /// Date and time of creation of the transfer.
        /// </summary>
        /// <value>Date and time of creation of the transfer.</value>
        /// <example>1553273553</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Unique identifier of the transfer.
        /// </summary>
        /// <value>Unique identifier of the transfer.</value>
        /// <example>pytmtd_2ide3qwTdDvNBosEC</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Object name, which is bank_transfer_payout_method.
        /// </summary>
        /// <value>Object name, which is bank_transfer_payout_method.</value>
        /// <example>bank_transfer_payout_method</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string VarObject { get; set; }

        /// <summary>
        /// Unique identifier of the payee.
        /// </summary>
        /// <value>Unique identifier of the payee.</value>
        /// <example>payee_2icdDewRxDENBos85</example>
        [DataMember(Name = "payee_id", EmitDefaultValue = false)]
        public string PayeeId { get; set; }

        /// <summary>
        /// Type of the payee.
        /// </summary>
        /// <value>Type of the payee.</value>
        /// <example>BankTransferPayoutMethod</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransferDestinationResponse {\n");
            sb.Append("  AccountHolder: ").Append(AccountHolder).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TransferDestinationResponse);
        }

        /// <summary>
        /// Returns true if TransferDestinationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferDestinationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferDestinationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountHolder == input.AccountHolder ||
                    (this.AccountHolder != null &&
                    this.AccountHolder.Equals(input.AccountHolder))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Bank == input.Bank ||
                    (this.Bank != null &&
                    this.Bank.Equals(input.Bank))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.VarObject == input.VarObject ||
                    (this.VarObject != null &&
                    this.VarObject.Equals(input.VarObject))
                ) && 
                (
                    this.PayeeId == input.PayeeId ||
                    (this.PayeeId != null &&
                    this.PayeeId.Equals(input.PayeeId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AccountHolder != null)
                {
                    hashCode = (hashCode * 59) + this.AccountHolder.GetHashCode();
                }
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                if (this.Bank != null)
                {
                    hashCode = (hashCode * 59) + this.Bank.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                if (this.PayeeId != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeId.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
