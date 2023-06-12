using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Polimorfismo
    {
        public class Comida
        {
            //criando atributo
            public double Peso;

            public Comida(double peso)
            {
                Peso = peso;
            }

            public Comida() { }
        }

        public class Feijão : Comida
        {

        }

        public class Arroz : Comida
        {

        }

        public class Carne : Comida
        {

        }




        public class Pessoa
        {
            public double Peso;


            //Criar 3 métodos
            public void Comer(Feijão feijão)
            {
                Peso += feijão.Peso;
            }

            public void Comer(Arroz arroz)
            {
                Peso += arroz.Peso;
            }
            public void Comer(Carne carne)
            {
                Peso += carne.Peso;
            }
        }


        public static void Executar()
        {
            Feijão ing1 = new Feijão();
            Arroz ing2 = new Arroz();
            Carne ing3 = new Carne();

            ing1.Peso = 3.3;
            ing2.Peso = 4.4;
            ing3.Peso = 5.0;

            Pessoa cliente = new Pessoa();
            cliente.Comer(ing1);
            cliente.Comer(ing2);
            cliente.Comer(ing3);

            Console.WriteLine($"Carne: {ing3.Peso}");
            Console.WriteLine($"Arroz: {ing2.Peso}");
            Console.WriteLine($"Feijão: {ing1.Peso}");

            Console.WriteLine($"O peso da pessoa é: {cliente.Peso}");

        }

    }
}
