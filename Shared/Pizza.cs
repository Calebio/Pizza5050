﻿using System.Collections.Generic;
using System.Linq;

namespace Pizza5050.Shared
{
    /// <summary>
    /// Represents a customized pizza as part of an order
    /// </summary>
    public class Pizza
    {
        public const int DefaultSize = 12;
        public const int MinimumSize = 9;
        public const int MaximumSize = 17;

        public int Id { get; set; }

        public int OrderId { get; set; }

        public PizzaSpecial Special { get; set; }

        public int SpecialId { get; set; }

        public int Size { get; set; }

        public List<Topping> Toppings { get; set; }

        public decimal GetBasePrice()
        {
            return ((decimal)Size / (decimal)DefaultSize) * Special.BasePrice;
        }

        public decimal GetTotalPrice()
        {
            //check this when the code is running
            return GetBasePrice() + Toppings.Sum(t => t.Price);
        }

        public string GetFormattedTotalPrice()
        {
            return GetTotalPrice().ToString("0.00");
        }
    }
}