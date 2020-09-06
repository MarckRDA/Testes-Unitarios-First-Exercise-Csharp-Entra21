using System;
using Xunit;

namespace Test.Exercise8
{
    public class TestExercise8
    {
        [Theory]
        [InlineData(4, 2)]
        [InlineData(18, 9)]
        [InlineData(15, 6)]
        public void Should_Return_Whether_A_Number_Is_Multiple_or_not(double numberOne, double numberTwo)
        {
            //Given
            var exercise8 = new Exercise8();

            //When
            var result = exercise8.XMutipleY(numberOne, numberTwo);

            //Then
            Assert.True(result);
        }
    }
}
