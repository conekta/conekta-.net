using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Order.
  /// </summary>
  public class Order : ModelBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="T:Conekta.Models.Order"/> live mode.
    /// </summary>
    /// <value><c>true</c> if live mode; otherwise, <c>false</c>.</value>
    [JsonProperty(PropertyName = "livemode")]
    public bool LiveMode { get; private set; }

    /// <summary>
    /// Gets or sets the amount.
    /// </summary>
    /// <value>The amount.</value>
    [JsonProperty(PropertyName = "amount")]
    public uint Amount { get; private set; }

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    /// <value>The currency.</value>
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or sets the amount refunded.
    /// </summary>
    /// <value>The amount refunded.</value>
    [JsonProperty(PropertyName = "amount_refunded")]
    public uint AmountRefunded { get; private set; }

    /// <summary>
    /// Gets or sets the customer info.
    /// </summary>
    /// <value>The customer info.</value>
    [JsonProperty(PropertyName = "customer_info")]
    public CustomerInfo CustomerInfo { get; set; }

    /// <summary>
    /// Gets or sets the created at.
    /// </summary>
    /// <value>The created at.</value>
    [JsonProperty(PropertyName = "created_at")]
    public long CreatedAt { get; private set; }

    /// <summary>
    /// Gets or sets the created at.
    /// </summary>
    /// <value>The created at.</value>
    [JsonProperty(PropertyName = "updated_at")]
    public long UpdatedAt { get; private set; }

    /// <summary>
    /// Gets or sets the line items list.
    /// </summary>
    /// <value>The line items list.</value>
    [JsonProperty(PropertyName = "line_items")]
    public LineItemsList LineItemsList { get; set; }

    #endregion
  }
}
