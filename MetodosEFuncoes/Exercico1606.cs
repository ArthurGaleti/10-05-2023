using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class Exercico1606
    {
        public static void Executar()
        {
            /* Console.WriteLine("Informe um número");
             int num = int.Parse(Console.ReadLine());


             Action ParImpar = () =>
             {
                 if (num / 2 == 0) 
                 {
                     Console.WriteLine($"{num} é par");
                 }
                 else if(num / 0 == 1)
                 {
                     Console.WriteLine($"{num} é impar");
                 }
             };

             Console.WriteLine("-------------------");

             ParImpar();

             */


            Func<int, bool> numeroPar = i =>
            {
                return (i % 2) == 0;
            };

            Console.WriteLine(numeroPar(2));
        }
    }
}
