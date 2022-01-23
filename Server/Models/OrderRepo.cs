using Microsoft.EntityFrameworkCore;
using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza5050.Server.Models
{
    public class OrderRepo : IOrderRepo
    {
        private readonly PizzaDBContext conn;

        public OrderRepo(PizzaDBContext db)
        {
            conn = db;
        }


        public async Task<Order> AddOrder(Order order)
        {
            var result = await conn.Order.AddAsync(order);
            await conn.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteOrder(int Id)
        {
            var result = await conn.Order.FirstOrDefaultAsync(o => o.OrderId == Id);
            if (result != null)
            {
                 conn.Order.Remove(result);
                await conn.SaveChangesAsync();

            }
        }

        public async Task<Order> GetOrder(int orderId)
        {
            var result = await conn.Order.FirstOrDefaultAsync(e => e.OrderId == orderId);
            return result;
        }

        public async Task<IEnumerable<Order>> GetOrderByUser(int userId)
        {
            return await conn.Order.Where(w => w.OrderBy == userId).ToListAsync();
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            return await conn.Order.ToListAsync();
        }

        public async Task<IEnumerable<PizzaSpecial>> GetPizzasByOrderId(int orderId)
        {
            return await conn.PizzaSpecial.Where(a => a.OrderId == orderId).Include(b => b.Name).ToListAsync();
        }

        public Task<Order> Update(Order order)
        {
            throw new NotImplementedException();

        }

        
    }
}
