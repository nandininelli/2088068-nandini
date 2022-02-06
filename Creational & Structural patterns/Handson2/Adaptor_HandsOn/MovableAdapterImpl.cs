using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_HandsOn
{
    public class MovableAdapterImpl : MovableAdaptor
    {
        private Movable LuxuryCars;

        public MovableAdapterImpl(Movable movable)
        {
            LuxuryCars = movable;
        }
        public double getSpeed()
        {
            return convertMPHtoKMPH(LuxuryCars.getSpeed());
        }

        public double getPrice()
        {
            return ConvertUSDtoEuro(LuxuryCars.getPrice());
        }

        private double ConvertUSDtoEuro(double usd)
        {
            return usd * 0.84;
        }

        private double convertMPHtoKMPH(double mph)
        {
            return mph * 1.60934;
        }
    }
}
