using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudy_AbstractPattern
{
    abstract class Factory
    {
        public abstract void ElectronicOrder(channel channel);
        public abstract void ToysOrder(channel channel);
        public abstract void FurnitureOrder(channel channel);
    }
}
