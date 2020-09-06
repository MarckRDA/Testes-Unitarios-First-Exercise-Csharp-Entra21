using System;
using Xunit;

namespace Test.Exercise10
{
    public class TestExercise10
    {
        
        [Fact]
        public void Should_Return_10_When_input_To_Be_10_and_9()
        {
            //Given 
            var exercise10 = new Exercise10();

            //When
            var result = exercise10.EqualityBetweenAandB(10,9);

            //Then
            
            Assert.Equal(10, result);
          

        }
    }
}
