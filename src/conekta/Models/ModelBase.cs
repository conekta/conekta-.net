using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Model base.
  /// </summary>
  public class ModelBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    [JsonProperty(PropertyName = "object")]
    public string ObjectType { get; set; }

    /// <summary>
    /// Gets or sets the metadata.
    /// </summary>
    /// <value>The metadata.</value>
    [JsonProperty(PropertyName = "metadata")]
    public dynamic Metadata { get; set; }

    #endregion
  }
}
