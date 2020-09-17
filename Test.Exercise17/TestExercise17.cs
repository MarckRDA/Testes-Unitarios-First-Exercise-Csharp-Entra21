using System;
using System.Collections.Generic;
using Xunit;

namespace Test.Exercise17
{
    public class TestExercise17
    {
        [Theory]
        [InlineData(new int[]{2, 4, 6, 8, 10, 12, 14, 16, 18, 20}, 2)]
        [InlineData(new int[]{6, 12, 18, 24, 30, 36, 42, 48, 54, 60}, 6)]
        [InlineData(new int[]{9, 18, 27, 36, 45, 54, 63, 72, 81, 90}, 9)]
        public void Should_Return_A_Multiplication_Table_Of_7(int[] expectedResults, int product)
        {
            //Given
            var exercise17 = new Exercise17();
            
            //When
            var result = exercise17.MutiplicationTable(product);

            //Then
            Assert.Equal(expectedResults, result);
        }
    }
}
