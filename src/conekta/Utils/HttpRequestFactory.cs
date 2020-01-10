using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Conekta.Utils
{
  /// <summary>
  /// Http request factory.
  /// </summary>
  internal class HttpRequestFactory : IHttpRequestFactory
  {
    #region :: Private Fields ::

    /// <summary>
    /// The http client factory.
    /// </summary>
    private readonly IHttpClientFactory _httpClientFactory;

    /// <summary>
    /// The accept header.
    /// </summary>
    private readonly string _acceptHeader = "application/json";

    #endregion

    #region :: Constructor ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.Utils.HttpRequestFactory"/> class.
    /// </summary>
    /// <param name="httpClientFactory">Http client factory.</param>
    internal HttpRequestFactory(IHttpClientFactory httpClientFactory) =>
      _httpClientFactory = httpClientFactory;

    #endregion

    #region :: Methods ::

    /// <summary>
    /// Sends the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="httpMethod">Http method.</param>
    /// <param name="resourceUri">Resource URI.</param>
    public Task<HttpResponseMessage> SendAsync(HttpMethod httpMethod, string resourceUri) =>
      SendAsync(httpMethod, resourceUri, null);

    public async Task<HttpResponseMessage> SendAsync(HttpMethod httpMethod, string resourceUri, object data)
    {
      if (httpMethod is null)
      {
        throw new ArgumentNullException(nameof(httpMethod));
      }

      if (resourceUri is null)
      {
        throw new ArgumentNullException(nameof(resourceUri));
      }

      using (var request = new HttpRequestMessage
      {
        Method = httpMethod,
        RequestUri = new Uri($"{ConektaInfo.BaseAPIUri}{resourceUri}")
      })
      {
        request.Headers.Accept.Add(
          new MediaTypeWithQualityHeaderValue($"application/vnd.conekta-v{ConektaInfo.APIVersion.Id}+json"));
        request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(_acceptHeader));

        //request.Headers.UserAgent.Add(
        //new ProductInfoHeaderValue($"Conekta/v1 DotNetBindings10/Conekta::{ConektaInfo.APIVersion.Id}"));

        var apiKeyBytes = Encoding.UTF8.GetBytes(ConektaInfo.APIKey);

        request.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(apiKeyBytes)}:");
        request.Headers.Add("Accept-Language", ConektaInfo.APILocale.Id);

        var userAgent = JObject.FromObject(new
        {
          bindings_version = ConektaInfo.APIVersion.Id,
          lang = "netcore",
          lang_version = Environment.Version,
          publisher = "conekta",
          uname = Environment.OSVersion
        });

        request.Headers.Add("X-Conekta-Client-User-Agent", userAgent.ToString());

        if (data != null)
        {
          var serializedData = JsonConvert.SerializeObject(data, Formatting.Indented,
            new JsonSerializerSettings
            {
              NullValueHandling = NullValueHandling.Ignore
            });

          Console.WriteLine($"serializedData -> {serializedData}");

          request.Content = new StringContent(serializedData, Encoding.UTF8, "application/json");
        }

        using (var client = _httpClientFactory.CreateClient())
        {
          return await client.SendAsync(request);
        }
      }
    }

    #endregion
  }
}
