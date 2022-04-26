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
                i++;
            }

            Console.WriteLine("Exibição");
            for (int j = 0; j < 3; j++)
            {
                if (numeros[j] < numeros[j + 1])
                {
                    j++;
                }
                else
                {
                    aux = numeros[j];
                    numeros[j + 1] = aux;
                    j++;
                }
               Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();
        }
    }
}
