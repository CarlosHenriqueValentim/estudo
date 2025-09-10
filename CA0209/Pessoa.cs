using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    class Pessoa : IPessoa
    {
        public string Nome;
        public string Datanasc;
        public string Cpf;
        public string Endereco;
        public string Telefone;
        public string Estadocivil;
        public string Email;
        
       
        public void CadastrarNome()
        {
            Console.WriteLine("Digite seu Nome");
            Nome = Console.ReadLine();
        }
        public void Cadastrardatanasc()
        {
            Console.WriteLine("Digite sua data de nascimento");
            Datanasc = Console.ReadLine();
        }
        public void CadastrarCpf()
        {
            Console.WriteLine("Digite seu CPF");
            Cpf = Console.ReadLine();
        }
        public void CadastrarEndereco()
        {
            Console.WriteLine("Digite seu Endereço:");
            Endereco = Console.ReadLine();
        }
        public void CadastrarTelefone()
        {
            Console.WriteLine("Digite seu número de Telefone:");
            Telefone = Console.ReadLine();
        }
        public void CadastrarEstadoCivil()
        {
            Console.WriteLine("Digite seu Estado Civil:");
            Estadocivil = Console.ReadLine();
        }
        public void CadastrarEmail()
        {
            Console.WriteLine("Digite seu Email:");
            Email = Console.ReadLine();
        }
        
       
        public void ExibirNome()
        {
            Console.WriteLine("Nome: {0}", Nome);
        }
        public void ExibirDatanasc()
        {
            Console.WriteLine("Data: {0}", Datanasc);
        }
         public void ExibirDatanasc()
        {
            Console.WriteLine("Cpf: {0}", Cpf);
        } 
        public void ExibirDatanasc()
        {
            Console.WriteLine("Endereço: {0}", Endereco);
        } 
        public void ExibirDatanasc()
        {
            Console.WriteLine("Telefone: {0}", Telefone);
        } 
        public void ExibirDatanasc()
        {
            Console.WriteLine("Estadocivil: {0}", Estadocivil);
        } 
        public void ExibirDatanasc()
        {
            Console.WriteLine("Email: {0}", Email);
        }
    }

}
