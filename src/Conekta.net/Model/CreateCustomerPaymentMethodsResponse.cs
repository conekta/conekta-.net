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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Conekta.net.Client.OpenAPIDateConverter;
using System.Reflection;

namespace Conekta.net.Model
{
    /// <summary>
    /// CreateCustomerPaymentMethodsResponse
    /// </summary>
    [JsonConverter(typeof(CreateCustomerPaymentMethodsResponseJsonConverter))]
    [DataContract(Name = "create_customer_payment_methods_response")]
    public partial class CreateCustomerPaymentMethodsResponse : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerPaymentMethodsResponse" /> class
        /// with the <see cref="PaymentMethodCashResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodCashResponse.</param>
        public CreateCustomerPaymentMethodsResponse(PaymentMethodCashResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerPaymentMethodsResponse" /> class
        /// with the <see cref="PaymentMethodCardResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodCardResponse.</param>
        public CreateCustomerPaymentMethodsResponse(PaymentMethodCardResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerPaymentMethodsResponse" /> class
        /// with the <see cref="PaymentMethodSpeiRecurrent" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodSpeiRecurrent.</param>
        public CreateCustomerPaymentMethodsResponse(PaymentMethodSpeiRecurrent actualInstance)
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
                if (value.GetType() == typeof(PaymentMethodCardResponse) || value is PaymentMethodCardResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodCashResponse) || value is PaymentMethodCashResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodSpeiRecurrent) || value is PaymentMethodSpeiRecurrent)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: PaymentMethodCardResponse, PaymentMethodCashResponse, PaymentMethodSpeiRecurrent");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodCashResponse`. If the actual instance is not `PaymentMethodCashResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodCashResponse</returns>
        public PaymentMethodCashResponse GetPaymentMethodCashResponse()
        {
            return (PaymentMethodCashResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodCardResponse`. If the actual instance is not `PaymentMethodCardResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodCardResponse</returns>
        public PaymentMethodCardResponse GetPaymentMethodCardResponse()
        {
            return (PaymentMethodCardResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodSpeiRecurrent`. If the actual instance is not `PaymentMethodSpeiRecurrent`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodSpeiRecurrent</returns>
        public PaymentMethodSpeiRecurrent GetPaymentMethodSpeiRecurrent()
        {
            return (PaymentMethodSpeiRecurrent)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateCustomerPaymentMethodsResponse {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, CreateCustomerPaymentMethodsResponse.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of CreateCustomerPaymentMethodsResponse
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of CreateCustomerPaymentMethodsResponse</returns>
        public static CreateCustomerPaymentMethodsResponse FromJson(string jsonString)
        {
            CreateCustomerPaymentMethodsResponse newCreateCustomerPaymentMethodsResponse = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newCreateCustomerPaymentMethodsResponse;
            }

            try
            {
                var discriminatorObj = JObject.Parse(jsonString)["type"];
                string discriminatorValue =  discriminatorObj == null ?string.Empty :discriminatorObj.ToString();
                switch (discriminatorValue)
                {
                    case "card":
                        newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCardResponse>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                        return newCreateCustomerPaymentMethodsResponse;
                    case "cash":
                        newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCashResponse>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                        return newCreateCustomerPaymentMethodsResponse;
                    case "oxxo_recurrent":
                        newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCashResponse>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                        return newCreateCustomerPaymentMethodsResponse;
                    case "spei_recurrent":
                        newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodSpeiRecurrent>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                        return newCreateCustomerPaymentMethodsResponse;
                    case "payment_method_card_response":
                        newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCardResponse>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                        return newCreateCustomerPaymentMethodsResponse;
                    case "payment_method_cash_response":
                        newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCashResponse>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                        return newCreateCustomerPaymentMethodsResponse;
                    case "payment_method_spei_recurrent":
                        newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodSpeiRecurrent>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                        return newCreateCustomerPaymentMethodsResponse;
                    default:
                        System.Diagnostics.Debug.WriteLine(string.Format("Failed to lookup discriminator value `{0}` for CreateCustomerPaymentMethodsResponse. Possible values: card cash oxxo_recurrent spei_recurrent payment_method_card_response payment_method_cash_response payment_method_spei_recurrent", discriminatorValue));
                        break;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to parse the json data : `{0}` {1}", jsonString, ex.ToString()));
            }

            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodCardResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCardResponse>(jsonString, CreateCustomerPaymentMethodsResponse.SerializerSettings));
                }
                else
                {
                    newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCardResponse>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PaymentMethodCardResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodCardResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodCashResponse).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCashResponse>(jsonString, CreateCustomerPaymentMethodsResponse.SerializerSettings));
                }
                else
                {
                    newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodCashResponse>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PaymentMethodCashResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodCashResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodSpeiRecurrent).GetProperty("AdditionalProperties") == null)
                {
                    newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodSpeiRecurrent>(jsonString, CreateCustomerPaymentMethodsResponse.SerializerSettings));
                }
                else
                {
                    newCreateCustomerPaymentMethodsResponse = new CreateCustomerPaymentMethodsResponse(JsonConvert.DeserializeObject<PaymentMethodSpeiRecurrent>(jsonString, CreateCustomerPaymentMethodsResponse.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("PaymentMethodSpeiRecurrent");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodSpeiRecurrent: {1}", jsonString, exception.ToString()));
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
            return newCreateCustomerPaymentMethodsResponse;
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
    /// Custom JSON converter for CreateCustomerPaymentMethodsResponse
    /// </summary>
    public class CreateCustomerPaymentMethodsResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(CreateCustomerPaymentMethodsResponse).GetMethod("ToJson").Invoke(value, null)));
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
                    return CreateCustomerPaymentMethodsResponse.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return CreateCustomerPaymentMethodsResponse.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
