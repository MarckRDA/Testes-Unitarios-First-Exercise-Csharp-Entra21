using System;
using Xunit;

namespace Test.Exercise11
{
    public class TestExercise11
    {
        [Theory]
        [InlineData(10, 1, 10)]
        [InlineData(15, 5, 3)]
        [InlineData(5, 3, 2)]
        public void Should_Return_A_Division_Between_Two_Double(double n1, double n2, double expectedResult)
        {
            //Given
            var exercise11 = new Exercise11();

            //When
            var result = exercise11.Division(n1, n2);

            //Then
            Assert.Equal(expectedResult, result);
        }
    }
}
