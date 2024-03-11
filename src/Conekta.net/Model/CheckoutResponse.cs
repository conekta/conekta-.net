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
    /// checkout response
    /// </summary>
    [DataContract(Name = "checkout_response")]
    public partial class CheckoutResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckoutResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckoutResponse" /> class.
        /// </summary>
        /// <param name="allowedPaymentMethods">allowedPaymentMethods.</param>
        /// <param name="canNotExpire">canNotExpire.</param>
        /// <param name="emailsSent">emailsSent.</param>
        /// <param name="excludeCardNetworks">excludeCardNetworks.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="failureUrl">failureUrl.</param>
        /// <param name="force3dsFlow">force3dsFlow.</param>
        /// <param name="id">id (required).</param>
        /// <param name="livemode">livemode (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="monthlyInstallmentsEnabled">monthlyInstallmentsEnabled.</param>
        /// <param name="monthlyInstallmentsOptions">monthlyInstallmentsOptions.</param>
        /// <param name="name">Reason for charge (required).</param>
        /// <param name="needsShippingContact">needsShippingContact.</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="paidPaymentsCount">paidPaymentsCount.</param>
        /// <param name="paymentsLimitCount">paymentsLimitCount.</param>
        /// <param name="recurrent">recurrent.</param>
        /// <param name="slug">slug.</param>
        /// <param name="smsSent">smsSent.</param>
        /// <param name="startsAt">startsAt.</param>
        /// <param name="status">status.</param>
        /// <param name="successUrl">successUrl.</param>
        /// <param name="type">type.</param>
        /// <param name="url">url.</param>
        public CheckoutResponse(List<string> allowedPaymentMethods = default(List<string>), bool canNotExpire = default(bool), int emailsSent = default(int), List<Object> excludeCardNetworks = default(List<Object>), long expiresAt = default(long), string failureUrl = default(string), bool force3dsFlow = default(bool), string id = default(string), bool livemode = default(bool), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), bool monthlyInstallmentsEnabled = default(bool), List<int> monthlyInstallmentsOptions = default(List<int>), string name = default(string), bool needsShippingContact = default(bool), string varObject = default(string), int paidPaymentsCount = default(int), int? paymentsLimitCount = default(int?), bool recurrent = default(bool), string slug = default(string), int smsSent = default(int), int startsAt = default(int), string status = default(string), string successUrl = default(string), string type = default(string), string url = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CheckoutResponse and cannot be null");
            }
            this.Id = id;
            this.Livemode = livemode;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CheckoutResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for CheckoutResponse and cannot be null");
            }
            this.VarObject = varObject;
            this.AllowedPaymentMethods = allowedPaymentMethods;
            this.CanNotExpire = canNotExpire;
            this.EmailsSent = emailsSent;
            this.ExcludeCardNetworks = excludeCardNetworks;
            this.ExpiresAt = expiresAt;
            this.FailureUrl = failureUrl;
            this.Force3dsFlow = force3dsFlow;
            this.Metadata = metadata;
            this.MonthlyInstallmentsEnabled = monthlyInstallmentsEnabled;
            this.MonthlyInstallmentsOptions = monthlyInstallmentsOptions;
            this.NeedsShippingContact = needsShippingContact;
            this.PaidPaymentsCount = paidPaymentsCount;
            this.PaymentsLimitCount = paymentsLimitCount;
            this.Recurrent = recurrent;
            this.Slug = slug;
            this.SmsSent = smsSent;
            this.StartsAt = startsAt;
            this.Status = status;
            this.SuccessUrl = successUrl;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets AllowedPaymentMethods
        /// </summary>
        /// <example>[&quot;cash&quot;,&quot;card&quot;,&quot;bank_transfer&quot;]</example>
        [DataMember(Name = "allowed_payment_methods", EmitDefaultValue = false)]
        public List<string> AllowedPaymentMethods { get; set; }

        /// <summary>
        /// Gets or Sets CanNotExpire
        /// </summary>
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
        public List<Object> ExcludeCardNetworks { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        /// <example>1680397724</example>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public long ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets FailureUrl
        /// </summary>
        /// <example>https://pay.conekta.com/failure</example>
        [DataMember(Name = "failure_url", EmitDefaultValue = false)]
        public string FailureUrl { get; set; }

        /// <summary>
        /// Gets or Sets Force3dsFlow
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "force_3ds_flow", EmitDefaultValue = true)]
        public bool Force3dsFlow { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>b0bf16c4-18b9-445e-ba24-01604f329dbf</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Livemode
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "livemode", IsRequired = true, EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        /// <example>{&quot;key&quot;:&quot;value&quot;}</example>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyInstallmentsEnabled
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "monthly_installments_enabled", EmitDefaultValue = true)]
        public bool MonthlyInstallmentsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets MonthlyInstallmentsOptions
        /// </summary>
        /// <example>[3,6,12]</example>
        [DataMember(Name = "monthly_installments_options", EmitDefaultValue = false)]
        public List<int> MonthlyInstallmentsOptions { get; set; }

        /// <summary>
        /// Reason for charge
        /// </summary>
        /// <value>Reason for charge</value>
        /// <example>Payment Link Name 1594138857</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NeedsShippingContact
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "needs_shipping_contact", EmitDefaultValue = true)]
        public bool NeedsShippingContact { get; set; }

        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        /// <example>checkout</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// Gets or Sets PaidPaymentsCount
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "paid_payments_count", EmitDefaultValue = false)]
        public int PaidPaymentsCount { get; set; }

        /// <summary>
        /// Gets or Sets PaymentsLimitCount
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "payments_limit_count", EmitDefaultValue = true)]
        public int? PaymentsLimitCount { get; set; }

        /// <summary>
        /// Gets or Sets Recurrent
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "recurrent", EmitDefaultValue = true)]
        public bool Recurrent { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        /// <example>b0bf16c418b9445eba2401604f329dbf</example>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets SmsSent
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "sms_sent", EmitDefaultValue = false)]
        public int SmsSent { get; set; }

        /// <summary>
        /// Gets or Sets StartsAt
        /// </summary>
        /// <example>1677650400</example>
        [DataMember(Name = "starts_at", EmitDefaultValue = false)]
        public int StartsAt { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        /// <example>Issued</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SuccessUrl
        /// </summary>
        /// <example>https://pay.conekta.com/success</example>
        [DataMember(Name = "success_url", EmitDefaultValue = false)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>PaymentLink</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        /// <example>https://pay.conekta.com/link/b0bf16c418b9445eba2401604f329dbf</example>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckoutResponse {\n");
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
            sb.Append("  PaidPaymentsCount: ").Append(PaidPaymentsCount).Append("\n");
            sb.Append("  PaymentsLimitCount: ").Append(PaymentsLimitCount).Append("\n");
            sb.Append("  Recurrent: ").Append(Recurrent).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  SmsSent: ").Append(SmsSent).Append("\n");
            sb.Append("  StartsAt: ").Append(StartsAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
