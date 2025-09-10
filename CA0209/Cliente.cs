using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA0209
{
    internal class Cliente :Pessoa
    {
        private int codigo;
        public void DefinirCodigo(int c)
        {
            codigo = c;
        }
       
        public void ExibirCodigo() {
            Console.WriteLine("Código do cliente:" + codigo);
        }
    }
}
