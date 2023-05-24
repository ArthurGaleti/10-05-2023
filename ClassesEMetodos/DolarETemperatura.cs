using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DolarETemperatura
    {
        public double Dolar(double real)
        {
            return real / 4.95;
        }

        public double Fahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public static void Executar()
        {

            var det = new DolarETemperatura();



            Console.WriteLine("Informe a quantidade de reais");
            double real = double.Parse(Console.ReadLine());

            double valor = det.Dolar(real);

            Console.WriteLine($"${valor.ToString("#.##")}");

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Informe a temperatura para ser convertida de célsius para fahrenheit:");
            double celsius = double.Parse(Console.ReadLine());

            double far = det.Fahrenheit(celsius);

            Console.WriteLine($"{far.ToString("#.##")}°F");
            
        }
    }
}
