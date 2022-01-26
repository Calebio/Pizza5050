using System.Collections.Generic;

namespace Pizza5050.Shared
{
    /// <summary>
    /// Represents a pre-configured template for a pizza a user can order
    /// </summary>
    public class PizzaSpecial
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal BasePrice { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        List<PizzaTopping> toppings { get; set; } = new List<PizzaTopping>();

        public string GetFormattedBasePrice() => BasePrice.ToString("0.00");
    }
}
