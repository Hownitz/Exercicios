using System.Runtime.Serialization;

namespace Exercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dados n e uma seqüência de n números inteiros, determinar quantos segmentos de números iguais consecutivos
            //    compõem essa seqüência.
            //Exemplo: A seguinte seqüência é formada por 5 segmentos de números iguais:
            //    5,  2,  2,  3,  4,  4,  4,  4,  1,  1

            int[] array = [5, 2, 2, 3, 4, 4, 4, 6, 1, 1];
            int contadorSegmentos = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i-1])
                {
                    contadorSegmentos++;
                }
            }
            Console.WriteLine($"O numero de segmentos iguais nesta sequencia eh de: {contadorSegmentos}");
        }
    }
}
 