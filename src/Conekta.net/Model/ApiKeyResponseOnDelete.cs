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
    /// api keys model
    /// </summary>
    [DataContract(Name = "api_key_response_on_delete")]
    public partial class ApiKeyResponseOnDelete : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeyResponseOnDelete" /> class.
        /// </summary>
        /// <param name="active">Indicates if the api key is active.</param>
        /// <param name="createdAt">Unix timestamp in seconds of when the api key was created.</param>
        /// <param name="description">A name or brief explanation of what this api key is used for.</param>
        /// <param name="livemode">Indicates if the api key is in production.</param>
        /// <param name="prefix">The first few characters of the authentication_token.</param>
        /// <param name="id">Unique identifier of the api key.</param>
        /// <param name="varObject">Object name, value is &#39;api_key&#39;.</param>
        /// <param name="deleted">Indicates if the api key was deleted.</param>
        /// <param name="role">Indicates if the api key is private or public.</param>
        public ApiKeyResponseOnDelete(bool active = default(bool), long createdAt = default(long), string description = default(string), bool livemode = default(bool), string prefix = default(string), string id = default(string), string varObject = default(string), bool deleted = default(bool), string role = default(string))
        {
            this.Active = active;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Livemode = livemode;
            this.Prefix = prefix;
            this.Id = id;
            this.VarObject = varObject;
            this.Deleted = deleted;
            this.Role = role;
        }

        /// <summary>
        /// Indicates if the api key is active
        /// </summary>
        /// <value>Indicates if the api key is active</value>
        /// <example>true</example>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Unix timestamp in seconds of when the api key was created
        /// </summary>
        /// <value>Unix timestamp in seconds of when the api key was created</value>
        /// <example>1684167881</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// A name or brief explanation of what this api key is used for
        /// </summary>
        /// <value>A name or brief explanation of what this api key is used for</value>
        /// <example>online store</example>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Indicates if the api key is in production
        /// </summary>
        /// <value>Indicates if the api key is in production</value>
        /// <example>false</example>
        [DataMember(Name = "livemode", EmitDefaultValue = true)]
        public bool Livemode { get; set; }

        /// <summary>
        /// The first few characters of the authentication_token
        /// </summary>
        /// <value>The first few characters of the authentication_token</value>
        /// <example>key_rp</example>
        [DataMember(Name = "prefix", EmitDefaultValue = false)]
        public string Prefix { get; set; }

        /// <summary>
        /// Unique identifier of the api key
        /// </summary>
        /// <value>Unique identifier of the api key</value>
        /// <example>64625cc9f3e02c00163f5e4d</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Object name, value is &#39;api_key&#39;
        /// </summary>
        /// <value>Object name, value is &#39;api_key&#39;</value>
        /// <example>api_key</example>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public string VarObject { get; set; }

        /// <summary>
        /// Indicates if the api key was deleted
        /// </summary>
        /// <value>Indicates if the api key was deleted</value>
        /// <example>false</example>
        [DataMember(Name = "deleted", EmitDefaultValue = true)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Indicates if the api key is private or public
        /// </summary>
        /// <value>Indicates if the api key is private or public</value>
        /// <example>private</example>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApiKeyResponseOnDelete {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Livemode: ").Append(Livemode).Append("\n");
            sb.Append("  Prefix: ").Append(Prefix).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
