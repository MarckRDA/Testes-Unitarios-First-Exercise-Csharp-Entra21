using System;
using Xunit;

namespace Test.Exercise7
{
    public class TestExercise7
    {
        [Theory]
        [InlineData(12,5.9,3, 3876)]
        [InlineData(10, 7.00, 4, 5110)]
        [InlineData(20, 3.00, 10, 10950)]
        public void Should_Return_Spent_Money_With_Cigarrets(double cigarettesPerDay, double cigarettesPrice,  double years, double amount)
        {
            //Given
            var exercise7 = new Exercise7();

            //When
            var result = exercise7.SpentMoneyWithCigarrets(cigarettesPerDay,cigarettesPrice, years);

            //Then
            Assert.Equal(amount, result);
        }
    }
}
