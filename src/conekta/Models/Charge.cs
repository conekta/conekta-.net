using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Charge.
  /// </summary>
  public class Charge
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    /// <summary>
    /// Gets a value indicating whether this <see cref="T:Conekta.Models.Charge"/> live mode.
    /// </summary>
    /// <value><c>true</c> if live mode; otherwise, <c>false</c>.</value>
    [JsonProperty(PropertyName = "livemode")]
    public bool LiveMode { get; private set; }

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    /// <value>The currency.</value>
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets the amount.
    /// </summary>
    /// <value>The amount.</value>
    [JsonProperty(PropertyName = "amount")]
    public uint Amount { get; private set; }

    /// <summary>
    /// Gets the parent identifier.
    /// </summary>
    /// <value>The parent identifier.</value>
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; private set; }

    /// <summary>
    /// Gets or sets the payment method.
    /// </summary>
    /// <value>The payment method.</value>
    [JsonProperty(PropertyName = "payment_method ")]
    public string PaymentMethod { get; set; }

    #endregion
  }
}
