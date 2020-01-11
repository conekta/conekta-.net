using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Model list base.
  /// </summary>
  public class ModelListBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    [JsonProperty(PropertyName = "object")]
    public string ObjectType { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="T:Conekta.Models.ModelListBase"/> has more.
    /// </summary>
    /// <value><c>true</c> if has more; otherwise, <c>false</c>.</value>
    [JsonProperty(PropertyName = "has_more")]
    public bool HasMore { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="T:Conekta.Models.ModelListBase"/> is total.
    /// </summary>
    /// <value><c>true</c> if total; otherwise, <c>false</c>.</value>
    [JsonProperty(PropertyName = "total")]
    public uint Total { get; set; }

    #endregion
  }
}
