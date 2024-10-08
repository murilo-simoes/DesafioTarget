using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioTarget
{
    internal static class Desafio2
    {
        public static void Resultado()
        {
            //////////////////////////////////////////////////////////////////////// A)

            List<int> arr1 = new() { 1, 3, 5, 7 }; // O ultimo valor da lista sempre é somado 2
            int last1 = arr1[^1]; // Pega o valor do ultimo elemento da lista
            arr1.Add(last1 + 2); // Soma mais dois ao ultimo elemento e adiciona à lista

            Console.WriteLine($"Exercicio A: { arr1[^1]}"); //Resultado: 9

            //////////////////////////////////////////////////////////////////////// B)

            List<int> arr2 = new() { 2, 4, 8, 16, 32, 64 }; // O ultimo valor da lista sempre é multiplicado por 2
            int last2 = arr2[^1]; // Pega o valor do ultimo elemento da lista
            arr2.Add(last2 * 2); // Multiplica o ultimo elemento por 2 e adiciona à lista

            Console.WriteLine($"Exercicio B: {arr2[^1]}"); ; //Resultado: 128

            //////////////////////////////////////////////////////////////////////// C)

            List<int> arr3 = new() { 0, 1, 4, 9, 16, 25, 36 }; // Sempre será somado a diferença entre os ultimos dois valores da lista mais 2

            // Exemplo: 36 - 25 = 11
            // Adiciona 2: 11 + 2 = 13
            // Soma 13 ao ultimo valor da lista: 36 + 13 = 49

            int last3 = arr3[^1]; // Pega o valor do ultimo elemento da lista
            int penultimate3 = arr3[^2]; // Pega o valor do penultimo elemento
            int add3 = last3 + (last3 - penultimate3 + 2);

            arr3.Add(add3); // Adiciona a diferença entre o ultimo e o penultimo mais 2 somado ao ultimo valor

            Console.WriteLine($"Exercicio C: { arr3[^1]}"); // Resultado: 49

            //////////////////////////////////////////////////////////////////////// D)

            List<int> arr4 = new() { 4, 16, 36, 64 }; // Sempre será somado a diferença entre os ultimos dois valores da lista mais 8

            // Exemplo: 64 - 36 = 28
            // Adiciona 8: 28 + 8 = 36
            // Soma 36 ao ultimo valor da lista: 36 + 64 = 100

            int last4 = arr4[^1]; // Pega o valor do ultimo elemento da lista
            int penultimate4 = arr4[^2]; // Pega o valor do penultimo elemento
            int add4 = last4 + (last4 - penultimate4 + 8);

            arr4.Add(add4); // Adiciona a diferença entre o ultimo e o penultimo mais 8 somado ao ultimo valor

            Console.WriteLine($"Exercicio D: { arr4[^1]}"); // Resultado: 100

            //////////////////////////////////////////////////////////////////////// E)

            List<int> arr5 = new() { 1, 1, 2, 3, 5, 8 }; // Os números da lista estão sendo somados de acordo com a sequência de Fibonacci,
                                                         // onde cada número é a soma dos dois anteriores

            int last5 = arr5[^1]; // Pega o valor do ultimo elemento da lista
            int penultimate5 = arr5[^2]; // Pega o valor do penultimo elemento

            arr5.Add(last5 + penultimate5); // Adiciona à lista a soma do ultimo elemento e o penultimo elemento

            Console.WriteLine($"Exercicio E: { arr5[^1]}"); // Resultado: 13

            //////////////////////////////////////////////////////////////////////// F)

            List<int> arr6 = new() { 2, 10, 12, 16, 17, 18, 19 }; // A lógica que encontrei foi que todos os números da lista
                                                                  // começam com a letra D, sendo assim o próximo numero 
                                                                  // da lista seria 200

            arr6.Add(200);

            Console.WriteLine($"Exercicio F: {arr6[^1]}"); // Resultado: 200
        }
    }
}
