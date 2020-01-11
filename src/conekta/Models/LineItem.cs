using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Line item.
  /// </summary>
  public class LineItem : ModelBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [Required]
    [StringLength(150)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
    [StringLength(250)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the unit price in cents.
    /// </summary>
    /// <value>The unit price in cents.</value>
    [Required]
    [JsonProperty(PropertyName = "unit_price")]
    public int UnitPrice { get; set; }

    /// <summary>
    /// Gets or sets the quantity.
    /// </summary>
    /// <value>The quantity.</value>
    [Required]
    [JsonProperty(PropertyName = "quantity")]
    public uint Quantity { get; set; }

    /// <summary>
    /// Gets or sets the sku.
    /// </summary>
    /// <value>The sku.</value>
    [StringLength(150)]
    [JsonProperty(PropertyName = "sku")]
    public string Sku { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="T:Conekta.Models.LineItem"/> is shippable.
    /// </summary>
    /// <value><c>true</c> if shippable; otherwise, <c>false</c>.</value>
    [JsonProperty(PropertyName = "shippable")]
    public bool Shippable { get; set; }

    /// <summary>
    /// Gets or sets the tags.
    /// </summary>
    /// <value>The tags.</value>
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Gets or sets the brand.
    /// </summary>
    /// <value>The brand.</value>
    [StringLength(150)]
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    #endregion
  }
}
