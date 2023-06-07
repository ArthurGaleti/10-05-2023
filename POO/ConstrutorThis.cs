using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class ConstrutorThis
    {
        public class Animal 
        {
            public string Nome;

            public Animal(string nome)
            {
                Nome = nome;
            }
        }

        public class Cachorro : Animal
        {
            public double Altura { get; set; }

            public Cachorro(string nome) : base(nome)
            {
                Console.WriteLine($"Cachorro {nome} foi iniciazado");
            }

            /*
             aqui, estou usando this para chamar o construtor(nome)
             da própria classe que é do cachorro, porém esse nome
             foi pego da herança de animal
             */
            public Cachorro(string nome, double altura) : this(nome)
            {
                Altura = altura;
            }

            //corverte para string
            public override string ToString()
            {
                return $"{Nome} tem {Altura} cm de altura.";
            }
        }

        public static void Executar()
        {
            var w = new Cachorro("Wandebas");
            var max = new Cachorro("Max", 1.40);
        }
    }
}
