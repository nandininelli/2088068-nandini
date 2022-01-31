using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFoodSupply
{
    public class Supply
    {
        public FoodDetails FoodItem { get; set; }
        public int Count { get; set; }
        public double Cost { get; set; }
        public DateTime RequestDate { get; set; }
        public string SellerName { get; set; }
        public double PackingCharge { get; set; }

    }
}
