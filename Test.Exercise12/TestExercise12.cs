using System;
using Xunit;

namespace Test.Exercise12
{
    public class TestExercise12
    {
        [Theory]
        [InlineData(new int[] {2,4,7,10, -13, 43, 1, 622, 43}, 638, 81)]
        [InlineData(new int[]{3, 0, -9, 10, 15}, 10, 9)]
        [InlineData(new int[]{-9, -5, -4, -3, 10, -2}, 4, -17)]
        public void Should_Return_Sum_Of_Even_And_Odds_Elements_In_Array(int[] numbers, double even, double odds)
        {
            //Given
            var exercise12 = new Exercise12();

            //When
            var expectedResult = (even, odds);
            var result = exercise12.SumOfEvenAndOdds(numbers);

            //Then
            Assert.Equal(expectedResult, result);
        }
    }
}
