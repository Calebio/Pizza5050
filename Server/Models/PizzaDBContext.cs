using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza5050.Shared
{
    public class PizzaDBContext : DbContext
    {
        public PizzaDBContext(DbContextOptions<PizzaDBContext> options)
        : base(options)
        {
                
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Order { get; set; }
        //public DbSet<OrderWithStatus> OrderWithStatuses { get; set; }
        //public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaSpecial> PizzaSpecial { get; set; }
        //public DbSet<PizzaTopping> PizzaToppings { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }

    }
}
