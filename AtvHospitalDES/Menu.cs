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
        public FilaAtd f_a;
        public void escolher()
        {
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
    }
}
