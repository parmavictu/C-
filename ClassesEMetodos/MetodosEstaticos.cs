using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CalculadoraEstatica {
        public static int Multiplicar(int a, int b) {//Com static n precisa criar instancia vc pode acessar direto na classe, assim só podendo os mesmos dados
            return a * b;
        }
        public  int Somar(int a, int b) {//aqui vc precisa de uma instancia
            return a + b;
        }
    }



    class MetodosEstaticos {
        public static void  Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);// static -> n precisa instanciar
            Console.WriteLine("Resultado {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();//esse é o não estatico, qnd vc pode ter varias instancias
            Console.WriteLine(calc.Somar(2, 2));
            

        }
    }
}
