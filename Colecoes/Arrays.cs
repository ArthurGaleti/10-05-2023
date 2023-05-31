using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Arrays
    {
        public static void Executar()
        {
            /*string[] alunos = new string[5];

            alunos[0] = "Alice";
            alunos[1] = "Claudio";
            alunos[2] = "Tony";
            alunos[3] = "Marcos";
            alunos[4] = "Elena";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }*/

            double somatoria = 0.0;
            double[] notas = {7.5, 8.5,6.5};

            //somatoria = notas[0] + notas[1] + notas[2];

            foreach(var nota in notas)
            {
                somatoria += nota;

            }

            double media = somatoria / notas.Length;

            Console.WriteLine(media);
            

        }
    }
}
