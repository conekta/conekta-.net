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
    /// It is a sub-resource of the Order model that can be stipulated in order to configure its corresponding checkout
    /// </summary>
    [DataContract(Name = "checkout")]
    public partial class Checkout : IEquatable<Checkout>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Checkout" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Checkout() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Checkout" /> class.
        /// </summary>
        /// <param name="allowedPaymentMethods">Those are the payment methods that will be available for the link (required).</param>
        /// <param name="expiresAt">It is the time when the link will expire. It is expressed in seconds since the Unix epoch. The valid range is from 2 to 365 days (the valid range will be taken from the next day of the creation date at 00:01 hrs)  (required).</param>
        /// <param name="monthlyInstallmentsEnabled">This flag allows you to specify if months without interest will be active..</param>
        /// <param name="monthlyInstallmentsOptions">This field allows you to specify the number of months without interest..</param>
        /// <param name="name">Reason for charge (required).</param>
        /// <param name="needsShippingContact">This flag allows you to fill in the shipping information at checkout..</param>
        /// <param name="onDemandEnabled">onDemandEnabled.</param>
        /// <param name="orderTemplate">orderTemplate (required).</param>
        /// <param name="paymentsLimitCount">paymentsLimitCount.</param>
        /// <param name="recurrent">false: single use. true: multiple payments (required).</param>
        /// <param name="type">type (required).</param>
        public Checkout(List<string> allowedPaymentMethods = default(List<string>), long expiresAt = default(long), bool monthlyInstallmentsEnabled = default(bool), List<int> monthlyInstallmentsOptions = default(List<int>), string name = default(string), bool needsShippingContact = default(bool), bool? onDemandEnabled = default(bool?), CheckoutOrderTemplate orderTemplate = default(CheckoutOrderTemplate), int paymentsLimitCount = default(int), bool recurrent = default(bool), string type = default(string))
        {
            // to ensure "allowedPaymentMethods" is required (not null)
            if (allowedPaymentMethods == null)
            {
                throw new ArgumentNullException("allowedPaymentMethods is a required property for Checkout and cannot be null");
            }
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.ExpiresAt = expiresAt;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for Checkout and cannot be null");
            }
            this.Name = name;
            // to ensure "orderTemplate" is required (not null)
            if (orderTemplate == null)
            {
                throw new ArgumentNullException("orderTemplate is a required property for Checkout and cannot be null");
            }
            this.OrderTemplate = orderTemplate;
            this.Recurrent = recurrent;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Checkout and cannot be null");
            }
            this.Type = type;
            this.MonthlyInstallmentsEnabled = monthlyInstallmentsEnabled;
            this.MonthlyInstallmentsOptions = monthlyInstallmentsOptions;
            this.NeedsShippingContact = needsShippingContact;
            this.OnDemandEnabled = onDemandEnabled;
            this.PaymentsLimitCount = paymentsLimitCount;
        }

        /// <summary>
        /// Those are the payment methods that will be available for the link
        /// </summary>
        /// <value>Those are the payment methods that will be available for the link</value>
        [DataMember(Name = "allowed_payment_methods", IsRequired = true, EmitDefaultValue = true)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// It is the time when the link will expire. It is expressed in seconds since the Unix epoch. The valid range is from 2 to 365 days (the valid range will be taken from the next day of the creation date at 00:01 hrs) 
        /// </summary>
        /// <value>It is the time when the link will expire. It is expressed in seconds since the Unix epoch. The valid range is from 2 to 365 days (the valid range will be taken from the next day of the creation date at 00:01 hrs) </value>
        /// <example>1680397724</example>
        [DataMember(Name = "expires_at", IsRequired = true, EmitDefaultValue = true)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// This flag allows you to specify if months without interest will be active.
        /// </summary>
        /// <value>This flag allows you to specify if months without interest will be active.</value>
        /// <example>true</example>
        [DataMember(Name = "monthly_installments_enabled", EmitDefaultValue = true)]
        public bool MonthlyInstallmentsEnabled { get; set; }

        /// <summary>
        /// This field allows you to specify the number of months without interest.
        /// </summary>
        /// <value>This field allows you to specify the number of months without interest.</value>
        [DataMember(Name = "monthly_installments_options", EmitDefaultValue = false)]
        public List<int> MonthlyInstallmentsOptions { get; set; }

        /// <summary>
        /// Reason for charge
        /// </summary>
        /// <value>Reason for charge</value>
        /// <example>&quot;Payment Link Name 1594138857&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// This flag allows you to fill in the shipping information at checkout.
        /// </summary>
        /// <value>This flag allows you to fill in the shipping information at checkout.</value>
        /// <example>false</example>
        [DataMember(Name = "needs_shipping_contact", EmitDefaultValue = true)]
        public bool NeedsShippingContact { get; set; }

        /// <summary>
        /// Gets or Sets OnDemandEnabled
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "on_demand_enabled", EmitDefaultValue = true)]
        public bool? OnDemandEnabled { get; set; }

        /// <summary>
        /// Gets or Sets OrderTemplate
        /// </summary>
        [DataMember(Name = "order_template", IsRequired = true, EmitDefaultValue = true)]
        public CheckoutOrderTemplate OrderTemplate { get; set; }

        /// <summary>
        /// Gets or Sets PaymentsLimitCount
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "payments_limit_count", EmitDefaultValue = false)]
        public int PaymentsLimitCount { get; set; }

        /// <summary>
        /// false: single use. true: multiple payments
        /// </summary>
        /// <value>false: single use. true: multiple payments</value>
        /// <example>false</example>
        [DataMember(Name = "recurrent", IsRequired = true, EmitDefaultValue = true)]
        public bool Recurrent { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>&quot;PaymentLink&quot;</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Checkout {\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  MonthlyInstallmentsEnabled: ").Append(MonthlyInstallmentsEnabled).Append("\n");
            sb.Append("  MonthlyInstallmentsOptions: ").Append(MonthlyInstallmentsOptions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NeedsShippingContact: ").Append(NeedsShippingContact).Append("\n");
            sb.Append("  OnDemandEnabled: ").Append(OnDemandEnabled).Append("\n");
            sb.Append("  OrderTemplate: ").Append(OrderTemplate).Append("\n");
            sb.Append("  PaymentsLimitCount: ").Append(PaymentsLimitCount).Append("\n");
            sb.Append("  Recurrent: ").Append(Recurrent).Append("\n");
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
            return this.Equals(input as Checkout);
        }

        /// <summary>
        /// Returns true if Checkout instances are equal
        /// </summary>
        /// <param name="input">Instance of Checkout to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Checkout input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowedPaymentMethods == input.AllowedPaymentMethods ||
                    this.AllowedPaymentMethods != null &&
                    input.AllowedPaymentMethods != null &&
                    this.AllowedPaymentMethods.SequenceEqual(input.AllowedPaymentMethods)
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
                ) && 
                (
                    this.MonthlyInstallmentsEnabled == input.MonthlyInstallmentsEnabled ||
                    this.MonthlyInstallmentsEnabled.Equals(input.MonthlyInstallmentsEnabled)
                ) && 
                (
                    this.MonthlyInstallmentsOptions == input.MonthlyInstallmentsOptions ||
                    this.MonthlyInstallmentsOptions != null &&
                    input.MonthlyInstallmentsOptions != null &&
                    this.MonthlyInstallmentsOptions.SequenceEqual(input.MonthlyInstallmentsOptions)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NeedsShippingContact == input.NeedsShippingContact ||
                    this.NeedsShippingContact.Equals(input.NeedsShippingContact)
                ) && 
                (
                    this.OnDemandEnabled == input.OnDemandEnabled ||
                    (this.OnDemandEnabled != null &&
                    this.OnDemandEnabled.Equals(input.OnDemandEnabled))
                ) && 
                (
                    this.OrderTemplate == input.OrderTemplate ||
                    (this.OrderTemplate != null &&
                    this.OrderTemplate.Equals(input.OrderTemplate))
                ) && 
                (
                    this.PaymentsLimitCount == input.PaymentsLimitCount ||
                    this.PaymentsLimitCount.Equals(input.PaymentsLimitCount)
                ) && 
                (
                    this.Recurrent == input.Recurrent ||
                    this.Recurrent.Equals(input.Recurrent)
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
                if (this.AllowedPaymentMethods != null)
                {
                    hashCode = (hashCode * 59) + this.AllowedPaymentMethods.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                hashCode = (hashCode * 59) + this.MonthlyInstallmentsEnabled.GetHashCode();
                if (this.MonthlyInstallmentsOptions != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyInstallmentsOptions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NeedsShippingContact.GetHashCode();
                if (this.OnDemandEnabled != null)
                {
                    hashCode = (hashCode * 59) + this.OnDemandEnabled.GetHashCode();
                }
                if (this.OrderTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.OrderTemplate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PaymentsLimitCount.GetHashCode();
                hashCode = (hashCode * 59) + this.Recurrent.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
