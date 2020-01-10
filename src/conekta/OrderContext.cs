using System;
using System.Net.Http;
using System.Threading.Tasks;
using Conekta.Models;
using Conekta.Utils;
using Conekta.Exceptions;

namespace Conekta
{
  /// <summary>
  /// Order context.
  /// </summary>
  public class OrderContext
  {
    #region :: Private Fields ::

    /// <summary>
    /// The resource uri.
    /// </summary>
    private const string RESOURCEURI = "/orders";

    /// <summary>
    /// The http request factory.
    /// </summary>
    private IHttpRequestFactory _httpRequestFactory;

    #endregion

    #region :: Constructor ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.OrderContext"/> class.
    /// </summary>
    public OrderContext() => _httpRequestFactory = new HttpRequestFactory(ConektaInfo.HttpClientFactory);

    #endregion

    #region :: Methods ::

    /// <summary>
    /// Creates the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="orderCreationData">Order creation data.</param>
    public async Task<Order> CreateAsync(OrderCreationData orderCreationData)
    {
      orderCreationData.Validate();

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Post, RESOURCEURI, orderCreationData);

      Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Order>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    #endregion
  }
}
