using System.Net.Http;
using Newtonsoft.Json;

namespace Conekta.Utils
{
  /// <summary>
  /// Http response extensions.
  /// </summary>
  internal static class HttpResponseExtensions
  {
    #region :: Methods ::

    /// <summary>
    /// Contents the type of the as.
    /// </summary>
    /// <returns>The as type.</returns>
    /// <param name="response">Response.</param>
    /// <typeparam name="T">The 1st type parameter.</typeparam>
    public static T ContentAsType<T>(this HttpResponseMessage response)
    {
      var data = response.Content.ReadAsStringAsync().Result;

      return string.IsNullOrEmpty(data) ? default : JsonConvert.DeserializeObject<T>(data);
    }

    /// <summary>
    /// Contents as json.
    /// </summary>
    /// <returns>The as json.</returns>
    /// <param name="response">Response.</param>
    public static string ContentAsJson(this HttpResponseMessage response)
    {
      var data = response.Content.ReadAsStringAsync().Result;

      return JsonConvert.SerializeObject(data, Formatting.Indented,
        new JsonSerializerSettings
        {
          NullValueHandling = NullValueHandling.Ignore
        });
    }

    /// <summary>
    /// Contents as string.
    /// </summary>
    /// <returns>The as string.</returns>
    /// <param name="response">Response.</param>
    public static string ContentAsString(this HttpResponseMessage response) =>
      response.Content.ReadAsStringAsync().Result;

    #endregion
  }
}
