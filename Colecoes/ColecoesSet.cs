using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
   

    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);//adicionar uma coisa da lista

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("Game of thrones", 99.9),
                new Produto("Poster", 10),
            };

            carrinho.UnionWith(combo);//para adicionar um set a outro
            Console.WriteLine(carrinho.Count);//mostra o tamanho
            
            //Não da fazer coisa que envolveo  index pq o set não tem e não aceita repetição
            foreach (var item in carrinho)
            {
                
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            
            //lista aceita repetição
        }
    }
}
