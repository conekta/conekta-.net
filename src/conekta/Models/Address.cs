using Newtonsoft.Json;

namespace Conekta.Models
{
  /// <summary>
  /// Address.
  /// </summary>
  public class Address
  {
    #region :: Properties ::

    /// <summary>
    /// Gets or set the street 1.
    /// </summary>
    [JsonProperty(PropertyName = "street1")]
    public string Street1 { get; set; }

    /// <summary>
    /// Gets or set the street 2.
    /// </summary>
    [JsonProperty(PropertyName = "street2")]
    public string Street2 { get; set; }

    /// <summary>
    /// Gets or set the street 3.
    /// </summary>
    [JsonProperty(PropertyName = "street3")]
    public string Street3 { get; set; }

    /// <summary>
    /// Gets or set the city.
    /// </summary>
    [JsonProperty(PropertyName = "city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or set the state.
    /// </summary>
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or set the country.
    /// </summary>
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or set the zip.
    /// </summary>
    [JsonProperty(PropertyName = "zip")]
    public string Zip { get; set; }

    /// <summary>
    /// Gets or set the residencial.
    /// </summary>
    [JsonProperty(PropertyName = "residential")]
    public bool Residential { get; set; }

    /// <summary>
    /// Gets or set the Parent id.
    /// </summary>
    [JsonProperty(PropertyName = "parent_id")]
    public string ParentId { get; set; }

    #endregion
  }
}
