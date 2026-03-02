
namespace Treino
{
    public class Program
    {
        static void Main(string[] args)
        {
            //    São dados dois números inteiros positivos p e q, sendo que o número de dígitos de p é menor ou igual ao número de
            //    dígitos de q. Verificar se p é um subnúmero de q.

            //Exemplos:
            //    p = 23, q = 57238, p é subnúmero de q.
            //    p = 23, q = 258347, p não é subnúmero de q.


            int q = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            double numeroComparar = 0;
            int numero = q;
            int contador = 0;
            int numeroDividido = p;
            bool resposta = false;


            do
            {
                numeroDividido = numeroDividido / 10;
                contador += 1;
            } while (numeroDividido != 0);




            while (numero >= p)
            {
                numeroComparar = numero % (Math.Pow(10,contador));
                


                if(numeroComparar == p)
                {
                    Console.WriteLine("p eh subnumero de q");
                    resposta = true;
                    break;
                }

                numero = numero / 10;
            }

            if(!resposta)
            {
            Console.WriteLine("p nao eh subnumero de q");
            }




        }
    }
}