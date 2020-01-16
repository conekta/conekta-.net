using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Shipping contract.
  /// </summary>
  public class ShippingContact
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public string id { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the phone.
    /// </summary>
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the Receiver.
    /// </summary>
    [JsonProperty(PropertyName = "receiver")]
    public string Receiver { get; set; }

    /// <summary>
    /// Gets or sets the streets.
    /// </summary>
    [JsonProperty(PropertyName = "between_streets")]
    public string BetweenStreets { get; set; }

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    [JsonProperty(PropertyName = "address")]
    public Address Address { get; set; }

    /// <summary>
    /// Gets or sets the parent id.
    /// </summary>
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; set; }

    #endregion
  }
}
