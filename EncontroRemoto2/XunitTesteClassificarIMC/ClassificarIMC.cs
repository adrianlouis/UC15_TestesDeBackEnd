using Xunit;
using ProjetoTesteFST1;

namespace XunitTesteClassificarIMC
{
    public class ClassificarIMC
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Prepara��o
            double peso = 75;
            double altura = 1.81;
            double 


            //Act - A��o
            var resultado = Operacoes.IMC(peso, altura);
            var classifyIMC = ClassificacaoIMC.ClassIMC(resultado);


            //Assert - Verifica��o
            Assert.Equal(22.9, resultado);
            Assert.Equal("Peso normal", classifyIMC);
        }
    }
}