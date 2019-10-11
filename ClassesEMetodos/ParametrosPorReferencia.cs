using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {



        public static void AlterarRef(ref int numero) {
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) {
            numero = 0;
            numero = numero + 15;
        }

        public static void Executar() {
            int a = 3;//ref tem que a variavel inicializada
            AlterarRef(ref a);//passei como referencia por isso o a foi alterado
            Console.WriteLine(a);


            //int b;
            AlterarOut(out int b);//o out gera uma variavel de saida, só tem uma direção _> melhor usar out
            Console.WriteLine(b);
        }
    }
}
