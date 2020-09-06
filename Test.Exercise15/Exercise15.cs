using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise15
{
    public class Exercise15
    {
        public (int,int) Multipleby3and5(double[] numbers)
        {
            var multipleBy3 = 0;
            var multipleBy5 = 0;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] % 3 == 0)
                {
                    multipleBy3++;
                }
                if (numbers[index] % 5 == 0)
                {
                    multipleBy5++;
                }
            }
            
            return (multipleBy3, multipleBy5);

        }

    }
}
