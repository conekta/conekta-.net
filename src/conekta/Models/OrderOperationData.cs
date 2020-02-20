using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Order operation data.
  /// </summary>
  public class OrderOperationData : ICloneable
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

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
    [JsonProperty(PropertyName = "customer_info")]
    public CustomerInfo CustomerInfo { get; set; }

    /// <summary>
    /// Gets or sets the line items.
    /// </summary>
    /// <value>The line items.</value>
    [Required]
    [JsonProperty(PropertyName = "line_items")]
    public List<LineItem> LineItems { get; set; }

    /// <summary>
    /// Gets or sets the shipping lines.
    /// </summary>
    /// <value>The shipping lines.</value>
    [JsonProperty(PropertyName = "shipping_lines")]
    public List<ShippingLine> ShippingLines { get; set; }

    /// <summary>
    /// Gets or set charges.
    /// </summary>
    [JsonProperty(PropertyName = "charges")]
    public List<ChargeOperationData> Charges { get; set; }

    /// <summary>
    /// Pre authorize flag.
    /// </summary>
    [JsonProperty(PropertyName = "pre_authorize")]
    public bool PreAuthorize { get; set; }

    /// <summary>
    /// Gets or sets the metadata.
    /// </summary>
    /// <value>The metadata.</value>
    [StringLength(250)]
    [JsonProperty(PropertyName = "metadata")]
    public dynamic Metadata { get; set; }

    /// <summary>
    /// Gets or sets the shipping contact.
    /// </summary>
    /// <value>The shipping contact.</value>
    [JsonProperty(PropertyName = "shipping_contact")]
    public ShippingContact ShippingContact { get; set; }

    #endregion

    #region :: Constructors ::

    /// <summary>
    /// Order Operation Data constructor.
    /// </summary>
    public OrderOperationData() { }

    /// <summary>
    /// Order Operation Data constructor.
    /// </summary>
    /// <param name="id">Identifier.</param>
    public OrderOperationData(string id) => Id = id ?? throw new ArgumentNullException(nameof(id));

    #endregion

    #region :: Methods ::

    /// <summary>
    /// Clone object.
    /// </summary>
    /// <returns>Cloned object.</returns>
    public object Clone() => MemberwiseClone();

    #endregion
  }
}
