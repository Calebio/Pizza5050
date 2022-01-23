using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza5050.Server.Models
{
    public interface IOrderRepo
    {
        Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrder(int orderId);
        Task<Order> AddOrder(Order order);
        //Task<Order> GetOrder(DateTime orderDay);
        Task<Order> Update(Order order);
        Task DeleteOrder(int orderId);
        Task<IEnumerable<Order>> GetOrderByUser(int userId);
        Task<IEnumerable<PizzaSpecial>> GetPizzasByOrderId(int orderId);
       
    }
}
