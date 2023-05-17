using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class WhileEForm
    {
        public static void Executar()
        {
            int contador = 0;

            Console.WriteLine("Informe um número para eu contar");
            int.TryParse(Console.ReadLine(), out int lim);

            Console.WriteLine("Qual o valor do salto?");
            int.TryParse(Console.ReadLine(), out int salto);

            if (salto != 0)
            {
                /*while (contador <= lim)
                {

                    Console.WriteLine(contador);
                    contador = contador + salto;
                }
                */

                for(int cont = 1; cont < 10; cont++)
                {
                    Console.WriteLine(cont);
                }
            }
            else
            {
                Console.WriteLine("0 não vale >:(");
            }
        }
            
    }
}
