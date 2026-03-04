using System.Net;
using System.Numerics;

namespace Exercicio_5
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            //Qualquer número natural de quatro algarismos pode ser dividido em duas dezenas formadas
            //pelos seus dois primeiros e dois últimos dígitos.
            //Exemplos:
            //1297: 12 e 97.
            //5314: 53 e 14.
            //Escreva um programa que imprime todos os milhares(4 algarismos) cuja raiz quadrada seja
            //a soma das dezenas formadas pela divisão acima.
            //Exemplo: raiz de 9801 = 99 = 98 + 01.
            //Portanto 9801 é um dos números a ser impresso.

            for (int i = 1000; i < 10000; i++)
            {
                int x = i % 100;
                int y = i / 100;

                if (x + y == Math.Sqrt(i))
                {
                    Console.WriteLine(i);
                }
            }                                  
        }
    }
}
