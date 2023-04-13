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
    /// update customer
    /// </summary>
    [DataContract(Name = "update_customer")]
    public partial class UpdateCustomer : IEquatable<UpdateCustomer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCustomer" /> class.
        /// </summary>
        /// <param name="antifraudInfo">antifraudInfo.</param>
        /// <param name="defaultPaymentSourceId">It is a parameter that allows to identify in the response, the Conekta ID of a payment method (payment_id).</param>
        /// <param name="email">An email address is a series of customizable characters followed by a universal Internet symbol, the at symbol (@), the name of a host server, and a web domain ending (.mx, .com, .org, . net, etc)..</param>
        /// <param name="name">Client&#39;s name.</param>
        /// <param name="phone">Is the customer&#39;s phone number.</param>
        /// <param name="planId">Contains the ID of a plan, which could together with name, email and phone create a client directly to a subscription.</param>
        /// <param name="defaultShippingContactId">It is a parameter that allows to identify in the response, the Conekta ID of the shipping address (shipping_contact).</param>
        /// <param name="corporate">It is a value that allows identifying if the email is corporate or not. (default to false).</param>
        /// <param name="customReference">It is an undefined value..</param>
        /// <param name="fiscalEntities">fiscalEntities.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="paymentSources">Contains details of the payment methods that the customer has active or has used in Conekta.</param>
        /// <param name="shippingContacts">Contains the detail of the shipping addresses that the client has active or has used in Conekta.</param>
        /// <param name="subscription">subscription.</param>
        public UpdateCustomer(UpdateCustomerAntifraudInfo antifraudInfo = default(UpdateCustomerAntifraudInfo), string defaultPaymentSourceId = default(string), string email = default(string), string name = default(string), string phone = default(string), string planId = default(string), string defaultShippingContactId = default(string), bool corporate = false, string customReference = default(string), List<CustomerFiscalEntitiesRequest> fiscalEntities = default(List<CustomerFiscalEntitiesRequest>), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), List<ConsumerPaymentMethodsRequest> paymentSources = default(List<ConsumerPaymentMethodsRequest>), List<CustomerShippingContacts> shippingContacts = default(List<CustomerShippingContacts>), SubscriptionRequest subscription = default(SubscriptionRequest))
        {
            this.AntifraudInfo = antifraudInfo;
            this.DefaultPaymentSourceId = defaultPaymentSourceId;
            this.Email = email;
            this.Name = name;
            this.Phone = phone;
            this.PlanId = planId;
            this.DefaultShippingContactId = defaultShippingContactId;
            this.Corporate = corporate;
            this.CustomReference = customReference;
            this.FiscalEntities = fiscalEntities;
            this.Metadata = metadata;
            this.PaymentSources = paymentSources;
            this.ShippingContacts = shippingContacts;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Gets or Sets AntifraudInfo
        /// </summary>
        [DataMember(Name = "antifraud_info", EmitDefaultValue = true)]
        public UpdateCustomerAntifraudInfo AntifraudInfo { get; set; }

        /// <summary>
        /// It is a parameter that allows to identify in the response, the Conekta ID of a payment method (payment_id)
        /// </summary>
        /// <value>It is a parameter that allows to identify in the response, the Conekta ID of a payment method (payment_id)</value>
        /// <example>&quot;src_1a2b3c4d5e6f7g8h&quot;</example>
        [DataMember(Name = "default_payment_source_id", EmitDefaultValue = false)]
        public string DefaultPaymentSourceId { get; set; }

        /// <summary>
        /// An email address is a series of customizable characters followed by a universal Internet symbol, the at symbol (@), the name of a host server, and a web domain ending (.mx, .com, .org, . net, etc).
        /// </summary>
        /// <value>An email address is a series of customizable characters followed by a universal Internet symbol, the at symbol (@), the name of a host server, and a web domain ending (.mx, .com, .org, . net, etc).</value>
        /// <example>&quot;miguel@gmail.com&quot;</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Client&#39;s name
        /// </summary>
        /// <value>Client&#39;s name</value>
        /// <example>&quot;miguel&quot;</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Is the customer&#39;s phone number
        /// </summary>
        /// <value>Is the customer&#39;s phone number</value>
        /// <example>&quot;+5215555555555&quot;</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Contains the ID of a plan, which could together with name, email and phone create a client directly to a subscription
        /// </summary>
        /// <value>Contains the ID of a plan, which could together with name, email and phone create a client directly to a subscription</value>
        /// <example>&quot;plan_987234823&quot;</example>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId { get; set; }

        /// <summary>
        /// It is a parameter that allows to identify in the response, the Conekta ID of the shipping address (shipping_contact)
        /// </summary>
        /// <value>It is a parameter that allows to identify in the response, the Conekta ID of the shipping address (shipping_contact)</value>
        /// <example>&quot;ship_cont_1a2b3c4d5e6f7g8h&quot;</example>
        [DataMember(Name = "default_shipping_contact_id", EmitDefaultValue = false)]
        public string DefaultShippingContactId { get; set; }

        /// <summary>
        /// It is a value that allows identifying if the email is corporate or not.
        /// </summary>
        /// <value>It is a value that allows identifying if the email is corporate or not.</value>
        /// <example>false</example>
        [DataMember(Name = "corporate", EmitDefaultValue = true)]
        public bool Corporate { get; set; }

        /// <summary>
        /// It is an undefined value.
        /// </summary>
        /// <value>It is an undefined value.</value>
        [DataMember(Name = "custom_reference", EmitDefaultValue = false)]
        public string CustomReference { get; set; }

        /// <summary>
        /// Gets or Sets FiscalEntities
        /// </summary>
        [DataMember(Name = "fiscal_entities", EmitDefaultValue = false)]
        public List<CustomerFiscalEntitiesRequest> FiscalEntities { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// Contains details of the payment methods that the customer has active or has used in Conekta
        /// </summary>
        /// <value>Contains details of the payment methods that the customer has active or has used in Conekta</value>
        [DataMember(Name = "payment_sources", EmitDefaultValue = false)]
        public List<ConsumerPaymentMethodsRequest> PaymentSources { get; set; }

        /// <summary>
        /// Contains the detail of the shipping addresses that the client has active or has used in Conekta
        /// </summary>
        /// <value>Contains the detail of the shipping addresses that the client has active or has used in Conekta</value>
        [DataMember(Name = "shipping_contacts", EmitDefaultValue = false)]
        public List<CustomerShippingContacts> ShippingContacts { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public SubscriptionRequest Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateCustomer {\n");
            sb.Append("  AntifraudInfo: ").Append(AntifraudInfo).Append("\n");
            sb.Append("  DefaultPaymentSourceId: ").Append(DefaultPaymentSourceId).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  DefaultShippingContactId: ").Append(DefaultShippingContactId).Append("\n");
            sb.Append("  Corporate: ").Append(Corporate).Append("\n");
            sb.Append("  CustomReference: ").Append(CustomReference).Append("\n");
            sb.Append("  FiscalEntities: ").Append(FiscalEntities).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PaymentSources: ").Append(PaymentSources).Append("\n");
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
            return this.Equals(input as UpdateCustomer);
        }

        /// <summary>
        /// Returns true if UpdateCustomer instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCustomer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCustomer input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.DefaultShippingContactId == input.DefaultShippingContactId ||
                    (this.DefaultShippingContactId != null &&
                    this.DefaultShippingContactId.Equals(input.DefaultShippingContactId))
                ) && 
                (
                    this.Corporate == input.Corporate ||
                    this.Corporate.Equals(input.Corporate)
                ) && 
                (
                    this.CustomReference == input.CustomReference ||
                    (this.CustomReference != null &&
                    this.CustomReference.Equals(input.CustomReference))
                ) && 
                (
                    this.FiscalEntities == input.FiscalEntities ||
                    this.FiscalEntities != null &&
                    input.FiscalEntities != null &&
                    this.FiscalEntities.SequenceEqual(input.FiscalEntities)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.PaymentSources == input.PaymentSources ||
                    this.PaymentSources != null &&
                    input.PaymentSources != null &&
                    this.PaymentSources.SequenceEqual(input.PaymentSources)
                ) && 
                (
                    this.ShippingContacts == input.ShippingContacts ||
                    this.ShippingContacts != null &&
                    input.ShippingContacts != null &&
                    this.ShippingContacts.SequenceEqual(input.ShippingContacts)
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
                if (this.DefaultPaymentSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultPaymentSourceId.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.PlanId != null)
                {
                    hashCode = (hashCode * 59) + this.PlanId.GetHashCode();
                }
                if (this.DefaultShippingContactId != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultShippingContactId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Corporate.GetHashCode();
                if (this.CustomReference != null)
                {
                    hashCode = (hashCode * 59) + this.CustomReference.GetHashCode();
                }
                if (this.FiscalEntities != null)
                {
                    hashCode = (hashCode * 59) + this.FiscalEntities.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.PaymentSources != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentSources.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
