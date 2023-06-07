using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class heranca
    {
        //criando classe
        public class Carro
        {
            protected readonly int VelocidadeMax;//vai ser transmetida por herança, por isso o protected

            int VelocidadeAtual;

            public Carro(int velocidadeMax)
            {
                VelocidadeMax = velocidadeMax;
            }

            //criando método de aceletação do carro
            protected int AltVelocidade(int delta)
            {
                int novaVelocidade = VelocidadeAtual + delta;
                
                if(novaVelocidade < 0)
                {
                    VelocidadeAtual = 0;
                } else if(novaVelocidade > VelocidadeMax)
                {
                    VelocidadeAtual = VelocidadeMax;
                }
                else
                {
                    VelocidadeAtual = novaVelocidade;
                }

                return VelocidadeAtual;
            }

            public int Acelera()
            {
                return AltVelocidade(5);
            }

            public int Frear()
            {
                return AltVelocidade(-5);
            }
        }

        public class Uno : Carro
        {
            //o número 200 que está entre entre base() significa
            //a velocidade Maxiam que foi herdada de carro usamos
            //base para não precisar fazer o construtor novamente
            public Uno() : base(200)
            {

            }
        }

        public class Ferrari : Carro
        {
            public Ferrari() : base(100)
            {

            }
        }

        public static void Executar()
        {
            Console.WriteLine("Uno...");

            Uno carro1 = new Uno();

            Console.WriteLine(carro1.Acelera());
            Console.WriteLine(carro1.Acelera());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");

            Ferrari carro2 = new Ferrari();

            Console.WriteLine(carro2.Acelera());
            Console.WriteLine(carro2.Acelera());
            Console.WriteLine(carro1.Frear());

        }
    }
}
