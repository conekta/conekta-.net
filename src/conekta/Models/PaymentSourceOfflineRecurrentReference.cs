using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class PaymentSourceOfflineRecurrentReference : PaymentSourceOperationData
  {
    #region :: Properties ::

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "barcode")]
    public string Barcode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "barcode_url")]
    public string BarcodeUrl { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "provider")]
    public string Provider { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "expires_at")]
    public string ExpiresAt { get; set; }

    #endregion
  }
}
