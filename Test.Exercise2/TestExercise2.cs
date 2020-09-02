using System;
using Xunit;

namespace Test.Exercise2
{
    public class TestExercise2
    {
        [Fact]
        public void Shoud_Return_A_Sum_Between_1_and_100()
        {
            //Given
            var exercise2 = new Exercise2();

            //When
            var result = exercise2.SumBetween1and100();

            //Then
            Assert.Equal(5050, result);
        }
    }
}
