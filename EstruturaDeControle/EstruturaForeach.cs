using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra = "banana";

            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }

            //percorrendo um array
            var alunos = new string[] { "wandebas", "virgulinni", "adolfo", "carlos" };

            foreach(var letra in alunos)
            {
                Console.WriteLine(letra);
            }
        }
    }
}
