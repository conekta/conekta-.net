using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Charge list.
  /// </summary>
  public class ChargeList : ModelListBase
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>The data.</value>
    [JsonProperty(PropertyName = "data")]
    public List<Charge> Data { get; set; }

    #endregion
  }
}
