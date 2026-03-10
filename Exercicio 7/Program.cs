using System;
using System.Data;

namespace Exercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados n e n seqüências de números inteiros não - nulos, cada qual seguida por um 0,
            //calcular a soma dos números pares de cada seqüência.

            int n = Convert.ToInt32(Console.ReadLine()); ;
            int contadorPar = 0;


            for (int i = 1; i <= n; i++)
            {
                string sequencia = Console.ReadLine();



                string[] numeros = (sequencia.Split(" "));

                foreach (var numero in numeros)
                {
                    if (numero == "")
                    {
                        Console.WriteLine("Numero Invalido");
                        break;
                    }

                    int numeroConvertido = Convert.ToInt32(numero);

                    if (numeroConvertido != 0)
                    {
                        if (numeroConvertido % 2 == 0)
                        {
                            contadorPar += numeroConvertido;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine($"A soma dos pares da sequencia {i} eh {contadorPar}");
                contadorPar = 0;
                Array.Clear(numeros);
            }          
        }
    }
}
