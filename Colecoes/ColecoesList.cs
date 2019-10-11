using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        //Ctrl+ . -> se usar isso e clicar na classe aparece varias opções de gerar o construtor, hashcode e equals sozinho
        public override bool Equals(object obj) {//ISSO AQUI FAZEMOS PARA QUANDO FORMOS COMPARAR O VALOR DE 2 INSTANCIAS ELE COMPARAR O VALOR E N LOCAL DE MEMORIA
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {//Serve para filtrar os elementos para deixar o equals mais rapido
            return HashCode.Combine(Nome, Preco);
            //hashcode tbm impede de criar 2 listas iguais
        }



        

    }

    class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);//adicionar uma coisa da lista

            var combo = new List<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Game of thrones", 99.9),
                new Produto("Poster", 10),
            };

            carrinho.AddRange(combo);//para adicionar todas da lista
            Console.WriteLine(carrinho.Count);//mostra o tamanho
            carrinho.RemoveAt(3);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            
            //lista aceita repetição
        }
    }
}
