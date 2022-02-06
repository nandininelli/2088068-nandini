using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_HandsOn
{
    public class MercedesFactory : Factory
    {
        public override Headlight makeHeadlight()
        {
            return new MercedesHeadlight();
        }

        public  override  Tire makeTire()
        {
            return new MercedesTire();
        }
    }
}
