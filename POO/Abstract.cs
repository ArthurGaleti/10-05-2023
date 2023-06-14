using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Abstract
    {

        //não se pode instanciar classes abstratas, apenas classes concretas
        public abstract class Celular
        {
            public abstract string Assistente();
            
            public string Tocar()
            {
                return "trim trim trim";
            }
        }

        public class Samsung: Celular
        {
            public override string Assistente()
            {
                return "Ola, sou Bixby";
            }
        }

        public class Iphone : Celular
        {
            public override string Assistente()
            {
                return "Ola, sou Siri";
            }
        }

        public static void Executar()
        {
            var celulares = new List<Celular> { new Samsung(), new Iphone() };

            foreach(var celular in celulares)
            {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
