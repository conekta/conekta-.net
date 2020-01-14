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
    Task<Order> CaptureAsync(string orderId);

    /// <summary>
    /// Creates the refund.
    /// </summary>
    /// <returns>The refund.</returns>
    /// <param name="orderId">Order identifier.</param>
    /// <param name="refundInfo">Refund information</param>
    Task<Order> CreateRefundAsync(string orderId, RefundInfo refundInfo);

    /// <summary>
    /// Creates the charge.
    /// </summary>
    /// <returns>The charge.</returns>
    /// <param name="charge">Charge.</param>
    Task<ChargeOperationData> CreateChargeAsync(ChargeOperationData charge);

    /// <summary>
    /// Creates the line item.
    /// </summary>
    /// <returns>The line item.</returns>
    /// <param name="lineItem">Line item.</param>
    Task<LineItem> CreateLineItemAsync(LineItem lineItem);

    /// <summary>
    /// Creates the tax line.
    /// </summary>
    /// <param name="taxLine">The tax line</param>
    /// <returns>Taxline created.</returns>
    Task<TaxLine> CreateTaxLineAsync(TaxLine taxLine);

    /// <summary>
    /// Creates shipping line.
    /// </summary>
    /// <param name="shippingLine">The shipping line.</param>
    /// <returns>Shipping line created.</returns>
    Task<ShippingLine> CreateShippingLineAsync(ShippingLine shippingLine);

    /// <summary>
    /// Creates the discount line.
    /// </summary>
    /// <param name="discountLine">The discount line</param>
    /// <returns>Discount line created.</returns>
    Task<TaxLine> CreateDiscountLineAsync(DiscountLine discountLine);

    #endregion
  }
}
