using System;
using Xunit;

namespace Test.Exercise18
{
    public class TestExercise18
    {
        [Theory]
        [InlineData(3,3.90)]
        [InlineData(16, 16.00)]
        public void Should_Return_A_Price_Of_Apples_Unitities(int unitApple, double expectedPrice)
        {
            //Given
            var exercise18 = new Exercise18();

            //When
            var result = exercise18.ApplesPrice(unitApple);

            //Then
            Assert.Equal(expectedPrice, result);
        }
    }
}
