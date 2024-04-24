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
    /// Company model
    /// </summary>
    [DataContract(Name = "company_response")]
    public partial class CompanyResponse : IValidatableObject
    {
        /// <summary>
        /// The resource&#39;s type
        /// </summary>
        /// <value>The resource&#39;s type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum Company for value: company
            /// </summary>
            [EnumMember(Value = "company")]
            Company = 1
        }


        /// <summary>
        /// The resource&#39;s type
        /// </summary>
        /// <value>The resource&#39;s type</value>
        [DataMember(Name = "object", EmitDefaultValue = false)]
        public ObjectEnum? Object { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponse" /> class.
        /// </summary>
        /// <param name="id">The child company&#39;s unique identifier.</param>
        /// <param name="createdAt">The resource&#39;s creation date (unix timestamp).</param>
        /// <param name="name">The child company&#39;s name.</param>
        /// <param name="varObject">The resource&#39;s type.</param>
        /// <param name="parentCompanyId">Id of the parent company.</param>
        /// <param name="useParentFiscalData">Whether the parent company&#39;s fiscal data is to be used for liquidation and tax purposes.</param>
        /// <param name="payoutDestination">payoutDestination.</param>
        /// <param name="fiscalInfo">fiscalInfo.</param>
        public CompanyResponse(string id = default(string), long createdAt = default(long), string name = default(string), ObjectEnum? varObject = default(ObjectEnum?), string parentCompanyId = default(string), bool useParentFiscalData = default(bool), CompanyPayoutDestinationResponse payoutDestination = default(CompanyPayoutDestinationResponse), CompanyFiscalInfoResponse fiscalInfo = default(CompanyFiscalInfoResponse))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Name = name;
            this.Object = varObject;
            this.ParentCompanyId = parentCompanyId;
            this.UseParentFiscalData = useParentFiscalData;
            this.PayoutDestination = payoutDestination;
            this.FiscalInfo = fiscalInfo;
        }

        /// <summary>
        /// The child company&#39;s unique identifier
        /// </summary>
        /// <value>The child company&#39;s unique identifier</value>
        /// <example>6441bb27659a060465da7335</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// The resource&#39;s creation date (unix timestamp)
        /// </summary>
        /// <value>The resource&#39;s creation date (unix timestamp)</value>
        /// <example>1680397724</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public long CreatedAt { get; set; }

        /// <summary>
        /// The child company&#39;s name
        /// </summary>
        /// <value>The child company&#39;s name</value>
        /// <example>Child Company A</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Id of the parent company
        /// </summary>
        /// <value>Id of the parent company</value>
        /// <example>6441bb3c62db5812e7920c31</example>
        [DataMember(Name = "parent_company_id", EmitDefaultValue = false)]
        public string ParentCompanyId { get; set; }

        /// <summary>
        /// Whether the parent company&#39;s fiscal data is to be used for liquidation and tax purposes
        /// </summary>
        /// <value>Whether the parent company&#39;s fiscal data is to be used for liquidation and tax purposes</value>
        /// <example>false</example>
        [DataMember(Name = "use_parent_fiscal_data", EmitDefaultValue = true)]
        public bool UseParentFiscalData { get; set; }

        /// <summary>
        /// Gets or Sets PayoutDestination
        /// </summary>
        [DataMember(Name = "payout_destination", EmitDefaultValue = false)]
        public CompanyPayoutDestinationResponse PayoutDestination { get; set; }

        /// <summary>
        /// Gets or Sets FiscalInfo
        /// </summary>
        [DataMember(Name = "fiscal_info", EmitDefaultValue = false)]
        public CompanyFiscalInfoResponse FiscalInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  ParentCompanyId: ").Append(ParentCompanyId).Append("\n");
            sb.Append("  UseParentFiscalData: ").Append(UseParentFiscalData).Append("\n");
            sb.Append("  PayoutDestination: ").Append(PayoutDestination).Append("\n");
            sb.Append("  FiscalInfo: ").Append(FiscalInfo).Append("\n");
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
