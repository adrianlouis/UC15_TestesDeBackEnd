using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoTesteFST1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            //Arrange - Preparação
            double peso = 75;
            double altura = 1.81;
            

            //Act - Ação
            var resultado = Operacoes.IMC(peso, altura);
            var classifyIMC = ClassificacaoIMC.ClassIMC(resultado);
            

            //Assert - Verificação
            Assert.AreEqual(22.9, resultado);
            Assert.AreEqual("Peso normal", classifyIMC);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(1, 2, 5)]
        public void SomarDoisNumerosLista(double peso, double altura, double res)
        {
            //Act - Ação
            var resultado = Operacoes.IMC(peso, altura);

            //Assert - Verificação
            Assert.AreEqual(res, resultado);
        }

        
    }

   
}