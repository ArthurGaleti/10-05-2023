using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class GetSetExercios
    {

        public class Pessoa
        {
            private string nome;
            private double altura;
            private int idade;

            public string Nome
            {
                get
                {
                    return nome;
                }
                set
                {
                    nome = value;
                }
            }

            public double Altura
            {
                get
                {
                    return altura;
                }
                set
                {
                    altura = value;
                }
            }

            public int Idade
            {
                get
                {
                    return idade;
                }

                set
                {
                    idade = value;
                }
            }


            public Pessoa(string nome, double altura, int idade)
            {
                Nome = nome;
                Altura = altura;
                Idade = idade;
            }

        }


        public class Nota
        {
            private double n1;
            private double n2;
            private double n3;

            public double Media
            {
                get 
                {
                    return (n1+n2+n3)/3;
                }

                set
                {
                    n1 = value;
                    n2 = value;
                    n3 = value;
                }

            }
          

            public Nota(double n1, double n2, double n3){
                this.n1 = n1;
                this.n2 = n2;
                this.n3 = n3;
            }

        }

        public class Animais
        {
            string animal;
            string tipo;

            public string Animal
            {
                get
                {
                    return animal;
                }

                set
                {
                    animal = value;
                }
            }

            public string Tipo
            {
                get
                {
                    return tipo;
                }

                set
                {
                    tipo = value;
                }
            }

            public Animais(string animal, string tipo)
            {
                Animal = animal;
                Tipo = tipo;
            }

        }



        public static void Executar()
        {
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 1");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            
            var pes1 = new Pessoa("Arthur", 1.70, 2004);

            Console.WriteLine($"Nome: {pes1.Nome}/Idade: {2023 - pes1.Idade}/Altura: {pes1.Altura}.");


            Console.WriteLine("");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 2");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");


            var media = new Nota(3.3, 7.2, 5.5);
            Console.WriteLine($"Média: {media.Media.ToString("#.#")}");


            Console.WriteLine("");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 3");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            Console.WriteLine("Qual o nome do animal?");
            string ani = Console.ReadLine();

            Console.WriteLine("Qual seu tipo?(por gentileza digitar em letras minúsculas)");
            string tip = Console.ReadLine();


            var animal = new Animais(ani, tip);

            switch (tip)
            {
                case "cachorro":
                    Console.WriteLine($"Nome: {animal.Animal}, é um(a) {animal.Tipo} ");
                    Console.WriteLine("Características dos cachorros:");
                    Console.WriteLine("-peludos");
                    Console.WriteLine("-quadrupedes");
                    Console.WriteLine("-fucinho grande");
                    break;

                case "gato":
                    Console.WriteLine($"Nome: {animal.Animal}, é um {animal.Tipo} ");
                    Console.WriteLine("Características dos gatos:");
                    Console.WriteLine("-peludos");
                    Console.WriteLine("-quadrupedes");
                    Console.WriteLine("-grandes reflexos");
                    break;

                case "ave":
                    Console.WriteLine($"Nome: {animal.Animal}, é um {animal.Tipo} ");
                    Console.WriteLine("Características das aves:");
                    Console.WriteLine("-contém penas");
                    Console.WriteLine("-bípede");
                    Console.WriteLine("-contém bico");
                    break;

                case "Cachorro":
                    Console.WriteLine($"Nome: {animal.Animal}, é um {animal.Tipo} ");
                    Console.WriteLine("Características dos cachorros:");
                    Console.WriteLine("-peludos");
                    Console.WriteLine("-quadrupedes");
                    Console.WriteLine("-fucinho grande");
                    break;

                case "Gato":
                    Console.WriteLine($"Nome: {animal.Animal}, é um {animal.Tipo} ");
                    Console.WriteLine("Características dos gatos:");
                    Console.WriteLine("-peludos");
                    Console.WriteLine("-quadrupedes");
                    Console.WriteLine("-grandes reflexos");
                    break;

                case "Ave":
                    Console.WriteLine($"Nome: {animal.Animal}, é um {animal.Tipo} ");
                    Console.WriteLine("Características das aves:");
                    Console.WriteLine("-contém penas");
                    Console.WriteLine("-bípede");
                    Console.WriteLine("-contém bico");
                    break;


            }


        }
    }
}
