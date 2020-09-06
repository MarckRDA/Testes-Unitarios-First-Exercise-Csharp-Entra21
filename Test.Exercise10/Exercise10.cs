using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise10
{
    public class Exercise10
    {
        public double EqualityBetweenAandB(double n1, double n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else if (n2 > n1)
            {
                return n2;
            }
            else
            {
                return n1;
            }

            
        }


    }
}
