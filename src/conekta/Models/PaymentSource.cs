using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Payment source.
  /// </summary>
  public class PaymentSource
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    [StringLength(30)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or set the type.
    /// </summary>
    [StringLength(50)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets deleted flag.
    /// </summary>
    [JsonProperty(PropertyName = "deleted")]
    public bool Deleted { get; set; }

    /// <summary>
    /// Gets or sets the token identifier.
    /// </summary>
    [StringLength(50)]
    [JsonProperty(PropertyName = "token_id")]
    public string TokenId { get; set; }

    /// <summary>
    /// Gets the parent identifier.
    /// </summary>
    /// <value>The parent identifier.</value>
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; private set; }

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    [JsonProperty(PropertyName = "object")]
    public string ObjectType { get; private set; }

    /// <summary>
    /// Gets the creation date.
    /// </summary>
    [JsonProperty(PropertyName = "created_at")]
    public long CreatedAt { get; private set; }

    /// <summary>
    /// Gets the last four digits of card.
    /// </summary>
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; private set; }

    /// <summary>
    /// Gets the last four digits of card.
    /// </summary>
    [JsonProperty(PropertyName = "bin")]
    public string Bin { get; private set; }

    /// <summary>
    /// Gets the card expiration month.
    /// </summary>
    [JsonProperty(PropertyName = "exp_month")]
    public string ExpMonth { get; private set; }

    /// <summary>
    /// Gets the card expiration year.
    /// </summary>
    [JsonProperty(PropertyName = "exp_year")]
    public string ExpYear { get; private set; }

    /// <summary>
    /// Gets the card brand.
    /// </summary>
    [JsonProperty(PropertyName = "brand")]
    public string Brand { get; private set; }

    /// <summary>
    /// Gets the name.
    /// </summary>
    [JsonProperty(PropertyName = "name")]
    public string Name { get; private set; }

    /// <summary>
    /// Gets or sets deleted flag.
    /// </summary>
    [JsonProperty(PropertyName = "default")]
    public bool IsDefault { get; set; }

    #endregion
  }
}
