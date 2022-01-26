using Pizza5050.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pizza5050.Server.Models
{
    public interface IToppingRepo
    {
        Task<IEnumerable<PizzaTopping>> GetToppings();
        Task<PizzaTopping> GetTopping(int topId);
        Task<PizzaTopping> AddTopping(PizzaTopping topping);
        Task<PizzaTopping> UpdateTopping(PizzaTopping topping);
        Task DeleteTopping(int topId);
    }
}
