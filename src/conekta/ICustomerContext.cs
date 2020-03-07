using System.Collections.Generic;
using System.Threading.Tasks;
using Conekta.Models;

namespace Conekta
{
  /// <summary>
  /// Customer context interface.
  /// </summary>
  public interface ICustomerContext
  {
    #region :: Methods ::

    /// <summary>
    /// Creates the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="customerOperationData">Customer data.</param>
    Task<Customer> CreateAsync(CustomerOperationData customerOperationData);

    /// <summary>
    /// Updates the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="customerOperationData">customer operation data.</param>
    Task<Customer> UpdateAsync(CustomerOperationData customerOperationData);

    /// <summary>
    /// Finds the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="customerId">Customer identifier.</param>
    Task<Customer> FindAsync(string customerId);

    /// <summary>
    /// Wheres the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="query">Query.</param>
    Task<CustomerList> WhereAsync(Dictionary<string, string> query);

    /// <summary>
    /// Destroy the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="customerId">Customer identifier.</param>
    Task<Customer> DestroyAsync(string customerId);

    /// <summary>
    /// Creates card.
    /// </summary>
    /// <returns>Payment source created.</returns>
    /// <param name="customerId">Customer identifier.</param>
    /// <param name="paymentSource">Payment source to create.</param>
    Task<PaymentSource> CreatePaymentSourceAsync(string customerId, IPaymentSourceOperationData paymentSourceOperationData);

    /// <summary>
    /// Creates shipping contact.
    /// </summary>
    /// <returns>Shipping contact created.</returns>
    /// <param name="customerId">Customer identifier.</param>
    /// <param name="shippingContact">Shipping contact to create.</param>
    Task<ShippingContact> CreateShippingContact(string customerId, ShippingContact shippingContact);

    /// <summary>
    /// Creates subscription.
    /// </summary>
    /// <returns>Subscription created.</returns>
    /// <param name="customerId">Customer identifier.</param>
    /// <param name="subscription">Subscription to create.</param>
    Task<Subscription> CreateSubscription(string customerId, Subscription subscription);

    #endregion
  }
}
