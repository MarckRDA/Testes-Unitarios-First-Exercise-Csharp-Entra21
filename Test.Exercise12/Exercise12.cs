using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Test.Exercise12
{
    public class Exercise12
    {
          public (int even, int odds) SumOfEvenAndOdds(int[] numbers)
          {
              var returnedResults = (0, 0);

              foreach (var number in numbers)
              {
                  var selectorNumber = (number % 2 == 0)? returnedResults.Item1 +=number : returnedResults.Item2 +=number;
              }

              return returnedResults;
          } 
    }
}




