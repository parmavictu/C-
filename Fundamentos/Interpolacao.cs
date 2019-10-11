using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Interpolacao
    {
        public static void Executar()
        {
            string nome = "Notebook";
            string marca = "dell";
            double preco = 5800.00;

            Console.WriteLine("O {0} da marca {1} custa {2}", nome, marca, preco);
            Console.WriteLine($"A marca {marca} é legal!!");
        }
    }
}
