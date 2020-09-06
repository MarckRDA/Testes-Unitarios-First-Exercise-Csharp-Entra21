using System.Collections.Generic;

namespace Test.Exercise17
{
    public class Exercise17
    {
        public List<int> MutiplicationTable(int product)
        {
            var factors = new List<int>();
            
            for (int count = 1; count < 11; count++)
            {
                factors.Add(product * count);

            }

            return factors;
        }

    }
}
