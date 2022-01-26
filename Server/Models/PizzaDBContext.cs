using Microsoft.EntityFrameworkCore;
using Pizza5050.Shared;

namespace Pizza5050.Server
{
    public class PizzaDBContext : DbContext
    {
        public PizzaDBContext(DbContextOptions<PizzaDBContext> options)
        : base(options)
        {

        }
        //public DbSet<User> Users { get; set; }
        public DbSet<Order> Order { get; set; }
        //public DbSet<OrderWithStatus> OrderWithStatuses { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaSpecial> PizzaSpecial { get; set; }
        public DbSet<PizzaTopping> PizzaToppings { get; set; }
        public DbSet<PaymentMethod> PaymentMethod { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     //base.OnModelCreating(modelBuilder);

        //     //// Configuring a many-to-many special -> topping relationship that is friendly for serialization
        //     modelBuilder.Entity<PizzaTopping>().HasKey(pst => new { pst.PizzaId, pst.Id });
        //     modelBuilder.Entity<PizzaTopping>().HasData();
        //     //modelBuilder.Entity<PizzaTopping>().HasOne<Pizza>().WithMany(ps => ps.Toppings);
        //     //modelBuilder.Entity<PizzaTopping>().HasOne(pst => pst.Name).WithMany();

        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)// Crée la migration
        {
            //modelBuilder.Entity<>().Property(p => p.Prix).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<PizzaTopping>().Property(p => p.Price).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PizzaSpecial>().Property(r => r.BasePrice).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<PaymentMethod>().Property(i => i.TotalAmount).HasColumnType("decimal(18,2)");

        }


    }
}
