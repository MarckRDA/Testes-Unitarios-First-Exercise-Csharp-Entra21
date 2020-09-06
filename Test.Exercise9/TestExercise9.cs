using System;
using Xunit;

namespace Test.Exercise9
{
    public class TestExercise9
    {
        [Theory]
        [InlineData(2, 0, 1)]
        [InlineData (10, 23, 9)]
        [InlineData (100, 4, 5)]
        public void Should_Return_Whether_A_Number_Is_Bigger_Than_Sum_Of_Last_Two_Numbers(double n1, double n2, double n3)
        {
            //Given
            var exercises9 = new Exercise9();

            //When
            var result = exercises9.FirstGreatterThanSumBetweenLastBoth(n1, n2, n3);

            //Then
            Assert.True(result);
        }
    }
}
