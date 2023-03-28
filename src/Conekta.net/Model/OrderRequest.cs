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
    /// a order
    /// </summary>
    [DataContract(Name = "order_request")]
    public partial class OrderRequest : IEquatable<OrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderRequest" /> class.
        /// </summary>
        /// <param name="charges">List of [charges](https://developers.conekta.com/v2.1.0/reference/orderscreatecharge) that are applied to the order.</param>
        /// <param name="checkout">checkout.</param>
        /// <param name="currency">Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217) (required).</param>
        /// <param name="customerInfo">customerInfo (required).</param>
        /// <param name="discountLines">List of [discounts](https://developers.conekta.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount..</param>
        /// <param name="lineItems">List of [products](https://developers.conekta.com/v2.1.0/reference/orderscreatelineitems) that are sold in the order. You must have at least one product. (required).</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="needsShippingContact">Allows you to fill out the shipping information at checkout.</param>
        /// <param name="preAuthorize">Indicates whether the order charges must be preauthorized (default to false).</param>
        /// <param name="shippingContact">shippingContact.</param>
        /// <param name="shippingLines">List of [shipping costs](https://developers.conekta.com/v2.1.0/reference/orderscreateshippinglines). If the online store offers digital products..</param>
        /// <param name="taxLines">List of [taxes](https://developers.conekta.com/v2.1.0/reference/orderscreatetaxlines) that are applied to the order..</param>
        public OrderRequest(List<ChargeRequest> charges = default(List<ChargeRequest>), CheckoutRequest checkout = default(CheckoutRequest), string currency = default(string), OrderRequestCustomerInfo customerInfo = default(OrderRequestCustomerInfo), List<OrderDiscountLinesRequest> discountLines = default(List<OrderDiscountLinesRequest>), List<LineItems> lineItems = default(List<LineItems>), Dictionary<string, string> metadata = default(Dictionary<string, string>), bool needsShippingContact = default(bool), bool preAuthorize = false, CustomerShippingContacts shippingContact = default(CustomerShippingContacts), List<ShippingLinesRequest> shippingLines = default(List<ShippingLinesRequest>), List<OrderTaxLinesRequest> taxLines = default(List<OrderTaxLinesRequest>))
        {
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for OrderRequest and cannot be null");
            }
            this.Currency = currency;
            // to ensure "customerInfo" is required (not null)
            if (customerInfo == null)
            {
                throw new ArgumentNullException("customerInfo is a required property for OrderRequest and cannot be null");
            }
            this.CustomerInfo = customerInfo;
            // to ensure "lineItems" is required (not null)
            if (lineItems == null)
            {
                throw new ArgumentNullException("lineItems is a required property for OrderRequest and cannot be null");
            }
            this.LineItems = lineItems;
            this.Charges = charges;
            this.Checkout = checkout;
            this.DiscountLines = discountLines;
            this.Metadata = metadata;
            this.NeedsShippingContact = needsShippingContact;
            this.PreAuthorize = preAuthorize;
            this.ShippingContact = shippingContact;
            this.ShippingLines = shippingLines;
            this.TaxLines = taxLines;
        }

        /// <summary>
        /// List of [charges](https://developers.conekta.com/v2.1.0/reference/orderscreatecharge) that are applied to the order
        /// </summary>
        /// <value>List of [charges](https://developers.conekta.com/v2.1.0/reference/orderscreatecharge) that are applied to the order</value>
        [DataMember(Name = "charges", EmitDefaultValue = false)]
        public List<ChargeRequest> Charges { get; set; }

        /// <summary>
        /// Gets or Sets Checkout
        /// </summary>
        [DataMember(Name = "checkout", EmitDefaultValue = false)]
        public CheckoutRequest Checkout { get; set; }

        /// <summary>
        /// Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217)
        /// </summary>
        /// <value>Currency with which the payment will be made. It uses the 3-letter code of the [International Standard ISO 4217.](https://es.wikipedia.org/wiki/ISO_4217)</value>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerInfo
        /// </summary>
        [DataMember(Name = "customer_info", IsRequired = true, EmitDefaultValue = true)]
        public OrderRequestCustomerInfo CustomerInfo { get; set; }

        /// <summary>
        /// List of [discounts](https://developers.conekta.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount.
        /// </summary>
        /// <value>List of [discounts](https://developers.conekta.com/v2.1.0/reference/orderscreatediscountline) that are applied to the order. You must have at least one discount.</value>
        [DataMember(Name = "discount_lines", EmitDefaultValue = false)]
        public List<OrderDiscountLinesRequest> DiscountLines { get; set; }

        /// <summary>
        /// List of [products](https://developers.conekta.com/v2.1.0/reference/orderscreatelineitems) that are sold in the order. You must have at least one product.
        /// </summary>
        /// <value>List of [products](https://developers.conekta.com/v2.1.0/reference/orderscreatelineitems) that are sold in the order. You must have at least one product.</value>
        [DataMember(Name = "line_items", IsRequired = true, EmitDefaultValue = true)]
        public List<LineItems> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Allows you to fill out the shipping information at checkout
        /// </summary>
        /// <value>Allows you to fill out the shipping information at checkout</value>
        [DataMember(Name = "needs_shipping_contact", EmitDefaultValue = true)]
        public bool NeedsShippingContact { get; set; }

        /// <summary>
        /// Indicates whether the order charges must be preauthorized
        /// </summary>
        /// <value>Indicates whether the order charges must be preauthorized</value>
        [DataMember(Name = "pre_authorize", EmitDefaultValue = true)]
        public bool PreAuthorize { get; set; }

        /// <summary>
        /// Gets or Sets ShippingContact
        /// </summary>
        [DataMember(Name = "shipping_contact", EmitDefaultValue = false)]
        public CustomerShippingContacts ShippingContact { get; set; }

        /// <summary>
        /// List of [shipping costs](https://developers.conekta.com/v2.1.0/reference/orderscreateshippinglines). If the online store offers digital products.
        /// </summary>
        /// <value>List of [shipping costs](https://developers.conekta.com/v2.1.0/reference/orderscreateshippinglines). If the online store offers digital products.</value>
        [DataMember(Name = "shipping_lines", EmitDefaultValue = false)]
        public List<ShippingLinesRequest> ShippingLines { get; set; }

        /// <summary>
        /// List of [taxes](https://developers.conekta.com/v2.1.0/reference/orderscreatetaxlines) that are applied to the order.
        /// </summary>
        /// <value>List of [taxes](https://developers.conekta.com/v2.1.0/reference/orderscreatetaxlines) that are applied to the order.</value>
        [DataMember(Name = "tax_lines", EmitDefaultValue = false)]
        public List<OrderTaxLinesRequest> TaxLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderRequest {\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
            sb.Append("  Checkout: ").Append(Checkout).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CustomerInfo: ").Append(CustomerInfo).Append("\n");
            sb.Append("  DiscountLines: ").Append(DiscountLines).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  NeedsShippingContact: ").Append(NeedsShippingContact).Append("\n");
            sb.Append("  PreAuthorize: ").Append(PreAuthorize).Append("\n");
            sb.Append("  ShippingContact: ").Append(ShippingContact).Append("\n");
            sb.Append("  ShippingLines: ").Append(ShippingLines).Append("\n");
            sb.Append("  TaxLines: ").Append(TaxLines).Append("\n");
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
            return this.Equals(input as OrderRequest);
        }

        /// <summary>
        /// Returns true if OrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Charges == input.Charges ||
                    this.Charges != null &&
                    input.Charges != null &&
                    this.Charges.SequenceEqual(input.Charges)
                ) && 
                (
                    this.Checkout == input.Checkout ||
                    (this.Checkout != null &&
                    this.Checkout.Equals(input.Checkout))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.CustomerInfo == input.CustomerInfo ||
                    (this.CustomerInfo != null &&
                    this.CustomerInfo.Equals(input.CustomerInfo))
                ) && 
                (
                    this.DiscountLines == input.DiscountLines ||
                    this.DiscountLines != null &&
                    input.DiscountLines != null &&
                    this.DiscountLines.SequenceEqual(input.DiscountLines)
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.NeedsShippingContact == input.NeedsShippingContact ||
                    this.NeedsShippingContact.Equals(input.NeedsShippingContact)
                ) && 
                (
                    this.PreAuthorize == input.PreAuthorize ||
                    this.PreAuthorize.Equals(input.PreAuthorize)
                ) && 
                (
                    this.ShippingContact == input.ShippingContact ||
                    (this.ShippingContact != null &&
                    this.ShippingContact.Equals(input.ShippingContact))
                ) && 
                (
                    this.ShippingLines == input.ShippingLines ||
                    this.ShippingLines != null &&
                    input.ShippingLines != null &&
                    this.ShippingLines.SequenceEqual(input.ShippingLines)
                ) && 
                (
                    this.TaxLines == input.TaxLines ||
                    this.TaxLines != null &&
                    input.TaxLines != null &&
                    this.TaxLines.SequenceEqual(input.TaxLines)
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
                if (this.Charges != null)
                {
                    hashCode = (hashCode * 59) + this.Charges.GetHashCode();
                }
                if (this.Checkout != null)
                {
                    hashCode = (hashCode * 59) + this.Checkout.GetHashCode();
                }
                if (this.Currency != null)
                {
                    hashCode = (hashCode * 59) + this.Currency.GetHashCode();
                }
                if (this.CustomerInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerInfo.GetHashCode();
                }
                if (this.DiscountLines != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountLines.GetHashCode();
                }
                if (this.LineItems != null)
                {
                    hashCode = (hashCode * 59) + this.LineItems.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NeedsShippingContact.GetHashCode();
                hashCode = (hashCode * 59) + this.PreAuthorize.GetHashCode();
                if (this.ShippingContact != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingContact.GetHashCode();
                }
                if (this.ShippingLines != null)
                {
                    hashCode = (hashCode * 59) + this.ShippingLines.GetHashCode();
                }
                if (this.TaxLines != null)
                {
                    hashCode = (hashCode * 59) + this.TaxLines.GetHashCode();
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
            // Currency (string) maxLength
            if (this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            yield break;
        }
    }

}
