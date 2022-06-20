using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTesteFST1
{
    public static class Operacoes
    {
        public static double IMC(double peso, double altura)
        {
            var imc = (peso / (altura * altura));
            return Math.Truncate(imc * 100) / 100;
        }
    }

    public static class ClassificacaoIMC
    {
        
        public static string ClassIMC(double calculo)
        {
            string classificacao;
           
            if (calculo < 18.5)
            {
               classificacao = "Abaixo do peso";
            }
            else if (calculo >= 18.5 && calculo <= 24.9)
            {
               classificacao = "Peso normal";
            }
            else if (calculo >= 25 && calculo <= 29.9)
            {
               classificacao = "Sobrepeso";
            }
            else if (calculo >= 30 && calculo <= 34.9)
            {
               classificacao = "Obesidade grau I";
            }
            else if (calculo >= 35 && calculo <= 39.9)
            {
               classificacao = "Obesidade grau II";
            }
            else
            {
              classificacao = "Obesidade grau III" ;
            }

            return classificacao;

        }
    }
}