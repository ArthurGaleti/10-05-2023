using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class IfElse
    {
        public static void Executar()
        {

            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 1");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            Console.WriteLine("Digite seu ano de nascimento:");
            int idade = int.Parse(Console.ReadLine());

            idade = 2023 - idade;

            if (idade >= 18 && idade <= 70) {
                Console.WriteLine($"Você tem {idade} anos, seu voto é obrigatório!");
            }else{
                Console.WriteLine($"Você tem {idade} anos, voê ainda não é obrigado a votar.");
            }

            Console.WriteLine("");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 2");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");


            var senha = "1234";

            Console.WriteLine("Digite sua senha:");
            var conf = Console.ReadLine();

            if (conf == senha){
                Console.WriteLine("Senha correta.");
            }else{
                Console.WriteLine("Senha errada.");
            }

            Console.WriteLine("");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 3");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");


            Console.WriteLine("Informe a 1° nota:");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 2° nota:");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a 3° nota:");
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if (media  >= 7.0){
                Console.WriteLine("Você passou");
            }else if (media < 7 && media >= 5){
                Console.WriteLine("Esta de recuperação");
            }else{
                Console.WriteLine("Você reprovou");
            }

            Console.WriteLine("");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 4");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");


            Console.WriteLine("Informe seu peso");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("informe sua altura");
            double alt = double.Parse(Console.ReadLine());

            double imc = peso / (alt * alt);

            if (imc < 18.5) {
                Console.WriteLine("Você esta abaixo do peso");
            } else if (imc >= 18.5 && imc < 24.9) {
                Console.WriteLine("Você esta dentro do peso");
            } else if (imc >= 24.9 && imc < 29.9) {
                Console.WriteLine("Você está acima do peso");
            } else if (imc >= 29.9 && imc < 34.9){
                Console.WriteLine("Você está com obesidade I");
            } else if (imc >= 34.9 && imc < 39.9){
                Console.WriteLine("Você está com obesidade II");
            } else{
                Console.WriteLine("Você está com obesidade III");
            }

           


        }
    }
}
