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
using System.Reflection;

namespace Conekta.net.Model
{
    /// <summary>
    /// Contains details of the payment methods that the customer has active or has used in Conekta
    /// </summary>
    [JsonConverter(typeof(CreateCustomerPaymentMethodsRequestJsonConverter))]
    [DataContract(Name = "CreateCustomerPaymentMethods_request")]
    public partial class CreateCustomerPaymentMethodsRequest : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerPaymentMethodsRequest" /> class
        /// with the <see cref="PaymentMethodCardRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodCardRequest.</param>
        public CreateCustomerPaymentMethodsRequest(PaymentMethodCardRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerPaymentMethodsRequest" /> class
        /// with the <see cref="PaymentMethodCashRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodCashRequest.</param>
        public CreateCustomerPaymentMethodsRequest(PaymentMethodCashRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerPaymentMethodsRequest" /> class
        /// with the <see cref="PaymentMethodSpeiRequest" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodSpeiRequest.</param>
        public CreateCustomerPaymentMethodsRequest(PaymentMethodSpeiRequest actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(PaymentMethodCardRequest))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodCashRequest))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodSpeiRequest))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: PaymentMethodCardRequest, PaymentMethodCashRequest, PaymentMethodSpeiRequest");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodCardRequest`. If the actual instance is not `PaymentMethodCardRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodCardRequest</returns>
        public PaymentMethodCardRequest GetPaymentMethodCardRequest()
        {
            return (PaymentMethodCardRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodCashRequest`. If the actual instance is not `PaymentMethodCashRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodCashRequest</returns>
        public PaymentMethodCashRequest GetPaymentMethodCashRequest()
        {
            return (PaymentMethodCashRequest)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodSpeiRequest`. If the actual instance is not `PaymentMethodSpeiRequest`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodSpeiRequest</returns>
        public PaymentMethodSpeiRequest GetPaymentMethodSpeiRequest()
        {
            return (PaymentMethodSpeiRequest)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomerPaymentMethodsRequest {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, CreateCustomerPaymentMethodsRequest.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateCustomerPaymentMethodsRequest
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateCustomerPaymentMethodsRequest</returns>
        public static CreateCustomerPaymentMethodsRequest FromJson(string jsonString)
        {
            CreateCustomerPaymentMethodsRequest newCreateCustomerPaymentMethodsRequest = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateCustomerPaymentMethodsRequest;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodCardRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCustomerPaymentMethodsRequest = new CreateCustomerPaymentMethodsRequest(JsonConvert.DeserializeObject<PaymentMethodCardRequest>(jsonString, CreateCustomerPaymentMethodsRequest.SerializerSettings));
                }
                else
                {
                    newCreateCustomerPaymentMethodsRequest = new CreateCustomerPaymentMethodsRequest(JsonConvert.DeserializeObject<PaymentMethodCardRequest>(jsonString, CreateCustomerPaymentMethodsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PaymentMethodCardRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodCardRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodCashRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCustomerPaymentMethodsRequest = new CreateCustomerPaymentMethodsRequest(JsonConvert.DeserializeObject<PaymentMethodCashRequest>(jsonString, CreateCustomerPaymentMethodsRequest.SerializerSettings));
                }
                else
                {
                    newCreateCustomerPaymentMethodsRequest = new CreateCustomerPaymentMethodsRequest(JsonConvert.DeserializeObject<PaymentMethodCashRequest>(jsonString, CreateCustomerPaymentMethodsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PaymentMethodCashRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodCashRequest: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodSpeiRequest).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCustomerPaymentMethodsRequest = new CreateCustomerPaymentMethodsRequest(JsonConvert.DeserializeObject<PaymentMethodSpeiRequest>(jsonString, CreateCustomerPaymentMethodsRequest.SerializerSettings));
                }
                else
                {
                    newCreateCustomerPaymentMethodsRequest = new CreateCustomerPaymentMethodsRequest(JsonConvert.DeserializeObject<PaymentMethodSpeiRequest>(jsonString, CreateCustomerPaymentMethodsRequest.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PaymentMethodSpeiRequest");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodSpeiRequest: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newCreateCustomerPaymentMethodsRequest;
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

    /// <summary>
    /// Custom JSON converter for CreateCustomerPaymentMethodsRequest
    /// </summary>
    public class CreateCustomerPaymentMethodsRequestJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateCustomerPaymentMethodsRequest).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return CreateCustomerPaymentMethodsRequest.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CreateCustomerPaymentMethodsRequest.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
