using System;

namespace Test.Exercise4
{
    public class Exercise4
    {
        public double AgeAverage(params int[] ages)
        {
            var average = 0.0;
            
            foreach (var item in ages)
            {
                if (item == 0)
                {
                    break;
                }
                else
                {
                     average += item;
                }
            }

            return Math.Round(average/ages.Length);
        }

    }
}
