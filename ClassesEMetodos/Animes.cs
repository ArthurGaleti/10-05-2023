using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Animes
    {
        public string anime;
        public string categoria;

        public string Mostrar()
        {
            return string.Format($"O anime é {anime} e ele é {categoria}.");
        }

        public void MostrarNoConsole()
        {
            Console.WriteLine(Mostrar());
        }

    }
}
