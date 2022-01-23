using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza5050.Shared
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string PayType { get; set; }
        public DateTime PayDay { get; set; }
        public decimal TotalAmount { get; set; }
        //still checking this tho
        public int OrderId { get; set; }


        public List<Order> Orders { get; set; } = new List<Order>();

        //should be used to get the amount in order class
        public virtual Order OrderInfo { get; set; }



        public string PaymentStatus { get; set; }

        //get user making the payment
        //public virtual User UserMakingPayment { get; set; }

    }
}
