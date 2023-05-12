using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class ExerciciosOperadores
    {
        public static void Executar()
        {

            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 1");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            Console.WriteLine("Escreva a 1° nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escrva a 2° nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a 3° nota:");
            double nota3 = double.Parse(Console.ReadLine());

            double m1 = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("");

            Console.WriteLine("Notas:");
            Console.WriteLine($"1° nota:{nota1}");
            Console.WriteLine($"2° nota:{nota2}");
            Console.WriteLine($"3° nota:{nota3}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"A média do aluno é {m1.ToString("#.##")}!");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("Atividade 2");
            Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            Console.WriteLine("");

            Console.WriteLine("Escreva a 1° nota:");
            double nota4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escrva a 2° nota:");
            double nota5 = double.Parse(Console.ReadLine());

            double m2 = (nota4 * 3.5 + nota5 * 7.5) / 11;
            

            Console.WriteLine("Notas:");
            Console.WriteLine($"1° nota:{nota4}");
            Console.WriteLine($"2° nota:{nota5}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"A média do aluno é {m2.ToString("#.##")}!");
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("");
                Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
                Console.WriteLine("Atividade 3");
                Console.WriteLine("//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//-//");
            Console.WriteLine("");

            Console.WriteLine("Digide o código do(a) funcionário(a):");
            int codig = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de horas trabalhadas");
            int horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe Qanto ganham por hora");
            double ganho = double.Parse(Console.ReadLine());

            double salar = ganho * horas;

            Console.WriteLine($"Código do Funcionário: {codig}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Salário: {salar.ToString("#.##")}!");
            Console.WriteLine("-----------------------------------");

        }
    }
}
