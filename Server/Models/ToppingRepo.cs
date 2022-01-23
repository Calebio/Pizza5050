using Microsoft.EntityFrameworkCore;
using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
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


        public async Task<Topping> AddTopping(Topping topping)
        {
            var result = await conn.Toppings.AddAsync(topping);
            await conn.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteTopping(int topId)
        {
            var result = await conn.Toppings.FirstOrDefaultAsync(d => d.Id == topId);
            if(result != null)
            {
                conn.Toppings.Remove(result);
                await conn.SaveChangesAsync();
            }
        }

        public async Task<Topping> GetTopping(int topId)
        {
            var topping = await conn.Toppings.FirstOrDefaultAsync(e => e.Id == topId);
            return topping;
        }

        public async Task<IEnumerable<Topping>> GetToppings()
        {
            return await conn.Toppings.ToListAsync();
        }

        public async Task<Topping> UpdateTopping(Topping topping)
        {
            var result = await conn.Toppings.FirstOrDefaultAsync(e => e.Id == topping.Id);
            if(result != null)
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
