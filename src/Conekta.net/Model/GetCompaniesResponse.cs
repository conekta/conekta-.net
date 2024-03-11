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
    /// GetCompaniesResponse
    /// </summary>
    [DataContract(Name = "get_companies_response")]
    public partial class GetCompaniesResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCompaniesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCompaniesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCompaniesResponse" /> class.
        /// </summary>
        /// <param name="hasMore">Indicates if there are more pages to be requested (required).</param>
        /// <param name="varObject">Object type, in this case is list (required).</param>
        /// <param name="nextPageUrl">URL of the next page..</param>
        /// <param name="previousPageUrl">Url of the previous page..</param>
        /// <param name="data">data.</param>
        public GetCompaniesResponse(bool hasMore = default(bool), string varObject = default(string), string nextPageUrl = default(string), string previousPageUrl = default(string), List<CompanyResponse> data = default(List<CompanyResponse>))
        {
            this.HasMore = hasMore;
            // to ensure "varObject" is required (not null)
            if (varObject == null)
            {
                throw new ArgumentNullException("varObject is a required property for GetCompaniesResponse and cannot be null");
            }
            this.VarObject = varObject;
            this.NextPageUrl = nextPageUrl;
            this.PreviousPageUrl = previousPageUrl;
            this.Data = data;
        }

        /// <summary>
        /// Indicates if there are more pages to be requested
        /// </summary>
        /// <value>Indicates if there are more pages to be requested</value>
        /// <example>false</example>
        [DataMember(Name = "has_more", IsRequired = true, EmitDefaultValue = true)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Object type, in this case is list
        /// </summary>
        /// <value>Object type, in this case is list</value>
        /// <example>list</example>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public string VarObject { get; set; }

        /// <summary>
        /// URL of the next page.
        /// </summary>
        /// <value>URL of the next page.</value>
        /// <example>https://api.conekta.io/resources?limit&#x3D;10&amp;next&#x3D;chrg_1</example>
        [DataMember(Name = "next_page_url", EmitDefaultValue = true)]
        public string NextPageUrl { get; set; }

        /// <summary>
        /// Url of the previous page.
        /// </summary>
        /// <value>Url of the previous page.</value>
        /// <example>https://api.conekta.io/resources?limit&#x3D;10&amp;previous&#x3D;chrg_1</example>
        [DataMember(Name = "previous_page_url", EmitDefaultValue = true)]
        public string PreviousPageUrl { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<CompanyResponse> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetCompaniesResponse {\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
            sb.Append("  VarObject: ").Append(VarObject).Append("\n");
            sb.Append("  NextPageUrl: ").Append(NextPageUrl).Append("\n");
            sb.Append("  PreviousPageUrl: ").Append(PreviousPageUrl).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
