using Xunit;

namespace TestExercise1
{
    public class TestExercise1
    {
        [Fact]
        public void Should_Return_A_Shorted_Array_From_1_And_10()
        {
            //Given
            var exercise1a = new Exercise1();
            
            //When
            var result = exercise1a.Exercise1a();
            
            var expectedResult = new int[10]
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //Then
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);    
            }
            
        }

        [Fact]
        public void Should_Return_A_Shorted_Array_From_10_To_1()
        {
            //Given
            var exercise1b = new Exercise1();
            
            //When
            var result = exercise1b.Exercise1b();
            
            var expectedResult = new int[10]
            {
                10,9,8,7,6,5,4,3,2,1
            };

            //Then
            for (int i = 0; i < 10; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);    
            }
            
        }

        [Fact]
        public void Should_Return_An_Array_with_Even_numbers_Between_1_and_10()
        {
            //Given
            var exercise1c = new Exercise1();
            
            //When
            var result = exercise1c.Exercise1c();
            
            var expectedResult = new int[5]
            {
                2,4,6,8,10
            };

            //Then
            for (int i = 0; i < 5; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);    
            }
            
        }
    }
}