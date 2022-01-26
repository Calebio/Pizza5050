using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza5050.Client.Services
{
    public interface IPizzaSpecials 
    {
        Task<IEnumerable<PizzaSpecial>> GetPizzaSpecials();
        Task<PizzaSpecial> AddPizza(PizzaSpecial pizzaSpecial);
        Task<PizzaSpecial> UpdatePizza(PizzaSpecial pizza);
        Task DeletePizza(int id);
        Task<PizzaSpecial> GetPizzaSpecial(int PizzaId);
    }
}
