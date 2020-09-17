using System.Collections.Generic;
using System.Linq;

namespace Test.Exercise17
{
    public class Exercise17
    {
        public List<int> MutiplicationTable(int product)
        {
            var factors = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };
            
            
            return factors.Select(n => n * product).ToList();
        }

    }
}
