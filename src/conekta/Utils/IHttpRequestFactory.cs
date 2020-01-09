using System.Net.Http;
using System.Threading.Tasks;

namespace Conekta.Utils
{
  /// <summary>
  /// Http request factory.
  /// </summary>
  public interface IHttpRequestFactory
  {
    #region :: Methods ::

    /// <summary>
    /// Sends the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="httpMethod">Http method.</param>
    /// <param name="resourceUri">Resource URI.</param>
    Task<HttpResponseMessage> SendAsync(HttpMethod httpMethod, string resourceUri);

    /// <summary>
    /// Sends the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="httpMethod">Http method.</param>
    /// <param name="resourceUri">Resource URI.</param>
    /// <param name="data">Data.</param>
    Task<HttpResponseMessage> SendAsync(HttpMethod httpMethod, string resourceUri, object data);

    #endregion
  }
}
