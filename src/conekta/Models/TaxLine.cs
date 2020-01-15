using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Tax line.
  /// </summary>
  public class TaxLine
  {
    #region :: Properties :: 

    /// <summary>
    /// Gets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    /// <summary>
    /// Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

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
    /// Gets or sets the metadata.
    /// </summary>
    [JsonProperty(PropertyName = "metadata")]
    public dynamic Metadata { get; set; }

    #endregion
  }
}
