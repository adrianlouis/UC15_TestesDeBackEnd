using ProjetoTesteFST1;
using Xunit;

namespace ClassificarIMC
{
    public class ClassificarIMC
    {
        [Theory]
        [InlineData(22.09, "Peso normal")]
        [InlineData(27.75, "Sobrepeso")]
        [InlineData(35.71, "Obesidade grau II")]
        [InlineData(44.98, "Obesidade grau III")]
        public void ClassificandoIMC(double imc, string classificacao)
        {
            var resultado = ClassificacaoIMC.ClassIMC(imc);

            Assert.Equal(resultado, classificacao);
        }
    }
}