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
    /// ProductOrderResponse
    /// </summary>
    [DataContract(Name = "product_order_response")]
    public partial class ProductOrderResponse : IEquatable<ProductOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOrderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductOrderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOrderResponse" /> class.
        /// </summary>
        /// <param name="antifraudInfo">antifraudInfo.</param>
        /// <param name="brand">The brand of the item..</param>
        /// <param name="description">Short description of the item.</param>
        /// <param name="metadata">It is a key/value hash that can hold custom fields. Maximum 100 elements and allows special characters..</param>
        /// <param name="name">The name of the item. It will be displayed in the order. (required).</param>
        /// <param name="quantity">The quantity of the item in the order. (required).</param>
        /// <param name="sku">The stock keeping unit for the item. It is used to identify the item in the order..</param>
        /// <param name="tags">List of tags for the item. It is used to identify the item in the order..</param>
        /// <param name="unitPrice">The price of the item in cents. (required).</param>
        /// <param name="id">id.</param>
        /// <param name="_object">_object.</param>
        /// <param name="parentId">parentId.</param>
        public ProductOrderResponse(Dictionary<string, Object> antifraudInfo = default(Dictionary<string, Object>), string brand = default(string), string description = default(string), Dictionary<string, string> metadata = default(Dictionary<string, string>), string name = default(string), int quantity = default(int), string sku = default(string), List<string> tags = default(List<string>), int unitPrice = default(int), string id = default(string), string _object = default(string), string parentId = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ProductOrderResponse and cannot be null");
            }
            this.Name = name;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.AntifraudInfo = antifraudInfo;
            this.Brand = brand;
            this.Description = description;
            this.Metadata = metadata;
            this.Sku = sku;
            this.Tags = tags;
            this.Id = id;
            this.Object = _object;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Gets or Sets AntifraudInfo
        /// </summary>
        [DataMember(Name = "antifraud_info", EmitDefaultValue = false)]
        public Dictionary<string, Object> AntifraudInfo { get; set; }

        /// <summary>
        /// The brand of the item.
        /// </summary>
        /// <value>The brand of the item.</value>
        /// <example>&quot;Cohiba&quot;</example>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Short description of the item
        /// </summary>
        /// <value>Short description of the item</value>
        /// <example>&quot;Imported From Mex.&quot;</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// It is a key/value hash that can hold custom fields. Maximum 100 elements and allows special characters.
        /// </summary>
        /// <value>It is a key/value hash that can hold custom fields. Maximum 100 elements and allows special characters.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The name of the item. It will be displayed in the order.
        /// </summary>
        /// <value>The name of the item. It will be displayed in the order.</value>
        /// <example>&quot;Box of Cohiba S1s&quot;</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The quantity of the item in the order.
        /// </summary>
        /// <value>The quantity of the item in the order.</value>
        /// <example>1</example>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public int Quantity { get; set; }

        /// <summary>
        /// The stock keeping unit for the item. It is used to identify the item in the order.
        /// </summary>
        /// <value>The stock keeping unit for the item. It is used to identify the item in the order.</value>
        /// <example>&quot;XYZ12345&quot;</example>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// List of tags for the item. It is used to identify the item in the order.
        /// </summary>
        /// <value>List of tags for the item. It is used to identify the item in the order.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// The price of the item in cents.
        /// </summary>
        /// <value>The price of the item in cents.</value>
        /// <example>20000</example>
        [DataMember(Name = "unit_price", IsRequired = true, EmitDefaultValue = true)]
        public int UnitPrice { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string Object { get; set; }

        /// <summary>
        /// Gets or Sets ParentId
        /// </summary>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public string ParentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductOrderResponse {\n");
            sb.Append("  AntifraudInfo: ").Append(AntifraudInfo).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
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
            return this.Equals(input as ProductOrderResponse);
        }

        /// <summary>
        /// Returns true if ProductOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductOrderResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AntifraudInfo == input.AntifraudInfo ||
                    this.AntifraudInfo != null &&
                    input.AntifraudInfo != null &&
                    this.AntifraudInfo.SequenceEqual(input.AntifraudInfo)
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    this.UnitPrice.Equals(input.UnitPrice)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Object == input.Object ||
                    (this.Object != null &&
                    this.Object.Equals(input.Object))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
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
                if (this.Brand != null)
                {
                    hashCode = (hashCode * 59) + this.Brand.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.Sku != null)
                {
                    hashCode = (hashCode * 59) + this.Sku.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UnitPrice.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Object != null)
                {
                    hashCode = (hashCode * 59) + this.Object.GetHashCode();
                }
                if (this.ParentId != null)
                {
                    hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 250.", new [] { "Description" });
            }

            // Quantity (int) minimum
            if (this.Quantity < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must be a value greater than or equal to 1.", new [] { "Quantity" });
            }

            // UnitPrice (int) minimum
            if (this.UnitPrice < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitPrice, must be a value greater than or equal to 0.", new [] { "UnitPrice" });
            }

            yield break;
        }
    }

}
