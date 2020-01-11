using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Line items list.
  /// </summary>
  public class LineItemsList : ModelListBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>The data.</value>
    [JsonProperty(PropertyName = "data")]
    public List<LineItem> Data { get; set; }

    #endregion
  }
}
