using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            //atribuições
            int num = 8;

            num = 10;


            //num += 20;
            num = num + 20;

            num -= 5;

            var n1 = 8;
            var n2 = 90;

            n1++;
            n2--;

            Console.WriteLine(num);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
        }
    }
}
