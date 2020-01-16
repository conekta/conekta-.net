using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Customer Info.
  /// </summary>
  public class CustomerInfo
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [StringLength(30)]
    [JsonProperty(PropertyName = "customer_id")]
    public string CustomerId { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [StringLength(150)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the email.
    /// </summary>
    /// <value>The email.</value>
    [StringLength(150)]
    [EmailAddress]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    [StringLength(15)]
    [JsonProperty(PropertyName = "phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="T:Conekta.Models.CustomerInfo"/> is corporate.
    /// </summary>
    /// <value><c>true</c> if corporate; otherwise, <c>false</c>.</value>
    [JsonProperty(PropertyName = "corporate")]
    public bool Corporate { get; set; }

    /// <summary>
    /// Antifraud info.
    /// </summary>
    [JsonProperty(PropertyName = "antifraud_info")]
    public dynamic AntifraudInfo { get; set; }

    #endregion
  }
}
