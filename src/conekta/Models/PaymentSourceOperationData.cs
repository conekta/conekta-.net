using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Payment source.
  /// </summary>
  public class PaymentSourceOperationData : IPaymentSourceOperationData
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
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "token")]
    public string Token { get; set; }

    /// <summary>
    /// Gets the parent identifier.
    /// </summary>
    /// <value>The parent identifier.</value>
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; set; }

    /// <summary>
    /// Gets or sets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    [JsonProperty(PropertyName = "object")]
    public string ObjectType { get; set; }

    /// <summary>
    /// Gets the creation date.
    /// </summary>
    [JsonProperty(PropertyName = "created_at")]
    public long CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets deleted flag.
    /// </summary>
    [JsonProperty(PropertyName = "default")]
    public bool IsDefault { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "reference")]
    public string Reference { get; set; }

    #endregion
  }
}
