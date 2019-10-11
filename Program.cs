using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;
using CursoCSharp.Exercicios;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"inferencia - Fundamentos", inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando numeros - Fundamentos", FormatandoNumero.Executar},
                {"Conversoes- Fundamentos", Conversoes.Executar},
                {"Operadores Aritmeticos- Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais- Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos- Fundamentos", OperadoresLogicos.Executar},
                {"Operadores De Atribuição- Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios- Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternario- Fundamentos", OperadorTernario.Executar},

                {"Estrutura If- EstruturaDeControle", EstruturaIf.Executar},
                {"Estrutura If/Else- EstruturaDeControle", EstruturaIfElse.Executar},
                {"Estrutura If/Else If- EstruturaDeControle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch- EstruturaDeControle", EstruturaSwitch.Executar},
                {"Estrutura While- EstruturaDeControle", EstruturaWhile.Executar},
                {"Estrutura DoWhile- EstruturaDeControle", EstruturaDoWhile.Executar},
                {"Estrutura For- EstruturaDeControle", EstruturaFor.Executar},
                {"Estrutura ForEach- EstruturaDeControle", EstruturaForEach.Executar},
                {"Usando Break- EstruturaDeControle", UsandoBreak.Executar},
                {"Usando Continue- EstruturaDeControle", UsandoContinue.Executar},

                {"Membros- ClassesEMetodos", Membros.Executar},
                {"Construtores- ClassesEMetodos", Construtores.Executar},
                {"Metodos Com Retorno- ClassesEMetodos", MetodosComRetorno.Executar},
                {"Metodos estaticos- ClassesEMetodos", MetodosEstaticos.Executar},
                {"Atributos estaticos- ClassesEMetodos", AtributosEstaticos.Executar},
                {"Desafio atributo- ClassesEMetodos", DesafioAtributo.Executar},
                {"Params- ClassesEMetodos", Params.Executar},
                {"Parametros Nomeados- ClassesEMetodos", ParametrosNomeados.Executar},
                {"Props- ClassesEMetodos", Props.Executar},
                {"ReadOnly- ClassesEMetodos", ReadOnly.Executar},
                {"Enum- ClassesEMetodos", ExemploEnum.Executar},
                {"Struct- ClassesEMetodos", ExemploStruct.Executar},
                {"Struct Vs Class- ClassesEMetodos", StructVsClasse.Executar},
                {"Valor Vs Referência- ClassesEMetodos", ValorVsReferencia.Executar},
                {"Parametros por referência- ClassesEMetodos", ParametrosPorReferencia.Executar},
                {"Parametros Padrao- ClassesEMetodos", ParametroPadrao.Executar},

                {"Array - Coleções", Colecoes.Array.Executar},
                {"Lista - Coleções", ColecoesList.Executar},
                {"ArrayLista - Coleções", ColecoesArrayLista.Executar},
                {"Set - Coleções", ColecoesSet.Executar},
                {"Queue - Coleções", ColecoesQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", ColecoesStack.Executar},
                {"Dicionario - Coleções", ColecoesDictionary.Executar},


                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo- OO", OO.Polimorfismo.Executar},
                {"Classe Abstract- OO", OO.Abstract.Executar},
                {"Interface- OO", OO.Interface.Executar},
                {"Sealed- OO", Sealed.Executar},

                {"ExemploLambda- Metodos e funções", ExemploLambda.Executar},
                {"Lambda com delegate- Metodos e funções", LambdasDelegate.Executar},
                {"Usando Delegates- Metodos e funções", UsandoDelegates.Executar},
                {"Delegates com funcões anonimas- Metodos e funções", DelegateFunAnonima.Executar},
                {"Delegates como parametros- Metodos e funções", DelegatesComoParametros.Executar},
                {"Metodos de Extensao- Metodos e funções", MetodosDeExtensao.Executar},

                {"Primeira Excecao - Excecões", PrimeiraExcecao.Executar},
                {" Excecoes Personalizadas - Excecões", ExcecoesPersonalizadas.Executar},

                {"Primeiro Arquivo - Usando API", PrimeiroArquivo.Executar},
                {"Lendo Arquivo - Usando API", LendoArquivos.Executar},
                {"Exemplo FileInfo - Usando API", ExemploFileInfo.Executar},
                {"Diretórios - Usando API", Diretorios.Executar},
                {"Diretórios info - Usando API", ExemploDirectoryInfo.Executar},
                {"Exemplo Path - Usando API", ExemploPath.Executar},
                {"Exemplo DateTime  - Usando API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - Usando API", ExemploTimeSpan.Executar},

                {"LINK1 - Topicos Avançados", LINK1.Executar},
                {"LINK2 - Topicos Avançados", LINK2.Executar},
                {"Nullable - Topicos Avançados", TopicosAvancados.Nullable.Executar},
                {"Dynamics - Topicos Avançados", Dynamics.Executar},
                {"Generics - Topicos Avançados", Genericos.Executar},

                {"Exercicios", ex1.Executar},
                {"Exercicios2", ex2.Executar},
                {"Exercicios3", ex3.Executar},
                {"Exercicios4", ex4.Executar},
                {"Exercicios5", ex5.Executar},
                {"Exercicios6", ex6.Executar},
                {"Exercicios7", ex7.Executar},
                {"Exercicios8", ex8.Executar},
                {"Exercicios9", ex9.Executar},
            });

            central.SelecionarEExecutar();

        }
    }
}