using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoCSharp.POO
{

    public class FilhoNaoReconhecido : SubCelebridade
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho Não Reconhecido ..");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
        }


    }


    class Encapsulamento
    {
        public static void Executar()
        {
            SubCelebridade sub = new SubCelebridade();
            sub.MeuAcesso();

            Console.WriteLine("");

            new FilhoReconhecido().MeuAcesso();

            Console.WriteLine("");

            new AmigoProximo().MeusAcessos();

            Console.WriteLine("");
            new FilhoNaoReconhecido().MeusAcessos();

        }
    }
}
