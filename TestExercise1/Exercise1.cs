namespace TestExercise1
{
    public class Exercise1
    {
        public int[] Exercise1a()
        {
            var numbers = new int[10];

            for (int count = 1; count < 11; count++)
            {
                numbers[count - 1] = count;
            }

            return numbers;
        }

        public int[] Exercise1b()
        {
            var numbers = new int[10];

            for (int count = 10; count > 0; count--)
            {
                numbers[numbers.Length - count] = count;
            }

            return numbers;
        }


        public int[] Exercise1c()
        {
            var numbers = new int[5];

            for (int count = 2; count < 11; count += 2)
            {
                numbers[(count / 2) - 1] = count;
            }

            return numbers;
        }
    }

}




