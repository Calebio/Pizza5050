using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza5050.Server.Models
{
    public interface IToppingRepo
    {
        Task<IEnumerable<Topping>> GetToppings();
        Task<Topping> GetTopping(int topId);
        Task<Topping> AddTopping(Topping topping);
        Task<Topping> UpdateTopping(Topping topping);
        Task DeleteTopping(int topId);
    }
}
