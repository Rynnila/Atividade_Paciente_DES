using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvHospitalDES
{
    class Program
    {
        static void Main(string[] args)
        {
            Paciente[] pac = new Paciente[3];
            Menu menu = new Menu();
            int i = 0;
            int p = 0;
            int aux = 0;

            for (int j = 0; j < 3; j++)
            {
                pac[j] = new Paciente();
            }

            menu.escolher();
            while (menu.opcao != "q")
            {
                if (menu.opcao == "c")//cadastrar paciente
                {
                    pac[i].cad_pac();
                }
                if (menu.opcao == "e")//alterar dados do paciente em tal posição
                {
                    int j = 0;
                    Console.WriteLine("Pacientes cadastrados: \n");
                    while (j < 3)
                    {
                        Console.WriteLine("Paciente {0} cadastrado na posição {1}.", pac[j].nome, j);
                        j++;
                    }
                    Console.WriteLine("Os dados do paciente em qual posição deseja exibir?");
                    p = int.Parse(Console.ReadLine());
                    pac[p].ex_pac();
                }
                if (menu.opcao == "ep")//exibir os pacientes cadastrados em cada posição
                {
                    int j = 0;
                    while (j < 3)
                    {
                        Console.WriteLine("Paciente {0} cadastrado na posição {1}.",pac[j].nome,j);
                        j++;
                    }
                }
                if (menu.opcao == "o")//organizar fila
                {
                    
                }
                if (menu.opcao == "a")//alterar dados do paciente em tal posicao
                {
                    int j = 0;
                    Console.WriteLine("Pacientes cadastrados: \n");
                    while (j < 3)
                    {
                        Console.WriteLine("Paciente {0} cadastrado na posição {1}.", pac[j].nome, j);
                        j++;
                    }
                    Console.WriteLine("Os dados do paciente em qual posição deseja alterar?");
                    p = int.Parse(Console.ReadLine());
                    pac[p].cad_pac();
                }
                i++;
                menu.escolher();
             }
               Console.WriteLine("PROGRAMA ENCERRADO");
               Console.ReadKey();
            }
            
            
    }
}
