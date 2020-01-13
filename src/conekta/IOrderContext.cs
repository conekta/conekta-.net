using System.Threading.Tasks;
using Conekta.Models;
using System.Collections.Generic;

namespace Conekta
{
  /// <summary>
  /// Order context.
  /// </summary>
  public interface IOrderContext
  {
    #region :: Methods ::

    /// <summary>
    /// Creates the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="orderOperationData">Order operation data.</param>
    Task<Order> CreateAsync(OrderOperationData orderOperationData);

    /// <summary>
    /// Updates the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="orderOperationData">Order operation data.</param>
    Task<Order> UpdateAsync(OrderOperationData orderOperationData);

    /// <summary>
    /// Finds the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="orderId">Order identifier.</param>
    Task<Order> FindAsync(string orderId);

    /// <summary>
    /// Wheres the async.
    /// </summary>
    /// <returns>The async.</returns>
    /// <param name="query">Query.</param>
    Task<OrderList> WhereAsync(Dictionary<string, string> query);

    /// <summary>
    /// Capture the specified orderId.
    /// </summary>
    /// <returns>The capture.</returns>
    /// <param name="orderId">Order identifier.</param>
    Task<Order> Capture(string orderId);

    /// <summary>
    /// Creates the refund.
    /// </summary>
    /// <returns>The refund.</returns>
    /// <param name="orderId">Order identifier.</param>
    Task<Order> CreateRefund(string orderId);

    /// <summary>
    /// Creates the charge.
    /// </summary>
    /// <returns>The charge.</returns>
    /// <param name="charge">Charge.</param>
    Task<Charge> CreateCharge(Charge charge);

    /// <summary>
    /// Creates the line item.
    /// </summary>
    /// <returns>The line item.</returns>
    /// <param name="lineItem">Line item.</param>
    Task<LineItem> CreateLineItem(LineItem lineItem);

    Task<TaxLine> CreateTaxLine(TaxLine taxLine);

    #endregion
  }
}
