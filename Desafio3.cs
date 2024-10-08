using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTarget
{
    internal static class Desafio3
    {
        public static void Resultado()
        {
            double[] faturamento = new double[365]; // Crio o vetor do ano todo
            Random random = new();

            // Esse for() serve para popular esse vetor com o faturamento do ano
            for(int i = 0; i < faturamento.Length; i++){ faturamento[i] = Math.Round(random.NextDouble() * 100000, 2);}

            //Algoritmo que criei para achar o menor valor, o maior valor e a média
            //Esse algoritmo utiliza a lógica de sempre comparar o valor atual do loop com o que eu ja tenho salvo
            //assim sempre tendo o menor valor e o maior valor passando uma só vez pelo loop

            double menorValor = faturamento[0];
            double maiorValor = faturamento[0];
            int diasMedia = 0;
            double soma = 0;

            for (int i = 0; i < faturamento.Length; i++)
            {

                if (faturamento[i] == 0){continue;}

                if (menorValor > faturamento[i])
                {
                    menorValor = faturamento[i];
                }

                if (maiorValor < faturamento[i])
                {
                    maiorValor = faturamento[i];
                }

                soma += faturamento[i];
                diasMedia++;
                

            }

            double mediaFinal = soma / diasMedia;

            Console.WriteLine($"O menor valor de faturamento é {menorValor}");
            Console.WriteLine($"O maior valor de faturamento é {maiorValor}");
            Console.WriteLine($"A media do faturamento é {Math.Round(mediaFinal,2)}");


        }
        

    }
}
