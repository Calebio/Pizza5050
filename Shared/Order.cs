using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Pizza5050.Shared
{
    public class Order
    {
        public int OrderId { get; set; }

        public string UserId { get; set; }

        public DateTime OrderTime { get; set; }

        //public Address DeliveryAddress { get; set; } = new Address();

        //public LatLong DeliveryLocation { get; set; }

        [ForeignKey("OrderByUser")]
        public int? OrderBy { get; set; }

        public virtual User OrderByUser { get; set; }
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();

        public decimal GetTotalPrice() => Pizzas.Sum(p => p.GetTotalPrice());

        public string GetFormattedTotalPrice() => GetTotalPrice().ToString("0.00");
    }
}
