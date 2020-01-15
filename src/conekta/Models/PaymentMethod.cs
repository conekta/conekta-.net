using System;
using Newtonsoft.Json;

namespace Conekta.Models
{
  public class PaymentMethod
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the name of the object.
    /// </summary>
    /// <value>The name of the object.</value>
    [JsonProperty(PropertyName = "object")]
    public string ObjectName { get; set; }

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Set token id.
    /// </summary>
    [JsonProperty(PropertyName = "token_id")]
    public string TokenId { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the bank.
    /// </summary>
    /// <value>The bank.</value>
    [JsonProperty(PropertyName = "bank")]
    public string Bank { get; set; }

    /// <summary>
    /// Gets or sets the receiving account number.
    /// </summary>
    /// <value>The receiving account number.</value>
    [JsonProperty(PropertyName = "receiving_account_number")]
    public string ReceivingAccountNumber { get; set; }

    /// <summary>
    /// Gets or sets the receiving account bank.
    /// </summary>
    /// <value>The receiving account bank.</value>
    [JsonProperty(PropertyName = "receiving_account_bank")]
    public string ReceivingAccountBank { get; set; }

    /// <summary>
    /// Gets or sets the clabe.
    /// </summary>
    /// <value>The clabe.</value>
    [JsonProperty(PropertyName = "clabe")]
    public string Clabe { get; set; }

    /// <summary>
    /// Gets or sets the exp month.
    /// </summary>
    /// <value>The exp month.</value>
    [JsonProperty(PropertyName = "exp_month")]
    public string ExpMonth { get; set; }

    /// <summary>
    /// Gets or sets the exp year.
    /// </summary>
    /// <value>The exp year.</value>
    [JsonProperty(PropertyName = "exp_year")]
    public string ExpYear { get; set; }

    /// <summary>
    /// Gets or sets the auth code.
    /// </summary>
    /// <value>The auth code.</value>
    [JsonProperty(PropertyName = "auth_code")]
    public string AuthCode { get; set; }

    /// <summary>
    /// Gets or sets the last.
    /// </summary>
    /// <value>The last.</value>
    [JsonProperty(PropertyName = "last")]
    public string Last { get; set; }

    /// <summary>
    /// Gets or sets the brand.
    /// </summary>
    /// <value>The brand.</value>
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Gets or sets the issuer.
    /// </summary>
    /// <value>The issuer.</value>
    [JsonProperty(PropertyName = "issuer")]
    public string Issuer { get; set; }

    /// <summary>
    /// Gets or sets the type of the account.
    /// </summary>
    /// <value>The type of the account.</value>
    [JsonProperty(PropertyName = "account_type")]
    public string AccountType { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    /// <value>The country.</value>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the name of the service.
    /// </summary>
    /// <value>The name of the service.</value>
    [JsonProperty(PropertyName = "service_name")]
    public string ServiceName { get; set; }

    /// <summary>
    /// Gets or sets the service number.
    /// </summary>
    [JsonProperty(PropertyName = "service_number")]
    public string ServiceNumber { get; set; }

    /// <summary>
    /// Gets or sets the expires at.
    /// </summary>
    /// <value>The expires at.</value>
    [JsonProperty(PropertyName = "expires_at")]
    public long ExpiresAt { get; set; }

    /// <summary>
    /// Gets or sets the name of the store.
    /// </summary>
    /// <value>The name of the store.</value>
    [JsonProperty(PropertyName = "store_name")]
    public string StoreName { get; set; }

    /// <summary>
    /// Gets or sets the reference.
    /// </summary>
    /// <value>The reference.</value>
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    #endregion
  }
}
