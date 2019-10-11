using System;
using System.Collections.Generic;
using System.Text;
       
namespace CursoCSharp.Exercicios {
    class ex3 {
        public static void Executar() {

            Console.Write("Digite o número: ");
            int.TryParse(Console.ReadLine(), out int x);

            int count = 10;
            int soma = 0;
            int b = 1;

            while (count < x){
                count = count * 10;
            }

            count = count / 10;

            for(int a =10; a<x; a *= 10){
                if (a == 10){
                    soma += x % a * count;
                }else {
                    soma += (x % a - (x % (a / 10))) / b * count;
                }
                count /= 10;
                b *= 10;
            }

            soma += (x - x % b) / b;
            Console.WriteLine(soma);

        }

    }
}
