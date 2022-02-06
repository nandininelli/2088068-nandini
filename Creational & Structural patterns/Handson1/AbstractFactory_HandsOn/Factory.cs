using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_HandsOn
{
    public abstract class Factory
    {
        public  abstract  Headlight makeHeadlight();
        public  abstract Tire makeTire();
    }
}
