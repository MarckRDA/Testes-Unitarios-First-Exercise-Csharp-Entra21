using System;
using Xunit;
using Exercise8;

namespace Exercise8.Test
{
    public class UnitTest1
    {
        [Fact]
        public void TestandoSeONumeroSeraMultiplo()
        {
            //Arrange
            var instancia = new IsMultipleOrNot();
            
            //Act
            var resultado = instancia.XMultipleY(4,345);
            
            //Assert
            Assert.False(resultado, "False");
        }
    }
}
