using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Conekta.Exceptions;
using Conekta.Models;
using Conekta.Utils;

namespace Conekta
{
  /// <summary>
  /// Customer context.
  /// </summary>
  public class CustomerContext : ICustomerContext
  {
    #region :: Private Fields ::

    /// <summary>
    /// The resource uri.
    /// </summary>
    private const string RESOURCEURI = "/customers";

    /// <summary>
    /// The http request factory.
    /// </summary>
    private IHttpRequestFactory _httpRequestFactory;

    #endregion

    #region :: Constructor ::

    /// <summary>
    /// Initializes a new instance of the <see cref="T:Conekta.CustomerContext"/> class.
    /// </summary>
    public CustomerContext() => _httpRequestFactory = new HttpRequestFactory(ConektaInfo.HttpClientFactory);

    #endregion

    #region :: Methods ::

    /// <summary>
    /// Creates the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="customer">Customer data.</param>
    public async Task<Customer> CreateAsync(CustomerOperationData customer)
    {
      customer.Validate();

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Post, RESOURCEURI, customer);

      //Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Customer>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    /// <summary>
    /// Updates the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="customerOperationData">Customer operation data.</param>
    public async Task<Customer> UpdateAsync(CustomerOperationData customerOperationData)
    {
      customerOperationData.Validate();

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Put, $"{RESOURCEURI}/{customerOperationData.Id}", customerOperationData);

      //Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Customer>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    /// <summary>
    /// Finds the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="customerId">Customer identifier.</param>
    public async Task<Customer> FindAsync(string customerId)
    {
      if (customerId is null)
      {
        throw new ArgumentNullException(nameof(customerId));
      }

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Get, $"{RESOURCEURI}/{customerId}");

      //Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<Customer>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    /// <summary>
    /// Wheres the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="query">Query.</param>
    public async Task<CustomerList> WhereAsync(Dictionary<string, string> query)
    {
      if (query is null)
      {
        throw new ArgumentNullException(nameof(query));
      }

      var url = $"?{string.Join("&", query.Select(x => String.Format("{0}={1}", x.Key, x.Value)))}";

      var response = await _httpRequestFactory.SendAsync(HttpMethod.Get, $"{RESOURCEURI}{url}");

      //Console.WriteLine($"======= {response.StatusCode}, {await response.Content.ReadAsStringAsync()}");

      if (response.IsSuccessStatusCode)
      {
        return response.ContentAsType<CustomerList>();
      }

      throw new ConektaHttpException(await response.Content.ReadAsStringAsync(), response.StatusCode);
    }

    /// <summary>
    /// Destroy the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="customerId">Customer identifier.</param>
    public Task<Customer> DestroyAsync(string customerId)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates card.
    /// </summary>
    /// <returns>Payment source created.</returns>
    /// <param name="customerId">Customer identifier.</param>
    /// <param name="paymentSource">Payment source to create.</param>
    public Task<PaymentSource> CreateCardAsync(string customerId, PaymentSource paymentSource)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates card.
    /// </summary>
    /// <returns>Payment source created.</returns>
    /// <param name="customerId">Customer identifier.</param>
    /// <param name="paymentSource">Payment source to create.</param>
    public Task<PaymentSource> CreateOfflineRecurrentReferenceAsync(string customerId, PaymentSource paymentSource)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates shipping contact.
    /// </summary>
    /// <returns>Shipping contact created.</returns>
    /// <param name="customerId">Customer identifier.</param>
    /// <param name="shippingContact">Shipping contact to create.</param>
    public Task<ShippingContact> CreateShippingContact(string customerId, ShippingContact shippingContact)
    {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Creates subscription.
    /// </summary>
    /// <returns>Subscription created.</returns>
    /// <param name="customerId">Customer identifier.</param>
    /// <param name="subscription">Subscription to create.</param>
    public Task<Subscription> CreateSubscription(string customerId, Subscription subscription)
    {
      throw new NotImplementedException();
    }

    #endregion
  }
}
