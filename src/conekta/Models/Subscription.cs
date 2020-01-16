using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Subscription.
  /// </summary>
  public class Subscription
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the plan.
    /// </summary>
    [JsonProperty(PropertyName = "plan")]
    public string Plan { get; set; }

    /// <summary>
    /// Gets or sets the plan id.
    /// </summary>
    [JsonProperty(PropertyName = "plan_id")]
    public string PlanId { get; set; }

    /// <summary>
    /// Gets or sets the card id.
    /// </summary>
    [JsonProperty(PropertyName = "card_id")]
    public string CardId { get; set; }

    /// <summary>
    /// Gets or sets the Billing cycle start.
    /// </summary>
    [JsonProperty(PropertyName = "billing_cycle_start")]
    public long BillingCycleStart { get; set; }

    /// <summary>
    /// Gets or sets the the Billing cycle end.
    /// </summary>
    [JsonProperty(PropertyName = "billing_cycle_end")]
    public long BillingCycleEnd { get; set; }

    /// <summary>
    /// Gets or sets the creation date.
    /// </summary>
    [JsonProperty(PropertyName = "created_at")]
    public long CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the customer id.
    /// </summary>
    [JsonProperty(PropertyName = "customer_id")]
    public string CustomerId { get; set; }

    #endregion
  }
}
