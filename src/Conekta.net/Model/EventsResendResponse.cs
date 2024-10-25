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
    /// event model
    /// </summary>
    [DataContract(Name = "events_resend_response")]
    public partial class EventsResendResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EventsResendResponse" /> class.
        /// </summary>
        /// <param name="failedAttempts">failedAttempts.</param>
        /// <param name="id">id.</param>
        /// <param name="lastAttemptedAt">lastAttemptedAt.</param>
        /// <param name="lastHttpResponseStatus">lastHttpResponseStatus.</param>
        /// <param name="responseData">responseData.</param>
        /// <param name="url">url.</param>
        public EventsResendResponse(int failedAttempts = default(int), string id = default(string), int lastAttemptedAt = default(int), int lastHttpResponseStatus = default(int), Dictionary<string, Object> responseData = default(Dictionary<string, Object>), string url = default(string))
        {
            this.FailedAttempts = failedAttempts;
            this.Id = id;
            this.LastAttemptedAt = lastAttemptedAt;
            this.LastHttpResponseStatus = lastHttpResponseStatus;
            this.ResponseData = responseData;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets FailedAttempts
        /// </summary>
        /*
        <example>6</example>
        */
        [DataMember(Name = "failed_attempts", EmitDefaultValue = false)]
        public int FailedAttempts { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>webhl_2svd2sh6GbqzyWBNZ</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LastAttemptedAt
        /// </summary>
        /*
        <example>1684265970</example>
        */
        [DataMember(Name = "last_attempted_at", EmitDefaultValue = false)]
        public int LastAttemptedAt { get; set; }

        /// <summary>
        /// Gets or Sets LastHttpResponseStatus
        /// </summary>
        /*
        <example>405</example>
        */
        [DataMember(Name = "last_http_response_status", EmitDefaultValue = false)]
        public int LastHttpResponseStatus { get; set; }

        /// <summary>
        /// Gets or Sets ResponseData
        /// </summary>
        /*
        <example>{}</example>
        */
        [DataMember(Name = "response_data", EmitDefaultValue = false)]
        public Dictionary<string, Object> ResponseData { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        /*
        <example>https://username:password@mockoon.stg.conekta.io/payments-api/cash/merchant_approval</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EventsResendResponse {\n");
            sb.Append("  FailedAttempts: ").Append(FailedAttempts).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastAttemptedAt: ").Append(LastAttemptedAt).Append("\n");
            sb.Append("  LastHttpResponseStatus: ").Append(LastHttpResponseStatus).Append("\n");
            sb.Append("  ResponseData: ").Append(ResponseData).Append("\n");
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
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
