using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Discount Line
  /// </summary>
  public class DiscountLine
  {
    #region :: Properties ::

    /// <summary>
    /// Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    /// <summary>
    /// Gets or sets the code.
    /// </summary>
    /// <value>The code.</value>
    [JsonProperty(PropertyName = "code")]
    public string Code { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>The type.</value>
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the amount.
    /// </summary>
    /// <value>The amount.</value>
    [JsonProperty(PropertyName = "amount")]
    public uint Amount { get; set; }

    /// <summary>
    /// Gets the parent identifier.
    /// </summary>
    /// <value>The parent identifier.</value>
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; private set; }

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    [JsonProperty(PropertyName = "object")]
    public string ObjectType { get; set; }

    #endregion
  }
}
