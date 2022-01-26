using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Pizza5050.Client.Services
{
    public class PizzaSpecialService : IPizzaSpecials
    {
        private readonly HttpClient httpClient;

        public PizzaSpecialService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public Task<PizzaSpecial> AddPizza(PizzaSpecial pizzaSpecial)
        {
            throw new NotImplementedException();
        }

        public Task DeletePizza(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PizzaSpecial> GetPizzaSpecial(int PizzaId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PizzaSpecial>> GetPizzaSpecials()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<PizzaSpecial>>("/api/pizzaspecials");
        }

        public Task<PizzaSpecial> UpdatePizza(PizzaSpecial pizza)
        {
            throw new NotImplementedException();
        }
    }
}
