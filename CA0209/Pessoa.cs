using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    class Pessoa
    {
        public string nome;
        public string datanasc;
        public string cpf;
        public string endereco;
        public string telefone;
        public string estadocivil;
        public string email;

        public void cadastrarnome() 
        {
            Console.WriteLine("Digite seu Nome");
            nome = Console.ReadLine();
        }
        public void cadastrardatanasc()
        {
            Console.WriteLine("Digite sua data de nascimento");
            datanasc = Console.ReadLine();
        }
        public void cadastrarcpf()
        {
            Console.WriteLine("Digite seu CPF");
            cpf = Console.ReadLine();
        }
        public void cadastrarendereco()
        {
            Console.WriteLine("Digite seu endereço");
            endereco = Console.ReadLine();
        }
        public void cadastrartelefone()
        {
            Console.WriteLine("Digite seu número de Telefone");
            telefone = Console.ReadLine();
        }
        public void cadastrarestadocivil()
        {
            Console.WriteLine("");
            estadocivil = Console.ReadLine();
        }
        public void cadastraremail()
        {
            Console.WriteLine("Digite seu Email");
            email = Console.ReadLine();
        }



        

    }
}
