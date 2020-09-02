namespace Test.Exercise2
{
    public class Exercise2
    {
        public int SumBetween1and100()
        {
            var sum = 0;
            for (int count = 0; count < 101; count++)
            {
                sum += count;
            }
            return sum;
        }
    }
}