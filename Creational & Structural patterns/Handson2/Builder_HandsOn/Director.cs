using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_HandsOn
{
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPackageSweet();
            builder.BuildPackageSavory();
        }
    }
}
