using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.329;

            //arredondamento
            Console.WriteLine(valor.ToString("f1"));

            //transformar em monetário
            Console.WriteLine(valor.ToString("c"));

            //formatar de seu jeito
            Console.WriteLine(valor.ToString("#.#"));
        }
    }
}
