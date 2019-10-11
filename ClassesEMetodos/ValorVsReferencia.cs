using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ValorVsReferencia {

        public class Dependente {
            public string Nome;
            public int Idade;
        }

        public static void Executar() {
            int numero = 3;
            //Cópia por valor
            int copiaNumero = numero;
            Console.WriteLine($"{numero} {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumero}");


            Dependente dep = new Dependente
            {
                Nome = "Beto",
                Idade = 20
            };
            //Essa copia por referencia se muda um muda outro, porque aponta para a mesma paarte da memória
            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

        }
    }
}
