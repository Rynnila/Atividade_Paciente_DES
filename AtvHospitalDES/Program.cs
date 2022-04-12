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
            FilaAtd[] fila = new FilaAtd[3];
            for (int i = 0; i < 3; i++)
            {
                pac[i] = new Paciente();
            }
            menu.escolher();
            while (menu.opcao != "q")
            {
                int i = 0;
                if (menu.opcao == "c")
                {
                    pac[i].cad_pac();
                }
                if (menu.opcao == "e")
                {
                    pac[i].ex_pac();
                }
                if (menu.opcao == "ep")
                {
                    for(int j = 0; j < 3; j++)
                    {
                        while (j < 3)
                        {
                            Console.WriteLine(pac[j].nome);
                        }
                    }
                }
                i++;
                menu.escolher();
            }
            
            Console.WriteLine("PROGRAMA ENCERRADO");
            Console.ReadKey();
        }
    }
}
