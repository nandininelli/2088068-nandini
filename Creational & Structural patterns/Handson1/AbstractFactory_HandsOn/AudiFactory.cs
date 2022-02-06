using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_HandsOn
{
    public class AudiFactory:Factory
    {
        public override Headlight makeHeadlight()
        {
            return new AudiHeadlight();
        }

        public override Tire makeTire()
        {
            return new AudiTire();
        }
    }
}
