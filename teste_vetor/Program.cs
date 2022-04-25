using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste_vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int aux;
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Escreva 10 números");
                Console.WriteLine("Número {0}: ", i);
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] < numeros[i + 1])
                {

                }
                else
                {
                    aux = numeros[i];
                    numeros[i] = numeros[i + 1];
                    numeros[i + 1] = aux;
                }
                i++;
            }

            Console.WriteLine("Exibição");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();
        }
    }
}
