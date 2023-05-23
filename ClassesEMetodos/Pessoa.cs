using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Pessoa
    {

        //public = variavém que todos da classe possam acessar 
        public string nome;
        public int idade;

        public string Apresentar()
        {
            //formart retorna uma string formatada no console
            return string.Format($"Olá! Me chame {nome} e tenho {idade} anos");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());
        }
    }

   
}
