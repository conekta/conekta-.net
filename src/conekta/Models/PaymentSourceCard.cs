using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// 
  /// </summary>
  public class Card : PaymentSourceOperationData
  {
    #region :: Properties ::

    /// <summary>
    /// Gets the name.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "number")]
    public string Number { get; set; }

    /// <summary>
    /// Gets the card expiration month.
    /// </summary>
    [JsonProperty(PropertyName = "exp_month")]
    public string ExpMonth { get; set; }

    /// <summary>
    /// Gets the card expiration year.
    /// </summary>
    [JsonProperty(PropertyName = "exp_year")]
    public string ExpYear { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "cvc")]
    public string CVC { get; set; }

    /// <summary>
    /// Gets the last four digits of card.
    /// </summary>
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// Gets the last four digits of card.
    /// </summary>
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; set; }

    /// <summary>
    /// Gets the card brand.
    /// </summary>
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; set; }

    /// <summary>
    /// Gets the address.
    /// </summary>
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    #endregion
  }
}
