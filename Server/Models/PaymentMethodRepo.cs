using Microsoft.EntityFrameworkCore;
using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza5050.Server.Models
{
    public class PaymentMethodRepo : IPaymentMethod
    {
        private readonly PizzaDBContext conn;


        public PaymentMethodRepo(PizzaDBContext db)
        {
            conn = db;
        }

        public async Task<bool> AddPayment(PaymentMethod payment)
        {
            if (payment != null)
            {
                payment.PayDay = DateTime.Now;
                payment.PaymentStatus = "Pending";

                await conn.PaymentMethod.AddAsync(payment);
                await conn.SaveChangesAsync();

                return true;
            }
            return true;

        }

        public async Task DeletePayment(int Id)
        {
            var result = await conn.PaymentMethod.FirstOrDefaultAsync(e => e.Id == Id);
            if (result != null)
            {
                conn.PaymentMethod.Remove(result);
                await conn.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<PaymentMethod>> GetOrderDetails(int orderId)
        {
            return await conn.PaymentMethod.Where(e => e.OrderId == orderId).Include(w => w.OrderInfo).ToListAsync();
        }

        public async Task<PaymentMethod> GetPayment(int payId)
        {
            var result = await conn.PaymentMethod.FirstOrDefaultAsync(p => p.Id == payId);
            return result;
        }

        public async Task<IEnumerable<PaymentMethod>> GetPaymentMethods()
        {
            return await conn.PaymentMethod.ToListAsync();
        }

        public async Task<PaymentMethod> UpdatePaymentStatus(PaymentMethod payment)
        {
            var result = await conn.PaymentMethod.FirstOrDefaultAsync(e => e.Id == payment.Id);
            if (result != null)
            {
                result.PaymentStatus = "Confirmed!";

                await conn.SaveChangesAsync();

                return result;
            }
            return null;
        }
    }
}
