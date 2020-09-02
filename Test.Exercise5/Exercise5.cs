using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise5
{
    public class Exercise5
    {
        public double womensAgeBetween18and35(int[] ages)
        {
            var percents = 0.0;

            foreach (var womenAge in ages)
            {
                percents = (womenAge > 17 && womenAge < 36) ? percents += 1 : percents;    
            }

            return Math.Round((percents/ages.Length)*100);
        }

    }
}
