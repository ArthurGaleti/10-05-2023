using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            int a = 72;
            int b = 4;
            int c = 16;
            int d = 20;

            //se
            Console.WriteLine( a > b);

            //ou
            Console.WriteLine(a > c || b != d);

            //e
            Console.WriteLine(a > c && b != d);
        }
    }
}
