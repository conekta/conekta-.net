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

    /// <summary>
    /// Capture the specified orderId.
    /// </summary>
    /// <returns>The capture.</returns>
    /// <param name="orderId">Order identifier.</param>
    public async Task<Order> CaptureAsync(string orderId)
    {
      if (orderId is null)
      {
        throw new ArgumentNullException(nameof(orderId));
      }

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Put, $"{RESOURCEURI}/{orderId}/capture", "{}");

      Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Order>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }


    /// <summary>
    /// Creates the refund.
    /// </summary>
    /// <returns>The refund.</returns>
    /// <param name="orderId">Order identifier.</param>
    /// <param name="refundInfo">Refund information</param>
    public async Task<Order> CreateRefundAsync(string orderId, RefundInfo refundInfo)
    {
      if (orderId is null)
      {
        throw new ArgumentNullException(nameof(orderId));
      }

      refundInfo.Validate();

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Post, $"{RESOURCEURI}/{orderId}/refunds", refundInfo);

      Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Order>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    public Task<ChargeOperationData> CreateChargeAsync(ChargeOperationData charge)
    {
      throw new NotImplementedException();
    }

    public Task<LineItem> CreateLineItemAsync(LineItem lineItem)
    {
      throw new NotImplementedException();
    }

    public Task<TaxLine> CreateTaxLineAsync(TaxLine taxLine)
    {
      throw new NotImplementedException();
    }

    public Task<ShippingLine> CreateShippingLineAsync(ShippingLine shippingLine)
    {
      throw new NotImplementedException();
    }

    public Task<TaxLine> CreateDiscountLineAsync(DiscountLine discountLine)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
