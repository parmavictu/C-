using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string entrada;
            do
            {
                Console.WriteLine("Qual seu nome? ");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem-vindo {entrada}");
                Console.WriteLine($"Deseja continuar? ");
                entrada = Console.ReadLine();

            } while (entrada.ToLower() == "s");
        }
    }
}
