using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise18
{
    public class Exercise18
    {
        public double ApplesPrice(int unitApples)
        {
            var price = (unitApples < 6.00) ? Math.Round((unitApples * 1.30), 2) : Math.Round((unitApples * 1.00), 2);
            return price;
        }
    }

}
