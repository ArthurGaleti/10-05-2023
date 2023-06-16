using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MetodosEFuncoes
{
    class ExLambda
    {
        public static void Executar()
        {
            //criando a função
            Action algoNoConsole = () =>
            {
                Console.WriteLine("Palmeiras não tem mundial");
            };

            //chamando a função
            //algoNoConsole();


            //criando uma função com retorno
            Func<int> jogarDado = () =>
            {
                Random d20 = new Random();
                return d20.Next(1,20);
            };

            Console.WriteLine(jogarDado());


            Func<int, int, int, string> FormatarData = (dia, mes, ano) =>
            {
                return string.Format("{0:D2} / {1:D2} / {2:D2}", dia, mes, ano);
            };

            Console.WriteLine(FormatarData(01,01,2001));
        }
    }
}
