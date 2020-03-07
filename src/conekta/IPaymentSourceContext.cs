using System.Threading.Tasks;
using Conekta.Models;

namespace Conekta
{
  /// <summary>
  /// 
  /// </summary>
  public interface IPaymentSourceContext
  {
    ///// <summary>
    ///// 
    ///// </summary>
    ///// <param name="paymentSourceOperationData"></param>
    ///// <returns></returns>
    //Task<PaymentSource> UpdateAsync(IPaymentSourceOperationData paymentSourceOperationData);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parentId"></param>
    /// <param name="paymentMethodId"></param>
    /// <returns></returns>
    Task<PaymentSource> RemoveAsync(string parentId, string paymentMethodId);
  }
}
