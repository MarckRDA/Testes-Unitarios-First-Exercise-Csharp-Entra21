using System;
using Xunit;
using Exercicio14;

namespace Exercicio14.Teste
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1,2,3,"1,2,3")] // => Testar inputs já ordenados
        [InlineData(34,7,1,"1,7,34")] // => Testar inputs decrescentes
        [InlineData(1,50,3,"1,3,50")] // => Testar inputs com o segundo argumento maior
        [InlineData(34,2,15,"2,15,34")] // => Testar inputs com o primeiro argumento maior
        [InlineData(86,2,-6,"-6,2,86")] // => Testar inputs com 1 valor negativo
        [InlineData(13,-3,-8,"-8,-3,13")] // => Testar inputs com 2 valores negativo
        [InlineData(-3,-1,-9,"-9,-3,-1")] // => Testar inputs com 3 valores negativos
        public void TesteDeOrdenacaoTresValores(double n1, double n2, double n3, string resultadoEsperado)
        {   
            //Arrange
            var instancia = new Exercicio14SobTeste();
            
            //Act
            var resultado = instancia.NumbersSorted(n1, n2, n3);

            //Assert
            Assert.Equal(resultado, resultadoEsperado);
        }
    }
}
