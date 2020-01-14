using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Refund information.
  /// </summary>
  public class RefundInfo
  {
    #region :: Propeties ::

    /// <summary>
    /// Gets or sets the amount to refund.
    /// </summary>
    [Required]
    [JsonProperty(PropertyName = "amount")]
    public uint Amount { get; set; }

    /// <summary>
    /// Gets or sets refund reason.
    /// </summary>
    [Required]
    [StringLength(250)]
    [JsonProperty(PropertyName = "reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    [StringLength(3)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or sets the order id.
    /// </summary>
    [StringLength(150)]
    [JsonProperty(PropertyName = "order_id")]
    public string OrderId { get; set; }

    #endregion
  }
}
