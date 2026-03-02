using System.Runtime.CompilerServices;

namespace Exercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(POLI 89) Dados n e uma seqüência de n números inteiros, determinar o comprimento de um segmento crescente
            // de comprimento máximo.
            //Exemplos:
            //Na seqüência   5,10,3,2,4,7,9,8,5   o comprimento do segmento crescente máximo é 4.
            //Na seqüência   10,8,7,5,2   o comprimento de um segmento crescente máximo é 1.

            int[] array = { 5, 4, 3, 2, 1 };

            int contador = 1;
            int maxContador = 0;

            for (int i = 0; i < array.Length - 1 ; i++)
            {
                if (array[i] < array[i+1])
                {
                    contador++;
                    if (contador > maxContador)
                    {
                        maxContador = contador;
                    }
                }
                else
                {
                    contador = 1;
                }              
            }
            if (maxContador == 0)
            {
                Console.WriteLine("O segmento informado eh decrescente");
            }
            else
            {
                Console.WriteLine($"O comprimento do segmento crescente maximo eh {maxContador}");
            }
        }
    }
}
