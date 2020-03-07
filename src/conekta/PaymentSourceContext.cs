using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Conekta.Exceptions;
using Conekta.Models;
using Conekta.Utils;
using Newtonsoft.Json;

namespace Conekta
{
  /// <summary>
  /// 
  /// </summary>
  public class PaymentSourceContext : IPaymentSourceContext
  {
    #region :: Private Fields ::

    /// <summary>
    /// The resource uri.
    /// </summary>
    private const string RESOURCEURI = "/customers";

    /// <summary>
    /// The http request factory.
    /// </summary>
    private readonly IHttpRequestFactory _httpRequestFactory;

    #endregion

    #region :: Constructor ::

    /// <summary>
    /// 
    /// </summary>
    public PaymentSourceContext() => _httpRequestFactory = new HttpRequestFactory(ConektaInfo.HttpClientFactory);

    #endregion

    #region :: Methods ::

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parentId"></param>
    /// <param name="paymentMethodId"></param>
    /// <returns></returns>
    public async Task<PaymentSource> RemoveAsync(string parentId, string paymentMethodId)
    {
      if (string.IsNullOrEmpty(parentId))
      {
        throw new ArgumentException("message", nameof(parentId));
      }

      if (string.IsNullOrEmpty(paymentMethodId))
      {
        throw new ArgumentException("message", nameof(paymentMethodId));
      }

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Delete,
        $"{RESOURCEURI}/{parentId}/payment_sources/{paymentMethodId}");

      // Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<PaymentSource>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="paymentSourceOperationData"></param>
    ///// <returns></returns>
    //public async Task<PaymentSource> UpdateAsync(IPaymentSourceOperationData paymentSourceOperationData)
    //{
    //  if (paymentSourceOperationData is null)
    //  {
    //    throw new ArgumentNullException(nameof(paymentSourceOperationData));
    //  }

    //  var response = await _httpRequestFactory.SendAsync(HttpMethod.Put, $"{RESOURCEURI}/{paymentSourceOperationData.ParentId}/payment_sources/{paymentSourceOperationData.Id}", paymentSourceOperationData);

    //  Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

    //  if (response.IsSuccessStatusCode)
    //  {
    //    return response.ContentAsType<PaymentSource>();
    //  }

    //  throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    //}

    #endregion
  }
}
