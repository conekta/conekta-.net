using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
    /// <summary>
    /// Refunds list.
    /// </summary>
    public class RefundsList : ModelListBase
    {
        #region :: Properties ::

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>The data.</value>
        [JsonProperty(PropertyName = "data")]
        public List<RefundsOperationData> Data { get; set; }

        #endregion
    }
}