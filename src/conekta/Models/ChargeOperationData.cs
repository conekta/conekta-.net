using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Charge Operation Data.
  /// </summary>
  public class ChargeOperationData
  {
    #region :: Properties ::

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
    public uint Amount { get; set; }

    /// <summary>
    /// Gets or sets the payment method.
    /// </summary>
    /// <value>The payment method.</value>
    [JsonProperty(PropertyName = "payment_method")]
    public PaymentMethod PaymentMethod { get; set; }

    #endregion
  }
}
