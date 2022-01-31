using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMedicine
{
   public class Medicine
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GenericMedicineName { get; set; }
        public string Composition { get; set; }
        public DateTime ExpiryDate { get; set; }
        public double PricePerStrip { get; set; }
    }
}
