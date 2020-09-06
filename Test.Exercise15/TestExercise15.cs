using System;
using Xunit;

namespace Test.Exercise15
{
    public class TestExercise15
    {
        [Fact]
        public void Should_Return_How_Many_Numbers_Is_Multiple_By_3_Or_5()
        {
            //Given
            var exercise15 = new Exercise15();
            var numbers = new double[10]
            {
                14, 15, 5, 9, 13, 10, 30, 100, 12, 16
            };

            //When
            var result = exercise15.Multipleby3and5(numbers);
            var expectedResult = (4,5);
            //Then
            Assert.Equal(expectedResult,result);
        }
    }
}
