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

    #endregion
  }
}
