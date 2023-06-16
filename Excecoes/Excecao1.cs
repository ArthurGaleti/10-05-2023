using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Excecoes
{
    class Excecao1
    {

        public class conta
        {
            private double Saldo;

            public conta(double saldo)
            {
                Saldo = saldo;
            }

            public void Sacar(double valor)
            {
                if (valor > Saldo)
                {
                    throw new ArgumentException("Saldo Insuficiente");
                }
                Saldo -= valor;
                /*
                 se o usuario sacar um valor menor que o saldo
                então só subtraimos o valor da conta dele
                 */
            }
        }

        


        public static void Executar()
        {
            var conta = new conta(1000);

            try
            {

                //tentativa de savar, se der certo será retirado
                conta.Sacar(500);
                Console.WriteLine("Valor retitado com sucesso");
            }
            catch(Exception ex)
            {
                //receber a exceção(erro) lançado
                Console.WriteLine(ex.Message);
            }
            finally
            {

                //o finally é usado em qualquer situação
                Console.WriteLine("Obrigado");
            }
        }
    }
}
