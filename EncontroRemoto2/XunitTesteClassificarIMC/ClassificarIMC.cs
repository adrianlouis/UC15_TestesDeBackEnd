using Xunit;
using ProjetoTesteFST1;

namespace XunitTesteClassificarIMC
{
    public class ClassificarIMC
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação
            double peso = 75;
            double altura = 1.81;
            double 


            //Act - Ação
            var resultado = Operacoes.IMC(peso, altura);
            var classifyIMC = ClassificacaoIMC.ClassIMC(resultado);


            //Assert - Verificação
            Assert.Equal(22.9, resultado);
            Assert.Equal("Peso normal", classifyIMC);
        }
    }
}