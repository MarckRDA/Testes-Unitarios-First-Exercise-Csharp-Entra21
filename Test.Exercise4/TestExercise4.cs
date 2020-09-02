using System;
using Xunit;

namespace Test.Exercise4
{
    public class TestExercise4
    {
        [Fact]
        public void Should_Return_An_Age_Avarage()
        {
            //Given 
            var exercises4 = new Exercise4();

            //When
            var result = exercises4.AgeAverage(12,17,15,16,14,18,0);

            //Then
            Assert.Equal(13, result);
        }
    }
}
