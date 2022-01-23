using Microsoft.EntityFrameworkCore;
using Pizza5050.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza5050.Server
{
    public class PizzaSpecialsRepo : IPizzaSpecialsRepo
    {
        private readonly PizzaDBContext conn;

        public PizzaSpecialsRepo(PizzaDBContext db)
        {
            conn = db;
        }

        async Task<IEnumerable<PizzaSpecial>> IPizzaSpecialsRepo.GetPizzaSpecials()
        {
            return await conn.PizzaSpecial.ToListAsync();
        }

        async Task<PizzaSpecial> IPizzaSpecialsRepo.GetPizzaSpecial(int PizzaId)
        {
            var result = await conn.PizzaSpecial.FirstOrDefaultAsync(p => p.Id == PizzaId);
            return result;
        }

        public async Task<PizzaSpecial> AddPizza(PizzaSpecial pizzaSpecial)
        {
            var result = await conn.PizzaSpecial.AddAsync(pizzaSpecial);
            await conn.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<PizzaSpecial> UpdatePizza(PizzaSpecial pizza)
        {
            var result = await conn.PizzaSpecial.FirstOrDefaultAsync(e => e.Id == pizza.Id);
            if(result != null )
            {
                result.Name = pizza.Name;
                result.Description = pizza.Description;
                result.BasePrice = result.BasePrice;
                result.ImageUrl = result.ImageUrl;

                await conn.SaveChangesAsync();

                return result;
            }
            return null;
            
        }

        public async Task DeletePizza(int id)
        {
            var result = await conn.PizzaSpecial.FirstOrDefaultAsync(i => i.Id == id);
            if(result != null)
            {
                conn.PizzaSpecial.Remove(result);
                await conn.SaveChangesAsync();
            }
        }
    }
}
