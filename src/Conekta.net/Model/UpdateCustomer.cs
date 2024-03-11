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
    public partial class UpdateCustomer : IValidatableObject
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
        public UpdateCustomer(UpdateCustomerAntifraudInfo antifraudInfo = default(UpdateCustomerAntifraudInfo), string defaultPaymentSourceId = default(string), string email = default(string), string name = default(string), string phone = default(string), string planId = default(string), string defaultShippingContactId = default(string), bool corporate = false, string customReference = default(string), List<CustomerFiscalEntitiesRequest> fiscalEntities = default(List<CustomerFiscalEntitiesRequest>), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), List<CustomerPaymentMethodsRequest> paymentSources = default(List<CustomerPaymentMethodsRequest>), List<CustomerShippingContacts> shippingContacts = default(List<CustomerShippingContacts>), SubscriptionRequest subscription = default(SubscriptionRequest))
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
        /// <example>src_1a2b3c4d5e6f7g8h</example>
        [DataMember(Name = "default_payment_source_id", EmitDefaultValue = false)]
        public string DefaultPaymentSourceId { get; set; }

        /// <summary>
        /// An email address is a series of customizable characters followed by a universal Internet symbol, the at symbol (@), the name of a host server, and a web domain ending (.mx, .com, .org, . net, etc).
        /// </summary>
        /// <value>An email address is a series of customizable characters followed by a universal Internet symbol, the at symbol (@), the name of a host server, and a web domain ending (.mx, .com, .org, . net, etc).</value>
        /// <example>miguel@gmail.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Client&#39;s name
        /// </summary>
        /// <value>Client&#39;s name</value>
        /// <example>miguel</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Is the customer&#39;s phone number
        /// </summary>
        /// <value>Is the customer&#39;s phone number</value>
        /// <example>+5215555555555</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Contains the ID of a plan, which could together with name, email and phone create a client directly to a subscription
        /// </summary>
        /// <value>Contains the ID of a plan, which could together with name, email and phone create a client directly to a subscription</value>
        /// <example>plan_987234823</example>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId { get; set; }

        /// <summary>
        /// It is a parameter that allows to identify in the response, the Conekta ID of the shipping address (shipping_contact)
        /// </summary>
        /// <value>It is a parameter that allows to identify in the response, the Conekta ID of the shipping address (shipping_contact)</value>
        /// <example>ship_cont_1a2b3c4d5e6f7g8h</example>
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
        public List<CustomerPaymentMethodsRequest> PaymentSources { get; set; }

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
