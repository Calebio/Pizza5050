using Microsoft.EntityFrameworkCore;
using Pizza5050.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pizza5050.Server.Models
{


    public class ToppingRepo : IToppingRepo
    {

        private readonly PizzaDBContext conn;


        public ToppingRepo(PizzaDBContext db)
        {
            conn = db;
        }


        public async Task<PizzaTopping> AddTopping(PizzaTopping topping)
        {
            var result = await conn.PizzaToppings.AddAsync(topping);
            await conn.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteTopping(int topId)
        {
            var result = await conn.PizzaToppings.FirstOrDefaultAsync(d => d.Id == topId);
            if (result != null)
            {
                conn.PizzaToppings.Remove(result);
                await conn.SaveChangesAsync();
            }
        }

        public async Task<PizzaTopping> GetTopping(int topId)
        {
            var topping = await conn.PizzaToppings.FirstOrDefaultAsync(e => e.Id == topId);
            return topping;
        }

        public async Task<IEnumerable<PizzaTopping>> GetToppings()
        {
            return await conn.PizzaToppings.ToListAsync();
        }

        public async Task<PizzaTopping> UpdateTopping(PizzaTopping topping)
        {
            var result = await conn.PizzaToppings.FirstOrDefaultAsync(e => e.Id == topping.Id);
            if (result != null)
            {
                result.Name = topping.Name;
                result.Price = topping.Price;

                await conn.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
