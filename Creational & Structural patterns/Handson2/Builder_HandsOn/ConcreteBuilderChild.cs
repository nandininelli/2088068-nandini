using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_HandsOn
{
    class ConcreteBuilderChild:Builder
    {
        private Sweets sweet = new Sweets();
        public override void BuildPackageSavory()
        {
            sweet.Add("Samosa");
        
        }

        public override void BuildPackageSweet()
        {
            sweet.Add("GulabJamun");
            sweet.Add("RasGulla");
        }

        public override Sweets GetSweets()
        {
            return sweet;
        }
    }
}
