using Pizza5050.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pizza5050.Server
{
    public interface IPizzaSpecialsRepo
    {
        Task<IEnumerable<PizzaSpecial>> GetPizzaSpecials();
        Task<PizzaSpecial> AddPizza(PizzaSpecial pizzaSpecial);
        Task<PizzaSpecial> UpdatePizza(PizzaSpecial pizza);
        Task DeletePizza(int id);
        Task<PizzaSpecial> GetPizzaSpecial(int PizzaId);
    }
}
