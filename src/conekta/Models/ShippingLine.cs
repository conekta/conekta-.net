using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Shipping Line.
  /// </summary>
  public class ShippingLine
  {
    #region :: Properties ::

    /// <summary>
    /// Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    /// <summary>
    /// Gets or sets the amount.
    /// </summary>
    /// <value>The amount.</value>
    [JsonProperty(PropertyName = "amount")]
    public uint Amount { get; set; }

    /// <summary>
    /// Gets or sets the carrier.
    /// </summary>
    /// <value>The carrier.</value>
    [JsonProperty(PropertyName = "carrier")]
    public string Carrier { get; set; }

    /// <summary>
    /// Gets or sets the method.
    /// </summary>
    /// <value>The method.</value>
    [JsonProperty(PropertyName = "method")]
    public string Method { get; set; }

    /// <summary>
    /// Gets the parent identifier.
    /// </summary>
    /// <value>The parent identifier.</value>
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; private set; }

    /// <summary>
    /// Gets or sets the tracking number.
    /// </summary>
    [JsonProperty(PropertyName = "tracking_number")]
    public string TrackingNumber { get; set; }

    /// <summary>
    /// Gets or sets the metadata.
    /// </summary>
    [JsonProperty(PropertyName = "metadata")]
    public dynamic Metadata { get; set; }

    #endregion
  }
}
