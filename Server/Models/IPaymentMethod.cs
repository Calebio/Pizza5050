using Pizza5050.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pizza5050.Server.Models
{
    public interface IPaymentMethod
    {
        Task<IEnumerable<PaymentMethod>> GetPaymentMethods();
        Task<PaymentMethod> GetPayment(int payId);
        Task<PaymentMethod> UpdatePaymentStatus(PaymentMethod payment);
        Task DeletePayment(int Id);
        Task<IEnumerable<PaymentMethod>> GetOrderDetails(int orderId);
        Task<bool> AddPayment(PaymentMethod payment);
    }
}
