using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Order.
  /// </summary>
  public class Order : OrderCreationData
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    #endregion
  }
}
