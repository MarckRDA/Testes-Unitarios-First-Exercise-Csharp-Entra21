using System;
using Xunit;

namespace Test.Exercise5
{
    public class TestExercise5
    {
        [Fact]
        public void Should_Return_An_Percentage_Of_Women_Between_18_and_35_Years()
        {
            //Given
            var exercise5 = new Exercise5();
            var womenAges = new int[5]
            {
                20,18,65,34,60
            };

            //When
            var result = exercise5.womensAgeBetween18and35(womenAges);

            //Then
            Assert.Equal(60, result);

        }
    }
}
