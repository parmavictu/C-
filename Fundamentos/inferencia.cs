using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class inferencia
    {
        public static void Executar()
        {
            var nome = "Leonardo"; // ja define o tipo sozinho
            Console.WriteLine(nome);

            var idade = 32;
            Console.WriteLine(idade);
            //OUTRO MODO DE DECLARAR
            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
        }
    }
}
