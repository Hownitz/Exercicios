using System;
using System.Linq;

namespace Treino_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizemos que um número natural n é palíndromo (3) se o 1º algarismo de n é igual ao seu último algarismo,
            //o 2º algarismo de n é igual ao penúltimo algarismo,e assim sucessivamente.

            //Exemplos:
            //567765 e 32423 são palíndromos.
            //567675 não é palíndromo.
            //Dado um número natural n > 10 , verificar se n é palíndrome.

            string numero = Convert.ToString(Console.Read());
            int meio = numero.Length / 2;
            bool contador = true;
            string metadeA = numero.Substring(0, meio);
            string metadeB = numero.Substring(meio);

            for (int i = 0; i < metadeB.Length; i++)
            {
                if (!metadeB.EndsWith(metadeA[i]))
                {
                    contador = false;
                    break;
                }
                metadeB = metadeB.Remove(metadeB.Length - 1);
            }

            if (!contador)
            {
                Console.WriteLine($"O numero {numero} nao eh um palindromo");
            }
            else
            {
                Console.WriteLine($"O numero {numero} eh um palindromo");
            }
        }
    }
}
