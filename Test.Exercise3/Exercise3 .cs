using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise3
{
    class Exercise3
    {
        public int[] OddNumbersBetween1and200()
        {
            var oddNumbers = new int[100];

            var count = 1;
            for (int i= 0; i < 100; i++)
            {
                oddNumbers[i] = count;
                count+=2;
            }

            return oddNumbers;
        }
    }
}
