using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise12
{
    public class Exercise12
    {
        public double BiggestNumber(double[] numbers)
        {
            var biggestNumber = Double.MinValue;
            var input = 0.0;

            for (int index = 0; index < numbers.Length; index++)
            {
                input = numbers[index];
                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }    
            }

            return biggestNumber;
        }

    }
}




