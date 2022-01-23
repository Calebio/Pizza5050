namespace Pizza5050.Shared
{
    public class Topping
    {
        

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public Topping Toppings { get; set; }

        public string GetFormattedPrice() => Price.ToString("0.00");
    }
}
