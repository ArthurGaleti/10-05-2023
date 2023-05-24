using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class cliente
    {
        public string Nome;
        public string Cpf;
        public string Sexo;
        public string Endereco;
        public int Idade;

            public cliente(string nome, string cpf, string sexo, string endereco, int idade)
            {
            Nome = nome;
            Cpf = cpf;
            Sexo = sexo;
            Endereco = endereco;
            Idade = idade;
            }

        public cliente()
        {

        }

    }

    //construtor personalizado
    
    class Construtores
    {


        public static void Executar()
        {
            var cliente1 = new cliente(); //new cliente = construtor padão(não recebe parametros)

            cliente1.Nome = "Wandebas";
            cliente1.Cpf = "21847183856";
            cliente1.Sexo = "M";
            cliente1.Endereco = "Onde Judas Perdeu as Botas N° 15";
            cliente1.Idade = 200;

            //chamade do construtor
            var cliente2 = new cliente("carlos", "1234", "F", "dandanan", 33);

            var cliente3 = new cliente()
            {
                Nome = "maria",
                Sexo = "F",
                Endereco = "amaral wagner",
                Idade = 99
            };

            Console.WriteLine($" Ola {cliente1.Nome}, você tem {cliente1.Idade} anos.");
        }
    }
}
