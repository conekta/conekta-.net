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
    /// PaymentMethodCard
    /// </summary>
    [DataContract(Name = "payment_method_card")]
    public partial class PaymentMethodCard : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentMethodCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCard" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="accountType">Account type of the card.</param>
        /// <param name="authCode">authCode.</param>
        /// <param name="brand">Brand of the card.</param>
        /// <param name="contractId">Id sent for recurrent charges..</param>
        /// <param name="country">Country of the card.</param>
        /// <param name="expMonth">Expiration month of the card.</param>
        /// <param name="expYear">Expiration year of the card.</param>
        /// <param name="fraudIndicators">fraudIndicators.</param>
        /// <param name="issuer">Issuer of the card.</param>
        /// <param name="last4">Last 4 digits of the card.</param>
        /// <param name="name">Name of the cardholder.</param>
        /// <param name="customerIpAddress">Optional field used to capture the customer&#39;s IP address for fraud prevention and security monitoring purposes.</param>
        public PaymentMethodCard(string type = default(string), string varObject = default(string), string accountType = default(string), string authCode = default(string), string brand = default(string), string contractId = default(string), string country = default(string), string expMonth = default(string), string expYear = default(string), List<Object> fraudIndicators = default(List<Object>), string issuer = default(string), string last4 = default(string), string name = default(string), string customerIpAddress = default(string))
        {
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for PaymentMethodCard and cannot be null");
            }
            this.Object = varObject;
            this.Type = type;
            this.AccountType = accountType;
            this.AuthCode = authCode;
            this.Brand = brand;
            this.ContractId = contractId;
            this.Country = country;
            this.ExpMonth = expMonth;
            this.ExpYear = expYear;
            this.FraudIndicators = fraudIndicators;
            this.Issuer = issuer;
            this.Last4 = last4;
            this.Name = name;
            this.CustomerIpAddress = customerIpAddress;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        /// <example>payment_source</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string Object { get; set; }

        /// <summary>
        /// Account type of the card
        /// </summary>
        /// <value>Account type of the card</value>
        /// <example>Credit</example>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public string AccountType { get; set; }

        /// <summary>
        /// Gets or Sets AuthCode
        /// </summary>
        /// <example>867372</example>
        [DataMember(Name = "auth_code", EmitDefaultValue = false)]
        public string AuthCode { get; set; }

        /// <summary>
        /// Brand of the card
        /// </summary>
        /// <value>Brand of the card</value>
        /// <example>visa</example>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Id sent for recurrent charges.
        /// </summary>
        /// <value>Id sent for recurrent charges.</value>
        /// <example>S781317595</example>
        [DataMember(Name = "contract_id", EmitDefaultValue = false)]
        public string ContractId { get; set; }

        /// <summary>
        /// Country of the card
        /// </summary>
        /// <value>Country of the card</value>
        /// <example>MX</example>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// Expiration month of the card
        /// </summary>
        /// <value>Expiration month of the card</value>
        /// <example>02</example>
        [DataMember(Name = "exp_month", EmitDefaultValue = false)]
        public string ExpMonth { get; set; }

        /// <summary>
        /// Expiration year of the card
        /// </summary>
        /// <value>Expiration year of the card</value>
        /// <example>2026</example>
        [DataMember(Name = "exp_year", EmitDefaultValue = false)]
        public string ExpYear { get; set; }

        /// <summary>
        /// Gets or Sets FraudIndicators
        /// </summary>
        [DataMember(Name = "fraud_indicators", EmitDefaultValue = false)]
        public List<Object> FraudIndicators { get; set; }

        /// <summary>
        /// Issuer of the card
        /// </summary>
        /// <value>Issuer of the card</value>
        /// <example>BANAMEX</example>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// Last 4 digits of the card
        /// </summary>
        /// <value>Last 4 digits of the card</value>
        /// <example>4242</example>
        [DataMember(Name = "last4", EmitDefaultValue = false)]
        public string Last4 { get; set; }

        /// <summary>
        /// Name of the cardholder
        /// </summary>
        /// <value>Name of the cardholder</value>
        /// <example>Fulanito Perez</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Optional field used to capture the customer&#39;s IP address for fraud prevention and security monitoring purposes
        /// </summary>
        /// <value>Optional field used to capture the customer&#39;s IP address for fraud prevention and security monitoring purposes</value>
        /// <example>0.0.0.0</example>
        [DataMember(Name = "customer_ip_address", EmitDefaultValue = false)]
        public string CustomerIpAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodCard {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AuthCode: ").Append(AuthCode).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
            sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
            sb.Append("  FraudIndicators: ").Append(FraudIndicators).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  Last4: ").Append(Last4).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CustomerIpAddress: ").Append(CustomerIpAddress).Append("\n");
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
