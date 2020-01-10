using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Order creation data.
  /// </summary>
  public class OrderCreationData
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the currency.
    /// </summary>
    /// <value>The currency.</value>
    [Required]
    [StringLength(3)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or sets the customer info.
    /// </summary>
    /// <value>The customer info.</value>
    [Required]
    [JsonProperty(PropertyName = "customer_info")]
    public CustomerInfo CustomerInfo { get; set; }

    /// <summary>
    /// Gets or sets the line items.
    /// </summary>
    /// <value>The line items.</value>
    [Required]
    [JsonProperty(PropertyName = "line_items")]
    public List<LineItem> LineItems { get; set; }

    #endregion
  }
}
