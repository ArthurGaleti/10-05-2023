using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSetExercios
    {

        public class Pessoa {
            private string nome;
            private double altura;
            private DateTime idade;

            public string Nome{ get; set; }
            public double Altura{ get; set; }
            /*public DateTime Idade
            {
                get
                {
                    return idade;
                }

                set
                {
                    idade = value;
                }
            }*/

            public Pessoa(string nome, double altura)
            {
                Nome = nome;
                Altura = altura;
            }

        }


        public static void Executar()
        {
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 1");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            var pes1 = new Pessoa("Arthur", 1.70);

            Console.WriteLine(pes1);
            

        }
    }
}
