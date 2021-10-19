using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Charge.
  /// </summary>
  public class Charge : ChargeOperationData
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    /// <summary>
    /// Gets a value indicating whether this <see cref="T:Conekta.Models.Charge"/> live mode.
    /// </summary>
    /// <value><c>true</c> if live mode; otherwise, <c>false</c>.</value>
    [JsonProperty(PropertyName = "livemode")]
    public bool LiveMode { get; private set; }

    /// <summary>
    /// Gets a created date on timestamp value.
    /// </summary>
    [JsonProperty(PropertyName = "created_at")]
    public long CreatedAt { get; private set; }

    /// <summary>
    /// Gets device fingerprint.
    /// </summary>
    [JsonProperty(PropertyName = "device_fingerprint")]
    public string DeviceFingerprint { get; private set; }

    /// <summary>
    /// Gets the type of the object.
    /// </summary>
    /// <value>The type of the object.</value>
    [JsonProperty(PropertyName = "object")]
    public string ObjectType { get; private set; }

    /// <summary>
    ///Gets the description.
    /// </summary>
    [JsonProperty(PropertyName = "description")]
    public string Description { get; private set; }

    /// <summary>
    /// Gets the status.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; private set; }

    /// <summary>
    /// Gets pay date.
    /// </summary>
    [JsonProperty(PropertyName = "paid_at")]
    public string PaidAt { get; private set; }

    /// <summary>
    /// Gets the parent identifier.
    /// </summary>
    /// <value>The parent identifier.</value>
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; private set; }

    /// <summary>
    /// Gets the fee.
    /// </summary>
    [JsonProperty(PropertyName = "fee")]
    public uint Fee { get; private set; }

    /// <summary>
    /// Gets the customer id.
    /// </summary>
    [JsonProperty(PropertyName = "customer_id")]
    public string CustomerId { get; private set; }

    /// <summary>
    /// Gets the order id.
    /// </summary>
    [JsonProperty(PropertyName = "order_id")]
    public string OrderId { get; private set; }
    
    /// <summary>
    /// Gets or sets the referenceId.
    /// </summary>
    /// <value>The referenceId.</value>
    [JsonProperty(PropertyName = "reference_id")]
    public string ReferenceId { get; set;}

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "failure_code")]
    public string FailureCode { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty(PropertyName = "failure_message")]
    public string FailureMessage { get; private set; }

    #endregion
  }
}
