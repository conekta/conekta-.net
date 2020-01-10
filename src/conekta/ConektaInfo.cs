using System.Net.Http;
using Conekta.Enumerations;
using Conekta.Exceptions;

namespace Conekta
{
  /// <summary>
  /// Conekta info.
  /// </summary>
  public static class ConektaInfo
  {
    #region :: Private fields ::

    /// <summary>
    /// API Key.
    /// </summary>
    private static string _apiKey = string.Empty;

    /// <summary>
    /// The API locale.
    /// </summary>
    private static APILocale apiLocale = APILocale.Spanish;

    #endregion

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
    public static APILocale APILocale
    {
      get => apiLocale;
      set => apiLocale = value ?? throw new ConektaException("APILocale cannot be null");
    }

    /// <summary>
    /// Gets or sets the API Key.
    /// </summary>
    /// <value>The API Key.</value>
    public static string APIKey
    {
      get => _apiKey;
      set => _apiKey = value ?? throw new ConektaException("APIKey cannot be null");
    }

    /// <summary>
    /// Gets the http client factory.
    /// </summary>
    /// <value>The http client factory.</value>
    internal static IHttpClientFactory HttpClientFactory { get; private set; }

    #endregion

    #region :: Methods ::

    /// <summary>
    /// Sets the http client factory.
    /// </summary>
    /// <param name="httpClientFactory">Http client factory.</param>
    public static void SetHttpClientFactory(IHttpClientFactory httpClientFactory) =>
      HttpClientFactory = httpClientFactory ?? throw new System.ArgumentNullException(nameof(httpClientFactory));

    #endregion
  }
}
