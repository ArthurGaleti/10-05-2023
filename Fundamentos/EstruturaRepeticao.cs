using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class EstruturaRepeticao
    {
        public static void Executar()
        {
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 1");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            int cont = 0;
            int num = 0;
            int dig = 0;

            while(cont != 10)
            {
                Console.WriteLine("Digite um número:");
                dig = int.Parse(Console.ReadLine());

                num = num + dig;
                cont++;
            }

            Console.WriteLine($"A soma dos números é igual a {num}");
           

            Console.WriteLine("");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 2");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            cont = 0;

            Console.WriteLine("Informe um número:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");
            

            while(cont != num)
            {
                Console.WriteLine(cont);
                cont++;
            }


            Console.WriteLine("");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 3");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            cont = 1;

            Console.WriteLine("Informe o número da tabuada");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            while(cont != 10)
            {
                Console.WriteLine($"{num} * {cont} = {num * cont}");
                cont++;
            }
        }
    }
}
