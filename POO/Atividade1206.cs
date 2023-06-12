using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.POO
{
    class Atividade1206
    {

        public class Pessoa
        {
            public string Nome;
            public int Idade;
            public string Cpf;
            public string Cnpj;

            public Pessoa(string nome, int idade)
            {
                Nome = nome;
                Idade = idade;
            }

            public Pessoa() { }
        }

        public class Fisico : Pessoa 
        {
            public Fisico(string cpf)
            {
                Cpf = cpf;
            }
        }
        public class Juridico : Pessoa 
        {
            public Juridico(string cnpj)
            {
                Cnpj = cnpj;
            }
        }


        public static void Executar()
        {

            Console.WriteLine("Iniforme seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, idade);
           

            Console.WriteLine("Qual tipo de cliente você é? (digite 1 para físico, digite 2 para jurídico)");
            int tipo = int.Parse(Console.ReadLine());

            if(tipo == 1)
            {
                Console.WriteLine("Informe um cpf:");
                string cpf = Console.ReadLine();

                Fisico fisico = new Fisico(cpf);

                

                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Cpf: {fisico.Cpf}");

            }else if(tipo == 2)
            {
                Console.WriteLine("Informe no cnpj");
                string cnpj = Console.ReadLine();

                Juridico juridico = new Juridico(cnpj);

                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Cnpj: {juridico.Cnpj}");
            }
            else
            {
                Console.WriteLine("!Cliente Invalido!");
            }

        }
    }
}
