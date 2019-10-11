using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++;
            b--;

            Console.WriteLine($"{a} {b}");

            //coisa que vou aprender dps -> atribuindo uma variavel a outra e qnd muda uma muda outra
            dynamic c = new System.Dynamic.ExpandoObject();

            c.nome = "João";

            dynamic d = c;
            d.nome = "maria";

            Console.WriteLine(c.nome);
        }
    }
}
