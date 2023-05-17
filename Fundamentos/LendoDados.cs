using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados
    {
        internal static void Executar()
        {
            Console.WriteLine("Qual o seu nome?");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual sua altura?");
            double altura = double.Parse(Console.ReadLine());

            //exibição
            Console.WriteLine($"Ola {nome} você tem {idade} anos e {altura} de altura");

            //parse: converte tryparse verifica se é possível antes
            Console.WriteLine("Fale um número");
            string palavra =Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
        }

    }
}
