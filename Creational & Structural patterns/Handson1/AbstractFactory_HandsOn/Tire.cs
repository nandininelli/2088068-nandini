using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_HandsOn
{
    public abstract class Tire
    {
        string tireType;
        public Tire(string tyre)
        {
            tireType = tyre;
        }

        public string getTire()
        {
            return tireType;
        }
    }
}
