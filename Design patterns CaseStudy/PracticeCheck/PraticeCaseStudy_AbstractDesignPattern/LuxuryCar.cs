using System;
using System.Collections.Generic;
using System.Text;

namespace PraticeCaseStudy_AbstractDesignPattern
{
    class LuxuryCar:Car
    {
        public LuxuryCar(CarType carType, Location location) : base(CarType.LUXURY, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to luxury car");
            Console.WriteLine(base.ToString());
        }
    }
}
