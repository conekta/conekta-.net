using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Customer.
  /// </summary>
  public class Customer : CustomerInfo
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    [JsonProperty(PropertyName = "object")]
    public string ObjectType { get; private set; }

    /// <summary>
    /// Gets or sets the payment sources
    /// </summary>
    [JsonProperty(PropertyName = "payment_sources")]
    public PaymentSourceList PaymentSources { get; private set; }

    /// <summary>
    /// Gets or sets the account age.
    /// </summary>
    [JsonProperty(PropertyName = "account_age")]
    public int AccountAge { get; private set; }

    /// <summary>
    /// Gets or sets the paid transactions.
    /// </summary>
    [JsonProperty(PropertyName = "paid_transactions")]
    public int PaidTransactions { get; private set; }

    /// <summary>
    /// Gets or sets the first paid date.
    /// </summary>
    [JsonProperty(PropertyName = "first_paid_at")]
    public int FirstPaidAt { get; private set; }

    /// <summary>
    /// Gets or sets the creation date.
    /// </summary>
    [JsonProperty(PropertyName = "created_at")]
    public string CreatedAt { get; private set; }

    /// <summary>
    /// Gets or sets the default payment source id.
    /// </summary>
    [JsonProperty(PropertyName = "default_payment_source_id")]
    public string DefaultPaymentSourceId { get; private set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="T:Conekta.Models.Order"/> live mode.
    /// </summary>
    /// <value><c>true</c> if live mode; otherwise, <c>false</c>.</value>
    [JsonProperty(PropertyName = "livemode")]
    public bool LiveMode { get; private set; }

    /// <summary>
    /// Gets or sets the custom id.
    /// </summary>
    /// <value>The custom id.</value>
    [JsonProperty(PropertyName = "custom_id")]
    public string CustomId { get; private set; }


    #endregion
  }
}
