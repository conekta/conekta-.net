using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Customer.
  /// </summary>
  public class CustomerOperationData : CustomerInfo
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; private set; }

    /// <summary>
    /// Gets or sets the payment sources.
    /// </summary>
    [JsonProperty(PropertyName = "payment_sources")]
    public List<PaymentSource> PaymentSources { get; set; }

    /// <summary>
    /// Gets or sets the fiscal entities.
    /// </summary>
    [JsonProperty(PropertyName = "fiscal_entities")]
    public List<FiscalEntity> FiscalEntities { get; set; }

    /// <summary>
    /// Gets or sets the shipping contacts.
    /// </summary>s
    [JsonProperty(PropertyName = "shipping_contacts")]
    public List<ShippingContact> ShippingContacts { get; set; }

    /// <summary>
    /// Gets or sets the subscription.
    /// </summary>
    [JsonProperty(PropertyName = "subscription")]
    public Subscription Subscription { get; set; }

    #endregion

    #region :: Constructors ::

    /// <summary>
    /// Customer Operation Data constructor.
    /// </summary>
    public CustomerOperationData() { }

    /// <summary>
    /// Customer Operation Data constructor.
    /// </summary>
    /// <param name="id">Identifier.</param>
    public CustomerOperationData(string id) => Id = id ?? throw new ArgumentNullException(nameof(id));

    #endregion
  }
}
