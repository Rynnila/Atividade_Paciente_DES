using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvHospitalDES
{
    class Paciente
    {
        public double cpf;
        public string nome;
        public string endereco;
        public double telefone;
        public string email;
        public int idade;
        public bool preferencial;

        public void preferencia_fila()
        {
            string aux_pref;
            aux_pref = Console.ReadLine();
            if (aux_pref == "sim" || aux_pref == "Sim" || idade >= 65 && aux_pref == "sim")
            {
                preferencial = true;
            }
            else
            {
                preferencial = false;
            }
        }

        public void cad_pac()
        {
            Console.WriteLine("---CADASTRO DE DADOS DO PACIENTE---");
            Console.Write("Nome do paciente: ");
            nome = Console.ReadLine();
            Console.Write("CPF do paciente: ");
            cpf = double.Parse(Console.ReadLine());
            Console.Write("Idade do paciente: ");
            idade = int.Parse(Console.ReadLine());
            Console.Write("Endereço do paciente: ");
            endereco = Console.ReadLine();
            Console.Write("Número de telefone do paciente: ");
            telefone = double.Parse(Console.ReadLine());
            Console.Write("Email do paciente: ");
            email = Console.ReadLine();
            Console.WriteLine("O paciente é preferencial?");
            preferencia_fila();
            Console.ReadKey();
            Console.Clear();
        }

        public void ex_pac()
        {
            Console.WriteLine("  OS DADOS PESSOAIS DO PACIENTE ");
            Console.WriteLine("- Nome: {0}", nome);
            Console.WriteLine("- Idade: {0} anos", idade);
            Console.WriteLine("- CPF: {0}", cpf);
            Console.WriteLine("- Endereço: {0}", endereco);
            Console.WriteLine("- Telefone: {0}", telefone);
            Console.WriteLine("- E-mail: {0}", email);
            Console.WriteLine("- Preferência: {0}", preferencial);
            Console.ReadKey();
            Console.Clear();
        }
    }
}

