using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("A", 1);
            var p2 = new Produto("A", 1);
            var p3 = p2;

            Console.WriteLine(p1 == p2);//da falso pq estão apontando para locais diferentes de memoria
            Console.WriteLine(p3 == p2);//true pq as duas apontam para o mesmo lugar na memoria

            Console.WriteLine(p1.Equals(p2));//Equals é para comparar o valor, mas antes tem que ir la na instancia e fazer uma mudança
        }
    }
}
