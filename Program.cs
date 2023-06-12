using System;
using System.Collections.Generic;
using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.POO;


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
                {"Estrutura While e For - Estrutura de Controle",WhileEForm.Executar},
                {"Estrutura de Repetição - Estrutura de Controle",EstruturaRepeticao.Executar},
                {"Estrutura For It - Estrutura de Controle",EstruturaForeach.Executar},


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

                //classes e métodos
                {"Membros - Classes e Métodos",Membros.Executar},
                {"Construtores - Classes e Métodos",Construtores.Executar},
                {"Métodos com Retorno - Classes e Métodos",MetodosComRetorno.Executar},
                {"Dolar e Temperatura - Classes e métodos",DolarETemperatura.Executar},
                {"Métodos Estáticos - Classes e métodos",MetodosEstaticos.Executar},
                {"Param - Classes e métodos",Params.Executar},
                {"GetSet - Classes e métodos",GetSet.Executar},
                {"GetSet exemplo 2- Classes e métodos",GetSet2.Executar},
                {"GetSet exercícios- Classes e métodos",GetSetExercios.Executar},

                //coleções
                {"Array - Coleções",Arrays.Executar},
                {"Coleções Queque - Coleções",ColecoesQueue.Executar},
                {"stack - Cloleções",ColecoesStack.Executar},

                //POO
                {"herança - POO",heranca.Executar},
                {"Construtor This - POO",ConstrutorThis.Executar},
                {"Encapsulamento - POO", POO.Encapsulamento.Executar},
                



            }) ;

            central.SelecionarEExecutar();
        }
    }
}