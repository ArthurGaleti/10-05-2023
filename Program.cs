using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {

                //estrutura de controle

                {"Estrutura If - Estrutura de Controle",EstruturaIf.Executar},
                {"Estrutura Switch - Estrutura de Controle",EstruturaSwitch.Executar},


                //fundamentos

                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Variaveis e Constantes - Fundamentos",VariaveisEConstantes.Executar },
                {"Notação Ponto - Fundamentos ",NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos",LendoDados.Executar },
                {"Formatando Números - Fundamentos ",FormatandoNumeros.Executar},
                {"Operadores Aritimeticos - Fundamentos ",OperadoresAritimeticos.Executar},
                {"Exercícios Operadores - Fundamentos",ExerciciosOperadores.Executar},
                {"Operadores Relacionais - Fundamentos ",OperadoresRelacionais.Executar},
                {"Operadores Atribuição - Fundamentos ",OperadoresAtribuicao.Executar},
                {"If Else - Fundamentos",IfElse.Executar},
                {"Estrutura While e For - Estrutura de Controle",WhileEForm.Executar},



            }) ;

            central.SelecionarEExecutar();
        }
    }
}