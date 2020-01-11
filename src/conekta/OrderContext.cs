using System;
using System.Net.Http;
using System.Threading.Tasks;
using Conekta.Models;
using Conekta.Utils;
using Conekta.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace Conekta
{
  /// <summary>
  /// Order context.
  /// </summary>
  public class OrderContext : IOrderContext
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
    /// <param name="orderOperationData">Order operation data.</param>
    public async Task<Order> CreateAsync(OrderOperationData orderOperationData)
    {
      orderOperationData.Validate();

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Post, RESOURCEURI, orderOperationData);

      Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Order>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    /// <summary>
    /// Updates the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="orderOperationData">Order operation data.</param>
    public async Task<Order> UpdateAsync(OrderOperationData orderOperationData)
    {
      orderOperationData.Validate();

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Put, $"{RESOURCEURI}/{orderOperationData.Id}", orderOperationData);

      Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Order>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    /// <summary>
    /// Finds the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="orderId">Order identifier.</param>
    public async Task<Order> FindAsync(string orderId)
    {
      if (orderId is null)
      {
        throw new ArgumentNullException(nameof(orderId));
      }

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Get, $"{RESOURCEURI}/{orderId}");

      Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Order>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    /// <summary>
    /// Wheres the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="query">Query.</param>
    public async Task<OrderList> WhereAsync(Dictionary<string, string> query)
    {
      if (query is null)
      {
        throw new ArgumentNullException(nameof(query));
      }

      var url = $"?{string.Join("&", query.Select(x => String.Format("{0}={1}", x.Key, x.Value)))}";

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Get, $"{RESOURCEURI}{url}");

      Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<OrderList>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    #endregion
  }
}
