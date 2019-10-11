using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }public class CPonto {
        public int X;
        public int Y;
    }
    class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto copiaPonto1 = ponto1; //Struct -> Atribuição por valor !!!
            ponto1.X = 3;

            Console.WriteLine("Ponto1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto1 X:{0}", copiaPonto1.X);


            CPonto ponto2 = new CPonto { X = 2, Y = 4 };
            CPonto copiaPonto2 = ponto2; //Class -> Atribuição por Referencia !!! -> aponta para o mesmo local de memória.
            ponto2.X = 4;
            Console.WriteLine("Ponto2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto2 X:{0}", copiaPonto2.X);
        }
    }
}
