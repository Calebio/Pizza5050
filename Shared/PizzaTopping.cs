using System.Collections.Generic;

namespace Pizza5050.Shared
{
    public class PizzaTopping
    {
        

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int? PizzaId { get; set; }

        public string GetFormattedPrice() => Price.ToString("0.00");

        //List<PizzaSpecial> pizzaSpecials { get; set; } = new List<PizzaSpecial>();
    }
    
}
