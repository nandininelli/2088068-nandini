using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_HandsOn
{
    class ConcreteBuilderAdult : Builder
    {
        private Sweets sweet = new Sweets();
        public override void BuildPackageSavory()
        {
            sweet.Add("Samosa");
            sweet.Add("Pakora");
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
