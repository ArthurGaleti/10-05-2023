using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class ColecoesQueue
    {
        public static void Executar()
        {
            var fila = new Queue<string>();

            fila.Enqueue("Arthur");
            fila.Enqueue("Danilo");
            fila.Enqueue("Andre");
            fila.Enqueue("Lucas");
            fila.Enqueue("Felipe");

            //pega o 1° elemento da fila
            Console.WriteLine(fila.Peek());

            //contando a fila
            Console.WriteLine(fila.Count);

            //Removendo o 1° da fila
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            //verificando quantas pessoas temos na fila
            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
