using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvHospitalDES
{
    class Menu
    {
        public string opcao;
        public Paciente pac;
        public void escolher()
        {
            Console.ReadKey();
            Console.WriteLine("Digite 'c' para CADASTRAR UM PACIENTE");
            Console.WriteLine("Digite 'e' para EXIBIR DADOS DE UM PACIENTE");
            Console.WriteLine("Digite 'o' para ORGANIZAR A FILA DE ATENDIMENTO");
            Console.WriteLine("Digite 'a' para ALTERAR DADOS DE ALGUM PACIENTE");
            Console.WriteLine("Digite 'ep' para EXIBIR LISTA DE PACIENTES CADASTRADOS");
            Console.WriteLine("Digite 'q' para ENCERRAR O PROGRAMA");
            Console.WriteLine("ESCOLHA AGORA: ");
            opcao = Console.ReadLine();
            Console.Clear();
        }
        public void list_pac()
        {
            Paciente[] pac = new Paciente[3];
            for(int i = 0; i < 3; i++)
            {
                pac[i] = new Paciente();
            }
            int j = 0;
            while (j < 3)
            {
                Console.WriteLine(pac[j].nome);
                j++;
            }
        }
    }
}
