using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    interface OperacaoBinaria {//Interface é uam estrutura onde todos os metodos sao abstratos e publicos
        int Operacao(int a, int b);//Não precisa por public nem abstract pq já sao ambas por padrao
    }
    interface Teste {//Podemos fazer uma interface herdar de outra interface também
        bool bla(string teste);
    }
    class Soma : OperacaoBinaria,Teste {//Uma classe pode herdar varias interface e apenas uma classe
        public int Operacao(int a, int b) {//Só pode ser public
            return a + b;
        }

        public bool bla(string teste) {
            return true;
        }
    }
    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao()

        };
        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";


            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a,b)}";
            }

            return resultado;
        }
    }
    class Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
