using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_HandsOn
{
    public abstract class Builder
    {
        public abstract void BuildPackageSavory();

        public abstract void BuildPackageSweet();
       
        public abstract Sweets GetSweets();
    }
}
