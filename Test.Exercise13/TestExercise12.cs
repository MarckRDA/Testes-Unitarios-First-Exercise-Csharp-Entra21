using System;
using Xunit;

namespace Test.Exercise12
{
    public class TestExercise13
    {
        [Fact]
        public void Should_Return_The_Biggest_Number_In_Array()
        {
            //Given
            var exercise12 = new Exercise13();
            var numbers = new double[10]
            {
                13,465,7294,836,345,21,345,65,322,12
            };

            //When
            var result = exercise12.BiggestNumber(numbers);
            var expectedResult = 7294.0;

            //Then
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Should_Return_The_Biggest_Number_In_Array_With_Negative_Numbers()
        {
            //Given
            var exercise12 = new Exercise13();
            var numbers = new double[10]
            {
                -16,-65,-9, -5, -6, -8, -32, -71161, -98, -98
            };

            //When
            var result = exercise12.BiggestNumber(numbers);
            var expectedResult = -5.0;

            //Then
            Assert.Equal(expectedResult, result);
        }
    }
}
