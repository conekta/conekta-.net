using Conekta.Enumerations;

namespace Conekta
{
  /// <summary>
  /// Conekta info.
  /// </summary>
  public static class ConektaInfo
  {
    #region :: Properties ::

    /// <summary>
    /// Gets the base API Uri.
    /// </summary>
    /// <value>The base API Uri.</value>
    public static string BaseAPIUri { get; } = "https://api.conekta.io";

    /// <summary>
    /// Gets the API Version.
    /// </summary>
    /// <value>The API Version.</value>
    public static APIVersion APIVersion { get; } = APIVersion.V2;

    /// <summary>
    /// Gets or sets the API Locale.
    /// </summary>
    /// <value>The API Locale.</value>
    public static APILocale APILocale { get; set; } = APILocale.Spanish;

    /// <summary>
    /// Gets or sets the API Key.
    /// </summary>
    /// <value>The API Key.</value>
    public static string APIKey { get; set; } = string.Empty;

    #endregion
  }
}
