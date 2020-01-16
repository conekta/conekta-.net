using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Customer list.
  /// </summary>
  public class CustomerList : ModelListBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>The data.</value>
    [JsonProperty(PropertyName = "data")]
    public List<Customer> Data { get; set; }

    #endregion
  }
}
