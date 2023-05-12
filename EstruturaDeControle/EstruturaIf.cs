using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaIf
    {
        public static void Executar()
        {
            Console.WriteLine("Escreva a 1° nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escrva a 2° nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a 3° nota:");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if(media >= 7)
            {
                Console.WriteLine("Voce foi aprovado :).");

            }else if(media >=4 && media <= 6)
            {
                Console.WriteLine("Voce esta de recuperação :|.");

            }else
            {
                Console.WriteLine("Voce foi reprovado :(.");
            }
        }
    }
}
