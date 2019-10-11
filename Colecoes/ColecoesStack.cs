using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack();//Stack ao contrario de queue, stack remove o ultimo adicionado

            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(3.14f);

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");//pop tira o ultimo e pega ele

            foreach (var item in pilha)
            {
                Console.WriteLine($"{item} ");
            }
            Console.WriteLine($"\nPeek: {pilha.Peek()}");//vai pegar mas n vai remover da pilha
        }
    }
}
