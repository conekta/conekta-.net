using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// PaymentSource list.
  /// </summary>
  public class PaymentSourceList : ModelListBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>The data.</value>
    [JsonProperty(PropertyName = "data")]
    public List<PaymentSource> Data { get; set; }

    #endregion
  }
}
