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
    /// customer response
    /// </summary>
    [DataContract(Name = "customer_response")]
    public partial class CustomerResponse : IEquatable<CustomerResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerResponse" /> class.
        /// </summary>
        /// <param name="antifraudInfo">antifraudInfo.</param>
        /// <param name="corporate">true if the customer is a company.</param>
        /// <param name="createdAt">Creation date of the object (required).</param>
        /// <param name="customReference">Custom reference.</param>
        /// <param name="defaultFiscalEntityId">defaultFiscalEntityId.</param>
        /// <param name="defaultShippingContactId">defaultShippingContactId.</param>
        /// <param name="defaultPaymentSourceId">defaultPaymentSourceId.</param>
        /// <param name="email">email.</param>
        /// <param name="fiscalEntities">fiscalEntities.</param>
        /// <param name="id">Customer&#39;s ID (required).</param>
        /// <param name="livemode">true if the object exists in live mode or the value false if the object exists in test mode (required).</param>
        /// <param name="name">Customer&#39;s name (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="varObject">varObject (required).</param>
        /// <param name="paymentSources">paymentSources.</param>
        /// <param name="phone">Customer&#39;s phone number.</param>
        /// <param name="shippingContacts">shippingContacts.</param>
        /// <param name="subscription">subscription.</param>
        public CustomerResponse(CustomerAntifraudInfoResponse antifraudInfo = default(CustomerAntifraudInfoResponse), bool corporate = default(bool), long createdAt = default(long), string customReference = default(string), string defaultFiscalEntityId = default(string), string defaultShippingContactId = default(string), string defaultPaymentSourceId = default(string), string email = default(string), CustomerFiscalEntitiesResponse fiscalEntities = default(CustomerFiscalEntitiesResponse), string id = default(string), bool livemode = default(bool), string name = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string varObject = default(string), CustomerPaymentMethodsResponse paymentSources = default(CustomerPaymentMethodsResponse), string phone = default(string), CustomerResponseShippingContacts shippingContacts = default(CustomerResponseShippingContacts), SubscriptionResponse subscription = default(SubscriptionResponse))
        {
            this.CreatedAt = createdAt;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CustomerResponse and cannot be null");
            }
            this.Id = id;
            this.Livemode = livemode;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for CustomerResponse and cannot be null");
            }
            this.Name = name;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for CustomerResponse and cannot be null");
            }
            this.VarObject = varObject;
            this.AntifraudInfo = antifraudInfo;
            this.Corporate = corporate;
            this.CustomReference = customReference;
            this.DefaultFiscalEntityId = defaultFiscalEntityId;
            this.DefaultShippingContactId = defaultShippingContactId;
            this.DefaultPaymentSourceId = defaultPaymentSourceId;
            this.Email = email;
            this.FiscalEntities = fiscalEntities;
            this.Metadata = metadata;
            this.PaymentSources = paymentSources;
            this.Phone = phone;
            this.ShippingContacts = shippingContacts;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Gets or Sets AntifraudInfo
        /// </summary>
        [DataMember(Name = "antifraud_info", EmitDefaultValue = true)]
        public CustomerAntifraudInfoResponse AntifraudInfo { get; set; }

        /// <summary>
        /// true if the customer is a company
        /// </summary>
        /// <value>true if the customer is a company</value>
        [DataMember(Name = "corporate", EmitDefaultValue = true)]
        public bool Corporate { get; set; }

        /// <summary>
        /// Creation date of the object
        /// </summary>
        /// <value>Creation date of the object</value>
        /// <example>1485151007</example>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// Custom reference
        /// </summary>
        /// <value>Custom reference</value>
        /// <example>custom_reference</example>
        [DataMember(Name = "custom_reference", EmitDefaultValue = false)]
        public string CustomReference { get; set; }

        /// <summary>
        /// Gets or Sets DefaultFiscalEntityId
        /// </summary>
        /// <example>fis_ent_2tKqqAfqPi21oCmEJ</example>
        [DataMember(Name = "default_fiscal_entity_id", EmitDefaultValue = true)]
        public string DefaultFiscalEntityId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultShippingContactId
        /// </summary>
        /// <example>ship_cont_2tKZsTYcsryyu7Ah8</example>
        [DataMember(Name = "default_shipping_contact_id", EmitDefaultValue = false)]
        public string DefaultShippingContactId { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPaymentSourceId
        /// </summary>
        /// <example>src_2tHJfJ79KyUwpxTio</example>
        [DataMember(Name = "default_payment_source_id", EmitDefaultValue = true)]
        public string DefaultPaymentSourceId { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        /// <example>Felipe@gmail.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FiscalEntities
        /// </summary>
        [DataMember(Name = "fiscal_entities", EmitDefaultValue = false)]
        public CustomerFiscalEntitiesResponse FiscalEntities { get; set; }

        /// <summary>
        /// Customer&#39;s ID
        /// </summary>
        /// <value>Customer&#39;s ID</value>
        /// <example>cus_2tHJfJ79KyUwpxTik</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// true if the object exists in live mode or the value false if the object exists in test mode
        /// </summary>
        /// <value>true if the object exists in live mode or the value false if the object exists in test mode</value>
        /// <example>true</example>
        [DataMember(Name = "livemode", IsRequired = true, EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// Customer&#39;s name
        /// </summary>
        /// <value>Customer&#39;s name</value>
        /// <example>Felipe</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets VarObject
        /// </summary>
        /// <example>customer</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// Gets or Sets PaymentSources
        /// </summary>
        [DataMember(Name = "payment_sources", EmitDefaultValue = false)]
        public CustomerPaymentMethodsResponse PaymentSources { get; set; }

        /// <summary>
        /// Customer&#39;s phone number
        /// </summary>
        /// <value>Customer&#39;s phone number</value>
        /// <example>5215555555555</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets ShippingContacts
        /// </summary>
        [DataMember(Name = "shipping_contacts", EmitDefaultValue = false)]
        public CustomerResponseShippingContacts ShippingContacts { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public SubscriptionResponse Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerResponse {\n");
            sb.Append("  AntifraudInfo: ").Append(AntifraudInfo).Append("\n");
            sb.Append("  Corporate: ").Append(Corporate).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CustomReference: ").Append(CustomReference).Append("\n");
            sb.Append("  DefaultFiscalEntityId: ").Append(DefaultFiscalEntityId).Append("\n");
            sb.Append("  DefaultShippingContactId: ").Append(DefaultShippingContactId).Append("\n");
            sb.Append("  DefaultPaymentSourceId: ").Append(DefaultPaymentSourceId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FiscalEntities: ").Append(FiscalEntities).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  PaymentSources: ").Append(PaymentSources).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  ShippingContacts: ").Append(ShippingContacts).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
            return this.Equals(input as CustomerResponse);
        }

        /// <summary>
        /// Returns true if CustomerResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AntifraudInfo == input.AntifraudInfo ||
                    (this.AntifraudInfo != null &&
                    this.AntifraudInfo.Equals(input.AntifraudInfo))
                ) && 
                (
                    this.Corporate == input.Corporate ||
                    this.Corporate.Equals(input.Corporate)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    this.CreatedAt.Equals(input.CreatedAt)
                ) && 
                (
                    this.CustomReference == input.CustomReference ||
                    (this.CustomReference != null &&
                    this.CustomReference.Equals(input.CustomReference))
                ) && 
                (
                    this.DefaultFiscalEntityId == input.DefaultFiscalEntityId ||
                    (this.DefaultFiscalEntityId != null &&
                    this.DefaultFiscalEntityId.Equals(input.DefaultFiscalEntityId))
                ) && 
                (
                    this.DefaultShippingContactId == input.DefaultShippingContactId ||
                    (this.DefaultShippingContactId != null &&
                    this.DefaultShippingContactId.Equals(input.DefaultShippingContactId))
                ) && 
                (
                    this.DefaultPaymentSourceId == input.DefaultPaymentSourceId ||
                    (this.DefaultPaymentSourceId != null &&
                    this.DefaultPaymentSourceId.Equals(input.DefaultPaymentSourceId))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FiscalEntities == input.FiscalEntities ||
                    (this.FiscalEntities != null &&
                    this.FiscalEntities.Equals(input.FiscalEntities))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Livemode == input.Livemode ||
                    this.Livemode.Equals(input.Livemode)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.VarObject == input.VarObject ||
                    (this.VarObject != null &&
                    this.VarObject.Equals(input.VarObject))
                ) && 
                (
                    this.PaymentSources == input.PaymentSources ||
                    (this.PaymentSources != null &&
                    this.PaymentSources.Equals(input.PaymentSources))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.ShippingContacts == input.ShippingContacts ||
                    (this.ShippingContacts != null &&
                    this.ShippingContacts.Equals(input.ShippingContacts))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
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
                if (this.AntifraudInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AntifraudInfo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Corporate.GetHashCode();
                hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                if (this.CustomReference != null)
                {
                    hashCode = (hashCode * 59) + this.CustomReference.GetHashCode();
                }
                if (this.DefaultFiscalEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultFiscalEntityId.GetHashCode();
                }
                if (this.DefaultShippingContactId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultShippingContactId.GetHashCode();
                }
                if (this.DefaultPaymentSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultPaymentSourceId.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.FiscalEntities != null)
                {
                    hashCode = (hashCode * 59) + this.FiscalEntities.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Livemode.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.VarObject != null)
                {
                    hashCode = (hashCode * 59) + this.VarObject.GetHashCode();
                }
                if (this.PaymentSources != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentSources.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.ShippingContacts != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingContacts.GetHashCode();
                }
                if (this.Subscription != null)
                {
                    hashCode = (hashCode * 59) + this.Subscription.GetHashCode();
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
