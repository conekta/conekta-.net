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
    /// ProductDataResponse
    /// </summary>
    [DataContract(Name = "product_data_response")]
    public partial class ProductDataResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDataResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ProductDataResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDataResponse" /> class.
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
        /// <param name="varObject">varObject.</param>
        /// <param name="parentId">parentId.</param>
        public ProductDataResponse(Dictionary<string, Object> antifraudInfo = default(Dictionary<string, Object>), string brand = default(string), string description = default(string), Dictionary<string, Object> metadata = default(Dictionary<string, Object>), string name = default(string), int quantity = default(int), string sku = default(string), List<string> tags = default(List<string>), int unitPrice = default(int), string id = default(string), string varObject = default(string), string parentId = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ProductDataResponse and cannot be null");
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
            this.Object = varObject;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Gets or Sets AntifraudInfo
        /// </summary>
        /// <example>{key&#x3D;value}</example>
        [DataMember(Name = "antifraud_info", EmitDefaultValue = false)]
        public Dictionary<string, Object> AntifraudInfo { get; set; }

        /// <summary>
        /// The brand of the item.
        /// </summary>
        /// <value>The brand of the item.</value>
        /// <example>Cohiba</example>
        [DataMember(Name = "brand", EmitDefaultValue = false)]
        public string Brand { get; set; }

        /// <summary>
        /// Short description of the item
        /// </summary>
        /// <value>Short description of the item</value>
        /// <example>Imported From Mex.</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// It is a key/value hash that can hold custom fields. Maximum 100 elements and allows special characters.
        /// </summary>
        /// <value>It is a key/value hash that can hold custom fields. Maximum 100 elements and allows special characters.</value>
        /// <example>{key&#x3D;value}</example>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, Object> Metadata { get; set; }

        /// <summary>
        /// The name of the item. It will be displayed in the order.
        /// </summary>
        /// <value>The name of the item. It will be displayed in the order.</value>
        /// <example>Box of Cohiba S1s</example>
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
        /// <example>XYZ12345</example>
        [DataMember(Name = "sku", EmitDefaultValue = false)]
        public string Sku { get; set; }

        /// <summary>
        /// List of tags for the item. It is used to identify the item in the order.
        /// </summary>
        /// <value>List of tags for the item. It is used to identify the item in the order.</value>
        /// <example>[food, mexican food]</example>
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
            sb.Append("class ProductDataResponse {\n");
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
