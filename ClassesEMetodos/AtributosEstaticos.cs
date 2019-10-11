using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            
        }


        public Produto() {

        }

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }






    class AtributosEstaticos {
        public static void Executar() {
            var produto1 = new Produto("Caneta", 3.2);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3
            };
            Produto.Desconto = 0.5;// Atributo estatico é qnd é para a classe, então todas as instancias vai ter esse valor de atributo
            Console.WriteLine($"Preço com desconto: {produto1.CalcularDesconto()}");
            Console.WriteLine($"Preço com desconto: {produto2.CalcularDesconto()}");
        }
    }
}
