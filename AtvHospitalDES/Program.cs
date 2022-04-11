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
                menu.escolher();
            }
            if (menu.opcao == "c")
            {
                menu.o_c();
            }
            if (menu.opcao == "e")
            {
                menu.o_e();
            }
            Console.WriteLine("PROGRAMA ENCERRADO");
            Console.ReadKey();
        }
    }
}
