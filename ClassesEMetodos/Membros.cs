using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar()
        {
            //instanciando a classe pessoas e criando o objeto

            Pessoa pessoa1 = new Pessoa();

            pessoa1.nome = "arth";
            pessoa1.idade = 18;

            Console.WriteLine($"Seu nome: {pessoa1.nome}, sua idade {pessoa1.idade}");

            Animes anime = new Animes();

            anime.anime = "boku no hero";
            anime.categoria = "shounem";

            anime.MostrarNoConsole();

        }
    }
}
