using System;
using Xunit;

namespace Test.Exercise16
{
    public class TestExercise16
    {
        [Theory]
        [InlineData(550.00,550.00)]
        [InlineData(1000.00, 800.00)]
        [InlineData(1540.00, 1155.00)]
        [InlineData(2500.00, 1750.00)]
        public void Should_Return_An_Net_Salary_Due_To_Given_An_Gross_Salary(double grossSalary, double expectedNetSalary)
        {
            //Given 
            var exercise16 = new Exercise16();

            //When
            var result = exercise16.NetSalary(grossSalary);

            //Then
            Assert.Equal(expectedNetSalary, result);

            
        }
    }
}
