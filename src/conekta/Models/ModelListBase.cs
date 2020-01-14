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
    /// Next page URL.
    /// </summary>
    [JsonProperty(PropertyName = "next_page_url")]
    public string NextPageUrl { get; set; }


    /// <summary>
    /// Previous page URL.
    /// </summary>
    [JsonProperty(PropertyName = "previous_page_url")]
    public string PreviousPageUrl { get; set; }

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


    #endregion
  }
}
