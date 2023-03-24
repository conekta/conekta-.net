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
    /// [Checkout](https://developers.conekta.com/reference/checkout) details 
    /// </summary>
    [DataContract(Name = "checkout_request")]
    public partial class CheckoutRequest : IEquatable<CheckoutRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutRequest" /> class.
        /// </summary>
        /// <param name="allowedPaymentMethods">Are the payment methods available for this link (required).</param>
        /// <param name="expiresAt">Unix timestamp of checkout expiration.</param>
        /// <param name="failureUrl">Redirection url back to the site in case of failed payment, applies only to HostedPayment..</param>
        /// <param name="monthlyInstallmentsEnabled">monthlyInstallmentsEnabled.</param>
        /// <param name="monthlyInstallmentsOptions">monthlyInstallmentsOptions.</param>
        /// <param name="name">Reason for payment.</param>
        /// <param name="onDemandEnabled">onDemandEnabled.</param>
        /// <param name="successUrl">Redirection url back to the site in case of successful payment, applies only to HostedPayment.</param>
        /// <param name="type">This field represents the type of checkout.</param>
        public CheckoutRequest(List<string> allowedPaymentMethods = default(List<string>), long expiresAt = default(long), string failureUrl = default(string), bool monthlyInstallmentsEnabled = default(bool), List<int> monthlyInstallmentsOptions = default(List<int>), string name = default(string), bool onDemandEnabled = default(bool), string successUrl = default(string), string type = default(string))
        {
            // to ensure "allowedPaymentMethods" is required (not null)
            if (allowedPaymentMethods == null)
            {
                throw new ArgumentNullException("allowedPaymentMethods is a required property for CheckoutRequest and cannot be null");
            }
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.ExpiresAt = expiresAt;
            this.FailureUrl = failureUrl;
            this.MonthlyInstallmentsEnabled = monthlyInstallmentsEnabled;
            this.MonthlyInstallmentsOptions = monthlyInstallmentsOptions;
            this.Name = name;
            this.OnDemandEnabled = onDemandEnabled;
            this.SuccessUrl = successUrl;
            this.Type = type;
        }

        /// <summary>
        /// Are the payment methods available for this link
        /// </summary>
        /// <value>Are the payment methods available for this link</value>
        [DataMember(Name = "allowed_payment_methods", IsRequired = true, EmitDefaultValue = true)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// Unix timestamp of checkout expiration
        /// </summary>
        /// <value>Unix timestamp of checkout expiration</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// Redirection url back to the site in case of failed payment, applies only to HostedPayment.
        /// </summary>
        /// <value>Redirection url back to the site in case of failed payment, applies only to HostedPayment.</value>
        [DataMember(Name = "failure_url", EmitDefaultValue = false)]
        public string FailureUrl { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyInstallmentsEnabled
        /// </summary>
        [DataMember(Name = "monthly_installments_enabled", EmitDefaultValue = true)]
        public bool MonthlyInstallmentsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyInstallmentsOptions
        /// </summary>
        [DataMember(Name = "monthly_installments_options", EmitDefaultValue = false)]
        public List<int> MonthlyInstallmentsOptions { get; set; }

        /// <summary>
        /// Reason for payment
        /// </summary>
        /// <value>Reason for payment</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets OnDemandEnabled
        /// </summary>
        [DataMember(Name = "on_demand_enabled", EmitDefaultValue = true)]
        public bool OnDemandEnabled { get; set; }

        /// <summary>
        /// Redirection url back to the site in case of successful payment, applies only to HostedPayment
        /// </summary>
        /// <value>Redirection url back to the site in case of successful payment, applies only to HostedPayment</value>
        [DataMember(Name = "success_url", EmitDefaultValue = false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// This field represents the type of checkout
        /// </summary>
        /// <value>This field represents the type of checkout</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutRequest {\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  FailureUrl: ").Append(FailureUrl).Append("\n");
            sb.Append("  MonthlyInstallmentsEnabled: ").Append(MonthlyInstallmentsEnabled).Append("\n");
            sb.Append("  MonthlyInstallmentsOptions: ").Append(MonthlyInstallmentsOptions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OnDemandEnabled: ").Append(OnDemandEnabled).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
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
            return this.Equals(input as CheckoutRequest);
        }

        /// <summary>
        /// Returns true if CheckoutRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckoutRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckoutRequest input)
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
                    this.FailureUrl == input.FailureUrl ||
                    (this.FailureUrl != null &&
                    this.FailureUrl.Equals(input.FailureUrl))
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
                    this.OnDemandEnabled == input.OnDemandEnabled ||
                    this.OnDemandEnabled.Equals(input.OnDemandEnabled)
                ) && 
                (
                    this.SuccessUrl == input.SuccessUrl ||
                    (this.SuccessUrl != null &&
                    this.SuccessUrl.Equals(input.SuccessUrl))
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
                if (this.FailureUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FailureUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MonthlyInstallmentsEnabled.GetHashCode();
                if (this.MonthlyInstallmentsOptions != null)
                {
                    hashCode = (hashCode * 59) + this.MonthlyInstallmentsOptions.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OnDemandEnabled.GetHashCode();
                if (this.SuccessUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessUrl.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
