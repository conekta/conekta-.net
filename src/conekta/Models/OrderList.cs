using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Order list.
  /// </summary>
  public class OrderList : ModelListBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>The data.</value>
    [JsonProperty(PropertyName = "data")]
    public List<Order> Data { get; set; }

    #endregion
  }
}
