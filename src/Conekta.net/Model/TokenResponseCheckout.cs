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
    /// TokenResponseCheckout
    /// </summary>
    [DataContract(Name = "token_response_checkout")]
    public partial class TokenResponseCheckout : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenResponseCheckout" /> class.
        /// </summary>
        /// <param name="allowedPaymentMethods">allowedPaymentMethods.</param>
        /// <param name="canNotExpire">Indicates if the checkout can not expire..</param>
        /// <param name="emailsSent">emailsSent.</param>
        /// <param name="excludeCardNetworks">excludeCardNetworks.</param>
        /// <param name="expiresAt">Date and time when the checkout expires..</param>
        /// <param name="failureUrl">URL to redirect the customer to if the payment process fails..</param>
        /// <param name="force3dsFlow">Indicates if the checkout forces the 3DS flow..</param>
        /// <param name="id">id.</param>
        /// <param name="livemode">livemode.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="monthlyInstallmentsEnabled">Indicates if the checkout allows monthly installments..</param>
        /// <param name="monthlyInstallmentsOptions">List of monthly installments options..</param>
        /// <param name="name">name.</param>
        /// <param name="needsShippingContact">needsShippingContact.</param>
        /// <param name="varObject">Indicates the type of object, in this case checkout..</param>
        /// <param name="onDemandEnabled">Indicates if the checkout allows on demand payments..</param>
        /// <param name="paidPaymentsCount">Number of payments that have been paid..</param>
        /// <param name="recurrent">Indicates if the checkout is recurrent..</param>
        /// <param name="smsSent">smsSent.</param>
        /// <param name="startsAt">Date and time when the checkout starts..</param>
        /// <param name="status">Status of the checkout..</param>
        /// <param name="successUrl">URL to redirect the customer to after the payment process is completed..</param>
        /// <param name="type">Type of checkout..</param>
        public TokenResponseCheckout(List<string> allowedPaymentMethods = default(List<string>), bool canNotExpire = default(bool), int emailsSent = default(int), List<string> excludeCardNetworks = default(List<string>), long expiresAt = default(long), string failureUrl = default(string), bool force3dsFlow = default(bool), string id = default(string), bool livemode = default(bool), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), bool monthlyInstallmentsEnabled = default(bool), List<int> monthlyInstallmentsOptions = default(List<int>), string name = default(string), bool needsShippingContact = default(bool), string varObject = default(string), bool onDemandEnabled = default(bool), int paidPaymentsCount = default(int), bool recurrent = default(bool), int smsSent = default(int), long startsAt = default(long), string status = default(string), string successUrl = default(string), string type = default(string))
        {
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.CanNotExpire = canNotExpire;
            this.EmailsSent = emailsSent;
            this.ExcludeCardNetworks = excludeCardNetworks;
            this.ExpiresAt = expiresAt;
            this.FailureUrl = failureUrl;
            this.Force3dsFlow = force3dsFlow;
            this.Id = id;
            this.Livemode = livemode;
            this.Metadata = metadata;
            this.MonthlyInstallmentsEnabled = monthlyInstallmentsEnabled;
            this.MonthlyInstallmentsOptions = monthlyInstallmentsOptions;
            this.Name = name;
            this.NeedsShippingContact = needsShippingContact;
            this.VarObject = varObject;
            this.OnDemandEnabled = onDemandEnabled;
            this.PaidPaymentsCount = paidPaymentsCount;
            this.Recurrent = recurrent;
            this.SmsSent = smsSent;
            this.StartsAt = startsAt;
            this.Status = status;
            this.SuccessUrl = successUrl;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets AllowedPaymentMethods
        /// </summary>
        [DataMember(Name = "allowed_payment_methods", EmitDefaultValue = false)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// Indicates if the checkout can not expire.
        /// </summary>
        /// <value>Indicates if the checkout can not expire.</value>
        /// <example>false</example>
        [DataMember(Name = "can_not_expire", EmitDefaultValue = true)]
        public bool CanNotExpire { get; set; }

        /// <summary>
        /// Gets or Sets EmailsSent
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "emails_sent", EmitDefaultValue = false)]
        public int EmailsSent { get; set; }

        /// <summary>
        /// Gets or Sets ExcludeCardNetworks
        /// </summary>
        [DataMember(Name = "exclude_card_networks", EmitDefaultValue = false)]
        public List<string> ExcludeCardNetworks { get; set; }

        /// <summary>
        /// Date and time when the checkout expires.
        /// </summary>
        /// <value>Date and time when the checkout expires.</value>
        /// <example>1675715413</example>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// URL to redirect the customer to if the payment process fails.
        /// </summary>
        /// <value>URL to redirect the customer to if the payment process fails.</value>
        /// <example>https://example.com/failure</example>
        [DataMember(Name = "failure_url", EmitDefaultValue = false)]
        public string FailureUrl { get; set; }

        /// <summary>
        /// Indicates if the checkout forces the 3DS flow.
        /// </summary>
        /// <value>Indicates if the checkout forces the 3DS flow.</value>
        /// <example>false</example>
        [DataMember(Name = "force_3ds_flow", EmitDefaultValue = true)]
        public bool Force3dsFlow { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>524f9d2f-8c2e-4e64-a33d-6006711a91bd</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        /// <example>{&quot;key&quot;:&quot;value&quot;}</example>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Indicates if the checkout allows monthly installments.
        /// </summary>
        /// <value>Indicates if the checkout allows monthly installments.</value>
        /// <example>false</example>
        [DataMember(Name = "monthly_installments_enabled", EmitDefaultValue = true)]
        public bool MonthlyInstallmentsEnabled { get; set; }

        /// <summary>
        /// List of monthly installments options.
        /// </summary>
        /// <value>List of monthly installments options.</value>
        [DataMember(Name = "monthly_installments_options", EmitDefaultValue = false)]
        public List<int> MonthlyInstallmentsOptions { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>tok-2toNoPZpJgRU4PvgZ</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NeedsShippingContact
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "needs_shipping_contact", EmitDefaultValue = true)]
        public bool NeedsShippingContact { get; set; }

        /// <summary>
        /// Indicates the type of object, in this case checkout.
        /// </summary>
        /// <value>Indicates the type of object, in this case checkout.</value>
        /// <example>checkout</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string VarObject { get; set; }

        /// <summary>
        /// Indicates if the checkout allows on demand payments.
        /// </summary>
        /// <value>Indicates if the checkout allows on demand payments.</value>
        /// <example>false</example>
        [DataMember(Name = "on_demand_enabled", EmitDefaultValue = true)]
        public bool OnDemandEnabled { get; set; }

        /// <summary>
        /// Number of payments that have been paid.
        /// </summary>
        /// <value>Number of payments that have been paid.</value>
        /// <example>0</example>
        [DataMember(Name = "paid_payments_count", EmitDefaultValue = false)]
        public int PaidPaymentsCount { get; set; }

        /// <summary>
        /// Indicates if the checkout is recurrent.
        /// </summary>
        /// <value>Indicates if the checkout is recurrent.</value>
        /// <example>false</example>
        [DataMember(Name = "recurrent", EmitDefaultValue = true)]
        public bool Recurrent { get; set; }

        /// <summary>
        /// Gets or Sets SmsSent
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "sms_sent", EmitDefaultValue = false)]
        public int SmsSent { get; set; }

        /// <summary>
        /// Date and time when the checkout starts.
        /// </summary>
        /// <value>Date and time when the checkout starts.</value>
        /// <example>1675715413</example>
        [DataMember(Name = "starts_at", EmitDefaultValue = false)]
        public long StartsAt { get; set; }

        /// <summary>
        /// Status of the checkout.
        /// </summary>
        /// <value>Status of the checkout.</value>
        /// <example>Issued</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// URL to redirect the customer to after the payment process is completed.
        /// </summary>
        /// <value>URL to redirect the customer to after the payment process is completed.</value>
        /// <example>https://example.com/success</example>
        [DataMember(Name = "success_url", EmitDefaultValue = false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Type of checkout.
        /// </summary>
        /// <value>Type of checkout.</value>
        /// <example>Integration</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenResponseCheckout {\n");
            sb.Append("  AllowedPaymentMethods: ").Append(AllowedPaymentMethods).Append("\n");
            sb.Append("  CanNotExpire: ").Append(CanNotExpire).Append("\n");
            sb.Append("  EmailsSent: ").Append(EmailsSent).Append("\n");
            sb.Append("  ExcludeCardNetworks: ").Append(ExcludeCardNetworks).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  FailureUrl: ").Append(FailureUrl).Append("\n");
            sb.Append("  Force3dsFlow: ").Append(Force3dsFlow).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MonthlyInstallmentsEnabled: ").Append(MonthlyInstallmentsEnabled).Append("\n");
            sb.Append("  MonthlyInstallmentsOptions: ").Append(MonthlyInstallmentsOptions).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NeedsShippingContact: ").Append(NeedsShippingContact).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  OnDemandEnabled: ").Append(OnDemandEnabled).Append("\n");
            sb.Append("  PaidPaymentsCount: ").Append(PaidPaymentsCount).Append("\n");
            sb.Append("  Recurrent: ").Append(Recurrent).Append("\n");
            sb.Append("  SmsSent: ").Append(SmsSent).Append("\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
