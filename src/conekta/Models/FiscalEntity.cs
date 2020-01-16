using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Fiscla Entity.
  /// </summary>
  public class FiscalEntity
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the tax id.
    /// </summary>
    [JsonProperty(PropertyName = "tax_id")]
    public string TaxId { get; set; }

    /// <summary>
    /// Gets or sets the company name.
    /// </summary>
    [JsonProperty(PropertyName = "company_name")]
    public string CompanyName { get; set; }

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
