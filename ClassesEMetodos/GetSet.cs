using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSet
    {
        class Cliente {
            //modificador private garante que apenas a class Cliente terá acesso
            private string nome;


            //get e set tem que ser iguais ao mesmo ao atributos
            public string Nome {
                get
                {
                    return nome;
                }


                //usa SET para enviar informações
                set
                {
                    nome = value;
                }
            }

        }


        public static void Executar()
        {
            Cliente Cliente1 = new Cliente();

            /*Exemplo de GET*/
            //Cliente1.Nome

            Cliente1.Nome = "oliver";
            Console.WriteLine(Cliente1.Nome);
        }
    }
}
