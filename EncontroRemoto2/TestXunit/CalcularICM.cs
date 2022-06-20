using ProjetoTesteFST1;
using Xunit;

namespace TestXunit
{
    public class CalcularICM
    {
        [Theory]
        [InlineData(74, 1.83, 22.09)]
        [InlineData(85, 1.75, 27.75)]
        [InlineData(117, 1.81, 35.71)]
        [InlineData(130, 1.70, 44.98)]
        public void CalcularIMC(double peso, double altura, double imc)
        {
            var resultado = Operacoes.IMC(peso, altura);

            Assert.Equal(imc, resultado);
        }
    }
}